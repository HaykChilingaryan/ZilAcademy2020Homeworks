using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson11Homework
{
    public class Lion: WildAnimal
    {

        private string livingPlace;
        public Lion(string name, int age, string family, string livingPlace) : base(name, age, family)
        {
            this.livingPlace = livingPlace;
        }

        public override void MakeNoise()
        {
            Console.WriteLine("RRRRRR");
        }
    }
}
