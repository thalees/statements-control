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
            this.uc_panel = new System.Windows.Forms.Panel();
            this.btn_Search = new Bunifu.Framework.UI.BunifuThinButton2();
            this.txt_Name = new System.Windows.Forms.TextBox();
            this.txt_Id = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_Insert = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_Update = new System.Windows.Forms.Button();
            this.btn_Delete = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btn_Next = new System.Windows.Forms.Button();
            this.btn_Last = new System.Windows.Forms.Button();
            this.btn_First = new System.Windows.Forms.Button();
            this.btn_Previous = new System.Windows.Forms.Button();
            this.btn_Cancel = new System.Windows.Forms.Button();
            this.btn_Save = new System.Windows.Forms.Button();
            this.uc_panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txt_Id)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // uc_panel
            // 
            this.uc_panel.BackColor = System.Drawing.SystemColors.Control;
            this.uc_panel.Controls.Add(this.btn_Cancel);
            this.uc_panel.Controls.Add(this.btn_Save);
            this.uc_panel.Controls.Add(this.groupBox2);
            this.uc_panel.Controls.Add(this.groupBox1);
            this.uc_panel.Controls.Add(this.btn_Search);
            this.uc_panel.Controls.Add(this.txt_Name);
            this.uc_panel.Controls.Add(this.txt_Id);
            this.uc_panel.Controls.Add(this.label2);
            this.uc_panel.Controls.Add(this.label1);
            this.uc_panel.Location = new System.Drawing.Point(1, 0);
            this.uc_panel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.uc_panel.Name = "uc_panel";
            this.uc_panel.Size = new System.Drawing.Size(759, 542);
            this.uc_panel.TabIndex = 1;
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
            this.btn_Search.ButtonText = "Consulte os registros";
            this.btn_Search.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Search.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Search.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.btn_Search.IdleBorderThickness = 1;
            this.btn_Search.IdleCornerRadius = 20;
            this.btn_Search.IdleFillColor = System.Drawing.Color.White;
            this.btn_Search.IdleForecolor = System.Drawing.SystemColors.MenuHighlight;
            this.btn_Search.IdleLineColor = System.Drawing.SystemColors.MenuHighlight;
            this.btn_Search.Location = new System.Drawing.Point(66, 370);
            this.btn_Search.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.btn_Search.Name = "btn_Search";
            this.btn_Search.Size = new System.Drawing.Size(239, 42);
            this.btn_Search.TabIndex = 20;
            this.btn_Search.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txt_Name
            // 
            this.txt_Name.Location = new System.Drawing.Point(146, 171);
            this.txt_Name.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_Name.Name = "txt_Name";
            this.txt_Name.Size = new System.Drawing.Size(121, 22);
            this.txt_Name.TabIndex = 5;
            // 
            // txt_Id
            // 
            this.txt_Id.Location = new System.Drawing.Point(57, 171);
            this.txt_Id.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_Id.Name = "txt_Id";
            this.txt_Id.Size = new System.Drawing.Size(61, 22);
            this.txt_Id.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(142, 142);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 21);
            this.label2.TabIndex = 3;
            this.label2.Text = "Nome";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(53, 142);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(27, 21);
            this.label1.TabIndex = 3;
            this.label1.Text = "Id";
            // 
            // btn_Insert
            // 
            this.btn_Insert.Location = new System.Drawing.Point(30, 35);
            this.btn_Insert.Name = "btn_Insert";
            this.btn_Insert.Size = new System.Drawing.Size(99, 39);
            this.btn_Insert.TabIndex = 21;
            this.btn_Insert.Text = "Inserir";
            this.btn_Insert.UseVisualStyleBackColor = true;
            this.btn_Insert.Click += new System.EventHandler(this.btn_Insert_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btn_Delete);
            this.groupBox1.Controls.Add(this.btn_Update);
            this.groupBox1.Controls.Add(this.btn_Insert);
            this.groupBox1.Location = new System.Drawing.Point(57, 39);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(444, 91);
            this.groupBox1.TabIndex = 22;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Ações";
            // 
            // btn_Update
            // 
            this.btn_Update.Location = new System.Drawing.Point(140, 35);
            this.btn_Update.Name = "btn_Update";
            this.btn_Update.Size = new System.Drawing.Size(99, 39);
            this.btn_Update.TabIndex = 21;
            this.btn_Update.Text = "Atualizar";
            this.btn_Update.UseVisualStyleBackColor = true;
            this.btn_Update.Click += new System.EventHandler(this.btn_Update_Click);
            // 
            // btn_Delete
            // 
            this.btn_Delete.Location = new System.Drawing.Point(251, 35);
            this.btn_Delete.Name = "btn_Delete";
            this.btn_Delete.Size = new System.Drawing.Size(99, 39);
            this.btn_Delete.TabIndex = 21;
            this.btn_Delete.Text = "Deletar";
            this.btn_Delete.UseVisualStyleBackColor = true;
            this.btn_Delete.Click += new System.EventHandler(this.btn_Delete_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btn_Next);
            this.groupBox2.Controls.Add(this.btn_Previous);
            this.groupBox2.Controls.Add(this.btn_Last);
            this.groupBox2.Controls.Add(this.btn_First);
            this.groupBox2.Location = new System.Drawing.Point(517, 39);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(140, 311);
            this.groupBox2.TabIndex = 23;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Ações";
            // 
            // btn_Next
            // 
            this.btn_Next.Location = new System.Drawing.Point(22, 246);
            this.btn_Next.Name = "btn_Next";
            this.btn_Next.Size = new System.Drawing.Size(99, 39);
            this.btn_Next.TabIndex = 21;
            this.btn_Next.Text = "Próximo";
            this.btn_Next.UseVisualStyleBackColor = true;
            this.btn_Next.Click += new System.EventHandler(this.btn_Next_Click);
            // 
            // btn_Last
            // 
            this.btn_Last.Location = new System.Drawing.Point(22, 103);
            this.btn_Last.Name = "btn_Last";
            this.btn_Last.Size = new System.Drawing.Size(99, 39);
            this.btn_Last.TabIndex = 21;
            this.btn_Last.Text = "Último";
            this.btn_Last.UseVisualStyleBackColor = true;
            this.btn_Last.Click += new System.EventHandler(this.btn_Last_Click);
            // 
            // btn_First
            // 
            this.btn_First.Location = new System.Drawing.Point(22, 35);
            this.btn_First.Name = "btn_First";
            this.btn_First.Size = new System.Drawing.Size(99, 39);
            this.btn_First.TabIndex = 21;
            this.btn_First.Text = "Primeiro";
            this.btn_First.UseVisualStyleBackColor = true;
            this.btn_First.Click += new System.EventHandler(this.btn_First_Click);
            // 
            // btn_Previous
            // 
            this.btn_Previous.Location = new System.Drawing.Point(22, 171);
            this.btn_Previous.Name = "btn_Previous";
            this.btn_Previous.Size = new System.Drawing.Size(99, 39);
            this.btn_Previous.TabIndex = 21;
            this.btn_Previous.Text = "Anterior";
            this.btn_Previous.UseVisualStyleBackColor = true;
            this.btn_Previous.Click += new System.EventHandler(this.btn_Previous_Click);
            // 
            // btn_Cancel
            // 
            this.btn_Cancel.Location = new System.Drawing.Point(420, 373);
            this.btn_Cancel.Name = "btn_Cancel";
            this.btn_Cancel.Size = new System.Drawing.Size(99, 39);
            this.btn_Cancel.TabIndex = 24;
            this.btn_Cancel.Text = "Cancelar";
            this.btn_Cancel.UseVisualStyleBackColor = true;
            this.btn_Cancel.Click += new System.EventHandler(this.btn_Cancel_Click);
            // 
            // btn_Save
            // 
            this.btn_Save.Location = new System.Drawing.Point(539, 373);
            this.btn_Save.Name = "btn_Save";
            this.btn_Save.Size = new System.Drawing.Size(99, 39);
            this.btn_Save.TabIndex = 25;
            this.btn_Save.Text = "Salvar";
            this.btn_Save.UseVisualStyleBackColor = true;
            this.btn_Save.Click += new System.EventHandler(this.btn_Save_Click);
            // 
            // uc_DefaultRegister
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::statements_control.Properties.Resources.background_register;
            this.Controls.Add(this.uc_panel);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "uc_DefaultRegister";
            this.Size = new System.Drawing.Size(760, 542);
            this.uc_panel.ResumeLayout(false);
            this.uc_panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txt_Id)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        protected System.Windows.Forms.Panel uc_panel;
        private System.Windows.Forms.Label label1;
        protected System.Windows.Forms.NumericUpDown txt_Id;
        protected System.Windows.Forms.TextBox txt_Name;
        private System.Windows.Forms.Label label2;
        protected Bunifu.Framework.UI.BunifuThinButton2 btn_Search;
        private System.Windows.Forms.Button btn_Cancel;
        private System.Windows.Forms.Button btn_Save;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btn_Next;
        private System.Windows.Forms.Button btn_Previous;
        private System.Windows.Forms.Button btn_Last;
        private System.Windows.Forms.Button btn_First;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btn_Delete;
        private System.Windows.Forms.Button btn_Update;
        private System.Windows.Forms.Button btn_Insert;
    }
}
