using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KodKutuphanesi
{
    public class MatematikLib
    {
        //eğer metot tanımlarken static yazmamışsak non-static: statik olmayan olarak tanımlanır.
        //Main static oldugu için diğer metotları static olarak tanımladık ki main o metotları görebilsin. 
        //static üyeler sadece static üyeleri görebilir.
        public void Test()  
        {
            Console.WriteLine("hello");
        }
        

        //react.js / önyüzde kullanılır. daha hızlı çalıştıgını söylenir.

        public int Topla(int sayi1,int sayi2)  //1.versiyonu 2 tane int toplayan hali
        {
            return sayi1+sayi2;
        }
        public double Topla(double sayi1, double sayi2) //2.versiyonu 2 tane double toplayan hali
        {
            return sayi1 + sayi2;
        }

        //overloading:aşırı yüklemek anlamına gelir.
        //Aynı metot başlığı içerisine (Topla metoduna) 2 farklı versiyon tanımlandı. 2 int ve 2 double değer üretildi.

        public int Topla(int sayi1, int sayi2,int sayi3)  
        {
            return sayi1 + sayi2+sayi3;
        }

        //2-3-4-5 vs. bütün paremetreleri alarak calışabilir hale getirdik.
        public int Topla(params int[] sayilar)
        {
            int sonuc=0;
            for (int i = 0; i < sayilar.Length; i++)
            {
                sonuc += sayilar[i];
            }
            return sonuc;
        }
        /// <summary>
        /// double dizisi alır ve dizinin elemanlarını toplar.
        /// </summary>
        /// <param name="sayilar"></param>
        /// <returns></returns>
        public double Topla(params double[] sayilar)
        {
            double sonuc = 0;
            for (int i = 0; i < sayilar.Length; i++)
            {
                sonuc += sayilar[i];
            }
            return sonuc;
        }

        //çıkart, çarp, böl(buraya ekleyelim.) siz ekleyin.
        //mod alma, (2 tane sayısal değer  alsın.)ilk girilmiş olan değeri 2.girilen değere bölüp kalan bulsun. sayi1%sayi2 : modunu yani kalanını bulur.
        public int ModAlma(int sayi1,int sayi2)
        {
            return sayi1%sayi2;
        }

        //üs alma,
        //3,2
        //3:taban, 2üs
        //3*3=9

        //5,3 
        //5*5*5 = 125

        public int UsAlma(int taban,int us)
        {
            int sonuc=1;
            for (int i = 0; i < us; i++)
            {
                //sonuc=sonuc*taban;
                sonuc*=taban; //birleşik atama anlamına gelir.
            }
            return sonuc;
        } 

        //review : gözden geçirme 


        //faktöriyel
        //0! =1, 1!=1
        //negatif sayıların faktöriyeli hesaplanmaz.
        //pozitif sayıların faktöriyeli: sayi* sayi-1*sayi-2*sayi-3.....*2*1
        public int Faktoriyel(int sayi)
        {
            if(sayi<0)
                return -555;
            else if(sayi==1 || sayi==0)
                return 1;
            else
            {
                int sonuc=1;
                for (int i = 1; i < sayi; i++)
                {
                    sonuc*=i;
                }
                return sonuc;
            }
        }

        //mutlak değer,
        //sayı negatif ya da pozitif olması farketmez. 0a olan uzaklık değer
        public int MutlakDeger(int sayi)
        {
            if(sayi<0)
                return sayi*-1;
            else
                return sayi;

        }

        //yuvarlama,
        //matematikteki gibi bir yuvarlama kodlanacak.Math.Round()

        public double Yuvarlama(double deger)
        {
            return Math.Round(deger);
        }

        //faiz orani parametre alan ve anapara* faizorani formülü ile gelecek faizi hesaplayan kod.

        public double FaizOranHesapla(double anapara,double faizoran)
        {
            return anapara*faizoran;
        }

        //stringin eleman sayısını bulan metot. //Length
        public int ElemanSayisi(string deger)
        {
            return deger.Length;
        }

        //stringi ters ceviren metot. //döngü ile tersten döndür
        public string TerstenYazdirma(string metin)
        {
            string sonuc = "";
            for (int i = metin.Length - 1; i >= 0; i--)
            {
                sonuc += metin[i];
            }
            return sonuc;
        }

        //stringi bir büyük bir küçük formatta yazan metot.
        public string BirBuyukBirKucuk(string metin)
        {
            string sonuc = "";
            for (int i = 0; i < metin.Length; i++)
            {
                if (i % 2 == 0)
                    sonuc += metin[i].ToString().ToUpper();
                else
                    sonuc = metin[i].ToString().ToLower();
            }
            return sonuc;
        }



        //IslemYap metodu (2 int ,1 karakter alarak çalışsın)

        public double IslemYap(double sayi1, double sayi2, char islem)
        {
            if (islem == '*' || islem == '.')
                return sayi1* sayi2;
            else if (islem == '/')
                return sayi1 / sayi2;
            else if (islem == '+')
                return sayi1+ sayi2;
            else
                return sayi1- sayi2;
        }



        //kullanıcı parametre olarak ondalıklı bir değer girsin.
        //15.89 gibi. 15 tam kısmı ve 89 ondalıklı kısmı ayrı ayrı elde edip ekrana yazan metot.
        //deger.Split(".");15 89 //2 elemanlı bir dizi elde eder.[0] ilk değer tam kısmı, [1] ikinci değer ondalıklı kısmı alırız.
        public int TamKismiAl(double deger)
        {
            return Convert.ToInt32(deger.ToString().Split(".")[0]);
        }

        public int OndalikliKismiAl(double deger)
        {
            return Convert.ToInt32(deger.ToString().Split(".")[1]);
        }

        //1.500,38 formatındaki bir datanaın 1.500 kısmı binlik kısım için kullanılır. ,38 ise kuruş kısmı için kullanılır. 
        //hem binlik kısmı hem tam kısmı(binlik sonrası değer), hem de kuruş kısmını bulabilmek için uygun metodu yazınız.

        public int BinlikGosterim(string sayi)
        {
            return Convert.ToInt32(sayi.ToString().Split('.')[0]);
        }
   
        public int KusuratGosterim(string sayi)
        {
            return Convert.ToInt32(sayi.ToString().Split(',')[1]);
        }

        public int TamGosterim(string sayi)
        {
            return Convert.ToInt32(sayi.ToString().Split('.')[1].Split(',')[0]);
        }

        //2 tane ondalıklı değeri(virgülle ya da . ile girilmiş olabilir.) toplayıp tam kısımların toplamı . ondalıklı kısımların toplamı. 2double toplamını yapıp geriye değeri döndüren metot.

        public int OndalikToplama(double sayi1, double sayi2)
        {
            double toplam = 0;
            toplam = sayi1 + sayi2;
            return Convert.ToInt32(toplam.ToString().Split('.')[0]);
        }

        //2 tane int dizisi alıp, bütün elemanlarını dizi1[0]+dizi2[0] şeklinde topla.
        //4,5,9,15
        //3,7,4,13
        //yeni oluşan dizinin elemanlarını geriye döndüren metot.

        public int[] DizileriTopla(int[] dizi1, int[] dizi2)
        {
            //if (dizi1.Length == dizi2.Length)
            //{

            //}

            int[] toplam=new int[dizi1.Length];
            for (int i = 0; i < dizi1.Length; i++)
            {
                toplam[i] += dizi1[i] + dizi2[i];
            }
            return toplam;
        }


        //ihtiyaç durumunda yeni metotları buraya ekleyebiliriz.

        //yeni metotlar geldi. Bugün 13.07.2025




    }
}


