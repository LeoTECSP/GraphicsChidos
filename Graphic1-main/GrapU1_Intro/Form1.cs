using System;
using System.Windows.Forms;
//Librería para graficar en 2D
using System.Drawing.Drawing2D;
using System.Drawing;
using System.Security.Cryptography.X509Certificates;
using System.Drawing.Text;

namespace GrapU1_Intro
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
  
        }

        private void Form1_Click(object sender, EventArgs e)
        {

            Color color1, color2;
            color1 = Color.FromArgb(26, 184, 179);
            color2 = Color.FromArgb(177, 26, 184);

            //Crear rectangulo - el rectángulo solo lo usa de referencia para el degradado (area que va a abarcar el color
            Rectangle rectangle = new Rectangle(0, 0, 100, 250); //00 es para que siempre inicia el 0,0
            //Degradado que implementqa un color 
            LinearGradientBrush linear = new LinearGradientBrush( rectangle, color1, color2,90);
            Pen pen = new Pen(linear, 30);

            //Matriz de puntos
            Point[] point = new Point[]
            {
                //new Point(100,10),
                //new Point(50,100),
                //new Point(150,100),
                //new Point(100,10),
                
                
                new Point(10,100),
                new Point(100,100),
                new Point(100,200),
                new Point(10,100)
            };
          
            
            //Crear una línea.
            //Para graficar necesito una librería en 2D
            //Lo que me hace más facil programar son los frameworks: .NET, tiene
            //muchas clases que acompaña al lenguaje
            //Valores hexadecimales es de punto flotante

            //Graphics graphics = new Graphics -esto sería si crearamos un objeto

            //Coordenadas 0,0 están ahí arribas

            //Forma para graficar, es local porque esto solo funciona en el evento clic del formulario
            //Vamos a crear una variable y solo se usan los recursos de graphics cuando le pique al clic

            //Lineas con puntos
            using (Graphics graphics = CreateGraphics())
            {
     

                //point es para maandar como x , y
                //mando color, punto a, punto b

                graphics.DrawLine(pen,new Point(10,10) ,new Point(40,40));
                graphics.DrawLines(pen, point);
               
            }


         


        }
    }
}
