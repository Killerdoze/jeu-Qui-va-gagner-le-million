using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;


namespace GamebigData
{

    public partial class Form1 : Form

    {

        Boolean verif = false;
        private string option;
        private int count = 6;
        private int count2 = 40;
        private int index = 0;
        List<int> generatedIndexes = new List<int>();
        Random rand = new Random();
        string[,] questions = new string[19, 7] {
    {"Quel type de service cloud permet aux clients d'installer ce qu'ils veulent sur l'infrastructure fournie ?", "IaaS", "PaaS", "SaaS", "Aucune des réponses ci-dessus", "1", @"C:\Users\star store\Desktop\bigdata\sound\1.wav"},
    {"Qu'est-ce qui est typiquement utilisé par les développeurs pour se concentrer sur l'écriture de leur code dans le cloud ?", "IaaS", "PaaS", "PaaS", "SaaS", "3", @"C:\Users\star store\Desktop\bigdata\sound\2.wav"},
    {"Quel est l'un des exemples de solution PaaS mentionnés dans le cours ?", "Force.com", "Azur", "Amazon", "Aucune des réponses ci-dessus", "1", @"C:\Users\star store\Desktop\bigdata\sound\3.wav"},
    {"Quel est le terme qui tire son nom du schéma représentant Internet comme un nuage dans les services informatiques ?", "Cloud computing", "Aucune des réponses ci-dessus", "PaaS", "SaaS", "4", @"C:\Users\star store\Desktop\bigdata\sound\4.wav"},
    {"Quels sont les trois types d'offres de services cloud mentionnés dans le cours ?", "Cloud Computing, PaaS, SaaS", "IaaS, PaaS, SaaS", "Infrastructure as a Service, Plateforme as a Service, Software as a Service", "Aucune de reponses ci-dessus", "1", @"C:\Users\star store\Desktop\bigdata\sound\5.wav"},
    {"Qu'est-ce que SaaS?", "Un type de bois utilisé en construction", "Un type d'ordinateur portable", "Un logiciel accessible via Internet", "Aucune des réponses ci-dessus", "3", @"C:\Users\star store\Desktop\bigdata\sound\6.wav"},
    {"Où les logiciels en mode SaaS sont-ils installés ?", "Sur votre ordinateur", "Sur des disques durs externes", "Sur des serveurs disposés dans un ou plusieurs datacenters dans le monde", "Aucune des réponses ci-dessus", "3", @"C:\Users\star store\Desktop\bigdata\sound\7.wav"},
    {"Pourquoi le cloud est-il si répandu?", "Il permet de créer son propre datacenter à moindre coût", "Il offre de nombreux avantages, notamment une flexibilité en termes de capacité", "Il permet de stocker des données sans connexion Internet", "Aucune des réponses ci-dessus", "2", @"C:\Users\star store\Desktop\bigdata\sound\9.wav"},
    {"Pourquoi les entreprises qui investissent dans un datacenter risquent-elles d'avoir une capacité de calcul et/ou de stockage surdimensionnée ou sous-dimensionnée?", "Parce qu'elles ne savent pas comment planifier leurs besoins", "Parce que les logiciels ne sont pas adaptés à leurs besoins", "Parce qu'elles ont des besoins qui varient au fil du temps", "Aucune des réponses ci-dessus", "2", @"C:\Users\star store\Desktop\bigdata\sound\8.wav"},
    {"Les fournisseurs de services cloud réputés offrent-ils des garanties en termes de fiabilité?", "Vrai","faux", "Cela dépend du fournisseur", "Aucune des réponses ci-dessus", "1", @"C:\Users\star store\Desktop\bigdata\sound\11.wav"},
    {"Les fournisseurs de services cloud ont-ils souvent des accès Internet de secours?","Vrai","faux", "Cela dépend du fournisseur", "Aucune des réponses ci-dessus", "1", @"C:\Users\star store\Desktop\bigdata\sound\12.wav"},
    {"Les solutions cloud sont-elles accessibles n'importe où? ", "Vrai", "Faux", "Cela dépend du du type de solution cloud","Aucune des réponses ci-dessus", "1", @"C:\Users\star store\Desktop\bigdata\sound\13.wav"},
    {"Qu'est-ce que l'AIaaS ?", "Artificial Intelligence as a Service", "Artificial Intelligence as a System", "Artificial Intelligence as a Software", "Artificial Intelligence as a Solution", "1", @"C:\Users\star store\Desktop\bigdata\sound\27.wav"},
    {"Quels types de besoins métiers peuvent être satisfaits grâce aux solutions cloud ?", "Les besoins en communication uniquement", "Les besoins en logistique uniquement", "Aucun besoin métier ne peut être satisfait grâce au cloud", "Tous les besoins métiers possibles", "4", @"C:\Users\star store\Desktop\bigdata\sound\23.wav"},
    {"Qui sont les principaux utilisateurs du cloud ?", "Les entreprises","les particuliers", "les gouvernements", "Les associations", "1", @"C:\Users\star store\Desktop\bigdata\sound\28.wav"},
    {"Qu'est-ce que l'IoE ?", "L'Internet of Everything", "L'Internet of Energy", "L'Internet of Entertainment","L'Internet of Experience", "1", @"C:\Users\star store\Desktop\bigdata\sound\16.wav"},
    {"Quel est l'un des exemples d'application de l'intelligence artificielle cité dans le cours ?", "Les voitures électriques", "Les outils de médecine prédictive", "Les logiciels de gestion de projet", "Les jeux vidéo", "2", @"C:\Users\star store\Desktop\bigdata\sound\19.wav"},
    {"Le cloud public est-il moins cher que le cloud privé?", "Vrai", "Faux", "Cela dépend des circonstances", "Aucune des réponses ci-dessus", "3", @"C:\Users\star store\Desktop\bigdata\sound\34.wav"},
    {"Que peut permettre l'Intelligence Artificielle (IA)?", "Aider à la vente en indiquant les meilleurs moments pour contacter un prospect","Optimiser la gestion financière d'une entreprise", "Optimiser les investissements en bourse en indiquant les meilleurs placements au meilleur moment", "Tout ce qui précède", "4", @"C:\Users\star store\Desktop\bigdata\sound\26.wav"},


};



