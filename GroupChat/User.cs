using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GroupChat
{
    public partial class User : UserControl
    {

        public string Jmeno;
        public Action<User> Smazany;
        public Action<string, string> Zprava;
        public User()
        {
            InitializeComponent();
        }

        public User(string jmeno): this()
        {
            this.Jmeno = jmeno;
            ZobrazText();
        }

        private void ZobrazText()
        {
            label1.Text = "Nickname: " + Jmeno;
            
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Smazany?.Invoke(this);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Zprava?.Invoke(Jmeno, textBox1.Text);
        }
        public void Podrz(Form1 form1)
        {
            Zprava += form1.Chat;
        }
        public void Text(string name, string mess)
        {
            label2.Text += name + ": " + mess + "\n";
        }
    }
}
