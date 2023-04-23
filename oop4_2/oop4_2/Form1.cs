
namespace oop4_2
{

    public partial class Form1 : Form
    {
        Model model;

        public Form1()
        {
            InitializeComponent();
            model = new Model();
            model.observers += new System.EventHandler(this.UpdateFormModel);
            model.setValueA(Properties.Settings.Default.A);
            model.setValueC(Properties.Settings.Default.C);
        }

        private void UpdateFormModel(object sender, EventArgs e)
        {
            numA.Value = model.getValueA();
            tbA.Value = model.getValueA();
            textA.Text = model.getValueA().ToString();

            numB.Value = model.getValueB();
            tBB.Value = model.getValueB();
            textB.Text = model.getValueB().ToString();

            numC.Value = model.getValueC();
            tBC.Value = model.getValueC();
            textC.Text = model.getValueC().ToString();
        }

        private void numA_ValueChanged(object sender, EventArgs e)
        {
            model.setValueA((int)numA.Value);
        }

        private void tbA_Scroll(object sender, EventArgs e)
        {
            model.setValueA((int)tbA.Value);
        }

        private void textA_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                model.setValueA(Int32.Parse(textA.Text));
            }
        }

        private void textA_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Проверяем, является ли введенный символ цифрой или клавишей Backspace
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != '\b')
            {
                // Если символ не является цифрой или клавишей Backspace, то блокируем ввод
                e.Handled = true;
            }
        }

        private void text_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Проверяем, является ли введенный символ цифрой или клавишей Backspace
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != '\b')
            {
                // Если символ не является цифрой или клавишей Backspace, то блокируем ввод
                e.Handled = true;
            }
        }

        private void tBB_Scroll(object sender, EventArgs e)
        {
            model.setValueB((int)tBB.Value);
        }

        private void tBC_Scroll(object sender, EventArgs e)
        {
            model.setValueC((int)tBC.Value);
        }

        private void numB_ValueChanged(object sender, EventArgs e)
        {
            model.setValueB((int)numB.Value);
        }

        private void numC_ValueChanged(object sender, EventArgs e)
        {
            model.setValueC((int)numC.Value);
        }

        private void textB_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                model.setValueB(Int32.Parse(textB.Text));
            }
        }

        private void textC_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                model.setValueC(Int32.Parse(textC.Text));
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            Properties.Settings.Default.A = (int)numA.Value;
            Properties.Settings.Default.C = (int)numC.Value;
            Properties.Settings.Default.Save();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            model.setValueA(0);
            model.setValueB(0);
            model.setValueC(0);
        }
    }

    class Model
    {
        private int valueA;
        private int valueB;
        private int valueC;
        public System.EventHandler observers;

        public Model()
        {
            valueA = Properties.Settings.Default.A;
            valueB = 0;
            valueC = Properties.Settings.Default.C;
        }

        public void setValueA(int value)
        {
            if (value > 100)
                value = 100;
            if (value > valueC)
            {
                valueB = value;
                valueC = value;
            }
            else if (value > valueB)
                valueB = value;
            valueA = value;
            observers.Invoke(this, null);
        }

        public void setValueB(int value)
        {
            if (value > 100)
                value = 100;
            if (value > valueC)
                value = valueC;
            else if (value < valueA)
                value = valueA;
            valueB = value;
            observers.Invoke(this, null);
        }

        public void setValueC(int value)
        {
            if (value > 100)
                value = 100;
            if (value < valueA)
            {
                valueA = value;
                valueB = value;
            }
            else if (value < valueB)
                valueB = value;
            valueC = value;
            observers.Invoke(this, null);
        }

        public int getValueA()
        {
            return valueA;
        }
        public int getValueB()
        {
            return valueB;
        }
        public int getValueC()
        {
            return valueC;
        }
    }
}