using Microsoft.Data.SqlClient;
using System.Net;

namespace ProgrammingInCSharpStore.MyWindowsformApp.Forms;

public partial class ProductDetailForm : Form
{
    private readonly int productId;

    private readonly string connectionString = "Server=localhost,14330;Database=ProgrammingInCSharpStoreDB;User Id=sa;Password=SqlServer@123;TrustServerCertificate=True;";

    public ProductDetailForm(int productId)
    {
        InitializeComponent();
        
        this.RightToLeft = RightToLeft.Yes;
        
        this.RightToLeftLayout = true;

        this.productId = productId;

        productPictureBox.SizeMode = PictureBoxSizeMode.Zoom;

        LoadProduct();

        
    }


    private void LoadProduct()
    {
        string query = @" SELECT Name , PersianName , Price , CurrentStock ,ImageUrl
                          FROM Product
                          WHERE Id = @ProductId AND IsDeleted=0 ";

        try
        {
            using SqlConnection connection = new SqlConnection(connectionString);

            using SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@ProductId", productId);

            connection.Open();

            using SqlDataReader reader = command.ExecuteReader();

            if (reader.Read())
            {

                string productName;

                if (reader["PersianName"] != DBNull.Value && !string.IsNullOrEmpty(reader["PersianName"].ToString()))

                    productName = reader["PersianName"].ToString();

                else

                    productName = reader["Name"].ToString();


                productNameTextBox.Text = productName;


           
                decimal price = Convert.ToDecimal(reader["Price"]);

                productPriceTextBox.Text = price.ToString("N0") + " تومان";


       
                int stock = Convert.ToInt32(reader["CurrentStock"]);

                if (stock > 0)
                {
                    statusTextBox.Text = "موجود";
                }
                else
                {
                    statusTextBox.Text = "ناموجود";
                }

                if (reader["ImageUrl"] != DBNull.Value)
                {
                    string imageUrl = reader["ImageUrl"].ToString();

                    if (!string.IsNullOrEmpty(imageUrl))
                    {
                        LoadProductImage(imageUrl);
                    }
                }
            }
            else
            {
                MessageBox.Show(".محصول پیدا نشد", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                Close();
            }
        }
        catch (Exception ex)
        {
            MessageBox.Show(":خطا در دریافت اطلاعات محصول\n" + ex.Message, "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }


    private async Task LoadProductImage(string imageUrl)
    {
        try
        {
            using WebClient client = new WebClient();

            byte[] imageBytes = client.DownloadData(imageUrl);

            using MemoryStream stream = new MemoryStream(imageBytes);

            using Image tempImage = Image.FromStream(stream);

            productPictureBox.Image = new Bitmap(tempImage);
        }
        catch
        {
            productPictureBox.Image = null;
        }
    }

   
}

