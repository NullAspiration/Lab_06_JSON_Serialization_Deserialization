using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_06_JSON_Serialization_Deserialization.Models
{
    public class Book
    {
        public string Id { get; set; }
        public string Selflink { get; set; }
        public string Title { get; set; }
        public string Authors { get; set; }
        public string Description { get; set; }

        public Book(string id, string selfLink, string title, string authors, string description)
        {
     
            Id = id;
            Selflink = selfLink;
            Title = title;
            Authors = authors;
            Description = description;
        }

        public override string ToString()
        {
            string itemString = "";
            itemString += $"ID: {Id}\n";
            itemString += $"SelfLink: {Selflink}\n";
            itemString += $"Title: {Title}\n";
            itemString += $"Authors: {Authors}\n";
            itemString += $"Description: {Description}\n";

            return itemString;
        }
    }
}
