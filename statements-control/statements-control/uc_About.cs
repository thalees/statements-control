﻿using System;
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
    public partial class uc_About : UserControl
    {
        protected static uc_About _instance;

        public static uc_About Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new uc_About();
                return _instance;
            }
        }
        public uc_About()
        {
            InitializeComponent();
        }
    }
}
