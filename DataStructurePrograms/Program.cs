// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");


namespace DatastructurePrograms
{
    class program
    {
        static void Main(String[] args)
        {
            //Console.WriteLine(Simple Balanced Paranthesis);
            //int option = Convert.ToInt32(Console.ReadLine());
            //BalanceParentheses check = new BalanceParentheses();

            DataStructurePrograms.BalancedParantheses value = new DataStructurePrograms.BalancedParantheses();
            value.IsBalancedParentheses();
            Console.WriteLine("Simple Balanced Paranthesis");
           
        }
    }
}