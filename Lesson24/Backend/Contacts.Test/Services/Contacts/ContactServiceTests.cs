using Contacts.Application.Contracts;
using Contacts.Application.Services;
using Contacts.Domain;
using Moq;

namespace Contacts.Test.Services.Contacts
{
    public class ContactServiceTests
    {
        private readonly Mock<IContactRepository> _contactRepo;
        private readonly ContactService _contactService;

        public ContactServiceTests()
        {
            _contactRepo = new Mock<IContactRepository>();
            _contactService = new ContactService(_contactRepo.Object);
        }

        [Fact]
        public async Task GetAllContactsAsync_ReturnsListOfContacts()
        {
            //Arrange
            var contacts = new List<Contact>
            {   new Contact { Id = 1, Name = "Juan" },
                new Contact { Id = 2, Name = "Pedro" }
            };
            _contactRepo.Setup(r => r.GetAll()).ReturnsAsync(contacts);

            // Act
            var result = await _contactService.GetAllContactsAsync();

            //Assert  
            Assert.NotNull(result);
            Assert.Equal(2, result.Count);
            Assert.Equal("Juan", result.FirstOrDefault().Name);
        }

        [Fact]
        public async Task GetAllContactsAsync_ReturnsNull()
        {
            //Arrange
            List<Contact> contacts = null;
            _contactRepo.Setup(r => r.GetAll()).ReturnsAsync(contacts);

            // Act
            var result = await _contactService.GetAllContactsAsync();

            //Assert  
            Assert.Null(result); 
        }
    }
}
