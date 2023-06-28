using System;

namespace UTS_Dasar_pemrograman
{
    class EncounterZipzoit
    {
        public EncounterZipzoit(Zipzoit zipzoit, Enemy enemy, TreasureBox treasureBox){
            Console.WriteLine("");
            Console.WriteLine(zipzoit.Name+" is encountering " +enemy.Name);
            Console.WriteLine(enemy.Name+ " is attacking you");
            Console.WriteLine("choose your action");
            Console.WriteLine("1. Single Attack");
            Console.WriteLine("2. Special Attack");
            Console.WriteLine("3. Defend");
            Console.WriteLine("4. Run Away");
           
            while(!zipzoit.IsDead && !enemy.IsDead && !zipzoit.IsRunningAway){
                Console.WriteLine("chose your action : ");
                string playerAction = Console.ReadLine();
                Random rnd = new Random();
                switch(playerAction){
                    case "1" :
                    if (rnd.Next(1,6)==2){
                           treasureBox.OpenBoxZ(zipzoit);
                        }
                    Console.WriteLine("you are doing single attack");    
                    if (!enemy.IsDead){
                         if (rnd.Next(1,16)==6){
                        enemy.BossAttack(zipzoit);
                        }else{
                             zipzoit.GetHit(enemy.Attackpower);
                        }
                    }
                    enemy.GetHit(zipzoit.Attackpower);
                    zipzoit.Experience += 0.2f;
                    Console.WriteLine(zipzoit.Name+ " Blood " +zipzoit.Blood+ " | "  +enemy.Name+ " Blood " +enemy.Blood);
                    Console.WriteLine("your manna "+zipzoit.Manna);
                    Console.WriteLine("your Exp " +zipzoit.Experience);
                    break;

                    case "2" :
                    zipzoit.Attack(enemy);
                    if (!enemy.IsDead){
                        if(rnd.Next(1,5)==2){
                            enemy.Attack(zipzoit);
                        }else if (rnd.Next(1,16)==6){
                            enemy.BossAttack(zipzoit);
                        }else{
                            zipzoit.GetHit(enemy.Attackpower);             
                        } 
                    }if (rnd.Next(1,6)==2){
                           treasureBox.OpenBoxZ(zipzoit);
                        }
                    zipzoit.Experience += 0.5f;
                    Console.WriteLine(zipzoit.Name+ " Blood " +zipzoit.Blood+ " | "  +enemy.Name+ " Blood " +enemy.Blood);
                    Console.WriteLine("your manna "+zipzoit.Manna);
                    Console.WriteLine("your Exp " +zipzoit.Experience);
                    break;

                    case "3" :
                    zipzoit.Defend();
                    if (!enemy.IsDead){
                        if (rnd.Next(1,16)==6){
                            enemy.BossAttack(zipzoit);
                        }else{
                            zipzoit.GetHit(enemy.Attackpower);
                        }
                    }if (rnd.Next(1,6)==2){
                           treasureBox.OpenBoxZ(zipzoit);
                        }
                    zipzoit.Experience += 0.1f;
                    Console.WriteLine(zipzoit.Name+ " Blood " +zipzoit.Blood+ " | "  +enemy.Name+ " Blood " +enemy.Blood);
                    Console.WriteLine("your manna "+zipzoit.Manna);
                    Console.WriteLine("your Exp " +zipzoit.Experience);
                    break;

                    case "4" :
                    zipzoit.RunAway();
                    break;
                }
            }if (enemy.IsDead){
                Console.WriteLine("your blood "+zipzoit.Blood);
                Console.WriteLine("");
            }else if (zipzoit.IsDead){
                zipzoit.IsDead = true;
                Environment.Exit(0);
            }
        }
    }
}