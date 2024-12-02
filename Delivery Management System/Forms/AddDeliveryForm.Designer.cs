namespace Delivery_Management_System.Forms
{
    partial class AddDeliveryForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            txtDeliveryName = new TextBox();
            rtxtDescription = new RichTextBox();
            cboStatus = new ComboBox();
            btnSaveDelivery = new Button();
            groupBox1 = new GroupBox();
            label4 = new Label();
            label1 = new Label();
            label3 = new Label();
            label5 = new Label();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // txtDeliveryName
            // 
            txtDeliveryName.Location = new Point(139, 64);
            txtDeliveryName.Margin = new Padding(2);
            txtDeliveryName.Name = "txtDeliveryName";
            txtDeliveryName.Size = new Size(228, 23);
            txtDeliveryName.TabIndex = 3;
            // 
            // rtxtDescription
            // 
            rtxtDescription.Location = new Point(139, 133);
            rtxtDescription.Margin = new Padding(2);
            rtxtDescription.Name = "rtxtDescription";
            rtxtDescription.Size = new Size(228, 130);
            rtxtDescription.TabIndex = 4;
            rtxtDescription.Text = "";
            rtxtDescription.TextChanged += rtxtDescription_TextChanged;
            // 
            // cboStatus
            // 
            cboStatus.FormattingEnabled = true;
            cboStatus.Items.AddRange(new object[] { "New", "In Progress", "Delivered" });
            cboStatus.Location = new Point(139, 307);
            cboStatus.Margin = new Padding(2);
            cboStatus.Name = "cboStatus";
            cboStatus.Size = new Size(228, 23);
            cboStatus.TabIndex = 5;
            // 
            // btnSaveDelivery
            // 
            btnSaveDelivery.BackColor = Color.DarkBlue;
            btnSaveDelivery.FlatStyle = FlatStyle.Flat;
            btnSaveDelivery.ForeColor = Color.White;
            btnSaveDelivery.Location = new Point(236, 358);
            btnSaveDelivery.Margin = new Padding(2);
            btnSaveDelivery.Name = "btnSaveDelivery";
            btnSaveDelivery.Size = new Size(131, 36);
            btnSaveDelivery.TabIndex = 6;
            btnSaveDelivery.Text = "Save";
            btnSaveDelivery.UseVisualStyleBackColor = false;
            btnSaveDelivery.Click += btnSaveDelivery_Click;
            // 
            // groupBox1
            // 
            groupBox1.BackColor = SystemColors.Desktop;
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(txtDeliveryName);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(rtxtDescription);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(cboStatus);
            groupBox1.Controls.Add(btnSaveDelivery);
            groupBox1.Location = new Point(29, 11);
            groupBox1.Margin = new Padding(2);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(2);
            groupBox1.Size = new Size(459, 412);
            groupBox1.TabIndex = 7;
            groupBox1.TabStop = false;
            groupBox1.Enter += groupBox1_Enter;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            label4.Location = new Point(160, 18);
            label4.Name = "label4";
            label4.Size = new Size(127, 25);
            label4.TabIndex = 11;
            label4.Text = "Add Delivery";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            label1.Location = new Point(0, 68);
            label1.Name = "label1";
            label1.Size = new Size(114, 19);
            label1.TabIndex = 10;
            label1.Text = "Delivery Name:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            label3.Location = new Point(5, 133);
            label3.Name = "label3";
            label3.Size = new Size(89, 19);
            label3.TabIndex = 9;
            label3.Text = "Description:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            label5.Location = new Point(31, 311);
            label5.Name = "label5";
            label5.Size = new Size(53, 19);
            label5.TabIndex = 8;
            label5.Text = "Status:";
            // 
            // AddDeliveryForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(515, 442);
            Controls.Add(groupBox1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(2);
            Name = "AddDeliveryForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "AddDeliveryForm";
            Load += AddDeliveryForm_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private TextBox txtDeliveryName;
        private RichTextBox rtxtDescription;
        private ComboBox cboStatus;
        private Button btnSaveDelivery;
        private GroupBox groupBox1;
        private Label label5;
        private Label label3;
        private Label label1;
        private Label label4;
    }
}
