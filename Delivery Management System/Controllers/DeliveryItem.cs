using Delivery_Management_System.Models;
using Delivery_Management_System.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace Delivery_Management_System.Controllers
{
    public class DeliveryController
    {
        private readonly DeliveryService _deliveryService;

        public DeliveryController(DeliveryService deliveryService)
        {
            _deliveryService = deliveryService;
        }

        public List<DeliveryItem> GetAllDelivery()
        {
            return _deliveryService.GetAllDelivery();
        }

        public DeliveryItem GetDeliveryById(int id)
        {
            return _deliveryService.GetDeliveryById(id);
        }

        public void AddDelivery(string deliveryName, string deliveryDescription, string status)
        {
            var deliveryItem = new DeliveryItem
            {
                DeliveryName = deliveryName,
                DeliveryDescription = deliveryDescription,
                DeliveryStatus = status
            };
            _deliveryService.AddDelivery(deliveryItem);
        }

        public void UpdateDelivery(int id, string deliveryName, string deliveryDescription, string status)
        {
            var deliveryItem = _deliveryService.GetDeliveryById(id);
            if (deliveryItem != null)
            {
                deliveryItem.DeliveryName = deliveryName;
                deliveryItem.DeliveryDescription = deliveryDescription;
                deliveryItem.DeliveryStatus = status;
                _deliveryService.UpdateDelivery(deliveryItem);
            }
        }

        public void DeleteDelivery(int id)
        {
            _deliveryService.DeleteDelivery(id);
        }

    }
}