using System;
using System.Windows.Forms;
using System.Speech.Synthesis;

namespace Lottery_Machine
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        /// <summary>
        /// This is a function that can generate random numbers.
        /// </summary>
        /// <param name="min">The minimum value of random numbers.</param>
        /// <param name="max">The maximum value of random numbers.</param>
        /// <param name="n">The value that you don't want to see.</param>
        /// <param name="r">Expected random object.</param>
        /// <returns>The result.</returns>
        public int generate(int min, int max, string[] n, Random r)
        {
            int i = 0;
            int re = r.Next(min, max + 1);
            int num = Array.IndexOf(n, re.ToString());
            while ((num >= 0) && i<=10000000)
            {
                re = r.Next(min, max + 1);
                num = Array.IndexOf(n, re.ToString());
                i++;
            }
            if (i>=10000000)
            {
                return -2147483648;
            }
            else
            {
                return re;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Random rd = new Random();
            string mins = mint.Text.ToString();
            string maxs = maxt.Text.ToString();
            string dwss = dwst.Text.ToString();
            string quas = quat.Text.ToString();
            string[] nl = dwss.Split(' ');
            int mini, maxi, quai;
            bool minb = int.TryParse(mins, out mini);
            bool maxb = int.TryParse(maxs, out maxi);
            bool quab = int.TryParse(quas, out quai);
            if (minb==true && maxb==true)
            {
                mini = int.Parse(mins);
                maxi = int.Parse(maxs);
                if (mini<=maxi)
                {                    
                    if (quab == false)
                    {
                        quai = 1;
                    }
                    else
                    {
                        quai = int.Parse(quas);
                    }
                    int r = generate(mini, maxi, nl, rd);
                    if (mini == -2147483648 || maxi == -2147483648)
                    {
                        MessageBox.Show("The value of 'Don't want to see' you entered is not in the valid range.\nValid range: -2147483647~2147483648.", "Range", 0, MessageBoxIcon.Warning);
                    }
                    else
                    {
                        if (r == -2147483648)
                        {
                            MessageBox.Show("This is not a joke.", "Joke", 0, MessageBoxIcon.Warning);
                        }
                        else
                        {
                            if (quai < 1 || quai > 999)
                            {
                                MessageBox.Show("The value of 'Quality' you entered is not in the valid range.\nValid range: 1~999.", "Range", 0, MessageBoxIcon.Warning);
                            }
                            else if (quai != 1)
                            {
                                int[] rl = new int[quai];
                                for (int i = 0; i < quai; i++)
                                {
                                    r = generate(mini, maxi, nl, rd);
                                    rl[i] = r;
                                }
                                string result = String.Join(", ", rl);
                                MessageBox.Show($"Numbers: {result}.", "Generate", 0, MessageBoxIcon.Information);
                            } 
                            else
                            {
                                MessageBox.Show($"Number {r}.", "Generate", 0, MessageBoxIcon.Information);
                            }
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Why did 'Minimum' < 'Maximum'?", "Check", 0, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("Please enter correct numbers.", "Check", 0, MessageBoxIcon.Warning);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            SpeechSynthesizer speech = new SpeechSynthesizer();
            Random rd = new Random();
            string mins = mint.Text.ToString();
            string maxs = maxt.Text.ToString();
            string dwss = dwst.Text.ToString();
            string quas = quat.Text.ToString();
            string[] nl = dwss.Split(' ');
            int mini, maxi, quai;
            bool minb = int.TryParse(mins, out mini);
            bool maxb = int.TryParse(maxs, out maxi);
            bool quab = int.TryParse(quas, out quai);
            if (minb == true && maxb == true)
            {
                mini = int.Parse(mins);
                maxi = int.Parse(maxs);
                if (mini <= maxi)
                {
                    if (quab == false)
                    {
                        quai = 1;
                    }
                    else
                    {
                        quai = int.Parse(quas);
                    }
                    int r = generate(mini, maxi, nl, rd);
                    if (mini == -2147483648 || maxi == -2147483648)
                    {
                        speech.Speak("The value of 'Don't want to see' you entered is not in the valid range. Valid range: from minus two billion one hundred and forty-seven million four hundred and eighty-three thousand six hundred and forty-seven to two billion one hundred and forty-seven million four hundred and eighty-three thousand six hundred and forty-eight.");
                    }
                    else
                    {
                        if (r == -2147483648)
                        {
                            speech.Speak("These are not jokes.");
                        }
                        else
                        {
                            if (quai < 1 || quai > 999)
                            {
                                speech.Speak("The value of 'Quality' you entered is not in the valid range. Valid range: from one to nine hundred and ninety-nine.");
                            }
                            else if (quai != 1)
                            {
                                int[] rl = new int[quai];
                                for (int i = 0; i < quai; i++)
                                {
                                    r = generate(mini, maxi, nl, rd);
                                    rl[i] = r;
                                }
                                string result = String.Join(", ", rl);
                                speech.Speak(result);
                            }
                            else
                            {
                                speech.Speak(r.ToString());
                            }
                        }
                    }
                }
                else
                {
                    speech.Speak("Why did 'Minimum' smaller than 'Maximum'?");
                }
            }
            else
            {
                speech.Speak("Please enter correct numbers.");
            }
        }
    }
}
