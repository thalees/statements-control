﻿namespace statements_control.Register
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
            this.dt_EndDate = new Bunifu.Framework.UI.BunifuDatepicker();
            this.uc_panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txt_Id)).BeginInit();
            this.SuspendLayout();
            // 
            // uc_panel
            // 
            this.uc_panel.Controls.Add(this.dt_EndDate);
            this.uc_panel.Controls.SetChildIndex(this.btn_Search, 0);
            this.uc_panel.Controls.SetChildIndex(this.txt_Id, 0);
            this.uc_panel.Controls.SetChildIndex(this.txt_Name, 0);
            this.uc_panel.Controls.SetChildIndex(this.dt_EndDate, 0);
            // 
            // dt_EndDate
            // 
            this.dt_EndDate.BackColor = System.Drawing.Color.SeaGreen;
            this.dt_EndDate.BorderRadius = 0;
            this.dt_EndDate.ForeColor = System.Drawing.Color.White;
            this.dt_EndDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dt_EndDate.FormatCustom = null;
            this.dt_EndDate.Location = new System.Drawing.Point(61, 230);
            this.dt_EndDate.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dt_EndDate.Name = "dt_EndDate";
            this.dt_EndDate.Size = new System.Drawing.Size(160, 31);
            this.dt_EndDate.TabIndex = 6;
            this.dt_EndDate.Value = new System.DateTime(2019, 5, 26, 23, 12, 9, 637);
            // 
            // uc_GoalRegister
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Name = "uc_GoalRegister";
            this.uc_panel.ResumeLayout(false);
            this.uc_panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txt_Id)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuDatepicker dt_EndDate;
    }
}
