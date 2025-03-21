﻿using BrightCenter.Domain.Entities.OrdersManagement;
using BrightCenter.Infrastructure.DbContexts;

namespace BrightCenter.Infrastructure.Repositories.OrderManagement
{
    public class DeliveryOrderRepository : BaseRepository<DeliveryOrder>
    {
        private readonly AppDbContext _context;
        public DeliveryOrderRepository(AppDbContext context) : base(context)
        {
            _context = context;
        }
        public override async Task DeleteAsync(int id)
        {
            var deliveryOrder = await _context.DeliveryOrders.FindAsync(id);
            if (deliveryOrder is not null)
            {
                deliveryOrder.IsActive = false;
                await _context.SaveChangesAsync();
            }
            else
            {
                throw new Exception("DeliveryOrder not found");
            }
        }
    }
}
