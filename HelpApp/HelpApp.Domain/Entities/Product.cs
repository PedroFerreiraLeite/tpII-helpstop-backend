using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace HelpApp.Domain.Entities
{
    public class Product
    {
        #region atributos
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public int Stock {  get; set; }
        public string Iamge {  get; set; }
        public int CategoryId { get; set; }

        #region construtores
        public Product(string name, string description, decimal price, int stock, string iamge)
        {
            Name = name;
            Description = description;
            Price = price;
            Stock = stock;
            Iamge = iamge;
        }
        public Category Category { get; set; }
    }
}
