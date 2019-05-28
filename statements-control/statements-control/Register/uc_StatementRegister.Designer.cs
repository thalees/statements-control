namespace statements_control.Register
{
    partial class uc_StatementRegister
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(uc_StatementRegister));
            this.btn_FindTypes = new Bunifu.Framework.UI.BunifuThinButton2();
            this.btn_FindEnvironments = new Bunifu.Framework.UI.BunifuThinButton2();
            this.txt_Type = new System.Windows.Forms.TextBox();
            this.txt_Environment = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_Value = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.dt_Date = new System.Windows.Forms.DateTimePicker();
            this.uc_panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txt_Id)).BeginInit();
            this.SuspendLayout();
            // 
            // uc_panel
            // 
            this.uc_panel.Controls.Add(this.dt_Date);
            this.uc_panel.Controls.Add(this.label6);
            this.uc_panel.Controls.Add(this.label5);
            this.uc_panel.Controls.Add(this.label4);
            this.uc_panel.Controls.Add(this.txt_Value);
            this.uc_panel.Controls.Add(this.label3);
            this.uc_panel.Controls.Add(this.txt_Environment);
            this.uc_panel.Controls.Add(this.txt_Type);
            this.uc_panel.Controls.Add(this.btn_FindEnvironments);
            this.uc_panel.Controls.Add(this.btn_FindTypes);
            this.uc_panel.Controls.SetChildIndex(this.btn_Search, 0);
            this.uc_panel.Controls.SetChildIndex(this.txt_Id, 0);
            this.uc_panel.Controls.SetChildIndex(this.txt_Name, 0);
            this.uc_panel.Controls.SetChildIndex(this.btn_FindTypes, 0);
            this.uc_panel.Controls.SetChildIndex(this.btn_FindEnvironments, 0);
            this.uc_panel.Controls.SetChildIndex(this.txt_Type, 0);
            this.uc_panel.Controls.SetChildIndex(this.txt_Environment, 0);
            this.uc_panel.Controls.SetChildIndex(this.label3, 0);
            this.uc_panel.Controls.SetChildIndex(this.txt_Value, 0);
            this.uc_panel.Controls.SetChildIndex(this.label4, 0);
            this.uc_panel.Controls.SetChildIndex(this.label5, 0);
            this.uc_panel.Controls.SetChildIndex(this.label6, 0);
            this.uc_panel.Controls.SetChildIndex(this.dt_Date, 0);
            // 
            // txt_Name
            // 
            this.txt_Name.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            // 
            // btn_Search
            // 
            this.btn_Search.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_Search.BackgroundImage")));
            this.btn_Search.ButtonText = "Consultar Ambientes";
            this.btn_Search.Click += new System.EventHandler(this.btn_Search_Click);
            // 
            // btn_FindTypes
            // 
            this.btn_FindTypes.ActiveBorderThickness = 1;
            this.btn_FindTypes.ActiveCornerRadius = 20;
            this.btn_FindTypes.ActiveFillColor = System.Drawing.Color.SeaGreen;
            this.btn_FindTypes.ActiveForecolor = System.Drawing.Color.White;
            this.btn_FindTypes.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.btn_FindTypes.BackColor = System.Drawing.SystemColors.Control;
            this.btn_FindTypes.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_FindTypes.BackgroundImage")));
            this.btn_FindTypes.ButtonText = "Buscar";
            this.btn_FindTypes.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_FindTypes.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_FindTypes.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.btn_FindTypes.IdleBorderThickness = 1;
            this.btn_FindTypes.IdleCornerRadius = 20;
            this.btn_FindTypes.IdleFillColor = System.Drawing.Color.White;
            this.btn_FindTypes.IdleForecolor = System.Drawing.SystemColors.MenuHighlight;
            this.btn_FindTypes.IdleLineColor = System.Drawing.SystemColors.MenuHighlight;
            this.btn_FindTypes.Location = new System.Drawing.Point(195, 230);
            this.btn_FindTypes.Margin = new System.Windows.Forms.Padding(5);
            this.btn_FindTypes.Name = "btn_FindTypes";
            this.btn_FindTypes.Size = new System.Drawing.Size(101, 42);
            this.btn_FindTypes.TabIndex = 20;
            this.btn_FindTypes.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btn_FindEnvironments
            // 
            this.btn_FindEnvironments.ActiveBorderThickness = 1;
            this.btn_FindEnvironments.ActiveCornerRadius = 20;
            this.btn_FindEnvironments.ActiveFillColor = System.Drawing.Color.SeaGreen;
            this.btn_FindEnvironments.ActiveForecolor = System.Drawing.Color.White;
            this.btn_FindEnvironments.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.btn_FindEnvironments.BackColor = System.Drawing.SystemColors.Control;
            this.btn_FindEnvironments.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_FindEnvironments.BackgroundImage")));
            this.btn_FindEnvironments.ButtonText = "Buscar";
            this.btn_FindEnvironments.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_FindEnvironments.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_FindEnvironments.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.btn_FindEnvironments.IdleBorderThickness = 1;
            this.btn_FindEnvironments.IdleCornerRadius = 20;
            this.btn_FindEnvironments.IdleFillColor = System.Drawing.Color.White;
            this.btn_FindEnvironments.IdleForecolor = System.Drawing.SystemColors.MenuHighlight;
            this.btn_FindEnvironments.IdleLineColor = System.Drawing.SystemColors.MenuHighlight;
            this.btn_FindEnvironments.Location = new System.Drawing.Point(195, 290);
            this.btn_FindEnvironments.Margin = new System.Windows.Forms.Padding(5);
            this.btn_FindEnvironments.Name = "btn_FindEnvironments";
            this.btn_FindEnvironments.Size = new System.Drawing.Size(101, 42);
            this.btn_FindEnvironments.TabIndex = 21;
            this.btn_FindEnvironments.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txt_Type
            // 
            this.txt_Type.Location = new System.Drawing.Point(58, 237);
            this.txt_Type.Margin = new System.Windows.Forms.Padding(4);
            this.txt_Type.Name = "txt_Type";
            this.txt_Type.Size = new System.Drawing.Size(127, 22);
            this.txt_Type.TabIndex = 22;
            // 
            // txt_Environment
            // 
            this.txt_Environment.Location = new System.Drawing.Point(58, 297);
            this.txt_Environment.Margin = new System.Windows.Forms.Padding(4);
            this.txt_Environment.Name = "txt_Environment";
            this.txt_Environment.Size = new System.Drawing.Size(127, 22);
            this.txt_Environment.TabIndex = 23;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(290, 142);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 21);
            this.label3.TabIndex = 25;
            this.label3.Text = "Data";
            // 
            // txt_Value
            // 
            this.txt_Value.Location = new System.Drawing.Point(328, 237);
            this.txt_Value.Margin = new System.Windows.Forms.Padding(4);
            this.txt_Value.Name = "txt_Value";
            this.txt_Value.Size = new System.Drawing.Size(115, 22);
            this.txt_Value.TabIndex = 26;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(54, 213);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 21);
            this.label4.TabIndex = 27;
            this.label4.Text = "Tipo";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(54, 275);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(92, 21);
            this.label5.TabIndex = 28;
            this.label5.Text = "Ambiente";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(324, 213);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(54, 21);
            this.label6.TabIndex = 29;
            this.label6.Text = "Valor";
            // 
            // dt_Date
            // 
            this.dt_Date.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dt_Date.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dt_Date.Location = new System.Drawing.Point(294, 168);
            this.dt_Date.Name = "dt_Date";
            this.dt_Date.Size = new System.Drawing.Size(149, 27);
            this.dt_Date.TabIndex = 30;
            // 
            // uc_StatementRegister
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.Name = "uc_StatementRegister";
            this.uc_panel.ResumeLayout(false);
            this.uc_panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txt_Id)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        protected Bunifu.Framework.UI.BunifuThinButton2 btn_FindTypes;
        protected Bunifu.Framework.UI.BunifuThinButton2 btn_FindEnvironments;
        private System.Windows.Forms.TextBox txt_Environment;
        private System.Windows.Forms.TextBox txt_Type;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_Value;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dt_Date;
    }
}
