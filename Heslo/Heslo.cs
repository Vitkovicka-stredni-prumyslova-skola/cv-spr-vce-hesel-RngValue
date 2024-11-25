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
        private string[] znaky = {
            "abcdefghijklmnopqrstuvwxyz",
            "ABCDEFGHIJKLMNOPQRSTUVWXYZ",
            ".-/@$"
        };

        public string GenHeslo(int delka) {
            Random rnd = new Random();
            string heslo = "";
            for (int i = 0; i < delka; i++) {
                int x = rnd.Next(0,3);
                int y = rnd.Next(0, znaky[x].Length);
                heslo += znaky[x][y];
            }
            this.heslo = heslo;
            return heslo;
        }

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