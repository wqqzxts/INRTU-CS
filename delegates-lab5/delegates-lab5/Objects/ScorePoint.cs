using System;
using System.Collections.Generic;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace delegates_lab5.Objects {
    class ScorePoint : BaseObject {
        private DateTime creationDate;
        private const float LIFE_TIME = 5f;
        private float currentLifeRatio = 100f;
        private Font lifeFont = new Font("Verdana", 8);

        public ScorePoint(float x, float y, float angle) : base(x, y, angle) {
            this.creationDate = DateTime.Now;
        }

        public override void Render(Graphics g) {
            var elapsed = (float)(DateTime.Now - creationDate).TotalSeconds;
            currentLifeRatio = Math.Max(0, 100f - (elapsed / LIFE_TIME) * 100f);

            g.FillEllipse(new SolidBrush(Color.Yellow), -10, -10, 20, 20);
            g.DrawEllipse(new Pen(Color.Red, 2), -10, -10, 20, 20);

            string lifeText = $"{currentLifeRatio:0}";
            var textSize = g.MeasureString(lifeText, lifeFont);
            g.DrawString(lifeText, lifeFont, Brushes.Black, -textSize.Width / 2, 15);
        }

        public bool IsExpired() {
            return (DateTime.Now - creationDate).TotalSeconds >= LIFE_TIME;
        }

        public override GraphicsPath GetGraphicsPath() {
            var path = base.GetGraphicsPath();
            path.AddEllipse(-3, -3, 6, 6);

            return path;
        }
    }
}
