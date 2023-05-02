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
            textBox1 = new TextBox();
            label2 = new Label();
            emailBox = new TextBox();
            closeButton = new Button();
            checkbutton = new Button();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(90, 9);
            label1.Name = "label1";
            label1.Size = new Size(90, 45);
            label1.TabIndex = 0;
            label1.Text = "Вход";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(textBox1);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(emailBox);
            groupBox1.Controls.Add(closeButton);
            groupBox1.Controls.Add(checkbutton);
            groupBox1.Location = new Point(12, 57);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(252, 189);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(6, 71);
            label3.Name = "label3";
            label3.Size = new Size(63, 21);
            label3.TabIndex = 5;
            label3.Text = "Пароль";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(6, 95);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(240, 23);
            textBox1.TabIndex = 4;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(6, 19);
            label2.Name = "label2";
            label2.Size = new Size(54, 21);
            label2.TabIndex = 3;
            label2.Text = "Почта";
            // 
            // emailBox
            // 
            emailBox.Location = new Point(6, 43);
            emailBox.Name = "emailBox";
            emailBox.Size = new Size(240, 23);
            emailBox.TabIndex = 2;
            // 
            // closeButton
            // 
            closeButton.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            closeButton.Location = new Point(132, 137);
            closeButton.Name = "closeButton";
            closeButton.Size = new Size(93, 41);
            closeButton.TabIndex = 1;
            closeButton.Text = "Выход";
            closeButton.UseVisualStyleBackColor = true;
            closeButton.Click += closeButton_Click;
            // 
            // checkbutton
            // 
            checkbutton.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            checkbutton.Location = new Point(33, 137);
            checkbutton.Name = "checkbutton";
            checkbutton.Size = new Size(93, 41);
            checkbutton.TabIndex = 0;
            checkbutton.Text = "Вход";
            checkbutton.UseVisualStyleBackColor = true;
            checkbutton.Click += checkbutton_Click;
            // 
            // FormEnter
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(276, 252);
            ControlBox = false;
            Controls.Add(groupBox1);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
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
        private TextBox textBox1;
        private Label label2;
        private TextBox emailBox;
    }
}