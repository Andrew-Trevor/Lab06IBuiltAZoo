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
            Human human = new Human();
            human.Name = "Trevor";
            string expected = $"{human.Name} is talking.";
            // Act
            string returnFromMethod = human.IsTalking();
            // Assert
            Assert.Equal(expected, returnFromMethod);
        }
    }
}
