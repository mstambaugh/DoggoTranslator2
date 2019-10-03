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
            string inputString = "Dogs hate cats";
            // Act
            bool result = Translator.IsValidString(inputString);
            // Assert
            Assert.AreEqual(true, result);
        }
        [TestMethod]
        public void UseDictionaryWithString_SuccessfulStringReplace_KeyValue()
        {
            // Arrange
            string inputString = "dogs";
            // Act
            string result = Translator.UseDictionary(inputString);
            // Assert
            Assert.AreEqual(result, "doggos");
        }

    }
}