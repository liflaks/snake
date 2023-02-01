using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SNAKE.forms
{
    public partial class Snake_main : Form
    {
        //переменные
        int height_w = 900;
        int width_w = 900;

        public Snake_main()
        {
            InitializeComponent();
            this.KeyDown += new KeyEventHandler(KeyP);
        }

        public void KeyP (object send, KeyEventArgs e) // хэндлер нажатий сделанный на switch и case
        {
            switch(e.KeyCode.ToString()) // сделал wasd, так удобней
            {
                case "D":
                    body_sk.Location = new Point(body_sk.Location.X + 25, body_sk.Location.Y); //вправо
                    break;
                case "A":
                    body_sk.Location = new Point(body_sk.Location.X - 25, body_sk.Location.Y); //влево
                    break;
                case "W":
                    body_sk.Location = new Point(body_sk.Location.X, body_sk.Location.Y - 25); //верх
                    break;
                case "S":
                    body_sk.Location = new Point(body_sk.Location.X, body_sk.Location.Y + 25); //вниз
                    break;
            }
        }

       
    }
}
