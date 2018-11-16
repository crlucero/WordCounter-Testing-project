using Microsoft.VisualStudio.TestTools.UnitTesting;
using WordCounter.Models;
using System;

namespace WordCounter.Tests
{
    [TestClass]
    public class WordCounterTest
    {
        [TestMethod]
        public void RepeatWord_ReturnsInput_True()
        {
            // Arrange
                string input = "dog";
                RepeatWord newCount = new RepeatWord(sentence);

            // Act
              newCount.SetSentence(input);
              string result = newCount.GetSentence();

            // Assert
              Assert.AreEqual(input, result);
        }
    }
    
}