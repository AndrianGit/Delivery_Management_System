using Delivery_Management_System.Data;
using Delivery_Management_System.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace Delivery_Management_System.DAO
{
    public class DeliveryRepository
    {
        private readonly ApplicationDbContext _context;

        public DeliveryRepository(ApplicationDbContext context)
        {
            _context = context;
        }
        public List<DeliveryItem> GetAllDelivery()
        {
            return _context.DeliveryItem.ToList();
        }

        public DeliveryItem GetDeliveryById(int id)
        {
            return _context.DeliveryItem.Find(id);
        }

        public void AddDelivery(DeliveryItem deliveryitem)
        {
            _context.DeliveryItem.Add(deliveryitem);
            _context.SaveChanges();
        }
        public void UpdateDelivery(DeliveryItem deliveryitem)
        {
            _context.DeliveryItem.Update(deliveryitem);
            _context.SaveChanges();
        }
        public void DeleteDelivery(int id)
        {
            var delivery = _context.DeliveryItem.Find(id);
            if (delivery != null)
            {
                _context.DeliveryItem.Remove(delivery);
                _context.SaveChanges();
            }
        }
    }
}