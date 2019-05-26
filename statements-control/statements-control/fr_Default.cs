using statements_control.Register;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace statements_control
{
    public partial class fr_Default : Form
    {
        public fr_Default()
        {
            InitializeComponent();
        }

        private void btn_Dashboard_Click(object sender, EventArgs e)
        {
            if(!uc_panel.Controls.Contains(uc_Dashboard.Instance))
            {
                uc_panel.Controls.Add(uc_Dashboard.Instance);
                uc_Dashboard.Instance.Dock = DockStyle.Fill;
                uc_Dashboard.Instance.BringToFront();
            }
            else
                uc_Dashboard.Instance.BringToFront();
        }

        private void btn_Investments_Click(object sender, EventArgs e)
        {
            if (!uc_panel.Controls.Contains(uc_InvestimentRegister.Instance))
            {
                uc_panel.Controls.Add(uc_InvestimentRegister.Instance);
                uc_InvestimentRegister.Instance.Dock = DockStyle.Fill;
                uc_InvestimentRegister.Instance.BringToFront();
            }
            else
                uc_InvestimentRegister.Instance.BringToFront();
        }

        private void btn_Goals_Click(object sender, EventArgs e)
        {
            if (!uc_panel.Controls.Contains(uc_GoalRegister.Instance))
            {
                uc_panel.Controls.Add(uc_GoalRegister.Instance);
                uc_GoalRegister.Instance.Dock = DockStyle.Fill;
                uc_GoalRegister.Instance.BringToFront();
            }
            else
                uc_GoalRegister.Instance.BringToFront();
        }

        private void btn_Statements_Click(object sender, EventArgs e)
        {
            if (!uc_panel.Controls.Contains(uc_StatementRegister.Instance))
            {
                uc_panel.Controls.Add(uc_StatementRegister.Instance);
                uc_StatementRegister.Instance.Dock = DockStyle.Fill;
                uc_StatementRegister.Instance.BringToFront();
            }
            else
                uc_StatementRegister.Instance.BringToFront();
        }

        private void btn_About_Click(object sender, EventArgs e)
        {
            if (!uc_panel.Controls.Contains(uc_About.Instance))
            {
                uc_panel.Controls.Add(uc_About.Instance);
                uc_About.Instance.Dock = DockStyle.Fill;
                uc_About.Instance.BringToFront();
            }
            else
                uc_About.Instance.BringToFront();
        }

        private void btn_Types_Click(object sender, EventArgs e)
        {
            if (!uc_panel.Controls.Contains(uc_TypeRegister.Instance))
            {
                uc_panel.Controls.Add(uc_TypeRegister.Instance);
                uc_TypeRegister.Instance.Dock = DockStyle.Fill;
                uc_TypeRegister.Instance.BringToFront();
            }
            else
                uc_TypeRegister.Instance.BringToFront();
        }

        private void btn_Environments_Click(object sender, EventArgs e)
        {
            if (!uc_panel.Controls.Contains(uc_EnvironmentRegister.Instance))
            {
                uc_panel.Controls.Add(uc_EnvironmentRegister.Instance);
                uc_EnvironmentRegister.Instance.Dock = DockStyle.Fill;
                uc_EnvironmentRegister.Instance.BringToFront();
            }
            else
                uc_EnvironmentRegister.Instance.BringToFront();
        }
    }
}
