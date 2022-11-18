using ConsoleTables;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace Lab_06_JSON_Serialization_Deserialization.Models
{
    public class Book
    {
        public Items[] Items { get; set; }

        public Book(Items[] items)
        {
            Items = items;
        }
        public override string ToString()
        {
            Console.WriteLine("---------------------------------------------------------------------------------------------------------------");
            string bookString = "";
            bookString += $"\n\tTitle: {Items[0].VolumeInfo.Title}\n";
            bookString += $"\tAuthors: {Items[0].VolumeInfo.Authors[0]}\n";
            if (Items[0].VolumeInfo.Description != null)
            {
                bookString += $"\n\tDescription: {Items[0].VolumeInfo.Description}\n\n";
                bookString += $"\tID: {Items[0].Id}]\n";
                bookString += $"\tSelfLink: {Items[0].SelfLink}\n";
            }
            else
            {
                bookString += $"\n\tDescription: N/A\n\t[This request did not return a Description as the Description does not exist.\n\tThis is not an error only to show that handling of null values is working as intended.]\n\n";
                bookString += $"\tID: {Items[0].Id}\n";
                bookString += $"\tSelfLink: {Items[0].SelfLink}\n";
            }
            return bookString;
        }
    }
}
