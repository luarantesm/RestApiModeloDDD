using RestApiModeloDDD.Application.Dtos;
using RestApiModeloDDD.Domain.Entitys;
using System.Collections.Generic;

namespace RestApiModeloDDD.Application.Interfaces.Mappers
{
    public interface IMapperCliente
    {
        Cliente MapperDtoToEntity(ClienteDto clienteDto);

        ClienteDto MapperEntityToDto(Cliente cliente);

        IEnumerable<ClienteDto> MapperListClientesDto(IEnumerable<Cliente> clientes);
    }
}