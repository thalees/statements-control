using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace statements_control
{
    public partial class uc_DefaultSearch : UserControl
    {
        private static uc_DefaultSearch _instance;

        public static uc_DefaultSearch Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new uc_DefaultSearch();
                return _instance;
            }
        }
        public uc_DefaultSearch()
        {
            InitializeComponent();
        }
    }
}
