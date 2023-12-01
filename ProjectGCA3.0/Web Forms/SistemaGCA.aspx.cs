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
            PnlConsultarRelacionar.Visible =
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

        protected void PopulaCamposCadastroUsuario(int _cdID)
        {
            using (GCAEntities ctx = new GCAEntities())
            {
                int ID = _cdID;
                HdfID.Value = _cdID.ToString();

                tb_Usuarios Usuario = new tb_Usuarios();

                var Query = (from objUsuario in ctx.tb_Usuarios where objUsuario.ID_Usuario == ID select objUsuario).FirstOrDefault();

                if (!string.IsNullOrEmpty(Query.ToString()))
                {
                    txtNomeUsuario.Text = Query.NomeUsuario;
                    txtFuncaoUsuario.Text = Query.FuncaoUsuario;
                    ddlSetorUsuario.SelectedValue = Query.ID_Setor.ToString();
                }
            }
        }

        protected void PopulaCamposCadastroMaquina(int _cdID)
        {
            using (GCAEntities ctx = new GCAEntities())
            {
                int ID = _cdID;
                HdfID.Value = _cdID.ToString();

                tb_Maquinas Maquina = new tb_Maquinas();

                var Query = (from objMaquina in ctx.tb_Maquinas where objMaquina.ID_Maquina == ID select objMaquina).FirstOrDefault();

                if (!string.IsNullOrEmpty(Query.ToString()))
                {
                    txtNomeMaquina.Text = Query.NomeMaquina;
                    DdlSetorMaquina.SelectedValue = Query.ID_Setor.ToString();
                }
            }
        }

        protected void PopulaCamposCadastroChave(int _cdID)
        {
            using (GCAEntities ctx = new GCAEntities())
            {
                int ID = _cdID;
                HdfID.Value = _cdID.ToString();

                tb_Chaves Chave = new tb_Chaves();

                var Query = (from objChave in ctx.tb_Chaves where objChave.ID_ChaveAtivacao == ID select objChave).FirstOrDefault();

                if (!string.IsNullOrEmpty(Query.ToString()))
                {
                    txtNomeSoftware.Text = Query.NomeSoftware;
                    txtFabricante.Text = Query.Fabricante;
                    ddlTipolicenca.SelectedValue = Query.ID_TipoLicenca.ToString();
                    txtPrazoLicenca.Text = Query.PrazoLicenca;
                    txtChaveAtivacao.Text = Query.ChaveAtivacao;
                }
            }
        }

        protected void PopulaCamposRelacionar(int _cdID)
        {
            using (GCAEntities ctx = new GCAEntities())
            {
                int ID = _cdID;
                HdfID.Value = _cdID.ToString();

                tb_Relacionar Chave = new tb_Relacionar();

                var Query = (from objRelacionar in ctx.tb_Relacionar where objRelacionar.ID_Relacionar == ID select objRelacionar).FirstOrDefault();


                if (!string.IsNullOrEmpty(Query.ToString()))
                {
                    DdlRelacionarUsuario.SelectedValue = Query.ID_Usuario.ToString();
                    DdlRelacionarMaquina.SelectedValue = Query.ID_Maquina.ToString();
                    DdlRelacionarSoftware.SelectedValue = Query.ID_ChaveAtivacao.ToString();
                    DdlRelacionarChaveAtivacao.SelectedValue = Query.ID_ChaveAtivacao.ToString();
                }
            }
        }

        protected void PopulaDdlSetorUsuario()
        {
            ddlSetorUsuario.DataSource = Framework.GetDataTable("SELECT ID_Setor, NomeSetor FROM tb_Setores WHERE Deleted = 0");
            ddlSetorUsuario.DataBind();
            ddlSetorUsuario.Items.Insert(0, new ListItem("Selecionar"));
        }

        protected void PopulaDdlSetorMaquina()
        {
            DdlSetorMaquina.DataSource = Framework.GetDataTable("SELECT ID_Setor, NomeSetor FROM tb_Setores WHERE Deleted = 0");
            DdlSetorMaquina.DataBind();
            DdlSetorMaquina.Items.Insert(0, new ListItem("Selecionar"));
        }

        protected void PopulaDdlTipoLicenca()
        {
            ddlTipolicenca.DataSource = Framework.GetDataTable("SELECT ID_TipoLicenca, TipoLicenca FROM tb_TipoLicenca WHERE Deleted = 0");
            ddlTipolicenca.DataBind();
            ddlTipolicenca.Items.Insert(0, new ListItem("Selecionar"));
        }

        protected void PopulaDdlRelacionarUsuario()
        {
            DdlRelacionarUsuario.DataSource = Framework.GetDataTable("SELECT ID_Usuario, NomeUsuario FROM tb_Usuarios  WHERE Deleted = 0");
            DdlRelacionarUsuario.DataBind();
            DdlRelacionarUsuario.Items.Insert(0, new ListItem("Selecionar"));
        }

        protected void PopulaDdlRelacionarMaquina()
        {
            DdlRelacionarMaquina.DataSource = Framework.GetDataTable("SELECT ID_Maquina, NomeMaquina FROM tb_Maquinas WHERE Deleted = 0");
            DdlRelacionarMaquina.DataBind();
            DdlRelacionarMaquina.Items.Insert(0, new ListItem("Selecionar"));
        }

        protected void PopulaDdlRelacionarSoftware()
        {
            DdlRelacionarSoftware.DataSource = Framework.GetDataTable("SELECT ID_ChaveAtivacao, NomeSoftware FROM tb_Chaves WHERE ID_ChaveAtivacao IN (SELECT MIN(ID_ChaveAtivacao) FROM tb_Chaves WHERE Deleted = 0 GROUP BY NomeSoftware);");
            DdlRelacionarSoftware.DataBind();
            DdlRelacionarSoftware.Items.Insert(0, new ListItem("Selecionar"));
        }

        protected void PopulaDdlRelacionarChaveAtivacao()
        {
            DdlRelacionarChaveAtivacao.DataSource = Framework.GetDataTable($"SELECT ID_ChaveAtivacao, ChaveAtivacao FROM tb_Chaves WHERE {DdlRelacionarSoftware.SelectedItem} = NomeSoftware AND Deleted = 0");
            DdlRelacionarChaveAtivacao.DataBind();
            DdlRelacionarChaveAtivacao.Items.Insert(0, new ListItem("Selecionar"));
        }

        protected void AtualizaGridUsuarios()
        {
            GridUsuarios.DataSource = Framework.GetDataTable("SELECT ID_Usuario, ID_Usuario, NomeUsuario, FuncaoUsuario, ID_Setor, SetorUsuario FROM tb_Usuarios WHERE Deleted = 0");
            GridUsuarios.DataBind();
        }

        protected void AtualizaGridMaquinas()
        {
            GridMaquinas.DataSource = Framework.GetDataTable("SELECT ID_Maquina, ID_Maquina, NomeMaquina, ID_Setor, SetorMaquina, Status FROM tb_Maquinas WHERE Deleted = 0");
            GridMaquinas.DataBind();
        }

        protected void AtualizaGridChaves()
        {
            GridChaves.DataSource = Framework.GetDataTable("SELECT ID_ChaveAtivacao, NomeSoftware, Fabricante, TipoLicenca, PrazoLicenca, ChaveAtivacao, Status FROM tb_Chaves WHERE Deleted = 0");
            GridChaves.DataBind();
        }

        protected void AtualizaGridRelacionar()
        {
            GridRelacionar.DataSource = Framework.GetDataTable("SELECT ID_Relacionar, UsuarioRelacionar, MaquinaRelacionar, ChaveAtivacaoRelacionar FROM tb_Relacionar WHERE Deleted = 0");
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
                        Usuario.Deleted = 0;

                        if (string.IsNullOrEmpty(HdfID.Value))
                        {
                            ctx.tb_Usuarios.Add(Usuario);
                        }
                    }
                    ctx.SaveChanges();
                    EscondePaineis();
                    LimpaCampos();
                    PnlConsultarUsuarios.Visible = true;
                    AtualizaGridUsuarios();
                    PopulaDdlRelacionarUsuario();
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
                        Maquina.Status = "INATIVA";
                        Maquina.Deleted = 0;

                        if (string.IsNullOrEmpty(HdfID.Value))
                        {
                            ctx.tb_Maquinas.Add(Maquina);
                        }
                        ctx.SaveChanges();
                        EscondePaineis();
                        LimpaCampos();
                        PnlConsultarMaquinas.Visible = true;
                        AtualizaGridMaquinas();
                        PopulaDdlRelacionarMaquina();
                    }
                }
                catch (Exception ex)
                {
                    Response.Write("Erro, " + ex.Message);
                }
            }
        }    /*REVISAR*/

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
                        PopulaDdlSetorMaquina();
                        PopulaDdlSetorUsuario();
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
                        Chave.Status = "INATIVA";
                        Chave.Deleted = 0;

                        if (string.IsNullOrEmpty(HdfID.Value))
                        {
                            ctx.tb_Chaves.Add(Chave);
                        }
                        ctx.SaveChanges();
                        EscondePaineis();
                        LimpaCampos();
                        PnlConsultarChaves.Visible = true;
                        AtualizaGridChaves();
                        PopulaDdlRelacionarSoftware();
                        PopulaDdlRelacionarChaveAtivacao();
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
                        PopulaDdlTipoLicenca();
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

        protected void CancelarRelacionar_Click(object sender, EventArgs e)
        {
            EscondePaineis();
            PnlRelacionar.Visible = true;
        }

        protected void SalvarRelacionar_Click(object sender, EventArgs e)
        {
            using (GCAEntities ctx = new GCAEntities())
            {
                tb_Relacionar Usuario = new tb_Relacionar();
                try
                {
                    if (!string.IsNullOrEmpty(HdfID.Value))
                    {
                        int _id = Convert.ToInt32(HdfID.Value);

                        var Query = (from objUsuario in ctx.tb_Relacionar select objUsuario);

                        Usuario = Query.FirstOrDefault();
                    }
                    else
                    {
                        Usuario.UsuarioRelacionar = DdlRelacionarUsuario.SelectedItem.ToString();
                        Usuario.ID_Usuario = Convert.ToInt32(DdlRelacionarUsuario.SelectedValue);
                        Usuario.MaquinaRelacionar = DdlRelacionarMaquina.SelectedItem.ToString();
                        Usuario.ID_Maquina = Convert.ToInt32(DdlRelacionarMaquina.SelectedValue);
                        Usuario.SoftwareRelacionar = DdlRelacionarSoftware.SelectedItem.ToString();
                        Usuario.ChaveAtivacaoRelacionar = DdlRelacionarChaveAtivacao.SelectedItem.ToString();
                        Usuario.ID_ChaveAtivacao = Convert.ToInt32(DdlRelacionarChaveAtivacao.SelectedValue);
                        Usuario.Deleted = 0;

                        if (string.IsNullOrEmpty(HdfID.Value))
                        {
                            ctx.tb_Relacionar.Add(Usuario);
                        }
                        ctx.SaveChanges();
                        EscondePaineis();
                        LimpaCampos();
                        PnlConsultarRelacionar.Visible = true;
                        AtualizaGridRelacionar();
                    }
                }
                catch (Exception ex)
                {
                    Response.Write("Erro, " + ex.Message);
                }
            }
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
                        Maquina.Status = "ATIVA";

                        if (string.IsNullOrEmpty(HdfID.Value))
                        {
                            ctx.tb_Maquinas.Add(Maquina);
                        }
                        ctx.SaveChanges();
                        AtualizaGridRelacionar();
                    }
                }
                catch (Exception ex)
                {
                    Response.Write("Erro, " + ex.Message);
                }
            }
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
                        Chave.Status = "ATIVA";

                        if (string.IsNullOrEmpty(HdfID.Value))
                        {
                            ctx.tb_Chaves.Add(Chave);
                        }
                        ctx.SaveChanges();
                        AtualizaGridRelacionar();
                    }
                }
                catch (Exception ex)
                {
                    Response.Write("Erro, " + ex.Message);
                }
            }
        }

        protected void LnkConsultaUsuario_Click(object sender, EventArgs e)
        {
            EscondePaineis();
            PnlConsultarUsuarios.Visible = true;
            AtualizaGridUsuarios();
        }

        protected void LnkConsultaMaquina_Click(object sender, EventArgs e)
        {
            EscondePaineis();
            PnlConsultarMaquinas.Visible = true;
            AtualizaGridMaquinas();
            PopulaDdlRelacionarMaquina();
        }

        protected void LnkConsultaChaves_Click(object sender, EventArgs e)
        {
            EscondePaineis();
            PnlConsultarChaves.Visible = true;
            AtualizaGridChaves();
        }

        protected void LnkConsultaRelacionar_Click(object sender, EventArgs e)
        {
            EscondePaineis();
            PnlConsultarRelacionar.Visible = true;
            AtualizaGridRelacionar();
        }

        protected void DdlRelacionarSoftware_SelectedIndexChanged(object sender, EventArgs e)
        {
            PopulaDdlRelacionarChaveAtivacao();
        }

        #endregion

        #region NeedDataSource

        protected void GridUsuarios_NeedDataSource(object sender, Telerik.Web.UI.GridNeedDataSourceEventArgs e)
        {
            GridUsuarios.DataSource = Framework.GetDataTable("SELECT ID_Usuario, ID_Usuario, NomeUsuario, FuncaoUsuario, ID_Setor, SetorUsuario FROM tb_Usuarios WHERE Deleted = 0");
        }

        protected void GridMaquinas_NeedDataSource(object sender, Telerik.Web.UI.GridNeedDataSourceEventArgs e)
        {
            GridMaquinas.DataSource = Framework.GetDataTable("SELECT ID_Maquina, ID_Maquina, NomeMaquina, ID_Setor, SetorMaquina FROM tb_Maquinas WHERE Deleted = 0");
        }

        protected void GridChaves_NeedDataSource(object sender, Telerik.Web.UI.GridNeedDataSourceEventArgs e)
        {
            GridChaves.DataSource = Framework.GetDataTable("SELECT ID_ChaveAtivacao, ID_ChaveAtivacao, NomeSoftware, Fabricante, TipoLicenca, PrazoLicenca, ChaveAtivacao FROM tb_Chaves WHERE Deleted = 0");
        }

        protected void GridRelacionar_NeedDataSource(object sender, Telerik.Web.UI.GridNeedDataSourceEventArgs e)
        {
            GridRelacionar.DataSource = Framework.GetDataTable("SELECT ID_Relacionar, UsuarioRelacionar, MaquinaRelacionar, ChaveAtivacaoRelacionar FROM tb_Relacionar WHERE Deleted = 0");
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
                        EscondePaineis();
                        LimpaCampos();
                        PopulaCamposCadastroUsuario(_cdID);
                        PnlCadastroUsuario.Visible = true;
                        break;

                    case "opExcluir":
                        using (GCAEntities ctx = new GCAEntities())
                        {
                            tb_Usuarios Usuario = new tb_Usuarios();

                            int ID = _cdID;
                            HdfID.Value = _cdID.ToString();

                            var Query = (from objUsuario in ctx.tb_Usuarios where objUsuario.ID_Usuario == ID select objUsuario).FirstOrDefault();

                            Query.Deleted = 1;
                            ctx.SaveChanges();
                            AtualizaGridUsuarios();
                        }
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
                        EscondePaineis();
                        LimpaCampos();
                        PopulaCamposCadastroMaquina(_cdID);
                        PnlCadastroMaquina.Visible = true;
                        break;

                    case "opExcluir":
                        using (GCAEntities ctx = new GCAEntities())
                        {
                            tb_Maquinas Maquina = new tb_Maquinas();

                            int ID = _cdID;
                            HdfID.Value = _cdID.ToString();

                            var Query = (from objMaquina in ctx.tb_Maquinas where objMaquina.ID_Maquina == ID select objMaquina).FirstOrDefault();

                            Query.Deleted = 1;
                            ctx.SaveChanges();
                            AtualizaGridMaquinas();
                        }
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
            try
            {
                int _cdID = Convert.ToInt32(e.Item.OwnerTableView.DataKeyValues[e.Item.ItemIndex]["ID_ChaveAtivacao"]);

                switch (e.CommandName)
                {
                    case "opSelecionar":
                        break;

                    case "opEditar":
                        EscondePaineis();
                        LimpaCampos();
                        PopulaCamposCadastroChave(_cdID);
                        PnlCadastroChaveAtivacao.Visible = true;
                        break;

                    case "opExcluir":
                        using (GCAEntities ctx = new GCAEntities())
                        {
                            tb_Chaves Chave = new tb_Chaves();

                            int ID = _cdID;
                            HdfID.Value = _cdID.ToString();

                            var Query = (from objChave in ctx.tb_Chaves where objChave.ID_ChaveAtivacao == ID select objChave).FirstOrDefault();

                            Query.Deleted = 1;
                            ctx.SaveChanges();
                            AtualizaGridChaves();
                        }
                        break;
                }
            }
            catch (Exception ex)
            {
                Response.Write("Erro, " + ex.Message);
            }
        }

        protected void GridRelacionar_ItemCommand(object sender, Telerik.Web.UI.GridCommandEventArgs e)
        {
            try
            {
                int _cdID = Convert.ToInt32(e.Item.OwnerTableView.DataKeyValues[e.Item.ItemIndex]["ID_Relacionar"]);

                switch (e.CommandName)
                {
                    case "opSelecionar":
                        break;

                    case "opEditar":
                        EscondePaineis();
                        LimpaCampos();
                        PopulaCamposRelacionar(_cdID);
                        PnlRelacionar.Visible = true;
                        break;

                    case "opExcluir":
                        using (GCAEntities ctx = new GCAEntities())
                        {
                            tb_Relacionar Relacionar = new tb_Relacionar();

                            int ID = _cdID;
                            HdfID.Value = _cdID.ToString();

                            var Query = (from objRelacionar in ctx.tb_Relacionar where objRelacionar.ID_Relacionar == ID select objRelacionar).FirstOrDefault();

                            Query.Deleted = 1;
                            ctx.SaveChanges();
                            AtualizaGridRelacionar();
                        }
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
                                    Chave.Status = "INATIVA";

                                    if (string.IsNullOrEmpty(HdfID.Value))
                                    {
                                        ctx.tb_Chaves.Add(Chave);
                                    }
                                    ctx.SaveChanges();
                                    AtualizaGridRelacionar();
                                }
                            }
                            catch (Exception ex)
                            {
                                Response.Write("Erro, " + ex.Message);
                            }
                        }
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
                                    Maquina.Status = "INATIVA";

                                    if (string.IsNullOrEmpty(HdfID.Value))
                                    {
                                        ctx.tb_Maquinas.Add(Maquina);
                                    }
                                    ctx.SaveChanges();
                                    AtualizaGridRelacionar();
                                }
                            }
                            catch (Exception ex)
                            {
                                Response.Write("Erro, " + ex.Message);
                            }
                        }
                        break;
                }
            }
            catch (Exception ex)
            {
                Response.Write("Erro, " + ex.Message);
            }
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
            }
        }
        #endregion

        
    }
}