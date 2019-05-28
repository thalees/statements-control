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
            registerDAO = new EnvironmentsDAO();
            SugereProximoId = true;
            base.Inicializa();
        }

        protected override void FillScreen(MasterVO objVO)
        {
            try
            {
                if (objVO != null)
                {
                    txt_Id.Text = (objVO as EnvironmentsVO).Id.ToString();
                    txt_Name.Text = (objVO as EnvironmentsVO).Name;
                    txt_Description.Text = (objVO as EnvironmentsVO).Description;
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
            txt_Name.Enabled = modo != NavigationTypeENUM.Navigation;
        }

        protected override MasterVO FillObject()
        {
            EnvironmentsVO environmentVO = new EnvironmentsVO();
            environmentVO.Id = Convert.ToInt32(txt_Id.Text);
            environmentVO.Name = txt_Name.Text;
            environmentVO.Description = txt_Description.Text;
            return environmentVO;
        }
    }
}
