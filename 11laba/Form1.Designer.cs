namespace _11laba
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
            registarionButton = new Button();
            enterButton = new Button();
            label1 = new Label();
            closebutton = new Button();
            SuspendLayout();
            // 
            // registarionButton
            // 
            registarionButton.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            registarionButton.Location = new Point(119, 169);
            registarionButton.Name = "registarionButton";
            registarionButton.Size = new Size(247, 54);
            registarionButton.TabIndex = 2;
            registarionButton.Text = "Зарегистрироваться";
            registarionButton.UseVisualStyleBackColor = true;
            registarionButton.Click += registarionButton_Click;
            // 
            // enterButton
            // 
            enterButton.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            enterButton.Location = new Point(119, 96);
            enterButton.Name = "enterButton";
            enterButton.Size = new Size(247, 54);
            enterButton.TabIndex = 1;
            enterButton.Text = "Войти";
            enterButton.UseVisualStyleBackColor = true;
            enterButton.Click += enterButton_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(484, 30);
            label1.TabIndex = 2;
            label1.Text = "Добро пожаловать в сообщество художников";
            // 
            // closebutton
            // 
            closebutton.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            closebutton.Location = new Point(119, 244);
            closebutton.Name = "closebutton";
            closebutton.Size = new Size(247, 54);
            closebutton.TabIndex = 3;
            closebutton.Text = "Выход";
            closebutton.UseVisualStyleBackColor = true;
            closebutton.Click += closebutton_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(510, 365);
            ControlBox = false;
            Controls.Add(closebutton);
            Controls.Add(label1);
            Controls.Add(enterButton);
            Controls.Add(registarionButton);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button registarionButton;
        private Button enterButton;
        private Label label1;
        private Button closebutton;
    }
}