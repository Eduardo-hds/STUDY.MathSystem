using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaMatematica
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string index = "s";
            int seletor = 0;

            Program program = new Program();


            Console.WriteLine("Bem Vindo ao sistema, aqui você tera varios calculos matematicos \n");

            while (index != "n") 
            {
                Console.Clear();
                Console.WriteLine("Digite o numero do calculo a ser escolhido:\n");

                Console.WriteLine("1 - Calcular media dos numeros.");
                Console.WriteLine("2 - Calcular area de um triangulo.");
                Console.WriteLine("3 - Calcular porcentagem.");


                seletor = Convert.ToInt32(Console.ReadLine());

                if (seletor == 1)
                {
                    CalcularMedia();

                    Console.WriteLine("Precione voltar ao inicio? (S/N)");
                    index = Console.ReadLine();
                    index = index.ToLower();

                } if (seletor == 2)
                {  
                    CalcularTriangulo();

                    Console.WriteLine("Precione voltar ao inicio? (S/N)");
                    index = Console.ReadLine();
                    index = index.ToLower();

                } if(seletor == 3) 
                {
                    Console.Clear();

                    int a;
                    int b;
                    double c;

                    Console.Write("Digte o valor do numero interio:");
                    a = Convert.ToInt32(Console.ReadLine());

                    Console.Write("Agora digite a porcentagem a ser achada:");
                    b = Convert.ToInt32(Console.ReadLine());

                    c = program.CalcularPorcentate(a,b);

                    Console.WriteLine("O resultado é: {0} \n", c);

                    Console.WriteLine("Precione voltar ao inicio? (S/N)");
                    index = Console.ReadLine();
                    index = index.ToLower();

                }

            }
        }

        static void CalcularMedia()
        {
            Console.Clear();
            
            string continuar = "s";
            double resposta;
            double media = 0;
            int quantidade = 0;

            while( continuar != "n") 
            {
                Console.Clear();
                Console.WriteLine("Digite o numero:");
                resposta = Convert.ToInt32(Console.ReadLine());

                media = media + resposta;
                quantidade++;
                
                Console.WriteLine("Deseja adicionar mais numeros?(S/N)");
                
                continuar = Console.ReadLine();
                continuar = continuar.ToLower();   
            }

            Console.Clear();

            Console.WriteLine("A media dos numeros é : {0}",media / quantidade);

        }

        static void CalcularTriangulo() 
        {
            double a;
            double b;
            double c;
            double s;
            double r;

            Console.Clear();

            Console.WriteLine("Digite o valor dos 3 lados do triangulo:");
            Console.Write("Lado A: ");
            a = Convert.ToDouble(Console.ReadLine());
            
            Console.Write("Lado B: ");
            b = Convert.ToDouble(Console.ReadLine());

            Console.Write("Lado C: ");
            c = Convert.ToDouble(Console.ReadLine());

            s = (a + b + c) / 2;

            

            r = Math.Sqrt(s * (s - a) * (s - b) * (s - c));

            if (r > 0)
            {
                Console.WriteLine("A area do triangulo é de : {0}", r);
            } else 
            {
                Console.WriteLine("Esses valores nao formar um triangulo");
             }

        }

        double CalcularPorcentate(int x, int y)
        {
            int resultado = (x * y) / 100 ;


            return resultado;
        } 
    }
}
