using System;
using System.Windows.Forms;
using WinLib;               // using WinLib !!!!!!!!!!!!!

namespace Screw
{
    public partial class aForm1 : aForm
    {
        // DATA !!!
        double D = 0;   // Наружный диаметр шнека
        double d = 0;   // Внутренний диаметр шнека
        double S = 0;   // Шаг винтовой линии шнека

        double U =  0;  // Длина наружной винтовой линии
        double u =  0;  // Длина внутренней винтовой линии
        double b =  0;  // Ширина винтовой поверхности
        double R1 = 0;  // Наружный радиус кольца
        double D1 = 0;  // Наружный диаметр кольца
        double r1 = 0;  // Внутренний радиус кольца
        double d1 = 0;  // Внутренний диаметр кольца
        double A =  0;  // Угол разреза кольца


        // КОНСТРУКТОР !!!
        public aForm1()
        {
            InitializeComponent();
            InitializeDynamicComponent();
        }   // end of - КОНСТРУКТОР public Form1()


        // pict_01_MouseClick - т.е. клик на картинке !!!
        void pict_01_MouseClick(object sender, MouseEventArgs e)
        {
            if ((TBox_1.val == 0) || (TBox_2.val == 0) || (TBox_3.val == 0))
            {
                Result_1.BackColor = System.Drawing.Color.LightPink;
                Result_1.Text = "Error !\ndata can't == 0";
                return;
            }
            if (TBox_2.val >= TBox_1.val)
            {   
                Result_1.BackColor = System.Drawing.Color.LightPink;
                Result_1.Text = "Error !\nd can't >= D";
                TBox_2.Text = "";
                TBox_2.Focus();
                return;
            }

            D = TBox_1.val;
            d = TBox_2.val;
            S = TBox_3.val;
            
            U = Math.Sqrt(Trig.PiPow2 * D*D + S*S); // OK
            u = Math.Sqrt(Trig.PiPow2 * d*d + S*S); // OK
            b = (D - d) / 2;                        // OK
            r1 = (b * u) / (U - u);                 // OK
            d1 = 2.0 * r1;                          // OK
            R1 = r1 + b;                            // OK
            D1 = 2.0 * R1;                          // OK
            A = 360.0 - ((180.0 * U) / (Trig.Pi * R1)); // OK

            Result_1.BackColor = System.Drawing.SystemColors.Info;
            Result_1.setText("D1 = ", D1, " мм",
                "\nd1 = ", d1, " мм",
                "\nA = ", A, " град.");
        }   // end of pict_01_MouseClick

    }       // end of - class Form1 : Form
}           // end of - namespace Screw
