using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Rebar;
using ComboBox = System.Windows.Forms.ComboBox;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        #region Values

        public string letters = "qwertyuiopasdfghjklzxcvbnmQWERTYUIOPASDFGHJKLZXCVBNM";
        public string symbols = "~!@#$%^&*()_+-={}[]|:;<,>.?/№";

        public string[] Priority_Lvls = { "Наименьший", "Ниже Нормального", "Нормальный", "Выше Нормального", "Наибольший" };

        public Thread numberThread;
        public Thread letterThread;
        public Thread symbolThread;

        public ThreadStart ThreadStartNumber;
        public ThreadStart ThreadStartLetter;
        public ThreadStart ThreadStartSymbol;

        #endregion

        #region HelpFuncs

        public void GenerateRandomNumber()
        {
            for (int i = 0; i < 70; i++)
            {
                Random random = new Random();
                int randNum = random.Next(-100, 100);

                ThreadsListBox.Items.Add(randNum);

                Thread.Sleep(150);
            }
        }
        public void GenerateRandomLetter()
        {
            for (int i = 0; i < 70; i++)
            {
                Random random = new Random();
                int randIndex = random.Next(0, letters.Count());
                char letter = letters[randIndex];

                ThreadsListBox.Items.Add(letter);

                Thread.Sleep(150);
            }
        }
        public void GenerateRandomSymbol()
        {
            for (int i = 0; i < 70; i++)
            {
                Random random = new Random();
                int randIndex = random.Next(0, symbols.Count());
                char symbol = symbols[randIndex];

                ThreadsListBox.Items.Add(symbol);

                Thread.Sleep(150);
            }
        }

        public ThreadPriority GetThreadPriorityLvl(ComboBox comboBox)
        {
            if (comboBox.SelectedItem.ToString() == "Наименьший")
                return ThreadPriority.Lowest;
            else if (comboBox.SelectedItem.ToString() == "Ниже Нормального")
                return ThreadPriority.BelowNormal;
            else if (comboBox.SelectedItem.ToString() == "Выше Нормального")
                return ThreadPriority.AboveNormal;
            else if (comboBox.SelectedItem.ToString() == "Наибольший")
                return ThreadPriority.Highest;

            return ThreadPriority.Normal;
        }

        #endregion

        public Form1()
        {
            InitializeComponent();

            foreach (var Lvl in Priority_Lvls)
            {
               NumberPriorityComboBox.Items.Add(Lvl);
               LetterPriorityComboBox.Items.Add(Lvl);
               SymbolPriorityComboBox.Items.Add(Lvl);
            }

            ThreadStartNumber = new ThreadStart(GenerateRandomNumber);
            numberThread = new Thread(ThreadStartNumber); 
            ThreadStartLetter = new ThreadStart(GenerateRandomLetter);
            letterThread = new Thread(ThreadStartLetter);    
            ThreadStartSymbol = new ThreadStart(GenerateRandomSymbol);
            symbolThread = new Thread(ThreadStartSymbol);

            NumberPriorityComboBox.SelectedIndex = 2;
            LetterPriorityComboBox.SelectedIndex = 2;
            SymbolPriorityComboBox.SelectedIndex = 2;
        }


        private void RunBtn_Click(object sender, EventArgs e)
        {
            numberThread.Start();
            letterThread.Start();
            symbolThread.Start();

            NumberPriorityComboBox.Enabled = false;
            LetterPriorityComboBox.Enabled = false;
            SymbolPriorityComboBox.Enabled = false;
        }
        [Obsolete]
        private void SuspendBtn_Click(object sender, EventArgs e)
        {
            numberThread.Suspend();
            letterThread.Suspend();
            symbolThread.Suspend();

            NumberPriorityComboBox.Enabled = true;
            LetterPriorityComboBox.Enabled = true;
            SymbolPriorityComboBox.Enabled = true;
        }
        [Obsolete]
        private void ResumeBtn_Click(object sender, EventArgs e)
        {
            numberThread.Resume();
            letterThread.Resume();
            symbolThread.Resume();

            NumberPriorityComboBox.Enabled = false;
            LetterPriorityComboBox.Enabled = false;
            SymbolPriorityComboBox.Enabled = false;
        }

        private void NumberPriorityComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            numberThread.Priority = GetThreadPriorityLvl(NumberPriorityComboBox);
        }
        private void LetterPriorityComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            letterThread.Priority = GetThreadPriorityLvl(LetterPriorityComboBox);
        }
        private void SymbolPriorityComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            symbolThread.Priority = GetThreadPriorityLvl(SymbolPriorityComboBox);
        }

        private void ShowBtn_Click(object sender, EventArgs e)
        {
            MessageBox.Show($"Number Thread: {numberThread.Priority}\nLetter Thread: {letterThread.Priority}\nSymbol Thread: {symbolThread.Priority}");
        }
    }
}
