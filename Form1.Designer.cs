namespace WinFormsApp1
{
    partial class QuizApp
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(QuizApp));
            label1 = new Label();
            panel1 = new Panel();
            germanradioButton = new RadioButton();
            englishradioButton = new RadioButton();
            itradioButton = new RadioButton();
            inf04radioButton = new RadioButton();
            inf03radioButton = new RadioButton();
            inf02radioButton = new RadioButton();
            questionLabel = new Label();
            answerAButton = new Button();
            AnswersPanel = new Panel();
            answerBButton = new Button();
            label2 = new Label();
            scoreLabel = new Label();
            closeButton = new Button();
            startButton = new Button();
            pictureBox1 = new PictureBox();
            panel1.SuspendLayout();
            AnswersPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label1.Location = new Point(76, 49);
            label1.Name = "label1";
            label1.Size = new Size(114, 21);
            label1.TabIndex = 0;
            label1.Text = "Wybierz quiz:";
            // 
            // panel1
            // 
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(germanradioButton);
            panel1.Controls.Add(englishradioButton);
            panel1.Controls.Add(itradioButton);
            panel1.Controls.Add(inf04radioButton);
            panel1.Controls.Add(inf03radioButton);
            panel1.Controls.Add(inf02radioButton);
            panel1.Location = new Point(52, 86);
            panel1.Name = "panel1";
            panel1.Size = new Size(166, 169);
            panel1.TabIndex = 1;
            // 
            // germanradioButton
            // 
            germanradioButton.AutoSize = true;
            germanradioButton.Location = new Point(24, 139);
            germanradioButton.Name = "germanradioButton";
            germanradioButton.Size = new Size(67, 19);
            germanradioButton.TabIndex = 5;
            germanradioButton.TabStop = true;
            germanradioButton.Text = "German";
            germanradioButton.UseVisualStyleBackColor = true;
            // 
            // englishradioButton
            // 
            englishradioButton.AutoSize = true;
            englishradioButton.Location = new Point(24, 114);
            englishradioButton.Name = "englishradioButton";
            englishradioButton.Size = new Size(63, 19);
            englishradioButton.TabIndex = 4;
            englishradioButton.TabStop = true;
            englishradioButton.Text = "English";
            englishradioButton.UseVisualStyleBackColor = true;
            // 
            // itradioButton
            // 
            itradioButton.AutoSize = true;
            itradioButton.Location = new Point(24, 89);
            itradioButton.Name = "itradioButton";
            itradioButton.Size = new Size(35, 19);
            itradioButton.TabIndex = 3;
            itradioButton.TabStop = true;
            itradioButton.Text = "IT";
            itradioButton.UseVisualStyleBackColor = true;
            // 
            // inf04radioButton
            // 
            inf04radioButton.AutoSize = true;
            inf04radioButton.Location = new Point(24, 64);
            inf04radioButton.Name = "inf04radioButton";
            inf04radioButton.Size = new Size(58, 19);
            inf04radioButton.TabIndex = 2;
            inf04radioButton.TabStop = true;
            inf04radioButton.Text = "INF.04";
            inf04radioButton.UseVisualStyleBackColor = true;
            // 
            // inf03radioButton
            // 
            inf03radioButton.AutoSize = true;
            inf03radioButton.Location = new Point(24, 39);
            inf03radioButton.Name = "inf03radioButton";
            inf03radioButton.Size = new Size(58, 19);
            inf03radioButton.TabIndex = 1;
            inf03radioButton.TabStop = true;
            inf03radioButton.Text = "INF.03";
            inf03radioButton.UseVisualStyleBackColor = true;
            // 
            // inf02radioButton
            // 
            inf02radioButton.AutoSize = true;
            inf02radioButton.Location = new Point(24, 14);
            inf02radioButton.Name = "inf02radioButton";
            inf02radioButton.Size = new Size(58, 19);
            inf02radioButton.TabIndex = 0;
            inf02radioButton.TabStop = true;
            inf02radioButton.Text = "INF.02";
            inf02radioButton.UseVisualStyleBackColor = true;
            // 
            // questionLabel
            // 
            questionLabel.Location = new Point(-1, -1);
            questionLabel.Name = "questionLabel";
            questionLabel.Size = new Size(203, 49);
            questionLabel.TabIndex = 2;
            questionLabel.Text = "Pytanie";
            questionLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // answerAButton
            // 
            answerAButton.BackColor = Color.FromArgb(58, 110, 255);
            answerAButton.FlatAppearance.BorderSize = 0;
            answerAButton.FlatStyle = FlatStyle.Flat;
            answerAButton.ForeColor = Color.White;
            answerAButton.Location = new Point(57, 69);
            answerAButton.Name = "answerAButton";
            answerAButton.Size = new Size(87, 33);
            answerAButton.TabIndex = 3;
            answerAButton.Text = "AnswerA";
            answerAButton.UseVisualStyleBackColor = false;
            answerAButton.Click += answerAButton_Click_1;
            // 
            // AnswersPanel
            // 
            AnswersPanel.BorderStyle = BorderStyle.FixedSingle;
            AnswersPanel.Controls.Add(answerBButton);
            AnswersPanel.Controls.Add(answerAButton);
            AnswersPanel.Controls.Add(questionLabel);
            AnswersPanel.Location = new Point(253, 49);
            AnswersPanel.Name = "AnswersPanel";
            AnswersPanel.Size = new Size(203, 206);
            AnswersPanel.TabIndex = 5;
            AnswersPanel.Visible = false;
            // 
            // answerBButton
            // 
            answerBButton.BackColor = Color.FromArgb(58, 110, 255);
            answerBButton.FlatAppearance.BorderSize = 0;
            answerBButton.FlatStyle = FlatStyle.Flat;
            answerBButton.ForeColor = Color.White;
            answerBButton.Location = new Point(57, 126);
            answerBButton.Name = "answerBButton";
            answerBButton.Size = new Size(87, 33);
            answerBButton.TabIndex = 4;
            answerBButton.Text = "AnswerB";
            answerBButton.UseVisualStyleBackColor = false;
            answerBButton.Click += answerBButton_Click_1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label2.Location = new Point(521, 39);
            label2.Name = "label2";
            label2.Size = new Size(39, 15);
            label2.TabIndex = 7;
            label2.Text = "Score";
            label2.Click += label2_Click;
            // 
            // scoreLabel
            // 
            scoreLabel.BorderStyle = BorderStyle.FixedSingle;
            scoreLabel.Location = new Point(489, 69);
            scoreLabel.Name = "scoreLabel";
            scoreLabel.Size = new Size(100, 23);
            scoreLabel.TabIndex = 8;
            scoreLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // closeButton
            // 
            closeButton.BackColor = Color.FromArgb(58, 110, 255);
            closeButton.FlatAppearance.BorderSize = 0;
            closeButton.FlatStyle = FlatStyle.Flat;
            closeButton.ForeColor = Color.White;
            closeButton.Location = new Point(253, 299);
            closeButton.Name = "closeButton";
            closeButton.Size = new Size(83, 32);
            closeButton.TabIndex = 6;
            closeButton.Text = "Zakończ";
            closeButton.UseVisualStyleBackColor = false;
            closeButton.Click += closeButton_Click;
            // 
            // startButton
            // 
            startButton.BackColor = Color.FromArgb(58, 110, 255);
            startButton.FlatAppearance.BorderSize = 0;
            startButton.FlatStyle = FlatStyle.Flat;
            startButton.ForeColor = Color.White;
            startButton.Location = new Point(156, 300);
            startButton.Name = "startButton";
            startButton.Size = new Size(83, 32);
            startButton.TabIndex = 5;
            startButton.Text = "Generate";
            startButton.UseVisualStyleBackColor = false;
            startButton.Click += startButton_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(479, 137);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(110, 94);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 9;
            pictureBox1.TabStop = false;
            // 
            // QuizApp
            // 
            AcceptButton = startButton;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(8, 9, 10);
            CancelButton = closeButton;
            ClientSize = new Size(610, 369);
            Controls.Add(pictureBox1);
            Controls.Add(startButton);
            Controls.Add(label2);
            Controls.Add(AnswersPanel);
            Controls.Add(scoreLabel);
            Controls.Add(closeButton);
            Controls.Add(panel1);
            Controls.Add(label1);
            ForeColor = Color.White;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "QuizApp";
            Text = "Form1";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            AnswersPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Panel panel1;
        private RadioButton germanradioButton;
        private RadioButton englishradioButton;
        private RadioButton itradioButton;
        private RadioButton inf04radioButton;
        private RadioButton inf03radioButton;
        private RadioButton inf02radioButton;
        private Label questionLabel;
        private Button answerAButton;
        private Panel AnswersPanel;
        private Button startButton;
        private Button closeButton;
        private Button answerBButton;
        private Label label2;
        private Label scoreLabel;
        private PictureBox pictureBox1;
    }
}
