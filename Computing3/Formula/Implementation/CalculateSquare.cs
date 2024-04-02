using Computing3.Formula.Interface;

namespace Computing3.Formula.Implementation
{
    public class CalculateSquare: ICalculateSquare
    {
        public int Square(int number)
        {
            return number * number;
        }
    }
}
