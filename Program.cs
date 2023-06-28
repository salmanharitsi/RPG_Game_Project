using System;

namespace UTS_Dasar_pemrograman
{
    class Program
    {
        static void Main(string[] args)
        {
             Console.WriteLine("");
             Console.WriteLine("                             Welcome to the                            ");
             Console.WriteLine("   _________   ______   ___   ___   ________   ___   ___   _________   ");
             Console.WriteLine("  /|  ___  |  /|  __|  /| |  /| |  /|  __  |  /| |  /| |  /|__   __|   ");
             Console.WriteLine(" | | |__/| | | | |_   | | | | | | | | |__| | | | |_|_| | |/__/| |_/    ");
             Console.WriteLine(" | | | | | | | |  _|  | | | | | | | |  _  _| | |__   __|    | | |      ");
             Console.WriteLine(" | | | | | | | | |__  | | |_|_| | | | | | |_ |/__/| |_/     | | |      ");
             Console.WriteLine(" | | | | | | | |____| | |_______| | |_| |___|   | |_|       | |_|      ");
             Console.WriteLine(" |/_/  |/_/  |/____/  |/_______/  |/_/|/___/    |/_/        |/_/       ");
             Console.WriteLine("");
             Console.WriteLine("                           What is your name?                          ");
             Novice novice = new Novice();
             novice.Name = Console.ReadLine();
             Console.WriteLine("You will fight with the inhabitants of NEURYT");
             Console.WriteLine("Hi " +novice.Name+"... ready to entry the world?? [y/n]");
             string bReady = Console.ReadLine();
             if (bReady == "y"){
                 Console.WriteLine("");
                 Console.WriteLine("your adventure is starting");
                 Console.WriteLine("beat all the goblin, and go to the higher level");
                 Console.WriteLine("you must get 7 Exp or bigger than that to go to a higher level");
                 Console.WriteLine("");
                 Goblin1 goblin1 = new Goblin1();
                 EncounterNovice encounterNovice1 = new EncounterNovice(novice, goblin1);
                 Console.WriteLine("");
                 Console.WriteLine("LEVEL UP");
                 Console.WriteLine("beat them all, champ!! ");
                 Console.WriteLine("");
                 Goblin2 goblin2 = new Goblin2();
                 EncounterNovice encounterNovice2 = new EncounterNovice(novice, goblin2);
                 Console.WriteLine("");
                 Console.WriteLine("LEVEL UP");
                 Console.WriteLine("you are the legend");
                 Console.WriteLine("LETS GO!!");
                 Console.WriteLine("");
                 Goblin3 goblin3 = new Goblin3();
                 EncounterNovice encounterNovice3 = new EncounterNovice(novice, goblin3);
                 Console.WriteLine("");
                 Console.WriteLine("LEVEL UP");
                 Console.WriteLine("burn your spirit!!");
                 Console.WriteLine("");
                 Goblin4 goblin4 = new Goblin4();
                 EncounterNovice encounterNovice4 = new EncounterNovice(novice, goblin4);
                 if (novice.Experience >= 7){
                 while(!novice.IsDead && !novice.IsRunningAway && goblin1.IsDead && goblin2.IsDead && goblin3.IsDead && goblin4.IsDead){
                 Console.WriteLine("you get " +novice.Experience+ " Exp");
                 Console.WriteLine("!!LEVEL UP!!");
                 Console.WriteLine("you defeated all the goblins");
                 Console.WriteLine("you in the higher level");
                 Console.WriteLine("choose a job to fight the Neuryt's top brass");
                 Console.WriteLine("");
                 Console.WriteLine("Zipzoit | Special Skill : Lightning Bolt | Blood : 300");
                 Console.WriteLine("Wuifang | Special Skill : Combo Attack | Blood : 300");
                 Console.WriteLine("Gonrock | Special Skill : Stun Attack | Blood : 500");
                 Console.WriteLine("Skyepix | Special Skill : Healing | Blood : 400");
                 Console.WriteLine("");
                 Console.WriteLine("[zipzoit / wuifang / gonrock / skyepix]");
                 Console.WriteLine("");
                 Console.Write("plise type the job of your choice : ");
                 
                 string bNext = Console.ReadLine();
                 if (bNext == "zipzoit"){
                      Console.WriteLine("");
                      Console.WriteLine("hai Zipzoit");
                      Console.WriteLine("it's an honor you continue the game");
                      Console.WriteLine("you will fight 3 enemies and fight the boss as cover");
                      Console.WriteLine("you have a chance to get treasure box at random time");
                      Zipzoit zipzoit = new Zipzoit();
                      TreasureBox treasureBox = new TreasureBox();
                      Venom enemy1 = new Venom();
                      EncounterZipzoit encounterZipzoit1 = new EncounterZipzoit(zipzoit, enemy1, treasureBox);
                      zipzoit.Blood += 200;
                      Viper enemy2 = new Viper();
                      EncounterZipzoit encounterZipzoit2 = new EncounterZipzoit(zipzoit, enemy2, treasureBox);
                      zipzoit.Blood += 400;
                      Vector enemy3 = new Vector();
                      EncounterZipzoit encounterZipzoit3 = new EncounterZipzoit(zipzoit, enemy3, treasureBox);
                      zipzoit.Blood += 600;
                      Veronica boss = new Veronica();
                      EncounterZipzoit encounterZipzoit4 = new EncounterZipzoit(zipzoit, boss, treasureBox);
                      Console.WriteLine("");
                      Console.WriteLine("       YOU BEAT THE BOSS!! ");
                      Console.WriteLine("     take the NEURYT crown ");
                      Console.WriteLine("               /|          ");
                      Console.WriteLine("           /| | |  /|      ");
                      Console.WriteLine("       /|_| |_| |_| |_/|   ");
                      Console.WriteLine("      < ^O ^ O ^ O ^ O  >  ");
                      Console.WriteLine("      <_________________>  ");
                      Console.WriteLine("");
                      Console.WriteLine("you are the boss of NEURYT now!!");
                      Console.WriteLine("       CONGRATULATION!!    ");
                      Console.WriteLine("");   
                      Console.Read();
                      Environment.Exit(0); 
                 }
                 if (bNext == "wuifang"){
                      Console.WriteLine("");
                      Console.WriteLine("hai Wuifang");
                      Console.WriteLine("it's an honor you continue the game");
                      Console.WriteLine("you will fight 3 enemies and fight the boss as cover");
                      Console.WriteLine("you have a chance to get treasure box at random time");
                      Wuifang wuifang = new Wuifang();
                      TreasureBox treasureBox = new TreasureBox();
                      Venom enemy1 = new Venom();
                      EncounterWuifang encounterWuifang1 = new EncounterWuifang(wuifang, enemy1, treasureBox);
                      wuifang.Blood += 200;
                      Viper enemy2 = new Viper();
                      EncounterWuifang encounterWuifang2 = new EncounterWuifang(wuifang, enemy2, treasureBox);
                      wuifang.Blood += 400;
                      Vector enemy3 = new Vector();
                      EncounterWuifang encounterWuifang3 = new EncounterWuifang(wuifang, enemy3, treasureBox);
                      wuifang.Blood += 600;
                      Veronica boss = new Veronica();
                      EncounterWuifang encounterWuifang4 = new EncounterWuifang(wuifang, boss, treasureBox);
                      Console.WriteLine("");
                      Console.WriteLine("       YOU BEAT THE BOSS!! ");
                      Console.WriteLine("     take the NEURYT crown ");
                      Console.WriteLine("               /|          ");
                      Console.WriteLine("           /| | |  /|      ");
                      Console.WriteLine("       /|_| |_| |_| |_/|   ");
                      Console.WriteLine("      < ^O ^ O ^ O ^ O  >  ");
                      Console.WriteLine("      <_________________>  ");
                      Console.WriteLine("");
                      Console.WriteLine("you are the boss of NEURYT now!!");
                      Console.WriteLine("       CONGRATULATION!!    ");
                      Console.WriteLine("");  
                      Console.Read(); 
                      Environment.Exit(0); 
                     
                 }
                 if (bNext == "gonrock"){
                      Console.WriteLine("");
                      Console.WriteLine("hai Gonrock");
                      Console.WriteLine("it's an honor you continue the game");
                      Console.WriteLine("you will fight 3 enemies and fight the boss as cover");
                      Console.WriteLine("you have a chance to get treasure box at random time");
                      Gonrock gonrock = new Gonrock();
                      TreasureBox treasureBox = new TreasureBox();
                      Venom enemy1 = new Venom();
                      EncounterGonrock encounterGonrock1 = new EncounterGonrock(gonrock, enemy1, treasureBox);
                      gonrock.Blood += 200;
                      Viper enemy2 = new Viper();
                      EncounterGonrock encounterGonrock2 = new EncounterGonrock(gonrock, enemy2, treasureBox);
                      gonrock.Blood += 250;
                      Vector enemy3 = new Vector();
                      EncounterGonrock encounterGonrock3 = new EncounterGonrock(gonrock, enemy3, treasureBox);
                      gonrock.Blood += 350;
                      Veronica boss = new Veronica();
                      EncounterGonrock encounterGonrock4 = new EncounterGonrock(gonrock, boss, treasureBox);
                      Console.WriteLine("");
                      Console.WriteLine("       YOU BEAT THE BOSS!! ");
                      Console.WriteLine("     take the NEURYT crown ");
                      Console.WriteLine("               /|          ");
                      Console.WriteLine("           /| | |  /|      ");
                      Console.WriteLine("       /|_| |_| |_| |_/|   ");
                      Console.WriteLine("      < ^O ^ O ^ O ^ O  >  ");
                      Console.WriteLine("      <_________________>  ");
                      Console.WriteLine("");
                      Console.WriteLine("you are the boss of NEURYT now!!");
                      Console.WriteLine("       CONGRATULATION!!    ");
                      Console.WriteLine("");
                      Console.Read();   
                      Environment.Exit(0); 
                 }
                 if (bNext == "skyepix"){
                      Console.WriteLine("");
                      Console.WriteLine("hai Skyepix");
                      Console.WriteLine("it's an honor you continue the game");
                      Console.WriteLine("you will fight 3 enemies and fight the boss as cover");
                      Console.WriteLine("you have a chance to get treasure box at random time");
                      Skyepix skyepix = new Skyepix();
                      TreasureBox treasureBox = new TreasureBox();
                      Venom enemy1 = new Venom();
                      EncounterSkyepix encounterSkyepix1 = new EncounterSkyepix(skyepix, enemy1, treasureBox);
                      skyepix.Blood += 200;
                      Viper enemy2 = new Viper();
                      EncounterSkyepix encounterSkyepix2 = new EncounterSkyepix(skyepix, enemy2, treasureBox);
                      skyepix.Blood += 400;
                      Vector enemy3 = new Vector();
                      EncounterSkyepix encounterSkyepix3 = new EncounterSkyepix(skyepix, enemy3, treasureBox);
                      skyepix.Blood += 600;
                      Veronica boss = new Veronica();
                      EncounterSkyepix encounterSkyepix4 = new EncounterSkyepix(skyepix, boss, treasureBox);
                      Console.WriteLine("");
                      Console.WriteLine("       YOU BEAT THE BOSS!! ");
                      Console.WriteLine("     take the NEURYT crown ");
                      Console.WriteLine("               /|          ");
                      Console.WriteLine("           /| | |  /|      ");
                      Console.WriteLine("       /|_| |_| |_| |_/|   ");
                      Console.WriteLine("      < ^O ^ O ^ O ^ O  >  ");
                      Console.WriteLine("      <_________________>  ");
                      Console.WriteLine("");
                      Console.WriteLine("you are the boss of NEURYT now!!");
                      Console.WriteLine("       CONGRATULATION!!    ");
                      Console.WriteLine("");
                      Console.Read();   
                      Environment.Exit(0); 
                    }
               }
          }else{
               Console.WriteLine("you dont have enough Exp");
               Console.WriteLine("your Exp "+novice.Experience);
               Console.WriteLine("PLAY AGAIN!!");
               Console.Read();
          }
                
             }else{
                 Console.WriteLine("Thanks for trying this game <3");
                 Console.WriteLine("Good Byee..");
                 Console.Read();
               }
          }
     }
}
