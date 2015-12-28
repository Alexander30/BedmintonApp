using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfProject
{
   public static class Write
    {
        static StringBuilder textToWrite = new StringBuilder();
        public static String path = Environment.CurrentDirectory+"Zaznamenane_skore.txt";
        /// <summary>
        /// INformacie o stave hry.
        /// </summary>
        /// <param name="time"></param>
        /// <param name="countFirstPlayer"></param>
        /// <param name="setCountFirstPlayer"></param>
        /// <param name="countSecondPlayer"></param>
        /// <param name="setCountSecondPlayer"></param>
        public static void StateOfGame(TimeSpan time,int countFirstPlayer, int setCountFirstPlayer, int countSecondPlayer, int setCountSecondPlayer)
        {
            // textToWrite.AppendLine(string.Format("Čas: {0}, Stav 1: {1}, Stav 2: {2}, Set 1: {3}, Set 2: {4}", time, countFirstPlayer, countSecondPlayer, setCountFirstPlayer, setCountSecondPlayer));
            File.AppendAllText(Write.path,string.Format("Čas: {0}, Stav 1: {1}, Stav 2: {2}, Set 1: {3}, Set 2: {4}\n", time, countFirstPlayer, countSecondPlayer, setCountFirstPlayer, setCountSecondPlayer));
        }

       /* public static bool WriteToFile()
        {
            bool result = false;
            try
            {
                File.AppendAllText(Write.path, textToWrite.ToString());
                textToWrite = new StringBuilder();
            }
            catch (Exception e)
            { throw e; }
            return result;
        }*/


    }
}
