using StringManipulation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace StringManipulationTests
{
    public class StringsOperationsTest
    {
        [Fact]
        public void ConcatenateStrings()
        {
            // Arrange
            var stringOperations = new StringOperations();
            const string str1 = "Hello";
            const string str2 = "World";

            // Act
            var result = stringOperations.ConcatenateStrings(str1, str2);

            // Assert = comprobar
            Assert.NotNull(result);
            Assert.NotEmpty(result);
            Assert.Equal("Hello World", result);
        }

        [Fact]
        public void IsPalindrome_True()
        {
            // Arrange
            var stringOperations = new StringOperations();
            const string str = "anitalavalatina";

            // Act
            var result = stringOperations.IsPalindrome(str);

            // Assert
            Assert.True(result);
        }
        
        [Fact]
        public void IsPalindrome_False()
        {
            // Arrange
            var stringOperations = new StringOperations();
            const string str = "anitalavalatinaa";

            // Act
            var result = stringOperations.IsPalindrome(str);

            // Assert
            Assert.False(result);
        }

        [Fact]
        public void RemoveWhiteSpace()
        {
            // Arrange
            var stringOperations = new StringOperations();
            const string identification = "                  10 20 10 24 11";
            
            // Act
            var result = stringOperations.RemoveWhitespace(identification);
            
            // Assert 
            Assert.NotNull(result);
            Assert.NotEmpty(result);
            Assert.DoesNotContain(" ", result);
        }
    }
}
