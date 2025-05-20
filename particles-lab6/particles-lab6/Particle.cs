using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace particles_lab6 {
    public class Particle {                
        public float speedX;
        public float speedY;
        public int radius;
        public float X;
        public float Y;
        public float life;
        
        public static Random rand = new Random();

        public Particle() {
            var direction = (double)rand.Next(360);
            var speed = 1 + rand.Next(10);

            speedX = (float)(Math.Cos(direction / 180 * Math.PI) * speed);
            speedY = -(float)(Math.Sin(direction / 180 * Math.PI) * speed);

            radius = 2 + rand.Next(10);
            life = 20 + rand.Next(100);
        }

        public virtual void Draw(Graphics g) {
            float k = Math.Min(1f, life / 100);

            int alpha = (int)(k * 255);

            var color = Color.FromArgb(alpha, Color.White);
            var b = new SolidBrush(color);

            g.FillEllipse(b, X - radius, Y - radius, radius * 2, radius * 2);

            b.Dispose();
        }
    }

    public class ColorfulParticle : Particle {
        public Color fromColor;
        public Color toColor;

        public static Color MixColor(Color color1, Color color2, float k) {
            k = Math.Max(0, Math.Min(1, k));

            return Color.FromArgb(
                ClampToByte(color2.A * k + color1.A * (1 - k)),
                ClampToByte(color2.R * k + color1.R * (1 - k)),
                ClampToByte(color2.G * k + color1.G * (1 - k)),
                ClampToByte(color2.B * k + color1.B * (1 - k))
            );
        }

        private static int ClampToByte(float value) {
            return (int)Math.Max(0, Math.Min(255, value));
        }

        public override void Draw(Graphics g) {
            float k = Math.Min(1f, life / 100);

            var color = MixColor(toColor, fromColor, k);
            var b = new SolidBrush(color);

            g.FillEllipse(b, X - radius, Y - radius, radius * 2, radius * 2);

            b.Dispose();
        }
    }
}
