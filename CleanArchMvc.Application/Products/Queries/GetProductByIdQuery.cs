using CleanArqMvc.Domain.Entities;
using MediatR;

namespace CleanArchMvc.Application.Products.Queries
{
    internal class GetProductByIdQuery : IRequest<Product>
    {
        public int Id { get; set; }
        public GetProductByIdQuery(int id)
        {
            Id = id;
        }
    }
}
