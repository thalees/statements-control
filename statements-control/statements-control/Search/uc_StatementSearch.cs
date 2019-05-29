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
    public partial class uc_StatementSearch : uc_DefaultSearch
    {
        private static uc_StatementSearch _instance;

        public static uc_StatementSearch Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new uc_StatementSearch();
                return _instance;
            }
        }

        public uc_StatementSearch()
        {
            InitializeComponent();
        }

        private void btn_Pesquisar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txt_Name.Text))
            {
                MessageBox.Show("Digite um valor válido para o nome.");
            }
            else
            {
                StatementsDAO dao = new StatementsDAO();

                StatementsVO statement = new StatementsVO();
                statement.Name = txt_Name.Text;

                DataTable table = dao.SQLSearch(statement);
                dgv_Listing.DataSource = table;
            }
        }

        private void uc_StatementSearch_Load(object sender, EventArgs e)
        {
            base.SetupGrid();
        }

        private void btn_Confirm_Click(object sender, EventArgs e)
        {
            if (dgv_Listing.CurrentRow != null)
            {
                StatementsVO statement = new StatementsVO();
                statement.Id = Convert.ToInt32(dgv_Listing.CurrentRow.Cells[0].Value);
                statement.UserId = Convert.ToInt32(dgv_Listing.CurrentRow.Cells[1].Value);
                statement.TypeId = Convert.ToInt32(dgv_Listing.CurrentRow.Cells[2].Value);
                statement.EnvironmentId = Convert.ToInt32(dgv_Listing.CurrentRow.Cells[3].Value);
                statement.Name = dgv_Listing.CurrentRow.Cells[4].Value.ToString();
                statement.Value = Convert.ToDouble(dgv_Listing.CurrentRow.Cells[5].Value);
                statement.Date = Convert.ToDateTime(dgv_Listing.CurrentRow.Cells[6].Value);


                uc_StatementRegister.Instance.FillScreen(statement);
                this.Visible = false;
            }
            else
                MessageBox.Show("Selecione uma linha válida");
        }
    }
}
