using PracaInzynierska.Application.DTO.UserPermission;
using PracaInzynierskaAPI.Entities.UserPermission;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracaInzynierska.Application.Mapper.UserPermissionsMapper
{
    public static class UserPermissionMapper
    {
        public static UserPermissionDTO UserPermissionToDTO(UserPermissionDbModel userPermission)
        {
            var userPermissionDTO = new UserPermissionDTO
            {
                Id = userPermission.Id,
                IsBuildIn = userPermission.IsBuildIn,
                CreatedAt = userPermission.CreatedAt,
                IsModified = userPermission.IsModified,
                LastModifiedAt = userPermission.LastModifiedAt,
                IsDeleted = userPermission.IsDeleted,
                DeletedAt = userPermission.DeletedAt,
                PermissionName = userPermission.PermissionName,
                UserId = userPermission.UserId
            };
            return userPermissionDTO;
        }

        public static List<UserPermissionDTO> UserPermissionsToDTO(List<UserPermissionDbModel> permissions)
        {
            var list = new List<UserPermissionDTO>();
            var userPermissionDTO = new UserPermissionDTO();

            foreach(var item in permissions)
            {
                userPermissionDTO = UserPermissionToDTO(item);
                list.Add(userPermissionDTO);
            }

            return list;
        }

        public static UserPermissionDbModel UserPermissionToDbModel(UserPermissionDTO userPermission)
        {
            var userPermissionDbModel = new UserPermissionDbModel
            {
                Id = userPermission.Id,
                IsBuildIn = userPermission.IsBuildIn,
                CreatedAt = userPermission.CreatedAt,
                IsModified = userPermission.IsModified,
                LastModifiedAt = userPermission.LastModifiedAt,
                IsDeleted = userPermission.IsDeleted,
                DeletedAt = userPermission.DeletedAt,
                PermissionName = userPermission.PermissionName,
                UserId = userPermission.UserId
            };
            return userPermissionDbModel;
        }

        public static List<UserPermissionDbModel> UserPermissionsToDbModel(List<UserPermissionDTO> permissions)
        {
            var list = new List<UserPermissionDbModel>();
            var userPermissionDbModel = new UserPermissionDbModel();

            foreach(var item in permissions)
            {
                userPermissionDbModel = UserPermissionToDbModel(item);
                list.Add(userPermissionDbModel);
            }

            return list;
        }
    }
}
