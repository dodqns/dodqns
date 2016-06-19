namespace DungeonProject
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class Item
    {
        string name;
        string description;

        public Item(string Name, string Description)
        {
            name = Name;
            description = Description;
        }

        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
            }
        }

        public string Description
        {
            get
            {
                return description;
            }
            set
            {
                description = value;
            }
        }
    }

    public class Gear : Item
    {
        int cost;
        int weight;

        public Gear(string Name, string Description, int Cost, int Weight) : base(Name, Description)
        {
            this.weight = Weight;
            this.cost = Cost;
        }

        public int Weight
        {
            get
            {
                return weight;
            }
            set
            {
                weight = value;
            }
        }

        public int Cost
        {
            get
            {
                return cost;
            }
            set
            {
                cost = value;
            }
        }
    }

    public class Consumable : Item
    {
        int hP;

        public Consumable(string Name, string Description, int HP) : base(Name, Description)
        {
            this.hP = HP;
        }

        public int HP
        {
            get
            {
                return hP;
            }
            set
            {
                hP = value;
            }
        }
    }

    public class Trophy : Item
    {
        public Trophy(string Name, string Description) : base(Name, Description)
        { }
    }

    public class Weapon : Gear
    {
        int dMG;

        public Weapon(string Name, string Description, int Cost, int Weight, int DMG) : base(Name, Description, Cost, Weight)
        {
            this.dMG = DMG;
        }

        public int DMG
        {
            get
            {
                return dMG;
            }
            set
            {
                dMG = value;
            }
        }
    }

    public class Armor : Gear
    {
        int hP;

        public Armor(string Name, string Description, int Cost, int Weight, int HP) : base(Name, Description, Cost, Weight)
        {
            this.hP = HP;
        }

        public int HP
        {
            get
            {
                return hP;
            }
            set
            {
                hP = value;
            }
        }
    }
}