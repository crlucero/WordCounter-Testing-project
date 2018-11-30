using Microsoft.VisualStudio.TestTools.UnitTesting;
using WordCounter.Models;

namespace WordCounter.Tests
{
    [TestClass]
    public class WordCounterTests
    {
        [TestMethod]
        public void RepeatCounter_ReturnsWord()
        {
            RepeatCounter testCount = new RepeatCounter("dog", "sentence");

            Assert.AreEqual("dog", testCount.GetWord());
        }
        [TestMethod]
        public void RepeatCounter_SplitString_ReturnSplitString()
        {
            string inputString = "dog dog dog";
            string[] newArr = {"dog", "dog", "dog"};
            RepeatCounter testCount = new RepeatCounter("word", "sentence");

            testCount.SetSentence(inputString);
            string[] result = testCount.SplitString();

            CollectionAssert.AreEqual(newArr, result);
        }

        [TestMethod]

        public void RepeatCounter_Multiples_True()
        {
            // Arrange
            string inputString = "My dog does not think he is a dog";
            string inputWord = "dog";
            RepeatCounter testCount = new RepeatCounter("dog", "My dog does not think he is a dog");

            //Act 
            testCount.SetSentence(inputString);
            testCount.SetWord(inputWord);
            int wordMatches = testCount.CountWord();
            
            // Assert
            Assert.AreEqual(2, wordMatches);
        }
    }
    
}