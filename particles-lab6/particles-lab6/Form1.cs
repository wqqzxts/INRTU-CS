namespace particles_lab6 {
    public partial class Form1 : Form {
        private List<Particle> particles = new List<Particle>();
        private int counter = 0;
        public Form1() {
            InitializeComponent();
            this.Text = "Lab6";

            picDisplay.Image = new Bitmap(picDisplay.Width, picDisplay.Height);

            for (var i = 0; i < 500; ++i) {
                var particle = new Particle();                
                particle.X = picDisplay.Image.Width / 2;
                particle.Y = picDisplay.Image.Height / 2;                
                particles.Add(particle);
            }
        }

        private void timer1_Tick(object sender, EventArgs e) {
            counter++;

            using (var g = Graphics.FromImage(picDisplay.Image)) {
                g.Clear(Color.White);
                foreach(var particle in particles) {
                    particle.Draw(g);
                }
            }

            picDisplay.Invalidate();
        }
    }
}
