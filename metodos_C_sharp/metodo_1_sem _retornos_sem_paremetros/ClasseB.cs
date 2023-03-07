using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace metodos_C_sharp.metodo_1_sem__retornos_sem_paremetros
{
    class ClasseB
    {
        // Metodo sem retorno e sem parametro

        public void soma()
            {
            int n1 = 200, n2 = 300;
            int res_soma = n1 + n2;

            Console.WriteLine("O resultado da soma é " + res_soma);
            }

            public void mult()
            {
            int f1 = 600, f2 = 20;
            int res_mult = f1 * f2;

            Console.WriteLine("O resultado da multiplicação é " + res_mult);
            }

            public void abertura_programa()
            {
            Console.WriteLine("\t\tprograma de métodos em c#\n\n");
            }

            public void soma2()
            {
            Console.WriteLine("Digite o 1º número");
            int n1 = Int32.Parse(Console.ReadLine());

            Console.WriteLine("Digite o 2º número");
            int n2 = Int32.Parse(Console.ReadLine());

            int res_soma = n1 + n2;

            Console.WriteLine("O resultado da soma é " + res_soma);
            }
    }
}
