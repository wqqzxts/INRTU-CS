namespace particles_lab6 {
    public partial class Form1 : Form {
        Emitter emitter;
        private List<Emitter> emitters = new List<Emitter>();
        private int particleCounter = 0;
        public Form1() {
            InitializeComponent();
            this.Text = "Lab6";

            picDisplay.Image = new Bitmap(picDisplay.Width, picDisplay.Height);

            this.emitter = new Emitter {
                direction = 0,
                spreading = 10,
                speedMin = 10,
                speedMax = 10,
                colorFrom = Color.Azure,
                colorTo = Color.FromArgb(0, Color.Wheat),
                particlesPerTick = 10,
                X = picDisplay.Width / 2,
                Y = picDisplay.Height / 2,
            };

            this.emitter.impactPoints.Add(new GravityPoint {
                X = (float)(picDisplay.Width * 0.75),
                Y = picDisplay.Height / 2,
            });

            emitters.Add(emitter);
        }

        private void timer1_Tick(object sender, EventArgs e) {
            emitter.UpdateState(picDisplay);

            using (var g = Graphics.FromImage(picDisplay.Image)) {
                g.Clear(Color.DarkGray);
                emitter.Render(g);
            }

            particleCounter = emitter.particles.Count(p => p.life > 0);
            labelParticleCounter.Text = particleCounter.ToString();

            picDisplay.Invalidate();
        }

        private void trackBarParticlesAmount_Scroll(object sender, EventArgs e) {
            emitter.particlesPerTick = trackBarParticlesAmount.Value;
            lblParticleAmount.Text = trackBarParticlesAmount.Value.ToString();
        }

        private void trackBarSpeed_Scroll(object sender, EventArgs e) {
            emitter.speedMax = trackBarSpeed.Value;
            lblSpeed.Text = trackBarSpeed.Value.ToString();
        }

        private void trackBarDirection_Scroll(object sender, EventArgs e) {
            emitter.direction = trackBarDirection.Value;
            lblDirection.Text = trackBarDirection.Value.ToString() + "°";
        }

        private void trackBarLifePeriod_Scroll(object sender, EventArgs e) {
            emitter.lifeMax = trackBarLifePeriod.Value;
            lblLifePeriod.Text = trackBarLifePeriod.Value.ToString();
        }

        private void trackBarGravity_Scroll(object sender, EventArgs e) {
            if (emitter.impactPoints.Count > 0 && emitter.impactPoints[0] is GravityPoint gravityPoint) {
                gravityPoint.power = trackBarGravity.Value;
                lblGravity.Text = trackBarGravity.Value.ToString();
            }            
        }
    }
}
