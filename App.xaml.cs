using SQLiteDemo.MVVM.Views;
using SQLiteDemo.Repository;

namespace SQLiteDemo;

public partial class App : Application
{
	public static CustomerRepository CustomerRepo { get; private set; }

	public App(CustomerRepository repo)
	{
		InitializeComponent();
		CustomerRepo = repo;
		MainPage = new NavigationPage(new MainPage());
	}
}
