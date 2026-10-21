using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace GUI // <-- OJO: Asegúrate de que esto diga el mismo nombre de tu proyecto
{
    public class BotonRedondeado : Button
    {
        private int borderRadius = 20;

        public BotonRedondeado()
        {
            this.FlatStyle = FlatStyle.Flat;
            this.FlatAppearance.BorderSize = 0;
            this.BackColor = Color.MediumSlateBlue;
            this.ForeColor = Color.White;
        }

        protected override void OnPaint(PaintEventArgs pevent)
        {
            base.OnPaint(pevent);

            // Dibujar la superficie del botón
            GraphicsPath path = new GraphicsPath();
            path.AddArc(0, 0, borderRadius, borderRadius, 180, 90);
            path.AddArc(this.Width - borderRadius, 0, borderRadius, borderRadius, 270, 90);
            path.AddArc(this.Width - borderRadius, this.Height - borderRadius, borderRadius, borderRadius, 0, 90);
            path.AddArc(0, this.Height - borderRadius, borderRadius, borderRadius, 90, 90);
            path.CloseFigure();

            this.Region = new Region(path);
        }
    }
}