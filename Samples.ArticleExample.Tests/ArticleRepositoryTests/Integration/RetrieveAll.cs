using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Linq;
using static Samples.ArticleExample.Tests.CommanderHelper;

namespace Samples.ArticleExample.Tests.ArticleRepositoryTests.Integration
{
    [TestClass]
    public class RetrieveAll
    {
        // simple test to prove that the data has indeed been returned. 
        [TestMethod]
        public void Successfully()
        {
            var commander = CreateCommander();
            var repository = new ArticleRepository(commander);
            
            var result = repository.RetrieveAll();
            Assert.IsNotNull(result);
            Assert.AreEqual(3, result.Count());

            var first = result.First();
            Assert.IsNotNull(first.Author);
            Assert.AreEqual("John Smit", first.Author.Name);
            
        }
    }
}
