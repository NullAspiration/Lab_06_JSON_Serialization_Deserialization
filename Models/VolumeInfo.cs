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
