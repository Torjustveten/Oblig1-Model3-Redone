using NUnit.Framework;
using Oblig1_Modul3_redone;

namespace FamilyTree
{
    public class Tests
    {
        [Test] public void TestAllFields()
            {
                var p = new Person
                {
                    Id = 17,
                    FirstName = "Ola",
                    LastName = "Nordmann",
                    BirthYear = 2000,
                    DeathYear = 3000,
                    Father = new Person() { Id = 23, FirstName = "Per" },
                    Mother = new Person() { Id = 29, FirstName = "Lise" },
                };

                var actualDescription = p.GetDescription();
                var expectedDescription = "Ola Nordmann (Id=17) Født: 2000 Død: 3000 Far: Per (Id=23) Mor: Lise (Id=29)";

                Assert.AreEqual(expectedDescription, actualDescription);
            }
    }
}