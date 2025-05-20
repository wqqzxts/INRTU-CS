namespace particles_lab6 {
    public partial class Form1 : Form {
        private List<Particle> particles = new List<Particle>();
        private int counter = 0;
        public Form1() {
            InitializeComponent();
            this.Text = "Lab6";

            picDisplay.Image = new Bitmap(picDisplay.Width, picDisplay.Height);
        }

        private void timer1_Tick(object sender, EventArgs e) {
            updateState();

            using (var g = Graphics.FromImage(picDisplay.Image)) {
                g.Clear(Color.Black);
                render(g);
            }

            picDisplay.Invalidate();
        }

        private void updateState() {
            for (var i = 0; i < 10; ++i) {
                if (particles.Count < 500)
                {
                    var particle = new Particle();
                    particle.X = Particle.rand.Next(picDisplay.Width);
                    particle.Y = Particle.rand.Next(picDisplay.Height);
                    particles.Add(particle);
                } else {
                    break;
                }
            }

            foreach (var particle in particles) {
                particle.life -= 1;
                if (particle.life < 0) {
                    particle.life = 20 + Particle.rand.Next(100);
                    particle.X = Particle.rand.Next(picDisplay.Width);
                    particle.Y = Particle.rand.Next(picDisplay.Height);

                    var direction = (double)Particle.rand.Next(360);
                    var speed = 1 + Particle.rand.Next(10);

                    particle.speedX = (float)(Math.Cos(direction / 180 * Math.PI) * speed);
                    particle.speedY = -(float)(Math.Sin(direction / 180 * Math.PI) * speed);

                    particle.radius = 2 + Particle.rand.Next(10);
                } else {
                    particle.X += particle.speedX;
                    particle.Y += particle.speedY;
                }
            }
        }

        private void render(Graphics g) {
            foreach (var particle in particles) {
                particle.Draw(g);
            }
        }
    }
}
