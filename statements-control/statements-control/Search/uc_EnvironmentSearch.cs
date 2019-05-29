using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Library.DAOs;
using Library.VOs;
using statements_control.Register;

namespace statements_control.Search
{
    public partial class uc_EnvironmentSearch : uc_DefaultSearch
    {
        private static uc_EnvironmentSearch _instance;

        public static uc_EnvironmentSearch Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new uc_EnvironmentSearch();
                return _instance;
            }
        }
        public uc_EnvironmentSearch()
        {
            InitializeComponent();
        }

        private void btn_Pesquisar_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrEmpty(txt_Name.Text))
            {
                MessageBox.Show("Digite um valor válido para o nome.");
            }
            else
            {
                EnvironmentsDAO dao = new EnvironmentsDAO();

                EnvironmentsVO type = new EnvironmentsVO();
                type.Name = txt_Name.Text;

                DataTable table = dao.SQLSearch(type);
                dgv_Listing.DataSource = table;
            }
        }

        private void uc_EnvironmentSearch_Load(object sender, EventArgs e)
        {
            base.SetupGrid();
        }

        private void btn_Confirm_Click(object sender, EventArgs e)
        {
            if (dgv_Listing.CurrentRow != null)
            {
                EnvironmentsVO environment = new EnvironmentsVO();
                environment.Id = Convert.ToInt32(dgv_Listing.CurrentRow.Cells[0].Value);
                environment.Name = dgv_Listing.CurrentRow.Cells[1].Value.ToString();
                environment.Description = dgv_Listing.CurrentRow.Cells[2].Value.ToString();

                uc_EnvironmentRegister.Instance.FillScreen(environment);
                this.Visible = false;
            }
            else
                MessageBox.Show("Selecione uma linha válida");
        }
    }
}
