using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace IBiZ3
{

    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "txt files (*.txt)|*.txt";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                //Get the path of specified file
                textBox4.Text = openFileDialog.FileName;

                //Read the contents of the file into a stream
                var fileStream = openFileDialog.OpenFile();

                using (StreamReader reader = new StreamReader(fileStream))
                {
                    textBox8.Text = reader.ReadToEnd();
                }
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "txt files (*.txt)|*.txt";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                textBox3.Text = openFileDialog.FileName;
            }
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                label2.Text = "Введите текст:";
                textBox4.Visible = false; textBox3.Visible = false;
                textBox1.Visible = true; textBox2.Visible = true;
                button2.Visible = false; button1.Visible = false;
            }
            else
            {
                label2.Text = "Выберите файл:";
                textBox4.Visible = true; textBox3.Visible = true;
                textBox1.Visible = false; textBox2.Visible = false;
                button2.Visible = true; button1.Visible = true;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string text = "";
            if (radioButton2.Checked)
            {
                using (StreamReader reader = new StreamReader(textBox3.Text))
                {
                    text = reader.ReadToEnd().ToUpper();
                }
            }
            else
            {
                text = textBox1.Text.ToUpper();
            }
            string key = textBox5.Text.ToUpper();
            int num_cols = 0;
            if (Regex.IsMatch(key, @"^[А-ЯЁ ]+$") && (key.Distinct().Count() == key.Count()))
            {
                if (Regex.IsMatch(text, @"^[А-ЯЁ ]+$"))
                {
                    if (Int32.TryParse(textBox10.Text, out num_cols))
                    {
                        char[,] square = Program.create_Square(key, num_cols % 33);
                        string final = Program.EncodeString(text, square);
                        textBox7.Text = final;
                        if (checkBox1.Checked)
                        {
                            using (StreamWriter sw = new StreamWriter(textBox9.Text)) { sw.Write(final); }
                        }
                    }
                    else
                    {
                        MessageBox.Show("Введено не число в ячейку количества столбцов");
                    }

                }
                else
                {
                    MessageBox.Show("Неправильный формат текста");
                }
            }
            else
            {
                MessageBox.Show("Введён неправильный ключ");
            }
        }
        private void button8_Click(object sender, EventArgs e)
        {
            {
                string text = "";
                if (radioButton2.Checked)
                {
                    using (StreamReader reader = new StreamReader(textBox4.Text))
                    {
                        text = reader.ReadToEnd().ToUpper();
                    }
                }
                else
                {
                    text = textBox2.Text.ToUpper();
                }
                string key = textBox6.Text.ToUpper();
                int num_cols = 0;
                if (Regex.IsMatch(key, @"^[А-ЯЁ ]+$") && (key.Distinct().Count() == key.Count()))
                {
                    if (Regex.IsMatch(text, @"^[А-ЯЁ ]+$"))
                    {
                        if (Int32.TryParse(textBox10.Text, out num_cols))
                        {
                            char[,] square = Program.create_Square(key, num_cols % 33);
                            string final = Program.DecodeString(text, square);
                            textBox8.Text = final;
                            if (checkBox1.Checked)
                            {
                                using (StreamWriter sw = new StreamWriter(textBox9.Text)) { sw.Write(final); }
                            }
                        }
                        else
                        {
                            MessageBox.Show("Введено не число в ячейку количества столбцов");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Неправильный формат текста");
                    }
                }
                else
                {
                    MessageBox.Show("Введён неправильный ключ");
                }
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                textBox9.Enabled = true; button4.Enabled = true;
            }
            else
            {
                textBox9.Enabled = false; button4.Enabled = false;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "txt files (*.txt)|*.txt";
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                //Get the path of specified file
                textBox9.Text = saveFileDialog.FileName;
            }
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}