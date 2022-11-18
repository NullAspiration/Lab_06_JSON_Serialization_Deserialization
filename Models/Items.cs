namespace Lab_06_JSON_Serialization_Deserialization.Models
{
    public class Items
    {
        public string Id { get; set; }
        public string SelfLink { get; set; }
        public VolumeInfo VolumeInfo { get; set; }

        public Items(string id, string selfLink, VolumeInfo volumeInfo)
        {
            Id = id;
            SelfLink = selfLink;
            VolumeInfo = volumeInfo;
        }
    }
}
