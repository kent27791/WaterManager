using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WaterManager.Controls
{
    public partial class ucTextBox : UserControl
    {
        public Label LabelField
        {
            get { return labelField; }
            set { labelField = value; }
        }
        public TextBox TextBoxField
        {
            get { return textBoxField; }
            set { textBoxField = value; }
        }

        public ErrorProvider ErrorProviderField
        {
            get { return errorProviderField; }
            set { errorProviderField = value; }
        }
        public ucTextBox()
        {
            InitializeComponent();
        }
    }
}
