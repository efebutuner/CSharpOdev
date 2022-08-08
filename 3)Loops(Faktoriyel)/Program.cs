/* **3) Loops**
Faktoriyel:
Bir sayının sürekli 1 azaltılarak arka arkaya yapılan çarpım faktoriyeldir.
Örneğin 5 faktoriyel 5! şeklinde gösterilir ve 5! = 5 * 4 * 3 * 2 * 1 olarak hesaplanır.
Basit bir faktoriyel hesaplama konsol uygulaması yazınız:
1) Kullanıcıdan tek seferlik pozitif bir tam sayı alınır.
2) Kullanıcının girdiği sayının faktoriyeli hesaplanarak ekrana yazdırılır.
*/
Console.Write("Pozitif bir TamSayı giriniz: ");
int fakto = Convert.ToInt32(Console.ReadLine());
int final = 1;
for (int i = fakto; i > 0; i--)
{
    final *= i;
    
}
Console.WriteLine(final);