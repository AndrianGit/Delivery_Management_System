namespace Delivery_Management_System.Forms
{
    partial class UpdateDeliveryForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            btnSaveDelivery = new Button();
            cboStatus = new ComboBox();
            rtxtDescription = new RichTextBox();
            txtDeliveryName = new TextBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            groupBox1 = new GroupBox();
            label4 = new Label();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // btnSaveDelivery
            // 
            btnSaveDelivery.BackColor = Color.DarkBlue;
            btnSaveDelivery.FlatStyle = FlatStyle.Flat;
            btnSaveDelivery.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnSaveDelivery.ForeColor = Color.White;
            btnSaveDelivery.Location = new Point(280, 356);
            btnSaveDelivery.Name = "btnSaveDelivery";
            btnSaveDelivery.Size = new Size(131, 42);
            btnSaveDelivery.TabIndex = 6;
            btnSaveDelivery.Text = "Update Delivery";
            btnSaveDelivery.UseVisualStyleBackColor = false;
            btnSaveDelivery.Click += btnUpdateDelivery_Click;
            // 
            // cboStatus
            // 
            cboStatus.Font = new Font("Segoe UI", 10F);
            cboStatus.FormattingEnabled = true;
            cboStatus.Items.AddRange(new object[] { "Pending", "In Transit", "Delivered", "Cancelled" });
            cboStatus.Location = new Point(184, 300);
            cboStatus.Name = "cboStatus";
            cboStatus.Size = new Size(228, 25);
            cboStatus.TabIndex = 5;
            // 
            // rtxtDescription
            // 
            rtxtDescription.Font = new Font("Segoe UI", 10F);
            rtxtDescription.Location = new Point(184, 150);
            rtxtDescription.Name = "rtxtDescription";
            rtxtDescription.Size = new Size(228, 132);
            rtxtDescription.TabIndex = 4;
            rtxtDescription.Text = "";
            // 
            // txtDeliveryName
            // 
            txtDeliveryName.Font = new Font("Segoe UI", 10F);
            txtDeliveryName.Location = new Point(184, 94);
            txtDeliveryName.Name = "txtDeliveryName";
            txtDeliveryName.Size = new Size(228, 25);
            txtDeliveryName.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            label3.Location = new Point(114, 300);
            label3.Name = "label3";
            label3.Size = new Size(53, 19);
            label3.TabIndex = 2;
            label3.Text = "Status:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            label2.Location = new Point(96, 150);
            label2.Name = "label2";
            label2.Size = new Size(89, 19);
            label2.TabIndex = 1;
            label2.Text = "Description:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            label1.Location = new Point(27, 75);
            label1.Name = "label1";
            label1.Size = new Size(114, 19);
            label1.TabIndex = 0;
            label1.Text = "Delivery Name:";
            // 
            // groupBox1
            // 
            groupBox1.BackColor = SystemColors.Desktop;
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(44, 19);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(438, 403);
            groupBox1.TabIndex = 7;
            groupBox1.TabStop = false;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            label4.Location = new Point(140, 19);
            label4.Name = "label4";
            label4.Size = new Size(155, 25);
            label4.TabIndex = 0;
            label4.Text = "Update Delivery";
            // 
            // UpdateDeliveryForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(525, 450);
            Controls.Add(btnSaveDelivery);
            Controls.Add(cboStatus);
            Controls.Add(rtxtDescription);
            Controls.Add(txtDeliveryName);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(groupBox1);
            Name = "UpdateDeliveryForm";
            Text = "Update Delivery";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        private Button btnSaveDelivery;
        private ComboBox cboStatus;
        private RichTextBox rtxtDescription;
        private TextBox txtDeliveryName;
        private Label label3;
        private Label label2;
        private Label label1;
        private GroupBox groupBox1;
        private Label label4;
    }
}
