namespace InventoryMGMTTuto
{
    partial class ManageOrders
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.customersGridView = new System.Windows.Forms.DataGridView();
            this.orderIDInput = new System.Windows.Forms.TextBox();
            this.customerIDInput = new System.Windows.Forms.TextBox();
            this.dateTimeInput = new System.Windows.Forms.DateTimePicker();
            this.productsGridView = new System.Windows.Forms.DataGridView();
            this.selectCombo = new System.Windows.Forms.ComboBox();
            this.button6 = new System.Windows.Forms.Button();
            this.quantityInput = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.orderGridView = new System.Windows.Forms.DataGridView();
            this.customerNameInput = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.sumResult = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.customersGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productsGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.button5);
            this.panel1.Controls.Add(this.button4);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(848, 106);
            this.panel1.TabIndex = 3;
            // 
            // button5
            // 
            this.button5.AutoSize = true;
            this.button5.BackColor = System.Drawing.Color.Red;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button5.ForeColor = System.Drawing.Color.Transparent;
            this.button5.Location = new System.Drawing.Point(776, 12);
            this.button5.Name = "button5";
            this.button5.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.button5.Size = new System.Drawing.Size(42, 38);
            this.button5.TabIndex = 4;
            this.button5.Text = "X";
            this.button5.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(12, 23);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(73, 51);
            this.button4.TabIndex = 3;
            this.button4.Text = "Home";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // label2
            // 
            this.label2.Dock = System.Windows.Forms.DockStyle.Top;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(0, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(848, 28);
            this.label2.TabIndex = 0;
            this.label2.Text = "Manage Orders";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(848, 46);
            this.label1.TabIndex = 0;
            this.label1.Text = "Inventory management system";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(145, 116);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(109, 28);
            this.label3.TabIndex = 28;
            this.label3.Text = "Customers";
            // 
            // customersGridView
            // 
            this.customersGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.customersGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.customersGridView.Location = new System.Drawing.Point(26, 150);
            this.customersGridView.Name = "customersGridView";
            this.customersGridView.RowHeadersWidth = 51;
            this.customersGridView.RowTemplate.Height = 29;
            this.customersGridView.Size = new System.Drawing.Size(373, 187);
            this.customersGridView.TabIndex = 27;
            this.customersGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.customersGridView_CellContentClick);
            // 
            // orderIDInput
            // 
            this.orderIDInput.Location = new System.Drawing.Point(26, 357);
            this.orderIDInput.Name = "orderIDInput";
            this.orderIDInput.PlaceholderText = "OrderId";
            this.orderIDInput.Size = new System.Drawing.Size(181, 27);
            this.orderIDInput.TabIndex = 29;
            // 
            // customerIDInput
            // 
            this.customerIDInput.ForeColor = System.Drawing.SystemColors.WindowText;
            this.customerIDInput.Location = new System.Drawing.Point(26, 390);
            this.customerIDInput.Name = "customerIDInput";
            this.customerIDInput.PlaceholderText = "CustomerID";
            this.customerIDInput.Size = new System.Drawing.Size(181, 27);
            this.customerIDInput.TabIndex = 30;
            // 
            // dateTimeInput
            // 
            this.dateTimeInput.Location = new System.Drawing.Point(26, 456);
            this.dateTimeInput.Name = "dateTimeInput";
            this.dateTimeInput.Size = new System.Drawing.Size(181, 27);
            this.dateTimeInput.TabIndex = 31;
            // 
            // productsGridView
            // 
            this.productsGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.productsGridView.Location = new System.Drawing.Point(422, 150);
            this.productsGridView.Name = "productsGridView";
            this.productsGridView.RowHeadersWidth = 51;
            this.productsGridView.RowTemplate.Height = 29;
            this.productsGridView.Size = new System.Drawing.Size(396, 187);
            this.productsGridView.TabIndex = 33;
            this.productsGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.productsGridView_CellContentClick);
            // 
            // selectCombo
            // 
            this.selectCombo.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.selectCombo.FormattingEnabled = true;
            this.selectCombo.Location = new System.Drawing.Point(541, 116);
            this.selectCombo.Name = "selectCombo";
            this.selectCombo.Size = new System.Drawing.Size(143, 28);
            this.selectCombo.TabIndex = 34;
            this.selectCombo.Text = "SelectCategory";
            this.selectCombo.SelectionChangeCommitted += new System.EventHandler(this.selectCombo_SelectionChangeCommitted);
            // 
            // button6
            // 
            this.button6.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button6.ForeColor = System.Drawing.Color.Black;
            this.button6.Location = new System.Drawing.Point(690, 116);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(57, 28);
            this.button6.TabIndex = 35;
            this.button6.Text = "Reload";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // quantityInput
            // 
            this.quantityInput.Location = new System.Drawing.Point(478, 357);
            this.quantityInput.Name = "quantityInput";
            this.quantityInput.PlaceholderText = "Quantity";
            this.quantityInput.Size = new System.Drawing.Size(143, 27);
            this.quantityInput.TabIndex = 36;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button1.ForeColor = System.Drawing.Color.Black;
            this.button1.Location = new System.Drawing.Point(627, 357);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(57, 28);
            this.button1.TabIndex = 37;
            this.button1.Text = "Add";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // orderGridView
            // 
            this.orderGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.orderGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.orderGridView.Location = new System.Drawing.Point(277, 391);
            this.orderGridView.Name = "orderGridView";
            this.orderGridView.RowHeadersWidth = 51;
            this.orderGridView.RowTemplate.Height = 29;
            this.orderGridView.Size = new System.Drawing.Size(541, 120);
            this.orderGridView.TabIndex = 38;
            this.orderGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // customerNameInput
            // 
            this.customerNameInput.ForeColor = System.Drawing.SystemColors.WindowText;
            this.customerNameInput.Location = new System.Drawing.Point(26, 423);
            this.customerNameInput.Name = "customerNameInput";
            this.customerNameInput.PlaceholderText = "CustomerName";
            this.customerNameInput.Size = new System.Drawing.Size(181, 27);
            this.customerNameInput.TabIndex = 39;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(478, 518);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 28);
            this.label5.TabIndex = 40;
            this.label5.Text = "Sum:";
            // 
            // sumResult
            // 
            this.sumResult.AutoSize = true;
            this.sumResult.Location = new System.Drawing.Point(532, 525);
            this.sumResult.Name = "sumResult";
            this.sumResult.Size = new System.Drawing.Size(17, 20);
            this.sumResult.TabIndex = 41;
            this.sumResult.Text = "€";
            this.sumResult.Click += new System.EventHandler(this.sumResult_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button2.ForeColor = System.Drawing.Color.Black;
            this.button2.Location = new System.Drawing.Point(26, 489);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(181, 26);
            this.button2.TabIndex = 42;
            this.button2.Text = "InsertOrders";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button3.ForeColor = System.Drawing.Color.Black;
            this.button3.Location = new System.Drawing.Point(26, 517);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(181, 26);
            this.button3.TabIndex = 43;
            this.button3.Text = "ViewOrders";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click_1);
            // 
            // ManageOrders
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(848, 555);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.sumResult);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.customerNameInput);
            this.Controls.Add(this.orderGridView);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.quantityInput);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.selectCombo);
            this.Controls.Add(this.productsGridView);
            this.Controls.Add(this.dateTimeInput);
            this.Controls.Add(this.orderIDInput);
            this.Controls.Add(this.customerIDInput);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.customersGridView);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ManageOrders";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ManageOrders";
            this.Load += new System.EventHandler(this.ManageOrders_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.customersGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productsGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Panel panel1;
        private Button button5;
        private Button button4;
        private Label label2;
        private Label label1;
        private Label label3;
        private DataGridView customersGridView;
        private TextBox orderIDInput;
        private TextBox customerIDInput;
        private DateTimePicker dateTimeInput;
        private DataGridView productsGridView;
        private ComboBox selectCombo;
        private Button button6;
        private TextBox quantityInput;
        private Button button1;
        private DataGridView orderGridView;
        private TextBox customerNameInput;
        private Label label5;
        private Label sumResult;
        private Button button2;
        private Button button3;
    }
}