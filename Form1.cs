using System.Security.Cryptography.X509Certificates;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        private Dronecontroller dronecontroller;
        public Form1()
        {
            InitializeComponent();
            dronecontroller = new Dronecontroller("DJI Phantom");

        }

        private void button1_Click(object sender, EventArgs e)
        {
            dronecontroller.takeoff();
            MessageBox.Show("Araç kalkýyor");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            dronecontroller.land();
            MessageBox.Show("Araç aþaðýya iniyor");


        }

        private void button3_Click(object sender, EventArgs e)
        {

            dronecontroller.fly(Convert.ToInt32(textBox1.Text));

            MessageBox.Show("þarjýnýz"  + textBox1.Text +  "eksildi");
                    
        }
      
    }
}