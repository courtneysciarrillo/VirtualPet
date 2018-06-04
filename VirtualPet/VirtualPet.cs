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

        private string name;
        private int hunger;
        private int thirst;
        private int sleep;
        private int potty;
        private int boredom;
        private int sickness;

        // Declare Properties

        public string Name
        {
            get { return this.name; }
            set { this.name = value; }
        }

        public int Hunger
        {
            get { return this.hunger; }
            set { this.hunger = value; }
        }

        public int Thirst
        {
            get { return this.thirst; }
            set { this.thirst = value; }
        }

        public int Sleep
        {
            get { return this.sleep; }
            set { this.sleep = value; }
        }

        public int Potty
        {
            get { return this.potty; }
            set { this.potty = value; }
        }

        public int Boredom
        {
            get { return this.boredom; }
            set { this.boredom = value; }
        }

        public int Sickness
        {
            get { return this.sickness; }
            set { this.sickness = value; }
        }

        public VirtualPet()
        {
            // Default Constructor
        }

        public VirtualPet(string name, int hunger, int thirst, int sleep, int potty, int boredom, int sickness)
        {
            // Loaded Constructor
            this.Name = name;
            this.Hunger = hunger;
            this.Thirst = thirst;
            this.Sleep = sleep;
            this.Potty = potty;
            this.Boredom = boredom;
            this.Sickness = sickness;
        }

        // Declare Methods

        public void Eat()
        {
            Hunger -= 25;
            Thirst += 10;

            if (Hunger <= 0)
            {
                Hunger = 0;
            }
        }

        public void Drink()
        {
            Thirst -= 25;
            Potty += 15;

            if (Thirst <= 0)
            {
                Thirst = 0;
            }
        }

        public void TakeNap()
        {
            Sleep -= 25;
            Hunger += 10;

            if (Sleep <= 0)
            {
                Sleep = 0;
            }
        }

        public void GoPotty()
        {
            Potty -= 25;
            Boredom += 10;

            if (Potty <= 0)
            {
                Potty = 0;
            }
        }

        public void Play()
        {
            Boredom -= 25;
            Sleep += 15;

            if (Boredom <= 0)
            {
                Boredom = 0;
            }
        }

        public void SeeDoctor()
        {
            Sickness -= 25;

            if (Sickness <= 0)
            {
                Sickness = 0;
            }
        }

        public void Tick()
        {
            Random r = new Random();
            Hunger = Hunger + r.Next(0, 6);
            Thirst = Thirst + r.Next(0, 6);
            Sleep = Sleep + r.Next(0, 6);
            Potty = Potty + r.Next(0, 6);
            Boredom = Boredom + r.Next(0, 6);
            Sickness = Sickness + r.Next(0, 2);
        }

    } // end VirtualPet class
} // end VirtualPet namespace
