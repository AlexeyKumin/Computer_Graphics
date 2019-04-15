namespace Lab_CG
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.файлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.открытьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.фильтрыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.точечныеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.инверсияToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.averrageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.бинаризацияПоПорогуToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.медианныйToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.медианный2ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.матричныеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.размытиеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.гауссовскийToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.прюиттToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.резкостьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.морфологическаяФильтрацияToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.наращиваниеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.эрозияToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.замыканиеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.размыканиеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.файлToolStripMenuItem,
            this.фильтрыToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(898, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // файлToolStripMenuItem
            // 
            this.файлToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.открытьToolStripMenuItem});
            this.файлToolStripMenuItem.Name = "файлToolStripMenuItem";
            this.файлToolStripMenuItem.Size = new System.Drawing.Size(57, 24);
            this.файлToolStripMenuItem.Text = "Файл";
            // 
            // открытьToolStripMenuItem
            // 
            this.открытьToolStripMenuItem.Name = "открытьToolStripMenuItem";
            this.открытьToolStripMenuItem.Size = new System.Drawing.Size(142, 26);
            this.открытьToolStripMenuItem.Text = "Открыть";
            this.открытьToolStripMenuItem.Click += new System.EventHandler(this.открытьToolStripMenuItem_Click);
            // 
            // фильтрыToolStripMenuItem
            // 
            this.фильтрыToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.точечныеToolStripMenuItem,
            this.матричныеToolStripMenuItem,
            this.морфологическаяФильтрацияToolStripMenuItem});
            this.фильтрыToolStripMenuItem.Name = "фильтрыToolStripMenuItem";
            this.фильтрыToolStripMenuItem.Size = new System.Drawing.Size(83, 24);
            this.фильтрыToolStripMenuItem.Text = "Фильтры";
            // 
            // точечныеToolStripMenuItem
            // 
            this.точечныеToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.инверсияToolStripMenuItem,
            this.averrageToolStripMenuItem,
            this.бинаризацияПоПорогуToolStripMenuItem,
            this.медианныйToolStripMenuItem,
            this.медианный2ToolStripMenuItem});
            this.точечныеToolStripMenuItem.Name = "точечныеToolStripMenuItem";
            this.точечныеToolStripMenuItem.Size = new System.Drawing.Size(300, 26);
            this.точечныеToolStripMenuItem.Text = "Точечные";
            // 
            // инверсияToolStripMenuItem
            // 
            this.инверсияToolStripMenuItem.Name = "инверсияToolStripMenuItem";
            this.инверсияToolStripMenuItem.Size = new System.Drawing.Size(253, 26);
            this.инверсияToolStripMenuItem.Text = "Инверсия";
            this.инверсияToolStripMenuItem.Click += new System.EventHandler(this.инверсияToolStripMenuItem_Click);
            // 
            // averrageToolStripMenuItem
            // 
            this.averrageToolStripMenuItem.Name = "averrageToolStripMenuItem";
            this.averrageToolStripMenuItem.Size = new System.Drawing.Size(253, 26);
            this.averrageToolStripMenuItem.Text = "Average";
            this.averrageToolStripMenuItem.Click += new System.EventHandler(this.averrageToolStripMenuItem_Click);
            // 
            // бинаризацияПоПорогуToolStripMenuItem
            // 
            this.бинаризацияПоПорогуToolStripMenuItem.Name = "бинаризацияПоПорогуToolStripMenuItem";
            this.бинаризацияПоПорогуToolStripMenuItem.Size = new System.Drawing.Size(253, 26);
            this.бинаризацияПоПорогуToolStripMenuItem.Text = "Бинаризация по порогу";
            this.бинаризацияПоПорогуToolStripMenuItem.Click += new System.EventHandler(this.бинаризацияПоПорогуToolStripMenuItem_Click);
            // 
            // медианныйToolStripMenuItem
            // 
            this.медианныйToolStripMenuItem.Name = "медианныйToolStripMenuItem";
            this.медианныйToolStripMenuItem.Size = new System.Drawing.Size(253, 26);
            this.медианныйToolStripMenuItem.Text = "Медианный1";
            this.медианныйToolStripMenuItem.Click += new System.EventHandler(this.медианныйToolStripMenuItem_Click);
            // 
            // медианный2ToolStripMenuItem
            // 
            this.медианный2ToolStripMenuItem.Name = "медианный2ToolStripMenuItem";
            this.медианный2ToolStripMenuItem.Size = new System.Drawing.Size(253, 26);
            this.медианный2ToolStripMenuItem.Text = "Медианный2";
            this.медианный2ToolStripMenuItem.Click += new System.EventHandler(this.медианный2ToolStripMenuItem_Click);
            // 
            // матричныеToolStripMenuItem
            // 
            this.матричныеToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.размытиеToolStripMenuItem,
            this.гауссовскийToolStripMenuItem,
            this.прюиттToolStripMenuItem,
            this.резкостьToolStripMenuItem});
            this.матричныеToolStripMenuItem.Name = "матричныеToolStripMenuItem";
            this.матричныеToolStripMenuItem.Size = new System.Drawing.Size(300, 26);
            this.матричныеToolStripMenuItem.Text = "Матричные";
            // 
            // размытиеToolStripMenuItem
            // 
            this.размытиеToolStripMenuItem.Name = "размытиеToolStripMenuItem";
            this.размытиеToolStripMenuItem.Size = new System.Drawing.Size(216, 26);
            this.размытиеToolStripMenuItem.Text = "Размытие";
            this.размытиеToolStripMenuItem.Click += new System.EventHandler(this.размытиеToolStripMenuItem_Click);
            // 
            // гауссовскийToolStripMenuItem
            // 
            this.гауссовскийToolStripMenuItem.Name = "гауссовскийToolStripMenuItem";
            this.гауссовскийToolStripMenuItem.Size = new System.Drawing.Size(216, 26);
            this.гауссовскийToolStripMenuItem.Text = "Гауссовский";
            this.гауссовскийToolStripMenuItem.Click += new System.EventHandler(this.гауссовскийToolStripMenuItem_Click);
            // 
            // прюиттToolStripMenuItem
            // 
            this.прюиттToolStripMenuItem.Name = "прюиттToolStripMenuItem";
            this.прюиттToolStripMenuItem.Size = new System.Drawing.Size(216, 26);
            this.прюиттToolStripMenuItem.Text = "Прюитт";
            this.прюиттToolStripMenuItem.Click += new System.EventHandler(this.прюиттToolStripMenuItem_Click);
            // 
            // резкостьToolStripMenuItem
            // 
            this.резкостьToolStripMenuItem.Name = "резкостьToolStripMenuItem";
            this.резкостьToolStripMenuItem.Size = new System.Drawing.Size(216, 26);
            this.резкостьToolStripMenuItem.Text = "Резкость";
            this.резкостьToolStripMenuItem.Click += new System.EventHandler(this.резкостьToolStripMenuItem_Click);
            // 
            // морфологическаяФильтрацияToolStripMenuItem
            // 
            this.морфологическаяФильтрацияToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.наращиваниеToolStripMenuItem,
            this.эрозияToolStripMenuItem,
            this.замыканиеToolStripMenuItem,
            this.размыканиеToolStripMenuItem});
            this.морфологическаяФильтрацияToolStripMenuItem.Name = "морфологическаяФильтрацияToolStripMenuItem";
            this.морфологическаяФильтрацияToolStripMenuItem.Size = new System.Drawing.Size(300, 26);
            this.морфологическаяФильтрацияToolStripMenuItem.Text = "Морфологическая фильтрация";
            // 
            // наращиваниеToolStripMenuItem
            // 
            this.наращиваниеToolStripMenuItem.Name = "наращиваниеToolStripMenuItem";
            this.наращиваниеToolStripMenuItem.Size = new System.Drawing.Size(216, 26);
            this.наращиваниеToolStripMenuItem.Text = "Наращивание";
            this.наращиваниеToolStripMenuItem.Click += new System.EventHandler(this.наращиваниеToolStripMenuItem_Click);
            // 
            // эрозияToolStripMenuItem
            // 
            this.эрозияToolStripMenuItem.Name = "эрозияToolStripMenuItem";
            this.эрозияToolStripMenuItem.Size = new System.Drawing.Size(216, 26);
            this.эрозияToolStripMenuItem.Text = "Эрозия";
            this.эрозияToolStripMenuItem.Click += new System.EventHandler(this.эрозияToolStripMenuItem_Click);
            // 
            // замыканиеToolStripMenuItem
            // 
            this.замыканиеToolStripMenuItem.Name = "замыканиеToolStripMenuItem";
            this.замыканиеToolStripMenuItem.Size = new System.Drawing.Size(216, 26);
            this.замыканиеToolStripMenuItem.Text = "Замыкание";
            this.замыканиеToolStripMenuItem.Click += new System.EventHandler(this.замыканиеToolStripMenuItem_Click);
            // 
            // размыканиеToolStripMenuItem
            // 
            this.размыканиеToolStripMenuItem.Name = "размыканиеToolStripMenuItem";
            this.размыканиеToolStripMenuItem.Size = new System.Drawing.Size(216, 26);
            this.размыканиеToolStripMenuItem.Text = "Размыкание";
            this.размыканиеToolStripMenuItem.Click += new System.EventHandler(this.размыканиеToolStripMenuItem_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Lab_CG.Properties.Resources.matematika_b_2_1024x735;
            this.pictureBox1.Location = new System.Drawing.Point(32, 47);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(699, 408);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.WorkerReportsProgress = true;
            this.backgroundWorker1.WorkerSupportsCancellation = true;
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            this.backgroundWorker1.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.backgroundWorker1_ProgressChanged);
            this.backgroundWorker1.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorker1_RunWorkerCompleted);
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(32, 473);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(720, 35);
            this.progressBar1.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(774, 462);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(112, 46);
            this.button1.TabIndex = 3;
            this.button1.Text = "Отмена";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.AutoEllipsis = true;
            this.button2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button2.Location = new System.Drawing.Point(774, 106);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(98, 84);
            this.button2.TabIndex = 4;
            this.button2.TabStop = false;
            this.button2.Text = "Вернуть картинку";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form1
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(898, 570);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.DragDrop += new System.Windows.Forms.DragEventHandler(this.Form1_DragDrop);
            this.DragEnter += new System.Windows.Forms.DragEventHandler(this.Form1_DragEnter);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem файлToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem открытьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem фильтрыToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem точечныеToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem инверсияToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem матричныеToolStripMenuItem;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ToolStripMenuItem averrageToolStripMenuItem;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ToolStripMenuItem размытиеToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem гауссовскийToolStripMenuItem;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ToolStripMenuItem бинаризацияПоПорогуToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem медианныйToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem медианный2ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem прюиттToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem морфологическаяФильтрацияToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem наращиваниеToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem эрозияToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem замыканиеToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem размыканиеToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem резкостьToolStripMenuItem;
    }
}

