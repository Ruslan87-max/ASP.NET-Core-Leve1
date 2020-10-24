using Lesson1_Task1_MiddleWare.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Lesson1_Task1_MiddleWare.InfroStrucure.Interfaces
{
    public interface ICartService
    {
        void RemoveFromCart(int id);
        void DecrementFromCart(int id);
        void RemoveAll();
        void AddToCart(int id);
        CartViewModel TransformCart();
    }
}
