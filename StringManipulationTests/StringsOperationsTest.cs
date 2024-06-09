using StringManipulation;

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

        [Fact]
        public void QuantintyInWords()
        {
            // Arrange
            var stringOperations = new StringOperations();
            const string input  = "casas";
            const int quantity = 100;
            
            // Act
            var result = stringOperations.QuantintyInWords(input, quantity);
            
            // Assert 
            Assert.NotNull(result);
            Assert.NotEmpty(result);
            Assert.Contains("casas", result);
            Assert.StartsWith("cien", result);
        }

        [Fact]
        public void GetStringLength_Exception()
        {
            // Arrange
            var stringOperations = new StringOperations();
            
            //Assert
            Assert.Throws<ArgumentNullException>(() => stringOperations.GetStringLength(null));
            //It's necessary to use a lambda expression to call the method because it's a delegate
        }

        [Fact]
        public void GetStringLength()
        {
            // Arrange
            var stringOperations = new StringOperations();
            const string str = "Hello World";
            
            // Act
            var result = stringOperations.GetStringLength(str);
            
            // Assert
            Assert.Equal(str.Length, result);
        }

        [Fact]
        public void TruncateString_Exception()
        {
            // Arrange
            var stringOperations = new StringOperations();
            const string str = "";
            const int n = 0;
            
            // Assert
            Assert.Throws<ArgumentOutOfRangeException>(() => stringOperations.TruncateString(str, n));
        }
        
        [Theory]
        [InlineData("Hel", 5, "Hel")]
        [InlineData("", 5, "")]
        public void TruncateString_Validation(string str, int n, string expected)
        {
            // Arrange
            var stringOperations = new StringOperations();
            
            // Act
            var result = stringOperations.TruncateString(str, n);
            
            // Assert
            Assert.Equal(expected, result);
        }

        [Fact]
        public void TruncatedString()
        {
            // Arrange
            var stringOperations = new StringOperations();
            const string str = "Hello World";
            const int n = 5;
            
            // Act
            var result = stringOperations.TruncateString(str, n);
            
            // Assert
            Assert.Equal("Hello", result);
        }

        [Theory]
        [InlineData("MMXVIII", 2018)]
        [InlineData("MMXXI", 2021)]
        [InlineData("MMMCCL", 3250)]
        public void FromRomanToNumber(string str, int expected )
        {
            // Arrange
            var stringOperations = new StringOperations();
            
            // Act
            var result = stringOperations.FromRomanToNumber(str);
            
            // Assert
            Assert.Equal(expected, result);;
        }
    }
}

