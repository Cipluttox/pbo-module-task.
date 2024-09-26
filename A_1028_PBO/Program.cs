using System;

namespace KebunBinatang
{
    public class Hewan
    {
        public string nama;
        public int umur;

        public Hewan(string nama, int umur)
        {
            this.nama = nama;
            this.umur = umur;
        }
        public virtual string Suara()
        {
            return ("Hewan ini bersuara");
        }
        public virtual string InfoHewan()
        {
            return $"Nama : {nama} \nUmur : {umur}";
        }
    }
    public class Mamalia : Hewan
    {
        public int jumlahKaki;

        public Mamalia(string nama, int umur, int jumlahKaki) : base(nama, umur)
        {
            this.nama = nama;
            this.umur = umur;
            this.jumlahKaki = jumlahKaki;
        }
        public override string InfoHewan()
        {
            return base.InfoHewan() + "\n" + $"Jumlah Kaki : {jumlahKaki}" + "\n";
        }
    }
    public class Reptil : Hewan
    {
        public double panjangTubuh;

        public Reptil(string nama, int umur, int panjangTubuh) : base(nama, umur)
        {
            this.nama = nama;
            this.umur = umur;
            this.panjangTubuh = panjangTubuh;
        }
        public override string InfoHewan()
        {
            return base.InfoHewan() + "\n" + $"Jumlah Panjang Tubuh : {panjangTubuh}" + "\n";
        }
    }

    public class Singa : Mamalia
    {
        public Singa(string nama, int umur, int jumlahKaki) : base(nama, umur, jumlahKaki)
        {

        }
        public override string Suara()
        {
            return base.Suara() + $"Suara singa : Rawrrr";
        }

        public void Mengaum()
        {
            Console.Write("Singa mengaum : RAWRR");
        }
    }

    public class Gajah : Mamalia
    {
        public Gajah(string nama, int umur, int jumlahKaki) : base(nama, umur, jumlahKaki)
        {

        }
        public override string Suara()
        {
            return base.Suara() + $", Suara Gajah : Prwetttt";
        }
    }

    public class Ular : Reptil
    {
        public Ular(string nama, int umur, int panjangTubuh) : base(nama, umur, panjangTubuh)
        {

        }

        public override string Suara()
        {
            return base.Suara() + $"Suara ular : Sssshhh";
        }
        public void Merayap()
        {
            Console.Write("Ular bergerak : merayap");
        }
    }
    public class Buaya : Reptil
    {
        public Buaya(string nama, int umur, int panjangTubuh) : base(nama, umur, panjangTubuh)
        {

        }
        public override string Suara()
        {
            return base.Suara() + $"Suara Buaya : ada yang marah gak aku chat kamuh?";
        }
    }

    public class KebunBinatang
    {
        private List<Hewan> koleksiHewan = new List<Hewan>();

        public void TambahHewan(Hewan hewan)
        {
            koleksiHewan.Add(hewan);
        }
        public void DaftarHewan()
        {
            foreach (Hewan hewan in koleksiHewan)
            {
                Console.WriteLine(hewan.InfoHewan());
            }
        }
    }

    public class Program
    {
        public static void Main(string[] args)
        {
            KebunBinatang kebunBinatang = new KebunBinatang();

            Gajah gajah = new Gajah("Dumbo", 10, 4);
            Singa singa = new Singa("Simba", 8, 4);
            Ular ular = new Ular("Python", 5, 12);
            Buaya buaya = new Buaya("Lumpi", 10, 100);

            kebunBinatang.TambahHewan(gajah);
            kebunBinatang.TambahHewan(singa);
            kebunBinatang.TambahHewan(ular);
            kebunBinatang.TambahHewan(buaya);

            kebunBinatang.DaftarHewan();
        }
    }


}