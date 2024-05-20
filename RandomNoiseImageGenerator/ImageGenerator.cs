namespace RandomNoiseImageGenerator
{
    public partial class MainForm : Form
    {
        public List<ColourOption> colourOptions = [];

        public string filePath = string.Empty;
        public string directory = string.Empty;

        public MainForm()
        {
            InitializeComponent();
        }

        private void PickColour(object? sender, EventArgs e)
        {
            Button current = (Button)sender;

            ColorDialog dialog = new()
            {
                AllowFullOpen = true,
                ShowHelp = true,
                Color = Color.Red
            };

            int index = (int)current.Tag!;

            if (dialog.ShowDialog() == DialogResult.OK)
            {
                colourOptions[index].Colour = dialog.Color;
            }
            else
            {
                colourOptions[index].Colour = Color.White;
            }
        }

        private void SetColourCode(object? sender, EventArgs e)
        {
            TextBox current = (TextBox)sender;

            try
            {
                Color colour = ColorTranslator.FromHtml(current.Text);
                int index = (int)current.Tag!;
                colourOptions[index].Colour = colour;
                colourOptions[index].ColourPanel.BackColor = colour;
                current.ForeColor = Color.Black;
            }
            catch
            {
                current.ForeColor = Color.Red;
            }
        }

        private void SelectChance(object? sender, EventArgs e)
        {
            NumericUpDown current = (NumericUpDown)sender;
            colourOptions[(int)current.Tag!].Chance = (int)current.Value;
        }

        private void ImageSelect_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new())
            {
                openFileDialog.InitialDirectory = "c:\\";
                openFileDialog.Filter = "png files (*.png)|*.png|All files (*.*)|*.*";
                openFileDialog.FilterIndex = 2;
                openFileDialog.RestoreDirectory = true;

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    filePath = openFileDialog.FileName;
                    textBox1.Text = filePath;
                }
            }
        }

        private void OverwriteImage_Click(object sender, EventArgs e)
        {
            if (!File.Exists(filePath))
            {
                return;
            }

            string oldFilePath = Path.GetDirectoryName(filePath)!;
            string newFilePath = oldFilePath + "\\" + filename.Text + ".png";

            GenerateImage(newFilePath);

            MessageBox.Show("Saved file to: " + newFilePath);
        }

        private void GenerateImage(string filepath, Bitmap? image = null)
        {
            image ??= new Bitmap(filepath);

            for (int i = 0; i < colourOptions.Count; i++)
            {
                for (int x = 0; x < image.Width; x++)
                {
                    for (int y = 0; y < image.Height; y++)
                    {
                        Random rand = new Random();
                        int value = rand.Next(1, 101);
                        int chance = colourOptions[i].Chance;
                        if (value <= chance)
                        {
                            image.SetPixel(x, y, colourOptions[i].Colour);
                        }
                    }
                }
            }

            image.Save(filepath);
            image.Dispose();
        }

        private void addOption_Click(object sender, EventArgs e)
        {
            Panel panel = new Panel();
            panel.Size = new Size(30, 30);
            panel.BackColor = Color.White;
            panel.BorderStyle = BorderStyle.FixedSingle;
            flowLayoutPanel.Controls.Add(panel);

            Button colourPickerButton = new Button();
            colourPickerButton.Text = "Choose Colour";
            colourPickerButton.Tag = colourOptions.Count;
            colourPickerButton.Click += PickColour;
            colourPickerButton.Size = new Size(180, 30);
            flowLayoutPanel.Controls.Add(colourPickerButton);

            TextBox colourCodeBox = new TextBox();
            colourCodeBox.PlaceholderText = "#FFFFFF";
            colourCodeBox.Tag = colourOptions.Count;
            colourCodeBox.TextChanged += SetColourCode;
            colourCodeBox.Size = new Size(140, 30);
            flowLayoutPanel.Controls.Add(colourCodeBox);

            NumericUpDown chanceSelector = new NumericUpDown();
            chanceSelector.Minimum = 0;
            chanceSelector.Maximum = 100;
            chanceSelector.Tag = colourOptions.Count;
            chanceSelector.ValueChanged += SelectChance;
            chanceSelector.Size = new Size(180, 30);
            flowLayoutPanel.Controls.Add(chanceSelector);

            ColourOption colourOption = new ColourOption(panel, colourPickerButton, colourCodeBox, chanceSelector);
            colourOption.ColourChanged += ColourOption_ColourChanged;
            colourOptions.Add(colourOption);
        }

        private void ColourOption_ColourChanged(object? sender, EventArgs e)
        {
            if (sender is ColourOption current)
            {
                current.ColourPanel.BackColor = current.Colour;
                string colourCode = ColorTranslator.ToHtml(current.Colour);
                if (!current.ColourCodeBox.Focused)
                {
                    current.ColourCodeBox.Text = colourCode;
                }
            }
        }

        private void DirectorySelect_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog dialog = new FolderBrowserDialog();
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                directory = dialog.SelectedPath;
                selectedDirectoryBox.Text = directory;
            }
        }

        private void CreateImage_Click(object sender, EventArgs e)
        {
            int width = (int)widthBox.Value;
            int height = (int)heightBox.Value;
            string path = directory + "\\" + newFileNameBox.Text + ".png";

            if (!Directory.Exists(directory))
            {
                MessageBox.Show("The given directory does not exist.");
                return;
            }

            Bitmap image = new Bitmap(width, height);
            Graphics graphics = Graphics.FromImage(image);
            Rectangle ImageSize = new Rectangle(0, 0, width, height);
            graphics.FillRectangle(Brushes.White, ImageSize);

            GenerateImage(path, image);

            MessageBox.Show("Successfully created image at " + path);
        }
    }

    public class ColourOption
    {
        private Color colour;
        public Color Colour 
        {
            get { return colour; }
            set {
                colour = value;
                ColourChanged?.Invoke(this, EventArgs.Empty);
            }
        }
        public int Chance { get; set; }
        public Panel ColourPanel { get; set; }
        public Button ColourPicker { get; set; }
        public TextBox ColourCodeBox { get; set; }
        public NumericUpDown ChanceSelector { get; set; }

        public ColourOption(Panel colourPanel, Button colourPicker, TextBox colourCodeBox, NumericUpDown chanceSelector) 
        {
            Colour = Color.White;
            Chance = 0;

            ColourPanel = colourPanel;
            ColourPicker = colourPicker;
            ColourCodeBox = colourCodeBox;
            ChanceSelector = chanceSelector;
        }

        public event EventHandler ColourChanged;
    }
}

