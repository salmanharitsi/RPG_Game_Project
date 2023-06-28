using System;

namespace UTS_Dasar_pemrograman
{
    class TreasureBox
    {
        int code1 = 2;
        int code2 = 3;
        int code3 = 1;
        int code4 = 0;
        
        int summationResult = 0;
        public bool IsOpen { get; set; }
        public int getthebox { get; set; }
        
        public TreasureBox(){
            IsOpen = false;
            getthebox = 3;
        }

        public void OpenBoxZ(Zipzoit zipzoit){
        if (getthebox == 3){
            Console.WriteLine("");
            Console.WriteLine("STOP!!, you got a treasure box");
            Console.WriteLine("  _______________________  ");
            Console.WriteLine(" |           _           | ");
            Console.WriteLine(" |==========|_|==========| ");
            Console.WriteLine(" | o o o o o - o o o o o | ");
            Console.WriteLine(" |                       | ");
            Console.WriteLine(" |_______________________| ");
            Console.WriteLine("    try to open the box    ");
            
            summationResult = code1 + code2 + code3 + code4;
            Console.WriteLine("");
            Console.WriteLine("hint the answer");
            Console.WriteLine("for summation result is "+summationResult);
            Console.WriteLine("the code consists of 4 digits");
            Console.WriteLine("when was this project made?");
            Console.WriteLine("");

            Console.Write("input first code : ");
            string guess1 = Console.ReadLine();
            Console.Write("input second code : ");
            string guess2 = Console.ReadLine();
            Console.Write("input third code : ");
            string guess3 = Console.ReadLine();
            Console.Write("input fourth code : ");
            string guess4 = Console.ReadLine();
            Console.WriteLine("your guess : "+guess1+" "+guess2+" "+guess3+" "+guess4+" ??");

            int theguess1 = Convert.ToInt32(guess1);
            int theguess2 = Convert.ToInt32(guess2);
            int theguess3 = Convert.ToInt32(guess3);
            int theguess4 = Convert.ToInt32(guess4);


            if(code1 == theguess1 && code2 == theguess2 && code3 == theguess3 && code4 == theguess4){
                Console.WriteLine("");
                Console.WriteLine("your answer is correct");
                Console.WriteLine("you get potion, Manna and Exp");
                Console.WriteLine("       ________        ");
                Console.WriteLine("      |        |       ");
                Console.WriteLine("  ____|        |____   ");
                Console.WriteLine(" |   Blood = 300    |  ");
                Console.WriteLine(" |   Manna = 50     |  ");
                Console.WriteLine(" |___Exp   = 20 ____|  ");
                Console.WriteLine("      |        |       ");
                Console.WriteLine("      |________|       ");
                zipzoit.Blood += 300;
                zipzoit.Experience += 20f;
                zipzoit.Manna += 50;
                IsOpen = true;
                getthebox = getthebox - 3;

            }else if (getthebox <= 0){
                IsOpen = true;
                
            }else{
                Console.WriteLine("");
                Console.WriteLine("your answer is wrong");
                getthebox = getthebox - 1;
                IsOpen = false;
               
               }
            }
            if (getthebox == 2){
            Console.WriteLine("");
            Console.WriteLine("try again!!");
            
            summationResult = code1 + code2 + code3 + code4;
            Console.WriteLine("");
            Console.WriteLine("hint the answer");
            Console.WriteLine("for summation result is "+summationResult);
            Console.WriteLine("the code consists of 4 digits");
            Console.WriteLine("when was this project made?");
            Console.WriteLine("");

            Console.Write("input first code : ");
            string guess1 = Console.ReadLine();
            Console.Write("input second code : ");
            string guess2 = Console.ReadLine();
            Console.Write("input third code : ");
            string guess3 = Console.ReadLine();
            Console.Write("input fourth code : ");
            string guess4 = Console.ReadLine();
            Console.WriteLine("your guess : "+guess1+" "+guess2+" "+guess3+" "+guess4+" ??");

            int theguess1 = Convert.ToInt32(guess1);
            int theguess2 = Convert.ToInt32(guess2);
            int theguess3 = Convert.ToInt32(guess3);
            int theguess4 = Convert.ToInt32(guess4);


            if(code1 == theguess1 && code2 == theguess2 && code3 == theguess3 && code4 == theguess4){
                Console.WriteLine("");
                Console.WriteLine("your answer is correct");
                Console.WriteLine("you get potion, Manna and Exp");
                Console.WriteLine("       ________        ");
                Console.WriteLine("      |        |       ");
                Console.WriteLine("  ____|        |____   ");
                Console.WriteLine(" |   Blood = 300    |  ");
                Console.WriteLine(" |   Manna = 50     |  ");
                Console.WriteLine(" |___Exp   = 20 ____|  ");
                Console.WriteLine("      |        |       ");
                Console.WriteLine("      |________|       ");
                zipzoit.Blood += 300;
                zipzoit.Experience += 20f;
                zipzoit.Manna += 50;
                IsOpen = true;
                getthebox = getthebox - 3;

            }else if (getthebox <= 0){
                IsOpen = true;
                
            }else{
                Console.WriteLine("");
                Console.WriteLine("your answer is wrong");
                getthebox = getthebox - 1;
                IsOpen = false;
               
               }
            }
            if (getthebox == 1){
            Console.WriteLine("");
            Console.WriteLine("try again!!");
            Console.WriteLine("");
            Console.WriteLine("this is the last chance!!");
            
            summationResult = code1 + code2 + code3 + code4;
            Console.WriteLine("");
            Console.WriteLine("hint the answer");
            Console.WriteLine("for summation result is "+summationResult);
            Console.WriteLine("the code consists of 4 digits");
            Console.WriteLine("WHEN WAS THIS PROJECT MADE?");
            Console.WriteLine("");

            Console.Write("input first code : ");
            string guess1 = Console.ReadLine();
            Console.Write("input second code : ");
            string guess2 = Console.ReadLine();
            Console.Write("input third code : ");
            string guess3 = Console.ReadLine();
            Console.Write("input fourth code : ");
            string guess4 = Console.ReadLine();
            Console.WriteLine("your guess : "+guess1+" "+guess2+" "+guess3+" "+guess4+" ??");

            int theguess1 = Convert.ToInt32(guess1);
            int theguess2 = Convert.ToInt32(guess2);
            int theguess3 = Convert.ToInt32(guess3);
            int theguess4 = Convert.ToInt32(guess4);


            if(code1 == theguess1 && code2 == theguess2 && code3 == theguess3 && code4 == theguess4){
                Console.WriteLine("");
                Console.WriteLine("your answer is correct");
                Console.WriteLine("you get potion, Manna and Exp");
                Console.WriteLine("       ________        ");
                Console.WriteLine("      |        |       ");
                Console.WriteLine("  ____|        |____   ");
                Console.WriteLine(" |   Blood = 300    |  ");
                Console.WriteLine(" |   Manna = 50     |  ");
                Console.WriteLine(" |___Exp   = 20 ____|  ");
                Console.WriteLine("      |        |       ");
                Console.WriteLine("      |________|       ");
                zipzoit.Blood += 300;
                zipzoit.Experience += 20f;
                zipzoit.Manna += 50;
                IsOpen = true;
                getthebox = getthebox - 3;

            }else if (getthebox <= 0){
                IsOpen = true;
                
            }else{
                Console.WriteLine("");
                Console.WriteLine("your answer is wrong");
                Console.WriteLine("YOU CANT OPEN THE TREASURE BOX");
                Console.WriteLine("");
                getthebox = getthebox - 1;
                IsOpen = false;
               
               }
            }
        }

