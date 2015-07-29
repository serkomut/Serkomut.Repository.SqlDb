using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Serkomut.Repository.Core;

namespace Serkomut.Repository.SqlDb.Test
{
    [TestClass]
    public class SqDbRepositoryTestFixture
    {
        [TestMethod]
        public void TestMethod1()
        {
            var person = new Person
            {
                Name = "Serol",
                Surname = "Guzel"
            };
            var entity = Repository.Add(person);
            Repository.Save();
        }

        private static IRepository<Person> Repository
        {
            get { return new Repository<Person>(new SerkomutContext()); }
        }
    }

    public class Person: BaseEntity
    {
        public string Name { get; set; }
        public string Surname { get; set; }
    }
}
