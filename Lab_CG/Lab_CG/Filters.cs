using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.ComponentModel;

namespace Lab_CG
{
    abstract class Filters
    {
        protected abstract Color CalculateColor(Bitmap sourceImage, int x, int y);

        public int Clamp(int value, int min, int max)
        {
            if (value < min)
                return min;
            if (value > max)
                return max;
            else
                return value;
        }

        public Bitmap processImage(Bitmap sourceImage)
        {
            Bitmap resultImage = new Bitmap(sourceImage.Width, sourceImage.Height);
            for (int i = 0; i < resultImage.Width; i++)
                for (int j = 0; j < resultImage.Height; j++)
                {
                    resultImage.SetPixel(i, j, CalculateColor(sourceImage, i, j));
                }
            return resultImage;
        }

        public virtual Bitmap processImage(Bitmap sourceImage, BackgroundWorker worker)
        {
            Bitmap resultImage = new Bitmap(sourceImage.Width, sourceImage.Height);
            for (int i = 0; i < resultImage.Width; i++)
            {
                worker.ReportProgress((int)((float)i / resultImage.Width * 100));
                if (worker.CancellationPending)
                    return null;
                for (int j = 0; j < resultImage.Height; j++)
                {
                    resultImage.SetPixel(i, j, CalculateColor(sourceImage, i, j));
                }
            }
            return resultImage;
        }
    }

    class InvertFilters : Filters
    {
        protected override Color CalculateColor(Bitmap sourceImage, int x, int y)
        {
            Color sourceColor = sourceImage.GetPixel(x, y);
            Color resultColor = Color.FromArgb(255 - sourceColor.R, 255 - sourceColor.G, 255 - sourceColor.B);

            return resultColor;
        }
    }

    class Average : Filters
    {
        protected override Color CalculateColor(Bitmap sourceImage, int i, int j)
        {
            Color sourceColor = sourceImage.GetPixel(i, j);

            int intense = Clamp((sourceColor.R + sourceColor.B + sourceColor.G) / 3 , 0, 255);
            Color resultColor = Color.FromArgb(intense, intense, intense);

            return resultColor;
        }
    }

    class AdaptivBinarFilter : Filters
    {
        protected override Color CalculateColor(Bitmap sourceImage, int i, int j)
        {
            Color sourceColor = sourceImage.GetPixel(i, j);         
            int intense = Clamp((sourceColor.R + sourceColor.B + sourceColor.G) / 3, 0, 255);
            if (intense < 128)
                intense = 0;
            else
                intense = 255;
            Color resultColor = Color.FromArgb(intense, intense, intense);
            return resultColor;
        }
    }

    class MatrixFilter : Filters
    {
        protected double[,] kernel;
        public MatrixFilter()
        {
        }

        public MatrixFilter(double [,] kernel)
        {
            this.kernel = kernel;
        }

        protected override Color CalculateColor(Bitmap sourceImage, int x, int y)
        {
            int X = kernel.GetLength(0) / 2;
            int Y = kernel.GetLength(1) / 2;
            double resultR = 0;
            double resultG = 0;
            double resultB = 0;

            for (int l = -Y; l <= Y; l++)
            {
                for (int k = -X; k <= X; k++)
                {
                    int idX = Clamp(x + k, 0, sourceImage.Width - 1);
                    int idY = Clamp(y + l, 0, sourceImage.Height - 1);
                    Color nColor = sourceImage.GetPixel(idX, idY);

                    resultR += nColor.R * kernel[k + X, l + Y];
                    resultG += nColor.G * kernel[k + X, l + Y];
                    resultB += nColor.B * kernel[k + X, l + Y];
                }
            }
            return Color.FromArgb(
                Clamp((int)resultR, 0, 255),
                Clamp((int)resultG, 0, 255),
                Clamp((int)resultB, 0, 255)
                );
        }
    }

    class BlurFilter : MatrixFilter
    {
        public BlurFilter()
        {
            double a = 1.0 / 9.0;
            kernel = new double[3,3] { 
                { a, a, a}, 
                { a, a, a}, 
                { a, a, a} };
        }
    }

    class GaussianFilter : MatrixFilter
    {
        public void createGaussianKernel(int rad, double sigma)
        {
            int size = 2 * rad + 1;
            kernel = new double[size, size];
            double norm = 0;
            for (int i = -rad; i <= rad; i++)
            {
                for (int j = -rad; j <= rad; j++)
                {
                    kernel[i + rad, j + rad] = (float)(Math.Exp(-(i * i + j * j) / (sigma * sigma)));
                    norm += kernel[i + rad, j + rad];
                }
            }
            for (int i = 0; i < size; i++)
                for (int j = 0; j < size; j++)
                    kernel[i, j] /= norm;
        }

