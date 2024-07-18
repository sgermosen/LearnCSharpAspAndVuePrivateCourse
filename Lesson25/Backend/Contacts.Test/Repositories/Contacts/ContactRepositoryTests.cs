using Contacts.Domain;
using Contacts.Infraestructure.Repositories;
using Contacts.Persistence;
using Microsoft.EntityFrameworkCore;

namespace Contacts.Test.Repositories.Contacts
{
    public class ContactRepositoryTests
    {
        private readonly DbContextOptions<ApplicationContext> _dbContextOptions;
        private readonly ApplicationContext _context;
        private readonly ContactEfRepository _repository;
        private readonly Contact contactValid;
        private readonly Contact contactInValid;
        public ContactRepositoryTests()
        {
            _dbContextOptions = new DbContextOptionsBuilder<ApplicationContext>()
                .UseInMemoryDatabase(databaseName: "TestDatabase")
                .Options;
            _context = new ApplicationContext(_dbContextOptions);
            _repository = new ContactEfRepository(_context);
            contactValid = new Contact { Name = "Juan", Email = "", Address = "", LastName = "", Phone = "" };
            contactInValid = new Contact { Name = "Juan"}; 
        }

        [Fact]
        public async Task AddContact_SavesContactToDatabase()
        {
            //Arrange
           
            //Act
            await _repository.Add(contactValid);

            //Assert 
            var contactInDb = _context.Contacts.FirstOrDefault(p => p.Id == 1);

            Assert.NotNull(contactInDb);
            Assert.Equal("Juan", contactInDb.Name);
            Assert.Empty(contactInDb.LastName); 

        }
    }
}
