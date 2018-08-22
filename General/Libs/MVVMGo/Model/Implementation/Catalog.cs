﻿using System.Collections.Generic;
using Data.InMemory.Interfaces;
using Data.Persistent.Interfaces;

namespace Model.Implementation
{
    public abstract class Catalog<T> : CatalogFull<T,T,T> where T : IStorable
    {
        protected Catalog(
            IInMemoryCollection<T> collection, 
            IDataSourceCRUD<T> source, 
            List<PersistencyOperations> supportedOperations, 
            KeyManagementStrategyType keyManagementStrategy = KeyManagementStrategyType.CollectionDecides) 
            : base(collection, source, supportedOperations, keyManagementStrategy)
        {
        }
    }
}