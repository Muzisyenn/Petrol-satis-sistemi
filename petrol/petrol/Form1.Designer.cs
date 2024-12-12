namespace petrol
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.lblBranchName = new System.Windows.Forms.Label();
            this.txtBranchName = new System.Windows.Forms.TextBox();
            this.lblCity = new System.Windows.Forms.Label();
            this.txtCity = new System.Windows.Forms.TextBox();
            this.lblAddress = new System.Windows.Forms.Label();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.btnAddBranch = new System.Windows.Forms.Button();
            this.lblFuelType = new System.Windows.Forms.Label();
            this.txtFuelType = new System.Windows.Forms.TextBox();
            this.lblTankCapacity = new System.Windows.Forms.Label();
            this.txtTankCapacity = new System.Windows.Forms.TextBox();
            this.btnAddFuel = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.petrolSatisSistemiDataSet = new petrol.PetrolSatisSistemiDataSet();
            this.subelerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.subelerTableAdapter = new petrol.PetrolSatisSistemiDataSetTableAdapters.SubelerTableAdapter();
            this.subeIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.subeAdiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sehirDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.adresDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.petrolSatisSistemiDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.subelerBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // lblBranchName
            // 
            this.lblBranchName.AutoSize = true;
            this.lblBranchName.Location = new System.Drawing.Point(16, 18);
            this.lblBranchName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblBranchName.Name = "lblBranchName";
            this.lblBranchName.Size = new System.Drawing.Size(65, 16);
            this.lblBranchName.TabIndex = 0;
            this.lblBranchName.Text = "Şube Adı:";
            // 
            // txtBranchName
            // 
            this.txtBranchName.Location = new System.Drawing.Point(133, 15);
            this.txtBranchName.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtBranchName.Name = "txtBranchName";
            this.txtBranchName.Size = new System.Drawing.Size(265, 22);
            this.txtBranchName.TabIndex = 1;
            // 
            // lblCity
            // 
            this.lblCity.AutoSize = true;
            this.lblCity.Location = new System.Drawing.Point(16, 62);
            this.lblCity.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCity.Name = "lblCity";
            this.lblCity.Size = new System.Drawing.Size(41, 16);
            this.lblCity.TabIndex = 2;
            this.lblCity.Text = "Şehir:";
            // 
            // txtCity
            // 
            this.txtCity.Location = new System.Drawing.Point(133, 58);
            this.txtCity.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtCity.Name = "txtCity";
            this.txtCity.Size = new System.Drawing.Size(265, 22);
            this.txtCity.TabIndex = 3;
            // 
            // lblAddress
            // 
            this.lblAddress.AutoSize = true;
            this.lblAddress.Location = new System.Drawing.Point(16, 105);
            this.lblAddress.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(46, 16);
            this.lblAddress.TabIndex = 4;
            this.lblAddress.Text = "Adres:";
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(133, 101);
            this.txtAddress.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(265, 22);
            this.txtAddress.TabIndex = 5;
            // 
            // btnAddBranch
            // 
            this.btnAddBranch.Location = new System.Drawing.Point(133, 148);
            this.btnAddBranch.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnAddBranch.Name = "btnAddBranch";
            this.btnAddBranch.Size = new System.Drawing.Size(267, 37);
            this.btnAddBranch.TabIndex = 6;
            this.btnAddBranch.Text = "Şube Ekle";
            this.btnAddBranch.UseVisualStyleBackColor = true;
            this.btnAddBranch.Click += new System.EventHandler(this.btnAddBranch_Click);
            // 
            // lblFuelType
            // 
            this.lblFuelType.AutoSize = true;
            this.lblFuelType.Location = new System.Drawing.Point(16, 197);
            this.lblFuelType.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFuelType.Name = "lblFuelType";
            this.lblFuelType.Size = new System.Drawing.Size(66, 16);
            this.lblFuelType.TabIndex = 7;
            this.lblFuelType.Text = "Yakıt Tipi:";
            // 
            // txtFuelType
            // 
            this.txtFuelType.Location = new System.Drawing.Point(133, 193);
            this.txtFuelType.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtFuelType.Name = "txtFuelType";
            this.txtFuelType.Size = new System.Drawing.Size(265, 22);
            this.txtFuelType.TabIndex = 8;
            // 
            // lblTankCapacity
            // 
            this.lblTankCapacity.AutoSize = true;
            this.lblTankCapacity.Location = new System.Drawing.Point(16, 246);
            this.lblTankCapacity.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTankCapacity.Name = "lblTankCapacity";
            this.lblTankCapacity.Size = new System.Drawing.Size(110, 16);
            this.lblTankCapacity.TabIndex = 9;
            this.lblTankCapacity.Text = "Depo Kapasitesi:";
            // 
            // txtTankCapacity
            // 
            this.txtTankCapacity.Location = new System.Drawing.Point(133, 242);
            this.txtTankCapacity.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtTankCapacity.Name = "txtTankCapacity";
            this.txtTankCapacity.Size = new System.Drawing.Size(265, 22);
            this.txtTankCapacity.TabIndex = 10;
            // 
            // btnAddFuel
            // 
            this.btnAddFuel.Location = new System.Drawing.Point(133, 283);
            this.btnAddFuel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnAddFuel.Name = "btnAddFuel";
            this.btnAddFuel.Size = new System.Drawing.Size(267, 37);
            this.btnAddFuel.TabIndex = 11;
            this.btnAddFuel.Text = "Yakıt Ekle";
            this.btnAddFuel.UseVisualStyleBackColor = true;
            this.btnAddFuel.Click += new System.EventHandler(this.btnAddFuel_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.subeIDDataGridViewTextBoxColumn,
            this.subeAdiDataGridViewTextBoxColumn,
            this.sehirDataGridViewTextBoxColumn,
            this.adresDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.subelerBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(473, 58);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(555, 150);
            this.dataGridView1.TabIndex = 12;
            // 
            // petrolSatisSistemiDataSet
            // 
            this.petrolSatisSistemiDataSet.DataSetName = "PetrolSatisSistemiDataSet";
            this.petrolSatisSistemiDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // subelerBindingSource
            // 
            this.subelerBindingSource.DataMember = "Subeler";
            this.subelerBindingSource.DataSource = this.petrolSatisSistemiDataSet;
            // 
            // subelerTableAdapter
            // 
            this.subelerTableAdapter.ClearBeforeFill = true;
            // 
            // subeIDDataGridViewTextBoxColumn
            // 
            this.subeIDDataGridViewTextBoxColumn.DataPropertyName = "SubeID";
            this.subeIDDataGridViewTextBoxColumn.HeaderText = "SubeID";
            this.subeIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.subeIDDataGridViewTextBoxColumn.Name = "subeIDDataGridViewTextBoxColumn";
            this.subeIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.subeIDDataGridViewTextBoxColumn.Width = 125;
            // 
            // subeAdiDataGridViewTextBoxColumn
            // 
            this.subeAdiDataGridViewTextBoxColumn.DataPropertyName = "SubeAdi";
            this.subeAdiDataGridViewTextBoxColumn.HeaderText = "SubeAdi";
            this.subeAdiDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.subeAdiDataGridViewTextBoxColumn.Name = "subeAdiDataGridViewTextBoxColumn";
            this.subeAdiDataGridViewTextBoxColumn.Width = 125;
            // 
            // sehirDataGridViewTextBoxColumn
            // 
            this.sehirDataGridViewTextBoxColumn.DataPropertyName = "Sehir";
            this.sehirDataGridViewTextBoxColumn.HeaderText = "Sehir";
            this.sehirDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.sehirDataGridViewTextBoxColumn.Name = "sehirDataGridViewTextBoxColumn";
            this.sehirDataGridViewTextBoxColumn.Width = 125;
            // 
            // adresDataGridViewTextBoxColumn
            // 
            this.adresDataGridViewTextBoxColumn.DataPropertyName = "Adres";
            this.adresDataGridViewTextBoxColumn.HeaderText = "Adres";
            this.adresDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.adresDataGridViewTextBoxColumn.Name = "adresDataGridViewTextBoxColumn";
            this.adresDataGridViewTextBoxColumn.Width = 125;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1333, 332);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnAddFuel);
            this.Controls.Add(this.txtTankCapacity);
            this.Controls.Add(this.lblTankCapacity);
            this.Controls.Add(this.txtFuelType);
            this.Controls.Add(this.lblFuelType);
            this.Controls.Add(this.btnAddBranch);
            this.Controls.Add(this.txtAddress);
            this.Controls.Add(this.lblAddress);
            this.Controls.Add(this.txtCity);
            this.Controls.Add(this.lblCity);
            this.Controls.Add(this.txtBranchName);
            this.Controls.Add(this.lblBranchName);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "Petrol Satış Sistemi";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.petrolSatisSistemiDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.subelerBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private System.Windows.Forms.Label lblBranchName;
        private System.Windows.Forms.TextBox txtBranchName;
        private System.Windows.Forms.Label lblCity;
        private System.Windows.Forms.TextBox txtCity;
        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.Button btnAddBranch;
        private System.Windows.Forms.Label lblFuelType;
        private System.Windows.Forms.TextBox txtFuelType;
        private System.Windows.Forms.Label lblTankCapacity;
        private System.Windows.Forms.TextBox txtTankCapacity;
        private System.Windows.Forms.Button btnAddFuel;
        private System.Windows.Forms.DataGridView dataGridView1;
        private PetrolSatisSistemiDataSet petrolSatisSistemiDataSet;
        private System.Windows.Forms.BindingSource subelerBindingSource;
        private PetrolSatisSistemiDataSetTableAdapters.SubelerTableAdapter subelerTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn subeIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn subeAdiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sehirDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn adresDataGridViewTextBoxColumn;
    }
}
