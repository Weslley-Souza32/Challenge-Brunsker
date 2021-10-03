<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="PesquisaImovel.aspx.cs" Inherits="Challenge_Brunsker.Views.PesquisaImovel" MasterPageFile="~/Site.Master" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <div class="containsPesquisa">
        <div class="container">
            <div class="row">
                <div class="col">
                    <!-- Coluna Pesquisa por ID -->
                    <div class="mb-1">
                        <div class="container">
                            <div class="row">
                                <div class="col">
                                    <asp:Label Text="Código do imóvel" ID="lblCodImovel" runat="server" />
                                    <asp:TextBox ID="txtPesquisaID" runat="server" reuired="true" placeholder="Código do imóvel" CssClass="form-control" />
                                </div>
                                <div class="col">
                                    <asp:ImageButton ImageUrl="~/img/iconepesquisa.svg" ID="btnBuscarPorID" runat="server" CssClass="btn btn-ligth" Height="38px" ToolTip="Clique para pesquisar." OnClick="btnBuscarPorID_Click" />
                                </div>
                            </div>
                        </div>
                    </div>
                    <!-- Final Coluna Pesquisa por ID -->

                    <asp:Panel ID="pnPesquisa" runat="server" Enabled="false">
                        <div class="mb-1">
                            <div class="container">
                                <div class="row">
                                    <div class="col">
                                        <asp:Label Text="CEP" ID="lbl" runat="server" />
                                        <asp:TextBox ID="txtCep" runat="server" placeholder="CEP" CssClass="form-control" />
                                    </div>
                                    <div class="col">
                                    </div>
                                </div>
                            </div>
                        </div>
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

                        <div class="mb-1">
                            <div class="container">
                                <div class="row">
                                    <div class="col">
                                        <asp:Label Text="UF" ID="lblUF" runat="server" />
                                        <asp:TextBox ID="txtUF" runat="server" placeholder="UF" CssClass="form-control" />
                                    </div>
                                    <div class="col">
                                        <asp:Label Text="Tipo do imóvel" ID="lblTipoImovel" runat="server" />
                                        <asp:TextBox ID="txtTipoImovel" runat="server" placeholder="Tipo do Imóvel" CssClass="form-control" />
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
                                        <asp:TextBox ID="txtValorImovel" runat="server" placeholder="Valor do Imóvel" class="form-control" />
                                    </div>
                                    <div class="col">
                                        <asp:Label Text="Imagem" ID="lblImagem" runat="server" />
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
                                        <asp:TextBox ID="txtMetroQuadrado" runat="server" placeholder="M²" class="form-control" />
                                    </div>
                                    <div class="col">
                                        <asp:Label Text="Quantidade de quarto" ID="lblQuantidadeQuarto" runat="server" />
                                        <asp:TextBox ID="txtQuantidadeQuarto" runat="server" placeholder="Quantidade de Quarto" class="form-control" />
                                    </div>
                                </div>
                            </div>
                        </div>
                        <!--final colunas metro quadrado e quantidade de quartos -->

                        <!-- colunas quantidade banheiro e vaga de garagem -->
                        <div class="mb-1">
                            <div class="container">
                                <div class="row">
                                    <div class="col">
                                        <asp:Label Text="Quantidade de banheiro" ID="lblQuantidadeBanheiro" runat="server" />
                                        <asp:TextBox ID="txtQuantidadeBanheiro" runat="server" placeholder="Quantidade de Banheiros" class="form-control" />
                                    </div>
                                    <div class="col">
                                        <asp:Label Text="Vaga de garagem" ID="lblVagaGaragem" runat="server" />
                                        <asp:TextBox ID="txtVagaGaragem" runat="server" placeholder="Vaga de Garagem" class="form-control" />
                                    </div>

                                </div>
                            </div>
                        </div>
                        <!--final colunas quantidade banheiro e vaga de garagem -->

                        <!-- colunas botões editar e excluir -->
                        <div class="mb-1">
                            <div class="container">
                                <div class="row">
                                    <div class="col">
                                        <asp:Button ID="btnEditarImovel" Text="Editar" runat="server" CssClass=" btn btn-primary" OnClick="btnEditarImovel_Click" />
                                    </div>
                                    <div class="col">
                                        <asp:Button ID="btnExluir" Text="Excluir" runat="server" CssClass=" btn btn-primary" OnClick="btnExluir_Click" />
                                    </div>
                                </div>
                            </div>
                        </div>
                        <!--final colunas botões editar e excluir -->
                    </asp:Panel>
                </div>
            </div>
        </div>
    </div>
    <div class="containerImagem">
        <div class="col">
            <asp:Image ImageUrl="imageurl" runat="server" Height="550" Width="600" />
        </div>
    </div>
</asp:Content>
