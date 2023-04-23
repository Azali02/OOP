
namespace oop4_1
{
    internal class CCircle
    {
        private int x, y, rad;  //координаты и радиус
        private Pen pen;
        Graphics g;
        public CCircle(int x, int y)
        {
            this.x = x;
            this.y = y;
            rad = 25;
            pen = new Pen(Color.Red);
        }

        public void DrawCircle(Form1 form)  //отрисовка круга
        {
            g = form.CreateGraphics();
            g.DrawEllipse(pen, x - rad, y - rad, 2 * rad, 2 * rad);
        }

        public bool isClickedOnCircle(int X, int Y) //определение попадания в круг
        {
            if ((X - x) * (X - x) + (Y - y) * (Y - y) <= rad * rad)
                return true;
            else
                return false;
        }

        public void SetColor(Color color)  //установка цвета
        {
            pen.Color = color;
        }

        public Color GetColor()  //определение цвета
        {
            return pen.Color;
        }
    }
}
