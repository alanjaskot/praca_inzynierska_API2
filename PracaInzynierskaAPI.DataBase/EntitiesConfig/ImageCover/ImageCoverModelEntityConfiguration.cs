using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PracaInzynierskaAPI.Entities.ImageCover;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracaInzynierskaAPI.DataBase.EntitiesConfig.ImageCover
{
    public class ImageCoverModelEntityConfiguration : IEntityTypeConfiguration<ImageCoverDbModel>
    {
        public void Configure(EntityTypeBuilder<ImageCoverDbModel> builder)
        {
            builder.Property(ic => ic.FileName).IsRequired(true);
            builder.Property(ic => ic.FilePath).IsRequired(true);
            builder.Property(ic => ic.FileExtension).IsRequired(true);
        }
    }
}
