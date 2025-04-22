using System.Text;

namespace string_gui {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();

            sentenceInput.Text = Properties.Settings.Default.cacheSentenceInput.ToString();
        }

        private void label2_Click(object sender, EventArgs e) {

        }

        private void button1_Click(object sender, EventArgs e) {
            String input;

            try {
                input = this.sentenceInput.Text;
            } catch(FormatException) {
                return;
            }

            Properties.Settings.Default.cacheSentenceInput = input;
            Properties.Settings.Default.Save();

            MessageBox.Show(Logic.processText(input));
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
