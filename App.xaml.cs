using SQLiteDemo.MVVM.Models;
using SQLiteDemo.MVVM.Views;
using SQLiteDemo.Repository;

namespace SQLiteDemo;

public partial class App : Application
{
    public static BaseRepository<Customer> CustomerRepo { get; private set; }
    
    public static BaseRepository<Order> OrderRepo { get; private set; }

    public App(BaseRepository<Customer> customerRepo, BaseRepository<Order> orderRepo)
	{
		InitializeComponent();
        CustomerRepo = customerRepo;
        OrderRepo = orderRepo;
        MainPage = new NavigationPage(new MainPage());
	}
}
