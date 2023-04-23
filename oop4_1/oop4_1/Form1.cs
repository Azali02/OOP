namespace oop4_1
{

    public partial class Form1 : Form
    {
        List<CCircle> circles = new List<CCircle>();  //������� ������ �������� ���� CCircle
        public Form1()
        {
            InitializeComponent();
            KeyPreview = true;  // ���������� �������� KeyPreview � true
        }

        private void Form1_Paint(object sender, PaintEventArgs e)  //�������� ������� Paint
        {
            foreach (CCircle circle in circles)
            {
                circle.DrawCircle(this);  //������ ��� ����� �� ������
            }
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)  //�������� ������� ������� ������� �� ����������
        {
            if (ModifierKeys == Keys.Control)  //��� Control
            {
                chb_Ctrl.Checked = true;
            }
            if (e.KeyCode == Keys.Delete)  //��� Delete
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

        private void Form1_KeyUp(object sender, KeyEventArgs e)  //�������� ������� ���������� ������� 
        {
            if (chb_Ctrl.Checked == true) //�������� ������� ���������� ������� Control
                chb_Ctrl.Checked = false;
        }

        private void Form1_MouseClick(object sender, MouseEventArgs e)  //�������� ������� ������� ����
        {
            if (chb_Ctrl.Checked == false)  //������� ����� ����
            {
                foreach (CCircle circle1 in circles)
                    circle1.SetColor(Color.Black);
                CCircle circle = new CCircle(e.X, e.Y);
                circles.Add(circle);
            }
            else  //�������� ���� ��� ������� Control
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

        private void button1_Click(object sender, EventArgs e)  //�������� ������� ������ ��������
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