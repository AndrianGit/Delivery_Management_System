using Delivery_Management_System.DAO;
using Delivery_Management_System.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delivery_Management_System.Services
{
    public class DeliveryService
    {
        private readonly DeliveryRepository _deliveryRepository;
        public DeliveryService(DeliveryRepository deliveryRepository)
        {
            _deliveryRepository = deliveryRepository;
        }

        public List<DeliveryItem> GetAllDelivery()
        {
            return _deliveryRepository.GetAllDelivery();
        }
        public DeliveryItem GetDeliveryById(int id)
        {
            return _deliveryRepository.GetDeliveryById(id);
        }
        public void AddDelivery(DeliveryItem deliveryItem)
        {
            _deliveryRepository.AddDelivery(deliveryItem);
        }
        public void DeleteDelivery(int id)
        {
            _deliveryRepository.DeleteDelivery(id);
        }
        public void UpdateDelivery(DeliveryItem deliveryItem)
        {
            _deliveryRepository.UpdateDelivery(deliveryItem);
        }

    }
}