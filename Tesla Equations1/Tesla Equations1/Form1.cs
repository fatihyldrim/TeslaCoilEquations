using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tesla_Equations1
{
    public partial class Tesla : Form
    {
        public Tesla()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e) // This part is to calculate LC Frequency
        {
            double F1, F2, F3;
            F1 = Convert.ToDouble(textBox1.Text);   // Inductance L = F1
            F2 = Convert.ToDouble(textBox2.Text);   // Capaticance C = F2
            F3 = 1 / (2000 * 3.14159 * Math.Sqrt(F1 * F2 * Math.Pow(10, -9))); // Resonant frequency F = F3
            
            textBox3.Text = Math.Round(F3, 4).ToString();  // Write the F3 in textBox3' text

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click_1(object sender, EventArgs e) // This Part is to calculate Primary Coil
        {
            double D1, D0, N, S, W, A, L, LW;   // All parameters is same with the Primary Coil Design
            D1 = Convert.ToDouble(textBox4.Text);
            N = Convert.ToDouble(textBox5.Text);
            W = Convert.ToDouble(textBox6.Text);
            S = Convert.ToDouble(textBox7.Text);

            A = (D1 / 25.4 + N * (S + W) / 25.4) / 2;
            D0 = 2 * (D1 / 2 + N * (S + W));
            L = (N * N * A * A) / (30 * A - 11 * D1 / 25.4);    
            LW = 3.14159 * D0 * N / 2000;
            textBox8.Text = Math.Round(L, 4).ToString();
            textBox10.Text = Math.Round(D0, 4).ToString();
            textBox9.Text = Math.Round(LW, 4).ToString();

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label23_Click(object sender, EventArgs e)
        {

        }

        private void label27_Click(object sender, EventArgs e)
        {

        }

        private void label31_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)  // This parth is to calculate MMC
        {
            double m1, m2, m3, m4, m5, m6;
            m1 = Convert.ToDouble(textBox11.Text);      // Capacitance of each capacitor = m1
            m2 = Convert.ToDouble(textBox12.Text);      // Voltage of the each capacitor = m2
            m3 = Convert.ToDouble(textBox13.Text);      // Capacitor per String          = m3
            m4 = Convert.ToDouble(textBox14.Text);      // Strings in parallel           = m4

            m6 = m2 * m3;                               //  Total Voltage                = m6
            m5 = (m1 / m3) * m4;                        //  Total Capacitance            = m5

            textBox16.Text = Math.Round(m6, 4).ToString();       
            textBox15.Text = Math.Round(m5, 4).ToString();
                
        }

        private void textBox14_TextChanged(object sender, EventArgs e)
        {

        }

        private void label47_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)              // This part is to calculate Secondary Coil 
        {
            double S1, S2, S3, S4, S5, S6, S7;

            S1 = Convert.ToDouble(textBox23.Text);                          // Diameter  (D) = s1
            S2 = Convert.ToDouble(textBox22.Text);                          // Number of Turn (N) = s2
            S3 = Convert.ToDouble(textBox21.Text);                          // Wire Diameter (W) =s3
            S4 = Convert.ToDouble(textBox20.Text);                          // Turn Spacing (S) = s4

            S7 = S2 * (S3 + S4);                                            // Height (H) = s7
            S6 = 3.14159 * S1 * S2 / 1000;                                  // Length of Wire = s6
            S5 = (S2 * S2 * S1 * S1 / 2580.64) / (9 * S1 / 50.8 + 10 * S7 / 25.4);  // Inductance (L) =s5

            textBox17.Text = Math.Round(S7, 4).ToString();
            textBox18.Text = Math.Round(S6, 4).ToString();
            textBox19.Text = Math.Round(S5, 4).ToString();

        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)               // This part is to calculate Sphere Topload
        {
            double A1, A2;

            A1 = Convert.ToDouble(textBox25.Text);                          // diameter of Sphere topload = A1

            A2 = Math.Pow(10, 12) * ((1.01 * A1 / 1000) / (9 * Math.Pow(10, 9)));         // capacitance of Sphere topload = A2

            textBox24.Text = Math.Round(A2, 4).ToString();                  
        }

        private void tabPage7_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)               // This part is to calculate Toroid Topload
        {
            double t1, t2, t3;

            t1 = Convert.ToDouble(textBox28.Text);                           // diameter 1 of Toroid Topload = t1
            t2 = Convert.ToDouble(textBox27.Text);                           // diameter 2 of Toroid Topload = t2

            t3 = 0.055 * (1.2781 - t2 / t1) * Math.Sqrt(3.1415 * t2 * (t1 - t2));    // Capacitance of Toroid Topload 

            textBox26.Text = Math.Round(t3, 4).ToString();

        }
    }
}
