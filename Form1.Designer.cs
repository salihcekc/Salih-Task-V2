namespace Task_Level2_Test_App2
{
    partial class loginScreen
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.UserName_lbl = new System.Windows.Forms.Label();
            this.Password_lbl = new System.Windows.Forms.Label();
            this.UserName_txt = new System.Windows.Forms.TextBox();
            this.Password_txt = new System.Windows.Forms.TextBox();
            this.LoginBtn = new System.Windows.Forms.Button();
            this.btnLogout = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // UserName_lbl
            // 
            this.UserName_lbl.AutoSize = true;
            this.UserName_lbl.Location = new System.Drawing.Point(12, 40);
            this.UserName_lbl.Name = "UserName_lbl";
            this.UserName_lbl.Size = new System.Drawing.Size(63, 13);
            this.UserName_lbl.TabIndex = 0;
            this.UserName_lbl.Text = "User Name:";
            // 
            // Password_lbl
            // 
            this.Password_lbl.AutoSize = true;
            this.Password_lbl.Location = new System.Drawing.Point(12, 68);
            this.Password_lbl.Name = "Password_lbl";
            this.Password_lbl.Size = new System.Drawing.Size(56, 13);
            this.Password_lbl.TabIndex = 1;
            this.Password_lbl.Text = "Password:";
            // 
            // UserName_txt
            // 
            this.UserName_txt.Location = new System.Drawing.Point(109, 33);
            this.UserName_txt.Name = "UserName_txt";
            this.UserName_txt.Size = new System.Drawing.Size(100, 20);
            this.UserName_txt.TabIndex = 2;
            // 
            // Password_txt
            // 
            this.Password_txt.Location = new System.Drawing.Point(109, 68);
            this.Password_txt.Name = "Password_txt";
            this.Password_txt.Size = new System.Drawing.Size(100, 20);
            this.Password_txt.TabIndex = 3;
            // 
            // LoginBtn
            // 
            this.LoginBtn.Location = new System.Drawing.Point(109, 110);
            this.LoginBtn.Name = "LoginBtn";
            this.LoginBtn.Size = new System.Drawing.Size(100, 23);
            this.LoginBtn.TabIndex = 4;
            this.LoginBtn.Text = "LOGIN";
            this.LoginBtn.UseVisualStyleBackColor = true;
            this.LoginBtn.Click += new System.EventHandler(this.LoginBtn_Click);
            // 
            // btnLogout
            // 
            this.btnLogout.Location = new System.Drawing.Point(109, 152);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(100, 23);
            this.btnLogout.TabIndex = 5;
            this.btnLogout.Text = "LOGOUT";
            this.btnLogout.UseVisualStyleBackColor = true;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // loginScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(253, 281);
            this.Controls.Add(this.btnLogout);
            this.Controls.Add(this.LoginBtn);
            this.Controls.Add(this.Password_txt);
            this.Controls.Add(this.UserName_txt);
            this.Controls.Add(this.Password_lbl);
            this.Controls.Add(this.UserName_lbl);
            this.Name = "loginScreen";
            this.Text = "LOGIN SCREEN";
            this.Load += new System.EventHandler(this.loginScreen_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label UserName_lbl;
        private System.Windows.Forms.Label Password_lbl;
        private System.Windows.Forms.TextBox UserName_txt;
        private System.Windows.Forms.TextBox Password_txt;
        private System.Windows.Forms.Button LoginBtn;
        private System.Windows.Forms.Button btnLogout;
    }
}

