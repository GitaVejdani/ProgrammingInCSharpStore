
using Newtonsoft.Json;
using ProgrammingInCSharpStore.MyWindowsformApp.Dtos;


namespace ProgrammingInCSharpStore.MyWindowsformApp.Forms;

public partial class ForgetPasswordForm : Form
{
    List<CustomerInfo> customers = null;
    string jsonDataStr = string.Empty;
    string filePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Data", "CustomerInfo.json");
    public ForgetPasswordForm()
    {
        InitializeComponent();
        
        if (File.Exists(filePath))
        {
            jsonDataStr = File.ReadAllText(filePath);
            if (!string.IsNullOrEmpty(jsonDataStr))
            {
                customers = JsonConvert.DeserializeObject<List<CustomerInfo>>(jsonDataStr);

            }
        }
    }
  
    private void verifyCodeButton_Click(object sender, EventArgs e)
    {
        string username = userNameTextBox.Text;
        string emailAddress = emailAddressTextBox.Text;
        string verificationCode = Random.Shared.Next(100000, 1000000).ToString();


        if (string.IsNullOrEmpty(userNameTextBox.Text) ||  string.IsNullOrEmpty(emailAddressTextBox.Text))
        {
            MessageBox.Show("لطفاً نام کاربری و ایمیل را وارد کنید.");
            return;
        }


        var customer = customers?.FirstOrDefault(x => x.Username.Equals(username,StringComparison.OrdinalIgnoreCase)&&
                                                x.EmailAddress.Equals(emailAddress,StringComparison.OrdinalIgnoreCase));

        if (customer == null)
        {
            MessageBox.Show("نام کاربری یا ایمیل صحیح نیست.");
            return;
        }




        customer.VerificationCode = verificationCode;
        string json = JsonConvert.SerializeObject(customers, Formatting.Indented);
       
        File.WriteAllText(filePath, json);

        
        MessageBox.Show("کد تأیید به ایمیل شما ارسال شد.");       

  
    }
}
