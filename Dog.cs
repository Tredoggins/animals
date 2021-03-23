using System;
using System.Collections.Generic;
using System.Text;

namespace animals
{
    class Dog:Pet,Talkable
    {
        private bool Friendly { get; set; }
        public Dog(bool friendly,string name):base(name)
        {
            this.Friendly = friendly;
        }
        public string GetName()
        {
            return this.Name;
        }

        public string Talk()
        {
            return "Bark";
        }
        public string ToString() { return "Dog: " + "name=" + this.Name + " friendly=" + this.Friendly; }
    }
}
