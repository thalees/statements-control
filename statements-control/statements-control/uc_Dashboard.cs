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
    public partial class uc_Dashboard : UserControl
    {
        private static uc_Dashboard _instance;

        public static uc_Dashboard Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new uc_Dashboard();
                return _instance;
            }
        }
        public uc_Dashboard()
        {
            InitializeComponent();
        }
    }
}
