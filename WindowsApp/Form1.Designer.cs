namespace WindowsApp
{
    partial class Form1
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
            labelEmail = new Label();
            labelMainText = new Label();
            textEmail = new TextBox();
            labelPassword = new Label();
            textPassword = new TextBox();
            labelPasswordRepaat = new Label();
            textPasswordRepeat = new TextBox();
            buttonApprove = new Button();
            labelMessage = new Label();
            SuspendLayout();
            // 
            // labelEmail
            // 
            labelEmail.AutoSize = true;
            labelEmail.Location = new Point(3, 38);
            labelEmail.Name = "labelEmail";
            labelEmail.Size = new Size(74, 15);
            labelEmail.TabIndex = 1;
            labelEmail.Text = "Podaj e-mail";
            // 
            // labelMainText
            // 
            labelMainText.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            labelMainText.AutoSize = true;
            labelMainText.BackColor = Color.Teal;
            labelMainText.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            labelMainText.ForeColor = SystemColors.Control;
            labelMainText.Location = new Point(3, 9);
            labelMainText.Name = "labelMainText";
            labelMainText.Size = new Size(143, 28);
            labelMainText.TabIndex = 2;
            labelMainText.Text = "Rejestruj konto";
            labelMainText.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // textEmail
            // 
            textEmail.Location = new Point(3, 56);
            textEmail.Name = "textEmail";
            textEmail.Size = new Size(794, 23);
            textEmail.TabIndex = 3;
            textEmail.Text = "email";
            // 
            // labelPassword
            // 
            labelPassword.AutoSize = true;
            labelPassword.Location = new Point(3, 82);
            labelPassword.Name = "labelPassword";
            labelPassword.Size = new Size(68, 15);
            labelPassword.TabIndex = 4;
            labelPassword.Text = "Podaj haslo";
            // 
            // textPassword
            // 
            textPassword.Location = new Point(3, 100);
            textPassword.Name = "textPassword";
            textPassword.PasswordChar = '*';
            textPassword.Size = new Size(794, 23);
            textPassword.TabIndex = 5;
            // 
            // labelPasswordRepaat
            // 
            labelPasswordRepaat.AutoSize = true;
            labelPasswordRepaat.Location = new Point(3, 126);
            labelPasswordRepaat.Name = "labelPasswordRepaat";
            labelPasswordRepaat.Size = new Size(81, 15);
            labelPasswordRepaat.TabIndex = 6;
            labelPasswordRepaat.Text = "Powtorz haslo";
            // 
            // textPasswordRepeat
            // 
            textPasswordRepeat.Location = new Point(3, 144);
            textPasswordRepeat.Name = "textPasswordRepeat";
            textPasswordRepeat.PasswordChar = '*';
            textPasswordRepeat.Size = new Size(794, 23);
            textPasswordRepeat.TabIndex = 7;
            // 
            // buttonApprove
            // 
            buttonApprove.Location = new Point(71, 173);
            buttonApprove.Name = "buttonApprove";
            buttonApprove.Size = new Size(75, 23);
            buttonApprove.TabIndex = 8;
            buttonApprove.Text = "Zatwierdz";
            buttonApprove.UseVisualStyleBackColor = true;
            buttonApprove.Click += buttonApprove_Click;
            // 
            // labelMessage
            // 
            labelMessage.AutoSize = true;
            labelMessage.Location = new Point(71, 199);
            labelMessage.Name = "labelMessage";
            labelMessage.Size = new Size(0, 15);
            labelMessage.TabIndex = 9;
            labelMessage.Click += labelMessage_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(219, 251);
            Controls.Add(labelMessage);
            Controls.Add(buttonApprove);
            Controls.Add(textPasswordRepeat);
            Controls.Add(labelPasswordRepaat);
            Controls.Add(textPassword);
            Controls.Add(labelPassword);
            Controls.Add(textEmail);
            Controls.Add(labelMainText);
            Controls.Add(labelEmail);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelEmail;
        private Label labelMainText;
        private TextBox textEmail;
        private Label labelPassword;
        private TextBox textPassword;
        private Label labelPasswordRepaat;
        private TextBox textPasswordRepeat;
        private Button buttonApprove;
        private Label labelMessage;
    }
}