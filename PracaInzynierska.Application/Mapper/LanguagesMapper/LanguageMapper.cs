using PracaInzynierska.Application.DTO.Language;
using PracaInzynierskaAPI.Entities.Language;
using System.Collections.Generic;

namespace PracaInzynierska.Application.Mapper.LanguagesMapper
{
    public static class LanguageMapper
    {
        public static LanguageDTO LanguageToDTO(LanguageDbModel language)
        {
            var languageDTO = new LanguageDTO
            {
                Id = language.Id,
                IsBuildIn = language.IsBuildIn,
                CreatedAt = language.CreatedAt,
                IsModified = language.IsModified,
                LastModifiedAt = language.LastModifiedAt,
                IsDeleted = language.IsDeleted,
                DeletedAt = language.DeletedAt,
                Language = language.Language,
                AddedBy = language.AddedBy
            };

            return languageDTO;
        }

        public static List<LanguageDTO> LanguagesToDTO(List<LanguageDbModel> languages)
        {
            var list = new List<LanguageDTO>();
            var languageDTO = new LanguageDTO();

            foreach(var item in languages)
            {
                languageDTO = LanguageToDTO(item);
                list.Add(languageDTO);
            }

            return list;
        }

        public static LanguageDbModel LanguageToDbModel(LanguageDTO language)
        {
            var languageDbModel = new LanguageDbModel
            {
                Id = language.Id,
                IsBuildIn = language.IsBuildIn,
                CreatedAt = language.CreatedAt,
                IsModified = language.IsModified,
                LastModifiedAt = language.LastModifiedAt,
                IsDeleted = language.IsDeleted,
                DeletedAt = language.DeletedAt,
                Language = language.Language,
                AddedBy = language.AddedBy
            };

            return languageDbModel;
        }
    }
}