        public Form1()
        {

            InitializeComponent();
            timer1.Start();
            timer2.Start();







        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            option1.Enabled = false;
            option2.Enabled = false;
            option3.Enabled = false;
            option4.Enabled = false;

            bunifuCards1.Visible = true;
            timer3.Stop();






        }

        private void bunifuFlatButton5_Click(object sender, EventArgs e)
        {
            bunifuCards1.Visible = false;
            timer3.Start();
            option1.Enabled = true;
            option2.Enabled = true;
            option3.Enabled = true;
            option4.Enabled = true;
        }

        private void bunifuFlatButton7_Click(object sender, EventArgs e)
        {
            timer3.Stop();
            this.Close();
            menu menu = new menu();
            menu.Show();

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            count--;
            if (count == 0)
            {

                label16.Visible = false;
                verif = true;
                button1.Enabled = true;
                button2.Enabled = true;
                button3.Enabled = true;
                button4.Enabled = true;
                option1.Enabled = true;
                option2.Enabled = true;
                option3.Enabled = true;
                option4.Enabled = true;
                MessageBox.Show("La jeu est commencée !", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);



            }
            else
            {
                label16.Text = count.ToString();
            }


        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            if (verif == true && index < 16)
            {
                int randIndex = 0;
                do
                {
                    randIndex = rand.Next(0, 17);
                } while (generatedIndexes.Contains(randIndex));
                generatedIndexes.Add(randIndex);
                option1.Enabled = true;
                option2.Enabled = true;
                option3.Enabled = true;
                option4.Enabled = true;
                string question = questions[randIndex, 0];
                string reponseA = questions[randIndex, 1];
                string reponseB = questions[randIndex, 2];
                string reponseC = questions[randIndex, 3];
                string reponseD = questions[randIndex, 4];
                string reponseCorrecte = questions[randIndex, 5];
                SoundPlayer player = new SoundPlayer(questions[randIndex, 6]);
                player.Play();
                txtboxquestion.Text = question;
                option1.Text = reponseA;
                option2.Text = reponseB;
                option3.Text = reponseC;
                option4.Text = reponseD;
                textBox1.Text = reponseCorrecte;
                verif = false;
                timer3.Start();
                rst.Visible = false;

            }

        }

