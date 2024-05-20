using CodeFirstConvertionDataEx.Context;
using CodeFirstConvertionDataEx.Entities;

namespace CodeFirstConvertionDataEx
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        CodeFirstContext db = new CodeFirstContext();

        void getUserName()
        {
            cmbUserName.Items.Clear();
            foreach (var item in db.Users.ToList())
            {
                cmbUserName.Items.Add(item.UserName);
            }
        }

        private void btnUserAdd_Click(object sender, EventArgs e)
        {
            User user = new User();
            user.UserName = txtUserName.Text;
            db.Users.Add(user);
            int result = db.SaveChanges();
            if (result > 0)
            {
                MessageBox.Show("User Added");
                getUserName();
            }
            else
            {
                MessageBox.Show("Error");
            }
        }

        private void btnProfileAdd_Click(object sender, EventArgs e)
        {
            Profile profile = new Profile();
            profile.Bio = txtBio.Text;
            profile.User = db.Users.FirstOrDefault(x => x.UserName == cmbUserName.Text);



            if (db.Profiles.Find(profile.User.Id) == null)
            {
                db.Profiles.Add(profile);
                int result = db.SaveChanges();
                if (result > 0)
                {
                    MessageBox.Show("Profile Added");
                }
                else
                {
                    MessageBox.Show("Error");
                }
            }
            else
            {
                MessageBox.Show("Profile already exists");
            }
        }

        private void Form1_Load_1(object sender, EventArgs e)
        {
            getUserName();
        }
    }
}
