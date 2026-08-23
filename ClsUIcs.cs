using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyMathGame
{
    internal class ClsUIcs
    {
        public void ApplyQuestionAreaStyle(Control ctrl, int radius)
        {
            ctrl.BackColor = Color.FromArgb(25, 25, 25);
            ctrl.ForeColor = Color.White;

            GraphicsPath path = new GraphicsPath();
            path.AddArc(0, 0, radius, radius, 180, 90);
            path.AddArc(ctrl.Width - radius, 0, radius, radius, 270, 90);
            path.AddArc(ctrl.Width - radius, ctrl.Height - radius, radius, radius, 0, 90);
            path.AddArc(0, ctrl.Height - radius, radius, radius, 90, 90);
            path.CloseFigure();
            ctrl.Region = new Region(path);

            ctrl.Paint += (s, e) =>
            {
                e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;

               
               
                        
               
               

               
                using (Pen pen = new Pen(Color.FromArgb(50, 200, 200, 200), 2))
                {
                    e.Graphics.DrawPath(pen, path);
                }
            };
        }
        public void SetRoundedRegion(Control control, int radius)
        {
            GraphicsPath path = new GraphicsPath();
            path.StartFigure();
            path.AddArc(0, 0, radius, radius, 180, 90);
            path.AddArc(control.Width - radius, 0, radius, radius, 270, 90);
            path.AddArc(control.Width - radius, control.Height - radius, radius, radius, 0, 90);
            path.AddArc(0, control.Height - radius, radius, radius, 90, 90);
            path.CloseFigure();

            control.Region = new Region(path);
        }

        public void CustomizeProgressBar(ProgressBar pBar)
        {
            pBar.Style = ProgressBarStyle.Continuous;

            int radius = pBar.Height / 2;
            GraphicsPath path = new GraphicsPath();
            path.AddArc(0, 0, radius, radius, 180, 90);
            path.AddArc(pBar.Width - radius, 0, radius, radius, 270, 90);
            path.AddArc(pBar.Width - radius, pBar.Height - radius, radius, radius, 0, 90);
            path.AddArc(0, pBar.Height - radius, radius, radius, 90, 90);
            path.CloseFigure();
            pBar.Region = new Region(path);

            pBar.Paint += (s, e) =>
            {
                float percent = (float)pBar.Value / pBar.Maximum;
                int width = (int)(pBar.Width * percent);

                if (width > 0)
                {
                    using (LinearGradientBrush brush = new LinearGradientBrush(
                        new Rectangle(0, 0, width, pBar.Height),
                        Color.FromArgb(255, 215, 100), 
                        Color.FromArgb(190, 155, 85),  
                        LinearGradientMode.Vertical))
                    {
                        e.Graphics.FillRectangle(brush, 0, 0, width, pBar.Height);
                    }

                    using (Pen glowPen = new Pen(Color.FromArgb(100, 255, 255, 255), 1))
                    {
                        e.Graphics.DrawLine(glowPen, 0, 1, width, 1);
                    }
                }
            };
        }
        public void ApplyNumericStyle(NumericUpDown nm)
        {
            
            nm.BackColor = Color.FromArgb(25, 25, 25); 
            nm.ForeColor = Color.Gainsboro;           
            nm.BorderStyle = BorderStyle.None;        

           
            int radius = 15;
            GraphicsPath path = new GraphicsPath();
            path.AddArc(0, 0, radius, radius, 180, 90);
            path.AddArc(nm.Width - radius, 0, radius, radius, 270, 90);
            path.AddArc(nm.Width - radius, nm.Height - radius, radius, radius, 0, 90);
            path.AddArc(0, nm.Height - radius, radius, radius, 90, 90);
            path.CloseFigure();
            nm.Region = new Region(path);

            nm.Paint += (s, e) =>
            {
                e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
                using (Pen pen = new Pen(Color.FromArgb(70, 200, 200, 200), 1))
                {
                    e.Graphics.DrawPath(pen, path);
                }
            };
        }


        public void ApplyContainerStyle(Panel pnl,bool noresult=true)
        {
            int radius = 25; 

            GraphicsPath path = new GraphicsPath();
            path.AddArc(0, 0, radius, radius, 170, 90);
            path.AddArc(pnl.Width - radius, 0, radius, radius, 270, 90);
            path.AddArc(pnl.Width - radius, pnl.Height - radius, radius, radius, 0, 90);
            path.AddArc(0, pnl.Height - radius, radius, radius, 90, 90);
            path.CloseFigure();
            pnl.Region = new Region(path);

            pnl.Paint += (s, e) =>
            {
                e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;

                using (Pen pen = new Pen(Color.FromArgb(20, 20, 200, 200), 1))
                {
                    e.Graphics.DrawPath(pen, path);
                }
                if (noresult)
                {
                    pnl.BackColor = Color.FromArgb(15, 15, 15);

                    using (LinearGradientBrush lgb = new LinearGradientBrush(
                        new Rectangle(0, 0, pnl.Width, 20),
                        Color.FromArgb(10, 255, 255, 255),
                        Color.Transparent,
                        LinearGradientMode.Vertical))
                    {
                        e.Graphics.FillPath(lgb, path);
                    }
                }
            };
        }
    }
}
