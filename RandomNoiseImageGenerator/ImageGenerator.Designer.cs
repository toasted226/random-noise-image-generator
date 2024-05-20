namespace RandomNoiseImageGenerator
{
    partial class MainForm
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
            ImageSelect = new Button();
            textBox1 = new TextBox();
            OverwriteImage = new Button();
            label1 = new Label();
            filename = new TextBox();
            addOption = new Button();
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            tabPage2 = new TabPage();
            CreateImage = new Button();
            selectedDirectoryBox = new TextBox();
            DirectorySelect = new Button();
            newFileNameBox = new TextBox();
            label4 = new Label();
            heightBox = new NumericUpDown();
            widthBox = new NumericUpDown();
            label3 = new Label();
            label2 = new Label();
            flowLayoutPanel = new FlowLayoutPanel();
            panel1 = new Panel();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)heightBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)widthBox).BeginInit();
            SuspendLayout();
            // 
            // ImageSelect
            // 
            ImageSelect.Location = new Point(6, 6);
            ImageSelect.Name = "ImageSelect";
            ImageSelect.Size = new Size(124, 29);
            ImageSelect.TabIndex = 2;
            ImageSelect.Text = "Choose Image";
            ImageSelect.UseVisualStyleBackColor = true;
            ImageSelect.Click += ImageSelect_Click;
            // 
            // textBox1
            // 
            textBox1.Enabled = false;
            textBox1.Location = new Point(136, 8);
            textBox1.Name = "textBox1";
            textBox1.ReadOnly = true;
            textBox1.Size = new Size(430, 27);
            textBox1.TabIndex = 3;
            // 
            // OverwriteImage
            // 
            OverwriteImage.Location = new Point(6, 74);
            OverwriteImage.Name = "OverwriteImage";
            OverwriteImage.Size = new Size(560, 29);
            OverwriteImage.TabIndex = 4;
            OverwriteImage.Text = "Create Image";
            OverwriteImage.UseVisualStyleBackColor = true;
            OverwriteImage.Click += OverwriteImage_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(6, 44);
            label1.Name = "label1";
            label1.Size = new Size(113, 20);
            label1.TabIndex = 5;
            label1.Text = "New File Name:";
            label1.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // filename
            // 
            filename.Location = new Point(136, 41);
            filename.Name = "filename";
            filename.Size = new Size(430, 27);
            filename.TabIndex = 6;
            // 
            // addOption
            // 
            addOption.Location = new Point(26, 228);
            addOption.Name = "addOption";
            addOption.Size = new Size(134, 29);
            addOption.TabIndex = 8;
            addOption.Text = "Add Option";
            addOption.UseVisualStyleBackColor = true;
            addOption.Click += addOption_Click;
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Location = new Point(26, 263);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(580, 215);
            tabControl1.TabIndex = 9;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(ImageSelect);
            tabPage1.Controls.Add(textBox1);
            tabPage1.Controls.Add(label1);
            tabPage1.Controls.Add(OverwriteImage);
            tabPage1.Controls.Add(filename);
            tabPage1.Location = new Point(4, 29);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(572, 182);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Existing Image";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(CreateImage);
            tabPage2.Controls.Add(selectedDirectoryBox);
            tabPage2.Controls.Add(DirectorySelect);
            tabPage2.Controls.Add(newFileNameBox);
            tabPage2.Controls.Add(label4);
            tabPage2.Controls.Add(heightBox);
            tabPage2.Controls.Add(widthBox);
            tabPage2.Controls.Add(label3);
            tabPage2.Controls.Add(label2);
            tabPage2.Location = new Point(4, 29);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(572, 182);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "New Image";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // CreateImage
            // 
            CreateImage.Location = new Point(6, 140);
            CreateImage.Name = "CreateImage";
            CreateImage.Size = new Size(560, 29);
            CreateImage.TabIndex = 8;
            CreateImage.Text = "Create Image";
            CreateImage.UseVisualStyleBackColor = true;
            CreateImage.Click += CreateImage_Click;
            // 
            // selectedDirectoryBox
            // 
            selectedDirectoryBox.Enabled = false;
            selectedDirectoryBox.Location = new Point(151, 6);
            selectedDirectoryBox.Name = "selectedDirectoryBox";
            selectedDirectoryBox.ReadOnly = true;
            selectedDirectoryBox.Size = new Size(415, 27);
            selectedDirectoryBox.TabIndex = 7;
            // 
            // DirectorySelect
            // 
            DirectorySelect.Location = new Point(6, 6);
            DirectorySelect.Name = "DirectorySelect";
            DirectorySelect.Size = new Size(139, 29);
            DirectorySelect.TabIndex = 6;
            DirectorySelect.Text = "Choose Directory";
            DirectorySelect.UseVisualStyleBackColor = true;
            DirectorySelect.Click += DirectorySelect_Click;
            // 
            // newFileNameBox
            // 
            newFileNameBox.Location = new Point(151, 105);
            newFileNameBox.Name = "newFileNameBox";
            newFileNameBox.Size = new Size(415, 27);
            newFileNameBox.TabIndex = 5;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(6, 108);
            label4.Name = "label4";
            label4.Size = new Size(79, 20);
            label4.TabIndex = 4;
            label4.Text = "File Name:";
            label4.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // heightBox
            // 
            heightBox.Location = new Point(151, 72);
            heightBox.Name = "heightBox";
            heightBox.Size = new Size(415, 27);
            heightBox.TabIndex = 3;
            // 
            // widthBox
            // 
            widthBox.Location = new Point(151, 39);
            widthBox.Name = "widthBox";
            widthBox.Size = new Size(415, 27);
            widthBox.TabIndex = 2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(6, 74);
            label3.Name = "label3";
            label3.Size = new Size(57, 20);
            label3.TabIndex = 1;
            label3.Text = "Height:";
            label3.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(6, 41);
            label2.Name = "label2";
            label2.Size = new Size(52, 20);
            label2.TabIndex = 0;
            label2.Text = "Width:";
            label2.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // flowLayoutPanel
            // 
            flowLayoutPanel.AutoScroll = true;
            flowLayoutPanel.BackColor = SystemColors.ControlLightLight;
            flowLayoutPanel.Location = new Point(26, 12);
            flowLayoutPanel.Name = "flowLayoutPanel";
            flowLayoutPanel.Size = new Size(580, 210);
            flowLayoutPanel.TabIndex = 7;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ControlLightLight;
            panel1.Location = new Point(26, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(563, 210);
            panel1.TabIndex = 10;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(632, 495);
            Controls.Add(tabControl1);
            Controls.Add(addOption);
            Controls.Add(flowLayoutPanel);
            Controls.Add(panel1);
            Name = "MainForm";
            Text = "Random Noise Image Generator";
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            tabPage2.ResumeLayout(false);
            tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)heightBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)widthBox).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Button ImageSelect;
        private TextBox textBox1;
        private Button OverwriteImage;
        private Label label1;
        private TextBox filename;
        private Button addOption;
        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private Label label2;
        private Label label3;
        private NumericUpDown heightBox;
        private NumericUpDown widthBox;
        private Label label4;
        private TextBox newFileNameBox;
        private Button DirectorySelect;
        private TextBox selectedDirectoryBox;
        private Button CreateImage;
        private FlowLayoutPanel flowLayoutPanel;
        private Panel panel1;
    }
}
