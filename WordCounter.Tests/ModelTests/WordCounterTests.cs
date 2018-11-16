using Microsoft.VisualStudio.TestTools.UnitTesting;
using WordCounter.Models;

namespace WordCounter.Tests
{
    [TestClass]
    public class WordCounterTest
    {
        [TestMethod]
        public void RepeatCounter_ReturnsInput()
        {
            // Arrange
                string input = "dog";
                RepeatCounter testCount = new RepeatCounter();

            // Act
              testCount.SetSentence(input);
              string result = testCount.GetSentence();

            // Assert
              Assert.AreEqual(input, result);
        }
        [TestMethod]
        public void RepeatCounter_ReturnSplitString_true()
        {
            // Arrange
            string inputString = "dog dog dog";
            string[] newArray = {"dog", "dog", "dog"};
            RepeatCounter testCount = new RepeatCounter();

            // Act
            testCount.SetSentence(inputString);
            string[] result = testCount.SplitString();

            // Assert
            CollectionAssert.AreEqual(newArray, result);
        }

        [TestMethod]

        public void RepeatCounter_Multiples_True()
        {
            // Arrange
            string inputString = "dog dog dog cat horse";
            string inputWord = "dog";
            RepeatCounter testCount = new RepeatCounter();

            //Act 
            testCount.SetSentence(inputString);
            testCount.SetWord(inputWord);
            int wordMatches = testCount.CountWord();
            
            // Assert
            Assert.AreEqual(3, wordMatches);
        }
    }
    
}