using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using System.Windows.Threading;

namespace WpfProject
{
    /// <summary>
    /// Interaction logic for MainWindow2.xaml
    /// </summary>
    public partial class MainWindow2 : Window
    {
        bool IsSPressed = false;
        DispatcherTimer dispatcherTimer = new DispatcherTimer();
        Stopwatch stopwatch = new Stopwatch();
        TimeSpan actualTimeOfGame = new TimeSpan();
        public MainWindow2()
        {
            InitializeComponent();
            Class myClass = new Class();

            dispatcherTimer.Tick += new EventHandler(dispatcherTimer_Tick);
            dispatcherTimer.Interval = new TimeSpan(0, 0, 1);
            dispatcherTimer.Start();
            stopwatch.Start();
        }
        private void dispatcherTimer_Tick(object sender, EventArgs e)
        {
            actualTimeOfGame = stopwatch.Elapsed;
            labelTimer.Content = string.Format("{0:hh\\:mm\\:ss}", actualTimeOfGame);
        }

        private void buttPlusFirstPlayer_Click(object sender, RoutedEventArgs e)
        {
            int actualCount = Convert.ToInt32(LabelCountFirstPlayer.Content);
            switch (IsSPressed)
            {
                case false:
                    if (actualCount != 30)
                    {
                        if (actualCount == 29)
                        {
                            int setCount = Convert.ToInt32(LabelSetCountFirstPlayer.Content);
                            LabelSetCountFirstPlayer.Content = (++setCount).ToString();
                            LabelCountFirstPlayer.Content = (++actualCount).ToString();
                            Write.StateOfGame(actualTimeOfGame, Convert.ToInt32(LabelCountFirstPlayer.Content), Convert.ToInt32(LabelSetCountFirstPlayer.Content),
                                Convert.ToInt32(LabelCountSecondPlayer.Content), Convert.ToInt32(LabelSetCountSecondPlayer.Content));
                        }
                        else
                        {
                            LabelCountFirstPlayer.Content = (++actualCount).ToString();
                            Write.StateOfGame(actualTimeOfGame, Convert.ToInt32(LabelCountFirstPlayer.Content), Convert.ToInt32(LabelSetCountFirstPlayer.Content),
                                Convert.ToInt32(LabelCountSecondPlayer.Content), Convert.ToInt32(LabelSetCountSecondPlayer.Content));
                        }
                    }
                    break;
                case true:
                    int setCount2 = Convert.ToInt32(LabelSetCountFirstPlayer.Content);
                    if (setCount2 != 3)
                    {
                        LabelSetCountFirstPlayer.Content = (++setCount2).ToString();
                        Write.StateOfGame(actualTimeOfGame, Convert.ToInt32(LabelCountFirstPlayer.Content), Convert.ToInt32(LabelSetCountFirstPlayer.Content),
                            Convert.ToInt32(LabelCountSecondPlayer.Content), Convert.ToInt32(LabelSetCountSecondPlayer.Content));
                    }
                    break;
            }
        }

        private void buttMinusFirstPlayer_Click(object sender, RoutedEventArgs e)
        {
            int actualCount = Convert.ToInt32(LabelCountFirstPlayer.Content);
            switch (IsSPressed)
            {
                case false:
                    if (actualCount != 0)
                    {
                        LabelCountFirstPlayer.Content = (--actualCount).ToString();
                        Write.StateOfGame(actualTimeOfGame, Convert.ToInt32(LabelCountFirstPlayer.Content), Convert.ToInt32(LabelSetCountFirstPlayer.Content),
                            Convert.ToInt32(LabelCountSecondPlayer.Content), Convert.ToInt32(LabelSetCountSecondPlayer.Content));
                    }
                    break;
                case true:
                    int setCount = Convert.ToInt32(LabelSetCountFirstPlayer.Content);
                    if (setCount != 0)
                    {
                        LabelSetCountFirstPlayer.Content = (--setCount).ToString();
                        Write.StateOfGame(actualTimeOfGame, Convert.ToInt32(LabelCountFirstPlayer.Content), Convert.ToInt32(LabelSetCountFirstPlayer.Content),
                            Convert.ToInt32(LabelCountSecondPlayer.Content), Convert.ToInt32(LabelSetCountSecondPlayer.Content));
                    }
                    break;
            }
        }

