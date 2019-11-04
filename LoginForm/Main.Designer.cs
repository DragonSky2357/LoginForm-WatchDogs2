namespace LoginForm {
    partial class MainForm {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent() {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.btnClose = new System.Windows.Forms.Button();
            this.btnMinimisation = new System.Windows.Forms.Button();
            this.txtID = new System.Windows.Forms.TextBox();
            this.txtPassWord = new System.Windows.Forms.TextBox();
            this.lblID = new System.Windows.Forms.Label();
            this.lblPassword = new System.Windows.Forms.Label();
            this.btnLogin = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.MainPicture = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MainPicture)).BeginInit();
            this.SuspendLayout();
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.White;
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.ForeColor = System.Drawing.Color.Black;
            this.btnClose.Location = new System.Drawing.Point(1362, -1);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(40, 35);
            this.btnClose.TabIndex = 2;
            this.btnClose.Text = "x";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            this.btnClose.MouseLeave += new System.EventHandler(this.btnClose_MouseLeave);
            this.btnClose.MouseHover += new System.EventHandler(this.btnClose_MouseHover);
            // 
            // btnMinimisation
            // 
            this.btnMinimisation.BackColor = System.Drawing.Color.White;
            this.btnMinimisation.FlatAppearance.BorderSize = 0;
            this.btnMinimisation.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMinimisation.ForeColor = System.Drawing.Color.Black;
            this.btnMinimisation.Location = new System.Drawing.Point(1330, -1);
            this.btnMinimisation.Name = "btnMinimisation";
            this.btnMinimisation.Size = new System.Drawing.Size(33, 35);
            this.btnMinimisation.TabIndex = 4;
            this.btnMinimisation.Text = "_";
            this.btnMinimisation.UseVisualStyleBackColor = false;
            this.btnMinimisation.Click += new System.EventHandler(this.btnMinimisation_Click);
            // 
            // txtID
            // 
            this.txtID.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtID.Font = new System.Drawing.Font("Calisto MT", 15F);
            this.txtID.Location = new System.Drawing.Point(1084, 260);
            this.txtID.Multiline = true;
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(318, 39);
            this.txtID.TabIndex = 8;
            this.txtID.MouseLeave += new System.EventHandler(this.txtID_MouseLeave);
            this.txtID.MouseHover += new System.EventHandler(this.txtID_MouseHover);
            // 
            // txtPassWord
            // 
            this.txtPassWord.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPassWord.Font = new System.Drawing.Font("Calisto MT", 15F);
            this.txtPassWord.Location = new System.Drawing.Point(1084, 326);
            this.txtPassWord.Multiline = true;
            this.txtPassWord.Name = "txtPassWord";
            this.txtPassWord.PasswordChar = '*';
            this.txtPassWord.Size = new System.Drawing.Size(318, 39);
            this.txtPassWord.TabIndex = 9;
            this.txtPassWord.MouseLeave += new System.EventHandler(this.txtPassWord_MouseLeave);
            this.txtPassWord.MouseHover += new System.EventHandler(this.txtPassWord_MouseHover);
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Location = new System.Drawing.Point(1087, 238);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(28, 19);
            this.lblID.TabIndex = 10;
            this.lblID.Text = "ID";
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Location = new System.Drawing.Point(1087, 302);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(75, 19);
            this.lblPassword.TabIndex = 11;
            this.lblPassword.Text = "Password";
            // 
            // btnLogin
            // 
            this.btnLogin.BackColor = System.Drawing.Color.White;
            this.btnLogin.FlatAppearance.BorderSize = 0;
            this.btnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogin.Font = new System.Drawing.Font("Century Schoolbook", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogin.ForeColor = System.Drawing.Color.Black;
            this.btnLogin.Location = new System.Drawing.Point(1183, 392);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(115, 73);
            this.btnLogin.TabIndex = 5;
            this.btnLogin.Text = "LOG IN";
            this.btnLogin.UseVisualStyleBackColor = false;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calisto MT", 20F);
            this.label1.Location = new System.Drawing.Point(1091, 160);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 31);
            this.label1.TabIndex = 12;
            this.label1.Text = "LOGIN";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::LoginForm.Properties.Resources._74_741938_logo_de_watch_dogs_2;
            this.pictureBox1.Location = new System.Drawing.Point(1091, 40);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(311, 117);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 13;
            this.pictureBox1.TabStop = false;
            // 
            // MainPicture
            // 
            this.MainPicture.Image = ((System.Drawing.Image)(resources.GetObject("MainPicture.Image")));
            this.MainPicture.Location = new System.Drawing.Point(-4, -137);
            this.MainPicture.Name = "MainPicture";
            this.MainPicture.Size = new System.Drawing.Size(1089, 851);
            this.MainPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.MainPicture.TabIndex = 0;
            this.MainPicture.TabStop = false;
            this.MainPicture.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MainPicture_MouseDown);
            this.MainPicture.MouseMove += new System.Windows.Forms.MouseEventHandler(this.MainPicture_MouseMove);
            this.MainPicture.MouseUp += new System.Windows.Forms.MouseEventHandler(this.MainPicture_MouseUp);
            // 
            // MainForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1400, 580);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblPassword);
            this.Controls.Add(this.lblID);
            this.Controls.Add(this.txtPassWord);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.btnMinimisation);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.MainPicture);
            this.Font = new System.Drawing.Font("Calisto MT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MainForm_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.MainForm_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.MainForm_MouseUp);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MainPicture)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnMinimisation;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.TextBox txtPassWord;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.PictureBox MainPicture;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

