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
using System.Threading;
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

        private bool ExecuteSQLFiles(string path)
        {
            bool executed = false;
            try
            {
                if (File.Exists(path))
                {
                    FileInfo file = new FileInfo(path);
                    string script = file.OpenText().ReadToEnd();
                    script = script.Replace("\n", " ");
                    script = script.Replace("\r", " ");
                    script = script.Replace("\t", " ");

                    string[] commandArray = script.Split(new string[] { "GO" }, StringSplitOptions.RemoveEmptyEntries);
                    for (int i = 0; i < commandArray.Length; i++)
                    {
                        Methods.SQLExecuteNonQuery(commandArray[i], null);
                    }
                }
                executed = true;
            }
            catch
            {
                executed = false;
            }

            return executed;

        }

        private void CreateDatabase(string databaseName)
        {
            if (File.Exists(@"..\..\..\Database\Stored Procedures\Database.sql"))
            {
                try
                {
                    ExecuteSQLFiles(@"..\..\..\Database\Stored Procedures\Database.sql");
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

        private List<string> GetPathToExecute()
        {
            List<string> pathToExecute = new List<string>();
            string pathBase = @"..\..\..\Database\";

            string pathFolder = @"Initializer\";
            if (File.Exists(pathBase + pathFolder + "CreateTables.sql"))
                pathToExecute.Add(pathBase +pathFolder + "CreateTables.sql");

            pathFolder = @"Stored Procedures\";
            if(File.Exists(pathBase + pathFolder + "Users.sql"))
                pathToExecute.Add(pathBase + pathFolder + "Users.sql");
            if (File.Exists(pathBase + pathFolder + "Types.sql"))
                pathToExecute.Add(pathBase + pathFolder + "Statements.sql");
            if (File.Exists(pathBase + pathFolder + "Statements.sql"))
                pathToExecute.Add(pathBase + pathFolder + "Statements.sql");
            if (File.Exists(pathBase + pathFolder + "Investments.sql"))
                pathToExecute.Add(pathBase + pathFolder + "Investments.sql");
            if (File.Exists(pathBase + pathFolder + "Environments.sql"))
                pathToExecute.Add(pathBase + pathFolder + "Environments.sql");


            pathFolder = @"Triggers\";
            if (File.Exists(pathBase + pathFolder + "DeleteEnvironment.sql"))
                pathToExecute.Add(pathBase + pathFolder + "DeleteEnvironment.sql");
            if (File.Exists(pathBase + pathFolder + "DeleteType.sql"))
                pathToExecute.Add(pathBase + pathFolder + "DeleteType.sql");
            if (File.Exists(pathBase + pathFolder + "DeleteUser.sql"))
                pathToExecute.Add(pathBase + pathFolder + "DeleteUser.sql");

            pathFolder = @"Indexes\";
            if (File.Exists(pathBase + pathFolder + "ActionTypes.sql"))
                pathToExecute.Add(pathBase + pathFolder + "ActionTypes.sql");
            if (File.Exists(pathBase + pathFolder + "UserIdGoals.sql"))
                pathToExecute.Add(pathBase + pathFolder + "UserIdGoals.sql");

            pathFolder = @"Cursors\";
            if (File.Exists(pathBase + pathFolder + "Cursors.sql"))
                pathToExecute.Add(pathBase + pathFolder + "Cursors.sql");

            pathFolder = @"Functions\";
            if (File.Exists(pathBase + pathFolder + "Goals.sql"))
                pathToExecute.Add(pathBase + pathFolder + "Goals.sql");

            return pathToExecute;
        }

        public void BiuldDatabase(string instanceParameter)
        {
            List<string> pathToExecute = new List<string>();
            pathToExecute = GetPathToExecute();

            foreach (string path in pathToExecute)
            {
                ExecuteSQLFiles(path);
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
                using (SqlConnection connection = ConnectionDB.GetConnection())
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
            ConnectionDB.setCatalogDB("master", this.GetType());
            bool biuldDatabase = false;
            try
            {
                using (SqlConnection connection = ConnectionDB.GetConnection())
                {
                    if(MessageBox.Show($"Não foi encontrado nenhum banco de dados com o nome: {lastCatalogValue}" +
                        $"\n Gostaria de criar agora?", "Não encontrado.", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        CreateDatabase(lastCatalogValue);
                        biuldDatabase = true;
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

            Thread.Sleep(5000);
            if(biuldDatabase)
            {
                using (SqlConnection connection = ConnectionDB.GetConnection())
                {
                    BiuldDatabase(lastCatalogValue);
                    MessageBox.Show("Banco de dados criado com sucesso!", "Concluido.",
                         MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }
    }
}
