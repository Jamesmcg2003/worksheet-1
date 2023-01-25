namespace q1

{
    internal class Program
    {
        /* Name: James McGuinness
         * Date: 25/01/23
         * Desc: Worksheet 1
         * */

        static void Main(string[] args)
        {
            PrintIntegersFor();
            
        }

        static private void PrintIntegersFor()
        {
            for (int i = 40; i <= 60;)
            {
                Console.WriteLine($"{i}");
                i = i + 1;
                
            } 
        }
    }   
}