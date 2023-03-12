using System;
using System.Drawing;
using System.Windows.Forms;

namespace Wall
{
    public partial class AddElement : Form
    {
        private ElementType type;

        public AddElement(ElementType type)
        {
            InitializeComponent();

            this.type = type;

            switch (type)
            {
                case ElementType.WINDOW:
                    Text = "Добавить окно...";
                    break;
                case ElementType.DOOR:
                    Text = "Добавить дверь...";
                    posY_lb.Enabled = false;
                    posY_tb.Enabled = false;
                    posY_tb.Text = 0.ToString();
                    break;
                case ElementType.PILAR:
                    Text = "Добавить колонну";
                    height_lb.Enabled = false;
                    height_tb.Enabled = false;
                    height_tb.Text = 0.ToString();
                    posY_lb.Enabled = false;
                    posY_tb.Enabled = false;
                    posY_tb.Text = 0.ToString();
                    break;
            }
        }

        public enum ElementType { WINDOW, DOOR, PILAR }

        private void cancel_button_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void ok_button_Click(object sender, EventArgs e)
        {
            if(posX_tb.Text == "" || posY_tb.Text == "" || width_tb.Text == "" || height_lb.Text == "")
            {
                MessageBox.Show("Не все поля заполнены", "Ошибка", MessageBoxButtons.OK);
                return;
            }

            int x = int.Parse(posX_tb.Text);
            int y = int.Parse(posY_tb.Text);
            int width = int.Parse(width_tb.Text);
            int height = int.Parse(height_tb.Text);

            Rectangle rect_0 = new Rectangle(x, y, width, height);

            foreach (var item in MainForm.elements)
            {
                Rectangle rect_1 = new Rectangle(item.x, MainForm.wallMatrix.GetLength(1) - item.y - item.height, item.width, item.height);

                if (rect_0.IntersectsWith(rect_1))
                {
                    MessageBox.Show("Пересечение элементов", "Ошибка", MessageBoxButtons.OK);
                    return;
                }
            }

            switch (type)
            {
                case ElementType.WINDOW:
                    MainForm.instance.addWindow(x, y, width, height);
                    break;
                case ElementType.DOOR:
                    MainForm.instance.addDoor(x, y, width, height);
                    break;
                case ElementType.PILAR:
                    MainForm.instance.addPilar(x, y, width, height);
                    break;
            }

            Close();
        }

        private void tb_keyPressed(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 8)
            {
                e.Handled = true;
            }
        }
    }
}
