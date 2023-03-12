using System.Drawing;
using System.Windows.Forms;

namespace Wall
{
    public partial class ResultForm : Form
    {
        private Graphics graphics;

        private int cellSize = 16;
        private float pointSize = 5;

        public ResultForm()
        {
            InitializeComponent();

            int sizeX = MainForm.wallMatrix.GetLength(0);
            int sizeY = MainForm.wallMatrix.GetLength(1);

            Bitmap image = new Bitmap((sizeX + 2) * cellSize, (sizeY + 2)* cellSize);

            graphics = Graphics.FromImage(image);
            graphics.FillRectangle(Brushes.White, 0, 0, image.Width, image.Height);

            Pen pen = new Pen(Color.Black);
            pen.Width = 1;

            for (int i = 1; i < sizeX + 1; i++)
            {
                for (int ii = 1; ii < sizeY + 1; ii++)
                {
                        graphics.DrawRectangle(pen, i * cellSize, ii * cellSize, cellSize, cellSize);
                }
            }

            foreach (var item in MainForm.elements)
            {
                graphics.FillRectangle(Brushes.White, (item.x + 1.5f) * cellSize, (item.y + 1.5f) * cellSize, (item.width - 1) * cellSize, (item.height - 1) * cellSize);

                switch (item.type)
                {
                    case AddElement.ElementType.WINDOW:
                        drawWindow(item);
                        break;
                    case AddElement.ElementType.DOOR:
                        drawDoor(item);
                        break;
                    case AddElement.ElementType.PILAR:
                        drawPilar(item);
                        break;
                }

            }

            foreach (var item in MainForm.points)
                graphics.FillEllipse(Brushes.Red, (item.x + 1) * cellSize - pointSize / 2, (item.y + 1) * cellSize - pointSize / 2, pointSize, pointSize);

            pictureBox.Image = image;
        }

        private void drawWindow(MainForm.Element item)
        {
            Pen pen = new Pen(Color.LightBlue);
            pen.Width = 1;

            //graphics.FillRectangle(Brushes.White, (item.x + 1.5f) * cellSize, (item.y + 1.5f) * cellSize, (item.width - 1) * cellSize, (item.height - 1) * cellSize);

            for (int i = 1 + item.x; i < item.width + item.x + 1; i++)
            {
                for (int ii = 1 + item.y; ii < item.height + item.y + 1; ii++)
                {
                        graphics.DrawRectangle(pen, i * cellSize, ii * cellSize, cellSize, cellSize);
                }
            }

            pen.Width = 2;

            graphics.DrawRectangle(pen, (item.x + 1) * cellSize, (item.y + 1) * cellSize, item.width * cellSize, item.height * cellSize);
        }

        private void drawDoor(MainForm.Element item)
        {
            Pen pen = new Pen(Color.SandyBrown);
            pen.Width = 1;

            graphics.FillRectangle(Brushes.White, (item.x + 1.5f) * cellSize, (item.y + 1.5f) * cellSize, (item.width - 1) * cellSize, (item.height - 1) * cellSize);

            for (int i = 1 + item.x; i < item.width + item.x + 1; i++)
            {
                for (int ii = 1 + item.y; ii < item.height + item.y + 1; ii++)
                {
                    graphics.DrawRectangle(pen, i * cellSize, ii * cellSize, cellSize, cellSize);
                }
            }

            pen.Width = 2;

            graphics.DrawRectangle(pen, (item.x + 1) * cellSize, (item.y + 1) * cellSize, item.width * cellSize, item.height * cellSize);
        }

        private void drawPilar(MainForm.Element item)
        {
            Pen pen = new Pen(Color.Chocolate);
            pen.Width = 1;

            graphics.FillRectangle(Brushes.White, (item.x + 1.5f) * cellSize, (item.y + 1.5f) * cellSize, (item.width - 1) * cellSize, (item.height - 1) * cellSize);

            for (int i = 1 + item.x; i < item.width + item.x + 1; i++)
            {
                for (int ii = 1 + item.y; ii < item.height + item.y + 1; ii++)
                {
                    graphics.DrawRectangle(pen, i * cellSize, ii * cellSize, cellSize, cellSize);
                }
            }

            pen.Width = 2;

            graphics.DrawRectangle(pen, (item.x + 1) * cellSize, (item.y + 1) * cellSize, item.width * cellSize, item.height * cellSize);
        }

        private void onClosing(object sender, FormClosingEventArgs e)
        {
            MainForm.instance.Show();
        }
    }
}
