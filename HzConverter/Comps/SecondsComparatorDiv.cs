using System.Data;

namespace HzConverter
{
    public partial class SecondsComparatorDiv : UserControl
    {
        private NumberBox _selected;
        private NumberBox[] _toChange;

        public SecondsComparatorDiv()
        {
            InitializeComponent();
            StartupEvents();
        }

        private void StartupEvents()
        {
            foreach (var nb in Controls.OfType<NumberBox>())
            {
                nb.Enter += (invokerObj, e) =>
                {
                    _selected = (NumberBox)invokerObj;
                    _selected.InnerKeyUp += SelectedBehavior;
                    _selected.Leave += (sender, e) => _selected.InnerKeyUp -= SelectedBehavior;
                    _toChange = Controls.OfType<NumberBox>()
                        .Where(nb => nb != _selected).ToArray();
                };
            }
        }

        private void SelectedBehavior(object? sender, EventArgs e)
        {
            AutoUpdateValue(SanitizeInput(_selected.InnerText));
        }

        private double SanitizeInput(string inputValue)
        {
            if (inputValue == "") return 0;
            if (inputValue.StartsWith(".")) return double.Parse("0" + inputValue);
            if (double.TryParse(inputValue, out double result)) return result;
            return 0;
        }

        private void AutoUpdateValue(double inputValue)
        {
            foreach (var nb in _toChange) 
            { 
                double rawHz = inputValue * ((double)nb.Unit);
                double result = rawHz / ((double)_selected.Unit);
                nb.InnerText = result.ToString();
            }
        }
    }
}
