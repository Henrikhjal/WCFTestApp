using hjalmarsson.PhotoViewer.PhotoViewerService.Entity;

namespace hjalmarsson.PhotoViewer.PhotoViewerService
{
    public class PhotoService : IPhotoService
    {
        Repository.Repository repository = new Repository.Repository();
        //public List<Photo> GetAllPhotos()
        //{

        //    return repository.GetAllPhotos();
        //}

        public Photo[] GetRandomPhotos()
        {
            return repository.GetRandomPhotos();
        }
    }
}
