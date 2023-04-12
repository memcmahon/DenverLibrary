using System;

namespace DenverLibrary.UnitTests
{
    public class LibraryTests
    {
        [Fact]
        public void IsCreatedWithCorrectProperties()
        {
            Library library = new Library("Denver Public Library");

            Assert.Equal("Denver Public Library", library.Name);
            Assert.Equal(new List<Branch>(), library.Branches);
        }

        [Fact]
        public void AddBranch_Adds_GivenBranchToBranches()
        {
            Library library = new Library("Denver Public Library");
            Branch ross = new Branch("Ross");
            Branch aurora = new Branch("Aurora");

            library.AddBranch(ross);
            library.AddBranch(aurora);

            Assert.Equal(new List<Branch> { ross, aurora }, library.Branches);

        }

        [Fact]
        public void BranchNames_Returns_ListOfBranchNames()
        {
            Library library = new Library("Denver Public Library");
            Branch ross = new Branch("Ross");
            Branch aurora = new Branch("Aurora");

            library.AddBranch(ross);
            library.AddBranch(aurora);
            
            //MM: why do I not have any books in this test?
            Assert.Equal(new List<string> { "Ross", "Aurora" }, library.BranchNames());
        }

        [Fact]
        public void AllBooks_Returns_ListOfBookTitlesEvenThoughMeganCalledTheMethodVariableAuthorsInsteadOfBooksOrTitlesWhichWouldHaveMadeMoreSense()
        {
            Library library = new Library("Denver Public Library");
            Branch ross = new Branch("Ross");
            Branch aurora = new Branch("Aurora");
            Book goodOmens = new Book("Good Omens", "Terry Pratchett & Neil Gaiman");
            Book anansiBoys = new Book("Anansi Boys", "Neil Gaiman");
            Book mort = new Book("Mort", "Terry Pratchett");


            library.AddBranch(ross);
            library.AddBranch(aurora);
            ross.AddBook(goodOmens);
            aurora.AddBook(mort);
            ross.AddBook(anansiBoys);

            //MM: can you determine why the books are listed in this order?
            Assert.Equal(new List<string> { goodOmens.Title, anansiBoys.Title, mort.Title }, library.AllBooks());
        }
    }
}
