namespace DZ
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.readFromFileButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.downloadTimeLabel = new System.Windows.Forms.Label();
            this.findWordTextBox = new System.Windows.Forms.TextBox();
            this.findWordButton = new System.Windows.Forms.Button();
            this.maxDistanceTextBox = new System.Windows.Forms.TextBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.findWordTimeLabel = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.numberOfUniqueWordsLabel = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.threadNumberTextBox = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.numberOfThreadLabel = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.findLevenDistanceTimeLabel = new System.Windows.Forms.Label();
            this.findLevenDistanceButton = new System.Windows.Forms.Button();
            this.createReportButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // readFromFileButton
            // 
            this.readFromFileButton.Location = new System.Drawing.Point(12, 28);
            this.readFromFileButton.Name = "readFromFileButton";
            this.readFromFileButton.Size = new System.Drawing.Size(776, 50);
            this.readFromFileButton.TabIndex = 0;
            this.readFromFileButton.Text = "Чтение файла";
            this.readFromFileButton.UseVisualStyleBackColor = true;
            this.readFromFileButton.Click += new System.EventHandler(this.ReadFromFile_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 81);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(176, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Время загрузки:";
            // 
            // downloadTimeLabel
            // 
            this.downloadTimeLabel.AutoSize = true;
            this.downloadTimeLabel.Location = new System.Drawing.Point(194, 81);
            this.downloadTimeLabel.Name = "downloadTimeLabel";
            this.downloadTimeLabel.Size = new System.Drawing.Size(66, 25);
            this.downloadTimeLabel.TabIndex = 2;
            this.downloadTimeLabel.Text = "00:00";
            // 
            // findWordTextBox
            // 
            this.findWordTextBox.Location = new System.Drawing.Point(183, 125);
            this.findWordTextBox.Name = "findWordTextBox";
            this.findWordTextBox.Size = new System.Drawing.Size(605, 31);
            this.findWordTextBox.TabIndex = 3;
            // 
            // findWordButton
            // 
            this.findWordButton.Location = new System.Drawing.Point(12, 238);
            this.findWordButton.Name = "findWordButton";
            this.findWordButton.Size = new System.Drawing.Size(248, 45);
            this.findWordButton.TabIndex = 4;
            this.findWordButton.Text = "Поиск слова";
            this.findWordButton.UseVisualStyleBackColor = true;
            this.findWordButton.Click += new System.EventHandler(this.FindWordButton_Click);
            // 
            // maxDistanceTextBox
            // 
            this.maxDistanceTextBox.Location = new System.Drawing.Point(321, 162);
            this.maxDistanceTextBox.Name = "maxDistanceTextBox";
            this.maxDistanceTextBox.Size = new System.Drawing.Size(467, 31);
            this.maxDistanceTextBox.TabIndex = 5;
            this.maxDistanceTextBox.Text = "3";
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 25;
            this.listBox1.Location = new System.Drawing.Point(12, 340);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(776, 279);
            this.listBox1.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 165);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(289, 25);
            this.label2.TabIndex = 7;
            this.label2.Text = "Максимальное расстояние:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(316, 248);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(158, 25);
            this.label3.TabIndex = 8;
            this.label3.Text = "Время поиска:";
            // 
            // findWordTimeLabel
            // 
            this.findWordTimeLabel.AutoSize = true;
            this.findWordTimeLabel.Location = new System.Drawing.Point(480, 248);
            this.findWordTimeLabel.Name = "findWordTimeLabel";
            this.findWordTimeLabel.Size = new System.Drawing.Size(66, 25);
            this.findWordTimeLabel.TabIndex = 9;
            this.findWordTimeLabel.Text = "00:00";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(364, 81);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(312, 25);
            this.label4.TabIndex = 10;
            this.label4.Text = "Количество уникальных слов:";
            // 
            // numberOfUniqueWordsLabel
            // 
            this.numberOfUniqueWordsLabel.AutoSize = true;
            this.numberOfUniqueWordsLabel.Location = new System.Drawing.Point(682, 81);
            this.numberOfUniqueWordsLabel.Name = "numberOfUniqueWordsLabel";
            this.numberOfUniqueWordsLabel.Size = new System.Drawing.Size(24, 25);
            this.numberOfUniqueWordsLabel.TabIndex = 11;
            this.numberOfUniqueWordsLabel.Text = "0";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 125);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(165, 25);
            this.label6.TabIndex = 12;
            this.label6.Text = "Введите слово:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 200);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(221, 25);
            this.label7.TabIndex = 13;
            this.label7.Text = "Количество потоков:";
            // 
            // threadNumberTextBox
            // 
            this.threadNumberTextBox.Location = new System.Drawing.Point(321, 200);
            this.threadNumberTextBox.Name = "threadNumberTextBox";
            this.threadNumberTextBox.Size = new System.Drawing.Size(467, 31);
            this.threadNumberTextBox.TabIndex = 14;
            this.threadNumberTextBox.Text = "10";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(537, 299);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(221, 25);
            this.label8.TabIndex = 15;
            this.label8.Text = "Количество потоков:";
            // 
            // numberOfThreadLabel
            // 
            this.numberOfThreadLabel.AutoSize = true;
            this.numberOfThreadLabel.Location = new System.Drawing.Point(764, 299);
            this.numberOfThreadLabel.Name = "numberOfThreadLabel";
            this.numberOfThreadLabel.Size = new System.Drawing.Size(24, 25);
            this.numberOfThreadLabel.TabIndex = 16;
            this.numberOfThreadLabel.Text = "0";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(266, 299);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(158, 25);
            this.label10.TabIndex = 17;
            this.label10.Text = "Время поиска:";
            // 
            // findLevenDistanceTimeLabel
            // 
            this.findLevenDistanceTimeLabel.AutoSize = true;
            this.findLevenDistanceTimeLabel.Location = new System.Drawing.Point(430, 299);
            this.findLevenDistanceTimeLabel.Name = "findLevenDistanceTimeLabel";
            this.findLevenDistanceTimeLabel.Size = new System.Drawing.Size(66, 25);
            this.findLevenDistanceTimeLabel.TabIndex = 18;
            this.findLevenDistanceTimeLabel.Text = "00:00";
            // 
            // findLevenDistanceButton
            // 
            this.findLevenDistanceButton.Location = new System.Drawing.Point(12, 289);
            this.findLevenDistanceButton.Name = "findLevenDistanceButton";
            this.findLevenDistanceButton.Size = new System.Drawing.Size(248, 45);
            this.findLevenDistanceButton.TabIndex = 19;
            this.findLevenDistanceButton.Text = "Поиск Левенштейна";
            this.findLevenDistanceButton.UseVisualStyleBackColor = true;
            this.findLevenDistanceButton.Click += new System.EventHandler(this.findLevenDistanceButton_Click);
            // 
            // createReportButton
            // 
            this.createReportButton.Location = new System.Drawing.Point(12, 625);
            this.createReportButton.Name = "createReportButton";
            this.createReportButton.Size = new System.Drawing.Size(776, 45);
            this.createReportButton.TabIndex = 20;
            this.createReportButton.Text = "Создать отчет";
            this.createReportButton.UseVisualStyleBackColor = true;
            this.createReportButton.Click += new System.EventHandler(this.createReportButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(802, 678);
            this.Controls.Add(this.createReportButton);
            this.Controls.Add(this.findLevenDistanceButton);
            this.Controls.Add(this.findLevenDistanceTimeLabel);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.numberOfThreadLabel);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.threadNumberTextBox);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.numberOfUniqueWordsLabel);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.findWordTimeLabel);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.maxDistanceTextBox);
            this.Controls.Add(this.findWordButton);
            this.Controls.Add(this.findWordTextBox);
            this.Controls.Add(this.downloadTimeLabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.readFromFileButton);
            this.Name = "Form1";
            this.Text = "Шевчук Михаил ИУ5-31Б";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button readFromFileButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label downloadTimeLabel;
        private System.Windows.Forms.TextBox findWordTextBox;
        private System.Windows.Forms.Button findWordButton;
        private System.Windows.Forms.TextBox maxDistanceTextBox;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label findWordTimeLabel;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label numberOfUniqueWordsLabel;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox threadNumberTextBox;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label numberOfThreadLabel;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label findLevenDistanceTimeLabel;
        private System.Windows.Forms.Button findLevenDistanceButton;
        private System.Windows.Forms.Button createReportButton;
    }
}

