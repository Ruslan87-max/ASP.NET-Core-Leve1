using Lesson1_Task1_MiddleWare.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebStore.Domain.Entities;

namespace Lesson1_Task1_MiddleWare.InfroStrucure.Interfaces
{
    public interface ITotalProductService
    {
        TotalInCarViewModel GetCartItemsSum();
       // int GetCartItemsQuantity();
    }
}
