using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Drawing.Drawing2D;

namespace _6._1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        protected override void OnPaint(PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            // Задаем цвет для парусника
            SolidBrush pic = new SolidBrush(Color.Black);
            SolidBrush pic2 = new SolidBrush(Color.DarkRed);
            HatchBrush hb1 = new HatchBrush(HatchStyle.Percent30, Color.MidnightBlue);
            HatchBrush hb2 = new HatchBrush(HatchStyle.Percent30, Color.PaleVioletRed);
            HatchBrush hb3 = new HatchBrush(HatchStyle.Percent30, Color.Yellow);
            HatchBrush hb4 = new HatchBrush(HatchStyle.Percent50, Color.PaleVioletRed);
            HatchBrush hb5 = new HatchBrush(HatchStyle.Percent50, Color.LightSkyBlue);
            HatchBrush hb6 = new HatchBrush(HatchStyle.Percent50, Color.DeepSkyBlue);
            Pen line = new Pen(Brushes.Black, 2);
            Pen line2 = new Pen(Brushes.Black, 3);
            Pen line3 = new Pen(Brushes.DarkRed, 4);

            //рисуем основу

            g.FillRectangle(hb6, 0, 0, 644, 425);
            g.FillEllipse(hb5, -100, 50, 800, 300);
            g.FillEllipse(hb4, 70, 100, 500, 300);
            g.FillEllipse(hb3, 245, 160, 150, 150);
            g.FillRectangle(hb1, 0, 250, 700, 300);
            g.FillPolygon(hb2 , new Point[] { new Point(0, 175), new Point(0, 250), new Point(320, 250) });
            g.FillPolygon(hb2, new Point[] { new Point(322, 250), new Point(644, 250), new Point(644, 175) });

            //рисуем веревки
            g.DrawLine(line, 350, 53, 300, 73);
            g.DrawLine(line, 350, 53, 315, 80);
            g.DrawLine(line, 350, 53, 339, 85);
            g.DrawLine(line, 350, 53, 220, 58);
            g.DrawLine(line, 222, 58, 179, 78);
            g.DrawLine(line, 222, 58, 190, 85);
            g.DrawLine(line, 222, 58, 210, 93);

            // *********** 1 - Рисуем корпус парусника *********
            // Определяем графический контейнер
            GraphicsPath myGraphicsPath = new GraphicsPath();
            // Задаем координаты точек первой кривой (корпус)
            Point[] myPointArray1 = { new Point(110, 300),  //A
new Point(120, 320), new Point(200, 325),                   //B,C
new Point(300, 320), new Point(428, 320),                   //D,E
new Point(430, 318), new Point(460, 297),                   //F,G
new Point(463, 294), new Point(566, 275),                   //H,J
new Point(570, 270), new Point(463, 289)};                  //Z,O
            // Добавляем кривую в контейнер
            myGraphicsPath.AddCurve(myPointArray1);
            // Выводим корпус
            g.FillPath(pic, myGraphicsPath);
            // Задаем координаты точек второй и третьей кривых (мачты)
            GraphicsPath myGraphicsPath2 = new GraphicsPath();
            Point[] myPointArray2 = { new Point(350, 50),   //A
new Point(365, 283), new Point(372, 284),                   //B,C
new Point(355, 50) };                                       //D
            // Добавляем кривую в контейнер
            myGraphicsPath2.AddCurve(myPointArray2);
            Point[] myPointArray3 = { new Point(220, 60),   //A
new Point(235, 283), new Point(242, 284),                   //B,C
new Point(225, 60) };                                       //D
            // Добавляем кривую в контейнер
            myGraphicsPath2.AddCurve(myPointArray3);
            // Выводим мачты
            g.FillPath(pic, myGraphicsPath2);
            // Задаем координаты парусов
            GraphicsPath myGraphicsPath3 = new GraphicsPath();
            Point[] myPointArray4 = { new Point(350, 50),   //A
new Point(420, 160), new Point(413, 245),                   //B,C
new Point(415, 247), new Point(480, 250),                   //D,E
 new Point(570, 270) };                                     //F
            // Добавляем кривую в контейнер
            myGraphicsPath3.AddCurve(myPointArray4);
            g.FillPath(pic2, myGraphicsPath3);
            GraphicsPath myGraphicsPath4 = new GraphicsPath();
            Point[] myPointArray5 = { new Point(350, 50),   //A
new Point(394, 180), new Point(382, 259),                   //B,C
new Point(385, 261), new Point(428, 264),                   //D,E
 new Point(463, 289) };                                     //F
            // Добавляем кривую в контейнер
            myGraphicsPath4.AddCurve(myPointArray5);
            // Выводим паруса
            g.FillPath(pic2, myGraphicsPath4);
            // Задаем координаты больших парусов
            GraphicsPath myGraphicsPath5 = new GraphicsPath();
            Point[] myPointArray6 = { new Point(359, 285),  //A
new Point(362, 230), new Point(355, 90),                    //B,C
new Point(355,90),
new Point(300, 73), new Point(300, 73),                     //D,E
new Point(290, 185), new Point(253, 274),                   //F,G
new Point(253, 274),
new Point(243, 274), new Point(243, 278) };                 //H,J
            // Добавляем кривую в контейнер
            myGraphicsPath5.AddCurve(myPointArray6);

            GraphicsPath myGraphicsPath6 = new GraphicsPath();
            Point[] myPointArray7 = { new Point(232, 287),  //A
new Point(232, 230), new Point(225, 95),                    //B,C
new Point(225,95),
new Point(179, 78), new Point(179, 78),                     //D,E
new Point(172, 185), new Point(124, 278),                   //F,G
new Point(124, 278),
new Point(114, 278), new Point(114, 282) };                 //H,J
            // Добавляем кривую в контейнер
            myGraphicsPath6.AddCurve(myPointArray7);
            // Выводим паруса
            g.FillPath(pic2, myGraphicsPath5);
            g.FillPath(pic2, myGraphicsPath6);


            //рисуем вымпел
            g.DrawLine(line2, 222, 58, 220, 33);
            g.DrawLine(line3, 220, 33, 216, 49);

            //РИСУЕМ МОРЕ

            //рисуем волны

            GraphicsPath myGraphicsPath7 = new GraphicsPath();
            Point[] myPointArray9 = { new Point(130, 335),  //A
new Point(150, 335), new Point(200, 328),                   //B,C
new Point(250, 335), new Point(270, 335),                   //D,E
new Point(270, 335), new Point(250, 340),                   //F,G
new Point(200, 335), new Point(150, 340),                   //H,J
new Point(133, 337)};                                       //Z
            // Добавляем кривую в контейнер
            myGraphicsPath7.AddCurve(myPointArray9);
            g.FillPath(pic, myGraphicsPath7);

            GraphicsPath myGraphicsPath9 = new GraphicsPath();
            Point[] myPointArray11 = { new Point(330, 335),  //A
new Point(350, 335), new Point(400, 328),                   //B,C
new Point(450, 335), new Point(470, 335),                   //D,E
new Point(470, 335), new Point(450, 340),                   //F,G
new Point(400, 335), new Point(350, 340),                   //H,J
new Point(333, 337)};                                       //Z
            // Добавляем кривую в контейнер
            myGraphicsPath9.AddCurve(myPointArray11);
            g.FillPath(pic, myGraphicsPath9);
            GraphicsPath myGraphicsPath8 = new GraphicsPath();
            Point[] myPointArray10 = { new Point(230, 355),  //A
new Point(250, 355), new Point(300, 348),                   //B,C
new Point(350, 355), new Point(370, 355),                   //D,E
new Point(370, 355), new Point(350, 360),                   //F,G
new Point(300, 355), new Point(250, 360),                   //H,J
new Point(233, 357)};                                       //Z
            // Добавляем кривую в контейнер
            myGraphicsPath8.AddCurve(myPointArray10);
            g.FillPath(pic, myGraphicsPath8);
            GraphicsPath myGraphicsPath12 = new GraphicsPath();
            Point[] myPointArray12 = { new Point(30, 355),  //A
new Point(50, 355), new Point(100, 348),                   //B,C
new Point(150, 355), new Point(170, 355),                   //D,E
new Point(170, 355), new Point(150, 360),                   //F,G
new Point(100, 355), new Point(50, 360),                   //H,J
new Point(33, 357)};                                       //Z
            // Добавляем кривую в контейнер
            myGraphicsPath12.AddCurve(myPointArray12);
            g.FillPath(pic, myGraphicsPath12);
            GraphicsPath myGraphicsPath13 = new GraphicsPath();
            Point[] myPointArray13 = { new Point(430, 355),  //A
new Point(450, 355), new Point(500, 348),                   //B,C
new Point(550, 355), new Point(570, 355),                   //D,E
new Point(570, 355), new Point(550, 360),                   //F,G
new Point(500, 355), new Point(450, 360),                   //H,J
new Point(433, 357)};                                       //Z
            // Добавляем кривую в контейнер
            myGraphicsPath13.AddCurve(myPointArray13);
            g.FillPath(pic, myGraphicsPath13);
            GraphicsPath myGraphicsPath14 = new GraphicsPath();
            Point[] myPointArray14 = { new Point(480, 315),  //A
new Point(500, 315), new Point(550, 308),                   //B,C
new Point(600, 315), new Point(620, 315),                   //D,E
new Point(620, 315), new Point(600, 320),                   //F,G
new Point(550, 315), new Point(500, 320),                   //H,J
new Point(483, 317)};                                       //Z
            // Добавляем кривую в контейнер
            myGraphicsPath14.AddCurve(myPointArray14);
            g.FillPath(pic, myGraphicsPath14);
            GraphicsPath myGraphicsPath15 = new GraphicsPath();
            Point[] myPointArray15 = { new Point(-20, 315),  //A
new Point(0, 315), new Point(50, 308),                   //B,C
new Point(100, 315), new Point(120, 315),                   //D,E
new Point(120, 315), new Point(100, 320),                   //F,G
new Point(50, 315), new Point(0, 320),                   //H,J
new Point(-17, 317)};                                       //Z
            // Добавляем кривую в контейнер
            myGraphicsPath15.AddCurve(myPointArray15);
            g.FillPath(pic, myGraphicsPath15);
            
            // Рисуем чайку
            int x = 400; int y = 50;
            g.FillPolygon(pic, new Point[] {
new Point(x,y),new Point(x-7,y-2),
new Point(x-14,y+6),new Point(x-7,y+2),
new Point(x+1,y+2),new Point(x+6,y-1),
new Point(x+13,y),new Point(x+6,y-4)
});
            x = 480; y = 110;
            g.FillPolygon(pic, new Point[] {
new Point(x,y),new Point(x-7,y-2),
new Point(x-14,y+6),new Point(x-7,y+2),
new Point(x+1,y+2),new Point(x+6,y-1),
new Point(x+13,y),new Point(x+6,y-4)
});
        }

        private void Form1_Click(object sender, EventArgs e)
        {
            // Создаем графический контекст формы
            Graphics g = this.CreateGraphics();            
            // Рисуем чайку
            int x = MousePosition.X - this.Left;
            int y = MousePosition.Y - this.Top - 20;
            g.FillPolygon(Brushes.Black, new Point[] {
new Point(x,y),new Point(x-7,y-2),
new Point(x-14,y+6),new Point(x-7,y+2),
new Point(x+1,y+2),new Point(x+6,y-1),
new Point(x+13,y),new Point(x+6,y-4)
});
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
