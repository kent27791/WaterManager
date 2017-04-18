using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WaterManager.Controls;

namespace WaterManager.Extentions
{
    public static class ControlHelper
    {
        public static ucTextBox ValidateIsNumber(this ucTextBox textBox)
        {
            if (textBox != null)
            {
                int number;
                if (!Int32.TryParse(textBox.TextBoxField.Text, out number))
                {
                    textBox.ErrorProviderField.SetError(textBox, "Giá trị nhập vào phải là số.");
                    return null;
                }
                else
                {
                    textBox.ErrorProviderField.Clear();
                }
            }
            return textBox;

        }
        public static ucTextBox ValidateIsMoreThan(this ucTextBox textBoxNew, ucTextBox textBoxOld)
        {
            if (textBoxNew != null)
            {
                if (Convert.ToInt32(textBoxNew.TextBoxField.Text) <= Convert.ToInt32(textBoxOld.TextBoxField.Text))
                {
                    textBoxNew.ErrorProviderField.SetError(textBoxNew, "Giá trị mới phải lớn hơn giá trị củ.");
                    return null;
                }
                else
                {
                    textBoxNew.ErrorProviderField.Clear();
                }
            }
            return textBoxNew;
        }
        public static ucTextBox ValidateLength(this ucTextBox textBox, int length = 6)
        {
            if (textBox != null)
            {
                if (textBox.TextBoxField.Text.Length < length)
                {
                    textBox.ErrorProviderField.SetError(textBox, String.Format("Độ dài phải lớn hơn {0} ký tự", length));
                    return null;
                }
                else
                {
                    textBox.ErrorProviderField.Clear();
                }
            }
            return textBox;
            
        }
        public static ucTextBox ValidateIsEmpty(this ucTextBox textBox)
        {
            if(textBox != null)
            {
                if (String.IsNullOrEmpty(textBox.TextBoxField.Text))
                {
                    textBox.ErrorProviderField.SetError(textBox, "Giá trị không được để trống.");
                    return null;
                }
                else
                {
                    textBox.ErrorProviderField.Clear();
                }
            }
            return textBox;
            
        }
        
        public static void ResetTextBox(this GroupBox container)
        {
            foreach (Control control in container.Controls)
            {
                if (control is ucTextBox)
                {
                    ((ucTextBox)control).TextBoxField.Text = string.Empty;
                }
                else if (control is TextBox)
                {
                    ((TextBox)control).Text = string.Empty;
                }
            }
        }
    }
}
