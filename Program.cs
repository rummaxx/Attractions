using System;

namespace ConsoleApp1
{
    class Program
    {
        
        public void getInfo(NewAttraction thisObject)
        {
            Console.WriteLine(thisObject.getCity());
            Console.WriteLine(thisObject.getAttraction());
            Console.WriteLine(thisObject.getLink());
            Console.WriteLine(thisObject.getDescription());
        }
       

        public void postInfo(String Name, String City,String Attraction,String Link,String Description)
        {
            NewAttraction name = new NewAttraction(City, Attraction, Link, Description);

        }

        static void Main(string[] args)
        {
            Program start = new Program();
            start.postInfo("Kreml","Astrakhan", "Kremlin", "http://astrakhan-musei.ru/article/article/view/13843", "Астраханский кремль — историко-архитектурный комплекс,\n филиал ГБУК АО «Астраханский музей-заповедник», \n крепость в Астрахани, выстроенная на месте первых фортификационных сооружений,\n  появившихся в связи с переносом города в 1557-1558 годах воеводой И.С. Черемисиновым.\n  Комплекс Астраханского кремля представляет собой целостный ансамбль памятников оборонного зодчества, \n культовой и гражданской архитектуры и включает в себя 22 объекта XVI — начала XX вв.");
            Console.Read();
        }
    }
}
