using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prodykt
{
    class Program
    {
        static void Main(string[] args)
        {
            Molochka Prodykt = new Molochka("кефир", 7);

            Prodykt.MolochkaMethod();


            Console.Read();
        }
    }

    class Molochka
    {
        protected string Name { get; set; }
        protected int Shelflife { get; set; }

        public Molochka(string name, int Shelflife)
        {
            Name = name;
            Shelflife = Shelflife;
            Console.WriteLine("Родительский класс создан");
        }

        public virtual void MolochkaMethod()
        {
            Console.WriteLine("Кефир: {0} может храниться в холодильнике 14 дней ", Name, Shelflife);
        }


    }

    class Prodykt : Molochka
    {
        public Prodykt(string name, int Shelflife) : base(name, Shelflife)
        {
            Name = name;
            Shelflife = Shelflife;
            Console.WriteLine("Дочерний класс создан");
        }

        public override void MolochkaMethod()
        {
            Console.WriteLine("Молочка: {0} имеет срок годности {1} дней", Name, Shelflife);
        }
    }
}