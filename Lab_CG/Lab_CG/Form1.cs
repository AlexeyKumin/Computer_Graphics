using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab_CG
{
    public partial class Form1 : Form
    {
        Bitmap image;
        Bitmap source;

        public Form1()
        {
            InitializeComponent();
        }

        private void открытьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.ShowDialog();
            if (dialog.FileName != null)
            {
                image = new Bitmap(dialog.FileName);
                source = new Bitmap(dialog.FileName);
                pictureBox1.Image = image;
                pictureBox1.Refresh();
            }           
        }

        private void averrageToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Average filter = new Average();
            backgroundWorker1.RunWorkerAsync(filter);
        }
        
        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            if (source == null)
            {
                source = new Bitmap(pictureBox1.Image);
            }
            image = new Bitmap(pictureBox1.Image);
            Bitmap newImage = ((Filters)e.Argument).processImage(image, backgroundWorker1);         
            if (backgroundWorker1.CancellationPending != true)
                image = newImage;
        }

        private void backgroundWorker1_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            progressBar1.Value = e.ProgressPercentage + 1;
            progressBar1.Value = e.ProgressPercentage;
        }

        private void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            if (!e.Cancelled)
            {
                pictureBox1.Image = image;
                pictureBox1.Refresh();
            }
            progressBar1.Value = 0;
        }
        
        //Перетаскивание картинки на форму
        private void Form1_DragDrop(object sender, DragEventArgs e)
        {
            int x = this.PointToClient(new Point(e.X, e.Y)).X;
            int y = this.PointToClient(new Point(e.X, e.Y)).Y;          
            if (x >= pictureBox1.Location.X && x <= pictureBox1.Location.X + pictureBox1.Width && y >= pictureBox1.Location.Y && y <= pictureBox1.Location.Y + pictureBox1.Height)
            {
                string[] files = (string[])e.Data.GetData(DataFormats.FileDrop);
                pictureBox1.Image = Image.FromFile(files[0]);
                source = new Bitmap(pictureBox1.Image);
            }
        }

        private void Form1_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.Move;
        }

        //Кнопки
        private void button2_Click(object sender, EventArgs e)
        {
            if (source != null)
            {
                pictureBox1.Image = source;
                pictureBox1.Refresh();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            backgroundWorker1.CancelAsync();
        }

        //Фильтры
        private void инверсияToolStripMenuItem_Click(object sender, EventArgs e)
        {
            InvertFilters filter = new InvertFilters();
            backgroundWorker1.RunWorkerAsync(filter);
        }

        private void размытиеToolStripMenuItem_Click(object sender, EventArgs e)
        {        
            Filters filter = new BlurFilter();
            backgroundWorker1.RunWorkerAsync(filter);
        }

        private void гауссовскийToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Filters filter = new GaussianFilter();
            backgroundWorker1.RunWorkerAsync(filter);
        }

        private void бинаризацияПоПорогуToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Filters filter = new AdaptivBinarFilter();
            backgroundWorker1.RunWorkerAsync(filter);
        }

        private void медианныйToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Filters filter = new MedianFilter1();
            backgroundWorker1.RunWorkerAsync(filter);
        }

        private void медианный2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Filters filter = new MedianFilter2();
            backgroundWorker1.RunWorkerAsync(filter);
        }

        private void прюиттToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Filters filter = new PruittFilter();
            backgroundWorker1.RunWorkerAsync(filter);
        }

        private void наращиваниеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Filters filter = new BinaryOperationsBuildup();
            backgroundWorker1.RunWorkerAsync(filter);
        }

        private void эрозияToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Filters filter = new BinaryOperationsErosion();
            backgroundWorker1.RunWorkerAsync(filter);
        }

        private void замыканиеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BinaryOperatinsClosure filter = new BinaryOperatinsClosure();
            backgroundWorker1.RunWorkerAsync(filter);     
        }

        private void размыканиеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Filters filter = new BinaryOperatinsDisjunction();
            backgroundWorker1.RunWorkerAsync(filter);

        }

        private void резкостьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Filters filter1 = new HarshnessFilter();
            backgroundWorker1.RunWorkerAsync(filter1);

        }
    }
}