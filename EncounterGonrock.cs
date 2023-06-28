using System;

namespace UTS_Dasar_pemrograman
{
    class EncounterGonrock
    {
        public EncounterGonrock(Gonrock gonrock, Enemy enemy, TreasureBox treasureBox){
            Console.WriteLine(gonrock.Name+ " is encountering " +enemy.Name);
            Console.WriteLine(enemy.Name+ " is attacking you");
            Console.WriteLine("choose your action");
            Console.WriteLine("1. Single Attack");
            Console.WriteLine("2. Special Attack");
            Console.WriteLine("3. Defend");
            Console.WriteLine("4. Run Away");
            
            while(!gonrock.IsDead && !enemy.IsDead && !gonrock.IsRunningAway){
                Console.WriteLine("chose your action : ");
                string playerAction = Console.ReadLine();
                Random rnd = new Random();
                switch(playerAction){
                    case "1" :
                    if (rnd.Next(1,6)==2){
                           treasureBox.OpenBoxG(gonrock);
                        }
                    Console.WriteLine("you are doing single attack");
                    if (!enemy.IsStunned){
                        gonrock.GetHit(enemy.Attackpower);
                    }if (!enemy.IsDead){
                        if (rnd.Next(1,16)==6){
                            enemy.BossAttack(gonrock);
                        }
                    }  
                    enemy.GetHit(gonrock.Attackpower);
                    gonrock.Experience += 0.5f;
                    Console.WriteLine(gonrock.Name+ " Blood " +gonrock.Blood+ " | "  +enemy.Name+ " Blood " +enemy.Blood);
                    Console.WriteLine("your Exp " +gonrock.Experience);
                    Console.WriteLine("your stun point " +gonrock.StunPoint);
                    break;

                    case "2" :
                    gonrock.Attack(enemy);
                    if (!enemy.IsDead){
                        if (rnd.Next(1,16)==6){
                            enemy.BossAttack(gonrock);
                        }
                    }if (rnd.Next(1,6)==2){
                           treasureBox.OpenBoxG(gonrock);
                        }
                    gonrock.Experience += 1.0f;
                    Console.WriteLine(gonrock.Name+ " Blood " +gonrock.Blood+ " | "  +enemy.Name+ " Blood " +enemy.Blood);
                    Console.WriteLine("your Exp " +gonrock.Experience);
                    Console.WriteLine("your stun point " +gonrock.StunPoint);
                    break;

                    case "3" :
                    gonrock.Defend();
                    if (!enemy.IsStunned){
                        if (rnd.Next(1,4)==2){
                            enemy.Attack(gonrock);
                        }else{
                            gonrock.GetHit(enemy.Attackpower);
                        }
                    }if (!enemy.IsDead){
                        if (rnd.Next(1,16)==6){
                            enemy.BossAttack(gonrock);
                        }
                    }if (rnd.Next(1,6)==2){
                           treasureBox.OpenBoxG(gonrock);
                        }
                    gonrock.Experience += 0.5f;
                    Console.WriteLine(gonrock.Name+ " Blood " +gonrock.Blood+ " | "  +enemy.Name+ " Blood " +enemy.Blood);
                    Console.WriteLine("your Exp " +gonrock.Experience);
                    Console.WriteLine("your stun point " +gonrock.StunPoint);
                    break;

                    case "4" :
                    gonrock.RunAway();
                    break;
                }
                if (enemy.IsStunned){
                    Gonrock.StunDuration --;
                }
                if (Gonrock.StunDuration <= 0){
                enemy.IsStunned = false;   
            }
        }
            if (enemy.IsDead){
                Console.WriteLine("your blood "+gonrock.Blood);
                Console.WriteLine("");
            }else if (gonrock.IsDead){
                gonrock.IsDead = true;
                Environment.Exit(0);
            }
        }
    }
}