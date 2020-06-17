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

namespace RechnerV1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public int histCounter = 0;
        public string ans;
        public MainWindow()
        {
            InitializeComponent();
        }
        private void main()
        {
            InputBox.IsEnabled = false;
            SeparatedList SepL = new SeparatedList(InputBox.Text);
            List<string> sl = SepL.getStrings();
            string ergebnis = "";

            if (SepL.detectWrongInput() == false)
            {
                if (sl.Count == 1)
                {
                    ergebnis = InputBox.Text;
                }
                while (sl.Count > 1)
                {
                    int t = SepL.showNextClac(sl);
                    sl = SepL.getStrings();

                    decimal a = decimal.Parse(sl[t - 1]);
                    decimal b = decimal.Parse(sl[t + 1]);
                    string o = sl[t];
                    if (o == "/" && b == 0)
                    {
                        MessageBox.Show("an Denominator is 0");
                        break;
                    }
                    Calculate c = new Calculate(a, b, o);

                    ergebnis = c.getResult().ToString();
                    sl[t - 1] = ergebnis;

                    sl.RemoveAt(t + 1);
                    sl.RemoveAt(t);
                }
                if (sl.Count != 0)
                {
                    AddButtonToHistory(InputBox.Text + " = " + ergebnis);
                }
            }

            ans = ergebnis;
            InputBox.Clear();
            InputBox.IsEnabled = true;
        }

        private void InputBox_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            //sets which chars are allowed
            if(!char.IsDigit(e.Text.Last()) 
                && !(e.Text.Last() == ',')
                && !(e.Text.Last() == '+')
                && !(e.Text.Last() == '-')
                && !(e.Text.Last() == '*')
                && !(e.Text.Last() == '/')
                && !(e.Text.Last() == '(')
                && !(e.Text.Last() == ')')
                //&& !(e.Text.Last() == '|')
                //&& !(e.Text.Last() == '^')
                && !(e.Text.Last() == '\r'))
            {e.Handled = true;}
        }

        private void InputBox_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.Key == Key.Enter)
            {
                main();
            }
        }

        private void Button_Solve_PreviewMouseDown(object sender, MouseButtonEventArgs e)
        {
            if(e.LeftButton == MouseButtonState.Pressed)
            {
                main();
            }
        }
        private void AddButtonToHistory (string text)
        {
            Button b = new Button();
            b.Content = text;
            b.Width = 250;
            b.Height = 50;
            b.Tag = histCounter;
            b.Background = Brushes.Yellow;
            b.Click += new RoutedEventHandler(DelButtonsFromHistory);
            HistoryBox.Items.Add(b);
            histCounter++;
        }
        private void DelButtonsFromHistory(object sender, RoutedEventArgs e)
        {
            Button b = (Button)sender;
            //MessageBox.Show("Button pressed " + b.Tag.ToString());
            char[] c = { '\"', ' ' };
            string[] temp = b.Content.ToString().Split(c);
            string text = temp[0];
            int histButtonNr = (Int32)b.Tag;

            for (int i = histCounter; i > histButtonNr; i--)
            {
                HistoryBox.Items.RemoveAt(i-1);
            }
            InputBox.Text = text;
            histCounter = histButtonNr;
        }        
        private void Button_0_PreviewMouseDown(object sender, MouseButtonEventArgs e)
        {
            if (e.LeftButton == MouseButtonState.Pressed)
            {
                InputBox.Text = InputBox.Text + "0";
            }
        }
        private void Button_1_PreviewMouseDown(object sender, MouseButtonEventArgs e)
        {
            if (e.LeftButton == MouseButtonState.Pressed)
            {
                InputBox.Text = InputBox.Text + "1";
            }
        }

        private void Button_2_PreviewMouseDown(object sender, MouseButtonEventArgs e)
        {
            if (e.LeftButton == MouseButtonState.Pressed)
            {
                InputBox.Text = InputBox.Text + "2";
            }
        }

        private void Button_3_PreviewMouseDown(object sender, MouseButtonEventArgs e)
        {
            if (e.LeftButton == MouseButtonState.Pressed)
            {
                InputBox.Text = InputBox.Text + "3";
            }
        }

        private void Button_4_PreviewMouseDown(object sender, MouseButtonEventArgs e)
        {
            if (e.LeftButton == MouseButtonState.Pressed)
            {
                InputBox.Text = InputBox.Text + "4";
            }
        }

        private void Button_5_PreviewMouseDown(object sender, MouseButtonEventArgs e)
        {
            if (e.LeftButton == MouseButtonState.Pressed)
            {
                InputBox.Text = InputBox.Text + "5";
            }
        }

        private void Button_6_PreviewMouseDown(object sender, MouseButtonEventArgs e)
        {
            if (e.LeftButton == MouseButtonState.Pressed)
            {
                InputBox.Text = InputBox.Text + "6";
            }
        }

        private void Button_7_PreviewMouseDown(object sender, MouseButtonEventArgs e)
        {
            if (e.LeftButton == MouseButtonState.Pressed)
            {
                InputBox.Text = InputBox.Text + "7";
            }
        }

        private void Button_8_PreviewMouseDown(object sender, MouseButtonEventArgs e)
        {
            if (e.LeftButton == MouseButtonState.Pressed)
            {
                InputBox.Text = InputBox.Text + "8";
            }
        }

        private void Button_9_PreviewMouseDown(object sender, MouseButtonEventArgs e)
        {
            if (e.LeftButton == MouseButtonState.Pressed)
            {
                InputBox.Text = InputBox.Text + "9";
            }
        }

        private void Button_Komma_PreviewMouseDown(object sender, MouseButtonEventArgs e)
        {
            if (e.LeftButton == MouseButtonState.Pressed)
            {
                InputBox.Text = InputBox.Text + ",";
            }
        }

        private void Button_Plus_PreviewMouseDown(object sender, MouseButtonEventArgs e)
        {
            if (e.LeftButton == MouseButtonState.Pressed)
            {
                InputBox.Text = InputBox.Text + "+";
            }
        }

        private void Button_Minus_PreviewMouseDown(object sender, MouseButtonEventArgs e)
        {
            if (e.LeftButton == MouseButtonState.Pressed)
            {
                InputBox.Text = InputBox.Text + "-";
            }
        }

        private void Button_Mul_PreviewMouseDown(object sender, MouseButtonEventArgs e)
        {
            if (e.LeftButton == MouseButtonState.Pressed)
            {
                InputBox.Text = InputBox.Text + "*";
            }
        }

        private void Button_Div_PreviewMouseDown(object sender, MouseButtonEventArgs e)
        {
            if (e.LeftButton == MouseButtonState.Pressed)
            {
                InputBox.Text = InputBox.Text + "/";
            }
        }

        private void Button_DeleteLast_PreviewMouseDown(object sender, MouseButtonEventArgs e)
        {
            if (e.LeftButton == MouseButtonState.Pressed)
            {
                if (InputBox.Text.Length > 0)
                {
                    InputBox.Text = InputBox.Text.Substring(0, (InputBox.Text.Length - 1));
                }
            }
        }

        private void Button_Del_PreviewMouseDown(object sender, MouseButtonEventArgs e)
        {
            if (e.LeftButton == MouseButtonState.Pressed)
            {
                InputBox.Clear();
            }
            
        }

        private void Button_Ans_PreviewMouseDown(object sender, MouseButtonEventArgs e)
        {
            if (e.LeftButton == MouseButtonState.Pressed)
            {
                InputBox.Text = InputBox.Text + ans;
            }
        }

        private void Button_Clear_PreviewMouseDown(object sender, MouseButtonEventArgs e)
        {
            if (e.LeftButton == MouseButtonState.Pressed)
            {
                InputBox.Text = "";
                HistoryBox.Items.Clear();
                histCounter = 0;
            }
        }

        private void Button_Bracket_Left_PreviewMouseDown(object sender, MouseButtonEventArgs e)
        {
            if (e.LeftButton == MouseButtonState.Pressed)
            {
                InputBox.Text = InputBox.Text + "(";
            }
        }

        private void Button_Bracket_Right_PreviewMouseDown(object sender, MouseButtonEventArgs e)
        {
            if (e.LeftButton == MouseButtonState.Pressed)
            {
                InputBox.Text = InputBox.Text + ")";
            }
        }
        private bool checkbrackets(List<string> sl)
        {
            bool b = false;
            int t = 0;
            for (int i = 0; i< sl.Count; i++)
            {
                if (sl[i] == "(") { t++; }
                else if (sl[i] == ")") { t--; }

                if(t < 0) { MessageBox.Show("To much Rightbrackets: e.g. Index" + i); b = false;  break; }

            }
            if (t > 0) { MessageBox.Show("To much Leftbrackets!"); b = false; }
            else if (t == 0) { b = true; }
            return b;
        }
    }
}
