using Library;
using Library.DAOs;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace statements_control
{
    public partial class fr_DataBaseParameters : Form
    {
        public fr_DataBaseParameters()
        {
            InitializeComponent();
        }

        private void btn_Connect_Click(object sender, EventArgs e)
        {
            errorProvider.Clear();

            bool foundError = false;
            if (string.IsNullOrEmpty(txtDbCatalog.Text))
            {
                foundError = true;
                errorProvider.SetError(txtDbCatalog, "Digite uma instância válida.");
            }
            if (string.IsNullOrEmpty(txtDbUsername.Text))
            {
                foundError = true;
                errorProvider.SetError(txtDbUsername, "Digite um nome válido.");
            }
            if (string.IsNullOrEmpty(txtDbPassword.Text))
            {
                foundError = true;
                errorProvider.SetError(txtDbPassword, "Digite uma senha válida.");
            }

            if (!foundError)
            {
                if (ConnectionDB.setCatalogDB(txtDbCatalog.Text, this.GetType()) &&
                    ConnectionDB.setUsernameDB(txtDbUsername.Text, this.GetType()) &&
                    ConnectionDB.setPasswordDB(txtDbPassword.Text, this.GetType()))
                {
                    MessageBox.Show("Parâmetros do Banco de Dados alterados com sucesso!", "Sucesso",
                                     MessageBoxButtons.OK, MessageBoxIcon.Information);
                    MessageBox.Show(Encryption
                }
                else
                    MessageBox.Show("Erro ao alterar parâmetros do Banco de Dados", "Erro!",
                                     MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_Back_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btn_TestConnection_Click(object sender, EventArgs e)
        {
            try
            {
                using (ConnectionDB.GetConnection())
                {
                    btn_TestConnection.IdleForecolor = Color.SeaGreen;
                    btn_TestConnection.IdleLineColor = Color.SeaGreen;
                    btn_TestConnection.ActiveFillColor = Color.SeaGreen;
                }
            }
            catch
            {
                btn_TestConnection.IdleForecolor = Color.Red;
                btn_TestConnection.IdleLineColor = Color.Red;
                btn_TestConnection.ActiveFillColor = Color.Red;
            }
        }
    }
}
