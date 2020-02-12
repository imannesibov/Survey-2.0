using Newtonsoft.Json;
using Survey_2._0.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Survey_2._0
{
    public partial class Form1 : Form
    {
        List<User> users = new List<User>();
        User currentUser = new User();
        UserContext uc = new UserContext();
        int currentIndex = default(int);
        bool isSuccess = false;
        public const string MatchEmailPattern =
           @"^(([\w-]+\.)+[\w-]+|([a-zA-Z]{1}|[\w-]{2,}))@"
    + @"((([0-1]?[0-9]{1,2}|25[0-5]|2[0-4][0-9])\.([0-1]?
				[0-9]{1,2}|25[0-5]|2[0-4][0-9])\."
    + @"([0-1]?[0-9]{1,2}|25[0-5]|2[0-4][0-9])\.([0-1]?
				[0-9]{1,2}|25[0-5]|2[0-4][0-9])){1}|"
    + @"([a-zA-Z0-9]+[\w-]+\.)+[a-zA-Z]{1}[a-zA-Z0-9-]{1,23})$";

        Regex rgx = new Regex(MatchEmailPattern);

        public static bool IsEmail(string email)
        {
            if (email != null) return Regex.IsMatch(email, MatchEmailPattern);
            else return false;
        }
        public Form1()
        {
            InitializeComponent();
           
        }

        private void exitbtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void header_Click(object sender, EventArgs e)
        {

        }

        private void addbtn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(namearea.Text))
            {
                isSuccess = false;
            }
            if (string.IsNullOrEmpty(surnamearea.Text))
            {
                isSuccess = false;
            }
            if (string.IsNullOrEmpty(emailarea.Text))
            {
                isSuccess = false;
            }
            if (string.IsNullOrEmpty(phonearea.Text))
            {
                isSuccess = false;
            }
            if (isSuccess)
            {
                users.Add(new User { Name = namearea.Text, Surname = surnamearea.Text, Phone = phonearea.Text, Email = emailarea.Text, BirthDate = birthdate.Value });
                userlist.Items.Add(namearea.Text + " " + surnamearea.Text);
               
            }
            else
            {
                MessageBox.Show("All Fields Required");
            }

           
         
        }

        private void emailarea_MouseLeave(object sender, EventArgs e)
        {
            if (IsEmail(emailarea.Text))
            {
                isSuccess = true;
                ismail.Visible = false;
            }
            else
            {
                isSuccess = false;
                ismail.Visible = true;
            }
        }

        private void savebtn_Click(object sender, EventArgs e)
        {

        }

        private void loadbtn_Click(object sender, EventArgs e)
        {

        }

        private void emailarea_MouseUp(object sender, MouseEventArgs e)
        {

        }

        private void emailarea_TextChanged(object sender, EventArgs e)
        {

        }

        private void savebtn_Click_1(object sender, EventArgs e)
        {
            if (isSuccess)
            {
                SaveFileDialog sf = new SaveFileDialog();

                sf.Filter = "json files (*.json)|*.json|All files (*.*)|*.*";
                sf.ShowDialog();

                var json = JsonConvert.SerializeObject(users, Formatting.Indented);
                File.WriteAllText($"{sf.FileName}.json", json);

                uc.Users.AddRange(users);
                uc.SaveChanges();
            }
            else
            {
                MessageBox.Show("Unsuccessful");
            }

            
        }

        private void loadbtn_Click_1(object sender, EventArgs e)
        {
            if (userlist.Items.Count > 0)
            {
                userlist.Items.Clear();
            }
            OpenFileDialog of = new OpenFileDialog();

            of.Filter = "json files (*.json)|*.json|All files (*.*)|*.*";
            of.ShowDialog(); 

            try
            {
                var str = File.ReadAllText($"{of.FileName}");
                users = JsonConvert.DeserializeObject<List<User>>(str);
                userlist.Items.AddRange(users.ToArray());

            }
            catch (FileNotFoundException)
            {
                MessageBox.Show("File Not Exist");
            }

        }

        private void userlist_SelectedIndexChanged(object sender, EventArgs e)
        {
            for (int i = 0; i < users.Count; i++)
            {
                if (userlist.SelectedItem.ToString() == users[i].Name + " " + users[i].Surname)
                {
                    currentIndex = userlist.SelectedIndex;
                    currentUser = users[i];
                    namearea.Text = currentUser.Name;
                    surnamearea.Text = currentUser.Surname;
                    emailarea.Text = currentUser.Email;
                    phonearea.Text = currentUser.Phone;
                    birthdate.Value = currentUser.BirthDate;
                    break;
                }
            }

        }

        private void changebtn_Click(object sender, EventArgs e)
        {
            if (userlist.SelectedIndex >= 0)
            {
                users[currentIndex].Name = namearea.Text;
                users[currentIndex].Surname = surnamearea.Text;
                users[currentIndex].Email = emailarea.Text;
                users[currentIndex].Phone = phonearea.Text;
                users[currentIndex].BirthDate = birthdate.Value;
                userlist.Items.Clear();
                userlist.Items.AddRange(users.ToArray());  
            }
            else
            {
                MessageBox.Show("not changed");
            }
        }

        private void bunifuGradientPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void deletebtn_Click(object sender, EventArgs e)
        { 
            users.Remove(users[currentIndex]);
            uc.Users.AddRange(users);
            uc.SaveChanges(); 
        }
    }

}
