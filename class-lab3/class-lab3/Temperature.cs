namespace class_lab3 {
    public enum Type { Ra, K, C };
    public class Temperature {
        private double value;
        private Type type;

        public Temperature(double value, Type type) {
            this.value = value;
            this.type = type;
        }

        public static Temperature operator +(Temperature instance, double value) {                     
            return new Temperature(instance.value + value, instance.type); ;
        }

        public static Temperature operator +(double value, Temperature instance) {
            return instance + value;
        }

        public static Temperature operator -(Temperature instance, double value) {
            return new Temperature(instance.value - value, instance.type);
            ;
        }

        public static Temperature operator -(double value, Temperature instance) {
            return instance - value;
        }

        public static Temperature operator *(Temperature instance, double value) {
            return new Temperature(instance.value * value, instance.type);
            ;
        }

        public static Temperature operator *(double value, Temperature instance) {
            return instance * value;
        }

        public static Temperature operator /(Temperature instance, double value) {
            return new Temperature(instance.value / value, instance.type);
            ;
        }

        public static Temperature operator /(double value, Temperature instance) {
            return instance / value;
        }

        public string Verbose() {
            string typeFormatted = "";

            switch (this.type) {
                case Type.Ra:
                    typeFormatted = "по Ранкину";
                    break;
                case Type.K:
                    typeFormatted = "по Кельвину";
                    break;
                case Type.C:
                    typeFormatted = "по Цельсию";
                    break;
            }

            return String.Format("{0} {1}", this.value, typeFormatted);
        }
    }
}
