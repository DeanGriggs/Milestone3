namespace Milestone_3
{
    partial class InventoryMain
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
            this.lbl_Quantity = new System.Windows.Forms.Label();
            this.TB_Quan = new System.Windows.Forms.TextBox();
            this.BTN_ClearForm = new System.Windows.Forms.Button();
            this.BTN_Remove = new System.Windows.Forms.Button();
            this.BTN_add = new System.Windows.Forms.Button();
            this.CB_Department = new System.Windows.Forms.ComboBox();
            this.lbl_Price = new System.Windows.Forms.Label();
            this.lbl_Sku = new System.Windows.Forms.Label();
            this.TB_Price = new System.Windows.Forms.TextBox();
            this.TB_Sku = new System.Windows.Forms.TextBox();
            this.BTN_Load = new System.Windows.Forms.Button();
            this.BTN_Edit = new System.Windows.Forms.Button();
            this.BTN_Save = new System.Windows.Forms.Button();
            this.TB_Name = new System.Windows.Forms.TextBox();
            this.Edit_seachField = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Edit_seachField)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_Quantity
            // 
            this.lbl_Quantity.AutoSize = true;
            this.lbl_Quantity.Location = new System.Drawing.Point(273, 81);
            this.lbl_Quantity.Name = "lbl_Quantity";
            this.lbl_Quantity.Size = new System.Drawing.Size(49, 13);
            this.lbl_Quantity.TabIndex = 46;
            this.lbl_Quantity.Text = "Quantity:";
            // 
            // TB_Quan
            // 
            this.TB_Quan.Location = new System.Drawing.Point(276, 97);
            this.TB_Quan.Name = "TB_Quan";
            this.TB_Quan.Size = new System.Drawing.Size(219, 20);
            this.TB_Quan.TabIndex = 45;
            // 
            // BTN_ClearForm
            // 
            this.BTN_ClearForm.BackColor = System.Drawing.Color.Wheat;
            this.BTN_ClearForm.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BTN_ClearForm.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_ClearForm.Location = new System.Drawing.Point(521, 181);
            this.BTN_ClearForm.Name = "BTN_ClearForm";
            this.BTN_ClearForm.Size = new System.Drawing.Size(219, 36);
            this.BTN_ClearForm.TabIndex = 44;
            this.BTN_ClearForm.Text = "Clear";
            this.BTN_ClearForm.UseVisualStyleBackColor = false;
            this.BTN_ClearForm.Click += new System.EventHandler(this.BTN_ClearForm_Click_1);
            // 
            // BTN_Remove
            // 
            this.BTN_Remove.BackColor = System.Drawing.Color.Wheat;
            this.BTN_Remove.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BTN_Remove.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_Remove.Location = new System.Drawing.Point(276, 139);
            this.BTN_Remove.Name = "BTN_Remove";
            this.BTN_Remove.Size = new System.Drawing.Size(219, 36);
            this.BTN_Remove.TabIndex = 43;
            this.BTN_Remove.Text = "Remove";
            this.BTN_Remove.UseVisualStyleBackColor = false;
            this.BTN_Remove.Click += new System.EventHandler(this.BTN_Remove_Click_1);
            // 
            // BTN_add
            // 
            this.BTN_add.BackColor = System.Drawing.Color.Wheat;
            this.BTN_add.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BTN_add.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_add.Location = new System.Drawing.Point(38, 139);
            this.BTN_add.Name = "BTN_add";
            this.BTN_add.Size = new System.Drawing.Size(219, 36);
            this.BTN_add.TabIndex = 42;
            this.BTN_add.Text = "Add";
            this.BTN_add.UseVisualStyleBackColor = false;
            this.BTN_add.Click += new System.EventHandler(this.BTN_add_Click_1);
            // 
            // CB_Department
            // 
            this.CB_Department.FormattingEnabled = true;
            this.CB_Department.Items.AddRange(new object[] {
            "Tools",
            "Appliances",
            "Consumables",
            "Hardware",
            "Misc"});
            this.CB_Department.Location = new System.Drawing.Point(38, 96);
            this.CB_Department.Name = "CB_Department";
            this.CB_Department.Size = new System.Drawing.Size(219, 21);
            this.CB_Department.TabIndex = 40;
            // 
            // lbl_Price
            // 
            this.lbl_Price.AutoSize = true;
            this.lbl_Price.Location = new System.Drawing.Point(518, 42);
            this.lbl_Price.Name = "lbl_Price";
            this.lbl_Price.Size = new System.Drawing.Size(34, 13);
            this.lbl_Price.TabIndex = 39;
            this.lbl_Price.Text = "Price:";
            // 
            // lbl_Sku
            // 
            this.lbl_Sku.AutoSize = true;
            this.lbl_Sku.Location = new System.Drawing.Point(273, 42);
            this.lbl_Sku.Name = "lbl_Sku";
            this.lbl_Sku.Size = new System.Drawing.Size(36, 13);
            this.lbl_Sku.TabIndex = 38;
            this.lbl_Sku.Text = "Sku#:";
            // 
            // TB_Price
            // 
            this.TB_Price.Location = new System.Drawing.Point(521, 58);
            this.TB_Price.Name = "TB_Price";
            this.TB_Price.Size = new System.Drawing.Size(219, 20);
            this.TB_Price.TabIndex = 36;
            // 
            // TB_Sku
            // 
            this.TB_Sku.Location = new System.Drawing.Point(276, 58);
            this.TB_Sku.Name = "TB_Sku";
            this.TB_Sku.Size = new System.Drawing.Size(219, 20);
            this.TB_Sku.TabIndex = 35;
            this.TB_Sku.TextChanged += new System.EventHandler(this.TB_Sku_TextChanged);
            // 
            // BTN_Load
            // 
            this.BTN_Load.BackColor = System.Drawing.Color.Wheat;
            this.BTN_Load.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BTN_Load.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_Load.Location = new System.Drawing.Point(521, 139);
            this.BTN_Load.Name = "BTN_Load";
            this.BTN_Load.Size = new System.Drawing.Size(219, 36);
            this.BTN_Load.TabIndex = 34;
            this.BTN_Load.Text = "Load";
            this.BTN_Load.UseVisualStyleBackColor = false;
            this.BTN_Load.Click += new System.EventHandler(this.BTN_Load_Click);
            // 
            // BTN_Edit
            // 
            this.BTN_Edit.BackColor = System.Drawing.Color.Wheat;
            this.BTN_Edit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BTN_Edit.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_Edit.Location = new System.Drawing.Point(276, 181);
            this.BTN_Edit.Name = "BTN_Edit";
            this.BTN_Edit.Size = new System.Drawing.Size(219, 36);
            this.BTN_Edit.TabIndex = 33;
            this.BTN_Edit.Text = "Edit";
            this.BTN_Edit.UseVisualStyleBackColor = false;
            this.BTN_Edit.Click += new System.EventHandler(this.BTN_Edit_Click_1);
            // 
            // BTN_Save
            // 
            this.BTN_Save.BackColor = System.Drawing.Color.Wheat;
            this.BTN_Save.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BTN_Save.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_Save.Location = new System.Drawing.Point(38, 181);
            this.BTN_Save.Name = "BTN_Save";
            this.BTN_Save.Size = new System.Drawing.Size(219, 36);
            this.BTN_Save.TabIndex = 32;
            this.BTN_Save.Text = "Save";
            this.BTN_Save.UseVisualStyleBackColor = false;
            this.BTN_Save.Click += new System.EventHandler(this.BTN_Save_Click_1);
            // 
            // TB_Name
            // 
            this.TB_Name.Location = new System.Drawing.Point(38, 58);
            this.TB_Name.Name = "TB_Name";
            this.TB_Name.Size = new System.Drawing.Size(219, 20);
            this.TB_Name.TabIndex = 31;
            // 
            // Edit_seachField
            // 
            this.Edit_seachField.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Edit_seachField.BackgroundColor = System.Drawing.Color.Tan;
            this.Edit_seachField.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Edit_seachField.Location = new System.Drawing.Point(12, 240);
            this.Edit_seachField.Name = "Edit_seachField";
            this.Edit_seachField.Size = new System.Drawing.Size(752, 276);
            this.Edit_seachField.TabIndex = 30;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(35, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 13);
            this.label1.TabIndex = 47;
            this.label1.Text = "Item Name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(35, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 13);
            this.label2.TabIndex = 48;
            this.label2.Text = "Department:";
            // 
            // InventoryMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Bisque;
            this.ClientSize = new System.Drawing.Size(776, 528);
            this.Controls.Add(this.TB_Name);
            this.Controls.Add(this.TB_Sku);
            this.Controls.Add(this.TB_Price);
            this.Controls.Add(this.CB_Department);
            this.Controls.Add(this.TB_Quan);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbl_Quantity);
            this.Controls.Add(this.BTN_ClearForm);
            this.Controls.Add(this.BTN_Remove);
            this.Controls.Add(this.BTN_add);
            this.Controls.Add(this.lbl_Price);
            this.Controls.Add(this.lbl_Sku);
            this.Controls.Add(this.BTN_Load);
            this.Controls.Add(this.BTN_Edit);
            this.Controls.Add(this.BTN_Save);
            this.Controls.Add(this.Edit_seachField);
            this.Name = "InventoryMain";
            this.Text = "Inventory";
            this.Load += new System.EventHandler(this.InventoryMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Edit_seachField)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_Quantity;
        private System.Windows.Forms.TextBox TB_Quan;
        private System.Windows.Forms.Button BTN_ClearForm;
        private System.Windows.Forms.Button BTN_Remove;
        private System.Windows.Forms.Button BTN_add;
        private System.Windows.Forms.ComboBox CB_Department;
        private System.Windows.Forms.Label lbl_Price;
        private System.Windows.Forms.Label lbl_Sku;
        private System.Windows.Forms.TextBox TB_Price;
        private System.Windows.Forms.TextBox TB_Sku;
        private System.Windows.Forms.Button BTN_Load;
        private System.Windows.Forms.Button BTN_Edit;
        private System.Windows.Forms.Button BTN_Save;
        private System.Windows.Forms.TextBox TB_Name;
        public System.Windows.Forms.DataGridView Edit_seachField;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

