namespace statements_control
{
    partial class uc_DefaultRegister
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(uc_DefaultRegister));
            this.btn_Search = new Bunifu.Framework.UI.BunifuThinButton2();
            this.uc_panel = new System.Windows.Forms.Panel();
            this.txt_Name = new System.Windows.Forms.TextBox();
            this.txt_Id = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_Cancel = new System.Windows.Forms.Button();
            this.btn_Save = new System.Windows.Forms.Button();
            this.btn_Next = new System.Windows.Forms.Button();
            this.btn_Previous = new System.Windows.Forms.Button();
            this.btn_Last = new System.Windows.Forms.Button();
            this.btn_First = new System.Windows.Forms.Button();
            this.btn_Delete = new System.Windows.Forms.Button();
            this.btn_Update = new System.Windows.Forms.Button();
            this.btn_Insert = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.uc_panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txt_Id)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_Search
            // 
            this.btn_Search.ActiveBorderThickness = 1;
            this.btn_Search.ActiveCornerRadius = 20;
            this.btn_Search.ActiveFillColor = System.Drawing.Color.SeaGreen;
            this.btn_Search.ActiveForecolor = System.Drawing.Color.White;
            this.btn_Search.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.btn_Search.BackColor = System.Drawing.SystemColors.Control;
            this.btn_Search.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_Search.BackgroundImage")));
            this.btn_Search.ButtonText = "ThinButton";
            this.btn_Search.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Search.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Search.ForeColor = System.Drawing.Color.SeaGreen;
            this.btn_Search.IdleBorderThickness = 1;
            this.btn_Search.IdleCornerRadius = 20;
            this.btn_Search.IdleFillColor = System.Drawing.Color.White;
            this.btn_Search.IdleForecolor = System.Drawing.Color.SeaGreen;
            this.btn_Search.IdleLineColor = System.Drawing.Color.SeaGreen;
            this.btn_Search.Location = new System.Drawing.Point(621, 23);
            this.btn_Search.Margin = new System.Windows.Forms.Padding(5);
            this.btn_Search.Name = "btn_Search";
            this.btn_Search.Size = new System.Drawing.Size(111, 41);
            this.btn_Search.TabIndex = 0;
            this.btn_Search.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // uc_panel
            // 
            this.uc_panel.Controls.Add(this.txt_Name);
            this.uc_panel.Controls.Add(this.txt_Id);
            this.uc_panel.Controls.Add(this.label2);
            this.uc_panel.Controls.Add(this.label1);
            this.uc_panel.Controls.Add(this.btn_Cancel);
            this.uc_panel.Controls.Add(this.btn_Save);
            this.uc_panel.Controls.Add(this.btn_Next);
            this.uc_panel.Controls.Add(this.btn_Previous);
            this.uc_panel.Controls.Add(this.btn_Last);
            this.uc_panel.Controls.Add(this.btn_First);
            this.uc_panel.Controls.Add(this.btn_Delete);
            this.uc_panel.Controls.Add(this.btn_Update);
            this.uc_panel.Controls.Add(this.btn_Insert);
            this.uc_panel.Controls.Add(this.btn_Search);
            this.uc_panel.Location = new System.Drawing.Point(1, 0);
            this.uc_panel.Name = "uc_panel";
            this.uc_panel.Size = new System.Drawing.Size(759, 541);
            this.uc_panel.TabIndex = 1;
            // 
            // txt_Name
            // 
            this.txt_Name.Location = new System.Drawing.Point(152, 182);
            this.txt_Name.Name = "txt_Name";
            this.txt_Name.Size = new System.Drawing.Size(100, 22);
            this.txt_Name.TabIndex = 5;
            // 
            // txt_Id
            // 
            this.txt_Id.Location = new System.Drawing.Point(61, 182);
            this.txt_Id.Name = "txt_Id";
            this.txt_Id.Size = new System.Drawing.Size(61, 22);
            this.txt_Id.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(60, 151);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(19, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "Id";
            // 
            // btn_Cancel
            // 
            this.btn_Cancel.Location = new System.Drawing.Point(193, 381);
            this.btn_Cancel.Name = "btn_Cancel";
            this.btn_Cancel.Size = new System.Drawing.Size(71, 22);
            this.btn_Cancel.TabIndex = 2;
            this.btn_Cancel.Text = "Cancelar";
            this.btn_Cancel.UseVisualStyleBackColor = true;
            this.btn_Cancel.Click += new System.EventHandler(this.btn_Cancel_Click);
            // 
            // btn_Save
            // 
            this.btn_Save.Location = new System.Drawing.Point(65, 381);
            this.btn_Save.Name = "btn_Save";
            this.btn_Save.Size = new System.Drawing.Size(71, 22);
            this.btn_Save.TabIndex = 2;
            this.btn_Save.Text = "Salvar";
            this.btn_Save.UseVisualStyleBackColor = true;
            this.btn_Save.Click += new System.EventHandler(this.btn_Save_Click);
            // 
            // btn_Next
            // 
            this.btn_Next.Location = new System.Drawing.Point(599, 313);
            this.btn_Next.Name = "btn_Next";
            this.btn_Next.Size = new System.Drawing.Size(71, 22);
            this.btn_Next.TabIndex = 2;
            this.btn_Next.Text = "Proximo";
            this.btn_Next.UseVisualStyleBackColor = true;
            this.btn_Next.Click += new System.EventHandler(this.btn_Next_Click);
            // 
            // btn_Previous
            // 
            this.btn_Previous.Location = new System.Drawing.Point(599, 251);
            this.btn_Previous.Name = "btn_Previous";
            this.btn_Previous.Size = new System.Drawing.Size(71, 22);
            this.btn_Previous.TabIndex = 2;
            this.btn_Previous.Text = "Anterior";
            this.btn_Previous.UseVisualStyleBackColor = true;
            this.btn_Previous.Click += new System.EventHandler(this.btn_Previous_Click);
            // 
            // btn_Last
            // 
            this.btn_Last.Location = new System.Drawing.Point(599, 195);
            this.btn_Last.Name = "btn_Last";
            this.btn_Last.Size = new System.Drawing.Size(71, 22);
            this.btn_Last.TabIndex = 2;
            this.btn_Last.Text = "Último";
            this.btn_Last.UseVisualStyleBackColor = true;
            this.btn_Last.Click += new System.EventHandler(this.btn_Last_Click);
            // 
            // btn_First
            // 
            this.btn_First.Location = new System.Drawing.Point(599, 135);
            this.btn_First.Name = "btn_First";
            this.btn_First.Size = new System.Drawing.Size(71, 22);
            this.btn_First.TabIndex = 2;
            this.btn_First.Text = "Primeiro";
            this.btn_First.UseVisualStyleBackColor = true;
            this.btn_First.Click += new System.EventHandler(this.btn_First_Click);
            // 
            // btn_Delete
            // 
            this.btn_Delete.Location = new System.Drawing.Point(267, 82);
            this.btn_Delete.Name = "btn_Delete";
            this.btn_Delete.Size = new System.Drawing.Size(71, 22);
            this.btn_Delete.TabIndex = 2;
            this.btn_Delete.Text = "Deletar";
            this.btn_Delete.UseVisualStyleBackColor = true;
            this.btn_Delete.Click += new System.EventHandler(this.btn_Delete_Click);
            // 
            // btn_Update
            // 
            this.btn_Update.Location = new System.Drawing.Point(167, 82);
            this.btn_Update.Name = "btn_Update";
            this.btn_Update.Size = new System.Drawing.Size(71, 22);
            this.btn_Update.TabIndex = 2;
            this.btn_Update.Text = "Atualizar";
            this.btn_Update.UseVisualStyleBackColor = true;
            this.btn_Update.Click += new System.EventHandler(this.btn_Update_Click);
            // 
            // btn_Insert
            // 
            this.btn_Insert.Location = new System.Drawing.Point(61, 82);
            this.btn_Insert.Name = "btn_Insert";
            this.btn_Insert.Size = new System.Drawing.Size(75, 23);
            this.btn_Insert.TabIndex = 1;
            this.btn_Insert.Text = "Inserir";
            this.btn_Insert.UseVisualStyleBackColor = true;
            this.btn_Insert.Click += new System.EventHandler(this.btn_Insert_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(149, 151);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Nome";
            // 
            // uc_DefaultRegister
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.uc_panel);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "uc_DefaultRegister";
            this.Size = new System.Drawing.Size(760, 542);
            this.uc_panel.ResumeLayout(false);
            this.uc_panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txt_Id)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        protected Bunifu.Framework.UI.BunifuThinButton2 btn_Search;
        protected System.Windows.Forms.Panel uc_panel;
        private System.Windows.Forms.Button btn_First;
        private System.Windows.Forms.Button btn_Delete;
        private System.Windows.Forms.Button btn_Update;
        private System.Windows.Forms.Button btn_Insert;
        private System.Windows.Forms.Button btn_Cancel;
        private System.Windows.Forms.Button btn_Save;
        private System.Windows.Forms.Button btn_Next;
        private System.Windows.Forms.Button btn_Previous;
        private System.Windows.Forms.Button btn_Last;
        private System.Windows.Forms.Label label1;
        protected System.Windows.Forms.NumericUpDown txt_Id;
        protected System.Windows.Forms.TextBox txt_Name;
        private System.Windows.Forms.Label label2;
    }
}
