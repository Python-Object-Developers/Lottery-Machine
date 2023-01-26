using System;
using System.Windows.Forms;
using System.Speech.Synthesis;
using System.Threading;

namespace Lottery_Machine
{
    public partial class MainForm : Form
    {
        public MainForm() { InitializeComponent(); }

        /// <summary>
        /// This is a function that can generate random numbers.
        /// </summary>
        /// <param name="min">The minimum value of random numbers.</param>
        /// <param name="max">The maximum value of random numbers.</param>
        /// <param name="n">The value that you don't want to see.</param>
        /// <param name="r">Expected random object.</param>
        /// <returns>The result.</returns>
        public int Generate(int min, int max, string[] n, Random r)
        {
            int i = 0;
            int re = r.Next(min, max + 1);
            while (Array.IndexOf(n, re.ToString()) >= 0 && i <= 10000000)
            {
                re = r.Next(min, max + 1);
                i++;
            }
            if (i>=10000000) { return -2147483648; }
            else { return re; }
        }

        private void button2_Click(object sender, EventArgs e) { Close(); }

        private void button1_Click(object sender, EventArgs e)
        {
            Random rd = new Random();
            string[] nl = dwst.Text.ToString().Split(' ');
            if (int.TryParse(mint.Text.ToString(), out int mini)==true && int.TryParse(maxt.Text.ToString(), out int maxi)==true)
            {
                mini = int.Parse(mint.Text.ToString());
                maxi = int.Parse(maxt.Text.ToString());
                if (mini<=maxi)
                {                    
                    if (int.TryParse(quat.Text.ToString(), out int quai) == false) { quai = 1; }
                    else { quai = int.Parse(quat.Text.ToString()); }
                    int r = Generate(mini, maxi, nl, rd);
                    if (mini == -2147483648 || maxi == -2147483648) { MessageBox.Show("The value of 'Don't want to see' you entered is not in the valid range.\nValid range: -2147483647~2147483648.", "Range", 0, MessageBoxIcon.Warning); }
                    else
                    {
                        if (r == -2147483648) { MessageBox.Show("This is not a joke.", "Joke", 0, MessageBoxIcon.Warning); }
                        else
                        {
                            if (quai < 1 || quai > 999) { MessageBox.Show("The value of 'Quality' you entered is not in the valid range.\nValid range: 1~999.", "Range", 0, MessageBoxIcon.Warning); }
                            else if (quai != 1)
                            {
                                int[] rl = new int[quai];
                                for (int i = 0; i < quai; i++)
                                {
                                    r = Generate(mini, maxi, nl, rd);
                                    rl[i] = r;
                                }
                                MessageBox.Show($"Numbers: {String.Join(", ", rl)}.", "Generate", 0, MessageBoxIcon.Information);
                            } 
                            else { MessageBox.Show($"Number {r}.", "Generate", 0, MessageBoxIcon.Information); }
                        }
                    }
                }
                else { MessageBox.Show("Why did 'Minimum' < 'Maximum'?", "Check", 0, MessageBoxIcon.Warning); }
            }
            else { MessageBox.Show("Please enter correct numbers.", "Check", 0, MessageBoxIcon.Warning); }
        }

        public void speak()
        {
            SpeechSynthesizer speech = new SpeechSynthesizer();
            Random rd = new Random();
            string[] nl = dwst.Text.ToString().Split(' ');
            if (int.TryParse(mint.Text.ToString(), out int mini) == true && int.TryParse(maxt.Text.ToString(), out int maxi) == true)
            {
                mini = int.Parse(mint.Text.ToString());
                maxi = int.Parse(maxt.Text.ToString());
                if (mini <= maxi)
                {
                    if (int.TryParse(quat.Text.ToString(), out int quai) == false) { quai = 1; }
                    else { quai = int.Parse(quat.Text.ToString()); }
                    int r = Generate(mini, maxi, nl, rd);
                    if (mini == -2147483648 || maxi == -2147483648) { speech.Speak("The value of 'Don't want to see' you entered is not in the valid range. Valid range: from minus two billion one hundred and forty-seven million four hundred and eighty-three thousand six hundred and forty-seven to two billion one hundred and forty-seven million four hundred and eighty-three thousand six hundred and forty-eight."); }
                    else
                    {
                        if (r == -2147483648) { speech.Speak("These are not jokes."); }
                        else
                        {
                            if (quai < 1 || quai > 999) { speech.Speak("The value of 'Quality' you entered is not in the valid range. Valid range: from one to nine hundred and ninety-nine."); }
                            else if (quai != 1)
                            {
                                int[] rl = new int[quai];
                                for (int i = 0; i < quai; i++)
                                {
                                    r = Generate(mini, maxi, nl, rd);
                                    rl[i] = r;
                                }
                                speech.Speak(String.Join(", ", rl));
                            }
                            else { speech.Speak(r.ToString()); }
                        }
                    }
                }
                else { speech.Speak("Why did 'Minimum' smaller than 'Maximum'?"); }
            }
            else { speech.Speak("Please enter correct numbers."); }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Thread thread = new Thread(speak);
            thread.Start();
        }
    }
}
