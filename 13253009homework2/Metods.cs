using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _13253009homework2
{
    class Metods
    {


        public void menu() // Menüyü ekrana yazan metod
        {
            Console.WriteLine("1....Fırça Aşağı");
            Console.WriteLine("2....Fırça Yukarı");
            Console.WriteLine("3....Sağa dön");
            Console.WriteLine("4....Sola dön");
            Console.WriteLine("5_x..X kadar ilerle");
            Console.WriteLine("6....Görüntüle");
            Console.WriteLine("0....Çıkış");
            Console.WriteLine();
            Console.WriteLine("Değerleri virgülle ayırarak giriniz");
            Console.WriteLine("-----------------------------------");
        }

        public int DiziYaz(int yon, int satir, int sutun, int yurut, int firca, int[,] Alan) //Asıl görevi yapan metodumuz
        {                                                                                    //Değişkenlerimizin tümünü parametre olarak alıyor
            if (yon == 6)                                                                  //int bir metod ve değer döndürüyor
            {
                
                if (sutun+yurut > 20) //Aracın yönü sağ taraf yani 6 , kullanıcının girdiği yurutme değeri ile mevcut sutunundaki değerin 
                {  }                   //toplamı 20'den büyükse (dizi sınırlarını aşma hatası vermemesi için) if içine girer ve hiçbirşey yapmaz.
                else
                {
                    for (int i = sutun; i < sutun + yurut; i++)    // Sınırları aşmıyorsa for döngüsüne gelir
                    {                                             // araç sağ yönde hareket ediceği için matris alanımızı düşünürsek 
                        if (firca == 1)                          // değişecek değerimiz sütün değeridir. Bu yüzden for döngümüz sütün üzerinden
                        {                                       // ilerleyecek. Döngünün son bulacağı sutun+yurut değeri aracın son durumdaki
                            Alan[satir, i] = 1;                // konumu ifade ediyor yani sütünun son değeri. 
                        }                                       // Alan[satir,i] i sütün değeri ve döngüde birer artıyor. firca 1 konumundaysa o matris
                        else if (firca == 0)                   // alanına 1, eğer fırça 0 konumundaysa 0 yazıyor.
                        {
                            Alan[satir, i] = 0;
                        }

                    }
                }
                sutun =sutun+ yurut;           // sütünun yürüme miktarından sonraki son alacağı değer bir sonraki işlem için main'e geri dönüyor.
                return sutun;

            }


            else if (yon == 4)                  // sağa yani 6 yönünde gitmesinden tek farkı sütünun araç yer değiştirirken azalması.
            {                                   // Örneğin araç 10. sütundaysa ve 4 yönünde 4 birim ilerleyecekse aracın son sütun değeri 10-6 olur.
                
                if (sutun-yurut< 0) // sütun değeri eksileceği için sağdan değilde soldan yani 0 dan küçük olma durumunu kontrol ederiz
                { }
                else
                {
                    for (int i = sutun; i > sutun - yurut; i--)
                    {
                        if (firca == 1)  // yine aynı şekilde fircanın durumuna göre dizinin o elemanına 1 yada 0 ataması yapılır.
                        {
                            Alan[satir, i] = 1;
                        }
                        else if (firca == 0)
                        {
                            Alan[satir, i] = 0;
                        }

                    }
                }
                sutun =sutun- yurut;
                return sutun;  // bu yöndede değişecek tek değer sütun olduğu için geri dönen değer sütun değeridir.


            }
            else if (yon == 8)              // bu sefer 8 yönüne gidildikçe matrisi düşünürsek değişen satır değerimiz olur.
            {
               
                if (satir-yurut < 0)        // dizimizi bu yönde 0 a doğru götürdüğümüz için yine 0 a göre kontrol yapıyoruz.
                { }
                else
                {
                    for (int i = satir; i > satir - yurut; i--)  // x ekseni doğrultusunda gitmekten tek farkı bu sefer sütun yerine 
                    {                                         //satir değerimizin değişecek olması ve Alan[i,sutun] komutuyla satir yerine döngümüzün
                        if (firca == 1)                  //i elemanı satirin yerini alıyor. 0 doğru gittiği için i değerimiz her adımda azalıcak
                        {                             // yani 3. satirda olan aracı 8 yönüne götürmeye başladığımızda satır değeri 2,1 olarak azalır.
                            Alan[i, sutun] = 1;       
                        }
                        else if (firca == 0)
                        {
                            Alan[i, sutun] = 0;
                        }
                    }
                }
                satir =satir- yurut;
                return satir;       //satir değeri değiştiği için son konumdan devam etme amacıyla satir değeri geri döner

            }
            else if (yon == 2)  // yine satir değerinin değişiceği bu sefer artacağı yön durumu
            {
                
                if (satir +yurut> 20)
                { }
                else
                {
                    for (int i = satir; i < satir + yurut; i++)
                    {
                        if (firca == 1)
                        {
                            Alan[i, sutun] = 1;
                        }
                        else if (firca == 0)
                        {
                            Alan[i, sutun] = 0;
                        }

                    }
                }
                satir = satir +yurut;
                return satir; //burdada satir değeri geri döner

            }

            return 0; // Kodlar itibariyle yukarıdaki iflere girmeme durumu olmasada derleyici int tipindeki metodun yinede değer döndürmesini
                        // beklediği için return 0 komutu burdadır. Zaten yukarıdaki returnlerden biri çalıştıktan sonra buraya program bakmaz.
        }               // yani 0 değeri hiç dönmeyecek.
        
        public void DiziGoruntule(int[,] Alan)
        {

            for (int i = 0; i < 20; i++) // 20 yerine satiri ifade eden get.Length(0) ve sütün için get.Length(1) kullanılabilir.
            {                               //Dizimizin boyutu belli olduğu için gerek duymadım.
                for (int j = 0; j < 20; j++)
                {
                    if (Alan[i, j] == 1) //DiziYaz metodunda yazılan 1 ve 0 değerlerine göre
                    {
                        Console.Write("*");     //Eğer 1 varsa yıldız
                    }
                    
                    else
                    {
                        Console.Write(" ");     //1 yoksa boşluk yazan görüntüleme metodumuz.
                    }
                }
                Console.WriteLine();
            }



        }



    }
}



