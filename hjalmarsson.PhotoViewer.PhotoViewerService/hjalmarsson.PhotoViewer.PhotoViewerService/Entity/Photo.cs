using System.Runtime.Serialization;

namespace hjalmarsson.PhotoViewer.PhotoViewerService.Entity
{
    [DataContract]
    public class Photo
    {
        [DataMember]
        public string Url { get; set; }
        [DataMember]
        public string Comment { get; set; }
    }
}