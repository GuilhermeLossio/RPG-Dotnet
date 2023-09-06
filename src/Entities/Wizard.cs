using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RPG_Dotnet.src.Entities
{
    public class Wizard : Hero
    {
        public Wizard(string Name, int Level, string HeroType) : base(Name, Level, HeroType)
        {
            this.Name = Name;
            this.Level = Level;
            this.HeroType = HeroType;
        }

        public override string Attack()
        {
            return this.Name + "atacou com uma magia.";
        }

        public string Attack(int Bonus)
        {
            if(Bonus > 6)
            {
                return this.Name + "teve um ataque muito poderoso de poder magico de " + Bonus.ToString() + " de dano extra.";
            }
            else
            {
                return this.Name + "teve um ataque comum de poder magico de " + Bonus.ToString() + " de dano extra.";
            }
        }



    }
}