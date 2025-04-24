using delegates_lab5.Objects;

namespace delegates_lab5 {
    public partial class Form1 : Form {
        List<BaseObject> objects = new();
        Player player;
        Marker marker;
        public Form1() {
            InitializeComponent();

            player = new Player(pbMain.Width / 2, pbMain.Height / 2, 0);
            marker = new Marker(pbMain.Width / 2 + 50, pbMain.Height / 2 + 50, 0);

            objects.Add(player);
            objects.Add(marker);

            objects.Add(new MyRectangle(50, 50, 0));
            objects.Add(new MyRectangle(100, 100, 0));
        }

        private void pbMain_Paint(object sender, PaintEventArgs e) {
            var g = e.Graphics;

            g.Clear(Color.GhostWhite);

            foreach (var obj in objects) {
                g.Transform = obj.GetTransform();
                obj.Render(g);
            }
        }
    }
}
