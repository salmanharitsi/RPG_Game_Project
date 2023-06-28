using System;

namespace UTS_Dasar_pemrograman
{
    class Novice : Player
    {
        public int Energy { get; set; }
        public Novice(){
            Blood = 200;
            Attackpower = 5;
            Experience = 0f;
            Energy = 0;
        }

        public override void Attack(Enemy enemy)
        {
            if (Energy >= 2){
                enemy.GetHit(Attackpower * 3);
                Console.WriteLine("SWORD ATTACK!!");
                Energy = Energy - 2;
            }else{
                Console.WriteLine("energy : "+Energy);
                Console.WriteLine("you dont have enough energy");
                Console.WriteLine("lets defend to restore energy");

            }
            
        }

        public override void Defend()
        {
            Console.WriteLine("DEFEND!!!");
            Console.WriteLine("you get 1 energy");
            Energy = Energy+ 1;
        }
    }
}