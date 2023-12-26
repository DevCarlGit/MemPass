namespace MemPass
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            label1 = new Label();
            lowerCheckBox = new CheckBox();
            upperCheckBox = new CheckBox();
            numericCheckBox = new CheckBox();
            specialCheckBox = new CheckBox();
            lengthTextBox = new TextBox();
            resultTextBox = new TextBox();
            passwordLabel = new Label();
            label3 = new Label();
            generatePasswordButton = new Button();
            copyToClipboardButton = new Button();
            modeToggleButton = new Button();
            cutePasswordButton = new Button();
            animalPasswordButton = new Button();
            sportsPasswordButton = new Button();
            label2 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(60, 50);
            label1.Name = "label1";
            label1.Size = new Size(49, 15);
            label1.TabIndex = 0;
            label1.Text = "Options";
            // 
            // lowerCheckBox
            // 
            lowerCheckBox.AutoSize = true;
            lowerCheckBox.Location = new Point(60, 79);
            lowerCheckBox.Name = "lowerCheckBox";
            lowerCheckBox.Size = new Size(86, 19);
            lowerCheckBox.TabIndex = 1;
            lowerCheckBox.Text = "Lower Case";
            lowerCheckBox.UseVisualStyleBackColor = true;
            // 
            // upperCheckBox
            // 
            upperCheckBox.AutoSize = true;
            upperCheckBox.Location = new Point(60, 104);
            upperCheckBox.Name = "upperCheckBox";
            upperCheckBox.Size = new Size(86, 19);
            upperCheckBox.TabIndex = 2;
            upperCheckBox.Text = "Upper Case";
            upperCheckBox.UseVisualStyleBackColor = true;
            // 
            // numericCheckBox
            // 
            numericCheckBox.AutoSize = true;
            numericCheckBox.Location = new Point(60, 129);
            numericCheckBox.Name = "numericCheckBox";
            numericCheckBox.Size = new Size(72, 19);
            numericCheckBox.TabIndex = 3;
            numericCheckBox.Text = "Numeric";
            numericCheckBox.UseVisualStyleBackColor = true;
            // 
            // specialCheckBox
            // 
            specialCheckBox.AutoSize = true;
            specialCheckBox.Location = new Point(60, 154);
            specialCheckBox.Name = "specialCheckBox";
            specialCheckBox.Size = new Size(122, 19);
            specialCheckBox.TabIndex = 4;
            specialCheckBox.Text = "Special Characters";
            specialCheckBox.UseVisualStyleBackColor = true;
            // 
            // lengthTextBox
            // 
            lengthTextBox.Location = new Point(347, 62);
            lengthTextBox.Name = "lengthTextBox";
            lengthTextBox.Size = new Size(49, 23);
            lengthTextBox.TabIndex = 5;
            // 
            // resultTextBox
            // 
            resultTextBox.Location = new Point(347, 101);
            resultTextBox.Name = "resultTextBox";
            resultTextBox.Size = new Size(309, 23);
            resultTextBox.TabIndex = 6;
            // 
            // passwordLabel
            // 
            passwordLabel.AutoSize = true;
            passwordLabel.Location = new Point(235, 65);
            passwordLabel.Name = "passwordLabel";
            passwordLabel.Size = new Size(97, 15);
            passwordLabel.TabIndex = 7;
            passwordLabel.Text = "Password Length";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(218, 104);
            label3.Name = "label3";
            label3.Size = new Size(114, 15);
            label3.TabIndex = 8;
            label3.Text = "Generated Password";
            // 
            // generatePasswordButton
            // 
            generatePasswordButton.Location = new Point(347, 140);
            generatePasswordButton.Name = "generatePasswordButton";
            generatePasswordButton.Size = new Size(152, 29);
            generatePasswordButton.TabIndex = 9;
            generatePasswordButton.Text = "Generate Password";
            generatePasswordButton.UseVisualStyleBackColor = true;
            generatePasswordButton.Click += generatePasswordButton_Click;
            // 
            // copyToClipboardButton
            // 
            copyToClipboardButton.Location = new Point(519, 140);
            copyToClipboardButton.Name = "copyToClipboardButton";
            copyToClipboardButton.Size = new Size(137, 29);
            copyToClipboardButton.TabIndex = 10;
            copyToClipboardButton.Text = "Copy to Clipboard";
            copyToClipboardButton.UseVisualStyleBackColor = true;
            copyToClipboardButton.Click += copyToClipboardButton_Click;
            // 
            // modeToggleButton
            // 
            modeToggleButton.Location = new Point(60, 183);
            modeToggleButton.Name = "modeToggleButton";
            modeToggleButton.Size = new Size(122, 29);
            modeToggleButton.TabIndex = 11;
            modeToggleButton.UseVisualStyleBackColor = true;
            modeToggleButton.Click += modeToggleButton_Click;
            // 
            // cutePasswordButton
            // 
            cutePasswordButton.Location = new Point(347, 175);
            cutePasswordButton.Name = "cutePasswordButton";
            cutePasswordButton.Size = new Size(304, 40);
            cutePasswordButton.TabIndex = 12;
            cutePasswordButton.Text = "Generate Cute Password";
            cutePasswordButton.UseVisualStyleBackColor = true;
            // 
            // animalPasswordButton
            // 
            animalPasswordButton.Location = new Point(347, 221);
            animalPasswordButton.Name = "animalPasswordButton";
            animalPasswordButton.Size = new Size(304, 40);
            animalPasswordButton.TabIndex = 13;
            animalPasswordButton.Text = "Generate Animal Password";
            animalPasswordButton.UseVisualStyleBackColor = true;
            // 
            // sportsPasswordButton
            // 
            sportsPasswordButton.Location = new Point(347, 267);
            sportsPasswordButton.Name = "sportsPasswordButton";
            sportsPasswordButton.Size = new Size(304, 40);
            sportsPasswordButton.TabIndex = 14;
            sportsPasswordButton.Text = "Generate Sports Password";
            sportsPasswordButton.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 322);
            label2.Name = "label2";
            label2.Size = new Size(177, 15);
            label2.TabIndex = 15;
            label2.Text = "Made by DevCarl for CS50x 2023";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(698, 346);
            Controls.Add(label2);
            Controls.Add(sportsPasswordButton);
            Controls.Add(animalPasswordButton);
            Controls.Add(cutePasswordButton);
            Controls.Add(modeToggleButton);
            Controls.Add(copyToClipboardButton);
            Controls.Add(generatePasswordButton);
            Controls.Add(label3);
            Controls.Add(passwordLabel);
            Controls.Add(resultTextBox);
            Controls.Add(lengthTextBox);
            Controls.Add(specialCheckBox);
            Controls.Add(numericCheckBox);
            Controls.Add(upperCheckBox);
            Controls.Add(lowerCheckBox);
            Controls.Add(label1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Form1";
            Text = "Memorable Password Generator";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox lowerCheckBox;
        private System.Windows.Forms.CheckBox upperCheckBox;
        private System.Windows.Forms.CheckBox numericCheckBox;
        private System.Windows.Forms.CheckBox specialCheckBox;
        private System.Windows.Forms.TextBox lengthTextBox;
        private System.Windows.Forms.TextBox resultTextBox;
        private System.Windows.Forms.Label passwordLabel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button generatePasswordButton;
        private System.Windows.Forms.Button copyToClipboardButton;
        private System.Windows.Forms.Button modeToggleButton;
        private Button cutePasswordButton;
        private Button animalPasswordButton;
        private Button sportsPasswordButton;
        private Label label2;
    }
}
