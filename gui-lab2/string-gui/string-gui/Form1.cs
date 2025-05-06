using System.Text;

namespace string_gui {
    public partial class Form1 : Form {
        // ¬ тексте удалить каждое слово с четным числом символов, продублировать каждое слово с нечетным
        // числом символов, заменив все вхождени€ букв СdТ на букву СtТ .
        public Form1() {
            InitializeComponent();
            this.Text = "Lab2";

            sentenceInput.Text = Properties.Settings.Default.cacheSentenceInput.ToString();
        }

        private void button1_Click(object sender, EventArgs e) {
            String input;

            try {
                input = this.sentenceInput.Text;
            } catch (FormatException) {
                return;
            }

            Properties.Settings.Default.cacheSentenceInput = input;
            Properties.Settings.Default.Save();

            MessageBox.Show(Logic.processText(input));
        }

        private void Form1_Load(object sender, EventArgs e) {

        }
    }

    public static class Logic {
        public static string processText(string Input) {
            string[] Words = Input.Split(new char[] { ' ', '.', ',', '!', '?' }, StringSplitOptions.RemoveEmptyEntries);
            StringBuilder SB = new StringBuilder();
            foreach (string Word in Words) {
                if (Word.Length % 2 != 0) {
                    string doubledWord = Word + " " + Word;
                    string modifiedWord = doubledWord.Replace('d', 't');
                    SB.Append(modifiedWord + " ");
                }
            }
            return SB.ToString();
        }
    }
}
