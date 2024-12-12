using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace petrol
{
    public partial class Form1 : Form
    {
        // Bağlantı dizesini doğru şekilde güncelledim
        string connectionString = "Data Source=MÜZISYENN;Initial Catalog=PetrolSatisSistemi;Integrated Security=True;Encrypt=False;";



        public Form1()
        {
            InitializeComponent();
        }

        // Şube Ekleme
        private void btnAddBranch_Click(object sender, EventArgs e)
        {
            string branchName = txtBranchName.Text.Trim();
            string city = txtCity.Text.Trim();
            string address = txtAddress.Text.Trim();

            if (string.IsNullOrWhiteSpace(branchName) || string.IsNullOrWhiteSpace(city) || string.IsNullOrWhiteSpace(address))
            {
                MessageBox.Show("Lütfen tüm alanları doldurunuz.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string query = "INSERT INTO Branches (BranchName, City, Address) VALUES (@BranchName, @City, @Address)";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@BranchName", branchName);
                        command.Parameters.AddWithValue("@City", city);
                        command.Parameters.AddWithValue("@Address", address);

                        int result = command.ExecuteNonQuery();
                        if (result > 0)
                        {
                            MessageBox.Show("Şube başarıyla eklendi.", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            txtBranchName.Clear();
                            txtCity.Clear();
                            txtAddress.Clear();
                        }
                        else
                        {
                            MessageBox.Show("Şube eklenirken bir hata oluştu.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Yakıt Ekleme
        private void btnAddFuel_Click(object sender, EventArgs e)
        {
            string fuelType = txtFuelType.Text.Trim();
            decimal tankCapacity = 0;
            if (!decimal.TryParse(txtTankCapacity.Text.Trim(), out tankCapacity))
            {
                MessageBox.Show("Geçerli bir depo kapasitesi giriniz.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string query = "INSERT INTO Fuel (FuelType, TankCapacity) VALUES (@FuelType, @TankCapacity)";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@FuelType", fuelType);
                        command.Parameters.AddWithValue("@TankCapacity", tankCapacity);

                        int result = command.ExecuteNonQuery();
                        if (result > 0)
                        {
                            MessageBox.Show("Yakıt başarıyla eklendi.", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            txtFuelType.Clear();
                            txtTankCapacity.Clear();
                        }
                        else
                        {
                            MessageBox.Show("Yakıt eklenirken bir hata oluştu.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Veritabanı bağlantısını test etmek için eklenen bir metod
        private void TestConnection()
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    MessageBox.Show("Veritabanı bağlantısı başarılı.", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Bağlantı hatası: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: Bu kod satırı 'petrolSatisSistemiDataSet.Subeler' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.subelerTableAdapter.Fill(this.petrolSatisSistemiDataSet.Subeler);

        }
    }
}
