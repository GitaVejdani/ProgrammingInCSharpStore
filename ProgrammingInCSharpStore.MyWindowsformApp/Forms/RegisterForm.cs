using Microsoft.Data.SqlClient;
namespace ProgrammingInCSharpStore.MyWindowsformApp.Forms;

public partial class RegisterForm : Form
{
    public RegisterForm()
    {
        InitializeComponent();
    }

    private void registerButton_Click(object sender, EventArgs e)
    {
        string connectionString = "Data Source=localhost;Initial Catalog=ProgrammingInCSharpStoreDB;Integrated Security=True;TrustServerCertificate=True;";

        string firstName = firstNameTextBox.Text;


        string lastName = lastNameTextBox.Text;


        string nationalCode = nationalCodeTextBox.Text;


        string phoneNumber = phoneNumberTextBox.Text;

        string address = addressTextBox.Text;

        string emailAddress = emailTextBox.Text;

        string username = userNameTextBox.Text;

        string password = passwordTextBox.Text;

        string confirmPassword = confirmPasswordTextBox.Text;

        DateTime datetime = DateTime.Now;

        




        if (string.IsNullOrEmpty(firstName) || string.IsNullOrEmpty(lastName) || string.IsNullOrEmpty(nationalCode) ||
            string.IsNullOrEmpty(phoneNumber) || string.IsNullOrEmpty(address) || string.IsNullOrEmpty(emailAddress) ||
            string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password) || string.IsNullOrEmpty(confirmPassword))

        {
            MessageBox.Show(".لطفاً تمام فیلدها را تکمیل کنید");
            return;
        }


        if (password != confirmPassword)
        {
            MessageBox.Show(".رمز عبور و تکرار رمز عبور یکسان نیستند");
            return;
        }



        using SqlConnection connection = new SqlConnection(connectionString);

        try
        {
            connection.Open();


            string checkUsernameQuery = "SELECT COUNT(*) FROM Customer WHERE Username = @Username";

            using SqlCommand checkCommand = new SqlCommand(checkUsernameQuery, connection);

            checkCommand.Parameters.AddWithValue("@Username", username);

            int usernameCount = (int)checkCommand.ExecuteScalar();

            if (usernameCount > 0)
            {
                MessageBox.Show(".این نام کاربری قبلاً ثبت شده است");
                return;
            }


            string insertQuery = @"INSERT INTO Customer( FirstName,LastName,NationalCode,PhoneNumber,Address,Email,Username,Password,CreatedAt)
                                                
                                                 VALUES( @FirstName, @LastName,@NationalCode,@PhoneNumber,@Address,@Email,@Username,@Password,@CreatedAt)";

            using SqlCommand command = new SqlCommand(insertQuery, connection);

            command.Parameters.AddWithValue("@FirstName", firstName);
            command.Parameters.AddWithValue("@LastName", lastName);
            command.Parameters.AddWithValue("@NationalCode", nationalCode);
            command.Parameters.AddWithValue("@PhoneNumber", phoneNumber);
            command.Parameters.AddWithValue("@Address", address);
            command.Parameters.AddWithValue("@Email", emailAddress);
            command.Parameters.AddWithValue("@Username", username);
            command.Parameters.AddWithValue("@Password", password);
            command.Parameters.AddWithValue("@CreatedAt", datetime); 


            command.ExecuteNonQuery();

            MessageBox.Show("ثبت نام با موفقیت انجام شد.");

            firstNameTextBox.Clear();
            lastNameTextBox.Clear();
            nationalCodeTextBox.Clear();
            phoneNumberTextBox.Clear();
            addressTextBox.Clear();
            emailTextBox.Clear();
            userNameTextBox.Clear();
            passwordTextBox.Clear();
            confirmPasswordTextBox.Clear();
        }
        catch (Exception ex)
        {
            MessageBox.Show("خطا در ثبت اطلاعات:\n" + ex.Message, "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }


  

    private void cancelButton_Click(object sender, EventArgs e)
    {
        this.Hide();
        
    }
}
