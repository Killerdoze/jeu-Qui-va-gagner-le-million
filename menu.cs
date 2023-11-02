using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;
using System.Diagnostics;



namespace GamebigData
{
    public partial class menu : Form
    {
        SoundPlayer player = new SoundPlayer(@"C:\Users\star store\Desktop\bigdata\wlc.wav");
        
        public menu()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
            player.Stop();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void menu_Load(object sender, EventArgs e)
        {
          

            // Jouez le son
            player.PlayLooping();
        }

        private void bunifuFlatButton3_Click(object sender, EventArgs e)
        {
            this.Close();
            player.Stop();
        }

        private void label1_MouseMove(object sender, MouseEventArgs e)
        {
            label1.BackColor=Color.White;
        }

        private void label1_MouseLeave(object sender, EventArgs e)
        {
            label1.BackColor = Color.FromArgb(68, 62, 103);
        }

        private void label1_Click(object sender, EventArgs e)
        {
            player.Stop();
            label3.Visible = true;
            label1.Visible=false;
        }

        private void label3_Click(object sender, EventArgs e)
        {
            player.Play();
            label3.Visible = false;
            label1.Visible = true;
        }

        private void label3_MouseMove(object sender, MouseEventArgs e)
        {
            label3.BackColor = Color.White;

        }

        private void label3_MouseLeave(object sender, EventArgs e)
        {
            label3.BackColor = Color.FromArgb(68, 62, 103);

        }

        private void option2_MouseMove(object sender, MouseEventArgs e)
        {
           
        }

        private void bunifuFlatButton1_MouseMove(object sender, MouseEventArgs e)
        {
            
        }

        private void bunifuFlatButton2_MouseMove(object sender, MouseEventArgs e)
        {
           
        }

        private void bunifuFlatButton3_MouseMove(object sender, MouseEventArgs e)
        {
           
        }

        private void option2_Click(object sender, EventArgs e)
        {
            player.Stop();
            this.Hide();
            Form1 form = new Form1();
            form.ShowDialog();

        }

        private void bunifuFlatButton2_Click(object sender, EventArgs e)
        {
            Process.Start("https://www.xbox.com/fr-fr/play/gallery/all-games");
        }

        private void label5_MouseMove(object sender, MouseEventArgs e)
        {
            label5.Font = new Font(label5.Font, FontStyle.Bold);
            label5.ForeColor = Color.Gold;
        }

        private void label5_MouseLeave(object sender, EventArgs e)
        {
            label5.Font = new Font(label5.Font, FontStyle.Regular);
            label5.ForeColor = Color.Gray;
            label6.Font = new Font(label6.Font, FontStyle.Regular);
            label6.ForeColor = Color.Gray;
            label7.Font = new Font(label7.Font, FontStyle.Regular);
            label7.ForeColor = Color.Gray;
            label8.Font = new Font(label8.Font, FontStyle.Regular);
            label8.ForeColor = Color.Gray;
        }

        private void label6_MouseLeave(object sender, EventArgs e)
        {
            label5.Font = new Font(label5.Font, FontStyle.Regular);
            label5.ForeColor = Color.Gray;
            label6.Font = new Font(label6.Font, FontStyle.Regular);
            label6.ForeColor = Color.Gray;
            label7.Font = new Font(label7.Font, FontStyle.Regular);
            label7.ForeColor = Color.Gray;
            label8.Font = new Font(label8.Font, FontStyle.Regular);
            label8.ForeColor = Color.Gray;
        }

        private void label6_MouseMove(object sender, MouseEventArgs e)
        {
            label5.Font = new Font(label5.Font, FontStyle.Bold);
            label5.ForeColor = Color.Gold;
            label6.Font = new Font(label6.Font, FontStyle.Bold);
            label6.ForeColor = Color.Gold;
        
    }

        private void label7_MouseMove(object sender, MouseEventArgs e)
        {
            label5.Font = new Font(label5.Font, FontStyle.Bold);
            label5.ForeColor = Color.Gold;
            label6.Font = new Font(label6.Font, FontStyle.Bold);
            label6.ForeColor = Color.Gold;
            label7.Font = new Font(label7.Font, FontStyle.Bold);
            label7.ForeColor = Color.Gold;
        }

        private void label7_MouseLeave(object sender, EventArgs e)
        {
            label5.Font = new Font(label5.Font, FontStyle.Regular);
            label5.ForeColor = Color.Gray;
            label6.Font = new Font(label6.Font, FontStyle.Regular);
            label6.ForeColor = Color.Gray;
            label7.Font = new Font(label7.Font, FontStyle.Regular);
            label7.ForeColor = Color.Gray;
            label8.Font = new Font(label8.Font, FontStyle.Regular);
            label8.ForeColor = Color.Gray;
        }

        private void label8_MouseMove(object sender, MouseEventArgs e)
        {
            label5.Font = new Font(label5.Font, FontStyle.Bold);
            label5.ForeColor = Color.Gold;
            label6.Font = new Font(label6.Font, FontStyle.Bold);
            label6.ForeColor = Color.Gold;
            label7.Font = new Font(label7.Font, FontStyle.Bold);
            label7.ForeColor = Color.Gold;
            label8.Font = new Font(label8.Font, FontStyle.Bold);
            label8.ForeColor = Color.Gold;
        
    }

        private void label8_MouseLeave(object sender, EventArgs e)
        {
            label5.Font = new Font(label5.Font, FontStyle.Regular);
            label5.ForeColor = Color.Gray;
            label6.Font = new Font(label6.Font, FontStyle.Regular);
            label6.ForeColor = Color.Gray;
            label7.Font = new Font(label7.Font, FontStyle.Regular);
            label7.ForeColor = Color.Gray;
            label8.Font = new Font(label8.Font, FontStyle.Regular);
            label8.ForeColor = Color.Gray;
        }

        private void label5_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Merci de nos aider à ameliorer notre application ! \nNous Sommes Vraiment désolé nous allons faire nos meilleurs pour atteindre vos besoins . ", "Note", MessageBoxButtons.OK, MessageBoxIcon.Information);
            groupBox1.Enabled=false;
        }

        private void label6_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Merci de nos aider à ameliorer notre application ! \nNous Sommes désolé nous allons ameliorer notre application . ", "Note", MessageBoxButtons.OK, MessageBoxIcon.Information);
            groupBox1.Enabled = false;

        }

        private void label7_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Merci de nos aider à ameliorer notre application ! \nNous Sommes Trés heureux d'avoir votre impression . ", "Note", MessageBoxButtons.OK, MessageBoxIcon.Information);
            groupBox1.Enabled = false;

        }

        private void label8_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Merci de nos aider à ameliorer notre application ! \nSuper ! Nous Sommes trés heureux d'aittendre vos besoins correctement . ", "Note", MessageBoxButtons.OK, MessageBoxIcon.Information);
            groupBox1.Enabled = false;

        }

        private void button4_Click(object sender, EventArgs e)
        {
            bunifuCards1.Visible=false;
        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            bunifuCards1.Visible = true;
        }
    }
}
