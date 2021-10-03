using Cadastro.Connection;
using Challenge_Brunsker.Model;
using Newtonsoft.Json.Linq;
using System;
using System.Net.Http;
using System.Web;

namespace Challenge_Brunsker
{
    public partial class Cadastro : System.Web.UI.Page
    {
        HttpClient client;
        Uri usuarioUri;

        public Cadastro()
        {
            if (client == null)
            {
                client = new HttpClient();
                client.BaseAddress = new Uri("https://viacep.com.br/ws/");
                client.DefaultRequestHeaders.Accept.Add(new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"));
            }
        }
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        #region Ação de cadastrar o imóvel
        protected void btnCadastar_Click(object sender, EventArgs e)
        {
            try
            {
                int tamanho = uploadImagem.PostedFile.ContentLength;
                byte[] imgbyte = new byte[tamanho];

                HttpPostedFile img = uploadImagem.PostedFile;

                img.InputStream.Read(imgbyte, 0, tamanho);

                Imovel imovel = new Imovel()
                {
                    CEP = Convert.ToInt32(txtCep.Text),
                    Rua = txtRua.Text,
                    Complemento = TxtComplemento.Text,
                    Bairro = txtBairro.Text,
                    Cidade = txtCidade.Text,
                    UF = txtUF.Text,
                    Tipo_Imovel = Convert.ToInt32(ddlTipoImovel.SelectedValue),
                    Valor_Venda = Convert.ToDecimal(txtValorImovel.Text),
                    Metros_Quadrados = Convert.ToDecimal(txtMetroQuadrado.Text),
                    Quantidade_Quarto = Convert.ToInt32(txtQuantidadeQuarto.Text),
                    Quantidade_Banheiro = Convert.ToInt32(txtQuantidadeBanheiro.Text),
                    Vagas_Garagem = Convert.ToInt32(txtVagaGaragem.Text),
                    ArrayImagem = imgbyte
                };

                ConnectionMySql.CadastrarImovel(imovel);

                Response.Write("<script language='javascript'>alert('Imóvel cadastrado com sucesso!');</script>");

                LimparCamposCadastro();
                pnCadastro.Enabled = false;
            }
            catch (Exception)
            {

                Response.Write("<script language='javascript'>alert('Falha no cadastro!');</script>");
            }
            
        }

        #endregion

        #region Metódo para utilizar a Api ViaCep
        private ViaCep BuscarCep(string cep)
        {
            var endereco = new ViaCep();

            //Chamar a api pela url.
            System.Net.Http.HttpResponseMessage response = client.GetAsync($"{cep}/json").Result;

            if (response.IsSuccessStatusCode)
            {
                //pegando o cabeçalho
                usuarioUri = response.Headers.Location;

                //Pegando os dados do Rest e armazenando na variável usuários
                var jsonString = response.Content.ReadAsStringAsync().Result;

                JObject jsonResultadoObjeto = JObject.Parse(jsonString);

                endereco.Rua = (string)jsonResultadoObjeto["logradouro"];
                endereco.Bairro = (string)jsonResultadoObjeto["bairro"];
                endereco.Cidade = (string)jsonResultadoObjeto["localidade"];
                endereco.UF = (string)jsonResultadoObjeto["uf"];
                endereco.CEP = (string)jsonResultadoObjeto["cep"];
            }
            else
            {
                Response.Write(response.StatusCode.ToString() + " - " + response.ReasonPhrase);
            }
            return endereco;
        }
        #endregion

        #region Ação do botão buscar CEP via Api
        protected void btnBuscarCep_Click(object sender, System.Web.UI.ImageClickEventArgs e)
        {
            if (txtCep.Text != string.Empty)
            {
                pnCadastro.Enabled = true;
                var endereco = BuscarCep(txtCep.Text);
                txtRua.Text = endereco.Rua;
                txtBairro.Text = endereco.Bairro;
                txtCidade.Text = endereco.Cidade;
                txtUF.Text = endereco.UF;
                
            }
            else
            {
                //Incrementar o erro.
            }
        }
        #endregion


        private void LimparCamposCadastro()
        {
            
            txtCep.Text = string.Empty;
            txtRua.Text = string.Empty;
            TxtComplemento.Text = string.Empty;
            txtBairro.Text = string.Empty;
            txtCidade.Text = string.Empty;
            txtUF.Text = string.Empty;
            ddlTipoImovel.Text = "Selecione o tipo do imóvel";
            txtValorImovel.Text = string.Empty;
            txtMetroQuadrado.Text = string.Empty;
            txtQuantidadeQuarto.Text = string.Empty;
            txtQuantidadeBanheiro.Text = string.Empty;
            txtValorImovel.Text = string.Empty;
            txtVagaGaragem.Text = string.Empty;
            uploadImagem = null;
        }
    }

}