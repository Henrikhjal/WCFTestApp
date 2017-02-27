using hjalmarsson.PhotoViewer.PhotoViewerService.Entity;
using System;
using System.Collections.Generic;


namespace hjalmarsson.PhotoViewer.PhotoViewerService.Repository
{
    public class Repository
    {
        public static List<Photo> photos = new List<Photo>();

        private List<Photo> GetAllPhotos()
        {

            if (photos.Count == 0)
            {

                Photo photo = new Photo { Url = "https://farm6.staticflickr.com/5514/10492931026_6fc1e2b318_c.jpg", Comment = "En fin blomma" };
                photos.Add(photo);

                photo = new Photo { Url = "https://farm1.staticflickr.com/86/244452541_98e41ed94d_c.jpg", Comment = "Trisse" };
                photos.Add(photo);

                photo = new Photo { Url = "https://farm1.staticflickr.com/166/358537978_7f933dcdfa_c.jpg", Comment = "En tjusig tulpan" };
                photos.Add(photo);

                photo = new Photo { Url = "https://farm2.staticflickr.com/1657/23566850883_bccd2f81a9_c.jpg", Comment = "Långsjön i dimma" };
                photos.Add(photo);

                photo = new Photo { Url = "https://farm5.staticflickr.com/4080/4772759224_b620c6968a_c.jpg", Comment = "The Mood" };
                photos.Add(photo);

                photo = new Photo { Url = "https://farm1.staticflickr.com/30/35459054_8432824293_c.jpg", Comment = "Atlantic Ocean" };
                photos.Add(photo);

                photo = new Photo { Url = "https://farm4.staticflickr.com/3843/14894599303_6ff4829633_c.jpg", Comment = "Vallmos" };
                photos.Add(photo);

            }
            return photos;
        }

        //public Photo[] GetRandomPhotos()
        public List<Photo> GetRandomPhotos()
        {
            Random r = new Random();
            Random rr = new Random();
            int inx;
            List<Photo> photoCol = new List<Photo>();

            if (photos.Count == 0)
            {
                GetAllPhotos();
            }

            int antal = r.Next(1, photos.Count);
            var randomPhotos = new Photo[antal];

            for (int i = 0; i < antal; i++)
            {
                inx = rr.Next(0, photos.Count);
                randomPhotos[i] = photos[inx];
                photoCol.Add(photos[inx]);
            }
            return photoCol;
        }
    }
}