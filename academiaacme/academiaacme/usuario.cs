using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace academiaacme
{
    class usuario
    {
        // Informações
        public string Nome { get; }
        public int Idade { get; set; }
        public double Altura { get; set; }
        public float Peso { get; set; }
        public double imc { get; }


        public usuario(string Nome, int Idade, double Altura, float Peso)
        {
            this.Nome = Nome;
            this.Idade = Idade;
            this.Altura = Altura;
            this.Peso = Peso;
            imc = Peso / (Altura * Altura);

        }

    }
}