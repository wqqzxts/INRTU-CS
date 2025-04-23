namespace inheritance_lab4 {
    public partial class Form1 : Form {
        List<Plant> plantsList = new List<Plant>();
        public Form1() {
            InitializeComponent();

            ShowInfo();
        }

        private void Form1_Load(object sender, EventArgs e) {

        }

        private void buttonRefill_Click(object sender, EventArgs e) {
            this.plantsList.Clear();
            var rand = new Random();

            for (var i = 0; i < 20; ++i) {
                switch (rand.Next() % 3) {
                    case 0:
                        this.plantsList.Add(new Flower());
                        break;
                    case 1:
                        this.plantsList.Add(new Tree());
                        break;
                    case 2:
                        this.plantsList.Add(new Bush());
                        break;
                }
            }

            ShowInfo();
        }

        private void buttonGet_Click(object sender, EventArgs e) {

        }

        private void ShowInfo() {
            int flowersCount = 0;
            int treesCount = 0;
            int bushesCount = 0;

            foreach(var plant in this.plantsList) {
                switch (plant) {
                    case Flower:
                        flowersCount += 1;
                        break;
                    case Tree:
                        treesCount += 1;
                        break;
                    case Bush:
                        bushesCount += 1;
                        break;
                }
            }

            textInfo.Text = "Цветы\tДеревья\tКустарники";
            textInfo.Text += "\n";
            textInfo.Text += String.Format("{0}\t{1}\t{2}", flowersCount, treesCount, bushesCount);
        }
    }
}
