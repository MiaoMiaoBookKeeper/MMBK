using MMBK.Core.Contract;
using MMBK.Core.Model;
using MMBK.Service;
using Moq;
using System;
using System.Threading.Tasks;
using Xunit;

namespace MMBK.Test
{
    public class BookServiceTest
    {
        Mock<IBookRepository> _bookRepository;
        public BookServiceTest()
        {
            _bookRepository = new Mock<IBookRepository>();
        }

        [Fact]
        public async Task GetOne_Return_data()
        {
            var id = 1;
            var book = new Book { Title = "book1", Category = "music", BookId = id };

            //Arrange
            var svc = new BookService(_bookRepository.Object);
            _bookRepository.Setup(x => x.GetOneAsync(It.IsAny<int>())).ReturnsAsync(book);

            //Act
            var response = await svc.GetOneAsync(id);

            //Assert
            Assert.Equal(book, response);
            Assert.Equal(id, book.BookId);
            _bookRepository.Verify(x => x.GetOneAsync(id), Times.Once);
        }
    }
}
