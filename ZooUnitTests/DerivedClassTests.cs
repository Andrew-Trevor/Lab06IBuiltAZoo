using System;
using Xunit;
using static Lab06_IBuiltAZoo.Program;
using Lab06_IBuiltAZoo.Classes;

namespace ZooUnitTests
{
    public class DerivedClassTests
    {
        [Fact]
        public void CanReturnIsTalking()
        {
            // Arrange
            Human human = new Human("Trevor");
            string expected = $"{human.Name} is talking.";
            // Act
            string returnFromMethod = human.IsTalking();
            // Assert
            Assert.Equal(expected, returnFromMethod);
        }

        [Fact]
        public void CanReturnSleep()
        {
            // Arrange
            Human human = new Human("Trevor");
            // Act
            bool returnFromMethod = human.Sleep();
            // Assert
            Assert.True(returnFromMethod);
        }


        [Fact]
        public void CanReturnIsMeowing()
        {
            // Arrange
            Cat cat = new Cat("Loki");
            string expected = $"{cat.Name} says Roar!!!";
            // Act
            string returnFromMethod = cat.IsMeowing();
            // Assert 
            Assert.Equal(expected, returnFromMethod);
        }

        [Fact]
        public void CanReturnIsSwimming()
        {
            // Arrange
            Penguin penguin = new Penguin("Ozwald");
            // Act
            bool returnFromMethod = penguin.IsSwimming();
            // Assert 
            Assert.True(returnFromMethod);
        }

        [Fact]
        public void CanReturnIsFlying()
        {
            // Arrange
            Eagle eagle = new Eagle("Harry");
            string expected = $"{eagle.Name} is flying so high";
            // Act
            string returnFromMethod = eagle.IsFlying();
            // Assert
            Assert.Equal(expected, returnFromMethod);
        }

        [Fact]
        public void CanReturnTrueFromIsSinging()
        {
            // Arrange
            Eagle eagle = new Eagle("Harry");
            // Act
            bool returnFromMethod = eagle.Singing();
            // Assert
            Assert.True(returnFromMethod);
        }

        [Fact]
        public void CanReturnSmellBlood()
        {
            // Arrange
            Shark shark = new Shark("Sharknado");
            // Act
            bool returnFromMethod = shark.SmellBlood();
            // Assert
            Assert.True(returnFromMethod);
        }

        [Fact]
        public void FishCanReturnIsSwimming()
        {
            // Arrange
            Shark shark = new Shark("Sharknado");
            string expected = $"{shark.Name} is swimming so far!";
            // Act
            string returnFromMethod = shark.IsSwimming();
            // Assert
            Assert.Equal(expected, returnFromMethod);
        }


        [Fact]
        public void CanReturnSwimUpStream()
        {
            // Arrange
            Salmon salmon = new Salmon("Nemo");
            string expected = $"{salmon.Name} is swimming up stream. Watch out for bears.";
            // Act
            string returnFromMethod = salmon.SwimUpStream();
            // Assert
            Assert.Equal(expected, returnFromMethod);
        }

        [Fact]
        public void CanReturnHumanFormOfProcreation()
        {
            // Arrange
            Human human = new Human("Trevor");
            string expected = "One live birth at a time every nine months.";
            // Act
            string returnFromMethod = human.FormOfProcreation();
            // Assert
            Assert.Equal(expected, returnFromMethod);
        }

        [Fact]
        public void CanReturnHumanLeaderOfTheHouse()
        {
            // Arrange
            Human human = new Human("Trevor");
            string expected = "I think I am the leader of the house!";
            // Act
            string returnFromMethod = human.LeadingTheHouse();
            // Assert
            Assert.Equal(expected, returnFromMethod);
        }

        [Fact]
        public void CanReturnCatFormOfProcreation()
        {
            // Arrange
            Cat cat = new Cat("Loki");
            string expected = "Produces a litter every birth roughly year round.";
            // Act
            string returnFromMethod = cat.FormOfProcreation();
            // Assert 
            Assert.Equal(expected, returnFromMethod);
        }

        [Fact]
        public void CanReturnCatLeaderOfTheHouse()
        {
            // Arrange
            Cat cat = new Cat("Loki");
            string expected = "I truly am the leader of the house!";
            // Act
            string returnFromMethod = cat.LeadingTheHouse();
            // Assert
            Assert.Equal(expected, returnFromMethod);
        }

        [Fact]
        public void CanReturnPenguinFormOfProcreation()
        {
            // Arrange
            Penguin penguin = new Penguin("Ozwald");
            string expected = "Lays one egg per year.";
            // Act
            string returnFromMethod = penguin.FormOfProcreation();
            // Assert 
            Assert.Equal(expected, returnFromMethod);
        }

        [Fact]
        public void CanReturnPenguinMoving()
        {
            // Arrange
            Penguin penguin = new Penguin("Ozwald");
            string expected = "I am swimming like a fish!";
            // Act
            string returnFromMethod = penguin.Moving();
            // Assert 
            Assert.Equal(expected, returnFromMethod);
        }

        [Fact]
        public void CanReturnEagleFormOfProcreation()
        {
            // Arrange
            Eagle eagle = new Eagle("Harry");
            string expected = "Lays one to three eggs three times a year.";
            // Act
            string returnFromMethod = eagle.FormOfProcreation();
            // Assert 
            Assert.Equal(expected, returnFromMethod);
        }

        [Fact]
        public void CanReturnEagleMoving()
        {
            // Arrange
            Eagle eagle = new Eagle("Harry");
            string expected = "Flyyyyy like an eagle";
            // Act
            string returnFromMethod = eagle.Moving();
            // Assert 
            Assert.Equal(expected, returnFromMethod);
        }

        [Fact]
        public void CanReturnSharkFormOfProcreation()
        {
            // Arrange
            Shark shark = new Shark("Sharknado");
            string expected = "Lays one egg that hatches inside the mother.";
            // Act
            string returnFromMethod = shark.FormOfProcreation();
            // Assert 
            Assert.Equal(expected, returnFromMethod);
        }

        [Fact]
        public void CanReturnSharkFreshOrSalt()
        {
            // Arrange
            Shark shark = new Shark("Sharknado");
            string expected = "I am a salt water fish!";
            // Act
            string returnFromMethod = shark.FreshOrSalt();
            // Assert 
            Assert.Equal(expected, returnFromMethod);
        }

        [Fact]
        public void CanReturnSalmonFormOfProcreation()
        {
            // Arrange
            Salmon salmon = new Salmon("Nemo");
            string expected = "Swims upstream lays all their eggs then dies.";
            // Act
            string returnFromMethod = salmon.FormOfProcreation();
            // Assert 
            Assert.Equal(expected, returnFromMethod);
        }

        [Fact]
        public void CanReturnSalmonFreshOrSalt()
        {
            // Arrange
            Salmon salmon = new Salmon("Nemo");
            string expected = "I can swim in fresh and salt water!";
            // Act
            string returnFromMethod = salmon.FreshOrSalt();
            // Assert 
            Assert.Equal(expected, returnFromMethod);
        }
    }
}
