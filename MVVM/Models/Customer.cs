using SQLite;

namespace SQLiteDemo.MVVM.Models
{
    [Table("Customers")]
    public class Customer
    {
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }

        [Indexed, MaxLength(100), NotNull]
        public string Name { get; set; }

        [MaxLength(20), Unique]
        public string Phone { get; set; }

        public int Age { get; set; }

        [MaxLength(100)]
        public string Address { get; set; }
    }
}
