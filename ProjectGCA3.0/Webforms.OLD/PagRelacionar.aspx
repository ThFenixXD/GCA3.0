<%@ Page Title="" Language="C#" MasterPageFile="~/Web Forms/MasterPage.Master" AutoEventWireup="true" CodeBehind="PagRelacionar.aspx.cs" Inherits="ProjectGCA3._0.Web_Forms.PagRelacionar" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:Panel ID="PnlRelacionar" CssClass="Pnl col-9 col-md-9 col-sm-9 d-flex align-items-center justify-content-center text-center" runat="server">
        <section class="row">
            <div class="col-12 col-md-12 col-sm-12 mx-auto mb-5 text-uppercase">
                <asp:Label ID="lbUsuarioTitulo" CssClass="LbTitulo" runat="server" Text="Relacionar"></asp:Label>
            </div>
            <div class="DivTextBlock row d-flex m-auto p-0 gap-2">
                <div class="row p-0 m-0 gap-1 justify-content-between">
                    <asp:Label CssClass="lbRelacionar col-2 col-md-2 col-sm-2 " runat="server" Text="Usuario"></asp:Label>
                    <asp:Label CssClass="lbRelacionar col-2 col-md-2 col-sm-2" runat="server" Text="Máquina"></asp:Label>
                    <asp:Label CssClass="lbRelacionar col-2 col-md-2 col-sm-2" runat="server" Text="Software"></asp:Label>
                    <asp:Label CssClass="lbRelacionar col-5 col-md-5 col-sm-5" runat="server" Text="Chave de Ativação"></asp:Label>
                </div>
                <div class="row p-0 m-0 gap-1 justify-content-between">
                    <asp:DropDownList CssClass="col-2 col-md-2 col-sm-2" runat="server"></asp:DropDownList>
                    <asp:DropDownList CssClass="col-2 col-md-2 col-sm-2" runat="server"></asp:DropDownList>
                    <asp:DropDownList CssClass="col-2 col-md-2 col-sm-2" runat="server"></asp:DropDownList>
                    <asp:DropDownList CssClass="col-5 col-md-5 col-sm-5" runat="server"></asp:DropDownList>
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
