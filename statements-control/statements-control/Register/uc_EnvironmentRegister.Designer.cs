namespace statements_control.Register
{
    partial class uc_EnvironmentRegister
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
            this.txt_Name = new System.Windows.Forms.TextBox();
            this.uc_panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_Search
            // 
            this.btn_Search.Visible = false;
            // 
            // uc_panel
            // 
            this.uc_panel.Controls.Add(this.txt_Name);
            this.uc_panel.Controls.SetChildIndex(this.btn_Search, 0);
            this.uc_panel.Controls.SetChildIndex(this.txt_Name, 0);
            // 
            // txt_Name
            // 
            this.txt_Name.Location = new System.Drawing.Point(180, 182);
            this.txt_Name.Name = "txt_Name";
            this.txt_Name.Size = new System.Drawing.Size(100, 22);
            this.txt_Name.TabIndex = 5;
            // 
            // uc_EnvironmentRegister
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Name = "uc_EnvironmentRegister";
            this.uc_panel.ResumeLayout(false);
            this.uc_panel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txt_Name;
    }
}
