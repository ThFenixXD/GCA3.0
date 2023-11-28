<%@ Page Title="" Language="C#" MasterPageFile="~/Web Forms/MasterPage.Master" AutoEventWireup="true" CodeBehind="PagConsultar.aspx.cs" Inherits="ProjectGCA3._0.Web_Forms.PagUsuarios" %>

<%@ Register Assembly="Telerik.Web.UI" Namespace="Telerik.Web.UI" TagPrefix="telerik" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">


     <asp:Panel ID="PnlCadastroOpcoes" CssClass="Pnl col-9 col-md-9 col-sm-9 d-flex align-items-center justify-content-center text-center" runat="server">
        <section class="row opcoes gap-2">
            <div class="col-12 col-md-12 col-sm-12 text-uppercase  mb-3">
                <asp:Label ID="lbCadastroTitulo" CssClass="LbTitulo" runat="server" Text="Consultar"></asp:Label>
            </div>
            <div class=" opcoes-item col-12 col-md-12 col-sm-12">
                <asp:LinkButton ID="lnkUsuario" CssClass="LnkButton border d-flex m-auto" runat="server" OnClick="lnkUsuario_Click" >
                    <span class="icon"><i class="bi bi-person-circle"></i></span>
                    <span class="txt-link">Usuário</span>
                </asp:LinkButton>
            </div>
            <div class=" opcoes-item col-12 col-md-12 col-sm-12">
                <asp:LinkButton ID="lnkMaquina" CssClass="LnkButton border d-flex m-auto" runat="server" OnClick="lnkMaquina_Click" >
                    <span class="icon"><i class="bi bi-pc-display-horizontal"></i></span>
                    <span class="txt-link">Máquina</span>
                </asp:LinkButton>
            </div>
            <div class="opcoes-item col-12 col-md-12 col-sm-12">
                <asp:LinkButton ID="lnkChaves" CssClass="LnkButton border d-flex m-auto" runat="server" OnClick="lnkChaves_Click" >
                    <span class="icon"><i class="bi bi-key"></i></span>
                    <span class="txt-link text-start">Chaves de Ativação</span>
                </asp:LinkButton>
            </div>
        </section>
    </asp:Panel>


    <asp:Panel ID="PnlUsuarios" CssClass="Pnl col-9 col-md-9 col-sm-9 d-flex align-items-center justify-content-center text-center" runat="server" Visible="false">
        <telerik:RadGrid ID="GridUsuarios" runat="server" AutoGenerateColumns="false" OnNeedDataSource="GridUsuarios_NeedDataSource" OnItemCommand="GridUsuarios_ItemCommand">
            <GroupingSettings CollapseAllTooltip="collaps all columns" />
            <MasterTableView DataKeyNames="ID_Usuario">
                <%--INSERIR DATAKEYNAMES--%>
                <Columns>
                    <telerik:GridTemplateColumn UniqueName="OP" AllowFiltering="false">
                        <ItemTemplate>
                            <asp:Button ID="btSelecionar" runat="server" Text="Selecionar" CommandName="opSelecionar" />
                            <asp:Button ID="btEditar" runat="server" Text="editar" CommandName="opEditar" />
                            <asp:Button ID="btexcluir" runat="server" Text="excluir" CommandName="opExcluir" />
                        </ItemTemplate>
                    </telerik:GridTemplateColumn>
                    <telerik:GridBoundColumn UniqueName="col_CodUsuario" DataField="ID_Usuario" HeaderText="COD"></telerik:GridBoundColumn>
                    <telerik:GridBoundColumn UniqueName="col_NomeUsuario" DataField="NomeUsuario" HeaderText="USUÁRIO"></telerik:GridBoundColumn>
                    <telerik:GridBoundColumn UniqueName="col_Funcao" DataField="FuncaoUsuario" HeaderText="FUNÇÃO"></telerik:GridBoundColumn>
                    <telerik:GridBoundColumn UniqueName="col_Setor" DataField="SetorUsuario" HeaderText="SETOR"></telerik:GridBoundColumn>
                </Columns>
            </MasterTableView>
        </telerik:RadGrid>
    </asp:Panel>

    <asp:Panel ID="PnlMaquinas" CssClass="Pnl col-9 col-md-9 col-sm-9 d-flex align-items-center justify-content-center text-center" runat="server" Visible="false">
        <telerik:RadGrid ID="GridMaquinas" runat="server" AutoGenerateColumns="false" OnNeedDataSource="GridMaquinas_NeedDataSource" OnItemCommand="GridMaquinas_ItemCommand">
            <GroupingSettings CollapseAllTooltip="collaps all columns" />
            <MasterTableView DataKeyNames="ID_Maquina">
                <Columns>
                    <telerik:GridTemplateColumn UniqueName="OP" AllowFiltering="false">
                        <ItemTemplate>
                            <asp:Button ID="btSelecionar" runat="server" Text="Selecionar" CommandName="opSelecionar" />
                            <asp:Button ID="btEditar" runat="server" Text="editar" CommandName="opEditar" />
                            <asp:Button ID="btexcluir" runat="server" Text="excluir" CommandName="opExcluir" />
                        </ItemTemplate>
                    </telerik:GridTemplateColumn>
                    <telerik:GridBoundColumn UniqueName="col_CodMaquina" DataField="ID_Maquina" HeaderText="COD"></telerik:GridBoundColumn>
                    <telerik:GridBoundColumn UniqueName="col_NomeMaquina" DataField="NomeMaquina" HeaderText="NOME DA MÁQUINA"></telerik:GridBoundColumn>
                    <telerik:GridBoundColumn UniqueName="col_Setor" DataField="SetorMaquina" HeaderText="SETOR"></telerik:GridBoundColumn>
                </Columns>
            </MasterTableView>
        </telerik:RadGrid>
    </asp:Panel>

    <asp:Panel ID="PnlChaves" CssClass="Pnl col-9 col-md-9 col-sm-9 d-flex align-items-center justify-content-center text-center" runat="server" Visible="false">
        <telerik:RadGrid ID="GridChaves" runat="server" AutoGenerateColumns="false" OnNeedDataSource="GridChaves_NeedDataSource" OnItemCommand="GridChaves_ItemCommand">
            <GroupingSettings CollapseAllTooltip="collaps all columns" />
            <MasterTableView DataKeyNames="ID_ChaveAtivacao">
                <Columns>
                    <telerik:GridTemplateColumn UniqueName="OP" AllowFiltering="false">
                        <ItemTemplate>
                            <asp:Button ID="btSelecionar" runat="server" Text="Selecionar" CommandName="opSelecionar" />
                            <asp:Button ID="btEditar" runat="server" Text="editar" CommandName="opEditar" />
                            <asp:Button ID="btexcluir" runat="server" Text="excluir" CommandName="opExcluir" />
                        </ItemTemplate>
                    </telerik:GridTemplateColumn>
                    <telerik:GridBoundColumn UniqueName="col_CodChaveAtivacao" DataField="ID_ChaveAtivacao" HeaderText="COD"></telerik:GridBoundColumn>
                    <telerik:GridBoundColumn UniqueName="col_NomeSoftware" DataField="NomeSoftware" HeaderText="Nome do Software"></telerik:GridBoundColumn>
                    <telerik:GridBoundColumn UniqueName="col_Fabricante" DataField="Fabricante" HeaderText="Fabricante"></telerik:GridBoundColumn>
                    <telerik:GridBoundColumn UniqueName="col_TipoLicenca" DataField="TipoLicenca" HeaderText="Tipo de Licenca"></telerik:GridBoundColumn>
                    <telerik:GridBoundColumn UniqueName="col_PrazoLicenca" DataField="PrazoLicenca" HeaderText="Prazo de Licenca"></telerik:GridBoundColumn>
                    <telerik:GridBoundColumn UniqueName="col_ChaveAtivacao" DataField="ChaveAtivacao" HeaderText="Chave de Ativação"></telerik:GridBoundColumn>
                </Columns>
            </MasterTableView>
        </telerik:RadGrid>
    </asp:Panel>

</asp:Content>
