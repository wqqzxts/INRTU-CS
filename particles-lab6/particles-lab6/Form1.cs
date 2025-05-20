namespace particles_lab6 {
    public partial class Form1 : Form {
        Emitter emitter;
        private List<Particle> particles = new List<Particle>();
        private int counter = 0;
        public Form1() {
            InitializeComponent();
            this.Text = "Lab6";

            picDisplay.Image = new Bitmap(picDisplay.Width, picDisplay.Height);

            emitter = new TopEmitter {
                width = picDisplay.Width,
                gravitationY = 0.25f
            };

            //emitter.impactPoints.Add(new GravityPoint {
            //    X = (float)(picDisplay.Width * 0.5),
            //    Y = picDisplay.Height / 2
            //});

            //emitter.impactPoints.Add(new AntiGravityPoint {
            //    X = picDisplay.Width / 2,
            //    Y = picDisplay.Height / 2
            //});

            //emitter.impactPoints.Add(new GravityPoint {
            //    X = (float)(picDisplay.Width * 0.75),
            //    Y = picDisplay.Height / 2
            //});
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
