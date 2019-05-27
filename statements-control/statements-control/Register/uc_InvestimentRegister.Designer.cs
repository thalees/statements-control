namespace statements_control.Register
{
    partial class uc_InvestimentRegister
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
            this.label3 = new System.Windows.Forms.Label();
            this.dt_EndDate = new Bunifu.Framework.UI.BunifuDatepicker();
            this.label4 = new System.Windows.Forms.Label();
            this.dt_StartDate = new Bunifu.Framework.UI.BunifuDatepicker();
            this.txt_Value = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.uc_panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txt_Id)).BeginInit();
            this.SuspendLayout();
            // 
            // uc_panel
            // 
            this.uc_panel.Controls.Add(this.label5);
            this.uc_panel.Controls.Add(this.txt_Value);
            this.uc_panel.Controls.Add(this.label4);
            this.uc_panel.Controls.Add(this.dt_StartDate);
            this.uc_panel.Controls.Add(this.label3);
            this.uc_panel.Controls.Add(this.dt_EndDate);
            this.uc_panel.Controls.SetChildIndex(this.btn_Search, 0);
            this.uc_panel.Controls.SetChildIndex(this.txt_Id, 0);
            this.uc_panel.Controls.SetChildIndex(this.txt_Name, 0);
            this.uc_panel.Controls.SetChildIndex(this.dt_EndDate, 0);
            this.uc_panel.Controls.SetChildIndex(this.label3, 0);
            this.uc_panel.Controls.SetChildIndex(this.dt_StartDate, 0);
            this.uc_panel.Controls.SetChildIndex(this.label4, 0);
            this.uc_panel.Controls.SetChildIndex(this.txt_Value, 0);
            this.uc_panel.Controls.SetChildIndex(this.label5, 0);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(298, 213);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 17);
            this.label3.TabIndex = 22;
            this.label3.Text = "Data final";
            // 
            // dt_EndDate
            // 
            this.dt_EndDate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(207)))), ((int)(((byte)(245)))));
            this.dt_EndDate.BorderRadius = 0;
            this.dt_EndDate.ForeColor = System.Drawing.Color.White;
            this.dt_EndDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dt_EndDate.FormatCustom = null;
            this.dt_EndDate.Location = new System.Drawing.Point(301, 240);
            this.dt_EndDate.Name = "dt_EndDate";
            this.dt_EndDate.Size = new System.Drawing.Size(112, 25);
            this.dt_EndDate.TabIndex = 21;
            this.dt_EndDate.Value = new System.DateTime(2019, 5, 26, 23, 12, 9, 637);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(140, 213);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 17);
            this.label4.TabIndex = 24;
            this.label4.Text = "Data inicial";
            // 
            // dt_StartDate
            // 
            this.dt_StartDate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(207)))), ((int)(((byte)(245)))));
            this.dt_StartDate.BorderRadius = 0;
            this.dt_StartDate.ForeColor = System.Drawing.Color.White;
            this.dt_StartDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dt_StartDate.FormatCustom = null;
            this.dt_StartDate.Location = new System.Drawing.Point(143, 240);
            this.dt_StartDate.Name = "dt_StartDate";
            this.dt_StartDate.Size = new System.Drawing.Size(112, 25);
            this.dt_StartDate.TabIndex = 23;
            this.dt_StartDate.Value = new System.DateTime(2019, 5, 26, 23, 12, 9, 637);
            // 
            // txt_Value
            // 
            this.txt_Value.Location = new System.Drawing.Point(321, 172);
            this.txt_Value.Name = "txt_Value";
            this.txt_Value.Size = new System.Drawing.Size(92, 20);
            this.txt_Value.TabIndex = 25;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(318, 148);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(42, 17);
            this.label5.TabIndex = 26;
            this.label5.Text = "Valor";
            // 
            // uc_InvestimentRegister
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Name = "uc_InvestimentRegister";
            this.uc_panel.ResumeLayout(false);
            this.uc_panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txt_Id)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private Bunifu.Framework.UI.BunifuDatepicker dt_EndDate;
        private System.Windows.Forms.TextBox txt_Value;
        private System.Windows.Forms.Label label4;
        private Bunifu.Framework.UI.BunifuDatepicker dt_StartDate;
        private System.Windows.Forms.Label label5;
    }
}
