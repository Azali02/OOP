namespace oop4_1
{

    public partial class Form1 : Form
    {
        List<CCircle> circles = new List<CCircle>();  //создаем список объектов типа CCircle
        public Form1()
        {
            InitializeComponent();
            KeyPreview = true;  // установить свойство KeyPreview в true
        }

        private void Form1_Paint(object sender, PaintEventArgs e)  //Описание события Paint
        {
            foreach (CCircle circle in circles)
            {
                circle.DrawCircle(this);  //Рисует все круги из списка
            }
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)  //описание события нажатия клавиши на клавиатуре
        {
            if (ModifierKeys == Keys.Control)  //для Control
            {
                chb_Ctrl.Checked = true;
            }
            if (e.KeyCode == Keys.Delete)  //для Delete
            {

                for (int i = 0; i < circles.Count;)
                {
                    if (circles[i].GetColor() == Color.Red)
                    {
                        circles.RemoveAt(i);
                        continue;
                    }
                    ++i;
                }
                if (circles.Count != 0)
                    circles.Last().SetColor(Color.Red);
                Refresh();
            }
        }

        private void Form1_KeyUp(object sender, KeyEventArgs e)  //описание события отпускания клавиши 
        {
            if (chb_Ctrl.Checked == true) //описание события отпускания клавиши Control
                chb_Ctrl.Checked = false;
        }

        private void Form1_MouseClick(object sender, MouseEventArgs e)  //Описание события нажатия мыши
        {
            if (chb_Ctrl.Checked == false)  //создаем новый круг
            {
                foreach (CCircle circle1 in circles)
                    circle1.SetColor(Color.Black);
                CCircle circle = new CCircle(e.X, e.Y);
                circles.Add(circle);
            }
            else  //выделяем круг при отжатии Control
            {
                foreach (CCircle circle in circles)
                    if (circle.isClickedOnCircle(e.X, e.Y))
                    {
                        circle.SetColor(Color.Red);
                        if (chb_flag.Checked == false)
                            break;
                    }
            }
            Refresh();
        }

        private void button1_Click(object sender, EventArgs e)  //описание события кнопки Очистить
        {
            for (int i = 0; i < circles.Count;)
            {
                circles.Remove(circles[i]);
            }
            if (circles.Count != 0)
                circles.Last().SetColor(Color.Red);
            Refresh();
        }

        private void chb_Ctrl_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}