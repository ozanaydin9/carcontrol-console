using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _13253009homework2
{
    class Test
    {


       static void Main(string[] args)
        {
                                                                                          //       8 
            int yon = 6;  //başlangıç yönü sağ, yönler numpad tuşları gibi  --->         //    4 Yönler 6
            int firca = 0; //firca 0 havada,firca 1 yerde                                 //       2
            int yurut = 0; //arabanın ne kadar yürüyeceğini tutan değişken
        
            int satir = 0; //Alan dizimizin satir ve sutun değerleri 
            int sutun = 0; //Araba başlangıçta 0,0 konumunda olduğu için değerleri 0,0.

            int[,] Alan = new int[20, 20]; //1 ve 0 lardan oluşacak Alanımız
           
            Metods obj = new Metods(); //Metods clasındaki metodlarımızı çağırmak için obje
           
            obj.menu(); //Menüyü çağırıyoruz
            
          
            string kullanicigirisi = Console.ReadLine(); //kullanicinin girdiği değerleri virgüle göre split yapıp 
            string[] dizi = kullanicigirisi.Split(','); //string dizisine aktarımı


            for (int i = 0; i < dizi.Length; i++)
            {

                if (dizi[i] == "1")

                    firca = 1;   //fırça durumlarını da metoddan çağırabilirdim fakat gerek duymadım

                else if (dizi[i] == "2")
                    firca = 0;  

                else if (dizi[i] == "3")  // yön değişimlerini akılda kalması için dediğim gibi klavyenin numpad kısmına göre yaptım
                {                                       // sağa dönmesi halinde yöne atanan yeni değerler
                    if (yon == 8)                       // örneğin aracın mevcut yönü 8 ise sağa dönmesi halinde yeni yönü 6 olur
                    {
                        yon = 6;
                    }
                    else if (yon == 4)
                    {
                        yon = 8;
                    }
                    else if (yon == 6)
                    {
                        yon = 2;
                    }
                    else if (yon == 2)
                    {
                        yon = 4;
                    }

                }

                else if (dizi[i] == "4")        // sola dönmesi halinde yöne atanan yeni değerler
                {                            // örneğin aracın mevcut yönü 8 ise sola dönmesi halinde yeni yönü 4 olur
                    if (yon == 8)
                    {
                        yon = 4;
                    }
                    else if (yon == 4)
                    {
                        yon = 2;
                    }
                    else if (yon == 2)
                    {
                        yon = 6;
                    }
                    else if (yon == 6)
                    {
                        yon = 8;
                    }

                }
                else if (dizi[i].Contains("5_"))
                {
                    string[] yurutdizi = dizi[i].Split('_');
                    yurut = int.Parse(yurutdizi[1]); // alt çizgiye göre split olan dizinin ilerleme miktarını alıyoruz 
                                                     //yani bölünen dizinin 2. elemanını
                   
                    //Console.WriteLine(yurut);  doğru alıp almadığını kontrol ettim
                    
                    //Console.WriteLine("{0}, {1}", satir,sutun);   aynı şekilde aşağıdaki komutlara girmeden önceki satir ve sütün değerinin
                                                                  //doğru gelip gelmediğini sırayla kontrol ettim

                    // eğer yön y ekseni doğrultusundaysa geriye satir, x ekseni doğrultusundaysa sütün değeri geri dönecek
                    // buna görede gelen değeri satir ve sütüna atadım

                    if(yon==8|| yon==2) 
                        satir=obj.DiziYaz(yon, satir, sutun, yurut, firca,  Alan);
                    else if(yon==4||yon==6)
                        sutun=obj.DiziYaz(yon, satir, sutun, yurut, firca, Alan);

                   
                    //Console.WriteLine("{0}, {1}", satir, sutun); // metoddan dönen değerleri kontrol ettim
                }
                else if (dizi[i] == "6")
                {
                    obj.DiziGoruntule(Alan); //diziyi görüntüleyen metod Alan dizimizi parametre alıyor

                }
                else if (dizi[i] == "0")
                {
                    break; // sıfır girilmesi halinde break.
                }
            }
        } 


        }

    }
