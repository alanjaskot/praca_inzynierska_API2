using PracaInzynierska.Application.DTO.Category;
using PracaInzynierskaAPI.Entities.Category;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracaInzynierska.Application.Mapper.CategoriesMapper
{
    public static class CategoryMapper
    {
        public static CategoryDTO CategoryToDTO(CategoryDbModel category)
        {
            var categoryDTO = new CategoryDTO
            {
                Id = category.Id,
                IsBuildIn = category.IsBuildIn,
                CreatedAt = category.CreatedAt,
                IsModified = category.IsModified,
                LastModifiedAt = category.LastModifiedAt,
                IsDeleted = category.IsDeleted,
                DeletedAt = category.DeletedAt,
                Category = category.Category,
                UserId = category.UserId
            };

            return categoryDTO;
        }

        public static List<CategoryDTO> CategoriesToDTO(List<CategoryDbModel> categories)
        {
            var list = new List<CategoryDTO>();
            var categoryDTO = new CategoryDTO();

            foreach(var item in categories)
            {
                categoryDTO = CategoryToDTO(item);
                list.Add(categoryDTO);
            }

            return list;
        }

        public static CategoryDbModel CategoryToDbModel(CategoryDTO category)
        {
            var categoryDbModel = new CategoryDbModel
            {
                Id = category.Id,
                IsBuildIn = category.IsBuildIn,
                CreatedAt = category.CreatedAt,
                IsModified = category.IsModified,
                LastModifiedAt = category.LastModifiedAt,
                IsDeleted = category.IsDeleted,
                DeletedAt = category.DeletedAt,
                Category = category.Category,
                UserId = category.UserId
            };

            return categoryDbModel;
        }

        public static List<CategoryDbModel> CategoriesToDbModel(List<CategoryDTO> categories)
        {
            var list = new List<CategoryDbModel>();
            var categoryDbModel = new CategoryDbModel();

            foreach (var item in categories)
            {
                categoryDbModel = CategoryToDbModel(item);
                list.Add(categoryDbModel);
            }

            return list;
        }
    }
}
