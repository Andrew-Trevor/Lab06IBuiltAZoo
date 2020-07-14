using Lab06_IBuiltAZoo.Classes;
using System;

namespace Lab06_IBuiltAZoo
{
    public class Program
    {
        static void Main(string[] args)
        {
            Human human = new Human("Andrew");
            human.IsTalking();
            human.ProCreating();
            human.IsRunning();
            human.Sleep();
            human.FormOfProcreation();
            human.LeadingTheHouse();

            Cat cat = new Cat("Razzle");
            cat.IsMeowing();
            cat.Sleep();
            cat.IsRunning();
            cat.ProCreating();
            cat.FormOfProcreation();
            cat.LeadingTheHouse();

            Penguin penguin = new Penguin("Tom");
            penguin.IsSwimming();
            penguin.Singing();
            penguin.ProCreating();
            penguin.FormOfProcreation();
            penguin.Moving();

            Eagle eagle = new Eagle("Bob");
            eagle.IsFlying();
            eagle.Singing();
            eagle.ProCreating();
            eagle.FormOfProcreation();
            eagle.Moving();

            Shark shark = new Shark("Sharina");
            shark.SmellBlood();
            shark.IsSwimming();
            shark.ProCreating();
            shark.FormOfProcreation();
            shark.FreshOrSalt();

            Salmon salmon = new Salmon("Flipper");
            salmon.SwimUpStream();
            salmon.IsSwimming();
            salmon.ProCreating();
            salmon.FormOfProcreation();
            salmon.FreshOrSalt();
        }
    }
}
