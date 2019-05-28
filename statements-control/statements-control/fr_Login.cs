using Library.DAOs;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Security.Cryptography;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using Library.Security;
using System.IO;
using System.Data.SqlClient;
using Library;
using Library.VOs;

namespace statements_control
{
    public partial class fr_Login : Form
    {
        byte[] pictureArray;
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
            dataBaseParameters.StartPosition = FormStartPosition.CenterParent;
            dataBaseParameters.ShowDialog();
        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            try
            {
                UsersVO currentUser = new UsersVO();
                using (SqlConnection connection = ConnectionDB.GetConnection())
                {
                    SqlParameter[] parameters = {
                        new SqlParameter("@name", txt_LoginUsername.Text),
                        new SqlParameter("@password", txt_LoginPassword.Text)
                    };
                    DataTable table = Methods.SQLSelectProcedure("usp_ValidadeUser", parameters);

                    if(table.Rows.Count == 0)
                    {
                        MessageBox.Show("Nenhum usuário encontrado com esse nome e senha.", "Erro.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    foreach(DataRow row in table.Rows)
                    {
                        currentUser.Id = Convert.ToInt32(row["id"].ToString());
                        currentUser.Name = row["name"].ToString();
                        currentUser.DateBirth = Convert.ToDateTime(row["dateBirth"]);
                        currentUser.Picture = (row["picture"] as byte[]);
                    }
                }

                fr_Default _Default = new fr_Default(currentUser);
                _Default.StartPosition = FormStartPosition.CenterParent;
                _Default.Show();
                Hide();
            }
            catch
            {
                MessageBox.Show("Erro ao conectar no Banco de Dados.", "Erro!",
                     MessageBoxButtons.OK, MessageBoxIcon.Error);
                ChangeButtonColor(btn_Database, Color.Red);
            }
        }

        private void fr_Login_Load(object sender, EventArgs e)
        {
            if (File.Exists("DataBaseParameters.txt"))
            {
                string[] dataBaseParameters = Encryption.DecryptString(File.ReadAllText("DataBaseParameters.txt")).Split('|');
                ConnectionDB.setCatalogDB(dataBaseParameters[0], this.GetType());
                ConnectionDB.setUsernameDB(dataBaseParameters[1], this.GetType());
                ConnectionDB.setPasswordDB(dataBaseParameters[2], this.GetType());
            } 

        }

        private void btn_RegisterUser_Click(object sender, EventArgs e)
        {
            Point point = new Point();
            point.X = 350;
            point.Y = 0;
            coverPanel.Location = point;
        }

        private void btn_Save_Click(object sender, EventArgs e)
        {
            errorProvider.Clear();
            bool foundError = false;

            if(String.IsNullOrEmpty(txt_RegisterUsername.Text))
            {
                foundError = true;
                errorProvider.SetError(txt_RegisterUsername, "Digite um nome válido.");
            }
            if(String.IsNullOrEmpty(txt_RegisterPassword.Text))
            {
                foundError = true;
                errorProvider.SetError(txt_RegisterPassword, "Digite ema senha válida.");
            }

            if (!foundError)
            {
                try
                {
                    //ImageConverter converter = new ImageConverter();
                    //byte[] imageArray = (byte[])converter.ConvertTo(pic_userPicture.Image, typeof(byte[]));

                    UsersDAO userDAO = new UsersDAO();
                    UsersVO user = new UsersVO();
                    user.Name = txt_RegisterUsername.Text;
                    user.Password = txt_RegisterPassword.Text;
                    user.DateBirth = Convert.ToDateTime(dtp_DateBirth.Value.ToShortDateString());

                    user.Picture = pictureArray;

                    userDAO.SQLInsert(user);

                    MessageBox.Show("Usuário cadastrado com sucesso.", "Cadastrado.", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch
                {
                    MessageBox.Show("Problemas para cadastrar usuário.", "Erro.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btn_Back_Click(object sender, EventArgs e)
        {
            Point point = new Point();
            point.X = point.Y = 0;
            coverPanel.Location = point;
        }

        private void pic_userPicture_Click(object sender, EventArgs e)
        {
            if (imageSearch.ShowDialog() == DialogResult.OK)
            {
                pic_userPicture.ImageLocation = imageSearch.FileName;
                pictureArray = File.ReadAllBytes(imageSearch.FileName);
            }
        }
    }
}
