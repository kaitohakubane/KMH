using Project.Bussiness_Layer;
using Project.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace Project.Presentation
{
    /// <summary>
    /// Interaction logic for ProductWindow.xaml
    /// </summary>
    public partial class ProductWindow : Window
    {
        bool isUpdate;
        public ProductWindow(bool Update)
        {
            InitializeComponent();
            isUpdate = Update;
            lblName.Content = "Add Product";
            loadData();                   
        }
        public void loadData()
        {
            cbbType.Items.Add("Nuoc ngot");
            cbbType.Items.Add("Banh");
            cbbType.Items.Add("Keo");
            cbbType.Items.Add("Kem");
            cbbType.Items.Add("Khac");
            if (isUpdate)
            {
                txtID.IsEnabled = false;
            }
            cbbType.SelectedIndex = 0;
        }
        public bool isValid()
        {
            int n;
            if (txtID.Text.Trim() == "")
            {
                System.Windows.Forms.MessageBox.Show("ID is not null");
                return false;
            }
            if (!int.TryParse(txtID.Text, out n))
            {
                System.Windows.Forms.MessageBox.Show("ID must be number and not contain spaces!");
                return false;
            }

            if (int.Parse(txtID.Text) <= 0 )
            {
                System.Windows.Forms.MessageBox.Show("0<ID");
                return false;
            }
            if (txtName.Text.Trim() == "")
            {
                System.Windows.Forms.MessageBox.Show("Name is not null");
                return false;
            }
            if (txtSupplierID.Text.Trim() == "")
            {
                System.Windows.Forms.MessageBox.Show("SupplierID is not null");
                return false;
            }
            if (!int.TryParse(txtSupplierID.Text, out n))
            {
                System.Windows.Forms.MessageBox.Show("SupplierID must be number and not contain spaces!");
                return false;
            }

            if (int.Parse(txtSupplierID.Text) <= 0)
            {
                System.Windows.Forms.MessageBox.Show("0<SupplierID");
                return false;
            }
            if (txtProducer.Text.Trim() == "")
            {
                System.Windows.Forms.MessageBox.Show("Producer is not null");
                return false;
            }
            if (txtOrigin.Text.Trim() == "")
            {
                System.Windows.Forms.MessageBox.Show("Origin is not null");
                return false;
            }

            if (txtInPrice.Text.Trim() == "")
            {
                System.Windows.Forms.MessageBox.Show("InPrice is not null");
                return false;
            }
            if (!int.TryParse(txtInPrice.Text, out n))
            {
                System.Windows.Forms.MessageBox.Show("InPrice must be number and not contain spaces!");
                return false;
            }

            if (int.Parse(txtInPrice.Text) <= 0)
            {
                System.Windows.Forms.MessageBox.Show("txtInPrice<ID");
                return false;
            }
            if (txtOutPrice.Text.Trim() == "")
            {
                System.Windows.Forms.MessageBox.Show("OutPrice is not null");
                return false;
            }
            if (!int.TryParse(txtOutPrice.Text, out n))
            {
                System.Windows.Forms.MessageBox.Show("OutPrice must be number and not contain spaces!");
                return false;
            }

            if (int.Parse(txtOutPrice.Text) <= 0)
            {
                System.Windows.Forms.MessageBox.Show("0<OutPrice");
                return false;
            }
            if (txtQuantity.Text.Trim() == "")
            {
                System.Windows.Forms.MessageBox.Show("Quantity is not null");
                return false;
            }
            if (!int.TryParse(txtQuantity.Text, out n))
            {
                System.Windows.Forms.MessageBox.Show("Quantity must be number and not contain spaces!");
                return false;
            }

            if (int.Parse(txtQuantity.Text) <= 0)
            {
                System.Windows.Forms.MessageBox.Show("0<Quantity");
                return false;
            }

            return true;
        }
        private void btnOK_Click(object sender, RoutedEventArgs e)
        {
            if (isValid())
            {
                if (isUpdate)
                {
                    lblName.Content = "Update Product";
                    try
                    {
                        if (!SupplierBL.GetSup(int.Parse(txtSupplierID.Text)))
                        {
                            System.Windows.Forms.MessageBox.Show("Supplier is not exist!");
                        }
                        else
                        {
                            Product pro = new Product();
                            pro.ProID = int.Parse(txtID.Text);
                            pro.ProName = txtName.Text.Trim();
                            pro.SupID = int.Parse(txtSupplierID.Text);
                            pro.Producer = txtProducer.Text.Trim();
                            pro.Origin = txtOrigin.Text.Trim();
                            pro.InPrice = int.Parse(txtInPrice.Text);
                            pro.OutPrice = int.Parse(txtOutPrice.Text);
                            pro.Quantity = int.Parse(txtQuantity.Text);
                            pro.Type = cbbType.SelectedItem.ToString();///////////////////
                            ProductBL.UpdateProduct(pro);
                            System.Windows.Forms.MessageBox.Show("Success");
                            this.Close();
                        }
                    }
                    catch (Exception h)
                    {
                        System.Windows.Forms.MessageBox.Show("Error " + h.Message);
                    }
                }
                else
                {
                    try
                    {
                        if (!SupplierBL.GetSup(int.Parse(txtSupplierID.Text)))
                        {
                            System.Windows.Forms.MessageBox.Show("Supplier is not exist!");
                        }
                        else
                        {
                            Product pro = new Product();
                            pro.ProID = int.Parse(txtID.Text);
                            pro.ProName = txtName.Text.Trim();
                            pro.SupID = int.Parse(txtSupplierID.Text);
                            pro.Producer = txtProducer.Text.Trim();
                            pro.Origin = txtOrigin.Text.Trim();
                            pro.InPrice = int.Parse(txtInPrice.Text);
                            pro.OutPrice = int.Parse(txtOutPrice.Text);
                            pro.Quantity = int.Parse(txtQuantity.Text);
                            pro.Type = cbbType.SelectedItem.ToString();///////////////////
                            ProductBL.AddProduct(pro);
                            System.Windows.Forms.MessageBox.Show("Success");
                            this.Close();
                        }
                    }
                    catch (Exception)
                    {
                        System.Windows.Forms.MessageBox.Show("ProductID is already existed!");
                    }
                }
            }
        }

        private void btnCancel_Click(object sender, RoutedEventArgs e)
        {
            this.DialogResult = false;
            this.Close();
        }        
        
    }
}
