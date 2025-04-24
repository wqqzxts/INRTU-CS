using delegates_lab5.Objects;

namespace delegates_lab5 {
    public partial class Form1 : Form {
        List<BaseObject> objects = new();
        Player player;
        Marker marker;
        public Form1() {
            InitializeComponent();

            player = new Player(pbMain.Width / 2, pbMain.Height / 2, 0);

            player.OnOverLap += (p, obj) => {
                txtLog.Text = $"[{DateTime.Now:HH:mm:ss}] ����� ��������� � {obj}\n" + txtLog.Text;
            };

            marker = new Marker(pbMain.Width / 2 + 50, pbMain.Height / 2 + 50, 0);

            objects.Add(player);
            objects.Add(marker);

            objects.Add(new MyRectangle(50, 50, 0));
            objects.Add(new MyRectangle(100, 100, 0));
        }

        private void pbMain_Paint(object sender, PaintEventArgs e) {
            var g = e.Graphics;

            g.Clear(Color.GhostWhite);

            updatePlayer();

            foreach (var obj in objects.ToList()) {
                if (obj != player && player.Overlaps(obj, g)) {
                    player.Overlap(obj);
                    obj.Overlap(player);

                    if (obj == marker) {
                        objects.Remove(marker);
                        marker = null;
                    }
                }

                g.Transform = obj.GetTransform();
                obj.Render(g);
            }

            foreach (var obj in objects) {
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
    }
}
