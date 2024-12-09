﻿using DesignPattern.Mediator.DAL;
using DesignPattern.Mediator.MediatorPattern.Commands;
using MediatR;

namespace DesignPattern.Mediator.MediatorPattern.Handlers
{
    public class CreateProductCommandHandler : IRequestHandler<CreateProductCommand>
    {
        private readonly Context _context;
        public CreateProductCommandHandler(Context context)
        {
            _context = context;
        }

        public async Task Handle(CreateProductCommand request, CancellationToken cancellationToken)
        {
            _context.Products.Add(new Product
            {
                ProductName = request.ProductName,
                ProductCategory = request.ProductCategory,
                ProduckStockType = request.ProduckStockType,
                ProductPrice = request.ProductPrice,
                ProductStock = request.ProductStock,
            });
            await _context.SaveChangesAsync();
        }
    }
}
