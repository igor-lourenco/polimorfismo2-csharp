using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace Polimorfismo2.Entidades {
    class Produto {

        public string Nome { get; set; }
        public double Preco { get; set; }

        public Produto() {
        }

        public Produto(string nome, double preco) {
            Nome = nome;
            Preco = preco;
        }

        public virtual string PrecoEtiqueta() {
            return Nome + "  R$ " + Preco.ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
