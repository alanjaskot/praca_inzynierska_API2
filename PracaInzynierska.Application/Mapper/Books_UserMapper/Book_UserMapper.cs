using PracaInzynierska.Application.DTO.Book_User;
using PracaInzynierskaAPI.Entities.Book_User;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracaInzynierska.Application.Mapper.Books_UserMapper
{
    public static class Book_UserMapper
    {
        public static Book_UserDbModel Book_UserToDbModel(Book_UserDTO bookUser)
        {
            var bookUserDbModel = new Book_UserDbModel
            {
                Id = bookUser.Id,
                IsBuildIn = bookUser.IsBuildIn,
                CreatedAt = bookUser.CreatedAt,
                IsModified = bookUser.IsModified,
                LastModifiedAt = bookUser.LastModifiedAt,
                IsDeleted = bookUser.IsDeleted,
                DeletedAt = bookUser.DeletedAt,
                BookId = bookUser.BookId,
                UserId = bookUser.UserId
            };

            return bookUserDbModel;
        }
    }
}
