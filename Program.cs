using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using RPG_Dotnet.src.Entities;

namespace RPG_Dotnet
{
    public class Program
    {

        static void Main(String[] args)
        {
            Knight hero = new Knight("Arus", 23, "Paladino");
            Wizard wizard = new Wizard("Jessica", 21, "White Wizard");


            Console.WriteLine(hero.Attack());
            Console.WriteLine(wizard.Attack(7));


        }
    }
}