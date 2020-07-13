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

            Cat cat = new Cat("Razzle");
            cat.IsMeowing();
            cat.Sleep();
            cat.IsRunning();
            cat.Sleep();
            cat.ProCreating();

            Penguin penguin = new Penguin("Tom");
            penguin.IsSwimming();
            penguin.Singing();
            penguin.ProCreating();

            Eagle eagle = new Eagle("Bob");
            eagle.IsFlying();
            eagle.Singing();
            eagle.ProCreating();

            Shark shark = new Shark("Sharina");
            shark.SmellBlood();
            shark.IsSwimming();
            shark.ProCreating();

            Salmon salmon = new Salmon("Flipper");
            salmon.SwimUpStream();
            salmon.IsSwimming();
            salmon.ProCreating();
        }
    }
}
