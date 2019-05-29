using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
    }
}
