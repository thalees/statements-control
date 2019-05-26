using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using statements_control.Search;

namespace statements_control.Register
{
    public partial class uc_StatementRegister : uc_DefaultRegister
    {
        protected static uc_StatementRegister _instance;
        public static uc_StatementRegister Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new uc_StatementRegister();
                return _instance;
            }
        }
        public uc_StatementRegister()
        {
            InitializeComponent();
        }

        private void btn_Search_Click(object sender, EventArgs e)
        {
            if(!uc_panel.Controls.Contains(uc_TypeSearch.Instance))
            {
                uc_panel.Controls.Add(uc_TypeSearch.Instance);
                uc_TypeSearch.Instance.Dock = DockStyle.Fill;
                uc_TypeSearch.Instance.BringToFront();
            }
            else
                uc_TypeSearch.Instance.BringToFront();
        }
    }
}
