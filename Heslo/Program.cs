namespace SpravceHesel {
    class SpravceHesel {
        static void Main(string[] args){
            Console.WriteLine(Heslo.maxDelkaHesla);
            Heslo noveHeslo = new Heslo();
            Console.WriteLine(noveHeslo.GenHeslo(16));
        }
    }
}