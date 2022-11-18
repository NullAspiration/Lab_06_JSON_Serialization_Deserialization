using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_06_JSON_Serialization_Deserialization.Models
{
    public class Book
    {
        public Items[] Items { get; set; }

        public Book(Items[] items   )
        {
            Items = items;
        }

        public override string ToString()
        {
            string bookString = "";
            return bookString;
        }
    }
}
