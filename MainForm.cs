// Two Cameras Test sample application
// AForge.NET framework
// http://www.aforgenet.com/framework/
//
// Copyright © AForge.NET, 2006-2011
// contacts@aforgenet.com
//

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Diagnostics;

using AForge.Video;
using AForge.Video.DirectShow;
using TwoCamerasTest;

namespace ThreeCamerasTest
{
    public partial class MainForm : Form
    {
        // list of video devices
        FilterInfoCollection videoDevices;
        // stop watch for measuring fps
        private Stopwatch stopWatch = null;

        VideoCaptureDevice videoSource1 = null;
        VideoCaptureDevice videoSource2 = null;
        VideoCaptureDevice videoSource3 = null;

        public MainForm()
        {
            InitializeComponent();

            camera1FpsLabel.Text = string.Empty;
            camera2FpsLabel.Text = string.Empty;
            camera3FpsLabel.Text = string.Empty;


            // show device list
            try
            {
                // enumerate video devices
                videoDevices = new FilterInfoCollection(FilterCategory.VideoInputDevice);

                if (videoDevices.Count == 0)
                {
                    throw new Exception();
                }


                for (int i = 1, n = videoDevices.Count; i <= n; i++)
                {
                    string cameraName = i + " : " + videoDevices[i - 1].Name;

                    camera1Combo.Items.Add(cameraName);
                    camera2Combo.Items.Add(cameraName);
                    camera3Combo.Items.Add(cameraName);
                }

                // check cameras count
                if (videoDevices.Count == 1)
                {
                    camera2Combo.Items.Clear();

                    camera2Combo.Items.Add("Only one camera found");
                    camera2Combo.SelectedIndex = 0;
                    camera2Combo.Enabled = false;

                    camera3Combo.Items.Clear();

                    camera3Combo.Items.Add("Only one camera found");
                    camera3Combo.SelectedIndex = 0;
                    camera3Combo.Enabled = false;

                }
                else if (videoDevices.Count == 2)
                {
                    camera2Combo.SelectedIndex = 1;
                    camera3Combo.Items.Clear();
                    camera3Combo.Items.Add("Only two cameras found");
                    camera3Combo.SelectedIndex = 0;
                    camera3Combo.Enabled = false;
                   
                 
                }
                else if (videoDevices.Count == 3)
                {
                    camera3Combo.SelectedIndex = 1;
                   
                }
                camera1Combo.SelectedIndex = 0;
            }
            catch
            {
                startButton.Enabled = false;

                camera1Combo.Items.Add("No cameras found");
                camera2Combo.Items.Add("No cameras found");
                camera3Combo.Items.Add("No cameras found");

                camera1Combo.SelectedIndex = 0;
                camera2Combo.SelectedIndex = 0;
                camera3Combo.SelectedIndex = 0;

                camera1Combo.Enabled = false;
                camera2Combo.Enabled = false;
                camera3Combo.Enabled = false;
            }
        }

        // On form closing
        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            StopCameras();
        }

        // On "Start" button click
        private void startButton_Click(object sender, EventArgs e)
        {
            StartCameras();

            startButton.Enabled = false;
            stopButton.Enabled = true;
        }

        // On "Stop" button click
        private void stopButton_Click(object sender, EventArgs e)
        {
            StopCameras();

            startButton.Enabled = true;
            stopButton.Enabled = false;
            btnOpenNew1.Visible = btnOpenNew2.Visible = btnOpenNew3.Visible = false;
            camera1FpsLabel.Text = string.Empty;
            camera2FpsLabel.Text = string.Empty;
            camera3FpsLabel.Text = string.Empty;
        }

        // Start cameras
        private void StartCameras()
        {
            // create first video source
            videoSource1 = new VideoCaptureDevice(videoDevices[camera1Combo.SelectedIndex].MonikerString);
            videoSource1.ProvideSnapshots = true;
            videoSource1.SnapshotFrame += VideoSource_SnapshotFrame;
            btnPhoto1.Enabled = btnOpenNew1.Visible = true;
            videoSourcePlayer1.VideoSource = videoSource1;
            videoSourcePlayer1.Start();

            // create second video source
            if (camera2Combo.Enabled == true)
            {
                System.Threading.Thread.Sleep(500);
                videoSource2 = new VideoCaptureDevice(videoDevices[camera2Combo.SelectedIndex].MonikerString);
                videoSource2.ProvideSnapshots = true;
                videoSource2.SnapshotFrame += new NewFrameEventHandler(VideoSource_SnapshotFrame);
                btnPhoto2.Enabled = btnOpenNew2.Visible = true;

                videoSourcePlayer2.VideoSource = videoSource2;
                videoSourcePlayer2.Start();
            }
            if (camera3Combo.Enabled == true)
            {
                System.Threading.Thread.Sleep(500);

                videoSource3 = new VideoCaptureDevice(videoDevices[camera3Combo.SelectedIndex].MonikerString);
                videoSource3.ProvideSnapshots = true;
                videoSource3.SnapshotFrame += new NewFrameEventHandler(VideoSource_SnapshotFrame);
                btnPhoto3.Enabled = btnOpenNew3.Visible = true;

                videoSourcePlayer3.VideoSource = videoSource3;
                videoSourcePlayer3.Start();
            }
            // reset stop watch
            stopWatch = null;
            // start timer
            timer.Start();
        }

