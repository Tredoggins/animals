using System;
using System.Collections.Generic;
using System.Text;

namespace animals
{
    class Teacher:Person,Talkable
    {
        private int Age { get; set; }
        public Teacher(int age,string name):base(name)
        {
            this.Age = age;
        }
        public string GetName()
        {
            return this.Name;
        }

        public string Talk()
        {
            return "Don't forget to do the assigned reading!";
        }
    }
}
