using RestApiModeloDDD.Application.Dtos;
using System.Collections.Generic;

namespace RestApiModeloDDD.Application.Interfaces
{
    public interface IApplicationServiceProduto
    {
        ProdutoDto Get(int id);

        IEnumerable<ProdutoDto> GetAll();

        void Add(ProdutoDto produtoDto);

        void Update(ProdutoDto produtoDto);

        void Delete(ProdutoDto produtoDto);
    }
}