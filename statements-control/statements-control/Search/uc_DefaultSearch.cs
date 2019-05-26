﻿using System;
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

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgv_Listing.CurrentRow != null)
            {
                TypesVO obj = dgv_Listing.CurrentRow.DataBoundItem as TypesVO;
                SelectedId = Convert.ToInt32(dgv_Listing.CurrentRow.Cells[0].Value);
                MessageBox.Show(SelectedId.ToString());
            }
        }
    }
}
