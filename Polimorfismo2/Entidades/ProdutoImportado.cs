using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace Polimorfismo2.Entidades {
    class ProdutoImportado: Produto{

        public double TaxaAlfandega { get; set; }

        public ProdutoImportado() {
        }

        public ProdutoImportado(string nome, double preco, double taxaAlfandega): base(nome, preco) {
            TaxaAlfandega = taxaAlfandega;
        }

        public double TotalPreco() {
            return Preco + TaxaAlfandega;
        }

        public override string PrecoEtiqueta() {
            return Nome + " R$ " + TotalPreco().ToString("F2",CultureInfo.InvariantCulture) + " (Taxa alfandegaria: " + TaxaAlfandega.ToString("F2", CultureInfo.InvariantCulture) + ")" ;
        }
    }
}