        private void buttPlusSecondPlayer_Click(object sender, RoutedEventArgs e)
        {
            int actualCount = Convert.ToInt32(LabelCountSecondPlayer.Content);
            switch (IsSPressed)
            {
                case false:
                    if (actualCount != 30)
                    {
                        if (actualCount == 29)
                        {
                            int setCount2 = Convert.ToInt32(LabelSetCountSecondPlayer.Content);
                            LabelCountSecondPlayer.Content = (++actualCount).ToString();
                            LabelSetCountSecondPlayer.Content = (++setCount2).ToString();
                            Write.StateOfGame(actualTimeOfGame, Convert.ToInt32(LabelCountFirstPlayer.Content), Convert.ToInt32(LabelSetCountFirstPlayer.Content),
                                Convert.ToInt32(LabelCountSecondPlayer.Content), Convert.ToInt32(LabelSetCountSecondPlayer.Content));
                        }
                        else
                        {
                            LabelCountSecondPlayer.Content = (++actualCount).ToString();
                            Write.StateOfGame(actualTimeOfGame, Convert.ToInt32(LabelCountFirstPlayer.Content), Convert.ToInt32(LabelSetCountFirstPlayer.Content),
                                Convert.ToInt32(LabelCountSecondPlayer.Content), Convert.ToInt32(LabelSetCountSecondPlayer.Content));
                        }
                    }
                    break;
                case true:
                    int setCount = Convert.ToInt32(LabelSetCountSecondPlayer.Content);
                    if (setCount != 3)
                    {
                        LabelSetCountSecondPlayer.Content = (++setCount).ToString();
                        Write.StateOfGame(actualTimeOfGame, Convert.ToInt32(LabelCountFirstPlayer.Content), Convert.ToInt32(LabelSetCountFirstPlayer.Content),
                                Convert.ToInt32(LabelCountSecondPlayer.Content), Convert.ToInt32(LabelSetCountSecondPlayer.Content));
                    }
                    break;
            }
        }

        private void buttMinusSecondPlayer_Click(object sender, RoutedEventArgs e)
        {
            int actualCount = Convert.ToInt32(LabelCountSecondPlayer.Content);
            switch (IsSPressed)
            {
                case false:
                    if (actualCount != 0)
                    {
                        LabelCountSecondPlayer.Content = (--actualCount).ToString();
                        Write.StateOfGame(actualTimeOfGame, Convert.ToInt32(LabelCountFirstPlayer.Content), Convert.ToInt32(LabelSetCountFirstPlayer.Content),
                                Convert.ToInt32(LabelCountSecondPlayer.Content), Convert.ToInt32(LabelSetCountSecondPlayer.Content));
                    }
                    break;
                case true:
                    int setCount = Convert.ToInt32(LabelSetCountSecondPlayer.Content);
                    if (setCount != 0)
                    {
                        LabelSetCountSecondPlayer.Content = (--setCount).ToString();
                        Write.StateOfGame(actualTimeOfGame, Convert.ToInt32(LabelCountFirstPlayer.Content), Convert.ToInt32(LabelSetCountFirstPlayer.Content),
                                Convert.ToInt32(LabelCountSecondPlayer.Content), Convert.ToInt32(LabelSetCountSecondPlayer.Content));
                    }
                    break;
            }
        }

