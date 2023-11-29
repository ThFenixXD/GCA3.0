using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ProjectGCA3._0.Web_Forms
{
    public partial class MasterPage : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Teste_Click(object sender, EventArgs e)
        {
            // Verifica se a página contém o ContentPlaceHolder desejado
            ContentPlaceHolder contentPlaceHolder = Page.Master.FindControl("ContentPlaceHolder1") as ContentPlaceHolder;

            if (contentPlaceHolder != null)
            {
                // Acesse o Panel dentro do ContentPlaceHolder
                Panel pnlExemplo = contentPlaceHolder.FindControl("PnlApresentacao") as Panel;

                if (pnlExemplo != null)
                {
                    // Faça algo com o Panel, por exemplo, torná-lo visível
                    pnlExemplo.Visible = true;
                }
            }
        }

        protected void PagCadastro_Click(object sender, EventArgs e)
        {
            // Verifica se a página contém o ContentPlaceHolder desejado
            ContentPlaceHolder contentPlaceHolder = Page.Master.FindControl("ContentPlaceHolder1") as ContentPlaceHolder;

            if (contentPlaceHolder != null)
            {
                // Acesse o Panel dentro do ContentPlaceHolder
                Panel pnlExemplo = contentPlaceHolder.FindControl("PnlCadastroOpcoes") as Panel;

                if (pnlExemplo != null)
                {
                    // Faça algo com o Panel, por exemplo, torná-lo visível
                    pnlExemplo.Visible = true;
                }
            }
        }
    }
}