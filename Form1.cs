using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WinFormsApp6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            foreach (var item in FontFamily.Families)
            {
                fonts.Items.Add(item.Name);
            }
            foreach (KnownColor knownColor in Enum.GetValues(typeof(KnownColor)))
            {
                Color color = Color.FromKnownColor(knownColor);
                colors.Items.Add(color);

            }
            for (int i = 8; i < 34; i += 2)
            {
                sizes.Items.Add(i);
            }
            sizes.Items.Add(40);
            sizes.Items.Add(48);
            sizes.Items.Add(52);
            sizes.Items.Add(60);
            sizes.Items.Add(72);
            sizes.Items.Add(80);
            sizes.Items.Add(100);
            sizes.Items.Add(200);
        }

        private void boldButton_Click(object sender, EventArgs e)
        {
            notepad.SelectAll();
            notepad.SelectionFont = new Font(notepad.Font, FontStyle.Bold);
            notepad.SelectionLength = 0;
        }

        private void underlineButton_Click(object sender, EventArgs e)
        {
            notepad.SelectAll();
            notepad.SelectionFont = new Font(notepad.Font, FontStyle.Underline);
            notepad.SelectionLength = 0;
        }

        private void italicButton_Click(object sender, EventArgs e)
        {
            notepad.SelectAll();
            notepad.SelectionFont = new Font(notepad.Font, FontStyle.Italic);
            notepad.SelectionLength = 0;
        }

        private void left_all_Click(object sender, EventArgs e)
        {
            notepad.SelectionAlignment = HorizontalAlignment.Left;
        }

        private void mid_all_Click(object sender, EventArgs e)
        {
            notepad.SelectionAlignment = HorizontalAlignment.Center;
        }

        private void right_all_Click(object sender, EventArgs e)
        {
            notepad.SelectionAlignment = HorizontalAlignment.Right;
        }

        private void fonts_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedFontName = fonts.SelectedItem.ToString();
            FontFamily selectedFontFamily = new FontFamily(selectedFontName);

            notepad.SelectionFont = new Font(selectedFontFamily, notepad.Font.Size);
        }

        private void sizes_SelectedIndexChanged(object sender, EventArgs e)
        {
            int selectedSize = Convert.ToInt32(sizes.SelectedItem);
            notepad.SelectionFont = new Font(notepad.Font.FontFamily, selectedSize);
        }

        private void colors_SelectedIndexChanged(object sender, EventArgs e)
        {
            Color selectedColor = (Color)colors.SelectedItem;

            notepad.SelectionColor = selectedColor;
        }

        private void loadFile_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string? fileName = openFileDialog1.FileName;
                string? text = File.ReadAllText(fileName);
                notepad.Text = text;
            }
        }

        private void saveFile_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string? text = notepad.Text;
                if (!File.Exists(saveFileDialog1.FileName))
                {
                    File.WriteAllText(saveFileDialog1.FileName, text);
                }
                else
                {
                    File.AppendAllText(saveFileDialog1.FileName, text);
                }
            }
        }
    }
}
