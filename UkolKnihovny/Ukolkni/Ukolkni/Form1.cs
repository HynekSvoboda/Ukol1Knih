using RetezUtil;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Ukolkni
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.CenterToScreen();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            try
            {
                string text = textBox1.Text;
                text = Retezec.Smaz(text);
                label1.Text = Retezec.Zobraz(text);
            }catch(Exception ex) { MessageBox.Show(ex.Message);}
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                Minus x = new Minus(textBox1.Text);
                Minus y = new Minus(textBox2.Text);
                label2.Text = x - y;
            }catch(Exception ex) { MessageBox.Show(ex.Message); }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Do knihovny RetezUtil pøidejte metodu Smaz, která v øetìzci smaže všechny èíslice. Slova jsou oddìlena libovolným poètem mezer. Pro øetìzec v TextBox zavolejte metodu Smaz a metodu Zobraz. Ke všem metodám v knihovnì RetezUtil napište nápovìdy a generujte XML. Pøeprogramujte operátor - (minus) tak, aby mazal vybraný znak z øetìzce znakù.");
        }
    }
}