using delegates_lab5.Objects;

namespace delegates_lab5 {
    public partial class Form1 : Form {
        int scoreCount = 0;
        Random rand = new Random();
        List<BaseObject> objects = new();
        Player player;
        Marker marker;
        ScorePoint point1;
        ScorePoint point2;
        public Form1() {
            InitializeComponent();
            this.Text = "Lab5";

            player = new Player(pbMain.Width / 2, pbMain.Height / 2, 0);

            player.OnOverLap += (p, obj) => {
                txtLog.Text = $"[{DateTime.Now:HH:mm:ss}] Игрок пересекся с {obj}\n" + txtLog.Text;
            };

            marker = new Marker(pbMain.Width / 2 + 50, pbMain.Height / 2 + 50, 0);

            point1 = new ScorePoint((rand.Next() % pbMain.Width), (rand.Next() % pbMain.Height), 0);
            point2 = new ScorePoint((rand.Next() % pbMain.Width), (rand.Next() % pbMain.Height), 0);

            objects.Add(player);
            objects.Add(marker);
            objects.Add(point1);
            objects.Add(point2);
        }

        private void pbMain_Paint(object sender, PaintEventArgs e) {
            var g = e.Graphics;

            g.Clear(Color.GhostWhite);

            updatePlayer();

            if (point1.IsExpired()) {
                objects.Remove(point1);
                point1 = createRandomScorePoint();
                objects.Add(point1);
            }
            if (point2.IsExpired()) {
                objects.Remove(point2);
                point2 = createRandomScorePoint();
                objects.Add(point2);
            }

            foreach (var obj in objects.ToList()) {
                if (obj != player && player.Overlaps(obj, g)) {
                    player.Overlap(obj);

                    if (obj == marker) {
                        objects.Remove(marker);
                        marker = null;
                    }

                    if (obj is ScorePoint point) {
                        scoreCount++;
                        scoreLabel.Text = scoreCount.ToString();
                        objects.Remove(obj);
                        if (obj == point1) {
                            point1 = createRandomScorePoint();
                            objects.Add(point1);
                        } else if (obj == point2) {
                            point2 = createRandomScorePoint();
                            objects.Add(point2);
                        }
                    }
                }

                g.Transform = obj.GetTransform();
                obj.Render(g);
            }
        }

        private void timer1_Tick(object sender, EventArgs e) {
            pbMain.Invalidate();
        }

        private void pbMain_MouseClick(object sender, MouseEventArgs e) {
            if (marker == null) {
                marker = new Marker(0, 0, 0);
                objects.Add(marker);
            }

            marker.X = e.X;
            marker.Y = e.Y;
        }

        private void updatePlayer() {
            if (marker != null) {
                float dx = marker.X - player.X;
                float dy = marker.Y - player.Y;
                float length = MathF.Sqrt(dx * dx + dy * dy);
                dx /= length;
                dy /= length;

                player.vX += dx * 0.5f;
                player.vY += dy * 0.5f;
                player.Angle = 90 - MathF.Atan2(player.vX, player.vY) * 180 / MathF.PI;
            }

            player.vX += -player.vX * 0.1f;
            player.vY += -player.vY * 0.1f;

            player.X += player.vX;
            player.Y += player.vY;
        }

        private ScorePoint createRandomScorePoint() {
            return new ScorePoint(rand.Next(pbMain.Width), rand.Next(pbMain.Height), 0);
        }
    }
}
