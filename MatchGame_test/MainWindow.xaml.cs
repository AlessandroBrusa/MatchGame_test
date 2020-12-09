using System;
using System.Collections.Generic;
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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace MatchGame_test
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    using System.Windows.Threading;

    public partial class MainWindow : Window
    {
        DispatcherTimer timer = new DispatcherTimer();
        int elapsed;
        int matches;

        public MainWindow()
        {
            InitializeComponent();

            timer.Interval = TimeSpan.FromSeconds(0.1);
            timer.Tick += Timer_Tick;

            SetUpGame();

        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            /*throw new NotImplementedException();*/
            elapsed++;
            timeTextBlock.Text = (matches).ToString("Matches 0") + (elapsed/10F).ToString("-Elapsed 0.0s");
            if (matches == 8)
            {
                timer.Stop();
                timeTextBlock.Text = timeTextBlock.Text + " Press to Restart";
            }
        }

        private void SetUpGame()
        {
            List<string> animalEmoji = new List<string>()
            {
                "🐱", "🐱",
                "🦇", "🦇",
                "🐌", "🐌",
                "🦍", "🦍",
                "🐕", "🐕",
                "🐍", "🐍",
                "🦈", "🦈",
                "🐞", "🐞",
            };

            Random rand = new Random();

            foreach (TextBlock textBlock in mainGrid.Children.OfType<TextBlock>())
            {
                if (textBlock.Name != "timeTextBlock")
                {
                    textBlock.Visibility = Visibility.Visible;
                    int ind = rand.Next(animalEmoji.Count);
                    string nextEmoji = animalEmoji[ind];
                    textBlock.Text = nextEmoji;
                    animalEmoji.RemoveAt(ind);
                }
            }
            timer.Start();
            elapsed = 0;
            matches = 0;
        }

        bool findingMatch = false;
        private TextBlock lastTextBlockClicked;

        private void textBlock_MouseDown(object sender, MouseButtonEventArgs e)
        {
            TextBlock textBlock = sender as TextBlock;
            if (findingMatch == false)
            {
                textBlock.Visibility = Visibility.Hidden;
                lastTextBlockClicked = textBlock;
                findingMatch = true;
            }
            else if (textBlock.Text == lastTextBlockClicked.Text)
            {
                matches++;
                textBlock.Visibility = Visibility.Hidden;
                findingMatch = false; 
            }
            else
            {
                lastTextBlockClicked.Visibility = Visibility.Visible;
                findingMatch = false;
            }

        }

        private void textBlock1_MouseDown(object sender, MouseButtonEventArgs e)
        {
            TextBlock textBlock1 = sender as TextBlock;
            if (findingMatch == false)
            {
                textBlock1.Visibility = Visibility.Hidden;
                lastTextBlockClicked = textBlock1;
                findingMatch = true;
            }
            else if (textBlock1.Text == lastTextBlockClicked.Text)
            {
                matches++;
                textBlock1.Visibility = Visibility.Hidden;
                findingMatch = false;
            }
            else
            {
                lastTextBlockClicked.Visibility = Visibility.Visible;
                findingMatch = false;
            }
        }

        private void textBlock2_MouseDown(object sender, MouseButtonEventArgs e)
        {
            TextBlock textBlock2 = sender as TextBlock;
            if (findingMatch == false)
            {
                textBlock2.Visibility = Visibility.Hidden;
                lastTextBlockClicked = textBlock2;
                findingMatch = true;
            }
            else if (textBlock2.Text == lastTextBlockClicked.Text)
            {
                matches++;
                textBlock2.Visibility = Visibility.Hidden;
                findingMatch = false;
            }
            else
            {
                lastTextBlockClicked.Visibility = Visibility.Visible;
                findingMatch = false;
            }
        }

        private void textBlock3_MouseDown(object sender, MouseButtonEventArgs e)
        {
            TextBlock textBlock3 = sender as TextBlock;
            if (findingMatch == false)
            {
                textBlock3.Visibility = Visibility.Hidden;
                lastTextBlockClicked = textBlock3;
                findingMatch = true;
            }
            else if (textBlock3.Text == lastTextBlockClicked.Text)
            {
                matches++;
                textBlock3.Visibility = Visibility.Hidden;
                findingMatch = false;
            }
            else
            {
                lastTextBlockClicked.Visibility = Visibility.Visible;
                findingMatch = false;
            }
        }

        private void textBlock4_MouseDown(object sender, MouseButtonEventArgs e)
        {
            TextBlock textBlock4 = sender as TextBlock;
            if (findingMatch == false)
            {
                textBlock4.Visibility = Visibility.Hidden;
                lastTextBlockClicked = textBlock4;
                findingMatch = true;
            }
            else if (textBlock4.Text == lastTextBlockClicked.Text)
            {
                matches++;
                textBlock4.Visibility = Visibility.Hidden;
                findingMatch = false;
            }
            else
            {
                lastTextBlockClicked.Visibility = Visibility.Visible;
                findingMatch = false;
            }
        }

        private void textBlock6_MouseDown(object sender, MouseButtonEventArgs e)
        {
            TextBlock textBlock6 = sender as TextBlock;
            if (findingMatch == false)
            {
                textBlock6.Visibility = Visibility.Hidden;
                lastTextBlockClicked = textBlock6;
                findingMatch = true;
            }
            else if (textBlock6.Text == lastTextBlockClicked.Text)
            {
                matches++;
                textBlock6.Visibility = Visibility.Hidden;
                findingMatch = false;
            }
            else
            {
                lastTextBlockClicked.Visibility = Visibility.Visible;
                findingMatch = false;
            }
        }

        private void textBlock7_MouseDown(object sender, MouseButtonEventArgs e)
        {
            TextBlock textBlock7 = sender as TextBlock;
            if (findingMatch == false)
            {
                textBlock7.Visibility = Visibility.Hidden;
                lastTextBlockClicked = textBlock7;
                findingMatch = true;
            }
            else if (textBlock7.Text == lastTextBlockClicked.Text)
            {
                matches++;
                textBlock7.Visibility = Visibility.Hidden;
                findingMatch = false;
            }
            else
            {
                lastTextBlockClicked.Visibility = Visibility.Visible;
                findingMatch = false;
            }
        }

        private void textBlock8_MouseDown(object sender, MouseButtonEventArgs e)
        {
            TextBlock textBlock8 = sender as TextBlock;
            if (findingMatch == false)
            {
                textBlock8.Visibility = Visibility.Hidden;
                lastTextBlockClicked = textBlock8;
                findingMatch = true;
            }
            else if (textBlock8.Text == lastTextBlockClicked.Text)
            {
                matches++;
                textBlock8.Visibility = Visibility.Hidden;
                findingMatch = false;
            }
            else
            {
                lastTextBlockClicked.Visibility = Visibility.Visible;
                findingMatch = false;
            }
        }

        private void textBlock10_MouseDown(object sender, MouseButtonEventArgs e)
        {
            TextBlock textBlock10 = sender as TextBlock;
            if (findingMatch == false)
            {
                textBlock10.Visibility = Visibility.Hidden;
                lastTextBlockClicked = textBlock10;
                findingMatch = true;
            }
            else if (textBlock10.Text == lastTextBlockClicked.Text)
            {
                matches++;
                textBlock10.Visibility = Visibility.Hidden;
                findingMatch = false;
            }
            else
            {
                lastTextBlockClicked.Visibility = Visibility.Visible;
                findingMatch = false;
            }
        }

        private void textBlock11_MouseDown(object sender, MouseButtonEventArgs e)
        {
            TextBlock textBlock11 = sender as TextBlock;
            if (findingMatch == false)
            {
                textBlock11.Visibility = Visibility.Hidden;
                lastTextBlockClicked = textBlock11;
                findingMatch = true;
            }
            else if (textBlock11.Text == lastTextBlockClicked.Text)
            {
                matches++;
                textBlock11.Visibility = Visibility.Hidden;
                findingMatch = false;
            }
            else
            {
                lastTextBlockClicked.Visibility = Visibility.Visible;
                findingMatch = false;
            }
        }

        private void textBlock12_MouseDown(object sender, MouseButtonEventArgs e)
        {
            TextBlock textBlock12 = sender as TextBlock;
            if (findingMatch == false)
            {
                textBlock12.Visibility = Visibility.Hidden;
                lastTextBlockClicked = textBlock12;
                findingMatch = true;
            }
            else if (textBlock12.Text == lastTextBlockClicked.Text)
            {
                matches++;
                textBlock12.Visibility = Visibility.Hidden;
                findingMatch = false;
            }
            else
            {
                lastTextBlockClicked.Visibility = Visibility.Visible;
                findingMatch = false;
            }
        }

        private void textBlock13_MouseDown(object sender, MouseButtonEventArgs e)
        {
            TextBlock textBlock13 = sender as TextBlock;
            if (findingMatch == false)
            {
                textBlock13.Visibility = Visibility.Hidden;
                lastTextBlockClicked = textBlock13;
                findingMatch = true;
            }
            else if (textBlock13.Text == lastTextBlockClicked.Text)
            {
                matches++;
                textBlock13.Visibility = Visibility.Hidden;
                findingMatch = false;
            }
            else
            {
                lastTextBlockClicked.Visibility = Visibility.Visible;
                findingMatch = false;
            }
        }

        private void textBlock15_MouseDown(object sender, MouseButtonEventArgs e)
        {
            TextBlock textBlock15 = sender as TextBlock;
            if (findingMatch == false)
            {
                textBlock15.Visibility = Visibility.Hidden;
                lastTextBlockClicked = textBlock15;
                findingMatch = true;
            }
            else if (textBlock15.Text == lastTextBlockClicked.Text)
            {
                matches++;
                textBlock15.Visibility = Visibility.Hidden;
                findingMatch = false;
            }
            else
            {
                lastTextBlockClicked.Visibility = Visibility.Visible;
                findingMatch = false;
            }
        }

        private void textBlock16_MouseDown(object sender, MouseButtonEventArgs e)
        {
            TextBlock textBlock16 = sender as TextBlock;
            if (findingMatch == false)
            {
                textBlock16.Visibility = Visibility.Hidden;
                lastTextBlockClicked = textBlock16;
                findingMatch = true;
            }
            else if (textBlock16.Text == lastTextBlockClicked.Text)
            {
                matches++;
                textBlock16.Visibility = Visibility.Hidden;
                findingMatch = false;
            }
            else
            {
                lastTextBlockClicked.Visibility = Visibility.Visible;
                findingMatch = false;
            }
        }

        private void textBlock17_MouseDown(object sender, MouseButtonEventArgs e)
        {
            TextBlock textBlock17 = sender as TextBlock;
            if (findingMatch == false)
            {
                textBlock17.Visibility = Visibility.Hidden;
                lastTextBlockClicked = textBlock17;
                findingMatch = true;
            }
            else if (textBlock17.Text == lastTextBlockClicked.Text)
            {
                matches++;
                textBlock17.Visibility = Visibility.Hidden;
                findingMatch = false;
            }
            else
            {
                lastTextBlockClicked.Visibility = Visibility.Visible;
                findingMatch = false;
            }
        }

        private void textBlock18_MouseDown(object sender, MouseButtonEventArgs e)
        {
            TextBlock textBlock18 = sender as TextBlock;
            if (findingMatch == false)
            {
                textBlock18.Visibility = Visibility.Hidden;
                lastTextBlockClicked = textBlock18;
                findingMatch = true;
            }
            else if (textBlock18.Text == lastTextBlockClicked.Text)
            {
                matches++;
                textBlock18.Visibility = Visibility.Hidden;
                findingMatch = false;
            }
            else
            {
                lastTextBlockClicked.Visibility = Visibility.Visible;
                findingMatch = false;
            }
        }

        private void timeTextBlock_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (matches == 8)
            {
                SetUpGame();
            }
        }
    }
}