        private void timer3_Tick(object sender, EventArgs e)
        {
            count2--;
            if (count2 == 0)
            {
                timer3.Stop();

                SoundPlayer player = new SoundPlayer(@"C:\Users\star store\Desktop\bigdata\sound\lose.wav");
                player.Play();
                MessageBox.Show("Le temps est finie!\nVous avez perdue", "Temps finie", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                this.Hide();
                menu menu = new menu();
                menu.ShowDialog();

            }
            else
            {
                btntmps.Text = count2.ToString();
                if (index == 15)
                {
                    rst.Visible = false;
                    pictureBox2.Visible = true;
                    label1.BackColor = Color.Gold;
                    timer3.Stop();
                    verif = false;
                    SoundPlayer playerwin = new SoundPlayer(@"C:\Users\star store\Desktop\bigdata\sound\win.wav");
                    playerwin.Play();
                    txtboxquestion.Text = "";
                    option1.Text = "";
                    option2.Text = "";
                    option3.Text = "";
                    option4.Text = "";
                    textBox1.Text = "";
                    btntmps.Text = "";
                    MessageBox.Show("vous avez gagner un million !", "WINNER", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Hide();
                    menu menu1 = new menu();
                    menu1.ShowDialog();
                }
                if (index == 1)
                {
                    label15.BackColor = Color.Green;
                }
                if (index == 2)
                {
                    label14.BackColor = Color.Green;
                }
                if (index == 3)
                {
                    label13.BackColor = Color.Green;
                }
                if (index == 4)
                {
                    label12.BackColor = Color.Green;
                }
                if (index == 5)
                {
                    label11.BackColor = Color.Green;
                }
                if (index == 6)
                {
                    label10.BackColor = Color.Green;
                }
                if (index == 7)
                {
                    label9.BackColor = Color.Green;
                }
                if (index == 8)
                {
                    label8.BackColor = Color.Green;
                }
                if (index == 9)
                {
                    label7.BackColor = Color.Green;
                }
                if (index == 10)
                {
                    label6.BackColor = Color.Green;
                }
                if (index == 11)
                {
                    label5.BackColor = Color.Green;
                }
                if (index == 12)
                {
                    label4.BackColor = Color.Green;
                }
                if (index == 13)
                {
                    label3.BackColor = Color.Green;
                }
                if (index == 14)
                {
                    label2.BackColor = Color.Green;
                }




            }
        }

        private void option1_Click(object sender, EventArgs e)
        {
            option = "1";
            if (option == textBox1.Text && index <= 15)
            {
                rst.Visible = true;
                SoundPlayer player = new SoundPlayer(@"C:\Users\star store\Desktop\bigdata\sound\shouting-yeah-7043 (1).wav");
                player.Play();
                timer2.Stop();
                count2 = 40;
                timer2.Start();
                verif = true;
                index++;

            }
            else
            {
                timer3.Stop();
                SoundPlayer player = new SoundPlayer(@"C:\Users\star store\Desktop\bigdata\sound\lose.wav");
                player.Play();
                MessageBox.Show("C'est faux !\nVous avez perdue", "Faux", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                timer2.Stop();

                this.Hide();
                menu menu = new menu();
                menu.ShowDialog();
            }
        }

        private void option2_Click(object sender, EventArgs e)
        {
            option = "2";
            if (option == textBox1.Text && index <= 15)
            {
                rst.Visible = true;
                SoundPlayer player = new SoundPlayer(@"C:\Users\star store\Desktop\bigdata\sound\shouting-yeah-7043 (1).wav");
                player.Play();
                timer2.Stop();
                count2 = 40;
                timer2.Start();
                verif = true;
                index++;


            }
            else
            {
                timer3.Stop();
                SoundPlayer player = new SoundPlayer(@"C:\Users\star store\Desktop\bigdata\sound\lose.wav");
                player.Play();
                MessageBox.Show("C'est faux !\nVous avez perdue", "Faux", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                timer2.Stop();

                this.Hide();
                menu menu = new menu();
                menu.ShowDialog();
            }
        }

        private void option3_Click(object sender, EventArgs e)
        {
            option = "3";
            if (option == textBox1.Text && index <= 15)
            {
                rst.Visible = true;
                SoundPlayer player = new SoundPlayer(@"C:\Users\star store\Desktop\bigdata\sound\shouting-yeah-7043 (1).wav");
                player.Play();
                timer2.Stop();
                count2 = 40;
                timer2.Start();
                verif = true;
                index++;




            }
            else
            {
                timer3.Stop();
                SoundPlayer player = new SoundPlayer(@"C:\Users\star store\Desktop\bigdata\sound\lose.wav");
                player.Play();
                MessageBox.Show("C'est faux !\nVous avez perdue", "Faux", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                timer2.Stop();

                this.Hide();
                menu menu = new menu();
                menu.ShowDialog();
            }
        }

        private void option4_Click(object sender, EventArgs e)
        {
            option = "4";
            if (option == textBox1.Text && index <= 15)
            {
                rst.Visible = true;
                SoundPlayer player = new SoundPlayer(@"C:\Users\star store\Desktop\bigdata\sound\shouting-yeah-7043 (1).wav");
                player.Play();
                timer2.Stop();
                count2 = 40;
                timer2.Start();
                verif = true;
                index++;



            }
            else
            {
                timer3.Stop();
                SoundPlayer player = new SoundPlayer(@"C:\Users\star store\Desktop\bigdata\sound\lose.wav");
                player.Play();
                MessageBox.Show("C'est faux !\nVous avez perdue", "Faux", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                timer2.Stop();

                this.Hide();
                menu menu = new menu();
                menu.ShowDialog();
            }
        }

        private void timer4_Tick(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Tu es sùr d'éliminer deux reponses incorrect ?\nCette option est disponible pour une seule fois ", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                button3.Enabled = false;
                if (textBox1.Text == "1")
                {
                    option2.Text = "";
                    option3.Text = "";
                    option2.Enabled = false;
                    option3.Enabled = false;
                }
                else if (textBox1.Text == "2")
                {
                    option1.Text = "";
                    option4.Text = "";
                    option1.Enabled = false;
                    option4.Enabled = false;
                }
                else if (textBox1.Text == "3")
                {
                    option1.Text = "";
                    option4.Text = "";
                    option1.Enabled = false;
                    option4.Enabled = false;
                }
                else if (textBox1.Text == "4")
                {
                    option2.Text = "";
                    option3.Text = "";
                    option2.Enabled = false;
                    option3.Enabled = false;
                }
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Tu es sùr de retrait de la jeu ?\nCette option est disponible pour une seule fois ", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes) { 
                timer3.Stop();
            


                if (index == 0)
                {
                    MessageBox.Show("vous n'avez rien gagner ", "LOSER", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                if (index == 1)
                {
                    MessageBox.Show("vous avez gagner 100 dt !", "WINNER", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                if (index == 2)
                {
                    MessageBox.Show("vous avez gagner 200 dt !", "WINNER", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                if (index == 3)
                {
                    MessageBox.Show("vous avez gagner 300 dt !", "WINNER", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                if (index == 4)
                {
                    MessageBox.Show("vous avez gagner 500 dt !", "WINNER", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                if (index == 5)
                {
                    MessageBox.Show("vous avez gagner 1000 dt !", "WINNER", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                if (index == 6)
                {
                    MessageBox.Show("vous avez gagner 2000 dt !", "WINNER", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                if (index == 7)
                {
                    MessageBox.Show("vous avez gagner 4000 dt !", "WINNER", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                if (index == 8)
                {
                    MessageBox.Show("vous avez gagner 8000 dt !", "WINNER", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                if (index == 9)
                {
                    MessageBox.Show("vous avez gagner 16000 dt !", "WINNER", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                if (index == 10)
                {
                    MessageBox.Show("vous avez gagner 32000 dt !", "WINNER", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                if (index == 11)
                {
                    MessageBox.Show("vous avez gagner 64000 dt !", "WINNER", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                if (index == 12)
                {
                    MessageBox.Show("vous avez gagner 125000 dt !", "WINNER", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                if (index == 13)
                {
                    MessageBox.Show("vous avez gagner 250000 dt !", "WINNER", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                if (index == 14)
                {
                    MessageBox.Show("vous avez gagner 500000 dt !", "WINNER", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                timer2.Stop();
                count2 = 0;
                this.Hide();
                menu menu1 = new menu();
                menu1.Show(); }
           


            }  

        private void button1_Click(object sender, EventArgs e)
        {   Random random= new Random();
            int option =random.Next(1,4);
            DialogResult result = MessageBox.Show("Tu es sùr de demander l'aide de spectacle ?\nCette option est disponible pour une seule fois ", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes) { 
                timer3.Stop();
                MessageBox.Show("Le spectacle vous recommande de choisir l'option numéro : " + option, "Option", MessageBoxButtons.OK, MessageBoxIcon.Information);
                button1.Enabled = false;           
            }
            else
            {

            }
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Tu es sùr de demander l'aide d'un ami(e) ?\nCette option est disponible pour une seule fois ", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                timer3.Stop();
                MessageBox.Show("Ton ami(e) vous recommande de choisir l'option numéro : " + textBox1.Text, "Option", MessageBoxButtons.OK, MessageBoxIcon.Information);
                button2.Enabled = false;
            }
        }

        private void bunifuFlatButton6_Click(object sender, EventArgs e)
        {

        }

        private void timer4_Tick_1(object sender, EventArgs e)
        {
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            label17.Text = textBox1.Text;
        }
    }
}
