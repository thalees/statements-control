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
    public partial class uc_InvestmentSearch : uc_DefaultSearch
    {
        private static uc_InvestmentSearch _instance;

        public static uc_InvestmentSearch Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new uc_InvestmentSearch();
                return _instance;
            }
        }

        public uc_InvestmentSearch()
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
                InvestmentsDAO dao = new InvestmentsDAO();

                InvestmentsVO statement = new InvestmentsVO();
                statement.Name = txt_Name.Text;

                DataTable table = dao.SQLSearch(statement);
                dgv_Listing.DataSource = table;
            }
        }

        private void uc_InvestmentSearch_Load(object sender, EventArgs e)
        {
            base.SetupGrid();
        }

        private void btn_Confirm_Click(object sender, EventArgs e)
        {
            if (dgv_Listing.CurrentRow != null)
            {
                InvestmentsVO investment = new InvestmentsVO();
                investment.Id = Convert.ToInt32(dgv_Listing.CurrentRow.Cells[0].Value);
                investment.Name = dgv_Listing.CurrentRow.Cells[1].Value.ToString();
                investment.StartDate = Convert.ToDateTime(dgv_Listing.CurrentRow.Cells[2].Value.ToString());
                investment.Value = Convert.ToDouble(dgv_Listing.CurrentRow.Cells[3].Value);

                //uc_InvestimentRegister.FillScreen(investment);
                this.Visible = false;
            }
            else
                MessageBox.Show("Selecione uma linha válida");
        }
    }
}
