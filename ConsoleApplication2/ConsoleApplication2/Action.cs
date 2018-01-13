namespace ConsoleApplication2
{
    public class Action
    {
        public double? Calculate(int num1, int num2, string action)
        {
            var actionMethod = GetActionMethod(action);
            switch (actionMethod)
            {
                case ActionData.Add:
                    return num1 + num2;
                case ActionData.Division:
                    //skrócony zapis if else
                    /*
                     *  if(num2!=0)
                     *      return (double?) num1 / num2;
                     *  else
                     *      return null;
                    */
                    return num2 !=0?(double?) num1 / num2: null;
                    
                case ActionData.Subtraction:
                    return num1 - num2;
                        
                case ActionData.Multiplication:
                    return num1 * num2;
                default:
                    return null;
            }

        }


        private ActionData GetActionMethod(string actionSymbol)
        {
            if (actionSymbol.Equals("+"))
                return ActionData.Add;
            if (actionSymbol.Equals("-"))
                return ActionData.Subtraction;
            if (actionSymbol.Equals("*"))
                return ActionData.Multiplication;
            if (actionSymbol.Equals("/"))
                return ActionData.Division;
            //zwracamy 0 jesli żaden z wymienionych
            return 0;
        }


    }
}
