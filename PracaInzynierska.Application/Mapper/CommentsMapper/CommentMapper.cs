using PracaInzynierska.Application.DTO.Comment;
using PracaInzynierskaAPI.Entities.Comment;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracaInzynierska.Application.Mapper.CommentsMapper
{
    public static class CommentMapper
    {
        public static CommentDTO CommentToDTO(CommentDbModel comment)
        {
            var commentDTO = new CommentDTO
            {
                Id = comment.Id,
                IsBuildIn = comment.IsBuildIn,
                CreatedAt = comment.CreatedAt,
                IsModified = comment.IsModified,
                LastModifiedAt = comment.LastModifiedAt,
                IsDeleted = comment.IsDeleted,
                DeletedAt = comment.DeletedAt,
                Comment = comment.Comment,
                AddedBy = comment.AddedBy,
                CommentId = comment.CommentId,
                BookId = comment.BookId
            };

            return commentDTO;
        }

        public static List<CommentDTO> CommentsToDTO(List<CommentDbModel> comments)
        {
            var list = new List<CommentDTO>();
            var commentDTO = new CommentDTO();

            foreach(var item in comments)
            {
                commentDTO = CommentToDTO(item);
                list.Add(commentDTO);
            }

            return list;
        }

        public static CommentDbModel CommentToDbModel(CommentDTO comment)
        {
            var commentDbModel = new CommentDbModel
            {
                Id = comment.Id,
                IsBuildIn = comment.IsBuildIn,
                CreatedAt = comment.CreatedAt,
                IsModified = comment.IsModified,
                LastModifiedAt = comment.LastModifiedAt,
                IsDeleted = comment.IsDeleted,
                DeletedAt = comment.DeletedAt,
                Comment = comment.Comment,
                AddedBy = comment.AddedBy,
                CommentId = comment.CommentId,
                BookId = comment.BookId
            };

            return commentDbModel;
        }
    }
}
