using PracaInzynierskaAPI.Core.Abstraction;
using System;

namespace PracaInzynierska.Application.DTO.Language
{
    public class LanguageDTO: BaseCreatedLastModifiedDeletedEntity
    {
        public string Language { get; set; }

        //foreign key
        public Guid AddedBy { get; set; }
    }
}
