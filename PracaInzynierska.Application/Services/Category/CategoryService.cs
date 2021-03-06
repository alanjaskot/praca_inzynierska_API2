using NLog;
using PracaInzynierska.Application.DTO.Category;
using PracaInzynierska.Application.Mapper.CategoriesMapper;
using PracaInzynierskaAPI.DataBase.UnitOfWork;
using PracaInzynierskaAPI.Models.Response;
using System;
using System.Collections.Generic;

namespace PracaInzynierska.Application.Services.Category
{
    public class CategoryService: ICategoryService
    {
        private readonly IUnitOfWork _unitOfWork;
        private ILogger _logger;

        public CategoryService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
            _logger = LogManager.GetCurrentClassLogger();
        }

        public ResponseModel<List<CategoryDTO>> GetAllCategories()
        {
            try
            {
                var repoResponse = _unitOfWork.GetCategoryRepository.GetAll();
                if (repoResponse.Success)
                    return new ResponseModel<List<CategoryDTO>>
                    {
                        Success = repoResponse.Success,
                        Message = repoResponse.Message,
                        Object = CategoryMapper.CategoriesToDTO(repoResponse.Object)
                    };
                else
                    return new ResponseModel<List<CategoryDTO>>
                    {
                        Success = repoResponse.Success,
                        Message = repoResponse.Message
                    };
            }
            catch (Exception err)
            {
                _logger.Error(err, "CategoryService.GetAllCategories");
                throw;
            }
        }

        public ResponseModel<CategoryDTO> GetCategoryById(Guid id)
        {
            try
            {
                var repoResponse = _unitOfWork.GetCategoryRepository.GetById(id);
                if (repoResponse.Success)
                    return new ResponseModel<CategoryDTO>
                    {
                        Success = repoResponse.Success,
                        Message = repoResponse.Message,
                        Object = CategoryMapper.CategoryToDTO(repoResponse.Object)
                    };
                else
                    return new ResponseModel<CategoryDTO>
                    {
                        Success = repoResponse.Success,
                        Message = repoResponse.Message
                    };
            }
            catch (Exception err)
            {
                _logger.Error(err, "CategoryService.GetCategoryById");
                throw;
            }
        }

        public ResponseModel<List<CategoryDTO>> GetCategoriesByName(List<string> list)
        {
            try
            {
                var repoResponse = _unitOfWork.GetCategoryRepository.GetByName(list);
                if (repoResponse.Success)
                    return new ResponseModel<List<CategoryDTO>>
                    {
                        Success = repoResponse.Success,
                        Message = repoResponse.Message,
                        Object = CategoryMapper.CategoriesToDTO(repoResponse.Object)
                    };
                else
                    return new ResponseModel<List<CategoryDTO>>
                    {
                        Success = repoResponse.Success,
                        Message = repoResponse.Message
                    };
            }
            catch (Exception err)
            {
                _logger.Error(err, "CategoryService.GetAllCategories");
                throw;
            }
        }

        public ResponseModel<Guid> AddCategory(CategoryDTO category)
        {
            try
            {
                _unitOfWork.BeginTransaction();
                var repoResponse = _unitOfWork.GetCategoryRepository.Add(CategoryMapper.CategoryToDbModel(category));
                if(repoResponse.Success)
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
                            Message = "Dodanie kategorii nie powiodło się"
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
                _logger.Error(err, "CategoryService.AddCategory");
                throw;
            }
        }

        public ResponseModel<Guid> UpdateCategory(CategoryDTO category)
        {
            try
            {
                _unitOfWork.BeginTransaction();
                var repoResponse = _unitOfWork.GetCategoryRepository.Update(CategoryMapper.CategoryToDbModel(category));
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
                            Message = "Wprowadzone zmiany nie powiodły się"
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
                _logger.Error(err, "CategoryService.UpdateCategory");
                throw;
            }     
        }

        public ResponseModel<Guid> SoftDeleteCategory(Guid categoryId)
        {
            try
            {
                _unitOfWork.BeginTransaction();
                var repoResponse = _unitOfWork.GetCategoryRepository.SoftDelete(categoryId);
                if(repoResponse.Success)
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
                            Message = "Usunięcie kategorii nie powiodło się"
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
                _logger.Error(err, "CategoryService.SoftDeleteCategory");
                throw;
            }
        }

        public ResponseModel<Guid> DeleteCategory(Guid id)
        {
            try
            {
                _unitOfWork.BeginTransaction();
                var repoResponse = _unitOfWork.GetCategoryRepository.Delete(id);
                if(repoResponse.Success)
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
                            Message = "Usunięciee kategorii nie powiodło się"
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
                _logger.Error(err, "CategoryService.DeleteCategory");
                throw;
            }
        }
    }
}
