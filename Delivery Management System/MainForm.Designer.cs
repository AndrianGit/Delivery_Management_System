using static System.Net.Mime.MediaTypeNames;
using System.Windows.Forms;
using Font = System.Drawing.Font;

namespace Delivery_Management_System
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panel1 = new Panel();
            btnAddDelivery = new Button();
            label1 = new Label();
            DeliveryPanel = new FlowLayoutPanel();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(45, 45, 48); // Dark theme header
            panel1.Controls.Add(btnAddDelivery);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(2);
            panel1.Name = "panel1";
            panel1.Size = new Size(834, 70);
            panel1.TabIndex = 0;
            // 
            // btnAddDelivery
            // 
            btnAddDelivery.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnAddDelivery.BackColor = Color.FromArgb(0, 122, 204); // Azure blue button
            btnAddDelivery.ForeColor = Color.White;
            btnAddDelivery.FlatStyle = FlatStyle.Flat; // Modern flat design
            btnAddDelivery.FlatAppearance.BorderSize = 0;
            btnAddDelivery.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAddDelivery.Location = new Point(690, 18);
            btnAddDelivery.Margin = new Padding(2);
            btnAddDelivery.Name = "btnAddDelivery";
            btnAddDelivery.Size = new Size(120, 40);
            btnAddDelivery.TabIndex = 1;
            btnAddDelivery.Text = "Add Delivery";
            btnAddDelivery.UseVisualStyleBackColor = false;
            btnAddDelivery.Click += btnAddDelivery_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White; // White text for contrast
            label1.Location = new Point(20, 20);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(312, 30);
            label1.TabIndex = 0;
            label1.Text = "Delivery Management System";
            // 
            // DeliveryPanel
            // 
            DeliveryPanel.Dock = DockStyle.Fill;
            DeliveryPanel.BackColor = Color.FromArgb(242, 242, 242); // Light background for contrast
            DeliveryPanel.Padding = new Padding(20);
            DeliveryPanel.Location = new Point(0, 70);
            DeliveryPanel.Margin = new Padding(2);
            DeliveryPanel.Name = "DeliveryPanel";
            DeliveryPanel.Size = new Size(834, 318);
            DeliveryPanel.TabIndex = 1;
            DeliveryPanel.Paint += DeliveryPanel_Paint;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(834, 388);
            Controls.Add(DeliveryPanel);
            Controls.Add(panel1);
            Margin = new Padding(2);
            Name = "MainForm";
            Text = "Delivery Management";
            WindowState = FormWindowState.Maximized;
            Load += MainForm_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private Button btnAddDelivery;
        private FlowLayoutPanel DeliveryPanel;

        public PaintEventHandler DeliveryPanel_Paint { get; private set; }
    }
}
