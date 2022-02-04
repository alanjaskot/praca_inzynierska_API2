using PracaInzynierska.Application.DTO.Book_Author;
using PracaInzynierskaAPI.Entities.Book_Author;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracaInzynierska.Application.Mapper.Books_AuthorMapper
{
    public static class Book_AuthorMapper
    {
        public static Book_AuthorDTO Book_AuthorToDTO(Book_AuthorDbModel bookAuthor)
        {
            var bookAuthorDTO = new Book_AuthorDTO()
            {
                Id = bookAuthor.Id,
                IsBuildIn = bookAuthor.IsBuildIn,
                CreatedAt = bookAuthor.CreatedAt,
                IsModified = bookAuthor.IsModified,
                LastModifiedAt = bookAuthor.LastModifiedAt,
                IsDeleted = bookAuthor.IsDeleted,
                AuthorId = bookAuthor.AuthorId,
                BookId = bookAuthor.BookId
            };

            return bookAuthorDTO;
        }

        public static List<Book_AuthorDTO> Books_AuthorToDTO(List<Book_AuthorDbModel> books)
        {
            var list = new List<Book_AuthorDTO>();
            var bookAuthorDTO = new Book_AuthorDTO();

            foreach(var item in books)
            {
                bookAuthorDTO = Book_AuthorToDTO(item);
                list.Add(bookAuthorDTO);
            }

            return list;
        }

        public static Book_AuthorDbModel Book_AuthorToDbModel(Book_AuthorDTO bookAuthor)
        {
            var bookAuthorDbModel = new Book_AuthorDbModel()
            {
                Id = bookAuthor.Id,
                IsBuildIn = bookAuthor.IsBuildIn,
                CreatedAt = bookAuthor.CreatedAt,
                IsModified = bookAuthor.IsModified,
                LastModifiedAt = bookAuthor.LastModifiedAt,
                IsDeleted = bookAuthor.IsDeleted,
                AuthorId = bookAuthor.AuthorId,
                BookId = bookAuthor.BookId
            };

            return bookAuthorDbModel;
        }

        public static List<Book_AuthorDbModel> Books_AuthorToDbModel(List<Book_AuthorDTO> books)
        {
            var list = new List<Book_AuthorDbModel>();
            var bookAuthorDTO = new Book_AuthorDbModel();

            foreach (var item in books)
            {
                bookAuthorDTO = Book_AuthorToDbModel(item);
                list.Add(bookAuthorDTO);
            }

            return list;
        }
    }
}
