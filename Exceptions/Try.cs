using System;

namespace TestFoodCost.Exceptions
{
    public class Try
    {
        public bool TryExecute(Action action)
        {
            try
            {
                action();
                return true;
            }
            catch (Exception ex)
            {
                if (ex is IUseEx useEx)
                {
                    Console.WriteLine(useEx.DefaultMessage);
                }
                else
                {
                    Console.WriteLine("Что-то пошло не так.");
                }
                return false;
            }
        }
    }
}
