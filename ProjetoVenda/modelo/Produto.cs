using System;
using System.Collections.Generic;
using System.Text;

namespace ProjetoVenda.modelo
{
    internal class Produto
    {
        public int cod_produto { get; set;}
        public int cod_funcionario { get; set; }
        public string nome { get; set; }
        public string marca { get; set; }
        public int preco { get; set; }
        public int quantidade { get; set; }
        public DateTime data_registro { get; set; }

        public decimal precoReal => this.preco / 100m;

        public void validar()
        {
            if (preco <= 0)
            {
                throw new ArgumentException("O preço nao pode Zerado!");
            }
            if (quantidade < 0)
            {
                throw new ArgumentException("O quantidade nao pode ser menor que Zero");
            }
        }

    }
}
