﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ProjectGCA3._0.Útil;

namespace ProjectGCA3._0.Web_Forms
{
    public partial class PagUsuarios : System.Web.UI.Page
    {
        #region Métodos

        protected void EscondePaineis()
        {
            PnlCadastroOpcoes.Visible = false;
            PnlUsuarios.Visible = false;
            PnlMaquinas.Visible = false;
            PnlChaves.Visible = false;
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

        #endregion

        #region Click

        protected void lnkUsuario_Click(object sender, EventArgs e)
        {
            EscondePaineis();
            PnlUsuarios.Visible = true;
            AtualizaGridUsuarios("SELECT ID_Usuario, ID_Usuario, NomeUsuario, FuncaoUsuario, SetorUsuario FROM tb_Usuarios WHERE Status = 1 AND Deleted = 0");
        }

        protected void lnkMaquina_Click(object sender, EventArgs e)
        {
            EscondePaineis();
            PnlMaquinas.Visible = true;
            AtualizaGridMaquinas("SELECT ID_Maquina, ID_Maquina, NomeMaquina, SetorMaquina FROM tb_Maquinas WHERE Deleted = 0");
        }

        protected void lnkChaves_Click(object sender, EventArgs e)
        {
            EscondePaineis();
            PnlChaves.Visible = true;
            AtualizaGridChaves("SELECT ID_ChaveAtivacao, NomeSoftware, Fabricante, TipoLicenca, PrazoLicenca, ChaveAtivacao FROM tb_Chaves WHERE Deleted = 0");
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

        }
        #endregion
    }
}
