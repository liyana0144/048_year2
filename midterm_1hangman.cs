using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;



namespace ConsoleApp1_Hangman_1
{

    enum Menu
    {
        PlayGame = 1,
        Exit
    }
    class Program
    {
        static void Main(string[] args)
        {
            PrintMenuScreen();

        }

        static void PrintMenuScreen() //เปิดหน้าเมนูหลัก
        {
            PrintMenuHeader();
            PrintMenu();
            InputMenuFromKeyboard();
        }

        static void PrintMenuHeader() //พูดทักทายก่อนเข้าเกม
        {
            Console.WriteLine("Welcome to Hangman Game");
            Console.WriteLine("-----------------------");
        }

        static void PrintMenu() //หน้าตัวเลือกเมนู
        {
            Console.WriteLine("1. Play game.");
            Console.WriteLine("2. Exit.");
            //กด1และ2เพื่อเลือกว่าจะเริ่มหรือออก
        }

        static void InputMenuFromKeyboard()
        {
            Console.Write("Please Select Menu : ");
            Menu menu = (Menu)(int.Parse(Console.ReadLine()));//รับค่าเมนู

            PresentMenu(menu);
        }

        static void PresentMenu(Menu menu) //ไปยังตัวเลือกต่างๆในโปรแกรม
        {
            if (menu == Menu.PlayGame)
            {
                PlayScreen();
            }
            else if (menu == Menu.Exit)
            {
                Console.ReadLine();
            }
            else
            {
                ShowInputMenuAgain();
            }
        }

        static void ShowInputMenuAgain() //หน้าแสดงข้อมูลการกรอกข้อมูลผิด นอกเหนือจากที่กำหนดให้
        {
            Console.WriteLine("Menu is incorrect, Please try again.");
            
            Console.Clear();

            InputMenuFromKeyboard();
        }

        static void PlayScreen() //หน้าเริ่มเกม
        {
            PrintHeader();
            RandomWord();
        }

        static void PrintHeader() //พาดหัว แสดงสถานะหน้าเล่นเกม
        {
            Console.Clear();
            Console.WriteLine("Play Game Hangman");
            Console.WriteLine("-----------------");

        }


        static void RandomWord() //สุ่มคำและตัวขีดเว้นวรรค
        {
            string[] words = new string[3];
            words[0] = "tennis";
            words[1] = "football";
            words[2] = "badminton";

            Random random = new Random();
            int ResultRandom = random.Next(0, words.Length);
            string RandomWords = words[ResultRandom];

            char[] guessWords = new char[RandomWords.Length];

            for (int i = 0; i < RandomWords.Length; i++)
            {
                guessWords[i] = '-';
            }

            StartGame(RandomWords, guessWords);
        }

        static void StartGame(string mysteryWords, char[] guessWords)
        {
            int count = 0;
            int Truealphabet = 0;

            bool Win = false;

            do
            {
                PrintHeader();

                Console.WriteLine("Incorrect Score : {0}", count);
                Console.WriteLine(guessWords);
                Console.Write("Input letter alphabet : ");

                char playerGuess = char.Parse(Console.ReadLine());

                if (mysteryWords.Contains(playerGuess))
                {
                    for (int j = 0; j < mysteryWords.Length; j++)
                    {
                        if (playerGuess == mysteryWords[j])
                        {
                            guessWords[j] = playerGuess;
                            Truealphabet++;
                        }
                    }

                    if (Truealphabet == mysteryWords.Length)
                    {
                        Win = true;
                    }
                }
                else
                {
                    count += 1;
                }
            } while (count <= 6 && !Win);

            if (Win == true)
            {
                Console.WriteLine(guessWords);
                WinScreen();
            }
            else
            {
                LostScreen();
            }
            Console.Write("Press ENTER to exit...");  //กดEnterเพื่อออก
            Console.ReadLine();
        }

        static void WinScreen() //แสดงเมื่อชนะ
        {
            Console.WriteLine("You win!!");
        }

        static void LostScreen() //แสดงเมื่อแพ้
        {
            Console.WriteLine("You lost!!");
        }
       

    }
}

