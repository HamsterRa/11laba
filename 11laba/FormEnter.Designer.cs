namespace _11laba
{
    partial class FormEnter
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
            label1 = new Label();
            groupBox1 = new GroupBox();
            label3 = new Label();
            passwordBox = new TextBox();
            label2 = new Label();
            emailBox = new TextBox();
            closeButton = new Button();
            checkbutton = new Button();
            linkLabel1 = new LinkLabel();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(129, 15);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(132, 65);
            label1.TabIndex = 0;
            label1.Text = "Вход";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(linkLabel1);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(passwordBox);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(emailBox);
            groupBox1.Controls.Add(closeButton);
            groupBox1.Controls.Add(checkbutton);
            groupBox1.Location = new Point(17, 95);
            groupBox1.Margin = new Padding(4, 5, 4, 5);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(4, 5, 4, 5);
            groupBox1.Size = new Size(360, 333);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(9, 118);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(96, 32);
            label3.TabIndex = 5;
            label3.Text = "Пароль";
            // 
            // passwordBox
            // 
            passwordBox.Location = new Point(9, 158);
            passwordBox.Margin = new Padding(4, 5, 4, 5);
            passwordBox.Name = "passwordBox";
            passwordBox.Size = new Size(341, 31);
            passwordBox.TabIndex = 4;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(9, 32);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(81, 32);
            label2.TabIndex = 3;
            label2.Text = "Почта";
            // 
            // emailBox
            // 
            emailBox.Location = new Point(9, 72);
            emailBox.Margin = new Padding(4, 5, 4, 5);
            emailBox.Name = "emailBox";
            emailBox.Size = new Size(341, 31);
            emailBox.TabIndex = 2;
            // 
            // closeButton
            // 
            closeButton.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            closeButton.Location = new Point(189, 250);
            closeButton.Margin = new Padding(4, 5, 4, 5);
            closeButton.Name = "closeButton";
            closeButton.Size = new Size(133, 68);
            closeButton.TabIndex = 1;
            closeButton.Text = "Выход";
            closeButton.UseVisualStyleBackColor = true;
            closeButton.Click += closeButton_Click;
            // 
            // checkbutton
            // 
            checkbutton.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            checkbutton.Location = new Point(47, 250);
            checkbutton.Margin = new Padding(4, 5, 4, 5);
            checkbutton.Name = "checkbutton";
            checkbutton.Size = new Size(133, 68);
            checkbutton.TabIndex = 0;
            checkbutton.Text = "Вход";
            checkbutton.UseVisualStyleBackColor = true;
            checkbutton.Click += checkbutton_Click;
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.Location = new Point(9, 194);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(186, 25);
            linkLabel1.TabIndex = 6;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "Восстановить пароль";
            linkLabel1.LinkClicked += linkLabel1_LinkClicked;
            // 
            // FormEnter
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(394, 442);
            ControlBox = false;
            Controls.Add(groupBox1);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(4, 5, 4, 5);
            Name = "FormEnter";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private GroupBox groupBox1;
        private Button closeButton;
        private Button checkbutton;
        private Label label3;
        private TextBox passwordBox;
        private Label label2;
        private TextBox emailBox;
        private LinkLabel linkLabel1;
    }
}