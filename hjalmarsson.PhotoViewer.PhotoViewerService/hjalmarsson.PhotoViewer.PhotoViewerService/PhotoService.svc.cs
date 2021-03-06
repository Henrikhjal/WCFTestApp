﻿using hjalmarsson.PhotoViewer.PhotoViewerService.Entity;
using System.Collections.Generic;

namespace hjalmarsson.PhotoViewer.PhotoViewerService
{
    public class PhotoService : IPhotoService
    {
        Repository.Repository repository = new Repository.Repository();

        List<Photo> IPhotoService.GetRandomPhotos()
        {
            return repository.GetRandomPhotos();
        }
    }
}
