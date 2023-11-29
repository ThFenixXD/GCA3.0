﻿using System;
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
            PnlApresentacao.Visible =
            PnlCadastroOpcoes.Visible =
            PnlCadastroUsuario.Visible =
            PnlCadastroMaquina.Visible =
            PnlCadastroSetor.Visible =
            PnlCadastroChaveAtivacao.Visible =
            PnlCadastroTipoLicenca.Visible =
            PnlConsultar.Visible =
            PnlConsultarUsuarios.Visible =
            PnlConsultarMaquinas.Visible =
            PnlConsultarChaves.Visible =
            PnlConsultarRelacionar.Visible
            PnlRelacionar.Visible = false;
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

        protected void PopulaDdlRelacionarUsuario()
        {
            DdlRelacionarUsuario.DataSource = Framework.GetDataTable("SELECT ID_Usuario, NomeUsuario FROM tb_Usuarios");
            DdlRelacionarUsuario.DataBind();
            DdlRelacionarUsuario.Items.Insert(0, new ListItem("Selecionar"));
        }

        protected void PopulaDdlRelacionarMaquina()
        {
            DdlRelacionarMaquina.DataSource = Framework.GetDataTable("SELECT ID_Maquina, NomeMaquina FROM tb_Maquinas");
            DdlRelacionarMaquina.DataBind();
            DdlRelacionarMaquina.Items.Insert(0, new ListItem("Selecionar"));
        }

        protected void PopulaDdlRelacionarSoftware()
        {
            DdlRelacionarSoftware.DataSource = Framework.GetDataTable("SELECT ID_ChaveAtivacao, NomeSoftware FROM tb_Chaves");
            DdlRelacionarSoftware.DataBind();
            DdlRelacionarSoftware.Items.Insert(0, new ListItem("Selecionar"));
        }

        protected void PopulaDdlRelacionarChaveAtivacao()
        {
            DdlRelacionarChaveAtivacao.DataSource = Framework.GetDataTable("SELECT ID_ChaveAtivacao, ChaveAtivacao FROM tb_Chaves");
            DdlRelacionarChaveAtivacao.DataBind();
            DdlRelacionarChaveAtivacao.Items.Insert(0, new ListItem("Selecionar"));
        }

        protected void AtualizaGridUsuarios(string Query)
        {
            GridUsuarios.DataSource = Framework.GetDataTable(Query);
            GridUsuarios.DataBind();
        }

        protected void AtualizaGridMaquinas(string Query)
        {
            GridMaquinas.DataSource = Framework.GetDataTable(Query);
            GridMaquinas.DataBind();
        }

        protected void AtualizaGridChaves(string Query)
        {
            GridChaves.DataSource = Framework.GetDataTable(Query);
            GridChaves.DataBind();
        }

        protected void AtualizaGridRelacionar(String Query)
        {
            GridRelacionar.DataSource = Framework.GetDataTable(Query);
            GridRelacionar.DataBind();
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

        protected void LnkConsultaUsuario_Click(object sender, EventArgs e)
        {
            EscondePaineis();
            PnlConsultarUsuarios.Visible = true;
            AtualizaGridUsuarios("SELECT ID_Usuario, ID_Usuario, NomeUsuario, FuncaoUsuario, SetorUsuario FROM tb_Usuarios WHERE Status = 1 AND Deleted = 0");
        }

        protected void LnkConsultaMaquina_Click(object sender, EventArgs e)
        {
            EscondePaineis();
            PnlConsultarMaquinas.Visible = true;
            AtualizaGridMaquinas("SELECT ID_Maquina, ID_Maquina, NomeMaquina, SetorMaquina FROM tb_Maquinas WHERE Deleted = 0");
        }

        protected void LnkConsultaChaves_Click(object sender, EventArgs e)
        {
            EscondePaineis();
            PnlConsultarChaves.Visible = true;
            AtualizaGridChaves("SELECT ID_ChaveAtivacao, NomeSoftware, Fabricante, TipoLicenca, PrazoLicenca, ChaveAtivacao FROM tb_Chaves WHERE Deleted = 0");
        }

        protected void CancelarRelacionar_Click(object sender, EventArgs e)
        {
            EscondePaineis();
            PnlRelacionar.Visible = true;
        }

        protected void SalvarRelacionar_Click(object sender, EventArgs e)
        {
            using (GCAEntities ctx = new GCAEntities())
            {
                tb_Relacionamento Usuario = new tb_Relacionamento();
                try
                {
                    if (!string.IsNullOrEmpty(HdfID.Value))
                    {
                        int _id = Convert.ToInt32(HdfID.Value);

                        var Query = (from objUsuario in ctx.tb_Relacionamento select objUsuario);

                        Usuario = Query.FirstOrDefault();
                    }
                    else
                    {
                        Usuario.UsuarioRelacionar = DdlRelacionarUsuario.SelectedItem.ToString();
                        Usuario.MaquinaRelacionar = DdlRelacionarMaquina.SelectedItem.ToString();
                        Usuario.SoftwareRelacionar = DdlRelacionarSoftware.SelectedItem.ToString();
                        Usuario.ChaveAtivacaoRelacionar = DdlRelacionarChaveAtivacao.ToString();
                        Usuario.Deleted = 0;

                        if (string.IsNullOrEmpty(HdfID.Value))
                        {
                            ctx.tb_Relacionamento.Add(Usuario);
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

        #endregion

        #region NeedDataSource

        protected void GridUsuarios_NeedDataSource(object sender, Telerik.Web.UI.GridNeedDataSourceEventArgs e)
        {
            GridUsuarios.DataSource = Framework.GetDataTable("SELECT ID_Usuario, ID_Usuario, NomeUsuario, FuncaoUsuario, SetorUsuario FROM tb_Usuarios WHERE Status = 1 AND Deleted = 0");
            GridUsuarios.DataBind();
        }

        protected void GridMaquinas_NeedDataSource(object sender, Telerik.Web.UI.GridNeedDataSourceEventArgs e)
        {
            GridMaquinas.DataSource = Framework.GetDataTable("SELECT ID_Maquina, ID_Maquina, NomeMaquina, SetorMaquina FROM tb_Maquinas WHERE Deleted = 0");
            GridMaquinas.DataBind();
        }

        protected void GridChaves_NeedDataSource(object sender, Telerik.Web.UI.GridNeedDataSourceEventArgs e)
        {
            GridChaves.DataSource = Framework.GetDataTable("SELECT ID_ChaveAtivacao, ID_ChaveAtivacao, NomeSoftware, Fabricante, TipoLicenca, PrazoLicenca, ChaveAtivacao FROM tb_Chaves WHERE Deleted = 0");
            GridChaves.DataBind();
        }

        #endregion

        #region ItemCommand

        protected void GridUsuarios_ItemCommand(object sender, Telerik.Web.UI.GridCommandEventArgs e)
        {
            try
            {
                int _cdID = Convert.ToInt32(e.Item.OwnerTableView.DataKeyValues[e.Item.ItemIndex]["ID_Usuario"]);

                switch (e.CommandName)
                {
                    case "opSelecionar":
                        break;

                    case "opEditar":
                        //EscondePaineis();
                        //LimpaCampos();
                        //PopulaCampos(_cdID);
                        //PnlCadastroCategorias.Visible = true;
                        break;

                    case "opExcluir":
                        //using (EmpresaXEntities ctx = new EmpresaXEntities())
                        //{
                        //    tb_Categorias Categoria = new tb_Categorias();

                        //    int ID = _cdID;
                        //    HdfID.Value = _cdID.ToString();

                        //    var Query = (from objCategoria in ctx.tb_Categorias where objCategoria.ID_Categoria == ID select objCategoria).FirstOrDefault();

                        //    Query.Deleted = 1;
                        //    ctx.SaveChanges();
                        //    AtualizaGrid();
                        //}
                        break;
                }
            }
            catch (Exception ex)
            {
                Response.Write("Erro, " + ex.Message);
            }
        }

        protected void GridMaquinas_ItemCommand(object sender, Telerik.Web.UI.GridCommandEventArgs e)
        {
            try
            {
                int _cdID = Convert.ToInt32(e.Item.OwnerTableView.DataKeyValues[e.Item.ItemIndex]["ID_Maquina"]);

                switch (e.CommandName)
                {
                    case "opSelecionar":
                        break;

                    case "opEditar":
                        //EscondePaineis();
                        //LimpaCampos();
                        //PopulaCampos(_cdID);
                        //PnlCadastroCategorias.Visible = true;
                        break;

                    case "opExcluir":
                        //using (EmpresaXEntities ctx = new EmpresaXEntities())
                        //{
                        //    tb_Categorias Categoria = new tb_Categorias();

                        //    int ID = _cdID;
                        //    HdfID.Value = _cdID.ToString();

                        //    var Query = (from objCategoria in ctx.tb_Categorias where objCategoria.ID_Categoria == ID select objCategoria).FirstOrDefault();

                        //    Query.Deleted = 1;
                        //    ctx.SaveChanges();
                        //    AtualizaGrid();
                        //}
                        break;
                }
            }
            catch (Exception ex)
            {
                Response.Write("Erro, " + ex.Message);
            }
        }

        protected void GridChaves_ItemCommand(object sender, Telerik.Web.UI.GridCommandEventArgs e)
        {

        }

        #endregion

        #region Page_Load

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                PopulaDdlSetorUsuario();
                PopulaDdlSetorMaquina();
                PopulaDdlTipoLicenca();
                PopulaDdlRelacionarUsuario();
                PopulaDdlRelacionarMaquina();
                PopulaDdlRelacionarSoftware();
                PopulaDdlRelacionarChaveAtivacao();
            }
        }
        #endregion

        
    }
}