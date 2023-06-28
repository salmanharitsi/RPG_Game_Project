using System;

namespace UTS_Dasar_pemrograman
{
    class Vector : Enemy
    {
        Random rnd = new Random();
        public Vector(){
            Blood = 175;
            Attackpower = rnd.Next(15,21);
            Name = "VECTOR";
            Console.WriteLine("");
            Console.WriteLine("AMAZING!! you are so great beat the VIPER");
            Console.WriteLine("you get +400 blood");
            Console.WriteLine("");
            Console.WriteLine("the third enemy is " +Name);
            Console.WriteLine("if you win this match, you will fight the boss of neuryt");
        }

        public override void Attack(Player player)
        {
            base.Attack(player);
            Console.WriteLine("MEGA LIGHTNING!!");
        }
    }
}