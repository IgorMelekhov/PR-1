using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ПР_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            textBox1Х.Validating += textBox1Х_Validating;
            textBox2У.Validating += textBox2У_Validating;
        }
        private void оПрограммеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 newF = new Form2();
            newF.Show();
        }
        private void выходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void очиститьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            answer.Clear();
            textBox1Х.Clear();
            textBox2У.Clear();
        }
        private void textBox1_MouseHover_1(object sender, EventArgs e)
        {
            toolTip1.SetToolTip(textBox1Х, "Введите число");
        }

        private void textBox2_MouseHover(object sender, EventArgs e)
        {
            toolTip1.SetToolTip(textBox2У, "Введите число");
        }

        private void textBox3_MouseHover(object sender, EventArgs e)
        {
            toolTip1.SetToolTip(answer, "Здесь будет выведен ответ");
        }
        //private void textBox1_TextChanged(object sender, EventArgs e)
        //{

        //}
        private void button3Выход_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button3Выход_MouseHover(object sender, EventArgs e)
        {
            toolTip1.SetToolTip(button3Exit, "Выйти");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                Pluse my_Class = new Pluse(Convert.ToDouble(textBox1Х.Text), Convert.ToDouble(textBox2У.Text));
                answer.Text = my_Class.res.ToString();
            }
            catch
            {
                MessageBox.Show("Введены неверные значения", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                textBox1Х.Clear();
                textBox2У.Clear();
                answer.Clear();
            }
        }

        private void buttonMinuse_Click(object sender, EventArgs e)
        {
            try
            {
                Minus my_Class = new Minus(Convert.ToDouble(textBox1Х.Text), Convert.ToDouble(textBox2У.Text));
                answer.Text = my_Class.res.ToString();
            }
            catch
            {
                MessageBox.Show("Введены неверные значения", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                textBox1Х.Clear();
                textBox2У.Clear();
                answer.Clear();
            }
        }

        private void buttonDivision_Click(object sender, EventArgs e)
        {
            if (Convert.ToDouble(textBox2У.Text) == 0)
            {
                MessageBox.Show("Деление на ноль", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                textBox1Х.Clear();
                textBox2У.Clear();
            }
            try
            {
                Division my_Class = new Division(Convert.ToDouble(textBox1Х.Text), Convert.ToDouble(textBox2У.Text));
                answer.Text = my_Class.res.ToString();
            }
            catch
            {
                MessageBox.Show("Введены неверные значения", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                textBox1Х.Clear();
                textBox2У.Clear();
                answer.Clear();
            }
        }
        private void buttonMultiply_Click(object sender, EventArgs e)
        {
            try
            {
                Multiply my_Class = new Multiply(Convert.ToDouble(textBox1Х.Text), Convert.ToDouble(textBox2У.Text));
                answer.Text = my_Class.res.ToString();
            }
            catch
            {
                MessageBox.Show("Введены неверные значения", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                textBox1Х.Clear();
                textBox2У.Clear();
                answer.Clear();
            }
        }

        private void textBox1Х_Validating(object sender, CancelEventArgs e)
        {
            double inputNumber;
            if (String.IsNullOrEmpty(textBox1Х.Text))
            { errorProvider1.SetError(textBox1Х, "Поле не может быть пустым!"); }
            else if (!double.TryParse(textBox1Х.Text, out inputNumber))
            { errorProvider1.SetError(textBox1Х, "В поле должно быть введено число!"); }
            else
            { errorProvider1.Clear(); }
        }
        private void textBox2У_Validating(object sender, CancelEventArgs e)
        {
            double inputNumber;
            if (String.IsNullOrEmpty(textBox2У.Text))
            { errorProvider1.SetError(textBox2У, "Поле не может быть пустым !"); }
            else if (!double.TryParse(textBox2У.Text, out inputNumber))
            { errorProvider1.SetError(textBox2У, "В поле должно быть введено число!"); }
            else
            { errorProvider1.Clear(); }
        }
    }
}
