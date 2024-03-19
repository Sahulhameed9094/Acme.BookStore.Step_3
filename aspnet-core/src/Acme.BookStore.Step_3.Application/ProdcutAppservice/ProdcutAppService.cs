using Acme.BookStore.Step_3.Dto;
using Acme.BookStore.Step_3.Entity;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Volo.Abp.Application.Services;
using Volo.Abp.Domain.Repositories;
using Volo.Abp.MultiTenancy;

namespace Acme.BookStore.Step_3.ProdcutAppservice
{
    public class ProdcutAppService : ApplicationService
    {
        private readonly IRepository<Product, Guid> _productRepository;

        public ProdcutAppService(IRepository<Product, Guid> productRepository)
        {
            _productRepository = productRepository;
        }


        public async Task<List<Product>> GetListAsync()
        {
            return await _productRepository.GetListAsync();
        }

        public async Task<Product> CreateAsync(CreateProductDto input)
        {
            var Product = new Product()
            {
                Name = input.Name,
                Price = input.Price
            };

            return await _productRepository.InsertAsync(Product);
        }

        public async Task<long> GetProductCountAsync()
        {
            //using (_dataFilter.Disable<IMultiTenant>())
            //{
                return await _productRepository.GetCountAsync();
            //}
        }


    }
}
