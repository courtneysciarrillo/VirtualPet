using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VirtualPet
{
    class VirtualPet
    {
        // Declare Fields
        private string hunger;
        private string thirst;
        private string sleep;

        // Declare Properties
        public string Hunger
        {
            get { return this.hunger; }
            set { this.hunger = value; }
        }

        public string Thirst
        {
            get { return this.thirst; }
            set { this.thirst = value; }
        }

        public string Sleep
        {
            get { return this.sleep; }
            set { this.sleep = value; }
        }

        VirtualPet()
        {
            // Default Constructor
        }

        VirtualPet(int hunger, int thirst, int sleep)
        {
            // Loaded Constructor
        }

        public void Eat()
        {

        }

        public void Drink()
        {

        }

        public void TakeNap()
        {

        }

        public void Tick()
        {

        }



    }
}
