using EduSphere.Data.ViewModels;
using EduSphere.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace EduSphere.Data.Services
{
    public interface IOrdersService
    {
        Task<List<Order>> GetOrdersByUserIdAndRoleAsync(string userId, string userRole);
        Task StoreOrderAsync(List<ShoppingCartItem> items, string userId, string userEmailAddress);
    }
}
