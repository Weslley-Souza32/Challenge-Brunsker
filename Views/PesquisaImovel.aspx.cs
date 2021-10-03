using Cadastro.Connection;
using Challenge_Brunsker.Model;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Challenge_Brunsker.Views
{
    public partial class PesquisaImovel : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        #region Ação do botão buscar o imovel cadastrado no banco pelo ID
        protected void btnBuscarPorID_Click(object sender, ImageClickEventArgs e)
        {
            if (!string.IsNullOrEmpty(txtPesquisaID.Text))
            {
                pnPesquisa.Enabled = true;
                BloqueiaOsCampos();
                
                var dtImovel = (ConnectionMySql.PesquisarPorId(Convert.ToInt32(txtPesquisaID.Text)));
                txtCep.Text = dtImovel.Rows[0]["CEP"].ToString();
                txtRua.Text = dtImovel.Rows[0]["Rua"].ToString();
                TxtComplemento.Text = dtImovel.Rows[0]["Complemento"].ToString();
                txtBairro.Text = dtImovel.Rows[0]["Bairro"].ToString();
                txtCidade.Text = dtImovel.Rows[0]["Cidade"].ToString();
                txtUF.Text = dtImovel.Rows[0]["UF"].ToString();
                txtTipoImovel.Text = dtImovel.Rows[0]["Tipo_Imovel"].ToString();
                txtValorImovel.Text = dtImovel.Rows[0]["Valor_Venda"].ToString();
                txtMetroQuadrado.Text = dtImovel.Rows[0]["Metros_Quadrados"].ToString();
                txtQuantidadeQuarto.Text = dtImovel.Rows[0]["Quantidade_quarto"].ToString();
                txtQuantidadeBanheiro.Text = dtImovel.Rows[0]["Quantidade_Banheiro"].ToString();
                txtVagaGaragem.Text = dtImovel.Rows[0]["Vagas_Garagem"].ToString();
                
            }
        }
        #endregion

        #region Ação do botão excluir o imovel cadastrado no banco pelo ID
        protected void btnExluir_Click(object sender, EventArgs e)
        {
            ConnectionMySql.DeletarImovel(Convert.ToInt32(txtPesquisaID.Text));

            Response.Write("<script language='javascript'>alert('Imóvel excluido com sucesso!');</script>");
            LimparCampos();
        }
        #endregion

        #region Ação do botão editar o imovel cadastrado no banco pelo ID
        protected void btnEditarImovel_Click(object sender, EventArgs e)
        {
            string[] imoveis = { txtTipoImovel.Text, txtValorImovel.Text, txtMetroQuadrado.Text,
                                 txtQuantidadeQuarto.Text, txtQuantidadeBanheiro.Text, txtVagaGaragem.Text, txtPesquisaID.Text };


            ConnectionMySql.AtualizarImovel(retornaImovel(imoveis));
        }
        #endregion

        #region Metódo que preenche os campos do imovel
        private Imovel retornaImovel(string[] imoveis)
        {
            
            Imovel imovel = new Imovel();

            imovel.Tipo_Imovel = Convert.ToInt32(imoveis[0]);
            imovel.Valor_Venda = Convert.ToDecimal(imoveis[1]);
            imovel.Metros_Quadrados = Convert.ToDecimal(imoveis[2]);
            imovel.Quantidade_Quarto = Convert.ToInt32(imoveis[3]);
            imovel.Quantidade_Banheiro = Convert.ToInt32(imoveis[4]);
            imovel.Vagas_Garagem = Convert.ToInt32(imoveis[5]);
            imovel.ID = Convert.ToInt32(imoveis[6]);

            return imovel;
        }
        #endregion

        #region Metódo de limpar os campos
        private void LimparCampos()
        {
            txtPesquisaID.Text = string.Empty;
            txtCep.Text = string.Empty;
            txtRua.Text = string.Empty;
            TxtComplemento.Text = string.Empty;
            txtBairro.Text = string.Empty;
            txtCidade.Text = string.Empty;
            txtUF.Text = string.Empty;
            txtTipoImovel.Text = string.Empty;
            txtValorImovel.Text = string.Empty;
            txtMetroQuadrado.Text = string.Empty;
            txtQuantidadeQuarto.Text = string.Empty;
            txtQuantidadeBanheiro.Text = string.Empty;
            txtValorImovel.Text = string.Empty;
            txtVagaGaragem.Text = string.Empty;
        }
        #endregion

        #region Metódo para que os campos não sejam editados
        private void BloqueiaOsCampos()
        {
            txtCep.Enabled = false;
            txtRua.Enabled = false;
            TxtComplemento.Enabled = false;
            txtBairro.Enabled = false;
            txtCidade.Enabled = false;
            txtUF.Enabled = false;
        }
        #endregion
    }
}