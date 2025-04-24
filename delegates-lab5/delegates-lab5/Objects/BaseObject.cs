﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing.Drawing2D;

namespace delegates_lab5.Objects {
    class BaseObject {
        public float X;
        public float Y;
        public float Angle;

        public BaseObject(float x, float y, float angle) {
            X = x;
            Y = y;
            Angle = angle;
        }

        public Matrix GetTransform() {
            var matrix = new Matrix();
            matrix.Translate(X, Y);
            matrix.Rotate(Angle);

            return matrix;
        }

        public virtual void Render(Graphics g) {

        }

        public virtual GraphicsPath GetGraphicsPath() {
            return new GraphicsPath();
        }

        public virtual bool OverLaps(BaseObject obj, Graphics g) {
            var path1 = this.GetGraphicsPath();
            var path2 = obj.GetGraphicsPath();

            path1.Transform(this.GetTransform());
            path2.Transform(obj.GetTransform());

            var region = new Region(path1);
            region.Intersect(path2);
            return !region.IsEmpty(g);
        }
    }
}
