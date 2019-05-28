using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using statements_control.Search;
using Library.VOs;
using Library.ENUMs;
using Library.DAOs;

namespace statements_control.Register
{
    public partial class uc_StatementRegister : uc_DefaultRegister
    {
        protected static uc_StatementRegister _instance;
        public static uc_StatementRegister Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new uc_StatementRegister();
                return _instance;
            }
        }
        public uc_StatementRegister()
        {
            InitializeComponent();
            registerDAO = new StatementsDAO();
            SugereProximoId = true;
            base.Inicializa();
        }

        protected override void FillScreen(MasterVO objVO)
        {
            try
            {
                if (objVO != null)
                {
                    txt_Id.Text = (objVO as StatementsVO).Id.ToString();
                    txt_Environment.Text = (objVO as StatementsVO).EnvironmentId.ToString();
                    txt_Type.Text = (objVO as StatementsVO).TypeId.ToString();
                    txt_Name.Text = (objVO as StatementsVO).Name;
                    dt_Date.Value = (objVO as StatementsVO).Date;
                    txt_Value.Text = (objVO as StatementsVO).Value.ToString();
                }
                else
                {
                    LimpaCampos(this);
                }
            }
            catch (Exception erro)
            {
                TrataErro(erro);
            }
        }

        protected override void ControlaCamposTela(NavigationTypeENUM modo)
        {
            txt_Name.Enabled = dt_Date.Enabled = txt_Value.Enabled = txt_Type.Enabled = txt_Environment.Enabled = modo != NavigationTypeENUM.Navigation;
        }

        protected override MasterVO FillObject()
        {
            StatementsVO statementVO = new StatementsVO();
            statementVO.Id = Convert.ToInt32(txt_Id.Text);
            statementVO.TypeId = Convert.ToInt32(txt_Type.Text);
            statementVO.EnvironmentId = Convert.ToInt32(txt_Environment.Text);
            statementVO.Name = txt_Name.Text;
            statementVO.Date = dt_Date.Value;
            statementVO.Value = Convert.ToDouble(txt_Value.Text);
            // investmentsVO.UserId = null;
            return statementVO;
        }

        private void btn_Search_Click(object sender, EventArgs e)
        {
            if (!uc_panel.Controls.Contains(uc_TypeSearch.Instance))
            {
                uc_panel.Controls.Add(uc_TypeSearch.Instance);
                uc_TypeSearch.Instance.Dock = DockStyle.Fill;
                uc_TypeSearch.Instance.BringToFront();
            }
            else
            {
                uc_TypeSearch.Instance.BringToFront();
                uc_TypeSearch.Instance.Visible = true;
            }
        }
    }
}
