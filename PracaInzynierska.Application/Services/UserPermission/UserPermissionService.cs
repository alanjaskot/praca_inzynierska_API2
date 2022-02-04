﻿using NLog;
using PracaInzynierska.Application.DTO.UserPermission;
using PracaInzynierska.Application.Mapper.UserPermissionsMapper;
using PracaInzynierskaAPI.DataBase.UnitOfWork;
using PracaInzynierskaAPI.Entities.UserPermission;
using PracaInzynierskaAPI.Models.Response;
using System;
using System.Collections.Generic;


namespace PracaInzynierska.Application.Services.UserPermission
{
    public class UserPermissionService: IUserPermissionService
    {
        private readonly IUnitOfWork _unitOfWork;
        private ILogger _logger;

        public UserPermissionService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
            _logger = LogManager.GetCurrentClassLogger();
        }

        public ResponseModel<List<UserPermissionDTO>> GetAllPermissionsByUserGuid(Guid userGuid)
        {
            try
            {
                var repoResponse = _unitOfWork.GetUserPermissionRepository.GetAllByUserGuid(userGuid);
                if (repoResponse.Success)
                    return new ResponseModel<List<UserPermissionDTO>>
                    {
                        Success = repoResponse.Success,
                        Message = repoResponse.Message,
                        Object = UserPermissionMapper.UserPermissionsToDTO(repoResponse.Object)
                    };
                else
                    return new ResponseModel<List<UserPermissionDTO>>
                    {
                        Success = repoResponse.Success,
                        Message = repoResponse.Message
                    };
            }
            catch (Exception err)
            {
                _logger.Error(err, "UserPermissionService.GetAllPermissionsByUserGuid");
                throw;
            }
        }

        public ResponseModel<UserPermissionDTO> GetPermitionByUserGuidAndPermission(Guid userGuid, string permitionName)
        {
            try
            {
                var repoResponse = _unitOfWork.GetUserPermissionRepository.GetByUserGuidAndPermission(userGuid, permitionName);
                if (repoResponse.Success)
                    return new ResponseModel<UserPermissionDTO>
                    {
                        Success = repoResponse.Success,
                        Message = repoResponse.Message,
                        Object = UserPermissionMapper.UserPermissionToDTO(repoResponse.Object)
                    };
                else
                    return new ResponseModel<UserPermissionDTO>
                    {
                        Success = repoResponse.Success,
                        Message = repoResponse.Message
                    };
            }
            catch (Exception err)
            {
                _logger.Error(err, "UserPermissionService.GetPermitionByUserGuidAndPermission");
                throw;
            }
        }

        public ResponseModel<List<Guid>> AddPermissionsByUserGuid(List<UserPermissionDTO> permisions)
        {
            try
            {
                _unitOfWork.BeginTransaction();
                var repoResponse = _unitOfWork.GetUserPermissionRepository.AddAllByUserGuid(UserPermissionMapper.UserPermissionsToDbModel(permisions));
                if (repoResponse.Success)
                {
                    var save = _unitOfWork.Save();
                    if (save > -1)
                    {
                        _unitOfWork.CommitTransaction();
                        return repoResponse;
                    }
                    else
                    {
                        _unitOfWork.RollBackTransaction();
                        return new ResponseModel<List<Guid>>
                        {
                            Success = false,
                            Message = "Nie udało się dodać zakresu uprawnień"
                        };
                    }
                }
                else
                {
                    _unitOfWork.RollBackTransaction();
                    return repoResponse;
                }
            }
            catch (Exception err)
            {
                _unitOfWork.RollBackTransaction();
                _logger.Error(err, "UserPermissionService.AddAllPermissionsByUserGuid");
                throw;
            }
        }

        //public ResponseModel<Guid> UpdatePermitionByUserGuidAndPermission(Guid userGuid, string permitionName)
        //{
        //    try
        //    {
        //        _unitOfWork.BeginTransaction();
        //        var repoRespone = _unitOfWork.GetUserPermissionRepository.UpdateByUserGuidAndPermission(userGuid, permitionName);
        //        {
        //            var save = _unitOfWork.Save();
        //            if (save > -1)
        //            {
        //                _unitOfWork.CommitTransaction();
        //                result = true;
        //            }
        //        }
        //        else
        //            _unitOfWork.RollBackTransaction();
        //    }
        //    catch (Exception err)
        //    {
        //        _unitOfWork.RollBackTransaction();
        //        _logger.Error(err, "UserPermissionService.UpdatePermitionByUserGuidAndPermission");
        //        throw;
        //    }
        //    return result;
        //}

        public ResponseModel<List<Guid>> DeleteAllPermissionsByUserGuid(List<UserPermissionDTO> permisions)
        {
            try
            {
                _unitOfWork.BeginTransaction();
                var repoResponse = _unitOfWork.GetUserPermissionRepository.DeleteAllByUserGuid(UserPermissionMapper.UserPermissionsToDbModel(permisions));
                if (repoResponse.Success)
                {
                    var save = _unitOfWork.Save();
                    if (save > -1)
                    {
                        _unitOfWork.CommitTransaction();
                        return repoResponse;
                    }
                    else
                    {
                        _unitOfWork.RollBackTransaction();
                        return new ResponseModel<List<Guid>>
                        {
                            Success = false,
                            Message = "Nie udało się usunąć zakresu uprawnień"
                        };
                    }
                }
                else
                {
                    _unitOfWork.RollBackTransaction();
                    return repoResponse;
                }
            }
            catch (Exception err)
            {
                _unitOfWork.RollBackTransaction();
                _logger.Error(err, "UserPermissionService.DeleteAllPermissionsByUserGuid");
                throw;
            }
        }

        public ResponseModel<Guid> DeletePermitionForUser(Guid userGuid, string permitionName)
        {
            try
            {
                _unitOfWork.BeginTransaction();
                var repoResponse = _unitOfWork.GetUserPermissionRepository.DeletePermissionForUser(userGuid, permitionName);
                if (repoResponse.Success)
                {
                    var save = _unitOfWork.Save();
                    if (save > -1)
                    {
                        _unitOfWork.CommitTransaction();
                        return repoResponse;
                    }
                    else
                    {
                        _unitOfWork.RollBackTransaction();
                        return new ResponseModel<Guid>
                        {
                            Success = false,
                            Message = "Nie udało się usunąć zakresu uprawnień"
                        };
                    }
                }
                else
                {
                    _unitOfWork.RollBackTransaction();
                    return repoResponse;
                }
            }
            catch (Exception err)
            {
                _unitOfWork.RollBackTransaction();
                _logger.Error(err, "UserPermissionService.DeletePermitionForUser");
                throw;
            }
        }
    }
}
