namespace class_lab3 {
    public enum Type { Ra, K, C, Fa };
    public class Temperature {
        private double value;
        private Type type;

        public Temperature(double value, Type type) {
            this.value = value;
            this.type = type;
        }

        public static Temperature operator +(Temperature instance, double value) {
            return new Temperature(instance.value + value, instance.type);
            ;
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

        public Temperature To(Type newType) {
            if (this.type == newType) {
                return new Temperature(this.value, newType);
            }

            double kelvinValue = 0;

            switch (this.type) {
                case Type.Ra:
                    kelvinValue = this.value * 5 / 9;
                    break;
                case Type.K:
                    kelvinValue = this.value;
                    break;
                case Type.C:
                    kelvinValue = this.value + 273.15;
                    break;
                case Type.Fa:
                    kelvinValue = (this.value + 459.67) * 5 / 9;
                    break;
            }

            double newValue = 0;
            switch (newType) {
                case Type.Ra:
                    newValue = kelvinValue * 9 / 5;
                    break;
                case Type.K:
                    newValue = kelvinValue;
                    break;
                case Type.C:
                    newValue = kelvinValue - 273.15;
                    break;
                case Type.Fa:
                    newValue = kelvinValue * 9 / 5 - 459.67;
                    break;
            }

            return new Temperature(newValue, newType);
        }

        public string Verbose() {
            string typeFormatted = "";
            double roundedValue = Math.Round(this.value, 2);

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
                case Type.Fa:
                    typeFormatted = "по Фаренгейту";
                    break;
            }

            return String.Format("{0} {1}", roundedValue, typeFormatted);
        }
    }
}