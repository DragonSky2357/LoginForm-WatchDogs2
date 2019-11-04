using System;
using System.Drawing;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LoginForm {
    public partial class MainForm : Form {
        private void MainForm_MouseDown(object sender, MouseEventArgs e) {
            ClickMouseLocation();
        }

        private void MainForm_MouseMove(object sender, MouseEventArgs e) {
            ClickMouseMove();
        }
        private void MainPicture_MouseDown(object sender, MouseEventArgs e) {
            ClickMouseLocation();
        }

        private void MainPicture_MouseUp(object sender, MouseEventArgs e) {
            IsMouseMoveStart = false;
        }

        private void MainPicture_MouseMove(object sender, MouseEventArgs e) {
            ClickMouseMove();
        }
        private void MainForm_MouseUp(object sender, MouseEventArgs e) {
            IsMouseMoveStart = false;
        }

        private void btnClose_MouseHover(object sender, EventArgs e) {
            btnClose.BackColor = Color.Red;
        }

        private void btnClose_MouseLeave(object sender, EventArgs e) {
            btnClose.BackColor = Color.White;
        }

        private void btnClose_Click(object sender, EventArgs e) {
            this.Close();
        }

        private void btnLogin_Click(object sender, EventArgs e) {
            btnLogin.BackColor = Color.CadetBlue;
            txtPassWord.Text = "";

            ScreenShake();
        }

        private void btnMinimisation_Click(object sender, EventArgs e) {
            this.WindowState = FormWindowState.Minimized;
        }

        private void txtID_MouseHover(object sender, EventArgs e) {
            txtID.BackColor = Color.LightGray;
        }

        private void txtID_MouseLeave(object sender, EventArgs e) {
            txtID.BackColor = Color.White;
        }

        private void txtPassWord_MouseHover(object sender, EventArgs e) {
            txtPassWord.BackColor = Color.LightGray;
        }

        private void txtPassWord_MouseLeave(object sender, EventArgs e) {
            txtPassWord.BackColor = Color.White;
        }
    }
}
