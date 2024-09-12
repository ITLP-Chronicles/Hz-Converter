using HzConverter.SecondsComparator;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HzConverter
{
    public partial class NumberBox : UserControl
    {
        private SecondUnits _selfUnit;
        [Category("Custom Props")]
        [Description("The unit of the number")]
        public SecondUnits Unit
        {
            get => _selfUnit;
            set => _selfUnit = value;
        }

        public string InnerText
        {
            get => _innerBox.Text;
            set => _innerBox.Text = value;
        }

        public event KeyEventHandler InnerKeyUp
        {
            add => _innerBox.KeyUp += value;
            remove => _innerBox.KeyUp -= value;
        }

        public event EventHandler InnerTextChange
        {
            add => _innerBox.TextChanged += value;
            remove => _innerBox.TextChanged -= value;
        }

        private TextBox _innerBox;
        private Regex _validator = new Regex(@"^\d*(\.)?(\d+)?$");

        public NumberBox()
        {
            InitializeComponent();
            _innerBox = textBox1;
            ConfigInnerTextBox();
        }

        private void ConfigInnerTextBox()
        {
            _innerBox.KeyPress += (sender, e) =>
            {
                if(!_validator.IsMatch(_innerBox.Text + e.KeyChar) 
                   && e.KeyChar != (char)Keys.Back)
                {
                    e.Handled = true;
                }
            };
        }
    }
}