        private void VideoSource_SnapshotFrame(object sender, NewFrameEventArgs eventArgs)
        {

        }

        private void SaveImage(Image img)
        {
            saveFileDialog1.FileName += "_" + DateTime.Now.ToString("yyyyMMdd_HHmmss");
            var ret = saveFileDialog1.ShowDialog();
            if (ret == DialogResult.OK)
            {
                img.Save(saveFileDialog1.FileName);
                img.Dispose();
            }
        }

        // Stop cameras
        private void StopCameras()
        {
            timer.Stop();

            videoSourcePlayer1.SignalToStop();
            videoSourcePlayer2.SignalToStop();
            videoSourcePlayer3.SignalToStop();
            btnPhoto1.Enabled = false;
            btnPhoto2.Enabled = false;
            btnPhoto3.Enabled = false;
            videoSourcePlayer1.WaitForStop();
            videoSourcePlayer2.WaitForStop();
            videoSourcePlayer3.WaitForStop();
        }

        // On times tick - collect statistics
        private void timer_Tick(object sender, EventArgs e)
        {
            IVideoSource videoSource1 = videoSourcePlayer1.VideoSource;
            IVideoSource videoSource2 = videoSourcePlayer2.VideoSource;
            IVideoSource videoSource3 = videoSourcePlayer3.VideoSource;

            int framesReceived1 = 0;
            int framesReceived2 = 0;
            int framesReceived3 = 0;

            // get number of frames for the last second
            if (videoSource1 != null)
            {
                framesReceived1 = videoSource1.FramesReceived;
            }

            if (videoSource2 != null)
            {
                framesReceived2 = videoSource2.FramesReceived;
            }
            if (videoSource3 != null)
            {
                framesReceived3 = videoSource3.FramesReceived;
            }
            if (stopWatch == null)
            {
                stopWatch = new Stopwatch();
                stopWatch.Start();
            }
            else
            {
                stopWatch.Stop();

                float fps1 = 1000.0f * framesReceived1 / stopWatch.ElapsedMilliseconds;
                float fps2 = 1000.0f * framesReceived2 / stopWatch.ElapsedMilliseconds;
                float fps3 = 1000.0f * framesReceived3 / stopWatch.ElapsedMilliseconds;

                camera1FpsLabel.Text = fps1.ToString("F2") + " fps";
                camera2FpsLabel.Text = fps2.ToString("F2") + " fps";
                camera3FpsLabel.Text = fps3.ToString("F2") + " fps";

                stopWatch.Reset();
                stopWatch.Start();
            }
        }

        private void btnPhoto1_Click(object sender, EventArgs e)
        {
            TakeSnapshot(1);
        }

        private void TakeSnapshot(int camNumber)
        {
            Image img = null;
            switch (camNumber)
            {
                case 1:
                    pictureBox1.Image = Image.FromHbitmap(videoSourcePlayer1.GetCurrentVideoFrame().GetHbitmap());
                    img = pictureBox1.Image;
                    btnSave1.Visible = true;
                    break;
                case 2:
                    pictureBox2.Image = Image.FromHbitmap(videoSourcePlayer2.GetCurrentVideoFrame().GetHbitmap());
                    img = pictureBox2.Image;
                    btnSave2.Visible = true;

                    break;
                case 3:
                    pictureBox3.Image = Image.FromHbitmap(videoSourcePlayer3.GetCurrentVideoFrame().GetHbitmap());
                    img = pictureBox2.Image;
                    btnSave3.Visible = true;

                    break;
            }

        }

        private void btnPhoto2_Click(object sender, EventArgs e)
        {
            TakeSnapshot(2);
        }

        private void btnPhoto3_Click(object sender, EventArgs e)
        {
            TakeSnapshot(3);
        }

        private void btnSave1_Click(object sender, EventArgs e)
        {
            SaveImage(pictureBox1.Image);
        }

        private void btnSave2_Click(object sender, EventArgs e)
        {
            SaveImage(pictureBox2.Image);
        }

        private void btnSave3_Click(object sender, EventArgs e)
        {
            SaveImage(pictureBox3.Image);
        }

        private void btnOpenNew1_Click(object sender, EventArgs e)
        {
            var f = new FormFullCam(videoSource1);
            f.Show();
            
        }

        private void btnOpenNew2_Click(object sender, EventArgs e)
        {
            var f = new FormFullCam(videoSource2);
            f.Show();
        }

        private void btnOpenNew3_Click(object sender, EventArgs e)
        {
            var f = new FormFullCam(videoSource3);
            f.Show();
        }
    }

}
