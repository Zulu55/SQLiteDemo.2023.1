﻿using Bogus;
using PropertyChanged;
using SQLiteDemo.MVVM.Models;
using System.Windows.Input;

namespace SQLiteDemo.MVVM.ViewModels
{
    [AddINotifyPropertyChangedInterface]
    public class MainPageViewModel
    {
        public MainPageViewModel()
        {
            Refresh();
            GenerateNewCustomer();
        }

        public List<Customer> Customers { get; set; }

        public Customer CurrentCustomer { get; set; }

        public ICommand AddOrUpdateCommand => new Command(() =>
        {
            App.CustomerRepo.SaveItem(CurrentCustomer);
            Console.WriteLine(App.CustomerRepo.StatusMessage);
            GenerateNewCustomer();
            Refresh();
        });

        public ICommand DeleteCommand => new Command(() =>
        {
            App.CustomerRepo.DeleteItem(CurrentCustomer);
            Refresh();
        });

        private void GenerateNewCustomer()
        {
            CurrentCustomer = new Faker<Customer>()
                .RuleFor(x => x.Name, f => f.Person.FullName)
                .RuleFor(x => x.Address, f => f.Person.Address.Street)
                .Generate();
        }

        private void Refresh()
        {
            Customers = App.CustomerRepo.GetItems();
            //Customers = App.CustomerRepo.GetAll(x => x.Name.StartsWith("A"));
        }
    }
}
