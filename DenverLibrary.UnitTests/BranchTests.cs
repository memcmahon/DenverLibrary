using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DenverLibrary.UnitTests
{
    public class BranchTests
    {
        [Fact]
        public void Is_Created_With_Correct_Properties()
        {
            Branch branch = new Branch("Ross");

            Assert.Equal("Ross", branch.Name);
            Assert.Equal(new List<Book>(), branch.Books);
        }

        [Fact]
        public void AddBook_AddsAGivenBookToBooks()
        {
            Branch branch = new Branch("Ross");
            Book goodOmens = new Book("Good Omens", "Terry Pratchett & Neil Gaiman");

            branch.AddBook(goodOmens);

            Assert.Equal(new List<Book> { goodOmens }, branch.Books);
            Assert.Equal(goodOmens, branch.Books[0]);
            Assert.Equal(goodOmens, branch.Books.First());
            Assert.Equal(goodOmens, branch.Books.Last());

        }

        [Fact]
        public void AllAuthors_Returns_ListOfAuthors()
        {
            Branch branch = new Branch("Ross");
            Book goodOmens = new Book("Good Omens", "Terry Pratchett & Neil Gaiman");
            Book anansiBrothers = new Book("Anansi Brothers", "Neil Gaiman");

            branch.AddBook(goodOmens);
            branch.AddBook(anansiBrothers);

            Assert.Equal(new List<string> { goodOmens.Author, anansiBrothers.Author }, branch.AllAuthors());

        }
    }
}
