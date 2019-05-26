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

namespace statements_control
{
    public partial class uc_DefaultSearch : UserControl
    {
        protected MasterDAO searchDAO;
        public uc_DefaultSearch()
        {
            InitializeComponent();
        }

        protected virtual void PreencheTela(MasterVO vo)
        {
            //preencher nos filhos
        }
    }
}
