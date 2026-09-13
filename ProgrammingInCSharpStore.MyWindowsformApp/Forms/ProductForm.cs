using Microsoft.Data.SqlClient;
using ProgrammingInCSharpStore.Business.Businesses;
using ProgrammingInCSharpStore.MyWindowsformApp.Domain.Models;
using ProgrammingInCSharpStore.MyWindowsformApp.Forms;
using System.Data;


namespace ProgrammingInCSharpStore.MyWindowsformApp
{
    public partial class ProductForm : Form
    {

        private int CategoryId;

        private string connectionString = "Data Source=localhost;Initial Catalog=ProgrammingInCSharpStoreDB;Integrated Security=True;TrustServerCertificate=True;";

        List<Product> products = new List<Product>();
        Product targetProduct = null;
        ProductBusiness productBusiness = new();


        public ProductForm()
        {
            InitializeComponent();
            SetCategoryIds();
            RegisterCategoryEvents();

        }
        public ProductForm(int categoryId)
        {
            InitializeComponent();

            SetCategoryIds();
            RegisterCategoryEvents();

            CategoryId = categoryId;

            LoadProducts();
        }

        private void SetCategoryIds()
        {
            string query = @" SELECT Id, PersianName
                              FROM Category
                               WHERE IsDeleted = 0";

            try
            {
                using SqlConnection connection = new SqlConnection(connectionString);
                connection.Open();

                using SqlCommand command = new SqlCommand(query, connection);

                using SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    int id = Convert.ToInt32(reader[0]);

                    string persianName = reader.GetString(1);

                    switch (persianName)
                    {
                        case "پردازنده":
                            cPUToolStripMenuItem.Tag = id;
                            break;

                        case "مادربورد":
                            motherboardToolStripMenuItem.Tag = id;
                            break;

                        case "رم":
                            rAMToolStripMenuItem.Tag = id;
                            break;

                        case "کیس":
                            caseToolStripMenuItem.Tag = id;
                            break;

                        case "منبع تغذیه":
                            powerSupplyToolStripMenuItem.Tag = id;
                            break;

                        case "مانیتور":
                            monitorToolStripMenuItem.Tag = id;
                            break;

                        case "ماوس":
                            mouseToolStripMenuItem.Tag = id;
                            break;

                        case "کیبورد":
                            keyboardToolStripMenuItem.Tag = id;
                            break;

                        case "مودم":
                            modemToolStripMenuItem.Tag = id;
                            break;

                        case "کارت شبکه":
                            networkCardToolStripMenuItem.Tag = id;
                            break;

                        case "لوازم جانبی شبکه":
                            networkAccessoriesToolStripMenuItem.Tag = id;
                            break;
                    }
                }
            }
            catch (Exception ex)
            { 
                MessageBox.Show(  "خطا در دریافت دسته‌بندی‌ها:\n" + ex.Message, "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void RegisterCategoryEvents()
        {
            cPUToolStripMenuItem.Click += CategoryItem_Click;
            motherboardToolStripMenuItem.Click += CategoryItem_Click;
            rAMToolStripMenuItem.Click += CategoryItem_Click;
            caseToolStripMenuItem.Click += CategoryItem_Click;
            powerSupplyToolStripMenuItem.Click += CategoryItem_Click;

            monitorToolStripMenuItem.Click += CategoryItem_Click;
            mouseToolStripMenuItem.Click += CategoryItem_Click;
            keyboardToolStripMenuItem.Click += CategoryItem_Click;

            modemToolStripMenuItem.Click += CategoryItem_Click;
            networkCardToolStripMenuItem.Click += CategoryItem_Click;
            networkAccessoriesToolStripMenuItem.Click += CategoryItem_Click;
        }

        private void CategoryItem_Click(object sender, EventArgs e)

        {
            
            ToolStripMenuItem item = (ToolStripMenuItem)sender;

            if (item.Tag == null)
            {
                MessageBox.Show( ".برای این دسته‌بندی CategoryId تنظیم نشده است", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                return;
            }

            CategoryId = Convert.ToInt32(item.Tag);
           // MessageBox.Show("CategoryId = " + CategoryId);

            LoadProducts();

        }

        private void LoadProducts()
        {

            try
            {
                string query = @" SELECT   Id,Name,Price,CurrentStock,ImageUrl
                                  FROM    Product
                                  WHERE   CategoryId = @CategoryId  AND IsDeleted = 0";

                using SqlConnection connection = new SqlConnection(connectionString);

                using SqlCommand command = new SqlCommand(query, connection);

                command.Parameters.Add("@CategoryId", SqlDbType.Int).Value = CategoryId;

                using SqlDataAdapter adapter = new SqlDataAdapter(command);

                DataTable table = new DataTable();

                adapter.Fill(table);

                productDataGridView.DataSource = table;
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "خطا در دریافت محصولات:\n" + ex.Message, "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        private void productDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
                return;

            var row = productDataGridView.Rows[e.RowIndex];

            int id = Convert.ToInt32(row.Cells["Id"].Value);

            Product selectedProduct = null;

            foreach (var product in products)
            {
                if (product.Id == id)
                {
                    selectedProduct = product;
                    break;
                }
            }

            if (selectedProduct == null)
            {
                MessageBox.Show("محصول پیدا نشد.");
                return;
            }

            ProductDetailForm productDetailForm = new ProductDetailForm(selectedProduct);

            productDetailForm.ShowDialog();
        }


    }
}
