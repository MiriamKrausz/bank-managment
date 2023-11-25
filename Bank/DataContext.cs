﻿using Bank.Entities;
namespace Bank
{
    public class DataContext
    {
        public List<Bank_Account> Bank_AccountList { get; set; }
        public List<Customer> CustomerList { get; set; }

        public List<Official> OfficialList { get; set; }
        public DataContext()
        {
            Bank_AccountList = new List<Bank_Account>();
            Bank_AccountList.Add(new Bank_Account(12, 655, 388585, "Miriam Krausz", 317810380));
            Bank_AccountList.Add(new Bank_Account(13, 644, 388500, "Ester Cohen", 12345678));
            Bank_AccountList.Add(new Bank_Account(52, 847, 658741, "Gila Rubin", 317810388));
            CustomerList = new List<Customer>();
            CustomerList.Add(new Customer(1, 0556764576, "Yakov", "Dessler 52", "Bnei brak"));
            CustomerList.Add(new Customer(2, 0556768747, "Tziri", "Ben zakai 19", "Bnei brak"));
            CustomerList.Add(new Customer(3, 0556749841, "Yeudit", "Hazon ish 21", "Bnei brak"));
            CustomerList.Add(new Customer(4, 0504149685, "Sara", "Dessler 52", "Jerusalem"));
            OfficialList = new List<Official>();
            OfficialList.Add(new Official(5, "Kobi", "Raul Valenberg", "Netanyah", 56, 655));
            OfficialList.Add(new Official(6, "Sarit", "Hagai", "Haifah", 27, 687));
            OfficialList.Add(new Official(7, "Osnat", "Raines", "Ramat gan", 35, 645));
            OfficialList.Add(new Official(8, "Tehila", "Hadkalim", "Netivot", 29, 624));
        }
    }
}
