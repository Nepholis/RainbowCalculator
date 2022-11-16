using System;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Media;
using org.mariuszgromada.math.mxparser;
using Expression = org.mariuszgromada.math.mxparser.Expression;

namespace RainbowCalculator
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
        //_______________________________________________________________________________________________________________________
        //_______________________________________________Main-Functions__________________________________________________________
        //_______________________________________________________________________________________________________________________

        private void main()
        {
            InputBox.IsEnabled = false;

            //? mxparser uses doubles, no decimals
            // roundingsettings for the calculation, no decimal available >> e.g. sin(90) fails/isn't 1
            mXparser.disableAlmostIntRounding();
            mXparser.enableUlpRounding();
            mXparser.disableCanonicalRounding();

            // calculate the given expression
            Expression e = new Expression(InputBox.Text);
            String ergebnis = e.calculate().ToString(new CultureInfo("en-us", false));

            // check if expression was valid
            if (ergebnis != "NaN")
            {
                AddButtonToHistory(InputBox.Text + " = " + ergebnis);
                ans = ergebnis;
                InputBox.Clear();
            }
            else
            {
                ShowErrorMessage("  '" + InputBox.Text + "' is not a valid Expression");
            }
            InputBox.IsEnabled = true;
        }
        private async void ShowErrorMessage(string message)
        {
            ErrorLog.Text = message;
            int seconds = 6;
            await Task.Delay(seconds*1000);
            ErrorLog.Text = "";
        }
        private void AddButtonToHistory (string text)
        {
            Button b = new Button();
            b.Content = text;
            b.FontSize = 14;
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
            InputBox_Focus(sender, e);
            histCounter = histButtonNr;
        }

        //_______________________________________________________________________________________________________________________
        //_______________________________________________InputBox-Functions________________________________________________________
        //_______________________________________________________________________________________________________________________
        private void InputBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Enter)
            {
                main();
            }
        }
        private void InputBox_Focus(object sender, RoutedEventArgs e)
        {
            InputBox.Focus();
            InputBox.SelectionStart = InputBox.Text.Length;
        }

        private void InputBox_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            //sets which chars are allowed
            if (!char.IsLetterOrDigit(e.Text.Last())
                && !(e.Text.Last() == '.')
                && !(e.Text.Last() == '+')
                && !(e.Text.Last() == '-')
                && !(e.Text.Last() == '*')
                && !(e.Text.Last() == '/')
                && !(e.Text.Last() == '(')
                && !(e.Text.Last() == ')')
                && !(e.Text.Last() == '√')
                && !(e.Text.Last() == '^')
                && !(e.Text.Last() == '!')
                && !(e.Text.Last() == '\r'))
            { e.Handled = true; }
        }
        //_______________________________________________________________________________________________________________________
        //_______________________________________________Button-Functions________________________________________________________
        //_______________________________________________________________________________________________________________________

        private void Button_Solve_PreviewMouseDown(object sender, MouseButtonEventArgs e)
        {
            if (e.LeftButton == MouseButtonState.Pressed)
            {
                main();
            }
        }
        private void Button_0_PreviewMouseDown(object sender, MouseButtonEventArgs e)
        {
            if (e.LeftButton == MouseButtonState.Pressed)
            {
                InputBox.Text = InputBox.Text.Insert(InputBox.SelectionStart, "");
            }
        }
        private void Button_1_PreviewMouseDown(object sender, MouseButtonEventArgs e)
        {
            if (e.LeftButton == MouseButtonState.Pressed)
            {
                InputBox.Text = InputBox.Text.Insert(InputBox.SelectionStart, "1");
            }
        }
        private void Button_2_PreviewMouseDown(object sender, MouseButtonEventArgs e)
        {
            if (e.LeftButton == MouseButtonState.Pressed)
            {
                InputBox.Text = InputBox.Text.Insert(InputBox.SelectionStart, "2");
            }
        }
        private void Button_3_PreviewMouseDown(object sender, MouseButtonEventArgs e)
        {
            if (e.LeftButton == MouseButtonState.Pressed)
            {
                InputBox.Text = InputBox.Text.Insert(InputBox.SelectionStart, "3");
            }
        }
        private void Button_4_PreviewMouseDown(object sender, MouseButtonEventArgs e)
        {
            if (e.LeftButton == MouseButtonState.Pressed)
            {
                InputBox.Text = InputBox.Text.Insert(InputBox.SelectionStart, "4");
            }
        }
        private void Button_5_PreviewMouseDown(object sender, MouseButtonEventArgs e)
        {
            if (e.LeftButton == MouseButtonState.Pressed)
            {
                InputBox.Text = InputBox.Text.Insert(InputBox.SelectionStart, "5");
            }
        }
        private void Button_6_PreviewMouseDown(object sender, MouseButtonEventArgs e)
        {
            if (e.LeftButton == MouseButtonState.Pressed)
            {
                InputBox.Text = InputBox.Text.Insert(InputBox.SelectionStart, "6");
            }
        }
        private void Button_7_PreviewMouseDown(object sender, MouseButtonEventArgs e)
        {
            if (e.LeftButton == MouseButtonState.Pressed)
            {
                InputBox.Text = InputBox.Text.Insert(InputBox.SelectionStart, "7");
            }
        }
        private void Button_8_PreviewMouseDown(object sender, MouseButtonEventArgs e)
        {
            if (e.LeftButton == MouseButtonState.Pressed)
            {
                InputBox.Text = InputBox.Text.Insert(InputBox.SelectionStart, "8");
            }
        }
        private void Button_9_PreviewMouseDown(object sender, MouseButtonEventArgs e)
        {
            if (e.LeftButton == MouseButtonState.Pressed)
            {
                InputBox.Text = InputBox.Text.Insert(InputBox.SelectionStart, "9");
            }
        }
        private void Button_Point_PreviewMouseDown(object sender, MouseButtonEventArgs e)
        {
            if (e.LeftButton == MouseButtonState.Pressed)
            {
                InputBox.Text = InputBox.Text.Insert(InputBox.SelectionStart, ".");
            }
        }
        private void Button_Plus_PreviewMouseDown(object sender, MouseButtonEventArgs e)
        {
            if (e.LeftButton == MouseButtonState.Pressed)
            {
                InputBox.Text = InputBox.Text.Insert(InputBox.SelectionStart, "+");
            }
        }
        private void Button_Minus_PreviewMouseDown(object sender, MouseButtonEventArgs e)
        {
            if (e.LeftButton == MouseButtonState.Pressed)
            {
                InputBox.Text = InputBox.Text.Insert(InputBox.SelectionStart, "-");
            }
        }
        private void Button_Mul_PreviewMouseDown(object sender, MouseButtonEventArgs e)
        {
            if (e.LeftButton == MouseButtonState.Pressed)
            {
                InputBox.Text = InputBox.Text.Insert(InputBox.SelectionStart, "*");
            }
        }
        private void Button_Div_PreviewMouseDown(object sender, MouseButtonEventArgs e)
        {
            if (e.LeftButton == MouseButtonState.Pressed)
            {
                InputBox.Text = InputBox.Text.Insert(InputBox.SelectionStart, "/");
            }
        }
        private void Button_Root_PreviewMouseDown(object sender, MouseButtonEventArgs e)
        {
            if (e.LeftButton == MouseButtonState.Pressed)
            {
                InputBox.Text = InputBox.Text.Insert(InputBox.SelectionStart, "√(");
            }
        }
        private void Button_Pow_PreviewMouseDown(object sender, MouseButtonEventArgs e)
        {
            if (e.LeftButton == MouseButtonState.Pressed)
            {
                InputBox.Text = InputBox.Text.Insert(InputBox.SelectionStart, "^(");
            }
        }
        private void Button_Bracket_Left_PreviewMouseDown(object sender, MouseButtonEventArgs e)
        {
            if (e.LeftButton == MouseButtonState.Pressed)
            {
                InputBox.Text = InputBox.Text.Insert(InputBox.SelectionStart, "(");
            }
        }
        private void Button_Bracket_Right_PreviewMouseDown(object sender, MouseButtonEventArgs e)
        {
            if (e.LeftButton == MouseButtonState.Pressed)
            {
                InputBox.Text = InputBox.Text.Insert(InputBox.SelectionStart, ")");
            }
        }
        private void Button_Ln_PreviewMouseDown(object sender, MouseButtonEventArgs e)
        {
            if (e.LeftButton == MouseButtonState.Pressed)
            {
                InputBox.Text = InputBox.Text.Insert(InputBox.SelectionStart, "ln(");
            }
        }
        private void Button_Log_PreviewMouseDown(object sender, MouseButtonEventArgs e)
        {
            if (e.LeftButton == MouseButtonState.Pressed)
            {
                InputBox.Text = InputBox.Text.Insert(InputBox.SelectionStart, "log(");
            }
        }
        private void Button_DeleteLast_PreviewMouseDown(object sender, MouseButtonEventArgs e)
        {
            //Deletes the marked Text in the Inputbox, if nothing is marked then the char before the selection will be deleted
            if (e.LeftButton == MouseButtonState.Pressed)
            {
                if (InputBox.Text.Length > 0)
                {
                    int startIndex = InputBox.SelectionStart;
                    int count = InputBox.SelectionLength;
                    int lenght = InputBox.Text.Length;

                    if (startIndex > 0 && count == 0)
                    { 
                        count = 1;
                        startIndex--;
                    }
                    if (startIndex == lenght)
                    {
                        startIndex--;
                    }

                    InputBox.Text = InputBox.Text.Remove(startIndex, count);
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
                InputBox.Text = InputBox.Text.Insert(InputBox.SelectionStart, ans);
            }
        }
        private void Button_Clear_PreviewMouseDown(object sender, MouseButtonEventArgs e)
        {
            if (e.LeftButton == MouseButtonState.Pressed && HistoryBox.Items.Count > 0)
            {
                MessageBoxResult result = System.Windows.MessageBox.Show("Do you want to delete the History?",
                                                                     "History deletion?",
                                                                     System.Windows.MessageBoxButton.YesNo);
                switch (result)
                {
                    case MessageBoxResult.Yes:
                        InputBox.Text = "";
                        HistoryBox.Items.Clear();
                        histCounter = 0;
                        break;
                    case MessageBoxResult.No:
                        break;
                    default:
                        break;
                }
            }
        }
    }
}
