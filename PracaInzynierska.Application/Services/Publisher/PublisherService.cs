using NLog;
using PracaInzynierska.Application.DTO.Publisher;
using PracaInzynierska.Application.Mapper.PublishersMapper;
using PracaInzynierskaAPI.DataBase.UnitOfWork;
using PracaInzynierskaAPI.Entities.Publisher;
using PracaInzynierskaAPI.Models.Response;
using System;
using System.Collections.Generic;


namespace PracaInzynierska.Application.Services.Publisher
{
    public class PublisherService: IPublisherService
    {
        private readonly IUnitOfWork _unitOfWork;
        private static ILogger _logger;

        public PublisherService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
            _logger = LogManager.GetCurrentClassLogger();
        }

        public ResponseModel<List<PublisherDTO>> GetAllPublishers()
        {
            try
            {
                var repoResponse = _unitOfWork.GetPublisherRepository.GetAll();
                if(repoResponse.Success)
                    return new ResponseModel<List<PublisherDTO>>
                    {
                        Success = repoResponse.Success,
                        Message = repoResponse.Message,
                        Object = PublisherMapper.PublishersToDTO(repoResponse.Object)
                    };
                else
                    return new ResponseModel<List<PublisherDTO>>
                    {
                        Success = repoResponse.Success,
                        Message = repoResponse.Message
                    };
            }
            catch (Exception err)
            {
                _logger.Error(err, "PublisherService.GetAllPublishers");
                throw;
            }
        }

        public ResponseModel<List<PublisherDTO>> FindPublishersByName(List<string> name)
        {
            try
            {
                var repoResponse = _unitOfWork.GetPublisherRepository.FindByName(name);
                if (repoResponse.Success)
                    return new ResponseModel<List<PublisherDTO>>
                    {
                        Success = repoResponse.Success,
                        Message = repoResponse.Message,
                        Object = PublisherMapper.PublishersToDTO(repoResponse.Object)
                    };
                else
                    return new ResponseModel<List<PublisherDTO>>
                    {
                        Success = repoResponse.Success,
                        Message = repoResponse.Message
                    };
            }
            catch (Exception err)
            {
                _logger.Error(err, "PublisherService.FindPublisherByName");
                throw;
            }
        }

        public ResponseModel<PublisherDTO> GetPublisherById(Guid id)
        {
            try
            {
                var repoResponse = _unitOfWork.GetPublisherRepository.GetById(id);
                if (repoResponse.Success && repoResponse.Object != null)
                    return new ResponseModel<PublisherDTO>
                    {
                        Success = repoResponse.Success,
                        Message = repoResponse.Message,
                        Object = PublisherMapper.PublisherToDTO(repoResponse.Object)
                    };
                else if (repoResponse.Success && repoResponse.Object == null)
                {
                    return new ResponseModel<PublisherDTO>
                    {
                        Success = repoResponse.Success,
                        Message = repoResponse.Message
                    };
                }
                else
                    return new ResponseModel<PublisherDTO>
                    {
                        Success = repoResponse.Success,
                        Message = repoResponse.Message
                    };
            }
            catch (Exception err)
            {
                _logger.Error(err, "PublisherService.GetPublisherById");
                throw;
            }
        }

        public ResponseModel<Guid> AddPublisher(PublisherDTO publisher)
        {
            try
            {
                _unitOfWork.BeginTransaction();
                var repoResponse = _unitOfWork.GetPublisherRepository.Add(PublisherMapper.PublisherToDbModel(publisher));
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
                            Message = "Nie udało się dodać wydawcy"
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
                _logger.Error(err, "PublisherService.AddPublishers");
                throw;
            }
        }

        public ResponseModel<Guid> UpdatePublisher(PublisherDTO publisher)
        {
            try
            {
                _unitOfWork.BeginTransaction();
                var repoResponse = _unitOfWork.GetPublisherRepository.Update(PublisherMapper.PublisherToDbModel(publisher));
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
                            Message = "Nie udało się dodać wydawcy"
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
                _logger.Error(err, "PublisherService.AddPublishers");
                throw;
            }
        }

        public ResponseModel<Guid> SoftDeletePublisher(Guid id)
        {
            try
            {
                _unitOfWork.BeginTransaction();
                var repoResponse = _unitOfWork.GetPublisherRepository.SoftDelete(id);
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
                            Message = "Nie udało się dodać wydawcy"
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
                _logger.Error(err, "PublisherService.AddPublishers");
                throw;
            }
        }
    }
}
