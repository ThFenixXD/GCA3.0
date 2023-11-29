using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProjectGCA3._0.Útil
{
    public class Class1
    {
        //protected void PopulaCampos(int _cdID)
        //{
        //    using (EmpresaXEntities ctx = new EmpresaXEntities())
        //    {
        //        int cdID = _cdID;
        //        hdfID.Value = _cdID.ToString();

        //        tb_Produtos Produto = new tb_Produtos();

        //        var Query = (from objProduto in ctx.tb_Produtos where objProduto.ID_Produto == cdID select objProduto).FirstOrDefault();

        //        txtProduto.Text = Query.Produto;
        //        ddlID_Categoria.Text = Query.ID_Categoria.ToString();
        //        txtDescricaoProduto.Text = Query.Descricao;

        //    }
        //}

        //protected void PopulaCampos(int _cdID)
        //{
        //    using (GCAEntities ctx = new GCAEntities())
        //    {
        //        int cdID = _cdID;
        //        HdfID.Value = _cdID.ToString();

        //        tb_Usuarios Usuario = new tb_Usuarios();

        //        var Query = (from objUsuario in ctx.tb_Usuarios where objUsuario.ID_Usuario == cdID select objUsuario).FirstOrDefault();

        //        txtNomeUsuario.Text = Query.NomeUsuario;
        //        txtFuncaoUsuario.Text = Query.FuncaoUsuario;
        //        ddlSetorUsuario.Text = Query.SetorUsuario;

        //    }
        //}


        //protected void btSalvarCategoria_Click(object sender, EventArgs e)
        //{
        //            using (EmpresaXEntities ctx = new EmpresaXEntities())
        //            {
        //                tb_Categorias Categoria = new tb_Categorias();
        //                try
        //                {
        //                    if (!string.IsNullOrEmpty(hdfID.Value))
        //                    {
        //                        int _id = Convert.ToInt32(hdfID.Value);

        //    var Query = (from objCategoria in ctx.tb_Categorias select objCategoria);

        //    Categoria = Query.FirstOrDefault();
        //                    }
        //                    else
        //                    {
        //                        Categoria.Categoria = txtNovaCategoria.Text;
        //                        Categoria.Deleted = 0;

        //                        if (string.IsNullOrEmpty(hdfID.Value))
        //                        {
        //                            ctx.tb_Categorias.Add(Categoria);
        //                        }
        //                        ctx.SaveChanges();
        //                        EscondePaineis();
        //pnlGridCadastroProdutos.Visible = true;

        //                        AtualizaGrid("SELECT tb_Produtos.ID_Produto, tb_Produtos.Produto, tb_Categorias.ID_Categoria, tb_Categorias.Categoria, tb_Produtos.Descricao " +
        //                                         "FROM tb_Produtos " +
        //                                         "INNER JOIN tb_Categorias " +
        //                                         "ON tb_Produtos.ID_Categoria = tb_Categorias.ID_Categoria " +
        //                                         "WHERE tb_Produtos.Deleted = 0");
        //                    }
        //                }
        //                catch (Exception ex)
        //                {
        //                    Response.Write("Erro, " + ex.Message);
        //                }
        //            }
        //}
    }
}