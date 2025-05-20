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

        public void Draw(Graphics g) {
            float k = Math.Min(1f, life / 100);

            int alpha = (int)(k * 255);

            var color = Color.FromArgb(alpha, Color.White);
            var b = new SolidBrush(color);

            g.FillEllipse(b, X - radius, Y - radius, radius * 2, radius * 2);

            b.Dispose();
        }
    }
}
