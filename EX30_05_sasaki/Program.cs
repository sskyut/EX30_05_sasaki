namespace EX30_05_sasaki
{
    internal class Program
    {
        static void Main(string[] args)
        {
           Person person=new Person(new DateTime(2004,04,01),"ハムの太郎",50f,172.2f, 29.7f, 81,"9時～22字","男性");
            person.SelfIntroduction();
        }
    }
}