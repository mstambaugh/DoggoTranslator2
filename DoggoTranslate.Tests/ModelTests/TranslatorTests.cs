using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Doggo.Models;

namespace DoggoTranslator.Tests
{
    [TestClass]
    public class TranslatorTests
    {
        [TestMethod]
        public void IsValidString_StringMeetsConditions_True()
        {
            // Arrange
            string inputString = "dogs hate cats";
            // Act
            bool result = Translator.IsValidString(inputString);
            // Assert
            Assert.AreEqual(true, result);
        }
        [TestMethod]
        public void UseDictionaryOnString_SuccessfulStringReplace_KeyValue()
        {
            // Arrange
            string inputString = "dogs";
            // Act
            string result = Translator.UseDictionary(inputString);
            // Assert
            Assert.AreEqual(result, "doggos");
        }
        [TestMethod]
        public void CallDictionaryOnArray_ReplaceAllElementsInArray_Translation()
        {
            // Arrange
            string inputString = "dogs hate cats";
            // Act
            string result = Translator.DoggoTranslation(inputString);
            // Assert
            Assert.AreEqual(result, "doggos hate cades ");
        }
        [TestMethod]
        public void RemoveEAfterV_CheckForEAfterV_WordWithoutE()
        {
            // Arrange
            string inputString = "have";
            // Act
            string result = Translator.RemoveEAfterV(inputString);
            // Assert
            Assert.AreEqual(result, "hav");
        }
        [TestMethod]
        public void AddLastWord_AddLastWordToReturnString_LongerString()
        {
            // Arrange
            string inputString = "I want cookies";
            // Act
            string resultAddWord = Translator.AddLastWord(Translator.DoggoTranslation(inputString));
            // Assert
            Assert.IsTrue (resultAddWord.Length > inputString.Length);
        }
    }
}