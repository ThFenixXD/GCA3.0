<%@ Page Title="" Language="C#" MasterPageFile="~/Web Forms/MasterPage.Master" AutoEventWireup="true" CodeBehind="PagCadastro.aspx.cs" Inherits="ProjectGCA3._0.Web_Forms.PagCadastro" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <asp:Panel ID="PnlCadastroOpcoes" CssClass="Pnl col-9 col-md-9 col-sm-9 d-flex align-items-center justify-content-center text-center" runat="server">
        <section class="row opcoes gap-2">
            <div class="col-12 col-md-12 col-sm-12 text-uppercase  mb-3">
                <asp:Label ID="lbCadastroTitulo" CssClass="LbTitulo" runat="server" Text="Cadastrar"></asp:Label>
            </div>
            <div class=" opcoes-item col-12 col-md-12 col-sm-12">
                <asp:LinkButton ID="lnkUsuario" CssClass="LnkButton border d-flex m-auto" runat="server" OnClick="lnkUsuario_Click">
                    <span class="icon"><i class="bi bi-person-circle"></i></span>
                    <span class="txt-link">Usuário</span>
                </asp:LinkButton>
            </div>
            <div class=" opcoes-item col-12 col-md-12 col-sm-12">
                <asp:LinkButton ID="lnkMaquina" CssClass="LnkButton border d-flex m-auto" runat="server" OnClick="lnkMaquina_Click">
                    <span class="icon"><i class="bi bi-pc-display-horizontal"></i></span>
                    <span class="txt-link">Máquina</span>
                </asp:LinkButton>
            </div>
            <div class="opcoes-item col-12 col-md-12 col-sm-12">
                <asp:LinkButton ID="lnkSetor" CssClass="LnkButton border d-flex m-auto" runat="server" OnClick="lnkSetor_Click">
                    <span class="icon"><i class="bi bi-buildings"></i></span>
                    <span class="txt-link">Setor</span>
                </asp:LinkButton>
            </div>
            <div class="opcoes-item col-12 col-md-12 col-sm-12">
                <asp:LinkButton ID="lnkChaves" CssClass="LnkButton border d-flex m-auto" runat="server" OnClick="lnkChaves_Click">
                    <span class="icon"><i class="bi bi-key"></i></span>
                    <span class="txt-link text-start">Chaves de Ativação</span>
                </asp:LinkButton>
            </div>
            <div class="opcoes-item col-12 col-md-12 col-sm-12">
                <asp:LinkButton ID="lnkTipoLicenca" CssClass="LnkButton border d-flex m-auto" runat="server" OnClick="lnkTipoLicenca_Click">
                    <span class="icon"><i class="bi bi-cc-circle"></i></span>
                    <span class="txt-link text-start">Tipo de Licença</span>
                </asp:LinkButton>
            </div>
        </section>
    </asp:Panel>

    <asp:Panel ID="PnlCadastroUsuario" CssClass="Pnl col-9 col-md-9 col-sm-9 d-flex align-items-center justify-content-center text-center" runat="server" Visible="false">
        <section class="row">
            <div class="col-12 col-md-12 col-sm-12 mb-5 text-uppercase">
                <asp:Label ID="lbUsuarioTitulo" CssClass="LbTitulo" runat="server" Text="Usuário"></asp:Label>
            </div>
            <div class="DivTextBlock row d-flex m-auto gap-2">
                <div class="row">
                    <asp:Label ID="lbNomeUsuario" CssClass="lbTextBlock col-4 col-md-4 col-sm-4" runat="server" Text="Nome do Usuário"></asp:Label>
                    <asp:TextBox ID="txtNomeUsuario" CssClass="txtTextBlock col-8 col-md-8 col-sm-8" runat="server"></asp:TextBox>
                </div>
                <div class="row">
                    <asp:Label ID="lbFuncao" CssClass="lbTextBlock col-4 col-md-4 col-sm-4" runat="server" Text="Função"></asp:Label>
                    <asp:TextBox ID="txtFuncao" CssClass="col-8 col-md-8 col-sm-8" runat="server"></asp:TextBox>
                </div>
                <div class="row">
                    <asp:Label ID="lbSetorUsuario" CssClass="lbTextBlock col-4 col-md-4 col-sm-4" runat="server" Text="Setor"></asp:Label>
                    <asp:DropDownList ID="ddlSetor" CssClass="col-8 col-md-8 col-sm-8" runat="server"></asp:DropDownList>
                </div>
                <div class="row p-0 m-0 gap-3">
                    <div class="col-7 col-md-7 col-sm-7"></div>
                    <asp:Button CssClass="col-2 col-md-2 col-sm-2"  runat="server" Text="Salvar"/>
                    <asp:Button CssClass="col-2 col-md-2 col-sm-2" runat="server" Text="Cancelar"/>
                </div>
            </div>
        </section>
    </asp:Panel>

    <asp:Panel ID="PnlCadastroMaquina" CssClass="Pnl col-9 col-md-9 col-sm-9 d-flex align-items-center justify-content-center text-center" runat="server" Visible="false">
        <section class="row">
            <div class="col-12 col-md-12 col-sm-12 mb-5 text-uppercase">
                <asp:Label ID="lbMaquinaTitulo" CssClass="LbTitulo" runat="server" Text="Máquina"></asp:Label>
            </div>
            <div class="DivTextBlock row d-flex m-auto gap-2">
                <div class="row">
                    <asp:Label ID="lbNomeMaquina" CssClass="lbTextBlock col-4 col-md-4 col-sm-4 p-0" runat="server" Text="Nome da Máquina"></asp:Label>
                    <asp:TextBox ID="txtNomeMaquina" CssClass="col-8 col-md-8 col-sm-8 p-0" runat="server"></asp:TextBox>
                </div>
                <div class="row">
                    <asp:Label ID="lbSetorMaquina" CssClass="lbTextBlock col-4 col-md-4 col-sm-4" runat="server" Text="Setor"></asp:Label>
                    <asp:DropDownList ID="DdlSetorMaquina" CssClass="col-8 col-md-8 col-sm-8" runat="server"></asp:DropDownList>
                </div>
                <div class="row p-0 m-0 gap-3 justify-content-end">
                    <div class="col-7 col-md-7 col-sm-7"></div>
                    <asp:Button CssClass="col-2 col-md-2 col-sm-2"  runat="server" Text="Salvar"/>
                    <asp:Button CssClass="col-2 col-md-2 col-sm-2" runat="server" Text="Cancelar"/>
                </div>
            </div>
        </section>
    </asp:Panel>

    <asp:Panel ID="PnlCadastroSetor" CssClass="Pnl col-9 col-md-9 col-sm-9 d-flex align-items-center justify-content-center text-center" runat="server" Visible="false">
        <section class="row">
            <div class="col-12 col-md-12 col-sm-12 mb-5 text-uppercase">
                <asp:Label ID="lbSetorTitulo" CssClass="LbTitulo" runat="server" Text="Setor"></asp:Label>
            </div>
            <div class="DivTextBlock row d-flex m-auto gap-2">
                <div class="row">
                    <asp:Label ID="lbSetor" CssClass="lbTextBlock col-4 col-md-4 col-sm-4" runat="server" Text="Nome do Setor"></asp:Label>
                    <asp:TextBox ID="txtSetor" CssClass="col-8 col-md-8 col-sm-8" runat="server"></asp:TextBox>
                </div>
                <div class="row p-0 m-0 gap-3 justify-content-end">
                    <div class="col-7 col-md-7 col-sm-7"></div>
                    <asp:Button CssClass="col-2 col-md-2 col-sm-2"  runat="server" Text="Salvar"/>
                    <asp:Button CssClass="col-2 col-md-2 col-sm-2" runat="server" Text="Cancelar"/>
                </div>
            </div>
        </section>
    </asp:Panel>

    <asp:Panel ID="PnlCadastroChaveAtivacao" CssClass="Pnl col-9 col-md-9 col-sm-9 d-flex align-items-center justify-content-center text-center" runat="server" Visible="false">
        <section class="row">
            <div class="col-12 col-md-12 col-sm-12 mb-5 text-uppercase">
                <asp:Label ID="lbChaveAticacaoTitulo" CssClass="LbTitulo" runat="server" Text="Chave de Ativação"></asp:Label>
            </div>
            <div class="DivTextBlock row d-flex m-auto gap-2">
                <div class="row">
                    <asp:Label ID="lbNomeSoftware" CssClass="lbTextBlock col-4 col-md-4 col-sm-4 p-0" runat="server" Text="Nome do Software"></asp:Label>
                    <asp:TextBox ID="txtNomeSoftware" CssClass="col-8 col-md-8 col-sm-8" runat="server"></asp:TextBox>
                </div>
                <div class="row">
                    <asp:Label ID="lbFabricante" CssClass="lbTextBlock col-4 col-md-4 col-sm-4" runat="server" Text="Fabricante"></asp:Label>
                    <asp:TextBox ID="txtFabricante" CssClass="col-8 col-md-8 col-sm-8" runat="server"></asp:TextBox>
                </div>
                <div class="row">
                    <asp:Label ID="lbTipoLicenca" CssClass="lbTextBlock col-4 col-md-4 col-sm-4 p-0" runat="server" Text="Tipo de Licença"></asp:Label>
                    <asp:DropDownList ID="ddlTipolicenca" CssClass="col-8 col-md-8 col-sm-8" runat="server"></asp:DropDownList>
                </div>
                <div class="row">
                    <asp:Label ID="lbPrazoLicenca" CssClass="lbTextBlock col-4 col-md-4 col-sm-4 p-0" runat="server" Text="Prazo de Licença"></asp:Label>
                    <asp:TextBox ID="txtPrazoLicenca" CssClass="col-8 col-md-8 col-sm-8" runat="server"></asp:TextBox>
                </div>
                <div class="row">
                    <asp:Label ID="lbChaveAtivacao" CssClass="lbTextBlock col-4 col-md-4 col-sm-4 p-0" runat="server" Text="Chave de Ativação"></asp:Label>
                    <asp:TextBox ID="txtChaveAtivacao" CssClass="col-8 col-md-8 col-sm-8" runat="server"></asp:TextBox>
                </div>
                <div class="row p-0 m-0 gap-3 justify-content-end">
                    <div class="col-7 col-md-7 col-sm-7"></div>
                    <asp:Button CssClass="col-2 col-md-2 col-sm-2"  runat="server" Text="Salvar"/>
                    <asp:Button CssClass="col-2 col-md-2 col-sm-2" runat="server" Text="Cancelar"/>
                </div>
            </div>
        </section>
    </asp:Panel>

    <asp:Panel ID="PnlCadastroTipoLicenca" CssClass="Pnl col-9 col-md-9 col-sm-9 d-flex align-items-center justify-content-center text-center" runat="server" Visible="false">
        <section class="row">
            <div class="col-12 col-md-12 col-sm-12 mb-5 text-uppercase">
                <asp:Label ID="lbTipoLicençaTitulo" CssClass="LbTitulo" runat="server" Text="Tipo de Licença"></asp:Label>
            </div>
            <div class="DivTextBlock row d-flex m-auto gap-2">
                <div class="row">
                    <asp:Label ID="lbTipoLicanca" CssClass="lbTextBlock col-4 col-md-4 col-sm-4" runat="server" Text="Tipo de Licença"></asp:Label>
                    <asp:TextBox ID="txtTipoLicenca" CssClass="col-8 col-md-8 col-sm-8" runat="server"></asp:TextBox>
                </div>
                <div class="row p-0 m-0 gap-3 justify-content-end">
                    <div class="col-7 col-md-7 col-sm-7"></div>
                    <asp:Button CssClass="col-2 col-md-2 col-sm-2"  runat="server" Text="Salvar"/>
                    <asp:Button CssClass="col-2 col-md-2 col-sm-2" runat="server" Text="Cancelar"/>
                </div>
            </div>
        </section>
    </asp:Panel>

</asp:Content>
