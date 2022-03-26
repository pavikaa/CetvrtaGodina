using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OPLV2
{
    public partial class Form1 : Form
    {
        Point mStartPoint, mCurrentPoint;
        bool bMouseDown;

        Graphics mGraphicsHelper;

        Elipsa elip;
        Kruznica circle;
        Linija line;
        Pravokutnik rectangle;
        Poligon poly;


        List<Elipsa> allElip = new List<Elipsa>();
        List<Kruznica> allCirc = new List<Kruznica>();
        List<Linija> allLine = new List<Linija>();
        List<Pravokutnik> allRect = new List<Pravokutnik>();
        List<Poligon> allPoly = new List<Poligon>();


        public Form1()
        {

            InitializeComponent();
        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            this.mStartPoint = e.Location;
            this.mCurrentPoint = Point.Empty;
            this.bMouseDown = true;
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            if (this.bMouseDown)
            {
                this.mCurrentPoint = e.Location;
                this.Invalidate();
            }

        }

        private void Form1_MouseUp(object sender, MouseEventArgs e)
        {
            this.bMouseDown = false;
            if (!allElip.Contains(elip) && elip != null)
                allElip.Add(elip);
            if (!allCirc.Contains(circle) && circle != null)
                allCirc.Add(circle);
            if (!allLine.Contains(line) && line != null)
                allLine.Add(line);
            if (!allRect.Contains(rectangle) && rectangle != null)
                allRect.Add(rectangle);
            if (!allPoly.Contains(poly) && poly != null)
                allPoly.Add(poly);
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            if (this.bMouseDown)
            {
                foreach (Elipsa ellip in allElip)
                    ellip.drawGrafObj();
                foreach (Kruznica circle in allCirc)
                    circle.drawGrafObj();
                foreach (Linija line in allLine)
                    line.drawGrafObj();
                foreach (Pravokutnik rect in allRect)
                    rect.drawGrafObj();
                foreach (Poligon poly in allPoly)
                    poly.drawGrafObj();

                Color color = Color.Black;
                switch (gbColor.Controls.OfType<RadioButton>().Where(x => x.Checked).FirstOrDefault().Name)
                {
                    case "rbBlack":
                        color = Color.Black;
                        break;
                    case "rbBlue":
                        color = Color.Blue;
                        break;
                    case "rbRed":
                        color = Color.Red;
                        break;
                }
                switch (gbObject.Controls.OfType<RadioButton>().Where(x => x.Checked).FirstOrDefault().Name)
                {
                    case "rbEllip":
                        elip = new Elipsa(mStartPoint, mCurrentPoint, mGraphicsHelper);
                        elip.setColor(color);
                        elip.drawGrafObj();
                        break;
                    case "rbCircle":
                        circle = new Kruznica(mStartPoint, mCurrentPoint, mGraphicsHelper);
                        circle.setColor(color);
                        circle.drawGrafObj();
                        break;
                    case "rbLine":
                        line = new Linija(mStartPoint, mCurrentPoint, mGraphicsHelper);
                        line.setColor(color);
                        line.drawGrafObj();
                        break;
                    case "rbSquare":
                        rectangle = new Pravokutnik(mStartPoint, mCurrentPoint, mGraphicsHelper);
                        rectangle.setColor(color);
                        rectangle.drawGrafObj();
                        break;
                    case "rbPoly":
                        poly = new Poligon(mCurrentPoint, mGraphicsHelper);
                        poly.setColor(color);
                        poly.drawGrafObj();
                        break;
                }
            }
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            mGraphicsHelper = this.CreateGraphics();
        }
    }
    class GrafObj
    {
        protected Color mColor;
        protected Point mStartPoint;

        protected int PEN_WIDTH = 1;

        public void setColor(Color color)
        {
            this.mColor = color;
        }

        public Color getColor()
        {
            return this.mColor;
        }
        public virtual void drawGrafObj()
        {

        }
    }
    class Linija : GrafObj
    {
        protected Point mCurrentPoint;
        protected Graphics mGraphicsHelper;
        public Linija(Point mStartPoint, Point mCurrentPoint, Graphics mGraphicsHelper)
        {
            this.mStartPoint = mStartPoint;
            this.mCurrentPoint = mCurrentPoint;
            this.mGraphicsHelper = mGraphicsHelper;
        }
        public override void drawGrafObj()
        {
            mGraphicsHelper.DrawLine(new Pen(this.mColor, this.PEN_WIDTH), this.mStartPoint, this.mCurrentPoint);
        }
    }
    class Pravokutnik : Linija
    {
        public Pravokutnik(Point mStartPoint, Point mCurrentPoint, Graphics mGraphicsHelper) : base(mStartPoint, mCurrentPoint, mGraphicsHelper) { }

        public override void drawGrafObj()
        {
            mGraphicsHelper.DrawRectangle(new Pen(this.mColor, this.PEN_WIDTH), this.mStartPoint.X, this.mStartPoint.Y, this.mCurrentPoint.X - this.mStartPoint.X, this.mCurrentPoint.Y - this.mStartPoint.Y);
        }
    }
    class Poligon : GrafObj
    {
        protected Graphics mGraphicsHelper;
        public Poligon(Point mStartPoint, Graphics mGraphicsHelper)
        {
            this.mGraphicsHelper = mGraphicsHelper;
            this.mStartPoint = mStartPoint;
        }
        public override void drawGrafObj()
        {
            var shape = new PointF[6];
            var r = 100;
            for (int i = 0; i < 6; i++)
            {
                shape[i] = new PointF(
                    this.mStartPoint.X + r * (float)Math.Cos(i * 60 * Math.PI / 180f),
                    this.mStartPoint.Y + r * (float)Math.Sin(i * 60 * Math.PI / 180f));
            }
            this.mGraphicsHelper.DrawPolygon(new Pen(this.mColor, this.PEN_WIDTH), shape);
        }
    }
    class Kruznica : GrafObj
    {
        protected Point mCurrentPoint;
        protected Graphics mGraphicsHelper;
        public Kruznica(Point mStartPoint, Point mCurrentPoint, Graphics mGraphicsHelper)
        {
            this.mStartPoint = mStartPoint;
            this.mCurrentPoint = mCurrentPoint;
            this.mGraphicsHelper = mGraphicsHelper;
        }
        public override void drawGrafObj()
        {
            mGraphicsHelper.DrawEllipse(new Pen(this.mColor, this.PEN_WIDTH), this.mStartPoint.X, this.mStartPoint.Y, this.mCurrentPoint.X - this.mStartPoint.X, this.mCurrentPoint.X - this.mStartPoint.X);
        }
    }
    class Elipsa : Kruznica
    {
        public Elipsa(Point mStartPoint, Point mCurrentPoint, Graphics mGraphicsHelper) : base(mStartPoint, mCurrentPoint, mGraphicsHelper)
        {
        }
        public override void drawGrafObj()
        {
            mGraphicsHelper.DrawEllipse(new Pen(this.mColor, this.PEN_WIDTH), this.mStartPoint.X, this.mStartPoint.Y, this.mCurrentPoint.X - this.mStartPoint.X, this.mCurrentPoint.Y - this.mStartPoint.Y);
        }
    }
}
