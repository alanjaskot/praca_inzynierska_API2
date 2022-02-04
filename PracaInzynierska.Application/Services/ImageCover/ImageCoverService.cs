using NLog;
using PracaInzynierska.Application.DTO.ImageCover;
using PracaInzynierska.Application.Mapper.ImageCoversMapper;
using PracaInzynierskaAPI.DataBase.UnitOfWork;
using PracaInzynierskaAPI.Models.Response;
using System;


namespace PracaInzynierska.Application.Services.ImageCover
{
    public class ImageCoverService: IImageCoverService
    {
        private readonly IUnitOfWork _unitOfWork;
        private ILogger _logger;

        public ImageCoverService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
            _logger = LogManager.GetCurrentClassLogger();
        }

        public ResponseModel<ImageCoverDTO> GetImageCoverById(Guid id)
        {
            try
            {
                var repoResponse = _unitOfWork.GetImageCoverRepository.GetById(id);
                if (repoResponse.Success)
                    return new ResponseModel<ImageCoverDTO>
                    {
                        Success = repoResponse.Success,
                        Message = repoResponse.Message,
                        Object = ImageCoverMapper.ImageCoverToDTO(repoResponse.Object)
                    };
                else
                    return new ResponseModel<ImageCoverDTO>
                    {
                        Success = repoResponse.Success,
                        Message = repoResponse.Message
                    };
            }
            catch (Exception err)
            {
                _logger.Error(err, "ImageCoverService.GetImageCoverById");
                throw;
            }
        }

        public ResponseModel<Guid> AddImageCover(ImageCoverDTO imageCover)
        {
            try
            {
                _unitOfWork.BeginTransaction();
                var repoResponse = _unitOfWork.GetImageCoverRepository.Add(ImageCoverMapper.ImageCoverToDbModel(imageCover));
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
                            Message = "Nie udało się dodać okładki"
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
                _logger.Error(err, "ImageCoverService.AddImageCover");
                throw;
            }
        }

        public ResponseModel<Guid> UpdateImageCover(ImageCoverDTO imageCover)
        {
            try
            {
                _unitOfWork.BeginTransaction();
                var repoResponse = _unitOfWork.GetImageCoverRepository.Update(ImageCoverMapper.ImageCoverToDbModel(imageCover));
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
                            Message = "Nie udało się zmodyfikować okładki"
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
                _logger.Error(err, "ImageCoverService.AddImageCover");
                throw;
            }
        }

        public ResponseModel<Guid> Delete(Guid id)
        {
            try
            {
                _unitOfWork.BeginTransaction();
                var repoResponse = _unitOfWork.GetImageCoverRepository.Delete(id);
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
                            Message = "Nie udało się usunąć okładki"
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
                _logger.Error(err, "ImageCoverService.AddImageCover");
                throw;
            }
        }
    }
}
