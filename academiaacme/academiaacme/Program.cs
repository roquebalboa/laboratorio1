using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace academiaacme
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite nome, idade, altura(com ponto no lugar da vírgula) e peso");
            string nome = Console.ReadLine();
            int idade = int.Parse(Console.ReadLine());
            double altura = double.Parse(Console.ReadLine());
            float peso = float.Parse(Console.ReadLine());
            //array
            var usuario1 = new usuario("Bob Nelson", 37, 1.70, 78);
            var usuario2 = new usuario("Testolfo Rocha", 43, 1.65, 60);
            var usuario3 = new usuario("Lisa Leite", 22, 1.72, 92);
            var usuario4 = new usuario(nome, idade, altura, peso);
            usuario[] usuarios;
            usuarios = new usuario[4] { usuario1, usuario2, usuario3, usuario4 };
           

            Console.WriteLine("USUÁRIOS: \n");
            foreach (usuario alunoAcademia in usuarios)
            {
                double imc = alunoAcademia.imc;
                Console.WriteLine("NOME:{0}\nIDADE:{1}\nALTURA:{2}\nPESO:{3}\nIMC:{4}", alunoAcademia.Nome, alunoAcademia.Idade, alunoAcademia.Altura, alunoAcademia.Peso, alunoAcademia.imc);
               
                if (imc < 25)
                    Console.WriteLine(alunoAcademia.Nome + " Está com peso normal\n\n");
                else if (imc > 24.9 && imc < 30)
                    Console.WriteLine(alunoAcademia.Nome + " Está com sobrepeso\n\n");
                else if (imc > 29.9 && imc < 35)
                    Console.WriteLine(alunoAcademia.Nome + " Está com obesidade grau 1\n\n");
                else if (imc > 34.9 && imc < 40)
                    Console.WriteLine(alunoAcademia.Nome + " Está com obesidade grau 2\n\n");
                else
                    Console.WriteLine(alunoAcademia.Nome + " Está com obesidade grau 3 ou mórbida\n\n");
            }
            Console.ReadLine();



        }
    }
}
