using SQLite;
using SQLiteDemo.MVVM.Models;
using static SQLite.SQLite3;

namespace SQLiteDemo.Repository
{
    public class CustomerRepository
    {
        private readonly SQLiteConnection _connection;

        public CustomerRepository()
        {
            _connection = new SQLiteConnection(Constants.DatabasePath, Constants.Flags);
            _connection.CreateTable<Customer>();
        }

        public string StatusMessage { get; set; }

        public void Add<T>(T model)
        {
            try
            {
                int result = _connection.Insert(model);
                StatusMessage = $"{result} row(s) added.";
            }
            catch (Exception ex)
            {
                StatusMessage = $"Error {ex.Message}.";
            }
        }

        public List<Customer> GetAll()
        {
            try
            {

            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
