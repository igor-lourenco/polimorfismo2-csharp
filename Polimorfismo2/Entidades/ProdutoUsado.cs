using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace Polimorfismo2.Entidades {
    class ProdutoUsado : Produto{

        public DateTime DataManufaturado { get; set; }

        public ProdutoUsado() {
        }

        public ProdutoUsado(string nome, double preco, DateTime dataManufaturado) : base(nome, preco){
            DataManufaturado = dataManufaturado;
        }

        public override string PrecoEtiqueta() {
            return Nome + " (usado) R$ " + Preco.ToString("F2",CultureInfo.InvariantCulture) + " (Data de fabricacao: " + DataManufaturado.ToString("dd/MM/yyyy") + ")";
        }
    }
}
