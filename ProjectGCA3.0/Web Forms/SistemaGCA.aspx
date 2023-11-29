<%@ Page Title="" Language="C#" MasterPageFile="~/Web Forms/MasterPage.Master" AutoEventWireup="true" CodeBehind="SistemaGCA.aspx.cs" Inherits="ProjectGCA3._0.Web_Forms.PagCadastro" %>

<%@ Register Assembly="Telerik.Web.UI" Namespace="Telerik.Web.UI" TagPrefix="telerik" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <%-- INÍCIO --%>

    <asp:Panel ID="PnlApresentacao" CssClass="PnlApresentacao col-9 col-md-9 col-sm-9 d-flex align-items-center justify-content-center" runat="server" Visible="true">
        <div class="row text-center">
            <asp:Label class="lbTextBlock lbHomeTItulo col-12 col-md-12 col-sm-12 " runat="server" Text="GCA"></asp:Label>
            <asp:Label class="lbTextBlock lbHomeSubTItulo col-12 col-md-12 col-sm-12" runat="server" Text="Gerenciador de Chaves de Ativação"></asp:Label>
            <p class="lbTextBlock col-12 col-md-12 col-sm-12">
                Bem vindo ao GCA aqui você poderá gerenciar suas chaves de ativação através de um sistema de
            consulta e cadastros...
            </p>
        </div>
    </asp:Panel>

    <%-- CADASTRAR --%>

    <asp:Panel ID="PnlCadastroOpcoes" CssClass="Pnl col-9 col-md-9 col-sm-9 d-flex align-items-center justify-content-center text-center" runat="server" Visible="false">
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
                    <asp:Label ID="lbNomeUsuario" CssClass="lbTextBlock col-4 col-md-4 col-sm-4 p-0 m-0" runat="server" Text="Nome do Usuário"></asp:Label>
                    <asp:TextBox ID="txtNomeUsuario" CssClass="txtTextBlock col-8 col-md-8 col-sm-8" runat="server"></asp:TextBox>
                </div>
                <div class="row">
                    <asp:Label ID="lbFuncao" CssClass="lbTextBlock col-4 col-md-4 col-sm-4" runat="server" Text="Função"></asp:Label>
                    <asp:TextBox ID="txtFuncaoUsuario" CssClass="col-8 col-md-8 col-sm-8" runat="server"></asp:TextBox>
                </div>
                <div class="row">
                    <asp:Label ID="lbSetorUsuario" CssClass="lbTextBlock col-4 col-md-4 col-sm-4" runat="server" Text="Setor"></asp:Label>
                    <asp:DropDownList ID="ddlSetorUsuario" CssClass="col-8 col-md-8 col-sm-8 text-center" runat="server" DataTextField="NomeSetor" DataValueField="ID_Setor"></asp:DropDownList>
                </div>
                <div class="row p-0 m-0 gap-3">
                    <div class="col-7 col-md-7 col-sm-7"></div>
                    <asp:Button ID="BtSalvarUsuario" CssClass="col-2 col-md-2 col-sm-2" runat="server" Text="Salvar" OnClick="BtSalvarUsuario_Click" />
                    <asp:Button ID="BtCancelarUsuario" CssClass="col-2 col-md-2 col-sm-2" runat="server" Text="Cancelar" OnClick="BtCancelarUsuario_Click" />
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
                    <asp:DropDownList ID="DdlSetorMaquina" CssClass="col-8 col-md-8 col-sm-8 text-center" runat="server" DataTextField="NomeSetor" DataValueField="ID_Setor"></asp:DropDownList>
                </div>
                <div class="row p-0 m-0 gap-3 justify-content-end">
                    <div class="col-7 col-md-7 col-sm-7"></div>
                    <asp:Button ID="BtSalvarMaquina" CssClass="col-2 col-md-2 col-sm-2" runat="server" Text="Salvar" OnClick="BtSalvarMaquina_Click" />
                    <asp:Button ID="BtCancelarMaquina" CssClass="col-2 col-md-2 col-sm-2" runat="server" Text="Cancelar" OnClick="BtCancelarMaquina_Click" />
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
                    <asp:TextBox ID="txtNomeSetor" CssClass="col-8 col-md-8 col-sm-8" runat="server"></asp:TextBox>
                </div>
                <div class="row p-0 m-0 gap-3 justify-content-end">
                    <div class="col-7 col-md-7 col-sm-7"></div>
                    <asp:Button ID="BtSalvarSetor" CssClass="col-2 col-md-2 col-sm-2" runat="server" Text="Salvar" OnClick="BtSalvarSetor_Click" />
                    <asp:Button ID="BtCancelarSetor" CssClass="col-2 col-md-2 col-sm-2" runat="server" Text="Cancelar" OnClick="BtCancelarSetor_Click" />
                </div>
            </div>
        </section>
    </asp:Panel>

    <asp:Panel ID="PnlCadastroChaveAtivacao" CssClass="Pnl col-9 col-md-9 col-sm-9 d-flex align-items-center justify-content-center text-center" runat="server" Visible="false">
        <section class="row">
            <div class="col-12 col-md-12 col-sm-12 mb-5 text-uppercase">
                <asp:Label ID="lbChaveAtivacaoTitulo" CssClass="LbTitulo" runat="server" Text="Chave de Ativação"></asp:Label>
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
                    <asp:DropDownList ID="ddlTipolicenca" CssClass="col-8 col-md-8 col-sm-8 text-center" runat="server" DataTextField="TipoLicenca" DataValueField="ID_TipoLicenca"></asp:DropDownList>
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
                    <asp:Button ID="BtSalvarChaveAtivacao" CssClass="col-2 col-md-2 col-sm-2" runat="server" Text="Salvar" OnClick="BtSalvarChaveAtivacao_Click" />
                    <asp:Button ID="BtCancelarChaveAtivacao" CssClass="col-2 col-md-2 col-sm-2" runat="server" Text="Cancelar" OnClick="BtCancelarChaveAtivacao_Click" />
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
                    <asp:Button ID="BtSalvarTipoLicenca" CssClass="col-2 col-md-2 col-sm-2" runat="server" Text="Salvar" OnClick="BtSalvarTipoLicenca_Click" />
                    <asp:Button ID="BtCancelarTipoLicenca" CssClass="col-2 col-md-2 col-sm-2" runat="server" Text="Cancelar" OnClick="BtCancelarTipoLicenca_Click" />
                </div>
            </div>
        </section>
    </asp:Panel>

    <%-- CONSULTAR --%>

    <asp:Panel ID="PnlConsultar" CssClass="Pnl col-9 col-md-9 col-sm-9 d-flex align-items-center justify-content-center text-center" runat="server" Visible="false">
        <section class="row opcoes gap-2">
            <div class="col-12 col-md-12 col-sm-12 text-uppercase  mb-3">
                <asp:Label ID="Label1" CssClass="LbTitulo" runat="server" Text="Consultar"></asp:Label>
            </div>
            <div class=" opcoes-item col-12 col-md-12 col-sm-12">
                <asp:LinkButton ID="LnkConsultaUsuario" CssClass="LnkButton border d-flex m-auto" runat="server" OnClick="LnkConsultaUsuario_Click">
                    <span class="icon"><i class="bi bi-person-circle"></i></span>
                    <span class="txt-link">Usuário</span>
                </asp:LinkButton>
            </div>
            <div class=" opcoes-item col-12 col-md-12 col-sm-12">
                <asp:LinkButton ID="LnkConsultaMaquina" CssClass="LnkButton border d-flex m-auto" runat="server" OnClick="LnkConsultaMaquina_Click">
                    <span class="icon"><i class="bi bi-pc-display-horizontal"></i></span>
                    <span class="txt-link">Máquina</span>
                </asp:LinkButton>
            </div>
            <div class="opcoes-item col-12 col-md-12 col-sm-12">
                <asp:LinkButton ID="LnkConsultaChaves" CssClass="LnkButton border d-flex m-auto" runat="server" OnClick="LnkConsultaChaves_Click">
                    <span class="icon"><i class="bi bi-key"></i></span>
                    <span class="txt-link text-start">Chaves de Ativação</span>
                </asp:LinkButton>
            </div>
        </section>
    </asp:Panel>

    <asp:Panel ID="PnlConsultarUsuarios" CssClass="Pnl col-9 col-md-9 col-sm-9 d-flex align-items-center justify-content-center text-center" runat="server" Visible="false">
        <telerik:RadGrid ID="GridUsuarios" runat="server" AutoGenerateColumns="false" OnNeedDataSource="GridUsuarios_NeedDataSource" OnItemCommand="GridUsuarios_ItemCommand">
            <GroupingSettings CollapseAllTooltip="collaps all columns" />
            <MasterTableView DataKeyNames="ID_Usuario">
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

    <asp:Panel ID="PnlConsultarMaquinas" CssClass="Pnl col-9 col-md-9 col-sm-9 d-flex align-items-center justify-content-center text-center" runat="server" Visible="false">
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

    <asp:Panel ID="PnlConsultarChaves" CssClass="Pnl col-9 col-md-9 col-sm-9 d-flex align-items-center justify-content-center text-center" runat="server" Visible="false">
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
                    <telerik:GridBoundColumn UniqueName="col_NomeSoftware" DataField="NomeSoftware" HeaderText="SOFTWARE"></telerik:GridBoundColumn>
                    <telerik:GridBoundColumn UniqueName="col_Fabricante" DataField="Fabricante" HeaderText="FABRICANTE"></telerik:GridBoundColumn>
                    <telerik:GridBoundColumn UniqueName="col_TipoLicenca" DataField="TipoLicenca" HeaderText="TIPO DE LICENÇA"></telerik:GridBoundColumn>
                    <telerik:GridBoundColumn UniqueName="col_PrazoLicenca" DataField="PrazoLicenca" HeaderText="PRAZO DE LICENÇA"></telerik:GridBoundColumn>
                    <telerik:GridBoundColumn UniqueName="col_ChaveAtivacao" DataField="ChaveAtivacao" HeaderText="CHAVE DE ATIVAÇÃO"></telerik:GridBoundColumn>
                </Columns>
            </MasterTableView>
        </telerik:RadGrid>
    </asp:Panel>

    <asp:Panel ID="PnlConsultarRelacionar" CssClass="Pnl col-9 col-md-9 col-sm-9 d-flex align-items-center justify-content-center text-center" runat="server" Visible="false">
        <telerik:RadGrid ID="GridRelacionar" runat="server" AutoGenerateColumns="false" OnNeedDataSource="GridChaves_NeedDataSource" OnItemCommand="GridChaves_ItemCommand">
            <GroupingSettings CollapseAllTooltip="collaps all columns" />
            <MasterTableView DataKeyNames="ID_Relacionar">
                <Columns>
                    <telerik:GridTemplateColumn UniqueName="OP" AllowFiltering="false">
                        <ItemTemplate>
                            <asp:Button ID="btSelecionar" runat="server" Text="Selecionar" CommandName="opSelecionar" />
                            <asp:Button ID="btEditar" runat="server" Text="editar" CommandName="opEditar" />
                            <asp:Button ID="btexcluir" runat="server" Text="excluir" CommandName="opExcluir" />
                        </ItemTemplate>
                    </telerik:GridTemplateColumn>
                    <telerik:GridBoundColumn UniqueName="col_CodChaveAtivacao" DataField="NomeUsuario" HeaderText="USUARIO"></telerik:GridBoundColumn>
                    <telerik:GridBoundColumn UniqueName="col_NomeSoftware" DataField="NomeMaquina" HeaderText="MAQUINA"></telerik:GridBoundColumn>
                    <telerik:GridBoundColumn UniqueName="col_Fabricante" DataField="NomeSoftware" HeaderText="SOFTWARE"></telerik:GridBoundColumn>
                    <telerik:GridBoundColumn UniqueName="col_ChaveAtivacao" DataField="ChaveAtivacao" HeaderText="CHAVE DE ATIVAÇÃO"></telerik:GridBoundColumn>
                </Columns>
            </MasterTableView>
        </telerik:RadGrid>
    </asp:Panel>

    <%-- RELACIONAR --%>

    <asp:Panel ID="PnlRelacionar" CssClass="Pnl col-9 col-md-9 col-sm-9 d-flex align-items-center justify-content-center text-center" runat="server" Visible="false">
        <section class="row">
            <div class="col-12 col-md-12 col-sm-12 mx-auto mb-5 text-uppercase">
                <asp:Label ID="Label2" CssClass="LbTitulo" runat="server" Text="Relacionar"></asp:Label>
            </div>
            <div class="DivTextBlock row d-flex m-auto p-0 gap-4">
                <div class="row p-0 m-0 gap-2 justify-content-evenly">
                    <asp:Label CssClass="lbRelacionar col-4 col-md-4 col-sm-4 text-center" runat="server" Text="Usuario"></asp:Label>
                    <asp:Label CssClass="lbRelacionar col-4 col-md-4 col-sm-4 text-center" runat="server" Text="Máquina"></asp:Label>
                </div>
                <div class="row p-0 m-0 gap-4 justify-content-evenly">
                    <asp:DropDownList ID="DdlRelacionarUsuario" CssClass="col-4 col-md-4 col-sm-4 text-center" runat="server" DataTextField="NomeUsuario" DataValueField="ID_Usuario"></asp:DropDownList>
                    <asp:DropDownList ID="DdlRelacionarMaquina" CssClass="col-4 col-md-4 col-sm-4 text-center" runat="server" DataTextField="NomeMaquina" DataValueField="ID_Maquina"></asp:DropDownList>
                </div>
                <div class="row p-0 m-0 gap-4 justify-content-evenly">
                    <asp:Label CssClass="lbRelacionar col-4 col-md-4 col-sm-4 text-center" runat="server" Text="Software"></asp:Label>
                    <asp:Label CssClass="lbRelacionar col-4 col-md-4 col-sm-4 text-center" runat="server" Text="Chave de Ativação"></asp:Label>
                </div>
                <div class="row p-0 m-0 gap-4 justify-content-evenly">
                    <asp:DropDownList ID="DdlRelacionarSoftware" CssClass="col-4 col-md-4 col-sm-4 text-center" runat="server" DataTextField="NomeSoftware" DataValueField="ID_ChaveAtivacao"></asp:DropDownList>
                    <asp:DropDownList ID="DdlRelacionarChaveAtivacao" CssClass="col-4 col-md-4 col-sm-4 text-center" runat="server" DataTextField="ChaveAtivacao" DataValueField="ID_ChaveAtivacao"></asp:DropDownList>
                </div>
                <div class="row gap-4 mt-5 justify-content-center">
                    <asp:Button ID="SalvarRelacionar" CssClass="col-3 col-md-3 col-sm-3 text-center" runat="server" Text="Salvar" OnClick="SalvarRelacionar_Click" />
                    <asp:Button ID="CancelarRelacionar" CssClass="col-3 col-md-3 col-sm-3  text-center" runat="server" Text="Cancelar" OnClick="CancelarRelacionar_Click" />
                </div>
            </div>
        </section>
    </asp:Panel>

    <asp:HiddenField ID="HdfID" runat="server" />
</asp:Content>
