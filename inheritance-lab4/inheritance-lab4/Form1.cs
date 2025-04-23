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
                        this.plantsList.Add(Flower.Generate());
                        break;
                    case 1:
                        this.plantsList.Add(Bush.Generate());
                        break;
                    case 2:
                        this.plantsList.Add(Tree.Generate());
                        break;                        
                }
            }

            ShowInfo();
        }

        private void buttonGet_Click(object sender, EventArgs e) {
            if (this.plantsList.Count == 0) {
                textOut.Text = "Растения закончились";
                return;
            }

            var plant = this.plantsList[0];
            this.plantsList.RemoveAt(0);

            textOut.Text = plant.GetInfo();

            ShowInfo();
        }

        private void ShowInfo() {
            int flowersCount = 0;
            int treesCount = 0;
            int bushesCount = 0;

            foreach (var plant in this.plantsList) {
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

            int columnWidth = 10;
            textInfo.Text = "Цветы".PadRight(columnWidth)
                            + "Деревья".PadRight(columnWidth)
                            + "Кустарники";

            textInfo.Text += "\n";

            textInfo.Text += flowersCount.ToString().PadRight(columnWidth)
                           + treesCount.ToString().PadRight(columnWidth)
                           + bushesCount;
        }
    }
}
