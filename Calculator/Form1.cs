using System.Diagnostics;
using System.Security.Cryptography.Xml;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Form1 : Form
    {
        double num1 = 0;
        double num2 = 0;
        double result = 0;
        string operation = string.Empty;

        KeyInfo keyInfo = new KeyInfo();
        public Form1()
        {
            InitializeComponent();
            SetDefaultValues();
            //labelPrompt.Text = "Click on start button for starting calculator.";
            labelPrompt.Text = "Для запуска калькулятора нажмите на кнопку";
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void SetDefaultValues()
        {
            enterNumberTextBox.Visible = true;
        }

        private void ResetForm()
        {

            SetDefaultValues();
        }

        private void buttonStart_Click(object sender, EventArgs e)
        {
            //labelPrompt.Text = "Enter first number:";
            labelPrompt.Text = "Введите первое число:";
            enterNumberButtonsGroup.Visible = true;
            buttonSecondNum.Visible = false;
            buttonStart.Visible = false;
        }

        private void buttonFirstNum_Click(object sender, EventArgs e)
        {
            try
            {
                num1 = Convert.ToDouble(enterNumberTextBox.Text);
                enterNumberTextBox.Text = string.Empty;
                //labelPrompt.Text = "Enter second number:";
                labelPrompt.Text = "Введите второе число:";
                buttonFirstNum.Visible = false;
                buttonSecondNum.Visible = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Введите корректное числовое значение. Возможен ввод дробного числа. Разделитель - запятая.", "Ошибка", MessageBoxButtons.OK);
                enterNumberTextBox.Text = string.Empty;
            }
        }

        private void buttonSecondNum_Click(object sender, EventArgs e)
        {
            try
            {
                //check = Double.TryParse(enterNumberTextBox.Text, out num2);
                num2 = Convert.ToDouble(enterNumberTextBox.Text);
                enterNumberTextBox.Visible = false;
                labelPrompt.Text = "Выберите операцию";
                buttonSecondNum.Visible = false;
                operationButtonsGroup.Visible = true;
                enterNumberButtonsGroup.Visible = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Введите корректное числовое значение. Возможен ввод дробного числа. Разделитель - запятая.", "Ошибка", MessageBoxButtons.OK);
                enterNumberTextBox.Text = string.Empty;
            }
        }

        private void buttonPlus_Click(object sender, EventArgs e)
        {
            solveButtonGroup.Visible = true;
            operation = "+";
            result = num1 + num2;
            operationButtonsGroup.Visible = false;
            labelPrompt.Text = "Для решения примера нажмите на кнопку";
        }

        private void buttonMinus_Click(object sender, EventArgs e)
        {
            solveButtonGroup.Visible = true;
            operation = "-";
            result = num1 - num2;
            operationButtonsGroup.Visible = false;
            labelPrompt.Text = "Для решения примера нажмите на кнопку";
        }

        private void buttonProd_Click(object sender, EventArgs e)
        {
            solveButtonGroup.Visible = true;
            operation = "*";
            result = num1 * num2;
            operationButtonsGroup.Visible = false;
            labelPrompt.Text = "Для решения примера нажмите на кнопку";
        }

        private void buttonDiv_Click(object sender, EventArgs e)
        {
            solveButtonGroup.Visible = true;
            operation = "/";
            result = num1 / num2;
            operationButtonsGroup.Visible = false;
            labelPrompt.Text = "Для решения примера нажмите на кнопку";
        }

        private void buttonControl_Click(object sender, EventArgs e)
        {
            labelAnswer.Visible = true;
            labelAnswer.Text = string.Format("{0} {3} {1} = {2}", num1, num2, result, operation);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            //ConsoleKeyInfo keyInfo = new ConsoleKeyInfo();
            //while (keyInfo.Key != ConsoleKey.Enter)
            //{

            //}

            //textBox1.Text = string.Empty;

            //labelPrompt.Text = "Введите второе число:";
            //while (keyInfo.Key != ConsoleKey.Enter)
            //{
            //    check = Double.TryParse(textBox1.Text, out num2);
            //}
            //textBox1.Text = string.Empty;
        }

        private void copyrightLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            try
            {
                VisitLink();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Unable to open link that was clicked.");
            }
        }

        private void VisitLink()
        {
            // Change the color of the link text by setting LinkVisited
            // to true.
            copyrightLabel.LinkVisited = true;
            //Call the Process.Start method to open the default browser
            //with a URL:
            System.Diagnostics.Process.Start(new ProcessStartInfo
            {
                FileName = "https://t.me/pafonelove",
                UseShellExecute = true
            });
        }
    }
}