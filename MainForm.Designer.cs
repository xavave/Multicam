namespace ThreeCamerasTest
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose( bool disposing )
        {
            if ( disposing && ( components != null ) )
            {
                components.Dispose( );
            }
            base.Dispose( disposing );
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent( )
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.videoSourcePlayer1 = new AForge.Controls.VideoSourcePlayer();
            this.videoSourcePlayer2 = new AForge.Controls.VideoSourcePlayer();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.camera1FpsLabel = new System.Windows.Forms.Label();
            this.camera1Combo = new System.Windows.Forms.ComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.camera2FpsLabel = new System.Windows.Forms.Label();
            this.camera2Combo = new System.Windows.Forms.ComboBox();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.camera3FpsLabel = new System.Windows.Forms.Label();
            this.camera3Combo = new System.Windows.Forms.ComboBox();
            this.videoSourcePlayer3 = new AForge.Controls.VideoSourcePlayer();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.stopButton = new System.Windows.Forms.Button();
            this.startButton = new System.Windows.Forms.Button();
            this.btnOpenNew3 = new System.Windows.Forms.Button();
            this.btnPhoto3 = new System.Windows.Forms.Button();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.btnSave3 = new System.Windows.Forms.Button();
            this.btnOpenNew2 = new System.Windows.Forms.Button();
            this.btnPhoto2 = new System.Windows.Forms.Button();
            this.btnSave2 = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.btnOpenNew1 = new System.Windows.Forms.Button();
            this.btnPhoto1 = new System.Windows.Forms.Button();
            this.btnSave1 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // videoSourcePlayer1
            // 
            this.videoSourcePlayer1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.videoSourcePlayer1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.videoSourcePlayer1.ForeColor = System.Drawing.Color.White;
            this.videoSourcePlayer1.Location = new System.Drawing.Point(10, 50);
            this.videoSourcePlayer1.Name = "videoSourcePlayer1";
            this.videoSourcePlayer1.Size = new System.Drawing.Size(331, 242);
            this.videoSourcePlayer1.TabIndex = 0;
            this.videoSourcePlayer1.VideoSource = null;
            // 
            // videoSourcePlayer2
            // 
            this.videoSourcePlayer2.BackColor = System.Drawing.SystemColors.ControlDark;
            this.videoSourcePlayer2.ForeColor = System.Drawing.Color.White;
            this.videoSourcePlayer2.Location = new System.Drawing.Point(10, 50);
            this.videoSourcePlayer2.Name = "videoSourcePlayer2";
            this.videoSourcePlayer2.Size = new System.Drawing.Size(322, 242);
            this.videoSourcePlayer2.TabIndex = 1;
            this.videoSourcePlayer2.VideoSource = null;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnOpenNew1);
            this.groupBox1.Controls.Add(this.camera1FpsLabel);
            this.groupBox1.Controls.Add(this.btnPhoto1);
            this.groupBox1.Controls.Add(this.camera1Combo);
            this.groupBox1.Controls.Add(this.videoSourcePlayer1);
            this.groupBox1.Controls.Add(this.btnSave1);
            this.groupBox1.Controls.Add(this.pictureBox1);
            this.groupBox1.Location = new System.Drawing.Point(10, 10);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(347, 537);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Camera 1";
            // 
            // camera1FpsLabel
            // 
            this.camera1FpsLabel.Location = new System.Drawing.Point(282, 295);
            this.camera1FpsLabel.Name = "camera1FpsLabel";
            this.camera1FpsLabel.Size = new System.Drawing.Size(50, 17);
            this.camera1FpsLabel.TabIndex = 4;
            this.camera1FpsLabel.Text = "label1";
            this.camera1FpsLabel.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // camera1Combo
            // 
            this.camera1Combo.FormattingEnabled = true;
            this.camera1Combo.Location = new System.Drawing.Point(10, 20);
            this.camera1Combo.Name = "camera1Combo";
            this.camera1Combo.Size = new System.Drawing.Size(327, 21);
            this.camera1Combo.TabIndex = 3;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnOpenNew2);
            this.groupBox2.Controls.Add(this.btnPhoto2);
            this.groupBox2.Controls.Add(this.camera2FpsLabel);
            this.groupBox2.Controls.Add(this.camera2Combo);
            this.groupBox2.Controls.Add(this.btnSave2);
            this.groupBox2.Controls.Add(this.pictureBox2);
            this.groupBox2.Controls.Add(this.videoSourcePlayer2);
            this.groupBox2.Location = new System.Drawing.Point(360, 10);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(342, 537);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Camera 2";
            // 
            // camera2FpsLabel
            // 
            this.camera2FpsLabel.Location = new System.Drawing.Point(282, 295);
            this.camera2FpsLabel.Name = "camera2FpsLabel";
            this.camera2FpsLabel.Size = new System.Drawing.Size(50, 17);
            this.camera2FpsLabel.TabIndex = 5;
            this.camera2FpsLabel.Text = "label2";
            this.camera2FpsLabel.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // camera2Combo
            // 
            this.camera2Combo.FormattingEnabled = true;
            this.camera2Combo.Location = new System.Drawing.Point(10, 20);
            this.camera2Combo.Name = "camera2Combo";
            this.camera2Combo.Size = new System.Drawing.Size(322, 21);
            this.camera2Combo.TabIndex = 2;
            // 
            // timer
            // 
            this.timer.Interval = 1000;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnOpenNew3);
            this.groupBox3.Controls.Add(this.btnPhoto3);
            this.groupBox3.Controls.Add(this.camera3FpsLabel);
            this.groupBox3.Controls.Add(this.pictureBox3);
            this.groupBox3.Controls.Add(this.btnSave3);
            this.groupBox3.Controls.Add(this.camera3Combo);
            this.groupBox3.Controls.Add(this.videoSourcePlayer3);
            this.groupBox3.Location = new System.Drawing.Point(708, 10);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(342, 537);
            this.groupBox3.TabIndex = 6;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Camera 3";
            // 
            // camera3FpsLabel
            // 
            this.camera3FpsLabel.Location = new System.Drawing.Point(282, 295);
            this.camera3FpsLabel.Name = "camera3FpsLabel";
            this.camera3FpsLabel.Size = new System.Drawing.Size(50, 17);
            this.camera3FpsLabel.TabIndex = 5;
            this.camera3FpsLabel.Text = "label3";
            this.camera3FpsLabel.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // camera3Combo
            // 
            this.camera3Combo.FormattingEnabled = true;
            this.camera3Combo.Location = new System.Drawing.Point(10, 20);
            this.camera3Combo.Name = "camera3Combo";
            this.camera3Combo.Size = new System.Drawing.Size(322, 21);
            this.camera3Combo.TabIndex = 2;
            // 
            // videoSourcePlayer3
            // 
            this.videoSourcePlayer3.BackColor = System.Drawing.SystemColors.ControlDark;
            this.videoSourcePlayer3.ForeColor = System.Drawing.Color.White;
            this.videoSourcePlayer3.Location = new System.Drawing.Point(10, 50);
            this.videoSourcePlayer3.Name = "videoSourcePlayer3";
            this.videoSourcePlayer3.Size = new System.Drawing.Size(322, 242);
            this.videoSourcePlayer3.TabIndex = 1;
            this.videoSourcePlayer3.VideoSource = null;
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.FileName = "Snapshot";
            this.saveFileDialog1.Filter = "jpg file|*.jpg";
            // 
            // stopButton
            // 
            this.stopButton.BackgroundImage = global::MultiCam.Properties.Resources.Stop;
            this.stopButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.stopButton.Enabled = false;
            this.stopButton.Location = new System.Drawing.Point(1056, 86);
            this.stopButton.Name = "stopButton";
            this.stopButton.Size = new System.Drawing.Size(50, 50);
            this.stopButton.TabIndex = 5;
            this.stopButton.UseVisualStyleBackColor = true;
            this.stopButton.Click += new System.EventHandler(this.stopButton_Click);
            // 
            // startButton
            // 
            this.startButton.BackgroundImage = global::MultiCam.Properties.Resources.Start;
            this.startButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.startButton.Location = new System.Drawing.Point(1056, 30);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(50, 50);
            this.startButton.TabIndex = 4;
            this.startButton.UseVisualStyleBackColor = true;
            this.startButton.Click += new System.EventHandler(this.startButton_Click);
            // 
            // btnOpenNew3
            // 
            this.btnOpenNew3.BackgroundImage = global::MultiCam.Properties.Resources.open_in_new_window;
            this.btnOpenNew3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnOpenNew3.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnOpenNew3.Location = new System.Drawing.Point(303, 50);
            this.btnOpenNew3.Name = "btnOpenNew3";
            this.btnOpenNew3.Size = new System.Drawing.Size(29, 28);
            this.btnOpenNew3.TabIndex = 15;
            this.btnOpenNew3.UseVisualStyleBackColor = true;
            this.btnOpenNew3.Visible = false;
            this.btnOpenNew3.Click += new System.EventHandler(this.btnOpenNew3_Click);
            // 
            // btnPhoto3
            // 
            this.btnPhoto3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnPhoto3.BackgroundImage")));
            this.btnPhoto3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnPhoto3.Enabled = false;
            this.btnPhoto3.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnPhoto3.Location = new System.Drawing.Point(282, 328);
            this.btnPhoto3.Name = "btnPhoto3";
            this.btnPhoto3.Size = new System.Drawing.Size(45, 43);
            this.btnPhoto3.TabIndex = 9;
            this.btnPhoto3.Text = "Photo";
            this.btnPhoto3.UseVisualStyleBackColor = true;
            this.btnPhoto3.Click += new System.EventHandler(this.btnPhoto3_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Location = new System.Drawing.Point(10, 328);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(266, 203);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 11;
            this.pictureBox3.TabStop = false;
            // 
            // btnSave3
            // 
            this.btnSave3.BackgroundImage = global::MultiCam.Properties.Resources.Save;
            this.btnSave3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSave3.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnSave3.Location = new System.Drawing.Point(282, 377);
            this.btnSave3.Name = "btnSave3";
            this.btnSave3.Size = new System.Drawing.Size(44, 43);
            this.btnSave3.TabIndex = 13;
            this.btnSave3.Text = "Save";
            this.btnSave3.UseVisualStyleBackColor = true;
            this.btnSave3.Visible = false;
            this.btnSave3.Click += new System.EventHandler(this.btnSave3_Click);
            // 
            // btnOpenNew2
            // 
            this.btnOpenNew2.BackgroundImage = global::MultiCam.Properties.Resources.open_in_new_window;
            this.btnOpenNew2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnOpenNew2.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnOpenNew2.Location = new System.Drawing.Point(303, 50);
            this.btnOpenNew2.Name = "btnOpenNew2";
            this.btnOpenNew2.Size = new System.Drawing.Size(29, 28);
            this.btnOpenNew2.TabIndex = 14;
            this.btnOpenNew2.UseVisualStyleBackColor = true;
            this.btnOpenNew2.Visible = false;
            this.btnOpenNew2.Click += new System.EventHandler(this.btnOpenNew2_Click);
            // 
            // btnPhoto2
            // 
            this.btnPhoto2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnPhoto2.BackgroundImage")));
            this.btnPhoto2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnPhoto2.Enabled = false;
            this.btnPhoto2.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnPhoto2.Location = new System.Drawing.Point(288, 328);
            this.btnPhoto2.Name = "btnPhoto2";
            this.btnPhoto2.Size = new System.Drawing.Size(44, 43);
            this.btnPhoto2.TabIndex = 8;
            this.btnPhoto2.Text = "Photo";
            this.btnPhoto2.UseVisualStyleBackColor = true;
            this.btnPhoto2.Click += new System.EventHandler(this.btnPhoto2_Click);
            // 
            // btnSave2
            // 
            this.btnSave2.BackgroundImage = global::MultiCam.Properties.Resources.Save;
            this.btnSave2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSave2.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnSave2.Location = new System.Drawing.Point(288, 377);
            this.btnSave2.Name = "btnSave2";
            this.btnSave2.Size = new System.Drawing.Size(44, 43);
            this.btnSave2.TabIndex = 12;
            this.btnSave2.Text = "Save";
            this.btnSave2.UseVisualStyleBackColor = true;
            this.btnSave2.Visible = false;
            this.btnSave2.Click += new System.EventHandler(this.btnSave2_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Location = new System.Drawing.Point(10, 328);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(272, 203);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 10;
            this.pictureBox2.TabStop = false;
            // 
            // btnOpenNew1
            // 
            this.btnOpenNew1.BackgroundImage = global::MultiCam.Properties.Resources.open_in_new_window;
            this.btnOpenNew1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnOpenNew1.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnOpenNew1.Location = new System.Drawing.Point(312, 50);
            this.btnOpenNew1.Name = "btnOpenNew1";
            this.btnOpenNew1.Size = new System.Drawing.Size(29, 28);
            this.btnOpenNew1.TabIndex = 13;
            this.btnOpenNew1.UseVisualStyleBackColor = true;
            this.btnOpenNew1.Visible = false;
            this.btnOpenNew1.Click += new System.EventHandler(this.btnOpenNew1_Click);
            // 
            // btnPhoto1
            // 
            this.btnPhoto1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnPhoto1.BackgroundImage")));
            this.btnPhoto1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnPhoto1.Enabled = false;
            this.btnPhoto1.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnPhoto1.Location = new System.Drawing.Point(297, 328);
            this.btnPhoto1.Name = "btnPhoto1";
            this.btnPhoto1.Size = new System.Drawing.Size(44, 43);
            this.btnPhoto1.TabIndex = 7;
            this.btnPhoto1.Text = "Photo";
            this.btnPhoto1.UseVisualStyleBackColor = true;
            this.btnPhoto1.Click += new System.EventHandler(this.btnPhoto1_Click);
            // 
            // btnSave1
            // 
            this.btnSave1.BackgroundImage = global::MultiCam.Properties.Resources.Save;
            this.btnSave1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSave1.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnSave1.Location = new System.Drawing.Point(297, 377);
            this.btnSave1.Name = "btnSave1";
            this.btnSave1.Size = new System.Drawing.Size(44, 43);
            this.btnSave1.TabIndex = 8;
            this.btnSave1.Text = "Save";
            this.btnSave1.UseVisualStyleBackColor = true;
            this.btnSave1.Visible = false;
            this.btnSave1.Click += new System.EventHandler(this.btnSave1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(10, 328);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(281, 203);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1113, 636);
            this.Controls.Add(this.stopButton);
            this.Controls.Add(this.startButton);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "MainForm";
            this.Text = "MultiCam";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private AForge.Controls.VideoSourcePlayer videoSourcePlayer1;
        private AForge.Controls.VideoSourcePlayer videoSourcePlayer2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox camera1Combo;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox camera2Combo;
        private System.Windows.Forms.Button startButton;
        private System.Windows.Forms.Button stopButton;
        private System.Windows.Forms.Label camera1FpsLabel;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.Label camera2FpsLabel;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label camera3FpsLabel;
        private System.Windows.Forms.ComboBox camera3Combo;
        private AForge.Controls.VideoSourcePlayer videoSourcePlayer3;
        private System.Windows.Forms.Button btnPhoto1;
        private System.Windows.Forms.Button btnPhoto2;
        private System.Windows.Forms.Button btnPhoto3;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Button btnSave1;
        private System.Windows.Forms.Button btnSave2;
        private System.Windows.Forms.Button btnSave3;
        private System.Windows.Forms.Button btnOpenNew1;
        private System.Windows.Forms.Button btnOpenNew2;
        private System.Windows.Forms.Button btnOpenNew3;
    }
}

