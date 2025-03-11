//CTRL + K + S
using ConsoleApp2.ErisimBelirleyiciler;
using MyNamespace;

#region Erisim Belirleyiciler
User user = new();
user.AdSoyad = "Fatih Bozkurt";
user.Yas = 21;
user.Email = "fatihbozkurt@gmail.com";

user.BilgileriGoster();
#endregion
#region Namespace
Hesaplama hesaplama = new();
hesaplama.Topla(3,5);
hesaplama.Carp(3,5);
#endregion
#region MerhabaDünya
Console.WriteLine("Merhaba Dünya!");
#endregion