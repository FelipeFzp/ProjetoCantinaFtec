using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AplicacaoCantinaIUNIFTEC
{
    public static class Utilidades
    {
        public static bool ValidarCamposCadastroProdutos(string campoCodigo, string campoDataFabricacao, string campoNome, string campoPreco, string campoDataValidade)
        {
            float Preco=0f;
            var Fabricacao = DateTime.Parse(campoDataFabricacao, CultureInfo.InvariantCulture).Date;
            var Validade = DateTime.Parse(campoDataValidade, CultureInfo.CurrentCulture).Date;
            if (campoCodigo != string.Empty && Fabricacao.Year <= Validade.Year && 
                Fabricacao.DayOfYear <= Validade.DayOfYear &&
                campoNome != string.Empty && float.TryParse(campoPreco, out Preco))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
