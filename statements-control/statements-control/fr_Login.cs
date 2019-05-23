using Library.DAOs;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace statements_control
{
    public partial class fr_Login : Form
    {
        public fr_Login()
        {
            InitializeComponent();
        }

        private void ChangeButtonColor(Bunifu.Framework.UI.BunifuThinButton2 button, Color color)
        {
            button.IdleForecolor = color;
            button.IdleLineColor = color;
            button.ActiveFillColor = color;
        }
        private void btn_Database_Click(object sender, EventArgs e)
        {
            fr_DataBaseParameters dataBaseParameters = new fr_DataBaseParameters();
            dataBaseParameters.ShowDialog();
        }

        private void btn_login_Click(object sender, EventArgs e)
        {

            try
            {
                using (ConnectionDB.GetConnection())
                {
                    ChangeButtonColor(btn_Database, Color.SeaGreen);
                }
            }
            catch
            {
                MessageBox.Show("Erro ao conectar no Banco de Dados.", "Erro!",
                     MessageBoxButtons.OK, MessageBoxIcon.Error);
                ChangeButtonColor(btn_Database, Color.Red);
            }     
        }
    }
}
