using System;

namespace ConsoleApp8_qz2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Input rose : ");
            int Roseid = int.Parse(Console.ReadLine());
            Console.WriteLine("Input sunflower : ");
            int SunFlowerid = int.Parse(Console.ReadLine());

        }
    }
    class ROSE
    {
        public int ID;
        public string NameFlower;
        public string Discription;
        public int Amount;
        public string Hight;
        public string Cercumference;

        public ROSE(int id, string nameflower, string discription, int amount, string hight, string cercumference)
        {
            this.ID = id;
            this.NameFlower = nameflower;
            this.Discription = discription;
            this.Amount = amount;
            this.Hight = hight;
            this.Cercumference = cercumference;
        }

    }
    class SUNFLOWER
    {
        public int ID;
        public string NameFlower;
        public string Discription;
        public int Amount;
        public string Hight;
        public string Cercumference;

        public SUNFLOWER(int id, string nameflower, string discription, int amount, string hight, string cercumference)
        {
            this.ID = id;
            this.NameFlower = nameflower;
            this.Discription = discription;
            this.Amount = amount;
            this.Hight = hight;
            this.Cercumference = cercumference;
        }
    }
}