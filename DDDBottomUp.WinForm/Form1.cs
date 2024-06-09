using DDDBottomUp.Entities;
using DDDBottomUp.Infrastracture.SqlServer;
using DDDBottomUp.Repositories;
using DDDBottomUp.ValueObjects;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DDDBottomUp.WinForm
{
    public partial class Form1 : Form
    {
        private IUserRepository _userRepository;

        public Form1()
        {
            InitializeComponent();

            _userRepository = new UserSqlServer();
        }

        private void SaveButtoon_Click(object sender, EventArgs e)
        {
            //var myMoney = new Money(1000, "JPY");
            //var allowance = new Money(200, "JPY");
            //var result = myMoney.Add(allowance);
            //var result2 = result.Multiply(2);
            //var result = myMoney + allowance;
            var userId = new UserId(UserIdTextBox.Text.ToString());
            var userName = new UserName(UserNameTextBox.Text.ToString());
            var user = new User(userId, userName);
            _userRepository.Save(user);

            MessageBox.Show($"Save: {user.UserName.DisplayValue} san");
        }

        private void FindButton_Click(object sender, EventArgs e)
        {
            var userName = new UserName(UserNameTextBox.Text.ToString());

            var user = _userRepository.Find(userName);
            if (user != null)
            {
                IdLabel.Text = user.UserId.DisplayValue;
            }
            else
            {
                MessageBox.Show($"Not Found: {UserNameTextBox.Text}");
            }
        }
    }
}
