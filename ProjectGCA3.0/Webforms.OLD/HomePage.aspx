﻿<%@ Page Title="" Language="C#" MasterPageFile="~/Web Forms/MasterPage.Master" AutoEventWireup="true" CodeBehind="HomePage.aspx.cs" Inherits="ProjectGCA3._0.Web_Forms.HomePage" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:Panel CssClass="PnlApresentacao col-9 col-md-9 col-sm-9 d-flex align-items-center justify-content-center" runat="server">
        <div class="row text-center">
            <asp:Label class="lbTextBlock lbHomeTItulo col-12 col-md-12 col-sm-12 " runat="server" Text="GCA"></asp:Label>
            <asp:Label class="lbTextBlock lbHomeSubTItulo col-12 col-md-12 col-sm-12" runat="server" Text="Gerenciador de Chaves de Ativação"></asp:Label>
            <p class="lbTextBlock col-12 col-md-12 col-sm-12">
                Bem vindo ao GCA aqui você poderá gerenciar suas chaves de ativação através de um sistema de
            consulta e cadastros...
            </p>
        </div>
    </asp:Panel>
</asp:Content>
