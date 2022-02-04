﻿using NLog;
using PracaInzynierska.Application.DTO.Language;
using PracaInzynierska.Application.Mapper.LanguagesMapper;
using PracaInzynierskaAPI.DataBase.UnitOfWork;
using PracaInzynierskaAPI.Entities.Language;
using PracaInzynierskaAPI.Models.Response;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracaInzynierska.Application.Services.Language
{
    public class LanguageService: ILanguageService
    {
        private readonly IUnitOfWork _unitOfWork;
        private static ILogger _logger;

        public LanguageService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
            _logger = LogManager.GetCurrentClassLogger();
        }

        public ResponseModel<List<LanguageDTO>> GetAllLanguages()
        {
            try
            {
                var repoResponse = _unitOfWork.GetLanguageRepository.GetAll();
                if (repoResponse.Success)
                    return new ResponseModel<List<LanguageDTO>>
                    {
                        Success = repoResponse.Success,
                        Message = repoResponse.Message,
                        Object = LanguageMapper.LanguagesToDTO(repoResponse.Object)
                    };
                else
                    return new ResponseModel<List<LanguageDTO>>
                    {
                        Success = repoResponse.Success,
                        Message = repoResponse.Message
                    };
            }
            catch (Exception err)
            {
                _logger.Error(err, "LanguageService.GetAll");
                throw;
            }
        }

        public ResponseModel<List<LanguageDTO>> GetLanguageByName(string name)
        {
            try
            {
                var repoResponse = _unitOfWork.GetLanguageRepository.GetByName(name);
                if (repoResponse.Success)
                    return new ResponseModel<List<LanguageDTO>>
                    {
                        Success = repoResponse.Success,
                        Message = repoResponse.Message,
                        Object = LanguageMapper.LanguagesToDTO(repoResponse.Object)
                    };
                else
                    return new ResponseModel<List<LanguageDTO>>
                    {
                        Success = repoResponse.Success,
                        Message = repoResponse.Message
                    };
            }
            catch (Exception err)
            {
                _logger.Error(err, "LanguageService.GetLanguageByName");
                throw;
            }
        }

        public ResponseModel<LanguageDTO> GetLanguageById(Guid id)
        {
            try
            {
                var repoResponse = _unitOfWork.GetLanguageRepository.GetById(id);
                if (repoResponse.Success)
                    return new ResponseModel<LanguageDTO>
                    {
                        Success = repoResponse.Success,
                        Message = repoResponse.Message,
                        Object = LanguageMapper.LanguageToDTO(repoResponse.Object)
                    };
                else
                    return new ResponseModel<LanguageDTO>
                    {
                        Success = repoResponse.Success,
                        Message = repoResponse.Message
                    };
            }
            catch (Exception err)
            {
                _logger.Error(err, "LanguageService.GetLanguageById");
                throw;
            }
        }

        public ResponseModel<Guid> AddLanguage(LanguageDTO language)
        {
            try
            {
                _unitOfWork.BeginTransaction();
                var repoResponse = _unitOfWork.GetLanguageRepository.Add(LanguageMapper.LanguageToDbModel(language));
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
                            Message = "Nie udało się dodać języka"
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
                _logger.Error(err, "LanguageService.AddLanguage");
                throw;
            }
        }

        public ResponseModel<Guid> UpdateLanguage(LanguageDTO language)
        {
            try
            {
                _unitOfWork.BeginTransaction();
                var repoResponse = _unitOfWork.GetLanguageRepository.Update(LanguageMapper.LanguageToDbModel(language));
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
                            Message = "Nie udało się zmodyfikować języka"
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
                _logger.Error(err, "LanguageService.UpdateLanguage");
                throw;
            }
        }

        public ResponseModel<Guid> SoftDeleteLanguage(Guid id)
        {
            try
            {
                _unitOfWork.BeginTransaction();
                var repoResponse = _unitOfWork.GetLanguageRepository.SoftDelete(id);
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
                            Message = "Nie udało się usunąć języka"
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
                _logger.Error(err, "LanguageService.SoftDeleteLanguage");
                throw;
            }
        }
    }
}
