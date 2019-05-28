using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Library.DAOs;
using Library.VOs;
using Library.ENUMs;

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
            registerDAO = new InvestmentsDAO();
            SugereProximoId = true;
            base.Inicializa();
        }

        protected override void FillScreen(MasterVO objVO)
        {
            try
            {
                if (objVO != null)
                {
                    txt_Id.Text = (objVO as InvestmentsVO).Id.ToString();
                    txt_Name.Text = (objVO as InvestmentsVO).Name;
                    dt_StartDate.Value = (objVO as InvestmentsVO).StartDate;
                    dt_EndDate.Value = (objVO as InvestmentsVO).EndDate;
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
            txt_Name.Enabled = dt_StartDate.Enabled = dt_EndDate.Enabled = modo != NavigationTypeENUM.Navigation;
        }

        protected override MasterVO FillObject()
        {
            InvestmentsVO investmentsVO = new InvestmentsVO();
            investmentsVO.Id = Convert.ToInt32(txt_Id.Text);
            investmentsVO.Name = txt_Name.Text;
            investmentsVO.StartDate = dt_StartDate.Value;
            investmentsVO.EndDate = dt_EndDate.Value;
            // investmentsVO.UserId = null;
            return investmentsVO;
        }
    }
}