        public void OpenBoxW(Wuifang wuifang){
        if (getthebox == 3){
            Console.WriteLine("");
            Console.WriteLine("STOP!!, you got a treasure box");
            Console.WriteLine("  _______________________  ");
            Console.WriteLine(" |           _           | ");
            Console.WriteLine(" |==========|_|==========| ");
            Console.WriteLine(" | o o o o o - o o o o o | ");
            Console.WriteLine(" |                       | ");
            Console.WriteLine(" |_______________________| ");
            Console.WriteLine("    try to open the box    ");
            
            summationResult = code1 + code2 + code3 + code4;
            Console.WriteLine("");
            Console.WriteLine("hint the answer");
            Console.WriteLine("for summation result is "+summationResult);
            Console.WriteLine("the code consists of 4 digits");
            Console.WriteLine("when was this project made?");
            Console.WriteLine("");

            Console.Write("input first code : ");
            string guess1 = Console.ReadLine();
            Console.Write("input second code : ");
            string guess2 = Console.ReadLine();
            Console.Write("input third code : ");
            string guess3 = Console.ReadLine();
            Console.Write("input fourth code : ");
            string guess4 = Console.ReadLine();
            Console.WriteLine("your guess : "+guess1+" "+guess2+" "+guess3+" "+guess4+" ??");

            int theguess1 = Convert.ToInt32(guess1);
            int theguess2 = Convert.ToInt32(guess2);
            int theguess3 = Convert.ToInt32(guess3);
            int theguess4 = Convert.ToInt32(guess4);


            if(code1 == theguess1 && code2 == theguess2 && code3 == theguess3 && code4 == theguess4){
                Console.WriteLine("");
                Console.WriteLine("your answer is correct");
                Console.WriteLine("you get potion, Combo Point and Exp");
                Console.WriteLine("       ________        ");
                Console.WriteLine("      |        |       ");
                Console.WriteLine("  ____|        |____   ");
                Console.WriteLine(" |   Blood = 300    |  ");
                Console.WriteLine(" |   CP    = 6      |  ");
                Console.WriteLine(" |___Exp   = 20 ____|  ");
                Console.WriteLine("      |        |       ");
                Console.WriteLine("      |________|       ");
                wuifang.Blood += 300;
                wuifang.Experience += 20f;
                wuifang.ComboPoint += 6;
                IsOpen = true;
                getthebox = getthebox - 3;

            }else if (getthebox <= 0){
                IsOpen = true;
                
            }else{
                Console.WriteLine("");
                Console.WriteLine("your answer is wrong");
                getthebox = getthebox - 1;
                IsOpen = false;
               
               }
            }
            if (getthebox == 2){
            Console.WriteLine("");
            Console.WriteLine("try again!!");
            
            summationResult = code1 + code2 + code3 + code4;
            Console.WriteLine("");
            Console.WriteLine("hint the answer");
            Console.WriteLine("for summation result is "+summationResult);
            Console.WriteLine("the code consists of 4 digits");
            Console.WriteLine("when was this project made?");
            Console.WriteLine("");

            Console.Write("input first code : ");
            string guess1 = Console.ReadLine();
            Console.Write("input second code : ");
            string guess2 = Console.ReadLine();
            Console.Write("input third code : ");
            string guess3 = Console.ReadLine();
            Console.Write("input fourth code : ");
            string guess4 = Console.ReadLine();
            Console.WriteLine("your guess : "+guess1+" "+guess2+" "+guess3+" "+guess4+" ??");

            int theguess1 = Convert.ToInt32(guess1);
            int theguess2 = Convert.ToInt32(guess2);
            int theguess3 = Convert.ToInt32(guess3);
            int theguess4 = Convert.ToInt32(guess4);


            if(code1 == theguess1 && code2 == theguess2 && code3 == theguess3 && code4 == theguess4){
                Console.WriteLine("");
                Console.WriteLine("your answer is correct");
                Console.WriteLine("you get potion, Combo Point and Exp");
                Console.WriteLine("       ________        ");
                Console.WriteLine("      |        |       ");
                Console.WriteLine("  ____|        |____   ");
                Console.WriteLine(" |   Blood = 300    |  ");
                Console.WriteLine(" |   CP    = 6      |  ");
                Console.WriteLine(" |___Exp   = 20 ____|  ");
                Console.WriteLine("      |        |       ");
                Console.WriteLine("      |________|       ");
                wuifang.Blood += 300;
                wuifang.Experience += 20f;
                wuifang.ComboPoint += 6;
                IsOpen = true;
                getthebox = getthebox - 3;

            }else if (getthebox <= 0){
                IsOpen = true;
                
            }else{
                Console.WriteLine("");
                Console.WriteLine("your answer is wrong");
                getthebox = getthebox - 1;
                IsOpen = false;
               
               }
            }
            if (getthebox == 1){
            Console.WriteLine("");
            Console.WriteLine("try again!!");
            Console.WriteLine("");
            Console.WriteLine("this is the last chance!!");
            
            summationResult = code1 + code2 + code3 + code4;
            Console.WriteLine("");
            Console.WriteLine("hint the answer");
            Console.WriteLine("for summation result is "+summationResult);
            Console.WriteLine("the code consists of 4 digits");
            Console.WriteLine("WHEN WAS THIS PROJECT MADE?");
            Console.WriteLine("");

            Console.Write("input first code : ");
            string guess1 = Console.ReadLine();
            Console.Write("input second code : ");
            string guess2 = Console.ReadLine();
            Console.Write("input third code : ");
            string guess3 = Console.ReadLine();
            Console.Write("input fourth code : ");
            string guess4 = Console.ReadLine();
            Console.WriteLine("your guess : "+guess1+" "+guess2+" "+guess3+" "+guess4+" ??");

            int theguess1 = Convert.ToInt32(guess1);
            int theguess2 = Convert.ToInt32(guess2);
            int theguess3 = Convert.ToInt32(guess3);
            int theguess4 = Convert.ToInt32(guess4);


            if(code1 == theguess1 && code2 == theguess2 && code3 == theguess3 && code4 == theguess4){
                Console.WriteLine("");
                Console.WriteLine("your answer is correct");
                Console.WriteLine("you get potion, Combo Point and Exp");
                Console.WriteLine("       ________        ");
                Console.WriteLine("      |        |       ");
                Console.WriteLine("  ____|        |____   ");
                Console.WriteLine(" |   Blood = 300    |  ");
                Console.WriteLine(" |   CP    = 6      |  ");
                Console.WriteLine(" |___Exp   = 20 ____|  ");
                Console.WriteLine("      |        |       ");
                Console.WriteLine("      |________|       ");
                wuifang.Blood += 300;
                wuifang.Experience += 20f;
                wuifang.ComboPoint += 6;
                IsOpen = true;
                getthebox = getthebox - 3;

            }else if (getthebox <= 0){
                IsOpen = true;
                
            }else{
                Console.WriteLine("");
                Console.WriteLine("your answer is wrong");
                Console.WriteLine("YOU CANT OPEN THE TREASURE BOX");
                Console.WriteLine("");
                getthebox = getthebox - 1;
                IsOpen = false;
               
               }
            }
        }

