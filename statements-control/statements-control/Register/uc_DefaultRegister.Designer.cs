namespace statements_control
{
    partial class uc_DefaultRegister
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(uc_DefaultRegister));
            this.btn_Search = new Bunifu.Framework.UI.BunifuThinButton2();
            this.uc_panel = new System.Windows.Forms.Panel();
            this.uc_panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_Search
            // 
            this.btn_Search.ActiveBorderThickness = 1;
            this.btn_Search.ActiveCornerRadius = 20;
            this.btn_Search.ActiveFillColor = System.Drawing.Color.SeaGreen;
            this.btn_Search.ActiveForecolor = System.Drawing.Color.White;
            this.btn_Search.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.btn_Search.BackColor = System.Drawing.SystemColors.Control;
            this.btn_Search.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_Search.BackgroundImage")));
            this.btn_Search.ButtonText = "ThinButton";
            this.btn_Search.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Search.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Search.ForeColor = System.Drawing.Color.SeaGreen;
            this.btn_Search.IdleBorderThickness = 1;
            this.btn_Search.IdleCornerRadius = 20;
            this.btn_Search.IdleFillColor = System.Drawing.Color.White;
            this.btn_Search.IdleForecolor = System.Drawing.Color.SeaGreen;
            this.btn_Search.IdleLineColor = System.Drawing.Color.SeaGreen;
            this.btn_Search.Location = new System.Drawing.Point(621, 23);
            this.btn_Search.Margin = new System.Windows.Forms.Padding(5);
            this.btn_Search.Name = "btn_Search";
            this.btn_Search.Size = new System.Drawing.Size(111, 41);
            this.btn_Search.TabIndex = 0;
            this.btn_Search.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // uc_panel
            // 
            this.uc_panel.Controls.Add(this.btn_Search);
            this.uc_panel.Location = new System.Drawing.Point(1, 0);
            this.uc_panel.Name = "uc_panel";
            this.uc_panel.Size = new System.Drawing.Size(759, 541);
            this.uc_panel.TabIndex = 1;
            // 
            // uc_DefaultRegister
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.uc_panel);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "uc_DefaultRegister";
            this.Size = new System.Drawing.Size(760, 542);
            this.uc_panel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        protected Bunifu.Framework.UI.BunifuThinButton2 btn_Search;
        protected System.Windows.Forms.Panel uc_panel;
    }
}
