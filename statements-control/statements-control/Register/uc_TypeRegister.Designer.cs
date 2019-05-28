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
            this.label4 = new System.Windows.Forms.Label();
            this.txt_Description = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cb_Action = new System.Windows.Forms.ComboBox();
            this.uc_panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txt_Id)).BeginInit();
            this.SuspendLayout();
            // 
            // uc_panel
            // 
            this.uc_panel.Controls.Add(this.cb_Action);
            this.uc_panel.Controls.Add(this.label3);
            this.uc_panel.Controls.Add(this.label4);
            this.uc_panel.Controls.Add(this.txt_Description);
            this.uc_panel.Controls.SetChildIndex(this.btn_Search, 0);
            this.uc_panel.Controls.SetChildIndex(this.txt_Id, 0);
            this.uc_panel.Controls.SetChildIndex(this.txt_Name, 0);
            this.uc_panel.Controls.SetChildIndex(this.txt_Description, 0);
            this.uc_panel.Controls.SetChildIndex(this.label4, 0);
            this.uc_panel.Controls.SetChildIndex(this.label3, 0);
            this.uc_panel.Controls.SetChildIndex(this.cb_Action, 0);
            // 
            // txt_Name
            // 
            this.txt_Name.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(52, 214);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(94, 21);
            this.label4.TabIndex = 22;
            this.label4.Text = "Descrição";
            // 
            // txt_Description
            // 
            this.txt_Description.Location = new System.Drawing.Point(56, 244);
            this.txt_Description.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_Description.Multiline = true;
            this.txt_Description.Name = "txt_Description";
            this.txt_Description.Size = new System.Drawing.Size(369, 73);
            this.txt_Description.TabIndex = 21;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(286, 140);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 21);
            this.label3.TabIndex = 23;
            this.label3.Text = "Ação";
            // 
            // cb_Action
            // 
            this.cb_Action.FormattingEnabled = true;
            this.cb_Action.Items.AddRange(new object[] {
            "Gasto",
            "Lucro"});
            this.cb_Action.Location = new System.Drawing.Point(290, 169);
            this.cb_Action.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cb_Action.Name = "cb_Action";
            this.cb_Action.Size = new System.Drawing.Size(135, 24);
            this.cb_Action.TabIndex = 24;
            // 
            // uc_TypeRegister
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.Name = "uc_TypeRegister";
            this.uc_panel.ResumeLayout(false);
            this.uc_panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txt_Id)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox cb_Action;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_Description;
    }
}
