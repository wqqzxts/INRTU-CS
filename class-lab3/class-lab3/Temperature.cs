namespace class_lab3 {
    public enum Type { Ra, K, C, Fa};
    public class Temperature {


    //Температура, задаваемая в виде пары(значение, тип), допустимые типы:
    //градус Цельсия, градус Фаренгейта, градус Ранкина, Кельвины
    //сложение
    //вычитание
    //умножение на число
    //сравнение
    //вывод значения в любом типе


        private double value;
        private Type type;

        public Temperature(double value, Type type) {
            this.value = value;
            this.type = type;
        }

        // числа
        public static Temperature operator +(Temperature instance, double value) {
            return new Temperature(instance.value + value, instance.type);            
        }

        public static Temperature operator +(double value, Temperature instance) {
            return instance + value;
        }

        public static Temperature operator -(Temperature instance, double value) {
            return new Temperature(instance.value - value, instance.type);            
        }

        public static Temperature operator -(double value, Temperature instance) {
            return instance - value;
        }
        
        public static Temperature operator *(Temperature instance, double value) {
            return new Temperature(instance.value * value, instance.type);            
        }

        public static Temperature operator *(double value, Temperature instance) {
            return instance * value;
        }

        public static Temperature operator /(Temperature instance, double value) {
            if (Math.Abs(value) < 1e-10)
                throw new DivideByZeroException("Деление на 0.");
            return new Temperature(instance.value / value, instance.type);
        }

        public static Temperature operator /(double value, Temperature instance) {
            return instance / value;
        }

        // температуры
        public static Temperature operator +(Temperature instance1, Temperature instance2) {
            var converted = instance2.To(instance1.type);
            return new Temperature(instance1.value + converted.value, instance1.type);
        }

        public static Temperature operator -(Temperature instance1, Temperature instance2) {
            var converted = instance2.To(instance1.type);
            return new Temperature(instance1.value - converted.value, instance1.type);
        }

        public static Temperature operator *(Temperature instance1, Temperature instance2) {
            var converted = instance2.To(instance1.type);
            return new Temperature(instance1.value * converted.value, instance1.type);
        }

        public static Temperature operator /(Temperature instance1, Temperature instance2) {
            var converted = instance2.To(instance1.type);

            if (Math.Abs(instance2.value) < 1e-10 || Math.Abs(converted.value) < 1e-10)
                throw new DivideByZeroException("Деление на 0.");

            return new Temperature(instance1.value / converted.value, instance1.type);
        }

        public static bool operator ==(Temperature instance1, Temperature instance2) {
            if (ReferenceEquals(instance1, null) || ReferenceEquals(instance2, null))
                throw new ArgumentNullException("Нельзя сравнить не инициализированные объекты");

            var converted = instance2.To(instance1.type);
            return Math.Abs(instance1.value - converted.value) < 1e-10;
        }

        public static bool operator !=(Temperature instance1, Temperature instance2) {
            return !(instance1 == instance2);
        }

        public static bool operator <(Temperature instance1, Temperature instance2) {
            if (ReferenceEquals(instance1, null) || ReferenceEquals(instance2, null))
                throw new ArgumentNullException("Нельзя сравнить не инициализированные объекты");

            var converted = instance2.To(instance1.type);
            return instance1.value < converted.value;
        }

        public static bool operator >(Temperature instance1, Temperature instance2) {
            if (ReferenceEquals(instance1, null) || ReferenceEquals(instance2, null))
                throw new ArgumentNullException("Нельзя сравнить не инициализированные объекты");

            var converted = instance2.To(instance1.type);
            return instance1.value > converted.value;
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