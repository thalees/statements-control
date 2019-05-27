using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Library.VOs;
using Library.DAOs;
using Library.ENUMs;

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
            registerDAO = new TypesDAO();
            SugereProximoId = true;
            base.Inicializa();
        }

        protected override void FillScreen(MasterVO objVO)
        {
            try
            {
                if (objVO != null)
                {
                    txt_Id.Text = (objVO as TypesVO).Id.ToString();
                    txt_Name.Text = (objVO as TypesVO).Name;
                    txt_Description.Text = (objVO as TypesVO).Description;
                    cb_Action.Text = (objVO as TypesVO).Action;
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
            TypesVO typeVO = new TypesVO();
            typeVO.Id = Convert.ToInt32(txt_Id.Text);
            typeVO.Name = txt_Name.Text;
            typeVO.Description = txt_Description.Text;
            typeVO.Action = cb_Action.Text;
            return typeVO;
        }
    }
}
