namespace if_gui {
    public partial class Form1 : Form {
        // Даны вещественные положительные числа a, b, c. Если существует треугольник со сторонами a, b, c, то определить, является ли он прямоугольным.
        public Form1() {
            InitializeComponent();
            this.Text = "Lab 2"

            triangA.Text = Properties.Settings.Default.cacheTriangA.ToString();
            triangB.Text = Properties.Settings.Default.cacheTriangB.ToString();
            triangC.Text = Properties.Settings.Default.cacheTriangC.ToString();
        }

        private void label1_Click(object sender, EventArgs e) {

        }

        private void button1_Click(object sender, EventArgs e) {
            double a, b, c;

            try {
                a = double.Parse(this.triangA.Text);
                b = double.Parse(this.triangB.Text);
                c = double.Parse(this.triangC.Text);
            } catch(FormatException) {
                return;
            }

            Properties.Settings.Default.cacheTriangA = a;
            Properties.Settings.Default.cacheTriangB = b;
            Properties.Settings.Default.cacheTriangC = c;
            Properties.Settings.Default.Save();

            MessageBox.Show(Logic.checkTriangle(a, b, c));
        }
    }

    public class Logic {
        public static string checkTriangle(double a, double b, double c) {
            double Accuracy = 0.01;
            bool isTriangle = false;
            bool isRight = false;
            if (a + b > c && a + c > b && b + c > a) {
                isTriangle = true;
                if (Math.Abs(a * a + b * b - c * c) < Accuracy || Math.Abs(a * a + c * c - b * b) < Accuracy || Math.Abs(b * b + c * c - a * a) < Accuracy) {
                    isRight = true;
                }
            }
            if (isTriangle) {
                if (isRight) {
                    return "Треугольник существует и прямоугольный";
                }
                return "Треугольник существует, но не прямоугольный";
            } else {
                return "Треугольника не существует";
            }
        }
    }
}
