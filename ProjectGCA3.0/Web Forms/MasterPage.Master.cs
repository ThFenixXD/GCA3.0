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
        protected void EscondePaineis()
        {
            // Verifica se a página está sendo carregada pela primeira vez
            //if (!IsPostBack)
            //{
                // Obtém uma referência ao ContentPlaceHolder desejado
                ContentPlaceHolder contentPlaceHolder = Page.Master.FindControl("ContentPlaceHolder1") as ContentPlaceHolder;

                // Verifica se o ContentPlaceHolder foi encontrado
                if (contentPlaceHolder != null)
                {
                    // Itera sobre os controles dentro do ContentPlaceHolder
                    foreach (Control Panel in contentPlaceHolder.Controls)
                    {
                        // Verifica se o controle é um Panel
                        if (Panel is Panel)
                        {
                            // Torna o Panel invisível
                            Panel panel = (Panel)Panel;
                            panel.Visible = false;
                        }
                    }
                }
            //}
        }

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void HomePage_Click(object sender, EventArgs e)
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
                    EscondePaineis();
                    pnlExemplo.Visible = true;
                }
            }
        }

        protected void PagConsultar_Click(object sender, EventArgs e)
        {
            // Verifica se a página contém o ContentPlaceHolder desejado
            ContentPlaceHolder contentPlaceHolder = Page.Master.FindControl("ContentPlaceHolder1") as ContentPlaceHolder;

            if (contentPlaceHolder != null)
            {
                // Acesse o Panel dentro do ContentPlaceHolder
                Panel pnlExemplo = contentPlaceHolder.FindControl("PnlConsultar") as Panel;

                if (pnlExemplo != null)
                {
                    // Faça algo com o Panel, por exemplo, torná-lo visível
                    EscondePaineis();
                    pnlExemplo.Visible = true;
                }
            }
        }

        protected void PagRelacionar_Click(object sender, EventArgs e)
        {
            // Verifica se a página contém o ContentPlaceHolder desejado
            ContentPlaceHolder contentPlaceHolder = Page.Master.FindControl("ContentPlaceHolder1") as ContentPlaceHolder;

            if (contentPlaceHolder != null)
            {
                // Acesse o Panel dentro do ContentPlaceHolder
                Panel pnlExemplo = contentPlaceHolder.FindControl("PnlRelacionar") as Panel;

                if (pnlExemplo != null)
                {
                    // Faça algo com o Panel, por exemplo, torná-lo visível
                    EscondePaineis();
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
                    EscondePaineis();
                    pnlExemplo.Visible = true;
                }
            }
        }
    }
}