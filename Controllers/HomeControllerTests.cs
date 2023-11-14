using AddressBook.Controllers;
using AddressBook.ViewModels;
using Microsoft.AspNetCore.Mvc;
using AddressBookTests.Mocks;

namespace AddressBookTests.Controllers
{
    public class HomeControllerTests
    {
        [Fact]
        public void List_ReturnsAllAddresses()
        {
            //arrange

            var mockAddressRepository = RepositoryMocks.GetAddressRepository();
            var homeController = new HomeController(mockAddressRepository.Object);

            //act

            var result = homeController.Index();

            //assert

            var viewResult = Assert.IsType<ViewResult>(result);
            var addressListViewModel = Assert.IsAssignableFrom<AddressBookEntryListViewModel>(viewResult.ViewData.Model);
            Assert.Equal(2, addressListViewModel.AddressBookEntries.Count());
        }
    }
}
