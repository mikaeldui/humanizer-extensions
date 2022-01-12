using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Humanizer.Tests
{
    [TestClass]
    public class StringIListExtensions
    {
        [TestMethod]
        public void PluralizeFirst()
        {
            var singulars = _getSingulars();
            singulars.PluralizeFirst();
            Assert.AreEqual(_plurals.First(), singulars.First());
        }

        [TestMethod]
        public void PluralizeLast()
        {
            var singulars = _getSingulars();
            singulars.PluralizeLast();
            Assert.AreEqual(_plurals.Last(), singulars.Last());
        }

        [TestMethod]
        public void SingularizeFirst()
        {
            var plurals = _getPlurals();
            plurals.SingularizeFirst();
            Assert.AreEqual(_singulars.First(), plurals.First());
        }

        [TestMethod]
        public void SingularizeLast()
        {
            var plurals = _getPlurals();
            plurals.SingularizeLast();
            Assert.AreEqual(_singulars.Last(), plurals.Last());
        }

        private static string[] _getSingulars() =>
            new string[] { "Dog", "Cat", "Elephant" };

        private static string[] _getPlurals() =>
            new string[] { "Dogs", "Cats", "Elephants" };

        private readonly IReadOnlyCollection<string> _singulars = Array.AsReadOnly(_getSingulars());
        private readonly IReadOnlyCollection<string> _plurals = Array.AsReadOnly(_getPlurals());
    }
}