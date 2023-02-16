using RestApiModeloDDD.Application.Dtos;
using RestApiModeloDDD.Application.Interfaces;
using RestApiModeloDDD.Application.Interfaces.Mappers;
using RestApiModeloDDD.Domain.Core.Interfaces.Services;
using System.Collections.Generic;

namespace RestApiModeloDDD.Application
{
    public class ApplicationServiceProduto : IApplicationServiceProduto
    {
        private readonly IServiceProduto _serviceProduto;
        private readonly IMapperProduto _mapperProduto;

        public ApplicationServiceProduto(IServiceProduto serviceProduto, IMapperProduto mapperProduto)
        {
            _serviceProduto = serviceProduto;
            _mapperProduto = mapperProduto;
        }

        public ProdutoDto Get(int id)
        {
            var produto = _serviceProduto.Get(id);

            return _mapperProduto.MapperEntityToDto(produto);
        }

        public IEnumerable<ProdutoDto> GetAll()
        {
            var produtos = _serviceProduto.GetAll();

            return _mapperProduto.MapperListProdutosDto(produtos);
        }

        public void Add(ProdutoDto produtoDto)
        {
            var produto = _mapperProduto.MapperDtoToEntity(produtoDto);

            _serviceProduto.Add(produto);
        }

        public void Update(ProdutoDto produtoDto)
        {
            var produto = _mapperProduto.MapperDtoToEntity(produtoDto);

            _serviceProduto.Update(produto);
        }

        public void Delete(ProdutoDto produtoDto)
        {
            var produto = _mapperProduto.MapperDtoToEntity(produtoDto);

            _serviceProduto.Delete(produto);
        }
    }
}