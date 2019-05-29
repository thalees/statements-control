namespace statements_control
{
    partial class uc_DefaultSearch
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(uc_DefaultSearch));
            this.txt_Name = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.lbl_Name = new System.Windows.Forms.Label();
            this.btn_HTML = new Bunifu.Framework.UI.BunifuThinButton2();
            this.btn_Back = new Bunifu.Framework.UI.BunifuThinButton2();
            this.btn_Pesquisar = new Bunifu.Framework.UI.BunifuThinButton2();
            this.dgv_Listing = new System.Windows.Forms.DataGridView();
            this.btn_Confirm = new Bunifu.Framework.UI.BunifuThinButton2();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Listing)).BeginInit();
            this.SuspendLayout();
            // 
            // txt_Name
            // 
            this.txt_Name.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_Name.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txt_Name.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txt_Name.HintForeColor = System.Drawing.Color.Empty;
            this.txt_Name.HintText = "Buscar";
            this.txt_Name.isPassword = false;
            this.txt_Name.LineFocusedColor = System.Drawing.Color.Blue;
            this.txt_Name.LineIdleColor = System.Drawing.Color.Gray;
            this.txt_Name.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.txt_Name.LineThickness = 3;
            this.txt_Name.Location = new System.Drawing.Point(76, 81);
            this.txt_Name.Margin = new System.Windows.Forms.Padding(4);
            this.txt_Name.Name = "txt_Name";
            this.txt_Name.Size = new System.Drawing.Size(156, 36);
            this.txt_Name.TabIndex = 14;
            this.txt_Name.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lbl_Name
            // 
            this.lbl_Name.AutoSize = true;
            this.lbl_Name.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Name.Location = new System.Drawing.Point(16, 101);
            this.lbl_Name.Name = "lbl_Name";
            this.lbl_Name.Size = new System.Drawing.Size(53, 16);
            this.lbl_Name.TabIndex = 16;
            this.lbl_Name.Text = "Nome:";
            // 
            // btn_HTML
            // 
            this.btn_HTML.ActiveBorderThickness = 1;
            this.btn_HTML.ActiveCornerRadius = 20;
            this.btn_HTML.ActiveFillColor = System.Drawing.Color.SeaGreen;
            this.btn_HTML.ActiveForecolor = System.Drawing.Color.White;
            this.btn_HTML.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.btn_HTML.BackColor = System.Drawing.SystemColors.Control;
            this.btn_HTML.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_HTML.BackgroundImage")));
            this.btn_HTML.ButtonText = "HTML";
            this.btn_HTML.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_HTML.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_HTML.ForeColor = System.Drawing.Color.SeaGreen;
            this.btn_HTML.IdleBorderThickness = 1;
            this.btn_HTML.IdleCornerRadius = 20;
            this.btn_HTML.IdleFillColor = System.Drawing.Color.White;
            this.btn_HTML.IdleForecolor = System.Drawing.Color.SeaGreen;
            this.btn_HTML.IdleLineColor = System.Drawing.Color.SeaGreen;
            this.btn_HTML.Location = new System.Drawing.Point(457, 15);
            this.btn_HTML.Margin = new System.Windows.Forms.Padding(4);
            this.btn_HTML.Name = "btn_HTML";
            this.btn_HTML.Size = new System.Drawing.Size(83, 35);
            this.btn_HTML.TabIndex = 12;
            this.btn_HTML.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_HTML.Click += new System.EventHandler(this.btn_HTML_Click);
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
            this.btn_Back.ButtonText = "Voltar";
            this.btn_Back.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Back.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Back.ForeColor = System.Drawing.Color.SeaGreen;
            this.btn_Back.IdleBorderThickness = 1;
            this.btn_Back.IdleCornerRadius = 20;
            this.btn_Back.IdleFillColor = System.Drawing.Color.White;
            this.btn_Back.IdleForecolor = System.Drawing.Color.SeaGreen;
            this.btn_Back.IdleLineColor = System.Drawing.Color.SeaGreen;
            this.btn_Back.Location = new System.Drawing.Point(18, 15);
            this.btn_Back.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Back.Name = "btn_Back";
            this.btn_Back.Size = new System.Drawing.Size(83, 35);
            this.btn_Back.TabIndex = 11;
            this.btn_Back.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_Back.Click += new System.EventHandler(this.btn_Back_Click);
            // 
            // btn_Pesquisar
            // 
            this.btn_Pesquisar.ActiveBorderThickness = 1;
            this.btn_Pesquisar.ActiveCornerRadius = 20;
            this.btn_Pesquisar.ActiveFillColor = System.Drawing.Color.SeaGreen;
            this.btn_Pesquisar.ActiveForecolor = System.Drawing.Color.White;
            this.btn_Pesquisar.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.btn_Pesquisar.BackColor = System.Drawing.SystemColors.Control;
            this.btn_Pesquisar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_Pesquisar.BackgroundImage")));
            this.btn_Pesquisar.ButtonText = "Pesquisar";
            this.btn_Pesquisar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Pesquisar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Pesquisar.ForeColor = System.Drawing.Color.SeaGreen;
            this.btn_Pesquisar.IdleBorderThickness = 1;
            this.btn_Pesquisar.IdleCornerRadius = 20;
            this.btn_Pesquisar.IdleFillColor = System.Drawing.Color.White;
            this.btn_Pesquisar.IdleForecolor = System.Drawing.Color.SeaGreen;
            this.btn_Pesquisar.IdleLineColor = System.Drawing.Color.SeaGreen;
            this.btn_Pesquisar.Location = new System.Drawing.Point(191, 15);
            this.btn_Pesquisar.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Pesquisar.Name = "btn_Pesquisar";
            this.btn_Pesquisar.Size = new System.Drawing.Size(188, 35);
            this.btn_Pesquisar.TabIndex = 19;
            this.btn_Pesquisar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dgv_Listing
            // 
            this.dgv_Listing.AllowUserToAddRows = false;
            this.dgv_Listing.AllowUserToDeleteRows = false;
            this.dgv_Listing.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgv_Listing.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgv_Listing.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Listing.Location = new System.Drawing.Point(19, 174);
            this.dgv_Listing.MultiSelect = false;
            this.dgv_Listing.Name = "dgv_Listing";
            this.dgv_Listing.ReadOnly = true;
            this.dgv_Listing.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_Listing.Size = new System.Drawing.Size(537, 198);
            this.dgv_Listing.TabIndex = 20;
            // 
            // btn_Confirm
            // 
            this.btn_Confirm.ActiveBorderThickness = 1;
            this.btn_Confirm.ActiveCornerRadius = 20;
            this.btn_Confirm.ActiveFillColor = System.Drawing.Color.SeaGreen;
            this.btn_Confirm.ActiveForecolor = System.Drawing.Color.White;
            this.btn_Confirm.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.btn_Confirm.BackColor = System.Drawing.SystemColors.Control;
            this.btn_Confirm.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_Confirm.BackgroundImage")));
            this.btn_Confirm.ButtonText = "Confirmar";
            this.btn_Confirm.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Confirm.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Confirm.ForeColor = System.Drawing.Color.SeaGreen;
            this.btn_Confirm.IdleBorderThickness = 1;
            this.btn_Confirm.IdleCornerRadius = 20;
            this.btn_Confirm.IdleFillColor = System.Drawing.Color.White;
            this.btn_Confirm.IdleForecolor = System.Drawing.Color.SeaGreen;
            this.btn_Confirm.IdleLineColor = System.Drawing.Color.SeaGreen;
            this.btn_Confirm.Location = new System.Drawing.Point(191, 132);
            this.btn_Confirm.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Confirm.Name = "btn_Confirm";
            this.btn_Confirm.Size = new System.Drawing.Size(188, 35);
            this.btn_Confirm.TabIndex = 21;
            this.btn_Confirm.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // uc_DefaultSearch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btn_Confirm);
            this.Controls.Add(this.btn_Pesquisar);
            this.Controls.Add(this.lbl_Name);
            this.Controls.Add(this.txt_Name);
            this.Controls.Add(this.btn_HTML);
            this.Controls.Add(this.btn_Back);
            this.Controls.Add(this.dgv_Listing);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "uc_DefaultSearch";
            this.Size = new System.Drawing.Size(570, 440);
            this.Load += new System.EventHandler(this.uc_DefaultSearch_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Listing)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lbl_Name;
        public Bunifu.Framework.UI.BunifuThinButton2 btn_Pesquisar;
        public Bunifu.Framework.UI.BunifuThinButton2 btn_HTML;
        public Bunifu.Framework.UI.BunifuMaterialTextbox txt_Name;
        public System.Windows.Forms.DataGridView dgv_Listing;
        public Bunifu.Framework.UI.BunifuThinButton2 btn_Confirm;
        public Bunifu.Framework.UI.BunifuThinButton2 btn_Back;
    }
}
