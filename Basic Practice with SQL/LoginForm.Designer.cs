namespace Basic_Practice_with_SQL
{
    partial class LoginForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            mainPanel = new Panel();
            enterButton = new Button();
            passwordField = new TextBox();
            pictureLock = new PictureBox();
            loginField = new TextBox();
            pictureUser = new PictureBox();
            headPanel = new Panel();
            closeButton = new Label();
            authorization = new Label();
            mainPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureLock).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureUser).BeginInit();
            headPanel.SuspendLayout();
            SuspendLayout();
            // 
            // mainPanel
            // 
            mainPanel.BackColor = Color.FromArgb(110, 33, 34);
            mainPanel.Controls.Add(enterButton);
            mainPanel.Controls.Add(passwordField);
            mainPanel.Controls.Add(pictureLock);
            mainPanel.Controls.Add(loginField);
            mainPanel.Controls.Add(pictureUser);
            mainPanel.Controls.Add(headPanel);
            mainPanel.Dock = DockStyle.Fill;
            mainPanel.Location = new Point(0, 0);
            mainPanel.Name = "mainPanel";
            mainPanel.Size = new Size(400, 494);
            mainPanel.TabIndex = 0;
            mainPanel.MouseDown += MainPanel_MouseDown;
            mainPanel.MouseMove += MainPanel_MouseMove;
            // 
            // enterButton
            // 
            enterButton.BackColor = Color.FromArgb(0, 158, 60);
            enterButton.Cursor = Cursors.Hand;
            enterButton.FlatAppearance.BorderColor = Color.FromArgb(33, 110, 109);
            enterButton.FlatAppearance.MouseDownBackColor = Color.FromArgb(0, 184, 69);
            enterButton.FlatAppearance.MouseOverBackColor = Color.FromArgb(158, 184, 0);
            enterButton.FlatStyle = FlatStyle.Flat;
            enterButton.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            enterButton.ForeColor = Color.White;
            enterButton.Location = new Point(112, 349);
            enterButton.Name = "enterButton";
            enterButton.Size = new Size(167, 39);
            enterButton.TabIndex = 5;
            enterButton.Text = "Enter";
            enterButton.UseVisualStyleBackColor = false;
            // 
            // passwordField
            // 
            passwordField.Font = new Font("Microsoft Sans Serif", 38.25F, FontStyle.Regular, GraphicsUnit.Point);
            passwordField.Location = new Point(102, 225);
            passwordField.Name = "passwordField";
            passwordField.Size = new Size(260, 65);
            passwordField.TabIndex = 4;
            passwordField.UseSystemPasswordChar = true;
            // 
            // pictureLock
            // 
            pictureLock.Image = Properties.Resources._lock;
            pictureLock.Location = new Point(32, 225);
            pictureLock.Name = "pictureLock";
            pictureLock.Size = new Size(65, 65);
            pictureLock.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureLock.TabIndex = 3;
            pictureLock.TabStop = false;
            // 
            // loginField
            // 
            loginField.Font = new Font("Microsoft Sans Serif", 38.25F, FontStyle.Regular, GraphicsUnit.Point);
            loginField.Location = new Point(102, 133);
            loginField.Name = "loginField";
            loginField.Size = new Size(260, 65);
            loginField.TabIndex = 2;
            // 
            // pictureUser
            // 
            pictureUser.Image = Properties.Resources.user;
            pictureUser.Location = new Point(32, 133);
            pictureUser.Name = "pictureUser";
            pictureUser.Size = new Size(65, 65);
            pictureUser.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureUser.TabIndex = 1;
            pictureUser.TabStop = false;
            // 
            // headPanel
            // 
            headPanel.BackColor = Color.FromArgb(33, 110, 109);
            headPanel.Controls.Add(closeButton);
            headPanel.Controls.Add(authorization);
            headPanel.Dock = DockStyle.Top;
            headPanel.Location = new Point(0, 0);
            headPanel.Name = "headPanel";
            headPanel.Size = new Size(400, 100);
            headPanel.TabIndex = 0;
            headPanel.MouseDown += HeadPanel_MouseDown;
            headPanel.MouseMove += HeadPanel_MouseMove;
            // 
            // closeButton
            // 
            closeButton.AutoSize = true;
            closeButton.Cursor = Cursors.Hand;
            closeButton.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Regular, GraphicsUnit.Point);
            closeButton.ForeColor = Color.White;
            closeButton.Location = new Point(374, -2);
            closeButton.Name = "closeButton";
            closeButton.Size = new Size(24, 29);
            closeButton.TabIndex = 1;
            closeButton.Text = "x";
            closeButton.Click += CloseButton_Click;
            closeButton.MouseEnter += CloseButton_MouseEnter;
            closeButton.MouseLeave += CloseButton_MouseLeave;
            // 
            // authorization
            // 
            authorization.Dock = DockStyle.Fill;
            authorization.Font = new Font("Comic Sans MS", 32F, FontStyle.Bold, GraphicsUnit.Point);
            authorization.ForeColor = Color.FromArgb(249, 249, 249);
            authorization.Location = new Point(0, 0);
            authorization.Name = "authorization";
            authorization.Size = new Size(400, 100);
            authorization.TabIndex = 0;
            authorization.Text = "Authorization";
            authorization.TextAlign = ContentAlignment.MiddleCenter;
            authorization.MouseDown += Authorization_MouseDown;
            authorization.MouseMove += Authorization_MouseMove;
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(8F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(400, 494);
            Controls.Add(mainPanel);
            FormBorderStyle = FormBorderStyle.None;
            Name = "LoginForm";
            Text = "LoginForm";
            mainPanel.ResumeLayout(false);
            mainPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureLock).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureUser).EndInit();
            headPanel.ResumeLayout(false);
            headPanel.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel mainPanel;
        private Panel headPanel;
        private Label authorization;
        private Label closeButton;
        private PictureBox pictureUser;
        private TextBox passwordField;
        private PictureBox pictureLock;
        private TextBox loginField;
        private Button enterButton;
    }
}