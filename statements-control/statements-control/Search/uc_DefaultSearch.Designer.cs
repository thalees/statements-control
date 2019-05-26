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
            this.txt_Search = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.dgv_Listing = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Listing)).BeginInit();
            this.SuspendLayout();
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
            this.txt_Search.Location = new System.Drawing.Point(81, 92);
            this.txt_Search.Margin = new System.Windows.Forms.Padding(5);
            this.txt_Search.Name = "txt_Search";
            this.txt_Search.Size = new System.Drawing.Size(616, 44);
            this.txt_Search.TabIndex = 10;
            this.txt_Search.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
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
            this.dgv_Listing.Location = new System.Drawing.Point(24, 214);
            this.dgv_Listing.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgv_Listing.Name = "dgv_Listing";
            this.dgv_Listing.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgv_Listing.RowTemplate.Height = 24;
            this.dgv_Listing.Size = new System.Drawing.Size(718, 310);
            this.dgv_Listing.TabIndex = 6;
            // 
            // uc_DefaultSearch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.txt_Search);
            this.Controls.Add(this.dgv_Listing);
            this.Name = "uc_DefaultSearch";
            this.Size = new System.Drawing.Size(760, 542);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Listing)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        protected Bunifu.Framework.UI.BunifuMaterialTextbox txt_Search;
        protected Bunifu.Framework.UI.BunifuCustomDataGrid dgv_Listing;
    }
}
