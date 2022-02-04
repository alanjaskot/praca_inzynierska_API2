using PracaInzynierska.Application.DTO.ImageCover;
using PracaInzynierskaAPI.Entities.ImageCover;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracaInzynierska.Application.Mapper.ImageCoversMapper
{
    public static class ImageCoverMapper
    {
        public static ImageCoverDTO ImageCoverToDTO(ImageCoverDbModel imageCover)
        {
            var imageCoverDTO = new ImageCoverDTO
            {
                Id = imageCover.Id,
                IsBuildIn = imageCover.IsBuildIn,
                CreatedAt = imageCover.CreatedAt,
                IsModified = imageCover.IsModified,
                LastModifiedAt = imageCover.LastModifiedAt,
                IsDeleted = imageCover.IsDeleted,
                DeletedAt = imageCover.DeletedAt,
                FileName = imageCover.FileName,
                FilePath = imageCover.FilePath,
                FileExtension = imageCover.FileExtension
            };

            return imageCoverDTO;
        }

        public static ImageCoverDbModel ImageCoverToDbModel(ImageCoverDTO imageCover)
        {
            var imageCoverDbModel = new ImageCoverDbModel
            {
                Id = imageCover.Id,
                IsBuildIn = imageCover.IsBuildIn,
                CreatedAt = imageCover.CreatedAt,
                IsModified = imageCover.IsModified,
                LastModifiedAt = imageCover.LastModifiedAt,
                IsDeleted = imageCover.IsDeleted,
                DeletedAt = imageCover.DeletedAt,
                FileName = imageCover.FileName,
                FilePath = imageCover.FilePath,
                FileExtension = imageCover.FileExtension
            };

            return imageCoverDbModel;
        }
    }
}
