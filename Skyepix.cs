using System;

namespace UTS_Dasar_pemrograman
{
    class Skyepix : Player
    {
        public int HealPoint { get; set; }

        public Skyepix(){
            Blood = 300;
            Attackpower = 15;
            HealPoint = 0;
            Name = "Skyepix";
        }

        public override void Attack(Enemy enemy)
        {
            if (HealPoint >= 4){
                Console.WriteLine("++HEALING++");
                Console.WriteLine("++SWINGG++");
                Blood = Blood + 70;
                HealPoint = HealPoint - 4;
                enemy.GetHit(5 *Attackpower);

            }else{
                Console.WriteLine("Heal point : " +HealPoint);
                Console.WriteLine("you dont have enough Heal point");
                Console.WriteLine("lets defend to get Heal point!!");
            }
        }

        public override void Defend()
        {
            Console.WriteLine("DEFEND!!");
            Console.WriteLine("you get 1 Heal point");
            HealPoint = HealPoint + 1;
        }
    }
}