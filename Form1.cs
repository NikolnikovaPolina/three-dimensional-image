using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2eab
{
    public partial class Form1 : Form
    {

        private Color brush = Color.RoyalBlue;

        public Form1()
        {
            InitializeComponent();
        }

        private void buttonPaint_Click(object sender, EventArgs e)
        {
            Scene s = new Scene(figureRepresentation.Height, figureRepresentation.Width);
            s.brush = brush;
            s.addCone(Double.Parse(radius.Text), Double.Parse(height.Text));
            s.addCamera(new Camera(new Point(textCameraPosition.Text), new Point(textCameraDirection.Text).minus(new Point(textCameraPosition.Text)), 
                (double)textViewingAngle.Value));
            s.lightPoint = new Point(lightingCoordinates.Text);
            s.Render();
            figureRepresentation.Image = s.pic;
        }

        private void buttonColor_Click(object sender, EventArgs e)
        {
            colorDialog.ShowDialog();
            brush = colorDialog.Color;
            buttonPaint_Click(sender, e);
        }

        private void FormMain_Paint(object sender, PaintEventArgs e)
        {
            buttonPaint_Click(sender, e);
        }
    }
}