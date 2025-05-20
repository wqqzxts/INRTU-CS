namespace particles_lab6 {
    public partial class Form1 : Form {
        Emitter emitter = new Emitter();
        private List<Particle> particles = new List<Particle>();
        private int counter = 0;
        public Form1() {
            InitializeComponent();
            this.Text = "Lab6";

            picDisplay.Image = new Bitmap(picDisplay.Width, picDisplay.Height);
        }

        private void timer1_Tick(object sender, EventArgs e) {
            emitter.updateState(picDisplay);

            using (var g = Graphics.FromImage(picDisplay.Image)) {
                g.Clear(Color.Black);
                emitter.render(g);
            }

            picDisplay.Invalidate();
        }
    }
}
