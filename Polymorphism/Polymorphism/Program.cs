using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism
{
    

        public class СombatUnit
        {
            public int Energy { get; set; } = 100;
            virtual public void Battle() => Console.WriteLine("-----СombatUnit------");

        }
        public class Elf : СombatUnit
        {
            public override void Battle() => Console.WriteLine("++++++++Elf++++++");
        }

        public class Goblin : СombatUnit
        {
            public override void Battle() => Console.WriteLine("~~~~~~~Goblin~~~~~~");
        }
        class Program
        {
            private static void Main(string[] args)
            {
                Elf anna = new Elf();
                Elf olgA = new Elf();
                Goblin oleg = new Goblin();
                Elf nikita = new Elf();
                Goblin polina = new Goblin();

                СombatUnit[] army = { anna, oleg, olgA, nikita, polina };
                foreach (var unit in army)
                {
                    unit.Battle();
                }

                //  вызов методов по типу ссылки
            }

        }
    
}
