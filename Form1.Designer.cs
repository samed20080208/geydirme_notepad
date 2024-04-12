namespace WinFormsApp6
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
            notepad = new RichTextBox();
            fonts = new ComboBox();
            label1 = new Label();
            label2 = new Label();
            sizes = new ComboBox();
            label3 = new Label();
            boldButton = new Button();
            underlineButton = new Button();
            italicButton = new Button();
            label4 = new Label();
            right_all = new Button();
            mid_all = new Button();
            left_all = new Button();
            label5 = new Label();
            colors = new ComboBox();
            loadFile = new Button();
            saveFile = new Button();
            fontDialog1 = new FontDialog();
            colorDialog1 = new ColorDialog();
            openFileDialog1 = new OpenFileDialog();
            saveFileDialog1 = new SaveFileDialog();
            SuspendLayout();
            // 
            // notepad
            // 
            notepad.Font = new Font("Segoe UI", 8.25F, FontStyle.Underline, GraphicsUnit.Point);
            notepad.Location = new Point(12, 72);
            notepad.Name = "notepad";
            notepad.Size = new Size(776, 366);
            notepad.TabIndex = 0;
            notepad.Text = "";
            // 
            // fonts
            // 
            fonts.BackColor = SystemColors.ButtonHighlight;
            fonts.ForeColor = SystemColors.ControlDarkDark;
            fonts.FormattingEnabled = true;
            fonts.Location = new Point(12, 41);
            fonts.Name = "fonts";
            fonts.Size = new Size(112, 23);
            fonts.TabIndex = 1;
            fonts.SelectedIndexChanged += fonts_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Calibri", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.ControlDarkDark;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(58, 29);
            label1.TabIndex = 2;
            label1.Text = "Font";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Calibri", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = SystemColors.ControlDarkDark;
            label2.Location = new Point(148, 9);
            label2.Name = "label2";
            label2.Size = new Size(50, 29);
            label2.TabIndex = 3;
            label2.Text = "Size";
            // 
            // sizes
            // 
            sizes.BackColor = SystemColors.ButtonHighlight;
            sizes.ForeColor = SystemColors.ControlDarkDark;
            sizes.FormattingEnabled = true;
            sizes.Location = new Point(153, 41);
            sizes.Name = "sizes";
            sizes.Size = new Size(40, 23);
            sizes.TabIndex = 4;
            sizes.SelectedIndexChanged += sizes_SelectedIndexChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Calibri", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = SystemColors.ControlDarkDark;
            label3.Location = new Point(228, 9);
            label3.Name = "label3";
            label3.Size = new Size(111, 29);
            label3.TabIndex = 5;
            label3.Text = "Font Style";
            // 
            // boldButton
            // 
            boldButton.Font = new Font("Segoe UI Black", 8.25F, FontStyle.Bold, GraphicsUnit.Point);
            boldButton.ForeColor = SystemColors.ActiveCaptionText;
            boldButton.Location = new Point(233, 41);
            boldButton.Name = "boldButton";
            boldButton.Size = new Size(29, 23);
            boldButton.TabIndex = 6;
            boldButton.Text = "B";
            boldButton.UseVisualStyleBackColor = true;
            boldButton.Click += boldButton_Click;
            // 
            // underlineButton
            // 
            underlineButton.Font = new Font("Segoe UI", 8.25F, FontStyle.Underline, GraphicsUnit.Point);
            underlineButton.ForeColor = SystemColors.ActiveCaptionText;
            underlineButton.Location = new Point(268, 41);
            underlineButton.Name = "underlineButton";
            underlineButton.Size = new Size(29, 23);
            underlineButton.TabIndex = 7;
            underlineButton.Text = "U";
            underlineButton.UseVisualStyleBackColor = true;
            underlineButton.Click += underlineButton_Click;
            // 
            // italicButton
            // 
            italicButton.Font = new Font("Segoe UI Semibold", 8.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            italicButton.ForeColor = SystemColors.ActiveCaptionText;
            italicButton.Location = new Point(303, 41);
            italicButton.Name = "italicButton";
            italicButton.Size = new Size(29, 23);
            italicButton.TabIndex = 8;
            italicButton.Text = "I";
            italicButton.UseVisualStyleBackColor = true;
            italicButton.Click += italicButton_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Calibri", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label4.ForeColor = SystemColors.ControlDarkDark;
            label4.Location = new Point(367, 9);
            label4.Name = "label4";
            label4.Size = new Size(128, 29);
            label4.TabIndex = 9;
            label4.Text = "Alingnment";
            // 
            // right_all
            // 
            right_all.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            right_all.ForeColor = SystemColors.ActiveCaptionText;
            right_all.Location = new Point(449, 40);
            right_all.Name = "right_all";
            right_all.Size = new Size(29, 23);
            right_all.TabIndex = 12;
            right_all.Text = "R";
            right_all.UseVisualStyleBackColor = true;
            right_all.Click += right_all_Click;
            // 
            // mid_all
            // 
            mid_all.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            mid_all.ForeColor = SystemColors.ActiveCaptionText;
            mid_all.Location = new Point(414, 40);
            mid_all.Name = "mid_all";
            mid_all.Size = new Size(29, 23);
            mid_all.TabIndex = 11;
            mid_all.Text = "M";
            mid_all.UseVisualStyleBackColor = true;
            mid_all.Click += mid_all_Click;
            // 
            // left_all
            // 
            left_all.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            left_all.ForeColor = SystemColors.ActiveCaptionText;
            left_all.Location = new Point(379, 40);
            left_all.Name = "left_all";
            left_all.Size = new Size(29, 23);
            left_all.TabIndex = 10;
            left_all.Text = "L";
            left_all.UseVisualStyleBackColor = true;
            left_all.Click += left_all_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Calibri", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label5.ForeColor = SystemColors.ControlDarkDark;
            label5.Location = new Point(513, 9);
            label5.Name = "label5";
            label5.Size = new Size(66, 29);
            label5.TabIndex = 13;
            label5.Text = "Color";
            // 
            // colors
            // 
            colors.BackColor = SystemColors.ButtonHighlight;
            colors.ForeColor = SystemColors.ControlDarkDark;
            colors.FormattingEnabled = true;
            colors.Location = new Point(513, 40);
            colors.Name = "colors";
            colors.Size = new Size(115, 23);
            colors.TabIndex = 14;
            colors.SelectedIndexChanged += colors_SelectedIndexChanged;
            // 
            // loadFile
            // 
            loadFile.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            loadFile.ForeColor = SystemColors.ControlDarkDark;
            loadFile.Location = new Point(671, 9);
            loadFile.Name = "loadFile";
            loadFile.Size = new Size(117, 23);
            loadFile.TabIndex = 15;
            loadFile.Text = "Load file";
            loadFile.UseVisualStyleBackColor = true;
            loadFile.Click += loadFile_Click;
            // 
            // saveFile
            // 
            saveFile.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            saveFile.ForeColor = SystemColors.ControlDarkDark;
            saveFile.Location = new Point(671, 38);
            saveFile.Name = "saveFile";
            saveFile.Size = new Size(117, 23);
            saveFile.TabIndex = 16;
            saveFile.Text = "Save file";
            saveFile.UseVisualStyleBackColor = true;
            saveFile.Click += saveFile_Click;
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(saveFile);
            Controls.Add(loadFile);
            Controls.Add(colors);
            Controls.Add(label5);
            Controls.Add(right_all);
            Controls.Add(mid_all);
            Controls.Add(left_all);
            Controls.Add(label4);
            Controls.Add(italicButton);
            Controls.Add(underlineButton);
            Controls.Add(boldButton);
            Controls.Add(label3);
            Controls.Add(sizes);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(fonts);
            Controls.Add(notepad);
            ForeColor = SystemColors.AppWorkspace;
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private RichTextBox notepad;
        private ComboBox fonts;
        private Label label1;
        private Label label2;
        private ComboBox sizes;
        private Label label3;
        private Button boldButton;
        private Button underlineButton;
        private Button italicButton;
        private Label label4;
        private Button right_all;
        private Button mid_all;
        private Button left_all;
        private Label label5;
        private ComboBox colors;
        private Button loadFile;
        private Button saveFile;
        private FontDialog fontDialog1;
        private ColorDialog colorDialog1;
        private OpenFileDialog openFileDialog1;
        private SaveFileDialog saveFileDialog1;
    }
}
