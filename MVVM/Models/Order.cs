using SQLiteDemo.Abstractions;

namespace SQLiteDemo.MVVM.Models
{
    public class Order : TableData
    {
        public int CustomerId { get; set; }

        public DateTime OrderDate { get; set; }
    }
}
