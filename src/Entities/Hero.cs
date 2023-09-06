using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RPG_Dotnet.src.Entities
{
    public class Hero
    {
        public Hero(string Name, int Level, string HeroType)
        {
            this.Name = Name;
            this.Level = Level;
            this.HeroType = HeroType;

        }

        public string Name;
        public int Level;
        public string HeroType;

        public override string ToString()
        {
            return this.Name + " é level " + this.Level + " da classe " + this.HeroType;
        }

        public virtual string Attack(){
            return this.Name + " atacou com a espada!";
        }

    }
}