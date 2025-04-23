namespace inheritance_lab4 {
    public class Plant {
        protected double height = 0;

        public static Random rand = new Random();

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

        public static Flower Generate() {            
            return new Flower {
                height = 0.05 + (rand.Next() % 3),
                leafsCount = 5 + rand.Next() % 100,
                color = (FlowerColor)rand.Next(Enum.GetValues(typeof(FlowerColor)).Length),
                type = (FlowerType)rand.Next(Enum.GetValues(typeof(FlowerType)).Length)
            };
        }

        public override String GetInfo() {
            var str = "Я цветок";
            str += base.GetInfo();
            str += String.Format("\nКоличество лепестков {0}", this.leafsCount);
            str += String.Format("\nЦвет {0}", this.color);
            str += String.Format("\nТип {0}", this.type);
            return str;
        }
    }

    public class Bush : Plant {
        private bool containFlowers = true;
        private int branchCount = 0;

        public static Bush Generate() {            
            return new Bush {
                height = 0.3 + (rand.Next() % 5),
                branchCount = 5 + rand.Next() % 100,
                containFlowers = rand.Next() % 2 == 0
            };
        }

        public override String GetInfo() {
            var str = "Я кустарник";
            str += base.GetInfo();
            str += String.Format("\nКоличество веток {0}", this.branchCount);
            str += String.Format("\nСодержит цветы? {0}", this.containFlowers);
            return str;
        }
    }

    public class Tree : Plant {
        private bool isSpruce = true;
        private double radius = 0;

        public static Tree Generate() {            
            return new Tree {
                height = 3 + (rand.Next() % 18),
                radius = 0.25 + rand.Next() % 2,
                isSpruce = rand.Next() % 2 == 0
            };
        }

        public override String GetInfo() {
            var str = "Я дерево";
            str += base.GetInfo();
            str += String.Format("\nРадиус {0}", this.radius);
            str += String.Format("\nХвойное? {0}", this.isSpruce);
            return str;
        }
    }
}
