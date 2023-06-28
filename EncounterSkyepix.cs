using System;

namespace UTS_Dasar_pemrograman
{
    class EncounterSkyepix
    {
        public EncounterSkyepix(Skyepix skyepix, Enemy enemy, TreasureBox treasureBox){
            Console.WriteLine("");
            Console.WriteLine(skyepix.Name+" is encountering " +enemy.Name);
            Console.WriteLine(enemy.Name+ " is attacking you");
            Console.WriteLine("choose your action");
            Console.WriteLine("1. Single Attack");
            Console.WriteLine("2. Special Attack");
            Console.WriteLine("3. Defend");
            Console.WriteLine("4. Run Away");
        
            while(!skyepix.IsDead && !enemy.IsDead && !skyepix.IsRunningAway){
                Console.WriteLine("chose your action : ");
                string playerAction = Console.ReadLine();
                Random rnd = new Random();
                switch(playerAction){
                    case "1" :
                    if (rnd.Next(1,6)==2){
                           treasureBox.OpenBoxS(skyepix);
                        }
                    Console.WriteLine("you are doing single attack");    
                    if (!enemy.IsDead){
                        if (rnd.Next(1,16)==6){
                            enemy.BossAttack(skyepix);
                        }else{
                             skyepix.GetHit(enemy.Attackpower);
                        }
                    }
                    enemy.GetHit(skyepix.Attackpower);
                    skyepix.Experience += 0.2f;
                    Console.WriteLine(skyepix.Name+ " Blood " +skyepix.Blood+ " | "  +enemy.Name+ " Blood " +enemy.Blood);
                    Console.WriteLine("your heal point "+skyepix.HealPoint);
                    Console.WriteLine("your Exp " +skyepix.Experience);
                    break;

                    case "2" :
                    skyepix.Attack(enemy);
                    if (!enemy.IsDead){
                        if(rnd.Next(1,4)==2){
                            enemy.Attack(skyepix);
                        }else if (rnd.Next(1,16)==6){
                            enemy.BossAttack(skyepix);
                        }else{
                            skyepix.GetHit(enemy.Attackpower);
                        } 
                    }if (rnd.Next(1,6)==2){
                           treasureBox.OpenBoxS(skyepix);
                        }
                    skyepix.Experience += 0.5f;
                    Console.WriteLine(skyepix.Name+ " Blood " +skyepix.Blood+ " | "  +enemy.Name+ " Blood " +enemy.Blood);
                    Console.WriteLine("your heal point "+skyepix.HealPoint);
                    Console.WriteLine("your Exp " +skyepix.Experience);
                    break;

                    case "3" :
                    skyepix.Defend();
                    if (!enemy.IsDead){
                        if (rnd.Next(1,16)==6){
                            enemy.BossAttack(skyepix);
                        }else{
                            skyepix.GetHit(enemy.Attackpower);
                        }
                    }if (rnd.Next(1,6)==2){
                           treasureBox.OpenBoxS(skyepix);
                        }
                    skyepix.Experience += 0.1f;
                    Console.WriteLine(skyepix.Name+ " Blood " +skyepix.Blood+ " | "  +enemy.Name+ " Blood " +enemy.Blood);
                    Console.WriteLine("your heal point "+skyepix.HealPoint);
                    Console.WriteLine("your Exp " +skyepix.Experience);
                    break;

                    case "4" :
                    skyepix.RunAway();
                    break;
                }
            }
            if (enemy.IsDead){
                Console.WriteLine("your blood "+skyepix.Blood);
                Console.WriteLine("");
            }else if (skyepix.IsDead){
                skyepix.IsDead = true;
                Environment.Exit(0);
            }
        }
    }
}