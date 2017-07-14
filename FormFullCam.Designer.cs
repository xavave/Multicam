namespace TwoCamerasTest
{
    partial class FormFullCam
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.vspFull = new AForge.Controls.VideoSourcePlayer();
            this.SuspendLayout();
            // 
            // vspFull
            // 
            this.vspFull.BackColor = System.Drawing.SystemColors.ControlDark;
            this.vspFull.Dock = System.Windows.Forms.DockStyle.Fill;
            this.vspFull.ForeColor = System.Drawing.Color.White;
            this.vspFull.Location = new System.Drawing.Point(0, 0);
            this.vspFull.Name = "vspFull";
            this.vspFull.Size = new System.Drawing.Size(284, 262);
            this.vspFull.TabIndex = 1;
            this.vspFull.VideoSource = null;
            // 
            // FormFullCam
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.vspFull);
            this.Name = "FormFullCam";
            this.Text = "Full Screen";
            this.ResumeLayout(false);

        }

        #endregion

        private AForge.Controls.VideoSourcePlayer vspFull;
    }
}