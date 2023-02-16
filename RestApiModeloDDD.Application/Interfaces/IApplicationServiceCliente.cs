using RestApiModeloDDD.Application.Dtos;
using System.Collections.Generic;

namespace RestApiModeloDDD.Application.Interfaces
{
    public interface IApplicationServiceCliente
    {
        ClienteDto Get(int id);

        IEnumerable<ClienteDto> GetAll();

        void Add(ClienteDto clienteDto);

        void Update(ClienteDto clienteDto);

        void Delete(ClienteDto clienteDto);
    }
}