        public void OpenBoxG(Gonrock gonrock){
        if (getthebox == 3){
            Console.WriteLine("");
            Console.WriteLine("STOP!!, you got a treasure box");
            Console.WriteLine("  _______________________  ");
            Console.WriteLine(" |           _           | ");
            Console.WriteLine(" |==========|_|==========| ");
            Console.WriteLine(" | o o o o o - o o o o o | ");
            Console.WriteLine(" |                       | ");
            Console.WriteLine(" |_______________________| ");
            Console.WriteLine("    try to open the box    ");
            
            summationResult = code1 + code2 + code3 + code4;
            Console.WriteLine("");
            Console.WriteLine("hint the answer");
            Console.WriteLine("for summation result is "+summationResult);
            Console.WriteLine("the code consists of 4 digits");
            Console.WriteLine("when was this project made?");
            Console.WriteLine("");

            Console.Write("input first code : ");
            string guess1 = Console.ReadLine();
            Console.Write("input second code : ");
            string guess2 = Console.ReadLine();
            Console.Write("input third code : ");
            string guess3 = Console.ReadLine();
            Console.Write("input fourth code : ");
            string guess4 = Console.ReadLine();
            Console.WriteLine("your guess : "+guess1+" "+guess2+" "+guess3+" "+guess4+" ??");

            int theguess1 = Convert.ToInt32(guess1);
            int theguess2 = Convert.ToInt32(guess2);
            int theguess3 = Convert.ToInt32(guess3);
            int theguess4 = Convert.ToInt32(guess4);


            if(code1 == theguess1 && code2 == theguess2 && code3 == theguess3 && code4 == theguess4){
                Console.WriteLine("");
                Console.WriteLine("your answer is correct");
                Console.WriteLine("you get potion, Stun Point and Exp");
                Console.WriteLine("       ________        ");
                Console.WriteLine("      |        |       ");
                Console.WriteLine("  ____|        |____   ");
                Console.WriteLine(" |   Blood = 200    |  ");
                Console.WriteLine(" |   SP    = 6      |  ");
                Console.WriteLine(" |___Exp   = 20 ____|  ");
                Console.WriteLine("      |        |       ");
                Console.WriteLine("      |________|       ");
                gonrock.Blood += 200;
                gonrock.Experience += 20f;
                gonrock.StunPoint += 6;
                IsOpen = true;
                getthebox = getthebox - 3;

            }else if (getthebox <= 0){
                IsOpen = true;
                
            }else{
                Console.WriteLine("");
                Console.WriteLine("your answer is wrong");
                getthebox = getthebox - 1;
                IsOpen = false;
               
               }
            }
            if (getthebox == 2){
            Console.WriteLine("");
            Console.WriteLine("try again!!");
            
            summationResult = code1 + code2 + code3 + code4;
            Console.WriteLine("");
            Console.WriteLine("hint the answer");
            Console.WriteLine("for summation result is "+summationResult);
            Console.WriteLine("the code consists of 4 digits");
            Console.WriteLine("when was this project made?");
            Console.WriteLine("");

            Console.Write("input first code : ");
            string guess1 = Console.ReadLine();
            Console.Write("input second code : ");
            string guess2 = Console.ReadLine();
            Console.Write("input third code : ");
            string guess3 = Console.ReadLine();
            Console.Write("input fourth code : ");
            string guess4 = Console.ReadLine();
            Console.WriteLine("your guess : "+guess1+" "+guess2+" "+guess3+" "+guess4+" ??");

            int theguess1 = Convert.ToInt32(guess1);
            int theguess2 = Convert.ToInt32(guess2);
            int theguess3 = Convert.ToInt32(guess3);
            int theguess4 = Convert.ToInt32(guess4);


            if(code1 == theguess1 && code2 == theguess2 && code3 == theguess3 && code4 == theguess4){
                Console.WriteLine("");
                Console.WriteLine("your answer is correct");
                Console.WriteLine("you get potion, Stun Point and Exp");
                Console.WriteLine("       ________        ");
                Console.WriteLine("      |        |       ");
                Console.WriteLine("  ____|        |____   ");
                Console.WriteLine(" |   Blood = 200    |  ");
                Console.WriteLine(" |   SP    = 6      |  ");
                Console.WriteLine(" |___Exp   = 20 ____|  ");
                Console.WriteLine("      |        |       ");
                Console.WriteLine("      |________|       ");
                gonrock.Blood += 200;
                gonrock.Experience += 20f;
                gonrock.StunPoint += 6;
                IsOpen = true;
                getthebox = getthebox - 3;

            }else if (getthebox <= 0){
                IsOpen = true;
                
            }else{
                Console.WriteLine("");
                Console.WriteLine("your answer is wrong");
                getthebox = getthebox - 1;
                IsOpen = false;
               
               }
            }
            if (getthebox == 1){
            Console.WriteLine("");
            Console.WriteLine("try again!!");
            Console.WriteLine("");
            Console.WriteLine("this is the last chance!!");
            
            summationResult = code1 + code2 + code3 + code4;
            Console.WriteLine("");
            Console.WriteLine("hint the answer");
            Console.WriteLine("for summation result is "+summationResult);
            Console.WriteLine("the code consists of 4 digits");
            Console.WriteLine("WHEN WAS THIS PROJECT MADE?");
            Console.WriteLine("");

            Console.Write("input first code : ");
            string guess1 = Console.ReadLine();
            Console.Write("input second code : ");
            string guess2 = Console.ReadLine();
            Console.Write("input third code : ");
            string guess3 = Console.ReadLine();
            Console.Write("input fourth code : ");
            string guess4 = Console.ReadLine();
            Console.WriteLine("your guess : "+guess1+" "+guess2+" "+guess3+" "+guess4+" ??");

            int theguess1 = Convert.ToInt32(guess1);
            int theguess2 = Convert.ToInt32(guess2);
            int theguess3 = Convert.ToInt32(guess3);
            int theguess4 = Convert.ToInt32(guess4);


            if(code1 == theguess1 && code2 == theguess2 && code3 == theguess3 && code4 == theguess4){
                Console.WriteLine("");
                Console.WriteLine("your answer is correct");
                Console.WriteLine("you get potion, Stun Point and Exp");
                Console.WriteLine("       ________        ");
                Console.WriteLine("      |        |       ");
                Console.WriteLine("  ____|        |____   ");
                Console.WriteLine(" |   Blood = 200    |  ");
                Console.WriteLine(" |   SP    = 6      |  ");
                Console.WriteLine(" |___Exp   = 20 ____|  ");
                Console.WriteLine("      |        |       ");
                Console.WriteLine("      |________|       ");
                gonrock.Blood += 200;
                gonrock.Experience += 20f;
                gonrock.StunPoint += 6;
                IsOpen = true;
                getthebox = getthebox - 3;

            }else if (getthebox <= 0){
                IsOpen = true;
                
            }else{
                Console.WriteLine("");
                Console.WriteLine("your answer is wrong");
                Console.WriteLine("YOU CANT OPEN THE TREASURE BOX");
                Console.WriteLine("");
                getthebox = getthebox - 1;
                IsOpen = false;
               
               }
            }
        }

