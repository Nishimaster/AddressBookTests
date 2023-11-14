using Moq;
using AddressBook.Models.AddressBook;

namespace AddressBookTests.Mocks
{
    public class RepositoryMocks
    {
        public static Mock<IAddressBookRepository> GetAddressRepository()
        {
            var addresses = new List<AddressBookEntry>
            {
                new AddressBookEntry
                {
                    first_name = "David",
                    last_name = "Skowron",
                    phone_number = "07712543092",
                    email = "test@test.com"
                },
                new AddressBookEntry
                {
                    first_name = "David2",
                    last_name = "Skowron2",
                    phone_number = "077125430922",
                    email = "test@potato.com"
                }
            };

            var mockAddressRepository = new Mock<IAddressBookRepository>();
            mockAddressRepository.Setup(repo => repo.AllAddresses()).Returns(addresses);

            return mockAddressRepository;
        }
    }
}