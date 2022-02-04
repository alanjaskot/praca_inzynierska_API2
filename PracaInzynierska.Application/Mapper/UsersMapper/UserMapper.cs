using PracaInzynierska.Application.DTO.User;
using PracaInzynierskaAPI.Entities.User;


namespace PracaInzynierska.Application.Mapper.UsersMapper
{
    public static class UserMapper
    {
        public static UserDTO UserToDTO(UserDbModel user)
        {
            var userDTO = new UserDTO
            {
                Id = user.Id,
                IsBuildIn = user.IsBuildIn,
                CreatedAt = user.CreatedAt,
                IsModified = user.IsModified,
                LastModifiedAt = user.LastModifiedAt,
                IsDeleted = user.IsDeleted,
                DeletedAt = user.DeletedAt,
                UserName = user.UserName,
                Password = user.Password,
                Email = user.Email,
                Likes = user.Likes,
                NumberOfBooks = user.NumberOfBooks,
                NumberOfComments = user.NumberOfComments,
                Name = user.Name,
                Surname = user.Surname,
                Sex = user.Sex,
                Banned = user.Banned,
                Level = user.Level
            };

            return userDTO;
        }

        public static UserDbModel UserToDbModel(UserDTO user)
        {
            var userDbModel = new UserDbModel
            {
                Id = user.Id,
                IsBuildIn = user.IsBuildIn,
                CreatedAt = user.CreatedAt,
                IsModified = user.IsModified,
                LastModifiedAt = user.LastModifiedAt,
                IsDeleted = user.IsDeleted,
                DeletedAt = user.DeletedAt,
                UserName = user.UserName,
                Password = user.Password,
                Email = user.Email,
                Likes = user.Likes,
                NumberOfBooks = user.NumberOfBooks,
                NumberOfComments = user.NumberOfComments,
                Name = user.Name,
                Surname = user.Surname,
                Sex = user.Sex,
                Banned = user.Banned,
            };

            return userDbModel;
        }
    }
}
