using System;

namespace Recursive
{
    class Program
    {
        static void Main(string[] args)
        {
            //Rekürsif- özyineleme
            // üs alma islemlerinde genelede kullanılır
            //3^4 = 3*3*3*3
           
            int result =1;
            for (int i = 1; i < 5; i++)
                result= result *3;
            
            Console.WriteLine(result);

            Islemler instance = new();
            Console.WriteLine(instance.Expo(3,4));
            
            //Extension Methodlar 
            // bosluk olup olmadıgı bana donen bir method yazmak istiyorum
             // birtane int diziyi sıralayan extention method
            string ifade ="Ferhan Abacı";
            bool sonuc =ifade.CheckSpaces();
            Console.WriteLine(ifade.CheckSpaces());
            if(sonuc){// eger bosluk varsa baska bir karakterle değistiren bir extention yazayım
                Console.WriteLine(ifade.RemoveWhiteSpaces());

            }
            Console.WriteLine(ifade.MakeUppCase());
            Console.WriteLine(ifade.MakeLowerCase());

            int[] dizi={9,3,6,2,5,0};// bunu sıralayan bir extention a ihtiyacım var 
          
            dizi.SortArray(); 
            dizi.EkranaYazdır();

            int sayi = 5;
            Console.WriteLine(sayi.IsEvenNumber());
            
            Console.WriteLine(ifade.GetFirstCharacter());
        }
    }
    public class Islemler{
        public int Expo(int sayi,int üs){
            if (üs<2)
                return sayi;
            return Expo(sayi,üs-1)*sayi;
        }
        //Expo(3,4)
        //Expo(3,3)*3;
        //Expo(3,2)*3;
        //Expo(3-1)*3*3;
        //3*3*3=3^4;

    }
    public static class Extension{// extantion method ve classlar static olmalı
        // en dogru yazımı aslında ilk normal bir sekilde yazmak ihtiyac varsa oyle yazmak 
        public static bool CheckSpaces(this string param){ // this koyarak onu bir extantion method haline getiriyorum 
            //Contains bir string kütüphanesidir
            return param.Contains(""); // peki bunu yazdık extension method için ne yapmam gerekiyor
        }
        public static string RemoveWhiteSpaces(this string param)
        {
            string[] dizi = param.Split();// bu diziyi boslularından ayor ve bir diziye at dedik 
            return string.Join("",dizi);// string nokta joın ifadesiyle bu diziyi birleştir diyoruz
        }
        public static string MakeUppCase(this string param){
            return param.ToUpper();
        }
         public static string MakeLowerCase(this string param){
            return param.ToLower();
        }
        public static int[] SortArray(this int[] param){
            // şimdi nasıl order lıcaz?
            Array.Sort(param);
            return param; 
        }
        public static void EkranaYazdır(this int[] param){

            foreach (var item in param)
            {
                Console.WriteLine(item);
                
            }
           
        }
         public static bool IsEvenNumber(this int param){

                return param%2 == 0;
            }

        public static string GetFirstCharacter(this string param){
            return param.Substring(0,1); // start indexi  end index veririm bana onların arasındaki ifade yi bana geri doner
        }     
    }
}
