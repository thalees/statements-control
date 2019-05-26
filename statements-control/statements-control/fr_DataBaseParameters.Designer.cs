namespace statements_control
{
    partial class fr_DataBaseParameters
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fr_DataBaseParameters));
            this.btn_Connect = new Bunifu.Framework.UI.BunifuThinButton2();
            this.txtDbCatalog = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.lblTitle = new System.Windows.Forms.Label();
            this.txtDbUsername = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.txtDbPassword = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.btn_Back = new Bunifu.Framework.UI.BunifuThinButton2();
            this.btn_TestConnection = new Bunifu.Framework.UI.BunifuThinButton2();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_Connect
            // 
            this.btn_Connect.ActiveBorderThickness = 1;
            this.btn_Connect.ActiveCornerRadius = 20;
            this.btn_Connect.ActiveFillColor = System.Drawing.Color.SeaGreen;
            this.btn_Connect.ActiveForecolor = System.Drawing.Color.White;
            this.btn_Connect.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.btn_Connect.BackColor = System.Drawing.SystemColors.Control;
            this.btn_Connect.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_Connect.BackgroundImage")));
            this.btn_Connect.ButtonText = "Salvar";
            this.btn_Connect.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Connect.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Connect.ForeColor = System.Drawing.Color.SeaGreen;
            this.btn_Connect.IdleBorderThickness = 1;
            this.btn_Connect.IdleCornerRadius = 20;
            this.btn_Connect.IdleFillColor = System.Drawing.Color.White;
            this.btn_Connect.IdleForecolor = System.Drawing.Color.SeaGreen;
            this.btn_Connect.IdleLineColor = System.Drawing.Color.SeaGreen;
            this.btn_Connect.Location = new System.Drawing.Point(73, 208);
            this.btn_Connect.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.btn_Connect.Name = "btn_Connect";
            this.btn_Connect.Size = new System.Drawing.Size(229, 46);
            this.btn_Connect.TabIndex = 13;
            this.btn_Connect.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_Connect.Click += new System.EventHandler(this.btn_Connect_Click);
            // 
            // txtDbCatalog
            // 
            this.txtDbCatalog.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtDbCatalog.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtDbCatalog.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtDbCatalog.HintForeColor = System.Drawing.Color.Empty;
            this.txtDbCatalog.HintText = "Catalog Database";
            this.txtDbCatalog.isPassword = false;
            this.txtDbCatalog.LineFocusedColor = System.Drawing.Color.Blue;
            this.txtDbCatalog.LineIdleColor = System.Drawing.Color.Gray;
            this.txtDbCatalog.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.txtDbCatalog.LineThickness = 3;
            this.txtDbCatalog.Location = new System.Drawing.Point(48, 81);
            this.txtDbCatalog.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.txtDbCatalog.Name = "txtDbCatalog";
            this.txtDbCatalog.Size = new System.Drawing.Size(280, 32);
            this.txtDbCatalog.TabIndex = 11;
            this.txtDbCatalog.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Location = new System.Drawing.Point(69, 30);
            this.lblTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(210, 17);
            this.lblTitle.TabIndex = 10;
            this.lblTitle.Text = "Parâmetros do Banco de Dados";
            // 
            // txtDbUsername
            // 
            this.txtDbUsername.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtDbUsername.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtDbUsername.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtDbUsername.HintForeColor = System.Drawing.Color.Empty;
            this.txtDbUsername.HintText = "Username";
            this.txtDbUsername.isPassword = false;
            this.txtDbUsername.LineFocusedColor = System.Drawing.Color.Blue;
            this.txtDbUsername.LineIdleColor = System.Drawing.Color.Gray;
            this.txtDbUsername.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.txtDbUsername.LineThickness = 3;
            this.txtDbUsername.Location = new System.Drawing.Point(48, 123);
            this.txtDbUsername.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.txtDbUsername.Name = "txtDbUsername";
            this.txtDbUsername.Size = new System.Drawing.Size(280, 32);
            this.txtDbUsername.TabIndex = 14;
            this.txtDbUsername.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // errorProvider
            // 
            this.errorProvider.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.errorProvider.ContainerControl = this;
            // 
            // txtDbPassword
            // 
            this.txtDbPassword.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtDbPassword.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtDbPassword.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtDbPassword.HintForeColor = System.Drawing.Color.Empty;
            this.txtDbPassword.HintText = "";
            this.txtDbPassword.isPassword = true;
            this.txtDbPassword.LineFocusedColor = System.Drawing.Color.Blue;
            this.txtDbPassword.LineIdleColor = System.Drawing.Color.Gray;
            this.txtDbPassword.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.txtDbPassword.LineThickness = 3;
            this.txtDbPassword.Location = new System.Drawing.Point(48, 165);
            this.txtDbPassword.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.txtDbPassword.Name = "txtDbPassword";
            this.txtDbPassword.Size = new System.Drawing.Size(280, 32);
            this.txtDbPassword.TabIndex = 15;
            this.txtDbPassword.Text = "Password";
            this.txtDbPassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // btn_Back
            // 
            this.btn_Back.ActiveBorderThickness = 1;
            this.btn_Back.ActiveCornerRadius = 20;
            this.btn_Back.ActiveFillColor = System.Drawing.Color.SeaGreen;
            this.btn_Back.ActiveForecolor = System.Drawing.Color.White;
            this.btn_Back.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.btn_Back.BackColor = System.Drawing.SystemColors.Control;
            this.btn_Back.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_Back.BackgroundImage")));
            this.btn_Back.ButtonText = "Back";
            this.btn_Back.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Back.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Back.ForeColor = System.Drawing.Color.SeaGreen;
            this.btn_Back.IdleBorderThickness = 1;
            this.btn_Back.IdleCornerRadius = 20;
            this.btn_Back.IdleFillColor = System.Drawing.Color.White;
            this.btn_Back.IdleForecolor = System.Drawing.Color.SeaGreen;
            this.btn_Back.IdleLineColor = System.Drawing.Color.SeaGreen;
            this.btn_Back.Location = new System.Drawing.Point(257, 283);
            this.btn_Back.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.btn_Back.Name = "btn_Back";
            this.btn_Back.Size = new System.Drawing.Size(91, 46);
            this.btn_Back.TabIndex = 16;
            this.btn_Back.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_Back.Click += new System.EventHandler(this.btn_Back_Click);
            // 
            // btn_TestConnection
            // 
            this.btn_TestConnection.ActiveBorderThickness = 1;
            this.btn_TestConnection.ActiveCornerRadius = 20;
            this.btn_TestConnection.ActiveFillColor = System.Drawing.Color.SeaGreen;
            this.btn_TestConnection.ActiveForecolor = System.Drawing.Color.White;
            this.btn_TestConnection.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.btn_TestConnection.BackColor = System.Drawing.SystemColors.Control;
            this.btn_TestConnection.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_TestConnection.BackgroundImage")));
            this.btn_TestConnection.ButtonText = "Test";
            this.btn_TestConnection.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_TestConnection.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_TestConnection.ForeColor = System.Drawing.Color.SeaGreen;
            this.btn_TestConnection.IdleBorderThickness = 1;
            this.btn_TestConnection.IdleCornerRadius = 20;
            this.btn_TestConnection.IdleFillColor = System.Drawing.Color.White;
            this.btn_TestConnection.IdleForecolor = System.Drawing.Color.SeaGreen;
            this.btn_TestConnection.IdleLineColor = System.Drawing.Color.SeaGreen;
            this.btn_TestConnection.Location = new System.Drawing.Point(153, 283);
            this.btn_TestConnection.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.btn_TestConnection.Name = "btn_TestConnection";
            this.btn_TestConnection.Size = new System.Drawing.Size(91, 46);
            this.btn_TestConnection.TabIndex = 17;
            this.btn_TestConnection.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_TestConnection.Click += new System.EventHandler(this.btn_TestConnection_Click);
            // 
            // fr_DataBaseParameters
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(367, 331);
            this.Controls.Add(this.btn_TestConnection);
            this.Controls.Add(this.btn_Back);
            this.Controls.Add(this.txtDbPassword);
            this.Controls.Add(this.txtDbUsername);
            this.Controls.Add(this.btn_Connect);
            this.Controls.Add(this.txtDbCatalog);
            this.Controls.Add(this.lblTitle);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "fr_DataBaseParameters";
            this.Text = "fr_DataBaseParameters";
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuThinButton2 btn_Connect;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtDbCatalog;
        private System.Windows.Forms.Label lblTitle;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtDbUsername;
        private System.Windows.Forms.ErrorProvider errorProvider;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtDbPassword;
        private Bunifu.Framework.UI.BunifuThinButton2 btn_TestConnection;
        private Bunifu.Framework.UI.BunifuThinButton2 btn_Back;
    }
}