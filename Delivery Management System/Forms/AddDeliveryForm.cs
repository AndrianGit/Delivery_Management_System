using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Delivery_Management_System.Controllers;
using Delivery_Management_System.DAO;
using Delivery_Management_System.Data;
using Delivery_Management_System.Services;

namespace Delivery_Management_System.Forms
{
    public partial class AddDeliveryForm : Form
    {
        private DeliveryController _deliveryController;

        public int DeliveryAdded { get; internal set; }

        public event Action deliveryAdded;
        public AddDeliveryForm()
        {
            InitializeComponent();
            var context = new ApplicationDbContext();
            var deliveryRepository = new DeliveryRepository(context);
            var deliveryService = new DeliveryService(deliveryRepository);
            _deliveryController = new DeliveryController(deliveryService);
        }

        private void cboStatus_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnSaveDelivery_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtDeliveryName.Text) ||
                string.IsNullOrWhiteSpace(rtxtDescription.Text) ||
                string.IsNullOrWhiteSpace(cboStatus.Text))
            {
                MessageBox.Show("All fields are required.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            string deliveryName = txtDeliveryName.Text;
            string description = rtxtDescription.Text;
            string status = cboStatus.Text;

            _deliveryController.AddDelivery(deliveryName, description, status);
            MessageBox.Show("Added Successfully", "Information");

            //Raise the event to notify the Main Form
            deliveryAdded?.Invoke();
            this.Close();

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void AddDeliveryForm_Load(object sender, EventArgs e)
        {

        }

        private void rtxtDescription_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
