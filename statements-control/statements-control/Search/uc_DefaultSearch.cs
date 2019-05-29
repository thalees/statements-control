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
using System.IO;

namespace statements_control
{
    public partial class uc_DefaultSearch : UserControl
    {
        public int SelectedId { get; private set; }
        protected MasterDAO searchDAO;
        public uc_DefaultSearch()
        {
            InitializeComponent();
        }

        protected virtual MasterVO ObjectFill()
        {
            return null;
        }
        protected void BiuldHTML()
        {
            string html = "<html> <head> <TITLE> Pesquisa HTML </ title> </ head> <BODY> <br>";
            foreach(DataGridViewRow row in dgv_Listing.Rows)
            {
                for(int i = 0; i < dgv_Listing.Columns.Count; i++)
                {
                    html += $@"<b> {dgv_Listing.Columns[i].Name} </b>" + 
                        $@"{row.Cells[dgv_Listing.Columns[i].Name].Value.ToString()} < br>";
                }
            }
            html += "</BODY> </ html>";

            File.WriteAllText("HTMLGrid.html", html);
            web_GridHTML.Navigate("HTMLGrid.html");
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgv_Listing.CurrentRow != null)
            {
                TypesVO obj = dgv_Listing.CurrentRow.DataBoundItem as TypesVO;
                SelectedId = Convert.ToInt32(dgv_Listing.CurrentRow.Cells[0].Value);
                MessageBox.Show(SelectedId.ToString());
            }
        }

        private void btn_Back_Click(object sender, EventArgs e)
        {
            this.Visible = false;
        }

        private void btn_HTML_Click(object sender, EventArgs e)
        {
            dgv_Listing.Visible = false;
        }
    }
}
