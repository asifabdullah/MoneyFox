﻿using SQLite.Net.Attributes;

namespace MoneyFox.DataAccess.Models
{
    [Table("Accounts")]
    internal class Account
    {
        [PrimaryKey, AutoIncrement, Indexed]
        public int Id { get; set; }

        public string Name { get; set; }
        public string Iban { get; set; }
        public double CurrentBalance { get; set; }
        public string Note { get; set; }
        public bool IsOverdrawn { get; set; }
    }
}