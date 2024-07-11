using Microsoft.Data.SqlClient;
using ProgramsForLearning.HomeWork14.Contracts;
using ProgramsForLearning.HomeWork14.Models;
using System.Configuration;
namespace ProgramsForLearning.HomeWork14.Repositories
{
    public class ContactAdoRepository : IContactRepository
    {
        private readonly string _connectionString;
        public ContactAdoRepository()
        {
            _connectionString = ConfigurationManager.ConnectionStrings["ContactesDbCnn"].ConnectionString;
        }

        public void Add(Contact contact)
        {
            using (var connection = new SqlConnection(_connectionString))
            {
                connection.Open();

                using (var transaction = connection.BeginTransaction())
                {
                    // var command = new SqlCommand($"INSERT INTO Contacts (ContactId, Name, LastName, Email, Phone) VALUES ({contact.Id}, @FirstName, @LastName, @Email, @PhoneNumber)", connection);
                    try
                    {
                        var command = new SqlCommand("INSERT INTO Contacts (ContactId, Name, LastName, Email, Phone) VALUES (@ContactID, @FirstName, @LastName, @Email, @PhoneNumber)", connection);
                        command.Parameters.AddWithValue("@ContactID", contact.ContactId);
                        command.Parameters.AddWithValue("@FirstName", contact.Name);
                        command.Parameters.AddWithValue("@LastName", contact.LastName);
                        command.Parameters.AddWithValue("@Email", contact.Email);
                        command.Parameters.AddWithValue("@PhoneNumber", contact.Phone);

                        command.ExecuteNonQuery();
                        transaction.Commit();
                    }
                    catch (Exception)
                    {
                        transaction.Rollback();
                    }
                    finally
                    {
                        connection.Close(); 
                    }

                }
            }

        }

        public void Delete(int id)
        {
            var connection = new SqlConnection(_connectionString);

            var command = new SqlCommand("DELETE FROM Contacts WHERE ContactID   = @ContactID", connection);
            command.Parameters.AddWithValue("@ContactID", id);

            connection.Open();
            command.ExecuteNonQuery();
            connection.Close();

        }

        public Contact GetById(int id)
        {
            using (var connection = new SqlConnection(_connectionString))
            {
                var command = new SqlCommand("SELECT * FROM Contacts WHERE ContactID = @ContactID", connection);
                command.Parameters.AddWithValue("@ContactID", id);

                connection.Open();
                using (var reader = command.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        // var contact = new Contact();
                        // contact.Id = (int)reader[nameof(contact.Id)];
                        //  contact.Id = (int)reader["ContactID"];
                        return new Contact
                        {
                            ContactId = (int)reader["ContactID"],
                            Name = reader["Name"].ToString(),
                            LastName = reader["LastName"].ToString(),
                            Email = reader["Email"].ToString(),
                            Phone = reader["Phone"].ToString()
                        };
                    }
                }
            }
            return null;

        }

        public List<Contact> GetAll()
        {
            var contacts = new List<Contact>();
            using (var connection = new SqlConnection(_connectionString))
            {
                var command = new SqlCommand("SELECT * FROM Contacts", connection);
                connection.Open();
                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        contacts.Add(new Contact
                        {
                            ContactId = (int)reader["ContactID"],
                            Name = reader["Name"].ToString(),
                            LastName = reader["LastName"].ToString(),
                            Email = reader["Email"].ToString(),
                            Phone = reader["Phone"].ToString()
                        });
                    }
                }
            }
            return contacts;

        }

        public void Update(Contact contact)
        {
            using (var connection = new SqlConnection(_connectionString))
            {
                var command = new SqlCommand("UPDATE Contacts SET Name = @FirstName, LastName = @LastName, Email = @Email, Phone = @PhoneNumber WHERE ContactID = @ContactID", connection);
                command.Parameters.AddWithValue("@ContactID", contact.ContactId);
                command.Parameters.AddWithValue("@FirstName", contact.Name);
                command.Parameters.AddWithValue("@LastName", contact.LastName);
                command.Parameters.AddWithValue("@Email", contact.Email);
                command.Parameters.AddWithValue("@PhoneNumber", contact.Phone);

                connection.Open();
                command.ExecuteNonQuery();
                connection.Close();

            }

        }
    }
}
