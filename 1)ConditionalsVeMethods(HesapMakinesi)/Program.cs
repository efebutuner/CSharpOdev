/* **1) Conditionals ve Methods **
Algoritma:
1) Kullanıcıdan ilk sayı istenir.
2) Kullanıcıdan ikinci sayı istenir.
3) Kullanıcıdan yapılması istenen işlem istenir (+, -, *, /).
4) Kullanıcının yaptığı girişlere göre hesaplama işlemi yapılır.
5) Hesap sonucu ekrana yazdırılır.

İpucu:
Sayısal tipte bir değişkene herhangi bir sayısal değer atanabildiği gibi herhangi bir aritmetik işlem yapılarak bu işlemin sonucu da atanabilir.

Örnek 1:
double sayi = 1;
double toplam = 2 + 3;

Örnek 2:
double sayi1 = 4;
double sayi2 = 5;
double carpim = sayi1 * sayi2;

İyi çalışmalar. :)
*/

Console.Write("Birinci Sayıyı Giriniz: ");
double sayi1 = Convert.ToDouble(Console.ReadLine());
Console.Write("İkinci Sayıyı Giriniz: ");
double sayi2 = Convert.ToDouble(Console.ReadLine());
Console.Write("Yapılmasını İstediğiniz İşlemi Giriniz: (+,-,*,/)");
char islem = Convert.ToChar(Console.ReadLine());

switch (islem)
{
    case '+':
        double toplam = sayi1 + sayi2;
        Console.Write("Toplam işleminin sonucu: " + toplam);
        break;
    case '-':
        double fark = sayi1 - sayi2;
        Console.Write("Çıkarma işleminin sonucu: " + fark);
        break;
    case '*':
        double carpim = sayi1 * sayi2;
        Console.WriteLine("Çarpım İşleminin sonucu: " + carpim);
        break;
    case '/':
        double bolum = sayi1 / sayi2;
        Console.WriteLine("Bölüm İşleminin sonucu: " + bolum);
        break;
}
