using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Lesson11Homework
{
    public class Dog : Pet
    {
        private string livingPlace;
        public Dog(string name, int age, string family,string livingPlace):base(name,age,family)
        {
            this.livingPlace = livingPlace;
        }

        public override void MakeNoise()
        {
            Console.WriteLine("Haf haf");
        }
    }
}
