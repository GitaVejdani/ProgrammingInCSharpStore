
using ProgrammingInCSharpStore.MyWindowsformApp.Domain.Models;

namespace ProgrammingInCSharpStore.MyWindowsformApp.Forms;

    public partial class ProductDetailForm : Form
    {
    private Product product;
    public ProductDetailForm()
        {
            InitializeComponent();
        }

   public ProductDetailForm(int productId)
    {
        InitializeComponent();

        
    }
}

