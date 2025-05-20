using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace particles_lab6 {
    public class TopEmitter : Emitter {
        public int width;

        public override void resetParticle(Particle particle, PictureBox picDisplay) {
            base.resetParticle(particle, picDisplay);

            particle.X = Particle.rand.Next(width);
            particle.Y = 0;

            particle.speedX = Particle.rand.Next(-2, 2);
            particle.speedY = 1;
        }
    }
}
