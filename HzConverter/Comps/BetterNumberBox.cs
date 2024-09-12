using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using HzConverter.Utils;

namespace HzConverter.Comps
{
    internal class BetterNumberBox : TextBox
    {
        private Powers_of_Ten _selfUnit;
        [Category("Custom Props")]
        [Description("The unit of the number")]
        public Powers_of_Ten Unit
        {
            get => _selfUnit;
            set => _selfUnit = value;
        }

        private Regex _validator = new Regex(@"^\d*(\.)?(\d+)?$");

        public BetterNumberBox()
        {
            ConfigInnerTextBox();
        }

        private void ConfigInnerTextBox()
        {
            Leave += (sender, e) =>
            {
                if (Text == string.Empty)
                {
                    Text = "0";
                }
            };

            KeyPress += (sender, e) =>
            {
                if (!_validator.IsMatch(Text + e.KeyChar)
                   && e.KeyChar != (char)Keys.Back)
                {
                    e.Handled = true;
                }
            };
        }
    }
}
