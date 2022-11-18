using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_06_JSON_Serialization_Deserialization.Models
{
    public class VolumeInfo
    {
        public string Title { get; set; }
        public string[] Authors { get; set; }
        public string Description { get; set; }


        public VolumeInfo(string title, string[] authors, string description)
        { 
            Title = title;
            Authors = authors;
            Description = description;
        }
    }
}
