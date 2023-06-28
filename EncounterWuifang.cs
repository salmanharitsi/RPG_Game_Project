using System;

namespace UTS_Dasar_pemrograman
{
    class EncounterWuifang
    {
        public EncounterWuifang(Wuifang wuifang, Enemy enemy, TreasureBox treasureBox){
            Console.WriteLine("");
            Console.WriteLine(wuifang.Name+" is encountering " +enemy.Name);
            Console.WriteLine(enemy.Name+ " is attacking you");
            Console.WriteLine("choose your action");
            Console.WriteLine("1. Single Attack");
            Console.WriteLine("2. Special Attack");
            Console.WriteLine("3. Defend");
            Console.WriteLine("4. Run Away");
        
            while(!wuifang.IsDead && !enemy.IsDead && !wuifang.IsRunningAway){
                Console.WriteLine("chose your action : ");
                string playerAction = Console.ReadLine();
                Random rnd = new Random();
                switch(playerAction){
                    case "1" :
                    if (rnd.Next(1,6)==2){
                           treasureBox.OpenBoxW(wuifang);
                        }
                    Console.WriteLine("you are doing single attack");    
                    if (!enemy.IsDead){
                        if (rnd.Next(1,16)==6){
                            enemy.BossAttack(wuifang);
                        }else{
                             wuifang.GetHit(enemy.Attackpower);
                        }
                    }
                    enemy.GetHit(wuifang.Attackpower);
                    wuifang.Experience += 0.2f;
                    Console.WriteLine(wuifang.Name+ " Blood " +wuifang.Blood+ " | "  +enemy.Name+ " Blood " +enemy.Blood);
                    Console.WriteLine("your combo point "+wuifang.ComboPoint);
                    Console.WriteLine("your Exp " +wuifang.Experience);
                    break;

                    case "2" :
                    wuifang.Attack(enemy);
                    if (!enemy.IsDead){
                        if(rnd.Next(1,4)==2){
                            enemy.Attack(wuifang);
                        }else if (rnd.Next(1,16)==6){
                            enemy.BossAttack(wuifang);
                        }else{
                            wuifang.GetHit(enemy.Attackpower);
                        } 
                    }if (rnd.Next(1,6)==2){
                           treasureBox.OpenBoxW(wuifang);
                        }
                    wuifang.Experience += 0.5f;
                    Console.WriteLine(wuifang.Name+ " Blood " +wuifang.Blood+ " | "  +enemy.Name+ " Blood " +enemy.Blood);
                    Console.WriteLine("your combo point "+wuifang.ComboPoint);
                    Console.WriteLine("your Exp " +wuifang.Experience);
                    break;

                    case "3" :
                    wuifang.Defend();
                    if (!enemy.IsDead){
                        if (rnd.Next(1,16)==6){
                            enemy.BossAttack(wuifang);
                        }else{
                            wuifang.GetHit(enemy.Attackpower);
                        }
                    }if (rnd.Next(1,6)==2){
                           treasureBox.OpenBoxW(wuifang);
                        }
                    wuifang.Experience += 0.1f;
                    Console.WriteLine(wuifang.Name+ " Blood " +wuifang.Blood+ " | "  +enemy.Name+ " Blood " +enemy.Blood);
                    Console.WriteLine("your combo point "+wuifang.ComboPoint);
                    Console.WriteLine("your Exp " +wuifang.Experience);
                    break;

                    case "4" :
                    wuifang.RunAway();
                    break;
                }
            }
            if (enemy.IsDead){
                Console.WriteLine("your blood "+wuifang.Blood);
                Console.WriteLine("");
            }else if (wuifang.IsDead){
                wuifang.IsDead = true;
                Environment.Exit(0);
            }
        }
    }
}