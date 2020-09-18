using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Lesson11Homework
{
    public class Animal
    {
        private string name;
        private int age;
        public Animal(string name, int age )
        {
            this.name = name;
            this.age = age;
        }

        public virtual void MakeNoise()
        {
            
        }
    }
}
