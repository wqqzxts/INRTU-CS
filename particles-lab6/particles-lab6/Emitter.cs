using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace particles_lab6 {
    public class Emitter {
        public List<Particle> particles = new List<Particle>();
        public List<IImpactPoint> impactPoints = new List<IImpactPoint>();
        public int particlesCount = 100;
        public int mousePositionX;
        public int mousePositionY;

        public float gravitationX = 0;
        public float gravitationY = 1;

        public int X; // координата X центра эмиттера, будем ее использовать вместо MousePositionX
        public int Y; // соответствующая координата Y 
        public int direction = 0; // вектор направления в градусах куда сыпет эмиттер
        public int spreading = 360; // разброс частиц относительно Direction
        public int speedMin = 1; // начальная минимальная скорость движения частицы
        public int speedMax = 10; // начальная максимальная скорость движения частицы
        private int radiusMin = 2; // минимальный радиус частицы
        public int radiusMax = 10; // максимальный радиус частицы
        private int lifeMin = 10; // минимальное время жизни частицы
        public int lifeMax = 100; // максимальное время жизни частицы
        public int particlesPerTick = 1; // генерация <количество> частиц в такт
        public Color colorFrom = Color.White; // начальный цвет частицы
        public Color colorTo = Color.FromArgb(0, Color.Black); // конечный цвет частицы

        public void UpdateState(PictureBox picDisplay) {
            int particlesToCreate = particlesPerTick;

            while (particlesToCreate >= 1) {
                particlesToCreate -= 1;
                var particle = CreateParticle();
                ResetParticle(particle, picDisplay);
                particles.Add(particle);
            }

            for (var i = 0; i < 10; ++i) {
                if (particles.Count < particlesCount) {
                    var particle = CreateParticle();
                    ResetParticle(particle, picDisplay);
                    particles.Add(particle);
                } else {
                    break;
                }
            }

            foreach (var particle in particles) {
                particle.life -= 1;
                if (particle.life <= 0) {
                    if (particlesToCreate > 0) {
                        particlesToCreate -= 1;
                        ResetParticle(particle, picDisplay);
                    }                    
                } else {
                    foreach (var point in impactPoints) {
                        point.ImpactParticle(particle);
                    }                   

                    particle.speedX += gravitationX;
                    particle.speedY += gravitationY;

                    particle.X += particle.speedX;
                    particle.Y += particle.speedY;
                }
            }
        }

        public void Render(Graphics g) {
            foreach (var particle in particles) {
                particle.Draw(g);
            }

            foreach (var point in impactPoints) {
                point.Render(g);
            }
        }

        public virtual void ResetParticle(Particle particle, PictureBox picDisplay) {
            particle.life = Particle.rand.Next(lifeMin, lifeMax);

            particle.X = X;
            particle.Y = Y;

            var direction = this.direction
                + (double)Particle.rand.Next(spreading)
                - spreading / 2;

            var speed = Particle.rand.Next(speedMin, speedMax);

            particle.speedX = (float)(Math.Cos(direction / 180 * Math.PI) * speed);
            particle.speedY = -(float)(Math.Sin(direction / 180 * Math.PI) * speed);

            particle.radius = Particle.rand.Next(radiusMin, radiusMax);
        }

        public virtual Particle CreateParticle() {
            var particle = new ColorfulParticle();
            particle.fromColor = colorFrom;
            particle.toColor = colorTo;

            return particle;
        }
    }
}
