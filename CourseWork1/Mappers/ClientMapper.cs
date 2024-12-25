using CourseWork1.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseWork1.Mappers
{
    public static class ClientMapper
    {
        public static ClientDTO ToDTO(IClient client)
        {
            return new ClientDTO()
            {
                Id = client.Id,
                FirstName = client.FirstName,
                LastName = client.LastName,
                Patronymic = client.Patronymic,
                DateOfBirth = client.DateOfBirth,
                PassportData = PassportMapper.ToDTO(client.PassportData),
                PathToPhoto = client.PathToPhoto
            };
        }
        public static IClient ToEntity(ClientDTO client)
        {
            var clientPassport = client.PassportData;
            return new Client(client.Id, client.FirstName, client.LastName, client.Patronymic, client.DateOfBirth,
                PassportMapper.ToEntity(clientPassport), client.PathToPhoto);
        }
    }
}
