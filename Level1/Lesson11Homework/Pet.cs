using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson11Homework
{
    public class Pet:Animal
    {
        private string family;
        public Pet(string name, int age, string family) : base(name, age)
        {
            this.family = family;
        }

        public override void MakeNoise()
        {
            base.MakeNoise();
        }
    }
}
