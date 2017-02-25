using hjalmarsson.PhotoViewer.PhotoViewerService.Entity;
using System.Collections.Generic;


namespace hjalmarsson.PhotoViewer.PhotoViewerService.Repository
{
    public class Repository
    {
        public List<Photo> GetAllPhotos()
        {
            List<Photo> photos = new List<Photo>();

            if (photos.Count == 0)
            {
                Photo photo = new Photo { Url = "https://s3.amazonaws.com/bestworkplacesdb/listlogos/2016_swe_bwp_sv.png", Comment = "Great place to work" };
                photos.Add(photo);


                photo = new Photo { Url = "http://www.idg.se/polopoly_fs/1.366965!teaserImage/imageTypeSelector/localImage/2465116442.jpg", Comment = "Jonna" };
                photos.Add(photo);

            }
            return photos;
        }
    }
}