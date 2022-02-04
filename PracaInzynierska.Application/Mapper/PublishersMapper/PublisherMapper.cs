using PracaInzynierska.Application.DTO.Publisher;
using PracaInzynierskaAPI.Entities.Publisher;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracaInzynierska.Application.Mapper.PublishersMapper
{
    public static class PublisherMapper
    {
        public static PublisherDTO PublisherToDTO(PublisherDbModel publisher)
        {
            var publisherDTO = new PublisherDTO
            {
                Id = publisher.Id,
                IsBuildIn = publisher.IsBuildIn,
                CreatedAt = publisher.CreatedAt,
                IsModified = publisher.IsModified,
                LastModifiedAt = publisher.LastModifiedAt,
                IsDeleted = publisher.IsDeleted,
                DeletedAt = publisher.DeletedAt,
                PublisherName = publisher.PublisherName,
                City = publisher.City,
                PostCode = publisher.PostCode,
                Street = publisher.Street,
                Building = publisher.Building,
                Premises = publisher.Premises,
                AddedBy = publisher.AddedBy
            };
            return publisherDTO;
        }

        public static List<PublisherDTO> PublishersToDTO(List<PublisherDbModel> publishers)
        {
            var list = new List<PublisherDTO>();
            var publisher = new PublisherDTO();

            foreach(var item in publishers)
            {
                publisher = PublisherToDTO(item);
                list.Add(publisher);
            }

            return list;
        }

        public static PublisherDbModel PublisherToDbModel(PublisherDTO publisher)
        {
            var publisherDbModel = new PublisherDbModel
            {
                Id = publisher.Id,
                IsBuildIn = publisher.IsBuildIn,
                CreatedAt = publisher.CreatedAt,
                IsModified = publisher.IsModified,
                LastModifiedAt = publisher.LastModifiedAt,
                IsDeleted = publisher.IsDeleted,
                DeletedAt = publisher.DeletedAt,
                PublisherName = publisher.PublisherName,
                City = publisher.City,
                PostCode = publisher.PostCode,
                Street = publisher.Street,
                Building = publisher.Building,
                Premises = publisher.Premises,
                AddedBy = publisher.AddedBy
            };
            return publisherDbModel;
        }
    }
}
