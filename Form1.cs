namespace lab4inheritance
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btLOAD_Click(object sender, EventArgs e)
        {
            Pikachu pikachu = new Pikachu();
            lbNAME.Text = pikachu.Name();
            //add resource file
            pictureBox1.Image = lab4inheritance.Properties.Resources.pika;
        }

        private void btLOAD2_Click(object sender, EventArgs e)
        {
            Charmander charmander = new Charmander();
            lbNAME.Text = charmander.Name();
            pictureBox1.Image = lab4inheritance.Properties.Resources.Charmander1;
        }

        private void btLOAD3_Click(object sender, EventArgs e)
        {
            Entei entei = new Entei();
            lbNAME.Text = entei.Name();
            pictureBox1.Image = lab4inheritance.Properties.Resources.Entei;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Copperajah copperajah = new Copperajah();
            lbNAME.Text = copperajah.Name();
            pictureBox1.Image = lab4inheritance.Properties.Resources.Copperajah;
        }

        private void btLOAD4_Click(object sender, EventArgs e)
        {
            Palafin palafin = new Palafin();
            lbNAME.Text = palafin.Name();
            pictureBox1.Image = lab4inheritance.Properties.Resources.Palafin;
        }

        private void btLOAD5_Click(object sender, EventArgs e)
        {
            Growlithe growlithe = new Growlithe();
            lbNAME.Text= growlithe.Name();
            pictureBox1.Image = lab4inheritance.Properties.Resources.Growlithe;
        }
    }
}
