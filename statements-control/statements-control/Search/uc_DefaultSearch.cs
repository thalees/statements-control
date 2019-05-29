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

        protected virtual void SetupGrid()
        {
            dgv_Listing.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dgv_Listing.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;

            dgv_Listing.AllowUserToAddRows = false;
            dgv_Listing.AllowUserToDeleteRows = false;
            dgv_Listing.AllowUserToResizeRows = false;
            dgv_Listing.MultiSelect = false;
            dgv_Listing.ReadOnly = true;
            dgv_Listing.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }
        protected virtual void gridRefresh()
        {
            return;
        }
        protected virtual MasterVO ObjectFill()
        {
            return null;
        }
        protected void BiuldHTML()
        {
            string html = $@"
                            <BODY> <br>";

            foreach (DataGridViewRow row in dgv_Listing.Rows)
            {
                foreach (DataGridViewColumn column in dgv_Listing.Columns)
                {
                    html += $@"<b> {column.Name} </b> = {row.Cells[$"{column.Name}"].Value.ToString()} //";
                }
                html += "<br><br>";
            }
            html += "</BODY> </ html> ";

            File.WriteAllText("HTMLGrid.html", html);
            MessageBox.Show("HTMLGrid atualizado com sucesso!");
        }
     
        protected void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgv_Listing.CurrentRow != null)
            {
                TypesVO obj = dgv_Listing.CurrentRow.DataBoundItem as TypesVO;
                SelectedId = Convert.ToInt32(dgv_Listing.CurrentRow.Cells[0].Value);
                MessageBox.Show(SelectedId.ToString());
            }
        }

        protected void btn_Back_Click(object sender, EventArgs e)
        {
            this.Visible = false;
        }

        protected void btn_HTML_Click(object sender, EventArgs e)
        {
            BiuldHTML();
        }



        private void uc_DefaultSearch_Load(object sender, EventArgs e)
        {
            SetupGrid();
        }
    }
}
