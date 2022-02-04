using PracaInzynierska.Application.DTO.Author;
using PracaInzynierskaAPI.Entities.Author;
using System.Collections.Generic;

namespace PracaInzynierska.Application.Mapper.AuthorsMapper
{
    public static class AuthorMapper
    {
        public static AuthorDTO AuthorToDTO(AuthorDbModel author)
        {
            if (author != null)
            {
                var authorDTO = new AuthorDTO
                {
                    Id = author.Id,
                    IsBuildIn = author.IsBuildIn,
                    CreatedAt = author.CreatedAt,
                    IsModified = author.IsModified,
                    LastModifiedAt = author.LastModifiedAt,
                    IsDeleted = author.IsDeleted,
                    DeletedAt = author.DeletedAt,
                    Surname = author.Surname,
                    Name = author.Name,
                    SecondName = author.SecondName,
                    Biography = author.Biography,
                    BirthDate = author.BirthDate,
                    DeathDate = author.DeathDate,
                    IsApproved = author.IsApproved,
                    AddedBy = author.AddedBy
                };
                return authorDTO;
            }
            else
            {
                return null;
            }
            
            
        }

        public static AuthorDbModel AuthorToDbModel(AuthorDTO author)
        {
            var authorDbModel = new AuthorDbModel
            {
                Id = author.Id,
                IsBuildIn = author.IsBuildIn,
                CreatedAt = author.CreatedAt,
                IsModified = author.IsModified,
                LastModifiedAt = author.LastModifiedAt,
                IsDeleted = author.IsDeleted,
                DeletedAt = author.DeletedAt,
                Surname = author.Surname,
                Name = author.Name,
                SecondName = author.SecondName,
                Biography = author.Biography,
                BirthDate = author.BirthDate,
                DeathDate = author.DeathDate,
                IsApproved = author.IsApproved,
                AddedBy = author.AddedBy
            };
            return authorDbModel;
        }

        public static List<AuthorDTO> AuthorsToDTO(List<AuthorDbModel> authors)
        {
            var list = new List<AuthorDTO>();
            var author = new AuthorDTO();

            foreach(var item in authors)
            {
                author = AuthorToDTO(item);
                list.Add(author);
            }

            return list;
        }

        public static List<AuthorDbModel> AuthorsToDbModel(List<AuthorDTO> authors)
        {
            var list = new List<AuthorDbModel>();
            var author = new AuthorDbModel();

            foreach (var item in authors)
            {
                author = AuthorToDbModel(item);
                list.Add(author);
            }

            return list;
        }
    }
}