        public GaussianFilter()
        {
            createGaussianKernel(3, 2);
        }

        class BlurFilter : MatrixFilter
        {
            public BlurFilter()
            {
                double a = 1.0 / 9.0;
                kernel = new double[3, 3] {
                { a, a, a},
                { a, a, a},
                { a, a, a} };
            }
        }
    }

    class PruittFilter : Filters
    {
        protected double[,] kernel1 = new double[3, 3] {
                { -1, 0, 1},
                { -1, 0, 1},
                { -1, 0, 1} };

         protected double[,] kernel2 = new double[3, 3] {
                { -1, -1, -1},
                { 0, 0, 0},
                { 1, 1, 1} };

        public PruittFilter()
        {
        }

        protected override Color CalculateColor(Bitmap sourceImage, int x, int y)
        {
            int X = kernel1.GetLength(0) / 2;
            int Y = kernel1.GetLength(1) / 2;
            double resultR1 = 0;
            double resultG1 = 0;
            double resultB1 = 0;

            double resultR2 = 0;
            double resultG2 = 0;
            double resultB2 = 0;

            double resultR = 0;
            double resultG = 0;
            double resultB = 0;
            for (int l = -Y; l <= Y; l++)
            {
                for (int k = -X; k <= X; k++)
                {
                    int idX = Clamp(x + k, 0, sourceImage.Width - 1);
                    int idY = Clamp(y + l, 0, sourceImage.Height - 1);
                    Color nColor = sourceImage.GetPixel(idX, idY);

                    resultR1 += nColor.R * kernel1[k + X, l + Y];
                    resultG1 += nColor.G * kernel1[k + X, l + Y];
                    resultB1 += nColor.B * kernel1[k + X, l + Y];

                    resultR2 += nColor.R * kernel2[k + X, l + Y];
                    resultG2 += nColor.G * kernel2[k + X, l + Y];
                    resultB2 += nColor.B * kernel2[k + X, l + Y];

                    resultR = Math.Sqrt(resultR1 * resultR1 + resultR2 * resultR2);
                    resultG = Math.Sqrt(resultG1 * resultG1 + resultG2 * resultG2);
                    resultB = Math.Sqrt(resultB1 * resultB1 + resultB2 * resultB2);
                }
            }
            return Color.FromArgb(
                Clamp((int)resultR, 0, 255),
                Clamp((int)resultG, 0, 255),
                Clamp((int)resultB, 0, 255)
                );
        }
    }

    class MedianFilter1 : Filters
    {
        protected override Color CalculateColor(Bitmap sourceImage, int x, int y)
        {
            int X = 1;
            int Y = 1;
            int[] resultR = new int[9];
            int[] resultG = new int[9];
            int[] resultB = new int[9];
            int p = 0;
            for (int l = -Y; l <= Y; l++)
            {
                for (int k = -X; k <= X; k++)
                {
                    int idX = Clamp(x + k, 0, sourceImage.Width - 1);
                    int idY = Clamp(y + l, 0, sourceImage.Height - 1);
                    Color nColor = sourceImage.GetPixel(idX, idY);
                    resultR[p] = nColor.R;
                    resultG[p] = nColor.G;
                    resultB[p] = nColor.B;
                    p++;
                }
            }
            Array.Sort(resultR);
            Array.Sort(resultG);
            Array.Sort(resultB);
            return Color.FromArgb(
                resultR[5],
                resultG[5],
                resultB[5]
                );
        }
    }

    class MedianFilter2 : Filters
    {
        int Med0(int M1, int M2, int M3)
        {
            if ((M1 <= M2) && (M2 <= M3))
                return M2;
            else if ((M2 <= M1) && (M1 <= M3))
                return M1;
            else
                return M3;
        }

        Color Med1(Color nColor1, Color nColor2, Color nColor3)
        {
            int M1 = Med0(nColor1.R, nColor2.R, nColor3.R);
            int M2 = Med0(nColor1.G, nColor2.G, nColor3.G);
            int M3 = Med0(nColor1.B, nColor2.B, nColor3.B);
            return Color.FromArgb(M1, M2, M3);
        }

        Color Med2(int x, int y, int z, int v, Bitmap sourceImage, Color C)
        {
            int idX = Clamp(x, 0, sourceImage.Width - 1);
            int idY = Clamp(y, 0, sourceImage.Height - 1);
            Color nColor1 = sourceImage.GetPixel(idX, idY);
            idX = Clamp(z, 0, sourceImage.Width - 1);
            idY = Clamp(v, 0, sourceImage.Height - 1);
            Color nColor2 = sourceImage.GetPixel(idX, idY);
            return Med1(C, nColor1, nColor2);
        }

