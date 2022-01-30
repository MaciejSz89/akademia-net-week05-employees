using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;

namespace EmployeesControls
{
    public partial class CurrencyTextBox : UserControl
    {
        public CurrencyTextBox()
        {

            InitializeComponent();
            ValidateTextBoxValue(_tbInternalTextBox);
            OnValueChanged += CurrencyTextBox_OnValueChanged;
        }

        private void textBox1_Validated(object sender, EventArgs e)
        {
            ValidateTextBoxValue((TextBox)sender);
        }

        private void CurrencyTextBox_SizeChanged(object sender, EventArgs e)
        {
            _tbInternalTextBox.Size = this.Size;
        }

        public string CultureName { get; set; } = CultureInfo.CurrentCulture.Name;

        public decimal Value
        {
            get
            {
                return _value;

            }
            set
            {
                if (value != _value)
                {
                    _value = value;
                    OnValueChanged(this, null);
                }
            }
        }

        private decimal _value = 0.0M;

        private void ValidateTextBoxValue(TextBox textBox)
        {

            if (decimal.TryParse(textBox.Text, out decimal value))
                _value = value;

            textBox.Text = $"{Value.ToString("C", CultureInfo.CreateSpecificCulture(CultureName))}";
        }

        public event Action<object, EventArgs> OnValueChanged; 


        private void CurrencyTextBox_OnValueChanged(object sender, EventArgs e)
        {
            _tbInternalTextBox.Text = $"{Value.ToString("C", CultureInfo.CreateSpecificCulture(CultureName))}";
        }

    }
}
