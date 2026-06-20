using Newtonsoft.Json;
using ProgrammingInCSharp___Store.Models;

namespace ProgrammingInCSharp___Store;

public partial class LoginForm : Form
{
    List<Customer> customers = new List<Customer>();

    public LoginForm()
    {
        InitializeComponent();

        string jsonDataStr = string.Empty;
        string filePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Data", "AdminLogin.json");
        if (File.Exists(filePath)) 
        {
             jsonDataStr = File.ReadAllText(filePath);
            if (!string.IsNullOrEmpty(jsonDataStr))
            {
                customers = JsonConvert.DeserializeObject<List<Customer>>(jsonDataStr);
                //RefreshForm();
                //ResetForm();
            }
        }
        
    }


    private void button1_Click(object sender, EventArgs e)
    {
        string username = userNameTextBox.Text;
        string password = passwordTextBox.Text;

    }

    private void button2_Click(object sender, EventArgs e)
    {
        string username = userNameTextBox.Text; 
        string password = passwordTextBox.Text;
        List<AdminLogin> logins = null;

        string jsonDataStr = string.Empty;
        string filePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Data", "AdminLogin.json");
        if (File.Exists(filePath))
        {
            jsonDataStr = File.ReadAllText(filePath);
            if (!string.IsNullOrEmpty(jsonDataStr))
            {
                logins = JsonConvert.DeserializeObject<List<AdminLogin>>(jsonDataStr);
                
            }
        }
        if (logins is null || logins.Count == 0)
        {
            MessageBox.Show("لطفا ابتدا فایل کانفیگ ادمین‌ها را ایجاد نمائید.");
            return;
        }

        for (int i = 0; i < logins.Count; i++) 
        {
            if (logins[i].Username == username && logins[i].Password == password)
            {
                ProductForm productForm = new ProductForm();
                productForm.ShowDialog();
                return;
            }
            else
            {
                MessageBox.Show("لطفا نام کاربری یا رمز عبور صحیح را وارد نمائید.");
                return;
            }
        }
    }
}
