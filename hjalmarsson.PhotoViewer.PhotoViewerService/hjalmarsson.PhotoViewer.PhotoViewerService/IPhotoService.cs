using hjalmarsson.PhotoViewer.PhotoViewerService.Entity;
using System.ServiceModel;

namespace hjalmarsson.PhotoViewer.PhotoViewerService
{
    [ServiceContract]
    public interface IPhotoService
    {

        //[OperationContract]
        //List<Photo> GetAllPhotos();

        [OperationContract]
        Photo[] GetRandomPhotos();

    }
}
