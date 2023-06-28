using System;

namespace UTS_Dasar_pemrograman
{
    class Goblin1 : Enemy
    {
        Random rnd = new Random();
        public Goblin1(){
            Blood = 25;
            Attackpower = rnd.Next(1,4);
            Name = "Goblin1";
        }

        public override void Attack(Player player)
        {
            player.GetHit(Attackpower);
        }
    }

     class Goblin2 : Enemy
    {
        Random rnd = new Random();
        public Goblin2(){
            Blood = 30;
            Attackpower = rnd.Next(3,5);
            Name = "Goblin2";
        }

        public override void Attack(Player player)
        {
            player.GetHit(Attackpower);
        }
    }

    class Goblin3 : Enemy
    {
        Random rnd = new Random();
        public Goblin3(){
            Blood = 35;
            Attackpower = rnd.Next(5,8);
            Name = "Goblin3";
        }

        public override void Attack(Player player)
        {
            player.GetHit(Attackpower);
        }
    }

     class Goblin4 : Enemy
    {
        Random rnd = new Random();
        public Goblin4(){
            Blood = 40;
            Attackpower = rnd.Next(7,10);
            Name = "Goblin4";
        }

        public override void Attack(Player player)
        {
            player.GetHit(Attackpower);
        }
    }
}