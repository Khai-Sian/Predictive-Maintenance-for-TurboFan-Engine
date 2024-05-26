using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.ComponentModel;

namespace Dashboard_UI
{
    public class ToggleButton: CheckBox
    {
        //button color
        private Color onBackColor = Color.MediumSlateBlue;
        private Color onToggleColor = Color.WhiteSmoke;
        private Color offBackColor = Color.Gray;
        private Color offToggleColor = Color.Gainsboro;

        public Color OnBackColor 
        { 
            get 
            { 
                return onBackColor; 
            } 
            set 
            { 
                onBackColor = value;
                this.Invalidate();
            } 
        }
        public Color OnToggleColor 
        {
            get
            {
                return onToggleColor;
            }
            set
            {
                onToggleColor = value;
                this.Invalidate();
            }
        }
        public Color OffBackColor 
        {
            get
            {
                return offBackColor;
            }
            set
            {
                offBackColor = value;
                this.Invalidate();
            }
        }
        public Color OffToggleColor {
            get
            {
                return offToggleColor;
            }
            set
            {
                offToggleColor = value;
                this.Invalidate();
            }
        }

        public override string Text 
        { 
            get 
            { 
                return base.Text; 
            } 
            set 
            { 

            } 
        }

        //Constructor
        public ToggleButton()
        {
            this.MinimumSize = new Size(45, 22);
        }

        //Method
        private GraphicsPath GetFigurePath()
        {
            int arcSize = this.Height - 1;
            Rectangle leftArc = new Rectangle(0, 0, arcSize, arcSize);
            Rectangle rightArc = new Rectangle(this.Width - arcSize - 2, 0, arcSize, arcSize);

            GraphicsPath path = new GraphicsPath();
            path.StartFigure();
            path.AddArc(leftArc, 90, 180);
            path.AddArc(rightArc, 270, 180);
            path.CloseFigure();

            return path;
        }

        /// <summary>
        /// draw button
        /// </summary>
        /// <param name="pevent"></param>
        protected override void OnPaint(PaintEventArgs pevent)
        {
            int toggleSize = this.Height - 5;
            pevent.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
            pevent.Graphics.Clear(this.Parent.BackColor);

            if (this.Checked) //ON
            {
                //Draw control surface
                pevent.Graphics.FillPath(new SolidBrush(OnBackColor), GetFigurePath());
                //Draw toggle
                pevent.Graphics.FillEllipse(new SolidBrush(OnToggleColor), 
                    new Rectangle(this.Width - this.Height + 1, 2, toggleSize, toggleSize));
            }
            else //OFF
            {
                //Draw control surface
                pevent.Graphics.FillPath(new SolidBrush(OffBackColor), GetFigurePath());
                //Draw toggle
                pevent.Graphics.FillEllipse(new SolidBrush(OffToggleColor),
                    new Rectangle(2, 2, toggleSize, toggleSize));
            }
        }
    }
}
