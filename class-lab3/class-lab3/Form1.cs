namespace class_lab3 {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();

            var measureItems = new string[] { "C", "Fa", "K", "Ra", };
            var measureItemsWithNumber = new string[] { "C", "Fa", "K", "Ra", "Number" };

            comboOperation.SelectedIndex = 0;
            comboTypeFirst.DataSource = new List<string>(measureItems);
            comboTypeSecond.DataSource = new List<string>(measureItemsWithNumber);
            comboTypeResult.DataSource = new List<string>(measureItems);

            onValueChanged(null, null);
        } 

        private void Form1_Load(object sender, EventArgs e) {

        }

        private void textFirst_TextChanged(object sender, EventArgs e) {
            Calculate();
        }

        private void textSecond_TextChanged(object sender, EventArgs e) {
            Calculate();
        }

        private Type GetMeasureType(ComboBox comboBox) {
            Type type;
            switch (comboBox.Text) {
                case "C":
                    type = Type.C;
                    break;
                case "Fa":
                    type = Type.Fa;
                    break;
                case "K":
                    type = Type.K;
                    break;
                case "Ra":
                    type = Type.Ra;
                    break;
                default:
                    type = Type.C;
                    break;
            }
            return type;
        }

        public void Calculate() {
            try {
                var firstValue = double.Parse(textFirst.Text);
                var secondValue = double.Parse(textSecond.Text);

                Type firstType = GetMeasureType(comboTypeFirst);
                Type secondType = GetMeasureType(comboTypeSecond);
                Type resultType = GetMeasureType(comboTypeResult);

                var firstTemperature = new Temperature(firstValue, firstType);
                var secondTemperature = new Temperature(secondValue, secondType);

                Temperature resultTemperature = null;
                string resultText = string.Empty;

                switch (comboOperation.Text) {
                    case "+":
                        resultTemperature = firstTemperature + secondTemperature;
                        break;
                    case "-":
                        resultTemperature = firstTemperature - secondTemperature;
                        break;
                    case "*":
                        resultTemperature = firstTemperature * secondValue;
                        break;
                    case ">":
                        resultText = firstTemperature > secondTemperature
                            ? "Первая температура больше второй"
                            : "Первая температура не больше второй";
                        break;
                    case "<":
                        resultText = firstTemperature < secondTemperature
                            ? "Первая температура меньше второй"
                            : "Первая температура не меньше второй";
                        break;
                    case "==":
                        resultText = firstTemperature == secondTemperature
                            ? "Температуры равны"
                            : "Температуры не равны";
                        break;
                    case "!=":
                        resultText = firstTemperature != secondTemperature
                            ? "Температуры не равны"
                            : "Температуры равны";
                        break;
                    default:
                        resultText = "Неизвестная операция";
                        break;
                }

                if (comboOperation.Text == ">" || comboOperation.Text == "<" || comboOperation.Text == "!=" || comboOperation.Text == "==") {
                    textResult.Text = resultText;
                } else {
                    textResult.Text = resultTemperature.To(resultType).Verbose();
                }
            } catch (FormatException) {
                textResult.Text = "Введите числовые значения.";
            }
        }

        private void onValueChanged(object sender, EventArgs e) {
            if (comboOperation == null || comboTypeSecond == null)
                return;

            if (comboOperation.Text == "*") {
                comboTypeSecond.SelectedItem = "Number";
                comboTypeSecond.Enabled = false;
            } else {
                comboTypeSecond.Enabled = true;
                if (comboTypeSecond.SelectedItem != null && comboTypeSecond.SelectedItem.ToString() == "Number") {
                    comboTypeSecond.SelectedItem = "C";
                }
            }

            Calculate();
        }
    }
}
