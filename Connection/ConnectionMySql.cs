using Challenge_Brunsker.Model;
using MySql.Data.MySqlClient;
using System;
using System.Data;


namespace Cadastro.Connection
{
    public class ConnectionMySql
    {
        #region Cadastro Imoveis
        public static void CadastrarImovel(Imovel imovel)
        {
            MySqlConnection conexao = new MySqlConnection();
            conexao.ConnectionString = @"server=localhost;database=wvlocacao;uid = root;pwd = 34454541Vw@nem";
            string query = $@"insert into imovel
                            (
                            CEP,
                            Rua,
                            Complemento,
                            Bairro,
                            Cidade,
                            UF,
                            Tipo_Imovel,
                            Valor_Venda,
                            Metros_Quadrados,
                            Quantidade_Quarto,
                            Quantidade_Banheiro,
                            Vagas_Garagem,
                            Imagem_Imovel
                            ) values 
                            (
                            {imovel.CEP},
                            '{imovel.Rua}',
                            '{imovel.Complemento}',
                            '{imovel.Bairro}',
                            '{imovel.Cidade}',
                            '{imovel.UF}',
                            {imovel.Tipo_Imovel},
                            {imovel.Valor_Venda},
                            {imovel.Metros_Quadrados},
                            {imovel.Quantidade_Quarto},
                            {imovel.Quantidade_Banheiro},
                            {imovel.Vagas_Garagem},
                            @imagem
                            )";
            try
            {
                conexao.Open();
                MySqlCommand command = new MySqlCommand(query, conexao);
                command.Parameters.Add("@imagem", MySqlDbType.LongBlob).Value = imovel.ArrayImagem;
                command.ExecuteNonQuery();

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);

            }
            finally
            {
                conexao.Close();
            }

        }
        #endregion

        #region Exibir imóveis cadastrados
        public static DataTable ExibirImovel()
        {
            MySqlConnection connection = new MySqlConnection();
            DataTable dtImovel = new DataTable();


            connection.ConnectionString = @"server=localhost;database=wvlocacao;uid = root;pwd = 34454541Vw@nem";
            string query = $"SELECT * FROM imovel";

            try
            {
                connection.Open();
                MySqlDataAdapter adapter = new MySqlDataAdapter(query, connection);
                adapter.Fill(dtImovel);

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
                
            }
            finally
            {
                connection.Close();
            }
            return dtImovel;
        }
        #endregion

        #region Pesquisar o imovel pelo seu codigo ID
        public static DataTable PesquisarPorId(int codigoImovel)
        {
            MySqlConnection conexao = new MySqlConnection();
            conexao.ConnectionString = @"server=localhost;database=wvlocacao;uid = root;pwd = 34454541Vw@nem";
            DataTable dtImovel = new DataTable();
            string query = $"SELECT * FROM imovel where ID = {codigoImovel} ";

            try
            {
                conexao.Open();
                MySqlDataAdapter adapter = new MySqlDataAdapter(query, conexao);
                adapter.Fill(dtImovel);
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
            finally
            {
                conexao.Close();
            }
            return dtImovel;
        }
        #endregion

        #region Editar/Atualizar imóvel
        public static void AtualizarImovel(Imovel imovel)
        {
            MySqlConnection connection = new MySqlConnection();
            connection.ConnectionString = @"server=localhost;database=wvlocacao;uid = root;pwd = 34454541Vw@nem";
            string comandoMySql = $@"UPDATE imovel SET 
                                  Tipo_Imovel = '{imovel.Tipo_Imovel}',
                                  Valor_Venda = {imovel.Valor_Venda},
                                  Metros_Quadrados = {imovel.Metros_Quadrados},
                                  Quantidade_Quarto = {imovel.Quantidade_Quarto},
                                  Quantidade_Banheiro = {imovel.Quantidade_Banheiro},
                                  Vagas_Garagem = {imovel.Vagas_Garagem}
                                  WHERE ID = {imovel.ID}";
                                  

            try
            {
                connection.Open();
                MySqlCommand command = new MySqlCommand(comandoMySql, connection);
                //command.Parameters.RemoveAt( MySqlDbType.LongBlob.ToString());
                command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                connection.Close();
            }
        }
        #endregion

        #region Deletar imóvel pelo código ID
        public static void DeletarImovel(int codigoImovel)
        {
            MySqlConnection connection = new MySqlConnection();
            connection.ConnectionString = "server=localhost;database=wvlocacao;uid = root;pwd = 34454541Vw@nem";
            string comandoMySql = $"DELETE FROM imovel WHERE ID = '{codigoImovel}'";

            try
            {
                connection.Open();
                MySqlCommand command = new MySqlCommand(comandoMySql, connection);
                command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                connection.Close();
            }
        }
        #endregion
    }
}
