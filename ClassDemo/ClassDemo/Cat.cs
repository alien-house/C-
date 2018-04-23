using System;
namespace ClassDemo
{
    public class Cat : Animal
    {
        private string name;
        private string owner;

        public Cat()
        {
        }

        public Cat(string name, string owner)
        {
            this.name = name;
            this.owner = owner;
        }
        public string Name{
            get{ return this.name; }
            set{ this.name = value; }
        }
    }
}
