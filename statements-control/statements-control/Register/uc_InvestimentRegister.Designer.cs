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
            this.label4 = new System.Windows.Forms.Label();
            this.txt_Value = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.dt_EndDate = new System.Windows.Forms.DateTimePicker();
            this.dt_StartDate = new System.Windows.Forms.DateTimePicker();
            this.uc_panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txt_Id)).BeginInit();
            this.SuspendLayout();
            // 
            // uc_panel
            // 
            this.uc_panel.Controls.Add(this.dt_StartDate);
            this.uc_panel.Controls.Add(this.dt_EndDate);
            this.uc_panel.Controls.Add(this.label5);
            this.uc_panel.Controls.Add(this.txt_Value);
            this.uc_panel.Controls.Add(this.label4);
            this.uc_panel.Controls.Add(this.label3);
            this.uc_panel.Controls.SetChildIndex(this.label3, 0);
            this.uc_panel.Controls.SetChildIndex(this.label4, 0);
            this.uc_panel.Controls.SetChildIndex(this.txt_Value, 0);
            this.uc_panel.Controls.SetChildIndex(this.label5, 0);
            this.uc_panel.Controls.SetChildIndex(this.btn_Search, 0);
            this.uc_panel.Controls.SetChildIndex(this.txt_Id, 0);
            this.uc_panel.Controls.SetChildIndex(this.txt_Name, 0);
            this.uc_panel.Controls.SetChildIndex(this.dt_EndDate, 0);
            this.uc_panel.Controls.SetChildIndex(this.dt_StartDate, 0);
            // 
            // txt_Name
            // 
            this.txt_Name.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(263, 221);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 21);
            this.label3.TabIndex = 22;
            this.label3.Text = "Data final";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(53, 221);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(104, 21);
            this.label4.TabIndex = 24;
            this.label4.Text = "Data inicial";
            // 
            // txt_Value
            // 
            this.txt_Value.Location = new System.Drawing.Point(294, 171);
            this.txt_Value.Margin = new System.Windows.Forms.Padding(4);
            this.txt_Value.Name = "txt_Value";
            this.txt_Value.Size = new System.Drawing.Size(121, 22);
            this.txt_Value.TabIndex = 25;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(290, 141);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(54, 21);
            this.label5.TabIndex = 26;
            this.label5.Text = "Valor";
            // 
            // dt_EndDate
            // 
            this.dt_EndDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dt_EndDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dt_EndDate.Location = new System.Drawing.Point(267, 258);
            this.dt_EndDate.Name = "dt_EndDate";
            this.dt_EndDate.Size = new System.Drawing.Size(149, 27);
            this.dt_EndDate.TabIndex = 31;
            // 
            // dt_StartDate
            // 
            this.dt_StartDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dt_StartDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dt_StartDate.Location = new System.Drawing.Point(57, 258);
            this.dt_StartDate.Name = "dt_StartDate";
            this.dt_StartDate.Size = new System.Drawing.Size(149, 27);
            this.dt_StartDate.TabIndex = 32;
            // 
            // uc_InvestimentRegister
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.Name = "uc_InvestimentRegister";
            this.uc_panel.ResumeLayout(false);
            this.uc_panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txt_Id)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_Value;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dt_StartDate;
        private System.Windows.Forms.DateTimePicker dt_EndDate;
    }
}
