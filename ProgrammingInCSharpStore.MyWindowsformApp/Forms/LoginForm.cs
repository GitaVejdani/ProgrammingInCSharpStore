using Newtonsoft.Json;
using ProgrammingInCSharpStore.MyWindowsformApp.Dtos;
using ProgrammingInCSharpStore.MyWindowsformApp.Forms;



namespace ProgrammingInCSharpStore.MyWindowsformApp;

public partial class LoginForm : Form
{
    List<AdminLogin> logins = null;

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
                logins = JsonConvert.DeserializeObject<List<AdminLogin>>(jsonDataStr);
                
            }
        }
    }

    private void loginButton_Click(object sender, EventArgs e)
    {
       
        string username = userNameTextBox.Text;
        string password = passwordTextBox.Text;
        bool successLogin = false;
        
        
        if (logins is null || logins.Count == 0)
        {
            MessageBox.Show(".لطفا ابتدا فایل کانفیگ ادمین‌ها را ایجاد نمائید");
            return;
        }
        if (logins.Any(x => x.Username.Trim() == username.Trim() && x.Password.Trim() == password.Trim()))
            successLogin = true;
        
        //for (int i = 0; i < logins.Count; i++)
        //    if (logins[i].Username.Trim().ToLower() == username.Trim().ToLower() && logins[i].Password.Trim() == password.Trim())
        //        successLogin = true;

        if (successLogin)
        {
            this.Hide();
            ProductForm productForm = new ProductForm();
            productForm.FormClosed += (s, args) =>
            {
                this.Show();
            };
            productForm.ShowDialog();
            return;
        }
        else
        {
            MessageBox.Show(".لطفا نام کاربری یا رمز عبور صحیح را وارد نمائید");
            return;
        }

    }

    private void forgetPasswordButton_Click(object sender, EventArgs e)
    {
        ForgetPasswordForm forgetpasswordForm = new ForgetPasswordForm();

        this.Hide();

        forgetpasswordForm.ShowDialog();

        this.Show();
        
    }

    private void registerButton_Click(object sender, EventArgs e)
    {
        RegisterForm registerForm = new RegisterForm();
        registerForm.ShowDialog();
    }

  
}
