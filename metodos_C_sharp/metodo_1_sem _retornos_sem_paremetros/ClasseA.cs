using metodos_C_sharp.metodo_1_sem__retornos_sem_paremetros;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;  

namespace metodos_C_sharp
{
    class Program
    {
        static void Main(string[] args)
        {
            ClasseB cb = new ClasseB();

            cb.abertura_programa();
            cb.soma();
            cb.mult();
            Console.ReadKey();

            cb.soma2();
            Console.ReadLine();
        }
    }
}
