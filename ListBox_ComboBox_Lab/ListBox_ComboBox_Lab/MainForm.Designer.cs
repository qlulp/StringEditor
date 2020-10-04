namespace ListBox_ComboBox_Lab
{
    partial class MainForm
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
            this.MainListBox = new System.Windows.Forms.ListBox();
            this.InputLabel = new System.Windows.Forms.Label();
            this.InputTextBox = new System.Windows.Forms.TextBox();
            this.AddLineButton = new System.Windows.Forms.Button();
            this.InsertButton = new System.Windows.Forms.Button();
            this.ChangeButton = new System.Windows.Forms.Button();
            this.DeleteButton = new System.Windows.Forms.Button();
            this.ClearButton = new System.Windows.Forms.Button();
            this.OpenFileButton = new System.Windows.Forms.Button();
            this.SaveToFileButton = new System.Windows.Forms.Button();
            this.FilePathLabel = new System.Windows.Forms.Label();
            this.Strip = new System.Windows.Forms.MenuStrip();
            this.файлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.OpenFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SaveFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.редактированиеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.AddLineToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.InsertLineToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ChangeLineToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.DeleteFromListToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ClearListToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.AboutProgramToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Strip.SuspendLayout();
            this.SuspendLayout();
            // 
            // MainListBox
            // 
            this.MainListBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.MainListBox.FormattingEnabled = true;
            this.MainListBox.HorizontalScrollbar = true;
            this.MainListBox.Location = new System.Drawing.Point(12, 27);
            this.MainListBox.Name = "MainListBox";
            this.MainListBox.Size = new System.Drawing.Size(517, 420);
            this.MainListBox.TabIndex = 0;
            // 
            // InputLabel
            // 
            this.InputLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.InputLabel.AutoSize = true;
            this.InputLabel.Location = new System.Drawing.Point(535, 29);
            this.InputLabel.Name = "InputLabel";
            this.InputLabel.Size = new System.Drawing.Size(66, 13);
            this.InputLabel.TabIndex = 2;
            this.InputLabel.Text = "Поле ввода";
            // 
            // InputTextBox
            // 
            this.InputTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.InputTextBox.Location = new System.Drawing.Point(538, 45);
            this.InputTextBox.Name = "InputTextBox";
            this.InputTextBox.Size = new System.Drawing.Size(184, 20);
            this.InputTextBox.TabIndex = 3;
            // 
            // AddLineButton
            // 
            this.AddLineButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.AddLineButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddLineButton.Location = new System.Drawing.Point(538, 70);
            this.AddLineButton.Name = "AddLineButton";
            this.AddLineButton.Size = new System.Drawing.Size(184, 23);
            this.AddLineButton.TabIndex = 4;
            this.AddLineButton.Text = "Добавить строку";
            this.AddLineButton.UseVisualStyleBackColor = true;
            this.AddLineButton.Click += new System.EventHandler(this.AddStudentButton_Click);
            // 
            // InsertButton
            // 
            this.InsertButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.InsertButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.InsertButton.Location = new System.Drawing.Point(538, 99);
            this.InsertButton.Name = "InsertButton";
            this.InsertButton.Size = new System.Drawing.Size(184, 23);
            this.InsertButton.TabIndex = 5;
            this.InsertButton.Text = "Вставить строку";
            this.InsertButton.UseVisualStyleBackColor = true;
            this.InsertButton.Click += new System.EventHandler(this.InsertButton_Click);
            // 
            // ChangeButton
            // 
            this.ChangeButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ChangeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ChangeButton.Location = new System.Drawing.Point(538, 128);
            this.ChangeButton.Name = "ChangeButton";
            this.ChangeButton.Size = new System.Drawing.Size(184, 23);
            this.ChangeButton.TabIndex = 6;
            this.ChangeButton.Text = "Изменить строку";
            this.ChangeButton.UseVisualStyleBackColor = true;
            this.ChangeButton.Click += new System.EventHandler(this.ChangeButton_Click);
            // 
            // DeleteButton
            // 
            this.DeleteButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.DeleteButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DeleteButton.Location = new System.Drawing.Point(538, 157);
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.Size = new System.Drawing.Size(184, 23);
            this.DeleteButton.TabIndex = 7;
            this.DeleteButton.Text = "Удалить из списка";
            this.DeleteButton.UseVisualStyleBackColor = true;
            this.DeleteButton.Click += new System.EventHandler(this.DeleteButton_Click);
            // 
            // ClearButton
            // 
            this.ClearButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ClearButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ClearButton.Location = new System.Drawing.Point(538, 186);
            this.ClearButton.Name = "ClearButton";
            this.ClearButton.Size = new System.Drawing.Size(184, 23);
            this.ClearButton.TabIndex = 8;
            this.ClearButton.Text = "Очистить список";
            this.ClearButton.UseVisualStyleBackColor = true;
            this.ClearButton.Click += new System.EventHandler(this.ClearButton_Click);
            // 
            // OpenFileButton
            // 
            this.OpenFileButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.OpenFileButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.OpenFileButton.Location = new System.Drawing.Point(538, 395);
            this.OpenFileButton.Name = "OpenFileButton";
            this.OpenFileButton.Size = new System.Drawing.Size(184, 23);
            this.OpenFileButton.TabIndex = 9;
            this.OpenFileButton.Text = "Открыть";
            this.OpenFileButton.UseVisualStyleBackColor = true;
            this.OpenFileButton.Click += new System.EventHandler(this.OpenFileButton_Click);
            // 
            // SaveToFileButton
            // 
            this.SaveToFileButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.SaveToFileButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SaveToFileButton.Location = new System.Drawing.Point(538, 424);
            this.SaveToFileButton.Name = "SaveToFileButton";
            this.SaveToFileButton.Size = new System.Drawing.Size(184, 23);
            this.SaveToFileButton.TabIndex = 10;
            this.SaveToFileButton.Text = "Сохранить";
            this.SaveToFileButton.UseVisualStyleBackColor = true;
            this.SaveToFileButton.Click += new System.EventHandler(this.SaveToFileButton_Click);
            // 
            // FilePathLabel
            // 
            this.FilePathLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.FilePathLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.FilePathLabel.Location = new System.Drawing.Point(538, 334);
            this.FilePathLabel.Name = "FilePathLabel";
            this.FilePathLabel.Size = new System.Drawing.Size(184, 58);
            this.FilePathLabel.TabIndex = 11;
            // 
            // Strip
            // 
            this.Strip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.файлToolStripMenuItem,
            this.редактированиеToolStripMenuItem,
            this.AboutProgramToolStripMenuItem});
            this.Strip.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow;
            this.Strip.Location = new System.Drawing.Point(0, 0);
            this.Strip.Name = "Strip";
            this.Strip.Size = new System.Drawing.Size(734, 24);
            this.Strip.TabIndex = 12;
            // 
            // файлToolStripMenuItem
            // 
            this.файлToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.OpenFileToolStripMenuItem,
            this.SaveFileToolStripMenuItem});
            this.файлToolStripMenuItem.Name = "файлToolStripMenuItem";
            this.файлToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.файлToolStripMenuItem.Text = "Файл";
            // 
            // OpenFileToolStripMenuItem
            // 
            this.OpenFileToolStripMenuItem.Name = "OpenFileToolStripMenuItem";
            this.OpenFileToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.OpenFileToolStripMenuItem.Text = "Открыть";
            this.OpenFileToolStripMenuItem.Click += new System.EventHandler(this.OpenFileToolStripMenuItem_Click);
            // 
            // SaveFileToolStripMenuItem
            // 
            this.SaveFileToolStripMenuItem.Name = "SaveFileToolStripMenuItem";
            this.SaveFileToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.SaveFileToolStripMenuItem.Text = "Сохранить";
            this.SaveFileToolStripMenuItem.Click += new System.EventHandler(this.SaveFileToolStripMenuItem_Click);
            // 
            // редактированиеToolStripMenuItem
            // 
            this.редактированиеToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.AddLineToolStripMenuItem,
            this.InsertLineToolStripMenuItem,
            this.ChangeLineToolStripMenuItem,
            this.DeleteFromListToolStripMenuItem,
            this.ClearListToolStripMenuItem});
            this.редактированиеToolStripMenuItem.Name = "редактированиеToolStripMenuItem";
            this.редактированиеToolStripMenuItem.Size = new System.Drawing.Size(108, 20);
            this.редактированиеToolStripMenuItem.Text = "Редактирование";
            // 
            // AddLineToolStripMenuItem
            // 
            this.AddLineToolStripMenuItem.Name = "AddLineToolStripMenuItem";
            this.AddLineToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.AddLineToolStripMenuItem.Text = "Добавить строку";
            this.AddLineToolStripMenuItem.Click += new System.EventHandler(this.AddLineToolStripMenuItem_Click);
            // 
            // InsertLineToolStripMenuItem
            // 
            this.InsertLineToolStripMenuItem.Name = "InsertLineToolStripMenuItem";
            this.InsertLineToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.InsertLineToolStripMenuItem.Text = "Вставить строку";
            this.InsertLineToolStripMenuItem.Click += new System.EventHandler(this.InsertLineToolStripMenuItem_Click);
            // 
            // ChangeLineToolStripMenuItem
            // 
            this.ChangeLineToolStripMenuItem.Name = "ChangeLineToolStripMenuItem";
            this.ChangeLineToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.ChangeLineToolStripMenuItem.Text = "Изменить строку";
            this.ChangeLineToolStripMenuItem.Click += new System.EventHandler(this.ChangeLineToolStripMenuItem_Click);
            // 
            // DeleteFromListToolStripMenuItem
            // 
            this.DeleteFromListToolStripMenuItem.Name = "DeleteFromListToolStripMenuItem";
            this.DeleteFromListToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.DeleteFromListToolStripMenuItem.Text = "Удалить из списка";
            this.DeleteFromListToolStripMenuItem.Click += new System.EventHandler(this.DeleteFromListToolStripMenuItem_Click);
            // 
            // ClearListToolStripMenuItem
            // 
            this.ClearListToolStripMenuItem.Name = "ClearListToolStripMenuItem";
            this.ClearListToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.ClearListToolStripMenuItem.Text = "Очистить список";
            this.ClearListToolStripMenuItem.Click += new System.EventHandler(this.ClearListToolStripMenuItem_Click);
            // 
            // AboutProgramToolStripMenuItem
            // 
            this.AboutProgramToolStripMenuItem.Name = "AboutProgramToolStripMenuItem";
            this.AboutProgramToolStripMenuItem.Size = new System.Drawing.Size(94, 20);
            this.AboutProgramToolStripMenuItem.Text = "О программе";
            this.AboutProgramToolStripMenuItem.Click += new System.EventHandler(this.AboutProgramToolStripMenuItem_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(734, 459);
            this.Controls.Add(this.FilePathLabel);
            this.Controls.Add(this.SaveToFileButton);
            this.Controls.Add(this.OpenFileButton);
            this.Controls.Add(this.ClearButton);
            this.Controls.Add(this.DeleteButton);
            this.Controls.Add(this.ChangeButton);
            this.Controls.Add(this.InsertButton);
            this.Controls.Add(this.AddLineButton);
            this.Controls.Add(this.InputTextBox);
            this.Controls.Add(this.InputLabel);
            this.Controls.Add(this.MainListBox);
            this.Controls.Add(this.Strip);
            this.MainMenuStrip = this.Strip;
            this.MaximumSize = new System.Drawing.Size(1920, 1080);
            this.MinimumSize = new System.Drawing.Size(400, 420);
            this.Name = "MainForm";
            this.ShowIcon = false;
            this.Text = "Обработка строк";
            this.Strip.ResumeLayout(false);
            this.Strip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox MainListBox;
        private System.Windows.Forms.Label InputLabel;
        private System.Windows.Forms.TextBox InputTextBox;
        private System.Windows.Forms.Button AddLineButton;
        private System.Windows.Forms.Button InsertButton;
        private System.Windows.Forms.Button ChangeButton;
        private System.Windows.Forms.Button DeleteButton;
        private System.Windows.Forms.Button ClearButton;
        private System.Windows.Forms.Button OpenFileButton;
        private System.Windows.Forms.Button SaveToFileButton;
        private System.Windows.Forms.Label FilePathLabel;
        private System.Windows.Forms.MenuStrip Strip;
        private System.Windows.Forms.ToolStripMenuItem файлToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem OpenFileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem SaveFileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem редактированиеToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem AddLineToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem InsertLineToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ChangeLineToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem DeleteFromListToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ClearListToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem AboutProgramToolStripMenuItem;
    }
}

