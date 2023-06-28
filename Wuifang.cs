using System;

namespace UTS_Dasar_pemrograman
{
    class Wuifang : Player
    {
        public int ComboPoint { get; set; }
        Random rnd = new Random();

        public Wuifang(){
            Blood = 300;
            Attackpower = 5;
            ComboPoint = 0;
            Name = "Wuifang";
        }

        public override void Attack(Enemy enemy)
        {
            if (ComboPoint >=3){
                Console.WriteLine("COMBO ATTACK");
                for(int i=0; i<=ComboPoint; i++){
                    Console.WriteLine(" BAM BAM BAM!!");
                    enemy.GetHit(Attackpower + rnd.Next(20,26));
                }
                ComboPoint = ComboPoint - 3; 
            }else{
                Console.WriteLine("Combo Point : " +ComboPoint);
                Console.WriteLine("you dont have enough combo point");
                Console.WriteLine("lets defend to get combo point");
            }
        }

        public override void Defend()
        {
            Console.WriteLine("DEFEND!!");
            Console.WriteLine("you get 1 combo point");
            ComboPoint = ComboPoint + 1;
        }
    }
}