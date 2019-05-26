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
    }
}
