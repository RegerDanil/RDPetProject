using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Wall
{
     public partial class MainForm : Form
    {
        public static MainForm instance;

        public static int[,] wallMatrix;

        public static List<Element> elements = new List<Element>();
        
        public static List<Point> points = new List<Point>();

        public MainForm()
        {
            InitializeComponent();

            instance = this;

            int sizeX = int.Parse(textBox_1.Text);
            int sizeY = int.Parse(textBox_2.Text);

            wallMatrix = new int[sizeX, sizeY];
        }

        private void calculate_button_Click(object sender, EventArgs e)
        {
            rebuildPoints();

            new ResultForm().Show();

            Hide();
        }

        public void addWindow(int x, int y, int width, int height)
        {
            if(x < 0 || y < 0 || x + width > wallMatrix.GetLength(0) || y + height > wallMatrix.GetLength(1))
            {
                MessageBox.Show("Элемент не был добавлен", "Некорректные параметры", MessageBoxButtons.OK);
                return;
            }

            for (int i = x; i < x + width; i++)
                for (int ii = y; ii < y + height; ii++)
                    wallMatrix[i, ii] = 1;

            elements.Add(new Element(AddElement.ElementType.WINDOW, x, wallMatrix.GetLength(1) - y - height, width, height));
        }

        public void addDoor(int x, int y, int width, int height)
        {
            if (x < 0 || y < 0 || x + width > wallMatrix.GetLength(0) || y + height > wallMatrix.GetLength(1))
            {
                MessageBox.Show("Элемент не был добавлен", "Некорректные параметры", MessageBoxButtons.OK);
                return;
            }

            for (int i = x; i < x + width; i++)
                for (int ii = y; ii < y + height; ii++)
                    wallMatrix[i, ii] = 2;

            elements.Add(new Element(AddElement.ElementType.DOOR, x, wallMatrix.GetLength(1) - y - height, width, height));
        }

        public void addPilar(int x, int y, int width, int height)
        {
            if (x < 0 || y < 0 || x + width > wallMatrix.GetLength(0) || y + height > wallMatrix.GetLength(1))
            {
                MessageBox.Show("Элемент не был добавлен", "Некорректные параметры", MessageBoxButtons.OK);
                return;
            }

            for (int i = x; i < x + width; i++)
                for (int ii = 0; ii < wallMatrix.GetLength(1); ii++)
                    wallMatrix[i, ii] = 3;

            elements.Add(new Element(AddElement.ElementType.PILAR, x, 0, width, wallMatrix.GetLength(1)));
        }

        private void tb_key_pressed(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 8)
            {
                e.Handled = true;
            }
        }

        private void add_window_Click(object sender, EventArgs e)
        {
            new AddElement(AddElement.ElementType.WINDOW).ShowDialog();
        }

        private void add_door_Click(object sender, EventArgs e)
        {
            new AddElement(AddElement.ElementType.DOOR).ShowDialog();
        }

        private void add_pilar_Click(object sender, EventArgs e)
        {
            new AddElement(AddElement.ElementType.PILAR).ShowDialog();
        }

        private void tb_textChanged(object sender, EventArgs e)
        {
            if (textBox_1.Text == "" || textBox_2.Text == "")
                return;

            int sizeX = int.Parse(textBox_1.Text);
            int sizeY = int.Parse(textBox_2.Text);

            wallMatrix = new int[sizeX, sizeY];
            elements.Clear();
            points.Clear();
        }
   
        private void clear_button_Click(object sender, EventArgs e)
        {
            int sizeX = int.Parse(textBox_1.Text);
            int sizeY = int.Parse(textBox_2.Text);

            wallMatrix = new int[sizeX, sizeY];

            elements.Clear();
            points.Clear();
        }

        private void massive_button_Click(object sender, EventArgs e)
        {
            rebuildPoints();

            StringBuilder array = new StringBuilder();

            //for (int i = 0; i < wallMatrix.GetLength(1); i++)
            //{
            //    array.Append("[");

            //    for (int ii = 0; ii < wallMatrix.GetLength(0); ii++)
            //    {
            //        array.Append(wallMatrix[ii, wallMatrix.GetLength(1) - 1 - i] + " ");
            //    }

            //    array.Append("] \r\n");
            //}

            //array.AppendLine();
            //array.AppendLine();
            //array.AppendLine("[0 - стена / 1 - окно / 2 - дверь / 3 - колонна]");

            array.Append("[");

            foreach (var item in points)
            {
                array.Append(" (" + item.x + ";" + item.y + ")");
            }

            array.Append(" ]");

            MessageBox.Show(array.ToString(), "Массив", MessageBoxButtons.OK);
        }

        private void rebuildPoints()
        {
            points.Clear();

            foreach (var item in elements)
            {
                int x = item.x;
                int y = item.y;
                int width = item.width;
                int height = item.height;

                float px, py;

                switch (item.type)
                {
                    case AddElement.ElementType.WINDOW:
                        px = x + (width / 2f);
                        py = y + (height / 2f);
                        points.Add(new Point(px, py));
                        break;
                    case AddElement.ElementType.DOOR:
                        px = x + (width / 2f);
                        py = wallMatrix.GetLength(1) - 1.5f;
                        points.Add(new Point(px, py));
                        break;
                    case AddElement.ElementType.PILAR:
                        px = x + (width / 2f);
                        py = 1;
                        for (int i = wallMatrix.GetLength(1) - 1; i > 0; i -= 2)
                            points.Add(new Point(px, i));
                        break;
                }
            }

            int sizeX = wallMatrix.GetLength(0);
            int sizeY = wallMatrix.GetLength(1);

            for (int i = 1; i < sizeX; i += 2)
            {
                for (int ii = 1; ii < sizeY; ii += 2)
                {
                    bool isPointIntersectElement = false;

                    foreach (var item in elements)
                    {
                        Rectangle rect = new Rectangle(item.x - 0, wallMatrix.GetLength(1) - item.y - item.height - 0, item.width + 1, item.height + 1);

                        if (rect.Contains(i, ii))
                        {
                            isPointIntersectElement = true;
                            break;
                        }
                    }
                    
                    if(!isPointIntersectElement)
                        points.Add(new Point(i, sizeY - ii));
                }
            }

        }

        public class Element
        {
            public int x, y, width, height;
            public AddElement.ElementType type;

            public Element(AddElement.ElementType _type, int _x, int _y, int _width, int _height)
            {
                x = _x;
                y = _y;
                width = _width;
                height = _height;
                type = _type;
            }
        }

        public struct Point
        {
            public float x, y;

            public Point(float x, float y)
            {
                this.x = x;
                this.y = y;
            }
        }
    }
}
