namespace El_Toque_de_Midas
{
    partial class Login
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            userTextBox = new TextBox();
            passTextBox = new TextBox();
            SuspendLayout();
            // 
            // userTextBox
            // 
            userTextBox.AccessibleRole = AccessibleRole.None;
            userTextBox.BackColor = Color.FromArgb(255, 255, 128);
            userTextBox.Cursor = Cursors.IBeam;
            userTextBox.Font = new Font("Calibri", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            userTextBox.Location = new Point(38, 225);
            userTextBox.Name = "userTextBox";
            userTextBox.PlaceholderText = "usuario";
            userTextBox.Size = new Size(148, 22);
            userTextBox.TabIndex = 0;
            userTextBox.TabStop = false;
            userTextBox.TextChanged += textBox1_TextChanged;
            // 
            // passTextBox
            // 
            passTextBox.BackColor = Color.FromArgb(255, 255, 128);
            passTextBox.Cursor = Cursors.IBeam;
            passTextBox.Font = new Font("Calibri", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            passTextBox.Location = new Point(38, 270);
            passTextBox.Name = "passTextBox";
            passTextBox.PasswordChar = '*';
            passTextBox.PlaceholderText = "contraseña";
            passTextBox.Size = new Size(148, 22);
            passTextBox.TabIndex = 1;
            passTextBox.TabStop = false;
            passTextBox.TextChanged += textBox2_TextChanged;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaptionText;
            BackgroundImage = Properties.Resources.login;
            BackgroundImageLayout = ImageLayout.None;
            ClientSize = new Size(224, 327);
            Controls.Add(passTextBox);
            Controls.Add(userTextBox);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Login";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login";
            Enter += Login_Enter;
            KeyPress += Login_KeyPress;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox userTextBox;
        private TextBox passTextBox;
    }
}
