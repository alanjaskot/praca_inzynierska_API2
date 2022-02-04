using PracaInzynierska.Application.DTO.Book;
using PracaInzynierskaAPI.Entities.Book;
using System.Collections.Generic;


namespace PracaInzynierska.Application.Mapper.BooksMapper
{
    public static class BookMapper
    {
        public static BookDTO BookToDTO(BookDbModel book)
        {
            var bookDTO = new BookDTO
            {
                Id = book.Id,
                IsBuildIn = book.IsBuildIn,
                CreatedAt = book.CreatedAt,
                IsModified = book.IsModified,
                LastModifiedAt = book.LastModifiedAt,
                IsDeleted = book.IsDeleted,
                DeletedAt = book.DeletedAt,
                Title = book.Title,
                ISBN = book.ISBN,
                PublishedYear = book.PublishedYear,
                Description = book.Description,
                Likes = book.Likes,
                Dislikes = book.Dislikes,
                LikesPercentage = book.LikesPercentage,
                Approved = book.Approved,
                Subtitle = book.Subtitle,
                Series = book.Series,
                Pages = book.Pages,
                CreatedBy = book.CreatedBy,
                CategoryId = book.CategoryId,
                LanguageId = book.LanguageId,
                PublisherId = book.PublisherId,
                ImageCoverId = book.ImageCoverId
            };

            return bookDTO;
        }

        public static BookDbModel BookToDbModel(BookDTO book)
        {
            var bookDbModel = new BookDbModel
            {
                Id = book.Id,
                IsBuildIn = book.IsBuildIn,
                CreatedAt = book.CreatedAt,
                IsModified = book.IsModified,
                LastModifiedAt = book.LastModifiedAt,
                IsDeleted = book.IsDeleted,
                DeletedAt = book.DeletedAt,
                Title = book.Title,
                ISBN = book.ISBN,
                PublishedYear = book.PublishedYear,
                Description = book.Description,
                Likes = book.Likes,
                Dislikes = book.Dislikes,
                Approved = book.Approved,
                Subtitle = book.Subtitle,
                Series = book.Series,
                Pages = book.Pages,
                CreatedBy = book.CreatedBy,
                CategoryId = book.CategoryId,
                LanguageId = book.LanguageId,
                PublisherId = book.PublisherId,
                ImageCoverId = book.ImageCoverId
            };

            return bookDbModel;
        }

        public static List<BookDbModel> BooksToDbModel(List<BookDTO> books)
        {
            var list = new List<BookDbModel>();
            var book = new BookDbModel();

            foreach (var item in books)
            {
                book = BookToDbModel(item);
                list.Add(book);
            }

            return list;
        }
        public static List<BookDTO> BooksToDTO(List<BookDbModel> books)
        {
            var list = new List<BookDTO>();
            var book = new BookDTO();
            
            foreach(var item in books)
            {
                book = BookToDTO(item);
                list.Add(book);
            }

            return list;
        }
    }
}
