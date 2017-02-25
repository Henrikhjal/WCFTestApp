using hjalmarsson.PhotoViewer.PhotoViewerService.Entity;
using System.Collections.Generic;

namespace hjalmarsson.PhotoViewer.PhotoViewerService
{
    public class PhotoService : IPhotoService
    {
        Repository.Repository repository = new Repository.Repository();
        public List<Photo> GetAllPhotos()
        {

            return repository.GetAllPhotos();
        }

        public Photo[] GetRandomPhotos()
        {
            return repository.GetRandomPhotos();
        }
    }
}
