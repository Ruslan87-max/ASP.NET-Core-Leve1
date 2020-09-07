using System;

namespace WebStore.Domain.Entities.Base.Interfaces
{
    public interface IOrderedEntity
    {
        /// <summary>Порядок</summary>
        int Order { get; set; }
    }
}
