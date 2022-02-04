using PracaInzynierska.Application.DTO.User;
using PracaInzynierskaAPI.Entities.User;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracaInzynierska.Application.Mapper.UsersMapper
{
    public static class UserInfoMapper
    {
        public static UserInfoDTO UserInfoToDTO(UserDbModel user)
        {
            var userInfoDTO = new UserInfoDTO
            {
                Id = user.Id,
                IsBuildIn = user.IsBuildIn,
                CreatedAt = user.CreatedAt,
                IsModified = user.IsModified,
                LastModifiedAt = user.LastModifiedAt,
                IsDeleted = user.IsDeleted,
                DeletedAt = user.DeletedAt,
                UserName = user.UserName,
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
            return userInfoDTO;
        }

        public static List<UserInfoDTO> UsersInfoToDTO(List<UserDbModel> users)
        {
            var list = new List<UserInfoDTO>();
            var userInfoDTO = new UserInfoDTO();

            foreach(var item in users)
            {
                userInfoDTO = UserInfoToDTO(item);
                list.Add(userInfoDTO);
            }

            return list;
        }
    }
}
