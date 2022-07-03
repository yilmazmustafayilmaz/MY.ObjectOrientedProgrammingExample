#region Class/Object(Create a class example)

//public class Feriha{}

#endregion      

#region ClassMembers(Create a class and class members)

// public class RamizDayi
// {
//     //ClassMembers
//     public string Name; //field
//     public int Age; //field
//     public void Sleep(){} //Method
// }

#endregion

#region Constructors(Create a class and constructors)

// public class Bizimkiler
// {
//     public string? benimAdim;
//     public Bizimkiler()
//     {
//       benimAdim = "Benim Adım Cemil Constructors";
//       System.Console.WriteLine(benimAdim);
//     }
// }

#endregion

#region AccessModifiers(Public,Private,Protected,Internal)

// public class AccessModifiers
// {
//     public AccessModifiers()
//     {
//         OzelAlan = "Sadece bulunduğu sınıf içerisinde erişilebilir";
//         GenelAlan = "Projenin tamamında erişilebilir";
//         BaglantiliAlan = "Kendi sınıfı ve kalıtım verdiği bağlantılı sınıflarda erişilebilir";
//         KisitliAlan = "Bulunduğu katman içerisinde erişilebilir";
//         System.Console.WriteLine("*************************************************************************************");
//         System.Console.WriteLine($"Private: {OzelAlan}");
//         System.Console.WriteLine("*************************************************************************************");
//         System.Console.WriteLine($"Public: {GenelAlan}");
//         System.Console.WriteLine("*************************************************************************************");
//         System.Console.WriteLine($"Protected: {BaglantiliAlan}");
//         System.Console.WriteLine("*************************************************************************************");
//         System.Console.WriteLine($"Internal: {KisitliAlan}");
//         System.Console.WriteLine("*************************************************************************************");
//     }
//     private string OzelAlan;
//     public string GenelAlan;
//     protected string BaglantiliAlan;
//     internal string KisitliAlan;
// }

#endregion

#region Properties/Encapsulation(Get and Set)

// public class LeylaMecnun
// {
//     public LeylaMecnun(string ismailAbi)
//     {
//         IsmailAbi = ismailAbi;
//         System.Console.WriteLine(IsmailAbi);
//     }
//     private string? _ismailAbi;
//     public string IsmailAbi
//     {
//         get
//         {
//             return "Hoop İsmail Abi " + _ismailAbi;
//         }
//         set
//         {
//             _ismailAbi = value;
//         }
//     }
// }

#endregion

#region Inheritance(Base and Derived Class)

// public class Babam
// {
//     public void BabaReplik()
//     {
//         System.Console.WriteLine("Açaydım kollarımı gitme diyeydim..!");
//     }
// }
// public class Oglum : Babam
// {

// }

#endregion

#region Polymorphism

// public class Diziler
// {
//     public virtual void DiziMuzikleri()
//     {
//         System.Console.WriteLine("Dizi müziği seçiminiz");
//     }
// }
// public class Dizi1 : Diziler
// {
//     public override void DiziMuzikleri()
//     {
//         base.DiziMuzikleri();
//         System.Console.WriteLine("Dizi bir müziği");
//     }
// }
// public class Dizi2 : Diziler
// {
//     public override void DiziMuzikleri()
//     {
//         base.DiziMuzikleri();
//         System.Console.WriteLine("Dizi iki müziği");
//     }
// }

#endregion

#region AbstractandInterface

// public abstract class Film
// {
//     public string? _filmAdi;
// }
// public interface IFilmTurleri
// {
//     void AksiyonSahnesi(string filmAdi);
// }
// public class AksiyonFilmi : Film, IFilmTurleri
// {
//     public void AksiyonSahnesi(string filmAdi)
//     {
//         base._filmAdi = filmAdi;
//         System.Console.WriteLine($"{_filmAdi} Aksiyon sahnesi eklendi.");
//     }
// }

#endregion

#region Enums

// enum FilmSet
// {
//     Oyuncu,
//     Yönetmen,
//     Kameraman
// }

#endregion
public class Program
{
    static void Main(string[] args)
    {

        #region Class/Object(Create an object from Feriha class)

        //Feriha feriha = new();

        #endregion

        #region ClassMembers(Create an instance from ramizDayi class and call the class members)

        // RamizDayi ramizDayi = new();
        // ramizDayi.Name = "Ramiz";
        // ramizDayi.Age = 53;
        // ramizDayi.Sleep();

        #endregion

        #region Constructors(Create an object and call the constructors)

        //Bizimkiler bizimkiler = new();

        #endregion

        #region AccessModifiers(Public,Private,Protected,Internal)

        //AccessModifiers accessModifiers = new();

        #endregion

        #region Properties/Encapsulation(Get and Set)

        //LeylaMecnun leylaMecnun = new("Nasılsın");

        #endregion

        #region Inheritance(Base and Derived Class)

        // Oglum oglum = new();
        // oglum.BabaReplik();

        #endregion

        #region Polymorphism

        // Dizi1 dizi1 = new();
        // dizi1.DiziMuzikleri();

        #endregion

        #region AbstractandInterface

        // AksiyonFilmi aksiyonFilmi = new();
        // aksiyonFilmi.AksiyonSahnesi("XXX");

        #endregion
    
        #region Enums

        //System.Console.WriteLine(FilmSet.Kameraman);

        #endregion
    }
}

