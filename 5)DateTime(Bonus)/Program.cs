/*** 5) DateTime (Bonus) ** 
Ekrandan kullanıcının doğum tarihini alan ve yaşını hesaplayan basit bir konsol uygulaması.
1 - Kullanıcıdan doğum tarihi istenir
2 - Yaş hesaplanır
3 - Ekrana yaş yazdırılır*/

Console.Write("Doğum Tarihinizi Gün/Ay/Yıl Şeklinde Giriniz: ");
DateTime dogumGunu = Convert.ToDateTime(Console.ReadLine());
DateTime guncelTarih = DateTime.Now;
int yasGun = guncelTarih.Day - dogumGunu.Day;
int yasAy = guncelTarih.Month - dogumGunu.Month;
int yasYil = guncelTarih.Year - dogumGunu.Year;
Console.WriteLine("Yaşınız : " + yasGun + "/" + yasAy + "/" + yasYil);