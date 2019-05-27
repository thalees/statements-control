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
using Library;
using Library.ENUMs;
using System.Data.SqlClient;

namespace statements_control
{
    public partial class uc_DefaultRegister : UserControl
    {
        public bool SugereProximoId { get; set; } = false;
        protected MasterDAO registerDAO;
        public uc_DefaultRegister()
        {
            InitializeComponent();
        }

        protected virtual void FillScreen(MasterVO obj)
        {
            //preencher nos filhos
        }


        protected void TrataErro(Exception erro)
        {
            if (erro is FormatException)
            {
                Methods.Message("Campo numérico inválido!", MessageTypeENUM.error);
            }
            else if (erro is SqlException)
            {
                Methods.Message("Ocorreu um erro no banco de dados.", MessageTypeENUM.error);
            }
            else if (erro is Exception)
            {
                Methods.Message(erro.Message, MessageTypeENUM.error);
            }
        }

        protected bool DevMode()
        {
            return (LicenseManager.UsageMode == LicenseUsageMode.Designtime);
        }

        private void ChangeMode(NavigationTypeENUM modo)
        {
            btn_Insert.Enabled = (modo == NavigationTypeENUM.Navigation);
            btn_Update.Enabled = (modo == NavigationTypeENUM.Navigation);
            btn_Delete.Enabled = (modo == NavigationTypeENUM.Navigation) &&
                                 txt_Id.Text.Length > 0;

            btn_First.Enabled = (modo == NavigationTypeENUM.Navigation);
            btn_Previous.Enabled = (modo == NavigationTypeENUM.Navigation) && txt_Id.Value > 0;
            btn_Next.Enabled = (modo == NavigationTypeENUM.Navigation) && txt_Id.Value > 0;
            btn_Last.Enabled = (modo == NavigationTypeENUM.Navigation);

            btn_Save.Enabled = (modo != NavigationTypeENUM.Navigation);
            btn_Cancel.Enabled = (modo != NavigationTypeENUM.Navigation);
            btn_Search.Enabled = (modo == NavigationTypeENUM.Navigation);

            if (modo == NavigationTypeENUM.Insert)
            {
                txt_Id.Enabled = true;
                LimpaCampos(this);
                txt_Id.Focus();
            }
            else
                txt_Id.Enabled = false;


            ControlaCamposTela(modo); // propositalmene no final para que se possa alterar alguns dos comportamentos acima nos descendentes
        }


        protected virtual void ControlaCamposTela(NavigationTypeENUM modo)
        {
            // deve ser sobrescrito
        }

        protected void LimpaCampos(Control objeto)
        {
            if (objeto is TextBox ||
                objeto is MaskedTextBox)
                objeto.Text = "";
            else if (objeto is NumericUpDown)
                (objeto as NumericUpDown).Value = 0;
            else
            {
                foreach (Control o in objeto.Controls)
                    LimpaCampos(o);
            }
        }

        private void btn_Update_Click(object sender, EventArgs e)
        {
            ChangeMode(NavigationTypeENUM.Update);
        }

        private void btn_Insert_Click(object sender, EventArgs e)
        {
            ChangeMode(NavigationTypeENUM.Insert);
        }

        private void btn_Delete_Click(object sender, EventArgs e)
        {
            if (Methods.IntValidation(txt_Id.Text) == false)
            {
                Methods.Message("Digite apenas números no campo ID.",
                    MessageTypeENUM.alert);
                return;
            }

            if (!Methods.Message("Confirma?", MessageTypeENUM.question))
                return;
            try
            {
                registerDAO.SQLDelete(Convert.ToInt32(txt_Id.Text));
                Inicializa();
            }
            catch (Exception erro)
            {
                TrataErro(erro);
            }
        }

        private void btn_Save_Click(object sender, EventArgs e)
        {
            try
            {
                MasterVO obj = FillObject();

                if (txt_Id.Enabled)
                    registerDAO.SQLInsert(obj);
                else
                    registerDAO.SQLUpdate(obj);

                ChangeMode(NavigationTypeENUM.Navigation);
            }
            catch (Exception erro)
            {
                TrataErro(erro);
            }
        }


        protected virtual MasterVO FillObject()
        {
            return null; // é necessário ter algo .. não é void!  Programar nos descendentes
        }

        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            if (txt_Id.Enabled)
                FillScreen(registerDAO.SQLFirst());
            else
                // PreencheTela(registerDAO.SQLSearch(Convert.ToInt32(txt_Id.Text)));

            ChangeMode(NavigationTypeENUM.Navigation);
        }

        private void btn_Previous_Click(object sender, EventArgs e)
        {
            try
            {
                MasterVO objVO = registerDAO.SQLPrevious(Convert.ToInt32(txt_Id.Text));
                if (objVO != null)
                    FillScreen(objVO);
            }
            catch (Exception erro)
            {
                TrataErro(erro);
            }
        }

        private void btn_First_Click(object sender, EventArgs e)
        {
            try
            {
                MasterVO objVO = registerDAO.SQLFirst();
                FillScreen(objVO);
            }
            catch (Exception erro)
            {
                TrataErro(erro);
            }
        }

        private void btn_Next_Click(object sender, EventArgs e)
        {
            try
            {
                MasterVO objVO = registerDAO.SQLNext(Convert.ToInt32(txt_Id.Text));
                if (objVO != null)
                    FillScreen(objVO);
            }
            catch (Exception erro)
            {
                TrataErro(erro);
            }
        }

        private void btn_Last_Click(object sender, EventArgs e)
        {
            try
            {
                MasterVO o = registerDAO.SQLLast();
                FillScreen(o);
            }
            catch (Exception erro)
            {
                TrataErro(erro);
            }
        }

        private void frPadrao_Load(object sender, EventArgs e)
        {
            if (!DevMode())
            {
                Inicializa();
            }
        }

        public void Inicializa() {
            try
            {
                MasterVO objVO = registerDAO.SQLFirst();
                FillScreen(objVO);
            }
            catch (Exception erro)
            {
                TrataErro(erro);
            }
            ChangeMode(NavigationTypeENUM.Navigation);
        }
    }
}