        /// <summary>
        /// Menia sa strany. Metoda obrati stav.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonR_Click(object sender, RoutedEventArgs e)
        {
            int firstCount = Convert.ToInt32(LabelCountFirstPlayer.Content);
            int secondCount = Convert.ToInt32(LabelCountSecondPlayer.Content);
            int firstSetCount = Convert.ToInt32(LabelSetCountFirstPlayer.Content);
            int secondSetCount = Convert.ToInt32(LabelSetCountSecondPlayer.Content);
            string firstPlayer = LabelStateFirstPlayer.Text;
            string secondPlayer = LabelStateSecondPlayer.Text;



            LabelCountFirstPlayer.Content = secondCount.ToString();
            LabelCountSecondPlayer.Content = firstCount.ToString();
            LabelSetCountFirstPlayer.Content = secondSetCount.ToString();
            LabelSetCountSecondPlayer.Content = firstSetCount.ToString();
            LabelStateFirstPlayer.Text = secondPlayer;
            LabelStateSecondPlayer.Text = firstPlayer;

        }

        /// <summary>
        /// Priradi + a - k SETOM a naopak. TODO Checkbox
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonS_Click(object sender, RoutedEventArgs e)
        {
            if (IsSPressed)
            {
                IsSPressed = false;
                checkBox.IsChecked = false;
            }
            else
            {
                IsSPressed = true;
                checkBox.IsChecked = true;
            }
        }

        /// <summary>
        /// Vynuluje skore, sety a cas.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonStart_Click(object sender, RoutedEventArgs e)
        {
            //vynuluj vsetko
            LabelCountFirstPlayer.Content = "0";
            LabelCountSecondPlayer.Content = "0";
            LabelSetCountFirstPlayer.Content = "0";
            LabelSetCountSecondPlayer.Content = "0";
            //TODO zacne timer
            stopwatch.Restart();
            labelStatus.Content = "Začala sa nová hra!";
        }

        /// <summary>
        /// Vynuluje skore.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonVynulovat_Click(object sender, RoutedEventArgs e)
        {
            //todo zapisat do suboru
            LabelCountFirstPlayer.Content = "0";
            LabelCountSecondPlayer.Content = "0";
            labelStatus.Content = "Skóre bolo vynulované.";
        }


        private void PlusFirstPlayer_Executed(object sender, ExecutedRoutedEventArgs e)
        {
            buttPlusFirstPlayer_Click(sender, e);
        }
        private void MinusFirstPlayer_Executed(object sender, ExecutedRoutedEventArgs e)
        {
            buttMinusFirstPlayer_Click(sender, e);
        }
        private void PlusSecondPlayer_Executed(object sender, ExecutedRoutedEventArgs e)
        {
            buttPlusSecondPlayer_Click(sender, e);
        }
        private void MinusSecondPlayer_Executed(object sender, ExecutedRoutedEventArgs e)
        {
            buttMinusSecondPlayer_Click(sender, e);
        }

        private void PressedS_Executed(object sender, ExecutedRoutedEventArgs e)
        {
            buttonS_Click(sender, e);
        }
        private void PressedR_Executed(object sender, ExecutedRoutedEventArgs e)
        {
            buttonR_Click(sender, e);
        }

        private void About_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show(string.Format("Aplikácia na zaznamenávanie a sledovanie herného stavu Bedmintonu."
                +" Aplikáciu je možné ovládať pomocou klávesnice:\n"
                +" Šipky = ovládaju skóre/sety\n Ctrl+Z = začiatok novej hry\n Ctrl+V = vynuluje stav\n Ctrl+S = prehadzuje skóre/sety\n Ctrl+R = výmena strán"
                +"\n V prípade problémov kontaktuje prosím autora: {0}", 
                "sasa303@gmail.com"), "About", MessageBoxButton.OK, MessageBoxImage.Information);
        }

        private void Close_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }

        private void PressedZaciatok_Executed(object sender, ExecutedRoutedEventArgs e)
        {
            buttonStart_Click(sender, e);
        }

        private void PressedVynulovat_Executed(object sender, ExecutedRoutedEventArgs e)
        {
            buttonVynulovat_Click(sender, e);
        }
    }
}
