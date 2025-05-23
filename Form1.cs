using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class QuizApp : Form
    {
        private Question currentQuestion;
        private Random random = new Random();
        private int score = 0;
        private List<Question> questionPool;
        private HashSet<int> askedQuestions = new HashSet<int>();

        public QuizApp()
        {
            InitializeComponent();
            AnswersPanel.Visible = false;

            try
            {
                if (File.Exists("score.txt"))
                {
                    string[] lines = File.ReadAllLines("score.txt");
                    if (lines.Length > 0)
                    {
                        string line = lines[0];
                        var parts = line.Split(':');
                        if (parts.Length > 1 && int.TryParse(parts[1].Trim(), out int savedScore))
                        {
                            score = savedScore;
                        }
                        else
                        {
                            score = 0;
                        }
                    }
                    else
                    {
                        score = 0;
                    }
                }
                else
                {
                    score = 0;
                }
            }
            catch
            {
                score = 0;
            }

            scoreLabel.Text = score.ToString();
        }

        public class Question
        {
            public string Name { get; set; }
            public string A { get; set; }
            public string B { get; set; }
            public string Correct { get; set; }
        }

        public static class QuizData
        {
            public static List<Question> Inf02Questions = new List<Question>
            {
                new Question { Name = "What will `console.log(typeof null)` return?", A = "'null'", B = "'object'", Correct = "b" },
                new Question { Name = "Which of these is a primitive type in C#?", A = "string", B = "class", Correct = "a" },
                new Question { Name = "What keyword is used to define a constant in C#?", A = "const", B = "static", Correct = "a" },
                new Question { Name = "What does the 'static' keyword do?", A = "Instance method", B = "Belongs to class", Correct = "b" },
                new Question { Name = "What is the default access modifier for class members in C#?", A = "private", B = "public", Correct = "a" },
                new Question { Name = "Which operator is used for equality in C#?", A = "==", B = "=", Correct = "a" },
                new Question { Name = "How do you write a single-line comment in C#?", A = "// comment", B = "/* comment */", Correct = "a" },
                new Question { Name = "What is the correct way to declare a method?", A = "void MethodName() {}", B = "function MethodName() {}", Correct = "a" }
            };

            public static List<Question> Inf03Questions = new List<Question>
            {
                new Question { Name = "Which SQL command is used to fetch data?", A = "SELECT", B = "UPDATE", Correct = "a" },
                new Question { Name = "What does CPU stand for?", A = "Central Processing Unit", B = "Computer Personal Unit", Correct = "a" },
                new Question { Name = "Which SQL clause is used to filter results?", A = "WHERE", B = "FILTER", Correct = "a" },
                new Question { Name = "Which command deletes all rows from a table?", A = "DELETE", B = "DROP", Correct = "a" },
                new Question { Name = "What type of language is SQL?", A = "Query Language", B = "Programming Language", Correct = "a" },
                new Question { Name = "Which command is used to add data to a table?", A = "INSERT INTO", B = "ADD ROW", Correct = "a" },
                new Question { Name = "What does RAM stand for?", A = "Random Access Memory", B = "Read Access Memory", Correct = "a" },
                new Question { Name = "What is the main function of an operating system?", A = "Manage hardware", B = "Write software", Correct = "a" }
            };

            public static List<Question> Inf04Questions = new List<Question>
            {
                new Question { Name = "What is the purpose of Git?", A = "Version control", B = "Database management", Correct = "a" },
                new Question { Name = "Which protocol is used to transfer web pages?", A = "HTTP", B = "FTP", Correct = "a" },
                new Question { Name = "What command initializes a Git repository?", A = "git init", B = "git start", Correct = "a" },
                new Question { Name = "What does HTTPS stand for?", A = "Secure HTTP", B = "HyperText Transfer Protocol", Correct = "a" },
                new Question { Name = "Which tool is used for containerization?", A = "Docker", B = "Kubernetes", Correct = "a" },
                new Question { Name = "What is continuous integration?", A = "Automated testing", B = "Manual coding", Correct = "a" },
                new Question { Name = "Which language is mainly used for Android development?", A = "Java", B = "Swift", Correct = "a" },
                new Question { Name = "What does API stand for?", A = "Application Programming Interface", B = "Application Process Integration", Correct = "a" }
            };

            public static List<Question> ItQuestions = new List<Question>
            {
                new Question { Name = "What does RAM stand for?", A = "Random Access Memory", B = "Read After Memory", Correct = "a" },
                new Question { Name = "Which one is a frontend framework?", A = "React", B = "Node.js", Correct = "a" },
                new Question { Name = "What does CSS stand for?", A = "Cascading Style Sheets", B = "Computer Style Syntax", Correct = "a" },
                new Question { Name = "What is the main language used to program iOS apps?", A = "Swift", B = "Java", Correct = "a" },
                new Question { Name = "Which database is relational?", A = "MySQL", B = "MongoDB", Correct = "a" },
                new Question { Name = "Which tool is used for virtualization?", A = "VirtualBox", B = "Docker", Correct = "a" },
                new Question { Name = "What is an IDE?", A = "Integrated Development Environment", B = "Internet Data Exchange", Correct = "a" },
                new Question { Name = "Which language is used for backend in Node.js?", A = "JavaScript", B = "Python", Correct = "a" }
            };

            public static List<Question> EnglishQuestions = new List<Question>
            {
                new Question { Name = "What is the past tense of 'go'?", A = "went", B = "goed", Correct = "a" },
                new Question { Name = "Choose the correct article: ___ apple", A = "a", B = "an", Correct = "b" },
                new Question { Name = "Which is a synonym of 'happy'?", A = "sad", B = "joyful", Correct = "b" },
                new Question { Name = "What is the plural form of 'mouse'?", A = "mouses", B = "mice", Correct = "b" },
                new Question { Name = "Select the correct form: I ___ to the store yesterday.", A = "go", B = "went", Correct = "b" },
                new Question { Name = "What is the opposite of 'big'?", A = "small", B = "tall", Correct = "a" },
                new Question { Name = "Choose the correct preposition: She is good ___ tennis.", A = "at", B = "in", Correct = "a" },
                new Question { Name = "Which word is an adjective?", A = "quickly", B = "quick", Correct = "b" }
            };

            public static List<Question> GermanQuestions = new List<Question>
            {
                new Question { Name = "What is the German word for 'cat'?", A = "Katze", B = "Hund", Correct = "a" },
                new Question { Name = "What is the correct definite article for 'Tisch' (table)?", A = "der", B = "die", Correct = "a" },
                new Question { Name = "How do you say 'thank you' in German?", A = "Danke", B = "Bitte", Correct = "a" },
                new Question { Name = "What is the plural of 'Buch' (book)?", A = "Bücher", B = "Buchs", Correct = "a" },
                new Question { Name = "What is the German word for 'house'?", A = "Haus", B = "Maus", Correct = "a" },
                new Question { Name = "What case is used for the direct object?", A = "Akkusativ", B = "Nominativ", Correct = "a" },
                new Question { Name = "Which article goes with 'Mädchen' (girl)?", A = "das", B = "die", Correct = "a" },
                new Question { Name = "How do you say 'good morning' in German?", A = "Guten Morgen", B = "Guten Abend", Correct = "a" }
            };
        }

        private void startButton_Click(object sender, EventArgs e)
        {
            AnswersPanel.Visible = true;
            askedQuestions.Clear();

            if (inf02radioButton.Checked)
                questionPool = QuizData.Inf02Questions;
            else if (inf03radioButton.Checked)
                questionPool = QuizData.Inf03Questions;
            else if (inf04radioButton.Checked)
                questionPool = QuizData.Inf04Questions;
            else if (itradioButton.Checked)
                questionPool = QuizData.ItQuestions;
            else if (englishradioButton.Checked)
                questionPool = QuizData.EnglishQuestions;
            else if (germanradioButton.Checked)
                questionPool = QuizData.GermanQuestions;
            else
                questionPool = null;

            if (questionPool == null || questionPool.Count == 0)
            {
                MessageBox.Show("Please select a category or there are no questions.");
                return;
            }

            LoadNextQuestion();
        }

        private void LoadNextQuestion()
        {
            if (askedQuestions.Count == questionPool.Count)
            {
                MessageBox.Show($"Quiz finished! Your final score: {score}");
                AnswersPanel.Visible = false;
                return;
            }

            int idx;
            do
            {
                idx = random.Next(questionPool.Count);
            } while (askedQuestions.Contains(idx));

            askedQuestions.Add(idx);
            currentQuestion = questionPool[idx];

            questionLabel.Text = currentQuestion.Name;
            answerAButton.Text = currentQuestion.A;
            answerBButton.Text = currentQuestion.B;
        }

        private void CheckAnswer(string selected)
        {
            if (currentQuestion == null)
            {
                MessageBox.Show("No question selected. Please start the quiz.");
                return;
            }

            if (selected == currentQuestion.Correct)
            {
                score++;
                MessageBox.Show("Correct!");
            }
            else
            {
                score--;
                MessageBox.Show($"Wrong! Correct answer was '{(currentQuestion.Correct == "a" ? currentQuestion.A : currentQuestion.B)}'");
            }

            scoreLabel.Text = $"{score}";

            try
            {
                File.WriteAllText("score.txt", $"Current Score: {score}{Environment.NewLine}Date: {DateTime.Now}");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error saving score: {ex.Message}");
            }

            LoadNextQuestion();
        }

        private void answerAButton_Click_1(object sender, EventArgs e)
        {
            CheckAnswer("a");
        }

        private void answerBButton_Click_1(object sender, EventArgs e)
        {
            CheckAnswer("b");
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label2_Click(object sender, EventArgs e)
        {
          
        }
    }
}
