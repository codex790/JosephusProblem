using System;
using Josephus.Resources;

namespace Josephus
{
    public class Program
    {
        /// <summary>
        /// Accept number of children and eliminate position parameters to display the winning child id and the removed children id in the console
        /// </summary>
        /// <param name="args"></param>
        public static void Main(string[] args)
        {
            string input;
            
            do
            {
                Console.WriteLine(JosephusTestResources.Breakline);

                int numberOfChildren = CaptureInput(JosephusTestResources.NumberOfChildrenInputText);
                int eliminatePosition = CaptureInput(JosephusTestResources.EliminatePositonInputText);

                if (!ValidInput(numberOfChildren, eliminatePosition))
                {
                    Console.WriteLine(JosephusTestResources.InvalidEntryErrorText);
                }
                else
                {
                    var childCircle = new ChildCircle(numberOfChildren, eliminatePosition);
                    Console.WriteLine("{0} {1}", JosephusTestResources.RemainingChildResultText, childCircle.GetWinner());

                    if (childCircle.RemovedChildren.Count > 0)
                    {
                        Console.WriteLine("{0} {1}", JosephusTestResources.EliminatedChildrenResultText,
                            string.Join(", ", childCircle.RemovedChildren));
                    }
                    else
                    {
                        Console.WriteLine(JosephusTestResources.NoRemovedChildrenText);
                    }
                }

                Console.WriteLine(JosephusTestResources.TryAgainText);
                input = Console.ReadLine();
                Console.WriteLine();

            } while (input != null && input.ToLower() == "y");

        }

        #region Console Input Helper Methods
        private static bool ValidInput(int numberOfChildren, int removeOnCountOn)
        {
            return numberOfChildren > 0 && removeOnCountOn > 0;
        }

        private static int CaptureInput(string msg)
        {
            int output;
            string input;
            do
            {
                Console.WriteLine(msg);
                input = Console.ReadLine();
            } while (!int.TryParse(input, out output));

            return output;
        }
        #endregion
    }
}
