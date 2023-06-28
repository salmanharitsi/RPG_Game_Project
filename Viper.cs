using System;

namespace UTS_Dasar_pemrograman
{
    class Viper : Enemy
    {
        Random rnd = new Random();
        public Viper(){
            Blood = 150;
            Attackpower = rnd.Next(10,16);
            Name = "VIPER";
            Console.WriteLine("");
            Console.WriteLine("UNSTOPPABLE!! you beat the VENOM");
            Console.WriteLine("you get +200 blood");
            Console.WriteLine("");
            Console.WriteLine("the second enemy is " +Name);
        }

        public override void Attack(Player player)
        {
            base.Attack(player);
            Console.WriteLine("FLAME BURST!!");
        }
    }
}