﻿using SimApi.Data;
using SimApi.Data.Repository;

namespace SimApi.Data.Uow;

public interface IUnitOfWork : IDisposable
{
    IGenericRepository<Category> CategoryRepository { get; }
    IGenericRepository<Product> ProductRepository { get; }
    IGenericRepository<Entity> Repository<Entity>() where Entity : class;

    void Complete();
    void CompleteWithTransaction();
}
