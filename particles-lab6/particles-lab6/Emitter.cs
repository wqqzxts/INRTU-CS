using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace particles_lab6 {
    public class Emitter {
        public List<Particle> particles = new List<Particle>();
        public List<IImpactPoint> impactPoints = new List<IImpactPoint>();
        public int particleCount = 100;
        public int mousePositionX;
        public int mousePositionY;

        public float gravitationX = 0;
        public float gravitationY = 0;

        public void updateState(PictureBox picDisplay) {
            for (var i = 0; i < 10; ++i) {
                if (particles.Count < particleCount) {
                    var particle = new Particle();
                    resetParticle(particle, picDisplay);
                    particles.Add(particle);
                } else {
                    break;
                }
            }

            foreach (var particle in particles) {
                particle.life -= 1;
                if (particle.life < 0) {
                    resetParticle(particle, picDisplay);
                } else {
                    foreach (var point in impactPoints) {
                        point.impactParticle(particle);
                    }                   

                    particle.speedX += gravitationX;
                    particle.speedY += gravitationY;

                    particle.X += particle.speedX;
                    particle.Y += particle.speedY;
                }
            }
        }

        public void render(Graphics g) {
            foreach (var particle in particles) {
                particle.Draw(g);
            }

            foreach (var point in impactPoints) {
                point.render(g);
            }
        }

        public virtual void resetParticle(Particle particle, PictureBox picDisplay) {
            particle.life = 10 + Particle.rand.Next(100);
            particle.X = Particle.rand.Next(picDisplay.Width);
            particle.Y = Particle.rand.Next(picDisplay.Height);

            var direction = (double)Particle.rand.Next(360);
            var speed = 1 + Particle.rand.Next(10);

            particle.speedX = (float)(Math.Cos(direction / 180 * Math.PI) * speed);
            particle.speedY = -(float)(Math.Sin(direction / 180 * Math.PI) * speed);

            particle.radius = 2 + Particle.rand.Next(10);
        }
    }
}
