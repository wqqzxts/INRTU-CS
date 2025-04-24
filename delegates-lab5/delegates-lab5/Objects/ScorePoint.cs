using System;
using System.Collections.Generic;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace delegates_lab5.Objects {
    class ScorePoint : BaseObject {
        public ScorePoint(float x, float y, float angle) : base(x, y, angle) {
        }

        public override void Render(Graphics g) {
            g.FillEllipse(new SolidBrush(Color.Yellow), -10, -10, 20, 20);
            g.DrawEllipse(new Pen(Color.Red, 2), -10, -10, 20, 20);
        }

        public override GraphicsPath GetGraphicsPath() {
            var path = base.GetGraphicsPath();
            path.AddEllipse(-3, -3, 6, 6);

            return path;
        }
    }
}
