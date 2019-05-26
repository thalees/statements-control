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
    public partial class uc_TypeRegister : uc_DefaultRegister
    {
        protected static uc_TypeRegister _instance;
        public static uc_TypeRegister Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new uc_TypeRegister();
                return _instance;
            }
        }
        public uc_TypeRegister()
        {
            InitializeComponent();
        }
    }
}
