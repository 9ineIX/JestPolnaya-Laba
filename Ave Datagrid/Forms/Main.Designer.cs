namespace Ave_Datagrid
{
    partial class Main
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
            dgvProducts = new DataGridView();
            txtName = new TextBox();
            txtPrice = new TextBox();
            txtQuantity = new TextBox();
            btnAdd = new Button();
            btnUpdate = new Button();
            btnDelete = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvProducts).BeginInit();
            SuspendLayout();
            // 
            // dgvProducts
            // 
            dgvProducts.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvProducts.Location = new Point(2, 12);
            dgvProducts.Name = "dgvProducts";
            dgvProducts.Size = new Size(578, 426);
            dgvProducts.TabIndex = 0;
            // 
            // txtName
            // 
            txtName.Location = new Point(595, 26);
            txtName.Name = "txtName";
            txtName.Size = new Size(193, 23);
            txtName.TabIndex = 1;
            // 
            // txtPrice
            // 
            txtPrice.Location = new Point(595, 73);
            txtPrice.Name = "txtPrice";
            txtPrice.Size = new Size(193, 23);
            txtPrice.TabIndex = 2;
            // 
            // txtQuantity
            // 
            txtQuantity.Location = new Point(595, 117);
            txtQuantity.Name = "txtQuantity";
            txtQuantity.Size = new Size(193, 23);
            txtQuantity.TabIndex = 3;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(595, 155);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(193, 28);
            btnAdd.TabIndex = 4;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(595, 202);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(193, 28);
            btnUpdate.TabIndex = 5;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click_1;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(595, 245);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(193, 28);
            btnDelete.TabIndex = 6;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(670, 8);
            label1.Name = "label1";
            label1.Size = new Size(39, 15);
            label1.TabIndex = 8;
            label1.Text = "Name";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(670, 55);
            label2.Name = "label2";
            label2.Size = new Size(33, 15);
            label2.TabIndex = 9;
            label2.Text = "Price";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(660, 99);
            label3.Name = "label3";
            label3.Size = new Size(49, 15);
            label3.TabIndex = 10;
            label3.Text = "Quanity";
            // 
            // Main
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnDelete);
            Controls.Add(btnUpdate);
            Controls.Add(btnAdd);
            Controls.Add(txtQuantity);
            Controls.Add(txtPrice);
            Controls.Add(txtName);
            Controls.Add(dgvProducts);
            Name = "Main";
            Text = "Main";
            ((System.ComponentModel.ISupportInitialize)dgvProducts).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvProducts;
        private TextBox txtName;
        private TextBox txtPrice;
        private TextBox txtQuantity;
        private Button btnAdd;
        private Button btnUpdate;
        private Button btnDelete;
        private Label label1;
        private Label label2;
        private Label label3;
    }
}