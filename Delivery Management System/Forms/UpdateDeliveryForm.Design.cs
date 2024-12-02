using System;
using System.Windows.Forms;
using Delivery_Management_System.Controllers;
using Delivery_Management_System.DAO;
using Delivery_Management_System.Data;
using Delivery_Management_System.Models;
using Delivery_Management_System.Services;

namespace Delivery_Management_System.Forms
{
    public partial class UpdateDeliveryForm : Form
    {
        private DeliveryController _deliveryController;
        private DeliveryItem _deliveryItem;

        // Event to notify the main form of updates
        public event Action<DeliveryItem> deliveryUpdated;

        public UpdateDeliveryForm(DeliveryItem deliveryItem)
        {
            InitializeComponent();

            var context = new ApplicationDbContext();
            var deliveryRepository = new DeliveryRepository(context);
            var deliveryService = new DeliveryService(deliveryRepository);
            _deliveryController = new DeliveryController(deliveryService);

            _deliveryItem = deliveryItem;

            // Populate form fields with current delivery details
            txtDeliveryName.Text = deliveryItem.DeliveryName;
            rtxtDescription.Text = deliveryItem.DeliveryDescription;
            cboStatus.Text = deliveryItem.DeliveryStatus;
        }

        private void btnUpdateDelivery_Click(object sender, EventArgs e)
        {
            // Validate inputs
            if (string.IsNullOrWhiteSpace(txtDeliveryName.Text) ||
                string.IsNullOrWhiteSpace(rtxtDescription.Text) ||
                string.IsNullOrWhiteSpace(cboStatus.Text))
            {
                MessageBox.Show("All fields are required.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Get updated details
            string deliveryName = txtDeliveryName.Text.Trim();
            string description = rtxtDescription.Text.Trim();
            string status = cboStatus.Text.Trim();

            // Update the delivery via the controller
            _deliveryController.UpdateDelivery(_deliveryItem.Id, deliveryName, description, status);

            // Notify the user
            MessageBox.Show("Delivery updated successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

            // Update local delivery item
            _deliveryItem.DeliveryName = deliveryName;
            _deliveryItem.DeliveryDescription = description;
            _deliveryItem.DeliveryStatus = status;

            // Trigger the event with the updated delivery item
            deliveryUpdated?.Invoke(_deliveryItem);

            // Close the form
            this.Close();
        }

        private void UpdateDeliveryForm_Load(object sender, EventArgs e)
        {
            // Additional initialization, if needed
        }
    }
}
