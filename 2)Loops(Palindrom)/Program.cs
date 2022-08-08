/* **2) Loops**
Palindrom:
Eğer bir kelimenin düz okunuşu ile ters okunuşu birbirinin aynı ise palindromdur, değilse palindrom değildir.
Örneğin 'ana' kelimesi bir palindrom iken 'baba' kelimesi bir palindrom değildir.
Basit bir palindrom kontrol konsol uygulaması yazınız:
1) Kullanıcı 'q' harfine basana kadar tekrar tekrar giriş yapabilir, 'q' harfine bastığında uygulamadan çıkılır.
2) Kullanıcının yaptığı giriş en az iki karakter olmalıdır.
3) Kullanıcı sadece harf girecek diye bir zorunluluk yoktur.
4) Eğer kullanıcının girdiği kelime palindrom ise ekrana 'Girdiğiniz kelime palindromdur.', değilse 'Girdiğiniz kelime palindrom değildir.' yazılır.
*/

Console.WriteLine("PALİNDROM TESTİNE HOŞGELDİNİZ!!!");
Console.Write("Bir Kelime Giriniz: ");
string duzKelime = Console.ReadLine();
int sayım = duzKelime.Length - 1;
string tersKelime = "";

for(int i = duzKelime.Length; i>0 ; i--)
{
    tersKelime += duzKelime[i - 1];
}
if(duzKelime == tersKelime)
{
    Console.WriteLine("Girmiş Olduğunuz Kelime: " + duzKelime);
    Console.WriteLine("Girmiş Olduğunuz Kelimenin Tersi: " + tersKelime);
    Console.WriteLine("TEBRİKLER, PALİNDROM :D !!!");
}
else
{
    Console.WriteLine("Girmiş Olduğunuz Kelime: " + duzKelime);
    Console.WriteLine("Girmiş Olduğunuz Kelimenin Tersi: " + tersKelime);
    Console.WriteLine("MALESEF PALİNDROM DEĞİL :(");
}




