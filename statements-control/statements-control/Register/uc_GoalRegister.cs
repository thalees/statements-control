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
    public partial class uc_GoalRegister : uc_DefaultRegister
    {
        protected static uc_GoalRegister _instance;
        public static uc_GoalRegister Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new uc_GoalRegister();
                return _instance;
            }
        }
        public uc_GoalRegister()
        {
            InitializeComponent();
        }
    }
}
