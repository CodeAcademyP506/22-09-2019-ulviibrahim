using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UserTodos
{
    public partial class Form1 : Form
    {
        List<Users> Users = new List<Users>();
        public Form1()
        {
            InitializeComponent();

            Users.Add(new Users(1, "Ulvi", 1234));
            Users.Add(new Users(2, "Nurlan", 5678));
            Users.Add(new Users(3, "Ayxan", 4554));
            Users.Add(new Users(4, "Besir", 6996));
            Users.Add(new Users(5, "Vusal", 7335));


        }

        private void BtnLogin_Click(object sender, EventArgs e)
        {
            Main_Window main_Window = new Main_Window();

            var user = Users.SingleOrDefault(s => TxtName.Text.ToLower() == s.Name.ToLower() && long.Parse(TxtPass.Text) == s.Password);
            if (user != null)
            {
                main_Window.loginUser = user;

                main_Window.Show();

            }


            main_Window.Show();


        }
    }

    public class Users
    {
        public Users(int id, string name, int pass)
        {
            Name = name;
            Password = pass;
            Id = id;
        }
        public int Id { get; set; }
        public string Name { get; set; }
        public long Password { get; set; }
    }

}
