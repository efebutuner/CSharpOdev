/*** 4) Loops (Bonus) **
Yıldız ve boşluk karakterlerini kullanarak ekrana bir dama tahtası çizen basit bir konsol uygulaması.
Örnek:
*  *  *  *  
  *  *  *  *
*  *  *  *  
  *  *  *  *
*  *  *  *  
  *  *  *  *
*  *  *  *  
  *  *  *  * 
 */
int count = 0;
for(int k = 0; k < 8; k++)
{
    if(count % 2 == 0)
    {
        for (int i = 0; i < 8; i++)
        {
            if (i % 2 == 0)
            {
                Console.Write("*");
            }
            else
            {
                Console.Write(" ");
            }
        }
    }
    else
    {
        for (int j = 0; j < 8; j++)
        {
            if (j % 2 == 0)
            {
                Console.Write(" ");
            }
            else
            {
                Console.Write("*");
            }
        }
    }
    count = count + 1; 
    Console.WriteLine();
}
