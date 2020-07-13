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

    }
}
