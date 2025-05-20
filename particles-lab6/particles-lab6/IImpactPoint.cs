﻿using System;
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
            g.FillEllipse(
                    new SolidBrush(Color.Red),
                    X - 5,
                    Y - 5,
                    10,
                    10
            );
        }
    }
}
