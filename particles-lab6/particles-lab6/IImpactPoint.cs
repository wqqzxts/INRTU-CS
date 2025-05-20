using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace particles_lab6 {
    public abstract class IImpactPoint {
        public float X;
        public float Y;
        public int power = 100;

        public abstract void ImpactParticle(Particle particle);

        public void Render(Graphics g) {
            int radius = 50;

            using (var outerGlow = new SolidBrush(Color.FromArgb(80, 255, 50, 0))) {
                g.FillEllipse(outerGlow, X - radius, Y - radius, radius * 2, radius * 2);
            }

            using (var innerGlow = new SolidBrush(Color.FromArgb(120, 255, 80, 0))) {
                g.FillEllipse(innerGlow, X - radius / 2, Y - radius / 2, radius, radius);
            }

            g.FillEllipse(Brushes.Black, X - 15, Y - 15, 30, 30);

            g.FillEllipse(Brushes.White, X - 2, Y - 2, 4, 4);
        }
    }
}
