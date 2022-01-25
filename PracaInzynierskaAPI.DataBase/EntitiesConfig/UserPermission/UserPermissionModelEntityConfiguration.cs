using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PracaInzynierskaAPI.Entities.UserPermission;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracaInzynierskaAPI.DataBase.EntitiesConfig.UserPermission
{
    public class UserPermissionModelEntityConfiguration : IEntityTypeConfiguration<UserPermissionDbModel>
    {
        public void Configure(EntityTypeBuilder<UserPermissionDbModel> builder)
        {
            builder.HasIndex(up => up.PermissionName);
            builder.Property(up => up.Id).IsRequired(true);
            builder.Property(up => up.CreatedAt).IsRequired(true);

            builder.HasData(
            new UserPermissionDbModel
            {
                Id = Guid.Parse("76a4ef96-9f1b-4c7f-9c3f-2daa9ed9401b"),
                IsBuildIn = true,
                CreatedAt = DateTime.Now,
                PermissionName = "Author.Approve",
                UserId = Guid.Parse("bcad5300-ef78-4e65-9240-d3609cc88176")
             },
            new UserPermissionDbModel
            {
                Id = Guid.Parse("3f34777b-8a49-496c-9dc8-8f13f6a512da"),
                IsBuildIn = true,
                CreatedAt = DateTime.Now,
                PermissionName = "Author.Update",
                UserId = Guid.Parse("bcad5300-ef78-4e65-9240-d3609cc88176")
            },
            new UserPermissionDbModel
            {
                Id = Guid.Parse("d998336a-005e-4016-b72c-2c01532a5d28"),
                IsBuildIn = true,
                CreatedAt = DateTime.Now,
                PermissionName = "Author.SoftDelete",
                UserId = Guid.Parse("bcad5300-ef78-4e65-9240-d3609cc88176")
            },
            new UserPermissionDbModel
            {
                Id = Guid.Parse("6e6df870-d6dd-4434-80b8-884a6624eae7"),
                IsBuildIn = true,
                CreatedAt = DateTime.Now,
                PermissionName = "Author.Delete",
                UserId = Guid.Parse("bcad5300-ef78-4e65-9240-d3609cc88176")
            },
            new UserPermissionDbModel
            {
                Id = Guid.Parse("43b1e7bb-1d6f-407c-82f5-ec17637e7aad"),
                IsBuildIn = true,
                CreatedAt = DateTime.Now,
                PermissionName = "Book.Approve",
                UserId = Guid.Parse("bcad5300-ef78-4e65-9240-d3609cc88176")
            },
            new UserPermissionDbModel
            {
                Id = Guid.Parse("823bf0ff-0179-4f6d-a485-e93c9523d700"),
                IsBuildIn = true,
                CreatedAt = DateTime.Now,
                PermissionName = "Book.Update",
                UserId = Guid.Parse("bcad5300-ef78-4e65-9240-d3609cc88176")
            },
            new UserPermissionDbModel
            {
                Id = Guid.Parse("108ebc86-ceb8-4357-87f6-0b82485a389d"),
                IsBuildIn = true,
                CreatedAt = DateTime.Now,
                PermissionName = "Book.SoftDelete",
                UserId = Guid.Parse("bcad5300-ef78-4e65-9240-d3609cc88176")
            },
            new UserPermissionDbModel
            {
                Id = Guid.Parse("cf69651e-3bb1-49eb-b1ed-a3bb453ba954"),
                IsBuildIn = true,
                CreatedAt = DateTime.Now,
                PermissionName = "Book.Delete",
                UserId = Guid.Parse("bcad5300-ef78-4e65-9240-d3609cc88176")
            },
            new UserPermissionDbModel
            {
                Id = Guid.Parse("613750bc-e471-4b28-be60-fd538a802f1e"),
                IsBuildIn = true,
                CreatedAt = DateTime.Now,
                PermissionName = "Category.Write",
                UserId = Guid.Parse("bcad5300-ef78-4e65-9240-d3609cc88176")
            },
            new UserPermissionDbModel
            {
                Id = Guid.Parse("24758f53-051b-4ba1-bea1-317d76c08558"),
                IsBuildIn = true,
                CreatedAt = DateTime.Now,
                PermissionName = "Category.Update",
                UserId = Guid.Parse("bcad5300-ef78-4e65-9240-d3609cc88176")
            },
            new UserPermissionDbModel
            {
                Id = Guid.Parse("1255c632-24c3-4091-b043-72d94c174db8"),
                IsBuildIn = true,
                CreatedAt = DateTime.Now,
                PermissionName = "Category.SoftDelete",
                UserId = Guid.Parse("bcad5300-ef78-4e65-9240-d3609cc88176")
            },
            new UserPermissionDbModel
            {
                Id = Guid.Parse("7b073c81-8bcd-4a93-96e3-8ef64b87960b"),
                IsBuildIn = true,
                CreatedAt = DateTime.Now,
                PermissionName = "Category.Delete",
                UserId = Guid.Parse("bcad5300-ef78-4e65-9240-d3609cc88176")
            },
            new UserPermissionDbModel
            {
                Id = Guid.Parse("0babc995-ad56-44e2-a92b-ca225f80ae40"),
                IsBuildIn = true,
                CreatedAt = DateTime.Now,
                PermissionName = "Comment.SoftDelete",
                UserId = Guid.Parse("bcad5300-ef78-4e65-9240-d3609cc88176")
            },
            new UserPermissionDbModel
            {
                Id = Guid.Parse("77a822b5-2211-4eaa-abef-e28cff58a096"),
                IsBuildIn = true,
                CreatedAt = DateTime.Now,
                PermissionName = "ImageCover.Update",
                UserId = Guid.Parse("bcad5300-ef78-4e65-9240-d3609cc88176")
            },
            new UserPermissionDbModel
            {
                Id = Guid.Parse("08c5d55a-1784-4806-8656-1e13d8c2c61d"),
                IsBuildIn = true,
                CreatedAt = DateTime.Now,
                PermissionName = "ImagCover.Delete",
                UserId = Guid.Parse("bcad5300-ef78-4e65-9240-d3609cc88176")
            },
            new UserPermissionDbModel
            {
                Id = Guid.Parse("e0f6bc31-eb25-4dbc-9af5-af200709088e"),
                IsBuildIn = true,
                CreatedAt = DateTime.Now,
                PermissionName = "Language.Write",
                UserId = Guid.Parse("bcad5300-ef78-4e65-9240-d3609cc88176")
            },
            new UserPermissionDbModel
            {
                Id = Guid.Parse("438d0327-21c7-4920-887c-de5e24e1efd2"),
                IsBuildIn = true,
                CreatedAt = DateTime.Now,
                PermissionName = "Language.Update",
                UserId = Guid.Parse("bcad5300-ef78-4e65-9240-d3609cc88176")
            },
            new UserPermissionDbModel
            {
                Id = Guid.Parse("e319013c-ac3f-45d4-b1c0-d23be2664028"),
                IsBuildIn = true,
                CreatedAt = DateTime.Now,
                PermissionName = "Language.SoftDelete",
                UserId = Guid.Parse("bcad5300-ef78-4e65-9240-d3609cc88176")
            },
            new UserPermissionDbModel
            {
                Id = Guid.Parse("7b8591d9-aa83-4ff6-8a68-5c8ca41b253f"),
                IsBuildIn = true,
                CreatedAt = DateTime.Now,
                PermissionName = "NLogs.Read",
                UserId = Guid.Parse("bcad5300-ef78-4e65-9240-d3609cc88176")
            },
            new UserPermissionDbModel
            {
                Id = Guid.Parse("00268e14-83df-4882-ba68-1089579eed8a"),
                IsBuildIn = true,
                CreatedAt = DateTime.Now,
                PermissionName = "Publisher.Write",
                UserId = Guid.Parse("bcad5300-ef78-4e65-9240-d3609cc88176")
            },
            new UserPermissionDbModel
            {
                Id = Guid.Parse("1e7d8ef5-3d1d-44bd-b58f-204de558d72d"),
                IsBuildIn = true,
                CreatedAt = DateTime.Now,
                PermissionName = "Publisher.Update",
                UserId = Guid.Parse("bcad5300-ef78-4e65-9240-d3609cc88176")
            },
            new UserPermissionDbModel
            {
                Id = Guid.Parse("bc6cd79c-64c5-4bec-b5aa-e2240a0f7cf4"),
                IsBuildIn = true,
                CreatedAt = DateTime.Now,
                PermissionName = "Publisher.SoftDelete",
                UserId = Guid.Parse("bcad5300-ef78-4e65-9240-d3609cc88176")
            },
            new UserPermissionDbModel
            {
                Id = Guid.Parse("d9447300-3048-4e21-bb29-4d943881554c"),
                IsBuildIn = true,
                CreatedAt = DateTime.Now,
                PermissionName = "User.Delete",
                UserId = Guid.Parse("bcad5300-ef78-4e65-9240-d3609cc88176")
            },
            new UserPermissionDbModel
            {
                Id = Guid.Parse("c3d979d6-4c97-4ff4-ae14-8319388c90ed"),
                IsBuildIn = true,
                CreatedAt = DateTime.Now,
                PermissionName = "UserPermission.Write",
                UserId = Guid.Parse("bcad5300-ef78-4e65-9240-d3609cc88176")
            },
            new UserPermissionDbModel
            {
                Id = Guid.Parse("23049d10-dfea-458d-b285-3a78f6cf28d9"),
                IsBuildIn = true,
                CreatedAt = DateTime.Now,
                PermissionName = "UserPermission.Update",
                UserId = Guid.Parse("bcad5300-ef78-4e65-9240-d3609cc88176")
            },
            new UserPermissionDbModel
            {
                Id = Guid.Parse("78273246-91e9-497e-9823-7948777ddd08"),
                IsBuildIn = true,
                CreatedAt = DateTime.Now,
                PermissionName = "UserPermission.Delete",
                UserId = Guid.Parse("bcad5300-ef78-4e65-9240-d3609cc88176")
            });
        }
    }
}
