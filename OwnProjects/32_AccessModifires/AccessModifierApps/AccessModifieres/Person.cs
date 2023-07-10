using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccessModifieres
{
    public class Person
    {
        public string name;
        private int age;

        public int GetAge()
        {
            return this.age;
        }

        public void SetAge(int age)
        {
            this.age = age;
        }
    }
}