        protected override Color CalculateColor(Bitmap sourceImage, int x, int y)
        {
            Color C, M1, M2, M3, M4, Ma, Mb;
            C = sourceImage.GetPixel(x, y);

            M2 = Med2(x + 1, y, x - 1, y, sourceImage, C);
            M1 = Med2(x, y + 1, x, y - 1, sourceImage, C);
            M3 = Med2(x + 1, y + 1, x + 1, y - 1,sourceImage, C);
            M4 = Med2(x - 1, y - 1, x - 1, y + 1, sourceImage, C);
            
            Ma = Med1(C, M1, M2);
            Mb = Med1(C, M3, M4);
            return Med1(C, Ma, Mb);
        }
    }

    class BinaryOperationsBuildup : Filters
    {
        protected override Color CalculateColor(Bitmap sourceImage, int x, int y)
        {
            int X = 1;
            int Y = 1;
            int resultR = 0;
            int resultG = 0;
            int resultB = 0;
            int p = 0;
            int intence = 0;

            for (int l = -Y; l <= Y; l++)
            {
                for (int k = -X; k <= X; k++)
                {
                    int idX = Clamp(x + k, 0, sourceImage.Width - 1);
                    int idY = Clamp(y + l, 0, sourceImage.Height - 1);
                    Color nColor = sourceImage.GetPixel(idX, idY);
                    intence = Clamp((nColor.R + nColor.B + nColor.G) / 3, 0, 255);
                    if (intence > 125)
                    {
                        resultR += nColor.R;
                        resultG += nColor.G;
                        resultB += nColor.B;
                        p++;
                    }
                }
            }
            if (p > 0)
            {
                return Color.FromArgb(
                Clamp(resultR / p, 0, 255),
                Clamp(resultG / p, 0, 255),
                Clamp(resultB / p, 0, 255)
                );
            }
            else
            {               
                return sourceImage.GetPixel(X, Y);
            }
        }
    }

    class BinaryOperationsErosion : Filters
    {
        protected override Color CalculateColor(Bitmap sourceImage, int x, int y)
        {
            int X = 1;
            int Y = 1;
            int resultR = 0;
            int resultG = 0;
            int resultB = 0;
            int p = 0;
            int intence = 0;

            for (int l = -Y; l <= Y; l++)
            {
                for (int k = -X; k <= X; k++)
                {
                    int idX = Clamp(x + k, 0, sourceImage.Width - 1);
                    int idY = Clamp(y + l, 0, sourceImage.Height - 1);
                    Color nColor = sourceImage.GetPixel(idX, idY);
                    intence = Clamp((nColor.R + nColor.B + nColor.G) / 3, 0, 255);
                    if (intence < 125)
                    {
                        resultR += nColor.R;
                        resultG += nColor.G;
                        resultB += nColor.B;
                        p++;
                    }
                }
            }
            if (p > 0)
            {
                return Color.FromArgb(
                Clamp(resultR / p, 0, 255),
                Clamp(resultG / p, 0, 255),
                Clamp(resultB / p, 0, 255)
                );
            }
            else
            {
                //return sourceImage.GetPixel(X, Y);
                return Color.FromArgb(255, 255, 255);
            }
        }
    }

    class BinaryOperatinsClosure : Filters
    {
        protected override Color CalculateColor(Bitmap sourceImage, int x, int y)
        {
            return Color.FromArgb(0, 0, 0);
        }

        public override Bitmap processImage(Bitmap sourceImage, BackgroundWorker worker)
        {
            Bitmap resultImage = new Bitmap(sourceImage.Width, sourceImage.Height);
            Filters filter1 = new BinaryOperationsBuildup();
            Filters filter2 = new BinaryOperationsErosion();
            resultImage = filter1.processImage(sourceImage);
            resultImage = filter2.processImage(resultImage);
            return resultImage;
        }
    }

    class BinaryOperatinsDisjunction : Filters
    {
        protected override Color CalculateColor(Bitmap sourceImage, int x, int y)
        {
            return Color.FromArgb(0, 0, 0);
        }

        public override Bitmap processImage(Bitmap sourceImage, BackgroundWorker worker)
        {
            Bitmap resultImage = new Bitmap(sourceImage.Width, sourceImage.Height);
            Filters filter1 = new BinaryOperationsBuildup();
            Filters filter2 = new BinaryOperationsErosion();
            resultImage = filter2.processImage(sourceImage);
            resultImage = filter1.processImage(resultImage);
            return resultImage;
        }
    }

    class HarshnessFilter : MatrixFilter
    {
        public HarshnessFilter()
        {
            kernel = new double[3, 3] {
                { -1, -1, -1},
                { -1, 9, -1},
                { -1, -1, -1} };
        }
    }

}
