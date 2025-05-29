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
        new Question { Name = "Which device connects multiple networks together?", A = "Router", B = "Switch", Correct = "a" },
        new Question { Name = "What is the basic unit of data in a computer?", A = "Bit", B = "Byte", Correct = "a" },
        new Question { Name = "Which protocol is used for assigning IP addresses dynamically?", A = "DNS", B = "DHCP", Correct = "b" },
        new Question { Name = "What does 'IP' stand for?", A = "Internet Protocol", B = "Internal Process", Correct = "a" },
        new Question { Name = "Which component is responsible for executing instructions?", A = "RAM", B = "CPU", Correct = "b" },
        new Question { Name = "Which cable is most commonly used in wired LANs?", A = "Ethernet", B = "HDMI", Correct = "a" },
        new Question { Name = "What does an operating system manage?", A = "Hardware and software", B = "Only software", Correct = "a" },
        new Question { Name = "Which of these is an example of an operating system?", A = "Linux", B = "BIOS", Correct = "a" },
        new Question { Name = "What does BIOS stand for?", A = "Basic Input Output System", B = "Binary Input Output Structure", Correct = "a" },
        new Question { Name = "Which layer of the OSI model handles routing?", A = "Network layer", B = "Data link layer", Correct = "a" },
        new Question { Name = "What is the loopback IP address?", A = "192.168.0.1", B = "127.0.0.1", Correct = "b" },
        new Question { Name = "What is the main function of RAM?", A = "Temporary data storage", B = "Permanent data storage", Correct = "a" }
    };

            public static List<Question> Inf03Questions = new List<Question>
    {
        new Question { Name = "Which language is used to style HTML pages?", A = "CSS", B = "SQL", Correct = "a" },
        new Question { Name = "Which tag is used to create a hyperlink in HTML?", A = "<a>", B = "<link>", Correct = "a" },
        new Question { Name = "Which SQL command retrieves data?", A = "SELECT", B = "GET", Correct = "a" },
        new Question { Name = "What does HTML stand for?", A = "HyperText Markup Language", B = "Home Tool Markup Language", Correct = "a" },
        new Question { Name = "Which tag defines a table row in HTML?", A = "<td>", B = "<tr>", Correct = "b" },
        new Question { Name = "What is the correct SQL clause to filter records?", A = "WHERE", B = "FILTER", Correct = "a" },
        new Question { Name = "Which HTTP method is used to send data to a server?", A = "POST", B = "GET", Correct = "a" },
        new Question { Name = "Which database system is relational?", A = "MongoDB", B = "MySQL", Correct = "b" },
        new Question { Name = "Which language is used for client-side scripting?", A = "JavaScript", B = "PHP", Correct = "a" },
        new Question { Name = "What does SQL stand for?", A = "System Question Language", B = "Structured Query Language", Correct = "b" },
        new Question { Name = "Which attribute is used to define a form input type?", A = "type", B = "class", Correct = "a" },
        new Question { Name = "What is the purpose of a foreign key in a database?", A = "To link two tables", B = "To make queries faster", Correct = "a" }
    };

            public static List<Question> Inf04Questions = new List<Question>
    {
        new Question { Name = "Which language is commonly used for Android apps?", A = "Java", B = "Swift", Correct = "a" },
        new Question { Name = "Which language is used to build iOS apps?", A = "Java", B = "Swift", Correct = "b" },
        new Question { Name = "What is the purpose of Flutter?", A = "Building cross-platform apps", B = "Managing databases", Correct = "a" },
        new Question { Name = "Which platform uses .NET for app development?", A = "Windows", B = "Linux", Correct = "a" },
        new Question { Name = "Which command creates a new React app?", A = "npx create-react-app", B = "npm new react", Correct = "a" },
        new Question { Name = "What is the entry point of a Java program?", A = "main()", B = "start()", Correct = "a" },
        new Question { Name = "Which language is used in WPF applications?", A = "C#", B = "Java", Correct = "a" },
        new Question { Name = "What is Xamarin used for?", A = "Web hosting", B = "Mobile app development", Correct = "b" },
        new Question { Name = "What does 'responsive design' mean?", A = "Design that adapts to screen sizes", B = "Design with animations", Correct = "a" },
        new Question { Name = "Which protocol is commonly used by REST APIs?", A = "HTTP", B = "FTP", Correct = "a" },
        new Question { Name = "What is MVVM in software development?", A = "Main Variable View Model", B = "Model View ViewModel", Correct = "b" },
        new Question { Name = "Which method is used to render React components?", A = "render()", B = "display()", Correct = "a" }
    };

            public static List<Question> ItQuestions = new List<Question>
    {
        new Question { Name = "What does RAM stand for?", A = "Random Access Memory", B = "Read After Memory", Correct = "a" },
        new Question { Name = "What is an operating system?", A = "System that manages computer hardware and software", B = "A type of programming language", Correct = "a" },
        new Question { Name = "Which device is an output device?", A = "Keyboard", B = "Monitor", Correct = "b" },
        new Question { Name = "Which of the following is a type of software?", A = "Printer", B = "Spreadsheet", Correct = "b" },
        new Question { Name = "Which one is a frontend framework?", A = "React", B = "Node.js", Correct = "a" },
        new Question { Name = "What does CSS stand for?", A = "Cascading Style Sheets", B = "Computer Style Syntax", Correct = "a" },
        new Question { Name = "What is an IDE?", A = "Integrated Development Environment", B = "Internet Data Exchange", Correct = "a" },
        new Question { Name = "Which programming language is mainly used for web scripting?", A = "C#", B = "JavaScript", Correct = "b" },
        new Question { Name = "What does URL stand for?", A = "Uniform Resource Locator", B = "Universal Redirect Link", Correct = "a" },
        new Question { Name = "Which component stores long-term data?", A = "Hard Drive", B = "RAM", Correct = "a" },
        new Question { Name = "What is the purpose of antivirus software?", A = "To protect the system from malware", B = "To format the hard drive", Correct = "a" },
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
        new Question { Name = "Which word is an adjective?", A = "quickly", B = "quick", Correct = "b" },
        new Question { Name = "What is the correct form: He ___ playing football.", A = "is", B = "are", Correct = "a" },
        new Question { Name = "What is the superlative of 'fast'?", A = "fastest", B = "more fast", Correct = "a" },
        new Question { Name = "Which word is a verb?", A = "run", B = "runner", Correct = "a" },
        new Question { Name = "What is the past participle of 'eat'?", A = "eaten", B = "ate", Correct = "a" }
    };

            public static List<Question> GermanQuestions = new List<Question>
    {
        new Question { Name = "What is the German word for 'cat'?", A = "Katze", B = "Hund", Correct = "a" },
        new Question { Name = "What is the correct definite article for 'Tisch' (table)?", A = "der", B = "die", Correct = "a" },
        new Question { Name = "How do you say 'thank you' in German?", A = "Bitte", B = "Danke", Correct = "b" },
        new Question { Name = "What is the plural of 'Buch' (book)?", A = "Buchs", B = "Bücher", Correct = "b" },
        new Question { Name = "What is the German word for 'house'?", A = "Haus", B = "Maus", Correct = "a" },
        new Question { Name = "What case is used for the direct object?", A = "Akkusativ", B = "Nominativ", Correct = "a" },
        new Question { Name = "Which article goes with 'Mädchen' (girl)?", A = "das", B = "die", Correct = "a" },
        new Question { Name = "How do you say 'good morning' in German?", A = "Guten Morgen", B = "Guten Abend", Correct = "a" },
        new Question { Name = "How do you say 'goodbye' in German?", A = "Hallo", B = "Auf Wiedersehen", Correct = "b" },
        new Question { Name = "Which is a German verb?", A = "gehen", B = "grün", Correct = "a" },
        new Question { Name = "What is the question word for 'where'?", A = "wo", B = "wann", Correct = "a" },
        new Question { Name = "How do you say 'My name is...' in German?", A = "Ich heiße...", B = "Ich bin...", Correct = "a" }
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
