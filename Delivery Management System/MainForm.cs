using System;
using System.Drawing;
using System.Windows.Forms;
using Delivery_Management_System.Controllers;
using Delivery_Management_System.DAO;
using Delivery_Management_System.Data;
using Delivery_Management_System.Forms;
using Delivery_Management_System.Models;
using Delivery_Management_System.Services;

namespace Delivery_Management_System
{
    public partial class MainForm : Form
    {
        private readonly DeliveryController _deliveryController;

        public MainForm()
        {
            InitializeComponent();

            var context = new ApplicationDbContext();
            var deliveryRepository = new DeliveryRepository(context);
            var deliveryService = new DeliveryService(deliveryRepository);
            _deliveryController = new DeliveryController(deliveryService);
        }

        private void btnAddDelivery_Click(object sender, EventArgs e)
        {
            var addDeliveryForm = new AddDeliveryForm();
            addDeliveryForm.deliveryAdded += LoadDelivery;
            addDeliveryForm.ShowDialog();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            LoadDelivery();
        }

        private void LoadDelivery()
        {
            var deliveryList = _deliveryController.GetAllDelivery();
            DeliveryPanel.Controls.Clear();

            foreach (var deliveryItem in deliveryList)
            {
                AddDeliveryCard(deliveryItem);
            }
        }

        private void AddDeliveryCard(DeliveryItem deliveryItem)
        {
            var cardPanel = new Panel
            {
                Size = new Size(370, 160),
                BackColor = Color.CadetBlue,
                Margin = new Padding(30),
                Padding = new Padding(10)
            };

            // Delete Icon
            var deleteIcon = new Label
            {
                Text = "✖",
                Font = new Font("Segoe UI", 8, FontStyle.Bold),
                ForeColor = Color.Red,
                Cursor = Cursors.Hand,
                Location = new Point(cardPanel.Width - 30, 5),
                AutoSize = true
            };
            deleteIcon.Click += (sender, e) => DeleteDelivery(deliveryItem);
            cardPanel.Controls.Add(deleteIcon);

            // Edit Icon
            var editIcon = new Label
            {
                Text = "✏",
                Font = new Font("Segoe UI", 8, FontStyle.Bold),
                ForeColor = Color.Gold,
                Cursor = Cursors.Hand,
                Location = new Point(cardPanel.Width - 60, 5),
                AutoSize = true
            };
            editIcon.Click += (sender, e) => UpdateDelivery(deliveryItem);
            cardPanel.Controls.Add(editIcon);

            // Delivery Name Label
            var nameLabel = new Label
            {
                Text = deliveryItem.DeliveryName,
                Font = new Font("Segoe UI", 12, FontStyle.Bold),
                ForeColor = Color.DarkSlateGray,
                Location = new Point(10, 10),
                AutoSize = true
            };
            cardPanel.Controls.Add(nameLabel);

            // Delivery Description Label
            var descriptionLabel = new Label
            {
                Text = deliveryItem.DeliveryDescription,
                Font = new Font("Segoe UI", 10, FontStyle.Bold),
                ForeColor = Color.DimGray,
                Location = new Point(10, 35),
                AutoSize = true
            };
            cardPanel.Controls.Add(descriptionLabel);

            // View Details Link
            var viewDetails = new LinkLabel
            {
                Text = "View Details",
                Font = new Font("Segoe UI", 9, FontStyle.Bold),
                ForeColor = Color.Blue,
                Location = new Point(cardPanel.Width - 100, cardPanel.Height - 30),
                AutoSize = true
            };
            viewDetails.LinkClicked += (sender, e) => ShowDeliveryDetails(deliveryItem);
            cardPanel.Controls.Add(viewDetails);

            DeliveryPanel.Controls.Add(cardPanel);
        }

        private void ShowDeliveryDetails(DeliveryItem deliveryItem)
        {
            MessageBox.Show($"Name: {deliveryItem.DeliveryName}\nDescription: {deliveryItem.DeliveryDescription}\nStatus: {deliveryItem.DeliveryStatus}",
                "Delivery Details",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);
        }

        private void UpdateDelivery(DeliveryItem deliveryItem)
        {
            var updateDeliveryForm = new UpdateDeliveryForm(deliveryItem);
            updateDeliveryForm.deliveryUpdated += updatedItem =>
            {
                // Reload delivery data after update
                LoadDelivery();
            };
            updateDeliveryForm.ShowDialog();
        }

        private void DeleteDelivery(DeliveryItem deliveryItem)
        {
            var confirmResult = MessageBox.Show($"Are you sure you want to delete {deliveryItem.DeliveryName}?",
                "Confirm Delete",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning);

            if (confirmResult == DialogResult.Yes)
            {
                _deliveryController.DeleteDelivery(deliveryItem.Id);
                LoadDelivery();
            }
        }
    }
}
