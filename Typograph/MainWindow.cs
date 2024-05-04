using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace TypographApp
{
    public partial class Typograph : Form
    {
        private bool TextCleared = false;
        public Typograph()
        {
            InitializeComponent();
            MaximizeBox = false;
        }

        private void TypographTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!TextCleared)
            {
                TypographTextBox.Text = string.Empty;
                TextCleared = true;
            }
        }

        private void TypographButton_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(TypographTextBox.Text) && TextCleared)
            {
                string text = TypographTextBox.Text;
                text = Rule_ReplaceSpaces(text);
                text = Rule_MinusPlus(text);
                text = Rule_OperationSigns(text);
                text = Rule_ReplaceEllipsis(text);
                text = Rule_Tyre(text);
                text = Rule_FiftyTwo(text);
                text = Rule_Point(text);
                TypographTextBox.Text = text;
                TypographTextBox.SelectionStart = TypographTextBox.Text.Length;
            }
            else
            {
                MessageBox.Show("Введите текст!");
            }
        }

        /// <summary>
        /// Метод заменяет все пробелы в строке на один пробел (правило 2).
        /// </summary>
        /// <param name="text">Строка, в которой нужно заменить пробелы.</param>
        /// <returns>Строка с замененными пробелами.</returns>
        public string Rule_ReplaceSpaces(string text)
        {
            Regex regexSpaces = new Regex(@"\s+", RegexOptions.Compiled);
            string replacementSpaces = " ";
            text = regexSpaces.Replace(text, replacementSpaces);
            return text;
        }

        /// <summary>
        /// Метод заменяет все символы "+−" на "±" в строке (правило 9).
        /// </summary>
        /// <param name="text">Строка, в которой нужно заменить "+−" на "±".</param>
        /// <returns>Строка с замененными символами.</returns>
        public string Rule_MinusPlus(string text)
        {
            Regex regexPlusMinus = new Regex(@"(\+−)", RegexOptions.Compiled);
            string replacementPlusMinus = "±";
            text = regexPlusMinus.Replace(text, replacementPlusMinus);
            return text;
        }

        /// <summary>
        /// Метод заменяет все символы "-" на "−" и отбивает
        ///знаки операций пробелом с двух сторон в строке (правило 8).
        /// </summary>
        /// <param name="text">Строка, в которой нужно заменить символы "-" на "−" и отбить пробелом знаки.</param>
        /// <returns>Строка с замененными символами и пробелами.</returns>
        public string Rule_OperationSigns(string text)
        {
            Regex regexMinusToDash = new Regex(@"-", RegexOptions.Compiled);
            string replacementMinusToDash = "−";
            text = regexMinusToDash.Replace(text, replacementMinusToDash);
            Regex regexAddition = new Regex(@"(\d)\+(−?)(\d)=(−?)(\d)", RegexOptions.Compiled);
            Regex regexSubtraction = new Regex(@"(\d)−(\d)=(\d)", RegexOptions.Compiled);
            Regex regexMultiplication = new Regex(@"(\d)\*(−?)(\d)=(−?)(\d)", RegexOptions.Compiled);
            Regex regexDivision = new Regex(@"(\d)/(−?)(\d)=(−?)(\d)", RegexOptions.Compiled);
            text = regexAddition.Replace(text, "$1 + $2$3 = $4$5");
            text = regexSubtraction.Replace(text, "$1 − $2 = $3");
            text = regexMultiplication.Replace(text, "$1 * $2$3 = $4$5");
            text = regexDivision.Replace(text, "$1 / $2$3 = $4$5");
            return text;
        }

        /// <summary>
        /// Метод заменяет троеточие, напсианное точками ("...") на знак ("…") в строке (правило 13).
        /// </summary>
        /// <param name="text">Строка, в которой нужно заменить троеточие, написанное точками на знак ("…").</param>
        /// <returns>Строка со знаком ("…").</returns>
        public string Rule_ReplaceEllipsis(string text)
        {
            Regex regexEllipsis = new Regex(@"\.\.\.", RegexOptions.Compiled);
            string replacementEllipsis = "…";
            text = regexEllipsis.Replace(text, replacementEllipsis);
            return text;
        }

        /// <summary>
        /// Метод заменяет все символы "-" на "—" в строке (правило 6).
        /// </summary>
        /// <param name="text">Строка, в которой нужно заменить "-" на "—".</param>
        /// <returns>Строка с замененными символами.</returns>
        public string Rule_Tyre(string text)
        {
            Regex regexHyphen = new Regex(@"-", RegexOptions.Compiled);
            string replacementHyphen = "—";
            text = regexHyphen.Replace(text, replacementHyphen);
            return text;
        }

        /// <summary>
        /// Метод заменяет символы "52" на "Да здравствует Санкт-Петербург, и это город наш!!!" в строке.
        /// </summary>
        /// <param name="text">Строка, в которой нужно заменить "52" на "Да здравствует Санкт-Петербург, и это город наш!!!".</param>
        /// <returns>Строка с замененными символами.</returns>
        public string Rule_FiftyTwo(string text)
        {
            Regex regexFiftyTwo = new Regex(@"52", RegexOptions.Compiled);
            string replacementFiftyTwo = "Да здравствует Санкт-Петербург, и это город наш!!!";
            text = regexFiftyTwo.Replace(text, replacementFiftyTwo);
            return text;
        }

        /// <summary>
        /// Метод заменяет символы "." на "(точка)" в строке.
        /// </summary>
        /// <param name="text">Строка, в которой нужно заменить "." на "(точка)".</param>
        /// <returns>Строка с замененными символами.</returns>
        public string Rule_Point(string text) 
        {
            Regex regexPoint = new Regex(@"\.", RegexOptions.Compiled);
            string replacementPoint = "(точка)";
            text = regexPoint.Replace(text, replacementPoint);
            return text;
        }

    }
}
