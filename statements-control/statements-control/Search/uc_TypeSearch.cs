using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Library.VOs;
using Library.DAOs;
using statements_control.Register;

namespace statements_control.Search
{
    public partial class uc_TypeSearch : uc_DefaultSearch
    {
        private static uc_TypeSearch _instance;

        public static uc_TypeSearch Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new uc_TypeSearch();
                return _instance;
            }
        }
        public uc_TypeSearch()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //List<TypesVO> list = (new TypesDAO()).List(txt_Id.Text.Trim());
            //dgv_Listing.DataSource = list;
            //dgv_Listing.ReadOnly = true;
        }

        private void btn_Pesquisar_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrEmpty(txt_Name.Text))
            {
                MessageBox.Show("Digite um valor válido para o nome.");
            }
            else
            {
                TypesDAO dao = new TypesDAO();

                TypesVO type = new TypesVO();
                type.Name = txt_Name.Text;

                DataTable table = dao.SQLSearch(type);
                dgv_Listing.DataSource = table;
            }
        }

        private void uc_TypeSearch_Load(object sender, EventArgs e)
        {
            base.SetupGrid();
        }

        private void btn_Back_Click_1(object sender, EventArgs e)
        {
            this.Visible = false;

        }

        private void btn_Confirm_Click(object sender, EventArgs e)
        {
            if (dgv_Listing.CurrentRow != null)
            {
                TypesVO type = new TypesVO();
                type.Id = Convert.ToInt32(dgv_Listing.CurrentRow.Cells[0].Value);
                type.Name = dgv_Listing.CurrentRow.Cells[1].Value.ToString();
                type.Description = dgv_Listing.CurrentRow.Cells[2].Value.ToString();
                type.Action = dgv_Listing.CurrentRow.Cells[3].Value.ToString();

                uc_TypeRegister.Instance.FillScreen(type);
                this.Visible = false;
            }
            else
                MessageBox.Show("Selecione uma linha válida");
        }
    }
}
