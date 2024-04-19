namespace Lesson_4
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
            NameLabel = new Label();
            Surname = new Label();
            Telephone = new Label();
            Email = new Label();
            NameBox = new TextBox();
            SurnameBox = new TextBox();
            TelephoneBox = new TextBox();
            EmailBox = new TextBox();
            AddButton = new Button();
            ChangeButton = new Button();
            DeleteButton = new Button();
            listBox1 = new ListBox();
            LoadButton = new Button();
            SaveButton = new Button();
            SuspendLayout();
            // 
            // NameLabel
            // 
            NameLabel.AutoSize = true;
            NameLabel.Font = new Font("Segoe UI", 14F);
            NameLabel.Location = new Point(32, 53);
            NameLabel.Name = "NameLabel";
            NameLabel.Size = new Size(78, 32);
            NameLabel.TabIndex = 0;
            NameLabel.Text = "Name";
            // 
            // Surname
            // 
            Surname.AutoSize = true;
            Surname.Font = new Font("Segoe UI", 14F);
            Surname.Location = new Point(32, 142);
            Surname.Name = "Surname";
            Surname.Size = new Size(109, 32);
            Surname.TabIndex = 1;
            Surname.Text = "Surname";
            // 
            // Telephone
            // 
            Telephone.AutoSize = true;
            Telephone.Font = new Font("Segoe UI", 14F);
            Telephone.Location = new Point(32, 233);
            Telephone.Name = "Telephone";
            Telephone.Size = new Size(126, 32);
            Telephone.TabIndex = 2;
            Telephone.Text = "Telephone";
            // 
            // Email
            // 
            Email.AutoSize = true;
            Email.Font = new Font("Segoe UI", 14F);
            Email.Location = new Point(32, 336);
            Email.Name = "Email";
            Email.Size = new Size(82, 32);
            Email.TabIndex = 3;
            Email.Text = "E-Mail";
            // 
            // NameBox
            // 
            NameBox.Font = new Font("Segoe UI", 10F);
            NameBox.Location = new Point(196, 55);
            NameBox.Name = "NameBox";
            NameBox.Size = new Size(125, 30);
            NameBox.TabIndex = 4;
            NameBox.TextChanged += NameBox_TextChanged;
            // 
            // SurnameBox
            // 
            SurnameBox.Font = new Font("Segoe UI", 10F);
            SurnameBox.Location = new Point(196, 144);
            SurnameBox.Name = "SurnameBox";
            SurnameBox.Size = new Size(125, 30);
            SurnameBox.TabIndex = 5;
            // 
            // TelephoneBox
            // 
            TelephoneBox.Font = new Font("Segoe UI", 10F);
            TelephoneBox.Location = new Point(196, 235);
            TelephoneBox.Name = "TelephoneBox";
            TelephoneBox.Size = new Size(125, 30);
            TelephoneBox.TabIndex = 6;
            // 
            // EmailBox
            // 
            EmailBox.Font = new Font("Segoe UI", 10F);
            EmailBox.Location = new Point(196, 338);
            EmailBox.Name = "EmailBox";
            EmailBox.Size = new Size(125, 30);
            EmailBox.TabIndex = 7;
            // 
            // AddButton
            // 
            AddButton.Location = new Point(369, 100);
            AddButton.Name = "AddButton";
            AddButton.Size = new Size(94, 29);
            AddButton.TabIndex = 8;
            AddButton.Text = "Add";
            AddButton.UseVisualStyleBackColor = true;
            AddButton.Click += AddButton_Click;
            // 
            // ChangeButton
            // 
            ChangeButton.Location = new Point(369, 194);
            ChangeButton.Name = "ChangeButton";
            ChangeButton.Size = new Size(94, 29);
            ChangeButton.TabIndex = 9;
            ChangeButton.Text = "Change";
            ChangeButton.UseVisualStyleBackColor = true;
            ChangeButton.Click += ChangeButton_Click;
            // 
            // DeleteButton
            // 
            DeleteButton.Location = new Point(369, 296);
            DeleteButton.Name = "DeleteButton";
            DeleteButton.Size = new Size(94, 29);
            DeleteButton.TabIndex = 10;
            DeleteButton.Text = "Delete";
            DeleteButton.UseVisualStyleBackColor = true;
            DeleteButton.Click += DeleteButton_Click;
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.Location = new Point(495, 104);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(150, 224);
            listBox1.TabIndex = 11;
            listBox1.SelectedIndexChanged += listBox1_SelectedIndexChanged;
            // 
            // LoadButton
            // 
            LoadButton.Location = new Point(32, 397);
            LoadButton.Name = "LoadButton";
            LoadButton.Size = new Size(94, 29);
            LoadButton.TabIndex = 12;
            LoadButton.Text = "Load";
            LoadButton.UseVisualStyleBackColor = true;
            LoadButton.Click += LoadButton_Click;
            // 
            // SaveButton
            // 
            SaveButton.Location = new Point(519, 397);
            SaveButton.Name = "SaveButton";
            SaveButton.Size = new Size(94, 29);
            SaveButton.TabIndex = 13;
            SaveButton.Text = "Save";
            SaveButton.UseVisualStyleBackColor = true;
            SaveButton.Click += SaveButton_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(657, 453);
            Controls.Add(SaveButton);
            Controls.Add(LoadButton);
            Controls.Add(listBox1);
            Controls.Add(DeleteButton);
            Controls.Add(ChangeButton);
            Controls.Add(AddButton);
            Controls.Add(EmailBox);
            Controls.Add(TelephoneBox);
            Controls.Add(SurnameBox);
            Controls.Add(NameBox);
            Controls.Add(Email);
            Controls.Add(Telephone);
            Controls.Add(Surname);
            Controls.Add(NameLabel);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label NameLabel;
        private Label Surname;
        private Label Telephone;
        private Label Email;
        private TextBox NameBox;
        private TextBox SurnameBox;
        private TextBox TelephoneBox;
        private TextBox EmailBox;
        private Button AddButton;
        private Button ChangeButton;
        private Button DeleteButton;
        private ListBox listBox1;
        private Button LoadButton;
        private Button SaveButton;
    }
}
