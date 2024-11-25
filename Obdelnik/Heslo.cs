namespace SpravceHesel {
    interface IHeslo {
        int DelkaHesla();
        int MaxDelka();
        int MinDelka();
    }

    class Heslo: IHeslo {
        private string heslo;

        public static int maxDelkaHesla = 20;
        public static int minDelkahesla = 8;

        public int DelkaHesla() {
            return 0;
        }
        public int MaxDelka() {
            return maxDelkaHesla;
        }

        public int MinDelka() {
            return minDelkahesla;
        }
    }
}