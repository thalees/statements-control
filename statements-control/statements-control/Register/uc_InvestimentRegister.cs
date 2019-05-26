using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace statements_control.Register
{
    public partial class uc_InvestimentRegister : uc_DefaultRegister
    {
        protected static uc_InvestimentRegister _instance;
        public static uc_InvestimentRegister Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new uc_InvestimentRegister();
                return _instance;
            }
        }

        public uc_InvestimentRegister()
        {
            InitializeComponent();
        }
    }
}
