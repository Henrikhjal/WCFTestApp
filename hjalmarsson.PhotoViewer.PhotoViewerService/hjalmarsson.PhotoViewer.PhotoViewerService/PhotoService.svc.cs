using hjalmarsson.PhotoViewer.PhotoViewerService.Entity;
using System.Collections.Generic;

namespace hjalmarsson.PhotoViewer.PhotoViewerService
{
    public class PhotoService : IPhotoService
    {
        public List<Photo> GetPhotos()
        {
            var repository = new Repository.Repository();
            return repository.GetAllPhotos();
        }
    }
}
