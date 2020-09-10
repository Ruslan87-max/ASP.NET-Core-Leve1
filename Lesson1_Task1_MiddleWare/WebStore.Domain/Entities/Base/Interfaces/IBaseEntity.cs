using System;
using System.ComponentModel.DataAnnotations;

namespace WebStore.Domain.Entities.Base.Interfaces
{
    public interface IBaseEntity
    {
        [Key]
        int Id { get; set; }
    }
}
