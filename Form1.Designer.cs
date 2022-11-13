namespace RestlessWallpaperV2
{
    partial class Window
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

        private AxWMPLib.AxWindowsMediaPlayer InitComponent()
        {
            AxWMPLib.AxWindowsMediaPlayer VideoWindow;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Window));
            VideoWindow = new AxWMPLib.AxWindowsMediaPlayer();
            ((System.ComponentModel.ISupportInitialize)(VideoWindow)).BeginInit();
            this.SuspendLayout();
            // 
            // VideoWindow
            // 
            VideoWindow.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            VideoWindow.Dock = System.Windows.Forms.DockStyle.Fill;
            VideoWindow.Enabled = true;
            VideoWindow.Location = new System.Drawing.Point(0, 0);
            VideoWindow.Name = "VideoWindow";
            VideoWindow.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("VideoWindow.OcxState")));
            //VideoWindow.Size = new System.Drawing.Size(1920, 1080);
            VideoWindow.TabIndex = 0;
            VideoWindow.TabStop = false;

            // 
            // Window
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            //this.ClientSize = new System.Drawing.Size(1920, 1080);
            this.ControlBox = false;
            this.Controls.Add(VideoWindow);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Window";
            this.RightToLeftLayout = true;
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "Form1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(VideoWindow)).EndInit();
            this.ResumeLayout(false);

            VideoWindow.URL = @"C:\Users\User\Videos\wallpaper.mp4";
            VideoWindow.uiMode = "none";
            VideoWindow.settings.autoStart = true;
            VideoWindow.settings.setMode("loop", true);

            return VideoWindow;
        }

    }
}

