using Library;
using Library.DAOs;
using Library.Security;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
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

        private void CreateDatabase(string databaseName)
        {
            if (File.Exists(@"..\..\..\Database\Stored Procedures\Database.sql"))
            {
                try
                {
                    FileInfo file = new FileInfo(@"..\..\..\Database\Stored Procedures\Database.sql");
                    string script = file.OpenText().ReadToEnd();
                    script = script.Replace("\n", " ");
                    script = script.Replace("\r", " ");
                    script = script.Replace("\t", " ");

                    string[] commandArray = script.Split(new string[] { "GO" }, StringSplitOptions.RemoveEmptyEntries);
                    for (int i = 0; i < commandArray.Length; i++)
                    {
                        Methods.SQLExecuteNonQuery(commandArray[i], null);
                    }
                    //Methods.SQLExecuteNonQuery(script, null);

                    SqlParameter[] parameter = { new SqlParameter("databaseName", databaseName) };
                    Methods.SQLNonQueryProcedure("usp_CreateDatabase", parameter);
                }
                catch
                {
                    SqlParameter[] parameter = { new SqlParameter("databaseName", databaseName) };
                    Methods.SQLNonQueryProcedure("usp_CreateDatabase", parameter);
                }
            }
        }

        private void ChangeButtonColor(Bunifu.Framework.UI.BunifuThinButton2 button, Color color)
        {
            button.IdleForecolor = color;
            button.IdleLineColor = color;
            button.ActiveFillColor = color;
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
                    string encrypted = txtDbCatalog.Text + "|" + txtDbUsername.Text + "|" + txtDbPassword.Text;
                    encrypted = Encryption.EncryptString(encrypted);
                    File.WriteAllText("DataBaseParameters.txt", encrypted);
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
            bool tryWithMaster = false;
            try
            {
                using (ConnectionDB.GetConnection())
                {
                    ChangeButtonColor(btn_TestConnection, Color.SeaGreen);
                }
            }
            catch
            {
                tryWithMaster = true;
            }

            if (!tryWithMaster)
                return;

            string lastCatalogValue = ConnectionDB.getCatalogDB();
            try
            {
                ConnectionDB.setCatalogDB("master", this.GetType());
                using (ConnectionDB.GetConnection())
                {
                    if(MessageBox.Show($"Não foi encontrado nenhum banco de dados com o nome: {lastCatalogValue}" +
                        $"\n Gostaria de criar agora?", "Não encontrado.",
                        MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        CreateDatabase(txtDbCatalog.Text);
                        ChangeButtonColor(btn_TestConnection, Color.SeaGreen);
                    }
                    else
                        ChangeButtonColor(btn_TestConnection, Color.Red);

                }
            }
            catch
            {
                MessageBox.Show("Suas credenciais com o banco de dados não estão corretas.", "Erro!", 
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
                ChangeButtonColor(btn_TestConnection, Color.Red);
            }
            finally
            {
                ConnectionDB.setCatalogDB(lastCatalogValue, this.GetType());
            }
        }
    }
}
