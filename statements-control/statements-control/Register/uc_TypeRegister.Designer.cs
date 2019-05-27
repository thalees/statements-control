namespace statements_control
{
    partial class uc_TypeRegister
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
            this.txt_Description = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_Action = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.uc_panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txt_Id)).BeginInit();
            this.SuspendLayout();
            // 
            // uc_panel
            // 
            this.uc_panel.Controls.Add(this.label3);
            this.uc_panel.Controls.Add(this.txt_Action);
            this.uc_panel.Controls.Add(this.label2);
            this.uc_panel.Controls.Add(this.txt_Description);
            this.uc_panel.Controls.SetChildIndex(this.btn_Search, 0);
            this.uc_panel.Controls.SetChildIndex(this.txt_Id, 0);
            this.uc_panel.Controls.SetChildIndex(this.txt_Name, 0);
            this.uc_panel.Controls.SetChildIndex(this.txt_Description, 0);
            this.uc_panel.Controls.SetChildIndex(this.label2, 0);
            this.uc_panel.Controls.SetChildIndex(this.txt_Action, 0);
            this.uc_panel.Controls.SetChildIndex(this.label3, 0);
            // 
            // txt_Description
            // 
            this.txt_Description.Location = new System.Drawing.Point(291, 182);
            this.txt_Description.Multiline = true;
            this.txt_Description.Name = "txt_Description";
            this.txt_Description.Size = new System.Drawing.Size(144, 66);
            this.txt_Description.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(288, 151);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 17);
            this.label2.TabIndex = 7;
            this.label2.Text = "Descrição";
            // 
            // txt_Action
            // 
            this.txt_Action.Location = new System.Drawing.Point(291, 293);
            this.txt_Action.Name = "txt_Action";
            this.txt_Action.Size = new System.Drawing.Size(100, 22);
            this.txt_Action.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(288, 273);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 17);
            this.label3.TabIndex = 9;
            this.label3.Text = "Ação";
            // 
            // uc_TypeRegister
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Name = "uc_TypeRegister";
            this.uc_panel.ResumeLayout(false);
            this.uc_panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txt_Id)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txt_Description;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_Action;
    }
}
