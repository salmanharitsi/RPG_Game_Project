using System;

namespace UTS_Dasar_pemrograman
{
    class Zipzoit : Player 
    {
        public int Manna { get; set; }
        Random rnd = new Random();

        public Zipzoit(){
            Blood = 300;
            Attackpower = 10;
            Manna = 0;
            Name = "Zipzoit";
        }

        public override void Attack(Enemy enemy)
        {
            if (Manna >= 30){
                Console.WriteLine("LIGHTNING BOLT");
                Console.WriteLine("ZZTTT!!!");
                enemy.GetHit(Attackpower + rnd.Next(50,101));
                Manna = Manna - 30;
                
            }else{
                Console.WriteLine("Manna : " +Manna);
                Console.WriteLine("you dont have enough manna");
                Console.WriteLine("lets defend to restore manna");
            }
        }

        public override void Defend()
        {
            Console.WriteLine("DEFEND!!!");
            Console.WriteLine("you get 15 manna");
            Manna = Manna + 15;
        }
    }
}