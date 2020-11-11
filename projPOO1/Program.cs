using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace projPOO1
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Coisas coisas = new Coisas(5);
            Console.WriteLine(coisas.mostraCoisas());

            Console.WriteLine(coisas.addCoisa(new Coisa(55, "cinquenta e cinco")) ? "Incluiu" : "Não incluiu");
            Console.WriteLine(coisas.addCoisa(new Coisa(66, "sessenta e seis")) ? "Incluiu" : "Não incluiu");
            Console.WriteLine(coisas.addCoisa(new Coisa(77, "setenta e sete")) ? "Incluiu" : "Não incluiu");
            Console.WriteLine(coisas.mostraCoisas());

            Console.WriteLine(coisas.delCoisa(new Coisa(66, "sessenta e seis")) ? "Deletou" : "Não deletou");
            Console.WriteLine(coisas.mostraCoisas());

            Console.WriteLine(coisas.searchCoisa( new Coisa(77, "") ).dados() );

            if (coisas.searchCoisa(new Coisa(99, "")).Id == -1)
                Console.WriteLine("Não encontrado");
            else
                Console.WriteLine(coisas.searchCoisa(new Coisa(99, "")).dados());


            Console.ReadKey();
        }
    }
}
