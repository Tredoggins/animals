using System;
using System.Collections.Generic;
using System.Text;

namespace animals
{
    class Cat:Pet,Talkable
    {
        private int MousesKilled { get; set; }
        public Cat(int mousesKilled,String name):base(name)
        {
            this.MousesKilled = mousesKilled;
        }
        public void AddMouse() { this.MousesKilled++; }

        public string Talk()
        {
            return "Meow";
        }

        public string GetName()
        {
            return this.Name;
        }
        public string ToString() { return "Cat: " + "name=" + this.Name + " Mouses Killed=" + this.MousesKilled; }
    }
}
