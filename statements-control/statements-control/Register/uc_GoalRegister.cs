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
using Library.ENUMs;
using Library.DAOs;

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
            registerDAO = new GoalsDAO();
            SugereProximoId = true;
            base.Inicializa();
        }

        protected override void FillScreen(MasterVO objVO)
        {
            try
            {
                if (objVO != null)
                {
                    txt_Id.Text = (objVO as GoalsVO).Id.ToString();
                    txt_Name.Text = (objVO as GoalsVO).Name;
                    dt_EndDate.Value = (objVO as GoalsVO).EndDate;
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
            GoalsVO goalVO = new GoalsVO();
            goalVO.Id = Convert.ToInt32(txt_Id.Text);
            goalVO.Name = txt_Name.Text;
            goalVO.EndDate = dt_EndDate.Value;
            //goalVO.UserId = null;
            return goalVO;
        }
    }
}
