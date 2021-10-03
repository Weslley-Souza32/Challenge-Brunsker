<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Cadastro.aspx.cs" Inherits="Challenge_Brunsker.Cadastro" MasterPageFile="~/Site.Master" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <div class="divCentral">
        <!-- Coluna CEP e botão de buscar -->
        <div class="mb-1">
            <div class="container">
                <div class="row">
                    <div class="col">
                        <asp:Label Text="CEP" ID="lblCEP" runat="server" />
                        <asp:TextBox ID="txtCep" runat="server" required="true" placeholder="Informe o CEP" class="form-control" />
                    </div>
                    <div class="col">
                        <asp:ImageButton ImageUrl="~/img/iconepesquisa.svg" runat="server" Text=" Pesquisar" CssClass="btn btn-light" ID="btnBuscarCep" OnClick="btnBuscarCep_Click" ToolTip="Clique aqui para buscar o CEP" />
                    </div>
                </div>
            </div>
        </div>
        <!-- Final Coluna CEP e botão de buscar -->
        <asp:Panel ID="pnCadastro" runat="server" enabled="false">
            <!-- colunas Rua e Complemento -->
            <div class="mb-1">
                <div class="container">
                    <div class="row">
                        <div class="col">
                            <asp:Label Text="Rua" ID="lblRua" runat="server" />
                            <asp:TextBox ID="txtRua" runat="server" placeholder="Informe a Rua" CssClass="form-control" />
                        </div>
                        <div class="col">
                            <asp:Label Text="Complemento" ID="lblComplemento" runat="server" />
                            <asp:TextBox ID="TxtComplemento" runat="server" placeholder="Complemento" CssClass="form-control" />
                        </div>
                    </div>
                </div>
            </div>
            <!--final colunas Rua e Complemento -->

            <!-- colunas Bairro e Cidade -->
            <div class="mb-1">
                <div class="container">
                    <div class="row">
                        <div class="col">
                            <asp:Label Text="Bairro" ID="lblBairro" runat="server" />
                            <asp:TextBox ID="txtBairro" runat="server" placeholder="Informe o Bairro" CssClass="form-control" />
                        </div>
                        <div class="col">
                            <asp:Label Text="Cidade" ID="lblCidade" runat="server" />
                            <asp:TextBox ID="txtCidade" runat="server" placeholder="Informe a Cidade" CssClass="form-control" />
                        </div>
                    </div>
                </div>
            </div>
            <!--final colunas Bairro e Cidade -->

            <!-- colunas UF e Tipo de imóveis -->
            <div class="mb-1">
                <div class="container">
                    <div class="row">
                        <div class="col">
                            <asp:Label Text="UF" ID="lblUF" runat="server" />
                            <asp:TextBox ID="txtUF" runat="server" placeholder="UF" CssClass="form-control" />
                        </div>
                        <div class="col">
                            <asp:Label Text="Tipo do imóvel" ID="lblTipoImovel" runat="server" />
                            <asp:DropDownList ID="ddlTipoImovel" runat="server" required="true" CssClass="form-control">
                                <asp:ListItem Text="Selecione o tipo do imóvel" />
                                <asp:ListItem Text="Casa" Value="1" />
                                <asp:ListItem Text="Apartamento" Value="2" />
                                <asp:ListItem Text="Clube" Value="3" />
                                <asp:ListItem Text="Fazenda" Value="4" />
                                <asp:ListItem Text="Flat" Value="5" />
                                <asp:ListItem Text="Cobertura" Value="6" />
                                <asp:ListItem Text="Terreno" Value="7" />
                                <asp:ListItem Text="Sítio" Value="8" />
                                <asp:ListItem Text="Galpão" Value="9" />
                                <asp:ListItem Text="Loja/Comércio" Value="10" />
                            </asp:DropDownList>
                        </div>
                    </div>
                </div>
            </div>
            <!--final colunas UF e Tipo de imóveis -->

            <!-- colunas Valor imóvel e adcionar imagem -->
            <div class="mb-1">
                <div class="container">
                    <div class="row">
                        <div class="col">
                            <asp:Label Text="Valor do imóvel" ID="lblValorImovel" runat="server" />
                            <asp:TextBox ID="txtValorImovel" runat="server" required="true" placeholder="Valor do Imóvel" class="form-control" />
                        </div>
                        <div class="col">
                            <asp:Label Text="Adcionar imagem" ID="lblAdcionarImagem" runat="server" />
                            <asp:FileUpload CssClass="form-control" runat="server" ID="uploadImagem"/>
                        </div>
                    </div>
                </div>
            </div>
            <!--final colunas Valor imóvel e adcionar imagem -->

            <!-- colunas metro quadrados e quantidade de quartos -->
            <div class="mb-1">
                <div class="container">
                    <div class="row">
                        <div class="col">
                            <asp:Label Text="M²" ID="lblMetroQuadrado" runat="server" />
                            <asp:TextBox ID="txtMetroQuadrado" runat="server" required="true" placeholder="M²" class="form-control" />
                        </div>
                        <div class="col">
                            <asp:Label Text="Quantidade de quartos" ID="lblPesquisar" runat="server" />
                            <asp:TextBox ID="txtQuantidadeQuarto" runat="server" required="true" placeholder="Quantidade de Quartos" class="form-control" />
                        </div>
                    </div>
                </div>
            </div>
            <!--final colunas -->

            <!-- colunas quantidade banheiro e vaga de garagem -->
            <div class="mb-3">
                <div class="container">
                    <div class="row">
                        <div class="col">
                            <asp:Label Text="Quantidade de banheiro" ID="lblQuantidadeBanheiro" runat="server" />
                            <asp:TextBox ID="txtQuantidadeBanheiro" runat="server" required="true" placeholder="Quantidade de Banheiros" class="form-control" />
                        </div>
                        <div class="col">
                            <asp:Label Text="Vaga de garagem" ID="lblVagaGaragem" runat="server" />
                            <asp:TextBox ID="txtVagaGaragem" runat="server" placeholder="Vaga de Garagem" class="form-control" />
                        </div>
                    </div>
                </div>
            </div>
            <!--final colunas -->
            
            <div class="mb-3">
                <asp:Button ID="btnCadastar" Text="Cadastrar" runat="server" CssClass="form-control btn btn-primary" OnClick="btnCadastar_Click" />
            </div>
        </asp:Panel>
    </div>
</asp:Content>
