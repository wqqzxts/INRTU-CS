namespace class_lab3 {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }

        private void comboTypeFirst_SelectedIndexChanged(object sender, EventArgs e) {

        }

        private void comboTypeSecond_SelectedIndexChanged(object sender, EventArgs e) {

        }

        private void comboOperation_SelectedIndexChanged(object sender, EventArgs e) {

        }

        private void comboTypeResult_SelectedIndexChanged(object sender, EventArgs e) {

        }
        
        private void Form1_Load(object sender, EventArgs e) {

        }

        private void textFirst_TextChanged(object sender, EventArgs e) {
            Calculate();
        }

        private void textSecond_TextChanged(object sender, EventArgs e) {
            Calculate();
        }

        public void Calculate() {
            var firstValue = double.Parse(textFirst.ToString());
            var secondValue= double.Parse(textSecond.ToString());

            var firstTemperature = new Temperature(firstValue, Type.K);
            var secondTemperature = new Temperature(secondValue, Type.K);

            Temperature resultTemperature;

            switch (comboOperation.Text) {
                case "+":
                    resultTemperature = firstTemperature + secondTemperature;
                    break;
                case "-":
                    resultTemperature = firstTemperature + secondTemperature;
                    break;
                case "*":
                    resultTemperature = firstTemperature * secondValue;
                    break;
                case ">/</=":

                    break;
                default:
                    resultTemperature = new Temperature(0, Type.K);
                    break;
            }
        }

        private void onValueChanged(object sender, EventArgs e) {
            Calculate();
        }
    }    
}
