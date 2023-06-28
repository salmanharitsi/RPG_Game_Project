using System;

namespace UTS_Dasar_pemrograman
{
    class Veronica : Enemy
    {
        public int AutoDead { get; set; }
        Random rnd = new Random();
        public Veronica(){
            Blood = 1000;
            Attackpower = rnd.Next(25,51);
            Name = "VERONICA";
            Console.WriteLine("");
            Console.WriteLine("AMAZING!! you are so great beat the VECTOR");
            Console.WriteLine("you get +600 blood for attack the boss");
            Console.WriteLine("");
            Console.WriteLine("the last enemy is " +Name);
            Console.WriteLine(Name+ " is a boss of NEURYT");
            Console.WriteLine("ready to be a loser!!");
        }

        public override void Attack(Player player)
        {
            Console.WriteLine("DEATH BLOW!!");
            player.GetHit((int)0.33 * player.Blood);
        }

        public override void BossAttack(Player player)
        {
            Console.WriteLine("");
            Console.WriteLine("NO WAY FOR RUN!!");
            player.GetHit(player.Blood);
        }
    }
}