using Microsoft.Data.SqlClient;
using System.Data;


namespace ProgrammingInCSharpStore.MyWindowsformApp
{
    public partial class ProductForm : Form
    {

        private int CategoryId;

        private string connectionString = "Data Source=localhost;Initial Catalog=ProgrammingInCSharpStoreDB;Integrated Security=True;";

        public ProductForm()
        {
            InitializeComponent();
        }
        public ProductForm(int categoryId)
        {
            InitializeComponent();

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
                    int id = reader.GetInt32(0);
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



        private void LoadCategories()
        {
            using SqlConnection connection = new SqlConnection(connectionString);

            string query = @" SELECT Id, PersianName, ParentCategoryId
                              FROM Category
                              WHERE IsDeleted = 0
                              ORDER BY Id";

            using SqlCommand command = new SqlCommand(query, connection);

            connection.Open();

            using SqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                int categoryId = Convert.ToInt32(reader["Id"]);
                string categoryName = reader["PersianName"].ToString();

                ToolStripMenuItem item = new ToolStripMenuItem(categoryName);

                item.Tag = categoryId;

                item.Click += CategoryItem_Click;

                categoryToolStripMenuItem.DropDownItems.Add(item);
            }
        }

        private void CategoryItem_Click(object sender, EventArgs e)
        {
            ToolStripMenuItem item = (ToolStripMenuItem)sender;


            if (item.Tag == null)
            {
                MessageBox.Show(".CategoryId برای این آیتم تنظیم نشده است");
                return;
            }

            int categoryId = (int)item.Tag;

            CategoryId = categoryId;

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

                productsDataGridView.DataSource = table;
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "خطا در دریافت محصولات:\n" + ex.Message, "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        
    }
}
