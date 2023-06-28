using System;

namespace UTS_Dasar_pemrograman
{
    class Venom : Enemy
    {
        Random rnd = new Random();
        public Venom(){
            Blood = 100;
            Attackpower = rnd.Next(5,11);
            Name = "VENOM";
            Console.WriteLine("");
            Console.WriteLine("the first enemy is " +Name);
        }

        public override void Attack(Player player)
        {
            base.Attack(player);
            Console.WriteLine("POISON!!");
        }
    }
}