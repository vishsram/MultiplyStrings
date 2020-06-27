using NUnit.Framework;
using System;

namespace MultiplyStrings
{
    public class Tests
    {
        private Program MultiplyStringsService;

        [SetUp]
        public void Setup()
        {
            MultiplyStringsService = new Program();
        }

        [Test]
        public void Test_MultipleStrings()
        {
            String result = MultiplyStringsService.MultiplyStrings("123", "456");
            Assert.AreEqual("56088", result);
        }

        [Test]
        public void Test_MultipleInvalidStrings()
        {
            Assert.Throws<ArgumentException>(() => MultiplyStringsService.MultiplyStrings("123", "2d1"));
        }

        [Test]
        public void Test_MultipleStringsWithZero()
        {
            String result = MultiplyStringsService.MultiplyStrings("123", "0");
            Assert.AreEqual(String.Empty, result);
        }

        [Test]
        public void Test_MultipleStringsEmptyString()
        {
            String result = MultiplyStringsService.MultiplyStrings("123", "");
            Assert.AreEqual(String.Empty, result);
        }

        [Test]
        public void Test_MultipleStringsInvalidChars()
        {
            Assert.Throws<ArgumentException>(() => MultiplyStringsService.MultiplyStrings("!@#", "~)("));
        }

        [Test]
        public void Test_MultipleStringsNegativeString()
        {
            Assert.Throws<ArgumentException>(() => MultiplyStringsService.MultiplyStrings("-123", "5"));
        }

    }

}