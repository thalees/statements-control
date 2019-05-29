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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(uc_DefaultSearch));
            this.dgv_Listing = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.txt_Search = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.web_GridHTML = new System.Windows.Forms.WebBrowser();
            this.bunifuMaterialTextbox1 = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.lbl_Id = new System.Windows.Forms.Label();
            this.lbl_Name = new System.Windows.Forms.Label();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.btn_HTML = new Bunifu.Framework.UI.BunifuThinButton2();
            this.btn_Back = new Bunifu.Framework.UI.BunifuThinButton2();
            this.btn_Pesquisar = new Bunifu.Framework.UI.BunifuThinButton2();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Listing)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_Listing
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dgv_Listing.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_Listing.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.dgv_Listing.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgv_Listing.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.SeaGreen;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.SeaGreen;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_Listing.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgv_Listing.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Listing.DoubleBuffered = true;
            this.dgv_Listing.EnableHeadersVisualStyles = false;
            this.dgv_Listing.HeaderBgColor = System.Drawing.Color.SeaGreen;
            this.dgv_Listing.HeaderForeColor = System.Drawing.Color.SeaGreen;
            this.dgv_Listing.Location = new System.Drawing.Point(18, 174);
            this.dgv_Listing.Margin = new System.Windows.Forms.Padding(2);
            this.dgv_Listing.Name = "dgv_Listing";
            this.dgv_Listing.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgv_Listing.RowTemplate.Height = 24;
            this.dgv_Listing.Size = new System.Drawing.Size(538, 252);
            this.dgv_Listing.TabIndex = 6;
            // 
            // txt_Search
            // 
            this.txt_Search.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_Search.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txt_Search.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txt_Search.HintForeColor = System.Drawing.Color.Empty;
            this.txt_Search.HintText = "Buscar";
            this.txt_Search.isPassword = false;
            this.txt_Search.LineFocusedColor = System.Drawing.Color.Blue;
            this.txt_Search.LineIdleColor = System.Drawing.Color.Gray;
            this.txt_Search.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.txt_Search.LineThickness = 3;
            this.txt_Search.Location = new System.Drawing.Point(75, 81);
            this.txt_Search.Margin = new System.Windows.Forms.Padding(4);
            this.txt_Search.Name = "txt_Search";
            this.txt_Search.Size = new System.Drawing.Size(156, 36);
            this.txt_Search.TabIndex = 10;
            this.txt_Search.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // web_GridHTML
            // 
            this.web_GridHTML.Location = new System.Drawing.Point(18, 174);
            this.web_GridHTML.MinimumSize = new System.Drawing.Size(20, 20);
            this.web_GridHTML.Name = "web_GridHTML";
            this.web_GridHTML.Size = new System.Drawing.Size(538, 250);
            this.web_GridHTML.TabIndex = 13;
            // 
            // bunifuMaterialTextbox1
            // 
            this.bunifuMaterialTextbox1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.bunifuMaterialTextbox1.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.bunifuMaterialTextbox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.bunifuMaterialTextbox1.HintForeColor = System.Drawing.Color.Empty;
            this.bunifuMaterialTextbox1.HintText = "Buscar";
            this.bunifuMaterialTextbox1.isPassword = false;
            this.bunifuMaterialTextbox1.LineFocusedColor = System.Drawing.Color.Blue;
            this.bunifuMaterialTextbox1.LineIdleColor = System.Drawing.Color.Gray;
            this.bunifuMaterialTextbox1.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.bunifuMaterialTextbox1.LineThickness = 3;
            this.bunifuMaterialTextbox1.Location = new System.Drawing.Point(362, 81);
            this.bunifuMaterialTextbox1.Margin = new System.Windows.Forms.Padding(4);
            this.bunifuMaterialTextbox1.Name = "bunifuMaterialTextbox1";
            this.bunifuMaterialTextbox1.Size = new System.Drawing.Size(156, 36);
            this.bunifuMaterialTextbox1.TabIndex = 14;
            this.bunifuMaterialTextbox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lbl_Id
            // 
            this.lbl_Id.AutoSize = true;
            this.lbl_Id.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Id.Location = new System.Drawing.Point(39, 101);
            this.lbl_Id.Name = "lbl_Id";
            this.lbl_Id.Size = new System.Drawing.Size(29, 16);
            this.lbl_Id.TabIndex = 15;
            this.lbl_Id.Text = "Id: ";
            // 
            // lbl_Name
            // 
            this.lbl_Name.AutoSize = true;
            this.lbl_Name.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Name.Location = new System.Drawing.Point(302, 101);
            this.lbl_Name.Name = "lbl_Name";
            this.lbl_Name.Size = new System.Drawing.Size(53, 16);
            this.lbl_Name.TabIndex = 16;
            this.lbl_Name.Text = "Nome:";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(525, 101);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(15, 14);
            this.checkBox1.TabIndex = 17;
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Location = new System.Drawing.Point(238, 101);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(15, 14);
            this.checkBox2.TabIndex = 18;
            this.checkBox2.UseVisualStyleBackColor = true;
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
            // uc_DefaultSearch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btn_Pesquisar);
            this.Controls.Add(this.checkBox2);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.lbl_Name);
            this.Controls.Add(this.lbl_Id);
            this.Controls.Add(this.bunifuMaterialTextbox1);
            this.Controls.Add(this.btn_HTML);
            this.Controls.Add(this.btn_Back);
            this.Controls.Add(this.txt_Search);
            this.Controls.Add(this.dgv_Listing);
            this.Controls.Add(this.web_GridHTML);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "uc_DefaultSearch";
            this.Size = new System.Drawing.Size(570, 440);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Listing)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        protected Bunifu.Framework.UI.BunifuCustomDataGrid dgv_Listing;
        protected Bunifu.Framework.UI.BunifuMaterialTextbox txt_Search;
        private Bunifu.Framework.UI.BunifuThinButton2 btn_Back;
        private Bunifu.Framework.UI.BunifuThinButton2 btn_HTML;
        private System.Windows.Forms.WebBrowser web_GridHTML;
        protected Bunifu.Framework.UI.BunifuMaterialTextbox bunifuMaterialTextbox1;
        private System.Windows.Forms.Label lbl_Id;
        private System.Windows.Forms.Label lbl_Name;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.CheckBox checkBox2;
        private Bunifu.Framework.UI.BunifuThinButton2 btn_Pesquisar;
    }
}
