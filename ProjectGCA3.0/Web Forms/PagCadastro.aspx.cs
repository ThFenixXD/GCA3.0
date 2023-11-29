using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ProjectGCA3._0.Útil;

namespace ProjectGCA3._0.Web_Forms
{
    public partial class PagCadastro : System.Web.UI.Page
    {
        #region Métodos

        protected void EscondePaineis()
        {
            PnlCadastroOpcoes.Visible = false;
            PnlCadastroUsuario.Visible = false;
            PnlCadastroMaquina.Visible = false;
            PnlCadastroSetor.Visible = false;
            PnlCadastroChaveAtivacao.Visible = false;
        }

        protected void LimpaCampos()
        {
            txtNomeUsuario.Text =
            txtFuncaoUsuario.Text =
            txtNomeMaquina.Text =
            txtNomeSetor.Text =
            txtTipoLicenca.Text =
            txtPrazoLicenca.Text =
            txtChaveAtivacao.Text =
            HdfID.Value =
            string.Empty;
        }

        protected void PopulaDdlSetorUsuario()
        {
            ddlSetorUsuario.DataSource = Framework.GetDataTable("SELECT ID_Setor, NomeSetor FROM tb_Setores");
            ddlSetorUsuario.DataBind();
            ddlSetorUsuario.Items.Insert(0, new ListItem("Selecionar"));
        }

        protected void PopulaDdlSetorMaquina()
        {
            DdlSetorMaquina.DataSource = Framework.GetDataTable("SELECT ID_Setor, NomeSetor FROM tb_Setores");
            DdlSetorMaquina.DataBind();
            DdlSetorMaquina.Items.Insert(0, new ListItem("Selecionar"));
        }

        protected void PopulaDdlTipoLicenca()
        {
            ddlTipolicenca.DataSource = Framework.GetDataTable("SELECT ID_TipoLicenca, TipoLicenca FROM tb_TipoLicenca");
            ddlTipolicenca.DataBind();
            ddlTipolicenca.Items.Insert(0, new ListItem("Selecionar"));
        }
        #endregion

        #region OnClick

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

        protected void BtSalvarUsuario_Click(object sender, EventArgs e)
        {
            using (GCAEntities ctx = new GCAEntities())
            {
                tb_Usuarios Usuario = new tb_Usuarios();
                try
                {
                    if (!string.IsNullOrEmpty(HdfID.Value))
                    {
                        int _id = Convert.ToInt32(HdfID.Value);

                        var Query = (from objUsuario in ctx.tb_Usuarios select objUsuario);

                        Usuario = Query.FirstOrDefault();
                    }
                    else
                    {
                        Usuario.NomeUsuario = txtNomeUsuario.Text;
                        Usuario.FuncaoUsuario = txtFuncaoUsuario.Text;
                        Usuario.SetorUsuario = ddlSetorUsuario.SelectedItem.ToString();
                        Usuario.ID_Setor = Convert.ToInt32(ddlSetorUsuario.SelectedValue);
                        Usuario.Status = 1;
                        Usuario.Deleted = 0;

                        if (string.IsNullOrEmpty(HdfID.Value))
                        {
                            ctx.tb_Usuarios.Add(Usuario);
                        }
                        ctx.SaveChanges();
                        EscondePaineis();
                        LimpaCampos();
                        PnlCadastroOpcoes.Visible = true;
                    }
                }
                catch (Exception ex)
                {
                    Response.Write("Erro, " + ex.Message);
                }
            }
        }

        protected void BtCancelarUsuario_Click(object sender, EventArgs e)
        {
            EscondePaineis();
            PnlCadastroOpcoes.Visible = true;
        }

        protected void BtSalvarMaquina_Click(object sender, EventArgs e)
        {
            using (GCAEntities ctx = new GCAEntities())
            {
                tb_Maquinas Maquina = new tb_Maquinas();
                try
                {
                    if (!string.IsNullOrEmpty(HdfID.Value))
                    {
                        int _id = Convert.ToInt32(HdfID.Value);

                        var Query = (from objMaquina in ctx.tb_Maquinas select objMaquina);

                        Maquina = Query.FirstOrDefault();
                    }
                    else
                    {
                        Maquina.NomeMaquina = txtNomeMaquina.Text;
                        Maquina.ID_Setor = Convert.ToInt32(DdlSetorMaquina.SelectedValue);
                        Maquina.SetorMaquina = DdlSetorMaquina.SelectedItem.ToString();
                        Maquina.Status = 0;
                        Maquina.Deleted = 0;

                        if (string.IsNullOrEmpty(HdfID.Value))
                        {
                            ctx.tb_Maquinas.Add(Maquina);
                        }
                        ctx.SaveChanges();
                        EscondePaineis();
                        LimpaCampos();
                        PnlCadastroOpcoes.Visible = true;
                    }
                }
                catch (Exception ex)
                {
                    Response.Write("Erro, " + ex.Message);
                }
            }
        }

