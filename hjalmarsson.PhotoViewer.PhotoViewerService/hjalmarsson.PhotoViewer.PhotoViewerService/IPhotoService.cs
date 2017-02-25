using hjalmarsson.PhotoViewer.PhotoViewerService.Entity;
using System.Collections.Generic;
using System.ServiceModel;

namespace hjalmarsson.PhotoViewer.PhotoViewerService
{
    [ServiceContract]
    public interface IPhotoService
    {

        [OperationContract]
        List<Photo> GetPhotos();
    }
}
