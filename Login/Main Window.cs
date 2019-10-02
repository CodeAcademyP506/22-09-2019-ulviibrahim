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

    public partial class Main_Window : Form

    {

        List<UserTodo> userTodos = new List<UserTodo>();
        public Users loginUser { get; set; }
        Form1 firstForm = new Form1();
        public Main_Window()
        {

            //listUser = users;
            //var form2 = Main_Window(List < Users > users);
            InitializeComponent();
            //String.Format("{0:M/d/yyyy}")

            userTodos.Add(new UserTodo(1, "Kitab oxumaq", new DateTime(2019, 10, 1)));
            userTodos.Add(new UserTodo(1, "Ingili dilini oyrenmek", new DateTime(2019, 09, 27)));
            userTodos.Add(new UserTodo(2, "Nefes almaq", new DateTime(2019, 09, 28)));
            userTodos.Add(new UserTodo(1, "Yatmaq", new DateTime(2019, 09, 28)));


        }

       

        private void Main_Window_Shown_1(object sender, EventArgs e)
        {
            if (loginUser != null)
            {
                var loginUsersToDos = userTodos.Where(w => w.UserID == loginUser.Id);


                foreach (var item in loginUsersToDos)
                {
                    DgvList.Rows.Add(item.UserID, item.Title, item.date);

                    LblTitle.Text = "List " + loginUser.Name;
                }
            }            else
            {
                MessageBox.Show(firstForm.TxtName.Text);

            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            userTodos.Add(new UserTodo(int.Parse(txtid.Text), txtTitle.Text, DtP.Value));
            DgvList.Rows.Add(int.Parse(txtid.Text), txtTitle.Text, DtP.Value);

            txtid.Text = "";
            txtTitle.Text = "";
            DtP.Value = DateTime.Now;
        }

        private void DgvList_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void DgvList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {


                DataGridViewRow row = this.DgvList.Rows[e.RowIndex];
                row.Cells["Deadline"].Value = "";
                row.Cells["Id"].Value = "";
                row.Cells["Title"].Value = "";


              
            }
        }

        private void BtnRef_Click(object sender, EventArgs e)
        {
            if (loginUser != null)
            {

                var loginUsersToDos = userTodos.Where(w => w.UserID == loginUser.Id);


                foreach (var item in loginUsersToDos)
                {
                    DgvList.Rows.Add(item.UserID, item.Title, item.date);

                    LblTitle.Text = "List " + loginUser.Name;
                }
            }
        }
    }






    class UserTodo
    {
        public UserTodo(int ui, string t, DateTime d)
        {
            UserID = ui;
            Title = t;
            date = d;
        }
        public int UserID { get; set; }
        public string Title { get; set; }
        public DateTime date { get; set; }
    }


}