        protected void BtCancelarMaquina_Click(object sender, EventArgs e)
        {
            EscondePaineis();
            PnlCadastroOpcoes.Visible = true;
        }

        protected void BtSalvarSetor_Click(object sender, EventArgs e)
        {
            using (GCAEntities ctx = new GCAEntities())
            {
                tb_Setores Setor = new tb_Setores();
                try
                {
                    if (!string.IsNullOrEmpty(HdfID.Value))
                    {
                        int _id = Convert.ToInt32(HdfID.Value);

                        var Query = (from objSetor in ctx.tb_Setores select objSetor);

                        Setor = Query.FirstOrDefault();
                    }
                    else
                    {
                        Setor.NomeSetor = txtNomeSetor.Text;
                        Setor.Deleted = 0;

                        if (string.IsNullOrEmpty(HdfID.Value))
                        {
                            ctx.tb_Setores.Add(Setor);
                        }
                        ctx.SaveChanges();
                        EscondePaineis();
                        LimpaCampos();
                        PnlCadastroOpcoes.Visible = true;
                    }
                }
                catch (Exception ex)
                {
                    Response.Write("Erro, " + ex.Message);
                }
            }
        }

        protected void BtCancelarSetor_Click(object sender, EventArgs e)
        {
            EscondePaineis();
            PnlCadastroOpcoes.Visible = true;
        }

        protected void BtSalvarChaveAtivacao_Click(object sender, EventArgs e)
        {
            using (GCAEntities ctx = new GCAEntities())
            {
                tb_Chaves Chave = new tb_Chaves();
                try
                {
                    if (!string.IsNullOrEmpty(HdfID.Value))
                    {
                        int _id = Convert.ToInt32(HdfID.Value);

                        var Query = (from objChave in ctx.tb_Chaves select objChave);

                        Chave = Query.FirstOrDefault();
                    }
                    else
                    {
                        Chave.NomeSoftware = txtNomeSoftware.Text;
                        Chave.Fabricante = txtFabricante.Text;
                        Chave.TipoLicenca = ddlTipolicenca.SelectedItem.ToString();
                        Chave.ID_TipoLicenca = Convert.ToInt32(ddlTipolicenca.SelectedValue);
                        Chave.PrazoLicenca = txtPrazoLicenca.Text;
                        Chave.ChaveAtivacao = txtChaveAtivacao.Text;
                        Chave.Status = 0;
                        Chave.Deleted = 0;

                        if (string.IsNullOrEmpty(HdfID.Value))
                        {
                            ctx.tb_Chaves.Add(Chave);
                        }
                        ctx.SaveChanges();
                        EscondePaineis();
                        LimpaCampos();
                        PnlCadastroOpcoes.Visible = true;
                    }
                }
                catch (Exception ex)
                {
                    Response.Write("Erro, " + ex.Message);
                }
            }
        }

        protected void BtCancelarChaveAtivacao_Click(object sender, EventArgs e)
        {
            EscondePaineis();
            PnlCadastroOpcoes.Visible = true;
        }

        protected void BtSalvarTipoLicenca_Click(object sender, EventArgs e)
        {
            using (GCAEntities ctx = new GCAEntities())
            {
                tb_TipoLicenca TipoLicenca = new tb_TipoLicenca();
                try
                {
                    if (!string.IsNullOrEmpty(HdfID.Value))
                    {
                        int _id = Convert.ToInt32(HdfID.Value);

                        var Query = (from objTipoLicenca in ctx.tb_TipoLicenca select objTipoLicenca);

                        TipoLicenca = Query.FirstOrDefault();
                    }
                    else
                    {
                        TipoLicenca.TipoLicenca = txtTipoLicenca.Text;
                        TipoLicenca.Deleted = 0;

                        if (string.IsNullOrEmpty(HdfID.Value))
                        {
                            ctx.tb_TipoLicenca.Add(TipoLicenca);
                        }
                        ctx.SaveChanges();
                        EscondePaineis();
                        LimpaCampos();
                        PnlCadastroOpcoes.Visible = true;
                    }
                }
                catch (Exception ex)
                {
                    Response.Write("Erro, " + ex.Message);
                }
            }
        }

        protected void BtCancelarTipoLicenca_Click(object sender, EventArgs e)
        {
            EscondePaineis();
            PnlCadastroOpcoes.Visible = true;
        }

        #endregion

        #region Programa Principal

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                PopulaDdlSetorUsuario();
                PopulaDdlSetorMaquina();
                PopulaDdlTipoLicenca();
            }
        }

        #endregion


    }
}