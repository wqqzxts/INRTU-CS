namespace inheritance_lab4 {
    public class Plant {
        protected double height = 0;

        public virtual String GetInfo() {
            var str = String.Format("\nВысота {0}", this.getHeight());

            return str;
        }

        public virtual double getHeight() {
            return this.height;
        }

        public virtual void setHeight(double value) {
            this.height = value;
        }
    }

    public enum FlowerType { Rose, Orchid, Lilie, Sunflower };
    public enum FlowerColor { Red, White, Violet, Pink };
    public class Flower : Plant {
        private int leafsCount = 0;
        private FlowerColor color = FlowerColor.Red;
        private FlowerType type = FlowerType.Rose; 

        public override String GetInfo() {
            var str = "Я цветок";
            str += base.GetInfo();
            str += String.Format("\nКоличество лепестков {0}", this.leafsCount);
            str += String.Format("\nЦвет{0}", this.color);
            str += String.Format("\nТип{0}", this.type);
            return str;
        }
    }

    public class Tree : Plant {
        private bool containFlowers = true;
        private int branchCount = 0;

        public override String GetInfo() {
            var str = "Я дерево";
            str += base.GetInfo();
            str += String.Format("\nКоличество лепестков {0}", this.branchCount);
            str += String.Format("\nСодержит цветы? {0}", this.containFlowers);
            return str;
        }
    }

    public class Bush : Plant {
        private bool isSpruce = true;
        private double radius = 0;

        public override String GetInfo() {
            var str = "Я кустарник";
            str += base.GetInfo();
            str += String.Format("\nРадиус{0}", this.radius);
            str += String.Format("\nХвойное? {0}", this.isSpruce);
            return str;
        }
    }
}