        public void OpenBoxS(Skyepix skyepix){
        if (getthebox == 3){
            Console.WriteLine("");
            Console.WriteLine("STOP!!, you got a treasure box");
            Console.WriteLine("  _______________________  ");
            Console.WriteLine(" |           _           | ");
            Console.WriteLine(" |==========|_|==========| ");
            Console.WriteLine(" | o o o o o - o o o o o | ");
            Console.WriteLine(" |                       | ");
            Console.WriteLine(" |_______________________| ");
            Console.WriteLine("    try to open the box    ");
            
            summationResult = code1 + code2 + code3 + code4;
            Console.WriteLine("");
            Console.WriteLine("hint the answer");
            Console.WriteLine("for summation result is "+summationResult);
            Console.WriteLine("the code consists of 4 digits");
            Console.WriteLine("when was this project made?");
            Console.WriteLine("");

            Console.Write("input first code : ");
            string guess1 = Console.ReadLine();
            Console.Write("input second code : ");
            string guess2 = Console.ReadLine();
            Console.Write("input third code : ");
            string guess3 = Console.ReadLine();
            Console.Write("input fourth code : ");
            string guess4 = Console.ReadLine();
            Console.WriteLine("your guess : "+guess1+" "+guess2+" "+guess3+" "+guess4+" ??");

            int theguess1 = Convert.ToInt32(guess1);
            int theguess2 = Convert.ToInt32(guess2);
            int theguess3 = Convert.ToInt32(guess3);
            int theguess4 = Convert.ToInt32(guess4);


            if(code1 == theguess1 && code2 == theguess2 && code3 == theguess3 && code4 == theguess4){
                Console.WriteLine("");
                Console.WriteLine("your answer is correct");
                Console.WriteLine("you get potion, Heal Point and Exp");
                Console.WriteLine("       ________        ");
                Console.WriteLine("      |        |       ");
                Console.WriteLine("  ____|        |____   ");
                Console.WriteLine(" |   Blood = 200    |  ");
                Console.WriteLine(" |   HP    = 10     |  ");
                Console.WriteLine(" |___Exp   = 20 ____|  ");
                Console.WriteLine("      |        |       ");
                Console.WriteLine("      |________|       ");
                skyepix.Blood += 300;
                skyepix.Experience += 20f;
                skyepix.HealPoint += 10;
                IsOpen = true;
                getthebox = getthebox - 3;

            }else if (getthebox <= 0){
                IsOpen = true;
                
            }else{
                Console.WriteLine("");
                Console.WriteLine("your answer is wrong");
                getthebox = getthebox - 1;
                IsOpen = false;
               
               }
            }
            if (getthebox == 2){
            Console.WriteLine("");
            Console.WriteLine("try again!!");
            
            summationResult = code1 + code2 + code3 + code4;
            Console.WriteLine("");
            Console.WriteLine("hint the answer");
            Console.WriteLine("for summation result is "+summationResult);
            Console.WriteLine("the code consists of 4 digits");
            Console.WriteLine("when was this project made?");
            Console.WriteLine("");

            Console.Write("input first code : ");
            string guess1 = Console.ReadLine();
            Console.Write("input second code : ");
            string guess2 = Console.ReadLine();
            Console.Write("input third code : ");
            string guess3 = Console.ReadLine();
            Console.Write("input fourth code : ");
            string guess4 = Console.ReadLine();
            Console.WriteLine("your guess : "+guess1+" "+guess2+" "+guess3+" "+guess4+" ??");

            int theguess1 = Convert.ToInt32(guess1);
            int theguess2 = Convert.ToInt32(guess2);
            int theguess3 = Convert.ToInt32(guess3);
            int theguess4 = Convert.ToInt32(guess4);


            if(code1 == theguess1 && code2 == theguess2 && code3 == theguess3 && code4 == theguess4){
                Console.WriteLine("");
                Console.WriteLine("your answer is correct");
                Console.WriteLine("you get potion, Heal Point and Exp");
                Console.WriteLine("       ________        ");
                Console.WriteLine("      |        |       ");
                Console.WriteLine("  ____|        |____   ");
                Console.WriteLine(" |   Blood = 200    |  ");
                Console.WriteLine(" |   HP    = 10     |  ");
                Console.WriteLine(" |___Exp   = 20 ____|  ");
                Console.WriteLine("      |        |       ");
                Console.WriteLine("      |________|       ");
                skyepix.Blood += 300;
                skyepix.Experience += 20f;
                skyepix.HealPoint += 10;
                IsOpen = true;
                getthebox = getthebox - 3;

            }else if (getthebox <= 0){
                IsOpen = true;
                
            }else{
                Console.WriteLine("");
                Console.WriteLine("your answer is wrong");
                getthebox = getthebox - 1;
                IsOpen = false;
               
               }
            }
            if (getthebox == 1){
            Console.WriteLine("");
            Console.WriteLine("try again!!");
            Console.WriteLine("");
            Console.WriteLine("this is the last chance!!");
            
            summationResult = code1 + code2 + code3 + code4;
            Console.WriteLine("");
            Console.WriteLine("hint the answer");
            Console.WriteLine("for summation result is "+summationResult);
            Console.WriteLine("the code consists of 4 digits");
            Console.WriteLine("WHEN WAS THIS PROJECT MADE?");
            Console.WriteLine("");

            Console.Write("input first code : ");
            string guess1 = Console.ReadLine();
            Console.Write("input second code : ");
            string guess2 = Console.ReadLine();
            Console.Write("input third code : ");
            string guess3 = Console.ReadLine();
            Console.Write("input fourth code : ");
            string guess4 = Console.ReadLine();
            Console.WriteLine("your guess : "+guess1+" "+guess2+" "+guess3+" "+guess4+" ??");

            int theguess1 = Convert.ToInt32(guess1);
            int theguess2 = Convert.ToInt32(guess2);
            int theguess3 = Convert.ToInt32(guess3);
            int theguess4 = Convert.ToInt32(guess4);


            if(code1 == theguess1 && code2 == theguess2 && code3 == theguess3 && code4 == theguess4){
                Console.WriteLine("");
                Console.WriteLine("your answer is correct");
                Console.WriteLine("you get potion, Heal Point and Exp");
                Console.WriteLine("       ________        ");
                Console.WriteLine("      |        |       ");
                Console.WriteLine("  ____|        |____   ");
                Console.WriteLine(" |   Blood = 200    |  ");
                Console.WriteLine(" |   HP    = 10     |  ");
                Console.WriteLine(" |___Exp   = 20 ____|  ");
                Console.WriteLine("      |        |       ");
                Console.WriteLine("      |________|       ");
                skyepix.Blood += 300;
                skyepix.Experience += 20f;
                skyepix.HealPoint += 10;
                IsOpen = true;
                getthebox = getthebox - 3;

            }else if (getthebox <= 0){
                IsOpen = true;
                
            }else{
                Console.WriteLine("");
                Console.WriteLine("your answer is wrong");
                Console.WriteLine("YOU CANT OPEN THE TREASURE BOX");
                Console.WriteLine("");
                getthebox = getthebox - 1;
                IsOpen = false;
               
               }
            }
        }
    }
}