namespace DenverLibrary.UnitTests
{
    public class BookTests
    {
        [Fact]
        public void Is_Created_With_Correct_Properties()
        {
            Book goodOmens = new Book("Good Omens", "Terry Pratchett & Neil Gaiman");

            Assert.Equal("Good Omens", goodOmens.Title);
            Assert.Equal("Terry Pratchett & Neil Gaiman", goodOmens.Author);
        }
    }
}