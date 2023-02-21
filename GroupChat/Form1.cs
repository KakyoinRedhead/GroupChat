namespace GroupChat
{
    public partial class Form1 : Form
    {
        List<User> users = new List<User>();
        Action<string, string> odesilani;
        public Form1()
        {
            InitializeComponent();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            VytvorUser();
        }

        public void VytvorUser()
        {
            User user = new User(textBox1.Text);
            flowLayoutPanel1.Controls.Add(user);

            user.Smazany += Delete;
            users.Add(user);
            user.Podrz(this);
            odesilani += user.Text;
        }

        private void Delete(User user)
        {
            flowLayoutPanel1.Controls.Remove(user);
        }

        public void Chat(string name, string mess)
        {
            odesilani.Invoke(name, mess);
        }
    }
}