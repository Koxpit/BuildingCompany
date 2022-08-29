using System;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace BuildingCompany.Errors
{
    public static class InputHandler
    {
        /// <summary>
        /// Проверка текстового поля на пустоту.
        /// </summary>
        /// <param name="textBox">Ссылка на текстовое поле.</param>
        /// <returns>Пустое или нет.</returns>
        public static bool TextBoxIsNull(TextBox textBox)
        {
            if (string.IsNullOrWhiteSpace(textBox.Text))
            {
                return true;
            }

            return false;
        }

        /// <summary>
        /// Метод обработки события ввода символа в текстовое поле. ДОпустимо вводить только цифры, backspace и символ разделения цифр.
        /// </summary>
        /// <param name="e"></param>
        public static void WeightChar(KeyPressEventArgs e)
        {
            char digit = e.KeyChar;

            if (!Char.IsDigit(digit) && digit != 8 && digit != 44)
            {
                e.Handled = true;
            }
        }

        /// <summary>
        /// Допустимость ввода только букв с пробелом.
        /// </summary>
        /// <param name="e"></param>
        public static void SymbolWithSpace(KeyPressEventArgs e)
        {
            string Symbol = e.KeyChar.ToString();
            char symbolChar = e.KeyChar;

            if (!Regex.Match(Symbol, @"[а-яА-Я]|[a-zA-Z]").Success && symbolChar != 8 && symbolChar != 32)
            {
                e.Handled = true;
            }
        }

        /// <summary>
        /// Ввод только цифр и backspace.
        /// </summary>
        /// <param name="e"></param>
        public static void DigitOnly(KeyPressEventArgs e)
        {
            char digit = e.KeyChar;

            if (!Char.IsDigit(digit) && digit != 8)
            {
                e.Handled = true;
            }
        }

        /*МЕТОДЫ ДЛЯ ВЫВОДА СООБЩЕНИЙ ПРИ ВОЗНИКНОВЕНИИ ИСКЛЮЧИТЕЛЬНЫХ СИТУАЦИЙ.*/
        public static void PrintNullWarningMessagge()
        {
            MessageBox.Show("Заполните необходимые поля.", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        public static void PrintBrigadierFindErrorMessagge()
        {
            MessageBox.Show("Бригадир не найден", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        public static void PrintErrorFindTypeOfFacility()
        {
            MessageBox.Show("Тип объекта не найден.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        public static void PrintErrorFindMaterial()
        {
            MessageBox.Show("Материал не найден.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        public static void PrintErrorFindWorker()
        {
            MessageBox.Show("Рабочий не найден.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        public static void PrintErrorFindBrigade()
        {
            MessageBox.Show("Бригада не найдена.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        public static void PrintErrorFindFacility()
        {
            MessageBox.Show("Объект не найден.", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        public static void PrintErrorFindProfession()
        {
            MessageBox.Show("Профессия не найдена.", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }


        public static void PrintWarningExistMaterial()
        {
            MessageBox.Show("Материал уже существует.", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        public static void PrintWarningExistWorker()
        {
            MessageBox.Show("Рабочий уже существует в данной бригаде.", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        public static void PrintWarningExistProfession()
        {
            MessageBox.Show("Данная профессия уже существует.", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        public static void PrintWarningExistProfessionInWorker()
        {
            MessageBox.Show("Рабочий уже обладает данной специальностью.", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        public static void PrintWarningExistPhoneNumberOnWorker()
        {
            MessageBox.Show("Введенный номер телефона принадлежит другому работнику.", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
    }
}
