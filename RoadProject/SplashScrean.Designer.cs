namespace RoadProject
{
    partial class SplashScrean
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SplashScrean));
            this.labelConn = new System.Windows.Forms.Label();
            this.timerRoad = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // labelConn
            // 
            this.labelConn.AutoSize = true;
            this.labelConn.BackColor = System.Drawing.Color.Transparent;
            this.labelConn.Font = new System.Drawing.Font("Bookman Old Style", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelConn.ForeColor = System.Drawing.SystemColors.ControlText;
            this.labelConn.Location = new System.Drawing.Point(21, 259);
            this.labelConn.Name = "labelConn";
            this.labelConn.Size = new System.Drawing.Size(239, 21);
            this.labelConn.TabIndex = 0;
            this.labelConn.Text = "Проверка подключения";
            // 
            // timerRoad
            // 
            this.timerRoad.Tick += new System.EventHandler(this.timerRoad_Tick);
            // 
            // SplashScrean
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(511, 321);
            this.Controls.Add(this.labelConn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "SplashScrean";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Загрузка";
            this.Load += new System.EventHandler(this.SplashScrean_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelConn;
        private System.Windows.Forms.Timer timerRoad;
    }
}