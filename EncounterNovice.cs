using System;

namespace UTS_Dasar_pemrograman
{
    class EncounterNovice
    {
        public EncounterNovice(Novice novice, Enemy enemy){
            Console.WriteLine("");
            Console.WriteLine(novice.Name+ " is encountering " +enemy.Name);
            Console.WriteLine(enemy.Name+ " is attacking you");
            Console.WriteLine("choose your action");
            Console.WriteLine("1. Single Attack");
            Console.WriteLine("2. Special Attack");
            Console.WriteLine("3. Defend");
            Console.WriteLine("4. Run Away");
        
            while(!novice.IsDead && !enemy.IsDead && !novice.IsRunningAway){
                Console.WriteLine("chose your action : ");
                string playerAction = Console.ReadLine();
                Random rnd = new Random();
                switch(playerAction){
                    case "1" :
                    Console.WriteLine("you are doing single attack");
                    enemy.GetHit(novice.Attackpower);
                    novice.GetHit(enemy.Attackpower);
                    novice.Experience += 0.2f;
                    Console.WriteLine(novice.Name+ " Blood " +novice.Blood+ " | "  +enemy.Name+ " Blood " +enemy.Blood);
                    Console.WriteLine("your Exp " +novice.Experience);
                    Console.WriteLine("your energy " +novice.Energy);
                    break;

                    case "2" :
                    novice.Attack(enemy);
                    if (!enemy.IsDead){
                        if (rnd.Next(1,4)==2){
                            enemy.Attack(novice);
                        }else{
                            novice.GetHit(enemy.Attackpower);
                        }
                    }
                    novice.Experience += 0.5f;
                    Console.WriteLine(novice.Name+ " Blood " +novice.Blood+ " | "  +enemy.Name+ " Blood " +enemy.Blood);
                    Console.WriteLine("your Exp " +novice.Experience);
                    Console.WriteLine("your energy " +novice.Energy);
                    break;

                    case "3" :
                    novice.Defend();
                    novice.Experience += 0.1f;
                    novice.GetHit(enemy.Attackpower);
                    Console.WriteLine(novice.Name+ " Blood " +novice.Blood+ " | "  +enemy.Name+ " Blood " +enemy.Blood);
                    Console.WriteLine("your Exp " +novice.Experience);
                    Console.WriteLine("your energy " +novice.Energy);
                    break;

                    case "4" :
                    novice.RunAway();
                    break;
                }
            }
            if (enemy.IsDead){
                Console.WriteLine("your blood "+novice.Blood);
                Console.WriteLine("");
            }else if (novice.IsDead){
                novice.IsDead = true;
                Environment.Exit(0);
            }
        }
    }
}