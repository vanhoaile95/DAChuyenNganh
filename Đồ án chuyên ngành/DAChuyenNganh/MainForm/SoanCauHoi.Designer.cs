namespace MainForm
{
    partial class SoanCauHoi
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SoanCauHoi));
            this.panelSoanCauHoi = new System.Windows.Forms.Panel();
            this.btnAddCauHoi = new Bunifu.Framework.UI.BunifuThinButton2();
            this.panelSoanCauHoi.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelSoanCauHoi
            // 
            this.panelSoanCauHoi.AutoScroll = true;
            this.panelSoanCauHoi.BackColor = System.Drawing.Color.White;
            this.panelSoanCauHoi.Controls.Add(this.btnAddCauHoi);
            this.panelSoanCauHoi.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelSoanCauHoi.Location = new System.Drawing.Point(0, 0);
            this.panelSoanCauHoi.Name = "panelSoanCauHoi";
            this.panelSoanCauHoi.Size = new System.Drawing.Size(613, 417);
            this.panelSoanCauHoi.TabIndex = 3;
            // 
            // btnAddCauHoi
            // 
            this.btnAddCauHoi.ActiveBorderThickness = 1;
            this.btnAddCauHoi.ActiveCornerRadius = 20;
            this.btnAddCauHoi.ActiveFillColor = System.Drawing.Color.SeaGreen;
            this.btnAddCauHoi.ActiveForecolor = System.Drawing.Color.White;
            this.btnAddCauHoi.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.btnAddCauHoi.BackColor = System.Drawing.Color.White;
            this.btnAddCauHoi.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnAddCauHoi.BackgroundImage")));
            this.btnAddCauHoi.ButtonText = "Thêm câu hỏi";
            this.btnAddCauHoi.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddCauHoi.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnAddCauHoi.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddCauHoi.ForeColor = System.Drawing.Color.SeaGreen;
            this.btnAddCauHoi.IdleBorderThickness = 1;
            this.btnAddCauHoi.IdleCornerRadius = 20;
            this.btnAddCauHoi.IdleFillColor = System.Drawing.Color.White;
            this.btnAddCauHoi.IdleForecolor = System.Drawing.Color.SeaGreen;
            this.btnAddCauHoi.IdleLineColor = System.Drawing.Color.SeaGreen;
            this.btnAddCauHoi.Location = new System.Drawing.Point(0, 0);
            this.btnAddCauHoi.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnAddCauHoi.Name = "btnAddCauHoi";
            this.btnAddCauHoi.Size = new System.Drawing.Size(613, 41);
            this.btnAddCauHoi.TabIndex = 0;
            this.btnAddCauHoi.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnAddCauHoi.Click += new System.EventHandler(this.btnAddCauHoi_Click);
            // 
            // SoanCauHoi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panelSoanCauHoi);
            this.Name = "SoanCauHoi";
            this.Size = new System.Drawing.Size(613, 417);
            this.panelSoanCauHoi.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelSoanCauHoi;
        private Bunifu.Framework.UI.BunifuThinButton2 btnAddCauHoi;
    }
}
