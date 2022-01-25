using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PracaInzynierskaAPI.Entities.User;
using System;

namespace PracaInzynierskaAPI.DataBase.EntitiesConfig.User
{
    public class UserModelEntityConfiguration : IEntityTypeConfiguration<UserDbModel>
    {
        public void Configure(EntityTypeBuilder<UserDbModel> builder)
        {
            builder.HasIndex(u => new { u.Id }).IsUnique(true);
            builder.HasIndex(u => new { u.UserName }).IsUnique(true);
            builder.HasIndex(u => new { u.Email }).IsUnique(true);
            builder.HasIndex(u => new { u.Id, u.UserName, u.Email }).IsUnique(true);

            builder.Property(u => u.Id).IsRequired(true);
            builder.Property(u => u.CreatedAt).IsRequired(true);

            builder.HasData(new UserDbModel
            {
                Id = Guid.Parse("bcad5300-ef78-4e65-9240-d3609cc88176"),
                IsBuildIn = true,
                CreatedAt = DateTime.Now,
                UserName = "Admin",
                Password = "123",
                Likes = 0,
                NumberOfBooks = 0,
                NumberOfComments = 0
            });
        }
    }
}
