namespace statements_control.Register
{
    partial class uc_GoalRegister
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
            this.dt_EndDate = new System.Windows.Forms.DateTimePicker();
            this.uc_panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txt_Id)).BeginInit();
            this.SuspendLayout();
            // 
            // uc_panel
            // 
            this.uc_panel.Controls.Add(this.dt_EndDate);
            this.uc_panel.Controls.Add(this.label3);
            this.uc_panel.Controls.SetChildIndex(this.label3, 0);
            this.uc_panel.Controls.SetChildIndex(this.btn_Search, 0);
            this.uc_panel.Controls.SetChildIndex(this.txt_Id, 0);
            this.uc_panel.Controls.SetChildIndex(this.txt_Name, 0);
            this.uc_panel.Controls.SetChildIndex(this.dt_EndDate, 0);
            // 
            // txt_Name
            // 
            this.txt_Name.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(53, 219);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(176, 21);
            this.label3.TabIndex = 20;
            this.label3.Text = "Data de finalização";
            // 
            // dt_EndDate
            // 
            this.dt_EndDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dt_EndDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dt_EndDate.Location = new System.Drawing.Point(57, 258);
            this.dt_EndDate.Name = "dt_EndDate";
            this.dt_EndDate.Size = new System.Drawing.Size(149, 27);
            this.dt_EndDate.TabIndex = 31;
            // 
            // uc_GoalRegister
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = null;
            this.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.Name = "uc_GoalRegister";
            this.uc_panel.ResumeLayout(false);
            this.uc_panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txt_Id)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dt_EndDate;
    }
}
