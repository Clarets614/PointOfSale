﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace PointOfSale
{
    public class Products
    {
        //properties
        public string Name { get; set; }
        public string Category { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public int Stock { get; set; }

        //constructor 
        public Products(string _name, string _category, string _description, decimal _price, int _stock)
        {
            Name = _name;
            Category = _category;
            Description = _description;
            Price = _price;
            Stock = _stock;
        }

        //methods
        public override string ToString()
        {
            
            return $"{Name,-35}{Description}{Category,-15}{Price,7:C}{Stock,5}\n";
        }

        public static int ReduceStock(int CurrentStock, int Buy)
        {
            int NewStock = CurrentStock - Buy;
            return NewStock;
        }

        public static decimal LineTotal(int qty, decimal price)
        {
           decimal Total = qty* price;

            return Total;
        }

    }
}
