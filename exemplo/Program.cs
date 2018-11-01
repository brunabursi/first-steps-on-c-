using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exemplo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Insira um número: ");
            String input1 = Console.ReadLine();

            Console.WriteLine("Insira o número para somar: ");
            String input2 = Console.ReadLine();

            int num1 = 0;
            int num2 = 0;

            int.TryParse(input1, out num1);
            int.TryParse(input2, out num2);

            if (num1 >= 0 || num1 <= 10 && num2 >= 0 || num2 <= 10)
            {            
                int result = num1 + num2;

                Console.WriteLine(result);
                Console.ReadKey();
            }
            else {
                Console.WriteLine("erro");
                    };

            {

            }
                
        }
    }
}

    

