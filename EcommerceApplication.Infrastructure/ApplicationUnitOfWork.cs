﻿using EcommerceApplicationWeb.Application;
using EcommerceApplicationWeb.Domain.Repositories;
using Microsoft.EntityFrameworkCore;

namespace EcommerceApplicationWeb.Infrastructure
{
    public class ApplicationUnitOfWork : UnitOfWork, IApplicationUnitOfWork
    {
        //public IBookRepository BookRepository { get; private set; }
        public IProductRepository ProductRepository { get; private set; }
        public ICategoryRepository CategoryRepository { get; private set; }
        public IUserRepository UserRepository { get; private set; }



        public ApplicationUnitOfWork(
            IProductRepository productRepository,
            ICategoryRepository categoryRepository,
            IUserRepository userRepository,
            IApplicationDbContext dbContext
        ) : base((DbContext)dbContext)
        {
            ProductRepository = productRepository;
            CategoryRepository = categoryRepository;
            UserRepository = userRepository;
        }
    }
}
