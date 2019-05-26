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
    public partial class uc_EnvironmentRegister : uc_DefaultRegister
    {
        protected static uc_EnvironmentRegister _instance;
        public static uc_EnvironmentRegister Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new uc_EnvironmentRegister();
                return _instance;
            }
        }
        public uc_EnvironmentRegister()
        {
            InitializeComponent();
        }
    }
}
