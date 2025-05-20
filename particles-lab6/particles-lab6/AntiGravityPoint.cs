﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace particles_lab6 {
    public class AntiGravityPoint : IImpactPoint {
        public int power = 100;

        public override void impactParticle(Particle particle) {
            float gX = X - particle.X;
            float gY = Y - particle.Y;
            float r2 = (float)Math.Max(100, gX * gX + gY * gY);

            particle.speedX -= gX * power / r2;
            particle.speedY -= gY * power / r2;
        }
    }
}
