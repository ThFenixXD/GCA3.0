using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ProjectGCA3._0.Web_Forms
{
    public partial class PagCadastro : System.Web.UI.Page
    {
        /* #MÉTODOS*/

        protected void EscondePaineis()
        {
            PnlCadastroOpcoes.Visible = false;
            PnlCadastroUsuario.Visible = false;
            PnlCadastroMaquina.Visible = false;
            PnlCadastroSetor.Visible = false;
            PnlCadastroChaveAtivacao.Visible = false;
        }


        /* #ONCLICK*/

        protected void lnkUsuario_Click(object sender, EventArgs e)
        {
            EscondePaineis();
            PnlCadastroUsuario.Visible = true;
        }

        protected void lnkMaquina_Click(object sender, EventArgs e)
        {
            EscondePaineis();
            PnlCadastroMaquina.Visible = true;
        }

        protected void lnkSetor_Click(object sender, EventArgs e)
        {
            EscondePaineis();
            PnlCadastroSetor.Visible = true;
        }

        protected void lnkChaves_Click(object sender, EventArgs e)
        {
            EscondePaineis();
            PnlCadastroChaveAtivacao.Visible = true;
        }

        protected void lnkTipoLicenca_Click(object sender, EventArgs e)
        {
            EscondePaineis();
            PnlCadastroTipoLicenca.Visible = true;
        }


        /* #PROGRAMA PRINCIPAL*/

        protected void Page_Load(object sender, EventArgs e)
        {

        }
    }
}