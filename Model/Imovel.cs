using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Challenge_Brunsker.Model
{
    public class Imovel
    {
        public int ID { get; set; }
        public int CEP { get; set; }
        public string Rua { get; set; }
        public string Complemento { get; set; }
        public string Bairro { get; set; }
        public string Cidade { get; set; }
        public string UF { get; set; }
        public int Tipo_Imovel { get; set; }
        public decimal Valor_Venda { get; set; }
        public decimal Metros_Quadrados { get; set; }
        public int Quantidade_Quarto { get; set; }
        public int Quantidade_Banheiro { get; set; }
        public int Vagas_Garagem { get; set; }
        public byte[] ArrayImagem { get; set; }
    }
}