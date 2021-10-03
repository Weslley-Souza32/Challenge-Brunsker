using Cadastro.Connection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Challenge_Brunsker
{
    public partial class CatalogoImovel : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //Incluir o código para pegar minhas imagens do BD e jogar no meu catalogo de imóvel.
            //Falta implementar.
            ConnectionMySql.ExibirImovel();
            
        }
    }
}