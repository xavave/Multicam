using AForge.Video.DirectShow;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace TwoCamerasTest
{
    public partial class FormFullCam : Form
    {
        public FormFullCam(VideoCaptureDevice vcd)
        {
            InitializeComponent();
            vspFull.VideoSource = vcd;
            vspFull.Start();
        }

    }
}
