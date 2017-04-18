using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using WaterManager.Controls;
using WaterManager.Extentions;

namespace WaterManager
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();

            Initial();

            buttonAdd.Click += (s, e) =>
            {
                groupBoxLeft.ResetTextBox();
                groupBoxRight.ResetTextBox();
            };

            buttonCheckInfo.Click += (s, e) =>
            {
                if (ucTextBoxCustomerId.ValidateLength(6).ValidateIsNumber() != null && 
                    ucTextBoxCustomerName.ValidateIsEmpty() != null &&
                    ucTextBoxCustomerAddress.ValidateIsEmpty() != null &&
                    ucTextBoxCustomerAddress.ValidateIsEmpty() != null &&
                    ucTextBoxWaterNumberOld.ValidateIsNumber() != null &&
                    ucTextBoxWaterNumberNew.ValidateIsNumber().ValidateIsMoreThan(ucTextBoxWaterNumberOld) != null)
                {
                    buttonChecking.Enabled = true;
                }
            };

            buttonChecking.Click += (s, e) =>
            {
                int waterUsed = Convert.ToInt32(ucTextBoxWaterNumberNew.TextBoxField.Text) - Convert.ToInt32(ucTextBoxWaterNumberOld.TextBoxField.Text);
                int price = waterUsed.CaculatorWaterPrice();
                int priceWithTax = price.CaculatorWaterPriceWithTax(10);

                ucTextBoxWaterNumberUsed.TextBoxField.Text = waterUsed.ToString();
                ucTextBoxNumberPrice.TextBoxField.Text = String.Format("{0:C0}", price);
                ucTextBoxNumberCheckout.TextBoxField.Text = String.Format("{0:C0}", priceWithTax);
                textBoxAddressChecking.Text = new StringBuilder()
                                                        .AppendLine("Mã khách hàng : " + ucTextBoxCustomerId.TextBoxField.Text)
                                                        .AppendLine("Họ tên : " + ucTextBoxCustomerName.TextBoxField.Text)
                                                        .AppendLine("Địa chỉ : " + ucTextBoxCustomerAddress.TextBoxField.Text)
                                                        .AppendLine("Đơn tính tiền nước tháng : " + comboBoxMonth.SelectedValue)
                                                        .ToString();
            };

            buttonExit.Click += (s, e) =>
            {
                DialogResult exitResult = MessageBox.Show("Bạn có muốn thoát chương trình", "Thoát chương trình", MessageBoxButtons.YesNo);
                if (exitResult == DialogResult.Yes)
                {
                    Application.Exit();
                }
            };

        }
        public void Initial()
        {
            comboBoxMonth.DataSource = Enumerable.Range(1, 12).ToArray();

            ucTextBoxCustomerId.LabelField.Text = "Mã khách hàng";
            ucTextBoxCustomerName.LabelField.Text = "Họ và tên";
            ucTextBoxCustomerAddress.LabelField.Text = "Địa chỉ";
            ucTextBoxWaterNumberOld.LabelField.Text = "Số củ";
            ucTextBoxWaterNumberNew.LabelField.Text = "Số mới";

            ucTextBoxWaterNumberUsed.LabelField.Text = "Số nước tiêu thụ";
            ucTextBoxWaterNumberUsed.TextBoxField.Enabled = false;

            ucTextBoxNumberPrice.LabelField.Text = "Số tiền";
            ucTextBoxNumberPrice.TextBoxField.Enabled = false;

            ucTextBoxNumberTax.LabelField.Text = "Thuế";
            ucTextBoxNumberTax.TextBoxField.Text = "10%";
            ucTextBoxNumberTax.TextBoxField.Enabled = false;

            ucTextBoxNumberCheckout.LabelField.Text = "Thành tiền";
            ucTextBoxNumberCheckout.TextBoxField.Enabled = false;

            textBoxAddressChecking.Enabled = false;

            buttonChecking.Enabled = false;
        }
    }
}
