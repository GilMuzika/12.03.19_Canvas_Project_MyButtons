using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Client
{
    class Program
    {
        static void Main(string[] args)
        {
            initialiseCanvas();

            Console.WriteLine($"Current number of buttons: {Canvas_MyButtons.MyCanvas.GetCurrentNumberOfButtons()}");
            Console.WriteLine($"Maximal number of buttons: {Canvas_MyButtons.MyCanvas.GetMaxNumberOfButtons()}");
            Console.WriteLine($"Maximum height of a button: {Canvas_MyButtons.MyCanvas.GetTheMaxHeightOfAButton()}");
            Console.WriteLine($"Get the maximum width of a button: {Canvas_MyButtons.MyCanvas.GetTheMaxWidthOfAButton()}");
            Console.WriteLine($"Get the maximum width of a button using IComparer: {Canvas_MyButtons.MyCanvas.GetTheMaxWidthOfAButtonThroughIComparer()}");
            Console.WriteLine($"Get the maximum height of a button: {Canvas_MyButtons.MyCanvas.GetTheMaxHeightOfAButton()}");
            Console.WriteLine($"Get the maximum height of a button using IComparer: {Canvas_MyButtons.MyCanvas.GetTheMaxHeightOfAButtonThroughIComparer()}");
            int x = 5; int y = 10;            
            Console.WriteLine($"Is the point with the coordinates \"({x}, {y})\": {Canvas_MyButtons.MyCanvas.IsPointInsideAButton(x, y)}");
            x = 25; y = 70;
            Console.WriteLine($"Is the point with the coordinates \"({x}, {y})\": {Canvas_MyButtons.MyCanvas.IsPointInsideAButton(x, y)}");
            Console.WriteLine(Canvas_MyButtons.MyCanvas.IsPointInsideAButton(25, 100));
            Canvas_MyButtons.MyCanvas.DeleteLastButton();
            Console.WriteLine($"Number of the buttons the last button had been deleted: {Canvas_MyButtons.MyCanvas.GetCurrentNumberOfButtons()}");
            Canvas_MyButtons.MyCanvas.ClearAllButtons();
            Console.WriteLine($"Number of the buttons the last button had been deleted: {Canvas_MyButtons.MyCanvas.GetCurrentNumberOfButtons()}");
            Console.WriteLine(Canvas_MyButtons.MyCanvas.GetCurrentNumberOfButtons());

            Console.ReadKey();
        }

        private static void initialiseCanvas()
        {
            Random rnd = new Random();

            int[,] matrix = new int[(int)Math.Sqrt(Canvas_MyButtons.MyCanvas.MaxButtons), (int)Math.Sqrt(Canvas_MyButtons.MyCanvas.MaxButtons)];

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    Canvas_MyButtons.MyCanvas.CreatenewButton(i, j, i + 15 + rnd.Next(15), j + 15 + rnd.Next(15));


                }
            }

            


        }
    }
}
