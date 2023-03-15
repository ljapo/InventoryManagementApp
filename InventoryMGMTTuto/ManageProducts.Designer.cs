namespace InventoryMGMTTuto
{
    partial class ManageProducts
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
            this.button5 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button4 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.productPriceInput = new System.Windows.Forms.TextBox();
            this.productQtyInput = new System.Windows.Forms.TextBox();
            this.productNameInput = new System.Windows.Forms.TextBox();
            this.productIDInput = new System.Windows.Forms.TextBox();
            this.descriptionInput = new System.Windows.Forms.TextBox();
            this.CategoryCombo = new System.Windows.Forms.ComboBox();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.productsGridView = new System.Windows.Forms.DataGridView();
            this.selectCombo = new System.Windows.Forms.ComboBox();
            this.searchButton = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.productsGridView)).BeginInit();
            this.SuspendLayout();
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
            this.panel1.TabIndex = 2;
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
            this.label2.Text = "Manage Products";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label4.Location = new System.Drawing.Point(149, 125);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 20);
            this.label4.TabIndex = 19;
            this.label4.Text = "Clear";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // productPriceInput
            // 
            this.productPriceInput.Location = new System.Drawing.Point(12, 247);
            this.productPriceInput.Name = "productPriceInput";
            this.productPriceInput.PlaceholderText = "ProductPrice";
            this.productPriceInput.Size = new System.Drawing.Size(181, 27);
            this.productPriceInput.TabIndex = 15;
            // 
            // productQtyInput
            // 
            this.productQtyInput.Location = new System.Drawing.Point(12, 214);
            this.productQtyInput.Name = "productQtyInput";
            this.productQtyInput.PlaceholderText = "ProductQty";
            this.productQtyInput.Size = new System.Drawing.Size(181, 27);
            this.productQtyInput.TabIndex = 16;
            // 
            // productNameInput
            // 
            this.productNameInput.Location = new System.Drawing.Point(12, 181);
            this.productNameInput.Name = "productNameInput";
            this.productNameInput.PlaceholderText = "ProductName";
            this.productNameInput.Size = new System.Drawing.Size(181, 27);
            this.productNameInput.TabIndex = 17;
            // 
            // productIDInput
            // 
            this.productIDInput.ForeColor = System.Drawing.SystemColors.WindowText;
            this.productIDInput.Location = new System.Drawing.Point(12, 148);
            this.productIDInput.Name = "productIDInput";
            this.productIDInput.PlaceholderText = "ProductId";
            this.productIDInput.Size = new System.Drawing.Size(181, 27);
            this.productIDInput.TabIndex = 18;
            // 
            // descriptionInput
            // 
            this.descriptionInput.Location = new System.Drawing.Point(12, 280);
            this.descriptionInput.Name = "descriptionInput";
            this.descriptionInput.PlaceholderText = "Description";
            this.descriptionInput.Size = new System.Drawing.Size(181, 27);
            this.descriptionInput.TabIndex = 20;
            // 
            // CategoryCombo
            // 
            this.CategoryCombo.FormattingEnabled = true;
            this.CategoryCombo.Location = new System.Drawing.Point(12, 313);
            this.CategoryCombo.Name = "CategoryCombo";
            this.CategoryCombo.Size = new System.Drawing.Size(181, 28);
            this.CategoryCombo.TabIndex = 21;
            this.CategoryCombo.Text = "ProductCategory";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(12, 422);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(181, 29);
            this.button3.TabIndex = 22;
            this.button3.Text = "Delete";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(12, 387);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(181, 29);
            this.button2.TabIndex = 23;
            this.button2.Text = "Edit";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 352);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(181, 29);
            this.button1.TabIndex = 24;
            this.button1.Text = "Add";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(455, 114);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(134, 31);
            this.label3.TabIndex = 26;
            this.label3.Text = "PRODUCTS";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // productsGridView
            // 
            this.productsGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.productsGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.productsGridView.Location = new System.Drawing.Point(219, 150);
            this.productsGridView.Name = "productsGridView";
            this.productsGridView.RowHeadersWidth = 51;
            this.productsGridView.RowTemplate.Height = 29;
            this.productsGridView.Size = new System.Drawing.Size(608, 393);
            this.productsGridView.TabIndex = 25;
            this.productsGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.productsGridView_CellContentClick);
            // 
            // selectCombo
            // 
            this.selectCombo.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.selectCombo.FormattingEnabled = true;
            this.selectCombo.Location = new System.Drawing.Point(12, 471);
            this.selectCombo.Name = "selectCombo";
            this.selectCombo.Size = new System.Drawing.Size(118, 25);
            this.selectCombo.TabIndex = 21;
            this.selectCombo.Text = "SelectCategory";
            this.selectCombo.SelectedIndexChanged += new System.EventHandler(this.selectCombo_SelectedIndexChanged);
            // 
            // searchButton
            // 
            this.searchButton.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.searchButton.Location = new System.Drawing.Point(136, 468);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(57, 29);
            this.searchButton.TabIndex = 27;
            this.searchButton.Text = "Search";
            this.searchButton.UseVisualStyleBackColor = true;
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // button6
            // 
            this.button6.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button6.ForeColor = System.Drawing.Color.Black;
            this.button6.Location = new System.Drawing.Point(136, 503);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(57, 28);
            this.button6.TabIndex = 5;
            this.button6.Text = "Reload";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click_1);
            // 
            // ManageProducts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(848, 555);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.searchButton);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.productsGridView);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.selectCombo);
            this.Controls.Add(this.CategoryCombo);
            this.Controls.Add(this.descriptionInput);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.productPriceInput);
            this.Controls.Add(this.productNameInput);
            this.Controls.Add(this.productQtyInput);
            this.Controls.Add(this.productIDInput);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ManageProducts";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ManageProducts";
            this.Load += new System.EventHandler(this.ManageProducts_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.productsGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button button5;
        private Label label1;
        private Panel panel1;
        private Button button4;
        private Label label2;
        private Label label4;
        private TextBox productPriceInput;
        private TextBox productQtyInput;
        private TextBox productNameInput;
        private TextBox productIDInput;
        private TextBox descriptionInput;
        private ComboBox CategoryCombo;
        private Button button3;
        private Button button2;
        private Button button1;
        private Label label3;
        private DataGridView productsGridView;
        private ComboBox selectCombo;
        private Button searchButton;
        private Button button6;
    }
}