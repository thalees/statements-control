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
    public partial class uc_GoalSearch : uc_DefaultSearch
    {
        private static uc_GoalSearch _instance;

        public static uc_GoalSearch Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new uc_GoalSearch();
                return _instance;
            }
        }

        public uc_GoalSearch()
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
                GoalsDAO dao = new GoalsDAO();

                GoalsVO goal = new GoalsVO();
                goal.Name = txt_Name.Text;

                DataTable table = dao.SQLSearch(goal);
                dgv_Listing.DataSource = table;
            }
        }

        private void btn_Confirm_Click(object sender, EventArgs e)
        {
            if (dgv_Listing.CurrentRow != null)
            {
                GoalsVO goal = new GoalsVO();
                goal.Id = Convert.ToInt32(dgv_Listing.CurrentRow.Cells[0].Value);
                goal.Name = dgv_Listing.CurrentRow.Cells[1].Value.ToString();
                goal.UserId = Convert.ToInt32(dgv_Listing.CurrentRow.Cells[2].Value);

                uc_GoalRegister.Instance.FillScreen(goal);
                this.Visible = false;
            }
            else
                MessageBox.Show("Selecione uma linha válida");
        }
    }
}
