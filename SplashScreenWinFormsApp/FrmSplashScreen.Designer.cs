namespace SplashScreenWinFormsApp
{
    partial class FrmSplashScreen
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
            lbStatusInfo = new Label();
            SuspendLayout();
            // 
            // lbStatusInfo
            // 
            lbStatusInfo.AutoSize = true;
            lbStatusInfo.Font = new Font("Microsoft YaHei UI", 10.5F, FontStyle.Bold, GraphicsUnit.Point, 134);
            lbStatusInfo.ForeColor = Color.FromArgb(255, 128, 128);
            lbStatusInfo.Location = new Point(81, 119);
            lbStatusInfo.Name = "lbStatusInfo";
            lbStatusInfo.Size = new Size(75, 28);
            lbStatusInfo.TabIndex = 0;
            lbStatusInfo.Text = "label1";
            // 
            // FrmSplashScreen
            // 
            AutoScaleDimensions = new SizeF(11F, 24F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(480, 283);
            Controls.Add(lbStatusInfo);
            Name = "FrmSplashScreen";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FrmSplashScreen";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbStatusInfo;
    }
}