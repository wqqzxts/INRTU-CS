using delegates_lab5.Objects;

namespace delegates_lab5 {
    public partial class Form1 : Form {
        MyRectangle myRect;
        public Form1() {
            InitializeComponent();

            myRect = new MyRectangle(0, 0, 0);
        }

        private void pbMain_Paint(object sender, PaintEventArgs e) {
            var g = e.Graphics;

            g.Clear(Color.GhostWhite);

            g.Transform = myRect.GetTransform();
            myRect.Render(g);
        }
    }
}
