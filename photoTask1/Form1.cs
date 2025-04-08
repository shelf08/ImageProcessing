using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.Runtime.Intrinsics.X86;
using System.Windows.Forms;

namespace photoTask1
{
    public partial class MainForm : Form
    {
        private Bitmap bmp1;
        public MainForm()
        {
            InitializeComponent();
        }

        Random rnd = new Random();

        private void btnLoad_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp;*.gif";

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        Bitmap bmp = new Bitmap(openFileDialog.FileName);
                        pictureBoxOriginal.Image = bmp;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Ошибка загрузки изображения: " + ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void btnProcess_Click(object sender, EventArgs e)
        {
            Bitmap bmp = (Bitmap)pictureBoxOriginal.Image;
            bmp1 = new Bitmap(bmp.Width, bmp.Height);
            int x, y;
            int r, g, b, br;
            Color cl;
            for (y = 0; y < bmp.Height; y++)
            {
                for (x = 0; x < bmp.Width; x++)
                {
                    cl = bmp.GetPixel(x, y);
                    r = cl.R; g = cl.G; b = cl.B;
                    br = (r + g + b) / 3;
                    cl = Color.FromArgb(br, br, br);
                    bmp1.SetPixel(x, y, cl);
                }
            }
            pictureBoxProcessed.Image = bmp1;
        }
        private void btnHz_Click(object sender, EventArgs e)
        {
            Bitmap bmp = (Bitmap)pictureBoxOriginal.Image;
            bmp1 = new Bitmap(bmp.Width, bmp.Height);
            int x, y;
            int r, g, b, br;
            double u = 0.5, v = 0;
            Color cl;
            for (y = 0; y < bmp.Height; y++)
            {
                for (x = 0; x < bmp.Width; x++)
                {
                    cl = bmp.GetPixel(x, y);
                    r = cl.R; g = cl.G; b = cl.B;
                    br = Convert.ToInt32(100 + 50 * Math.Cos(x * u + y * v));
                    cl = Color.FromArgb(br, br, br);
                    bmp1.SetPixel(x, y, cl);
                }
            }
            pictureBoxProcessed.Image = bmp1;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            // Проверяем, есть ли обработанное изображение
            //
            if (pictureBoxProcessed.Image != null)
            {
                // Создаем диалог сохранения файла
                SaveFileDialog saveDialog = new SaveFileDialog();
                saveDialog.Filter = "PNG|*.png|JPEG|*.jpg|BMP|*.bmp";
                saveDialog.Title = "Сохранить изображение";

                // Если пользователь выбрал файл и нажал "Сохранить"
                if (saveDialog.ShowDialog() == DialogResult.OK)
                {
                    // Сохраняем изображение
                    pictureBoxProcessed.Image.Save(saveDialog.FileName);
                    MessageBox.Show("Изображение сохранено!", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("Нет изображения для сохранения.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void gause_Click(object sender, EventArgs e)
        {
            if (!double.TryParse(textBoxSigma.Text, out double sigma))
            {
                MessageBox.Show("Введите корректное значение sigma (число).", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            Bitmap bmp = (Bitmap)pictureBoxOriginal.Image;
            if (bmp == null) return;

            bmp1 = new Bitmap(bmp.Width, bmp.Height);
            int x, y;
            int r, g, b;
            Color cl;

            for (y = 0; y < bmp.Height; y++)
            {
                for (x = 0; x < bmp.Width; x++)
                {
                    cl = bmp.GetPixel(x, y);

                    r = cl.R;
                    g = cl.G;
                    b = cl.B;

                    double d = 0;
                    for (int i = 0; i < 12; i++)
                    {
                        d += rnd.NextDouble();
                    }
                    d -= 6;

                    r += Convert.ToInt32(sigma * d);
                    g += Convert.ToInt32(sigma * d);
                    b += Convert.ToInt32(sigma * d);

                    if (r < 0) r = 0; else if (r > 255) r = 255;
                    if (g < 0) g = 0; else if (g > 255) g = 255;
                    if (b < 0) b = 0; else if (b > 255) b = 255;

                    cl = Color.FromArgb(r, g, b);
                    bmp1.SetPixel(x, y, cl);
                }
            }
            pictureBoxProcessed.Image = bmp1;
        }

        private void btnSP_Click(object sender, EventArgs e)
        {
            // Проверяем, есть ли изображение в pictureBoxOriginal
            if (pictureBoxOriginal.Image == null)
            {
                MessageBox.Show("Загрузите изображение сначала.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Пытаемся получить количество пикселей для шума из SPBox
            if (!double.TryParse(SPBox.Text, out double noisePower))
            {
                MessageBox.Show("Введите корректное количество пикселей (положительное число).", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Создаем копию оригинального изображения
            Bitmap bmp = (Bitmap)pictureBoxOriginal.Image;
            Bitmap bmp1 = new Bitmap(bmp.Width, bmp.Height);

            // Копируем оригинальное изображение в noisyImage
            using (Graphics g = Graphics.FromImage(bmp1))
            {
                g.DrawImage(bmp, 0, 0, bmp.Width, bmp.Height);
            }

            Random random = new Random();

            // Применяем шум "соль-перец"
            for (int i = 0; i < noisePower; i++)
            {
                // Случайные координаты пикселя
                int x = random.Next(0, bmp1.Width);
                int y = random.Next(0, bmp1.Height);

                // Случайный выбор: "соль" (белый) или "перец" (черный)
                Color noiseColor = random.Next(2) == 0 ? Color.Black : Color.White;

                // Применяем шум к пикселю
                bmp1.SetPixel(x, y, noiseColor);
            }

            // Отображаем зашумленное изображение в pictureBoxProcessed
            pictureBoxProcessed.Image = bmp1;
            MessageBox.Show("Шум 'соль-перец' добавлен!", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        private void Filter_Click(object sender, EventArgs e)
        {
            // Проверяем, загружено ли изображение
            if (pictureBoxOriginal.Image == null)
            {
                MessageBox.Show("Загрузите изображение сначала!");
                return;
            }

            // Получаем введенный номер маски
            if (!int.TryParse(textBoxMaskNumber.Text, out int maskChoice) || maskChoice < 1 || maskChoice > 6)
            {
                MessageBox.Show("Введите число от 1 до 6!");
                return;
            }

            Bitmap bmp = (Bitmap)pictureBoxOriginal.Image;
            Bitmap bmp1 = new Bitmap(bmp.Width, bmp.Height);

            // Получаем ядро (маску) в зависимости от выбора
            double[,] kernel = GetKernel(maskChoice);

            // Сумма элементов ядра для нормализации
            double kernelSum = GetKernelSum(kernel);

            int x, y;
            int r, g, b;
            Color cl;

            // Итерация по каждому пикселю изображения (исключая границы)
            for (y = 2; y < bmp.Height - 2; ++y)
            {
                for (x = 2; x < bmp.Width - 2; ++x)
                {
                    double rs = 0, gs = 0, bs = 0;

                    for (int i = -2; i <= 2; ++i)
                    {
                        for (int j = -2; j <= 2; ++j)
                        {
                            cl = bmp.GetPixel(x + i, y + j);
                            r = cl.R; g = cl.G; b = cl.B;

                            rs += r * kernel[i + 2, j + 2];
                            gs += g * kernel[i + 2, j + 2];
                            bs += b * kernel[i + 2, j + 2];
                        }
                    }

                    r = Convert.ToInt32(rs / kernelSum);
                    g = Convert.ToInt32(gs / kernelSum);
                    b = Convert.ToInt32(bs / kernelSum);

                    r = Math.Max(0, Math.Min(255, r));
                    g = Math.Max(0, Math.Min(255, g));
                    b = Math.Max(0, Math.Min(255, b));

                    cl = Color.FromArgb(r, g, b);
                    bmp1.SetPixel(x, y, cl);
                }
            }

            pictureBoxProcessed.Image = bmp1;
        }

        private double[,] CreateKernel(double w1, double w2, double w3)
        {
            return new double[,] {
        { w3, w3, w3, w3, w3 },
        { w3, w2, w2, w2, w3 },
        { w3, w2, w1, w2, w3 },
        { w3, w2, w2, w2, w3 },
        { w3, w3, w3, w3, w3 }
    };
        }

        private double[,] GetKernel(int choice)
        {
            switch (choice)
            {
                case 1:
                    // Маска 1: w1 = 0.440, w2 = 0.070, w3 = 0.000
                    return CreateKernel(0.440, 0.070, 0.000);

                case 2:
                    // Маска 2: w1 = 0.270, w2 = 0.000, w3 = 0.005
                    return CreateKernel(0.270, 0.000, 0.005);

                case 3:
                    // Маска 3: w1 = 0.150, w2 = 0.060, w3 = 0.020
                    return CreateKernel(0.150, 0.060, 0.020);

                case 4:
                    // Маска 4: w1 = 0.100, w2 = 0.060, w3 = 0.020
                    return CreateKernel(0.100, 0.060, 0.020);

                case 5:
                    // Маска 5: w1 = 0.060, w2 = 0.045, w3 = 0.030
                    return CreateKernel(0.060, 0.045, 0.030);

                case 6:
                    // Маска 6: w1 = 0.060, w2 = 0.060, w3 = 0.025
                    return CreateKernel(0.060, 0.060, 0.025);

                default:
                    // По умолчанию возвращаем маску 1
                    return CreateKernel(0.440, 0.070, 0.000);
            }
        }


        private double GetKernelSum(double[,] kernel)
        {
            double sum = 0;
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    sum += kernel[i, j];
                }
            }
            return sum;
        }

        private void MedianF_Click(object sender, EventArgs e)
        {
            if (pictureBoxOriginal.Image == null)
            {
                MessageBox.Show("Сначала загрузите изображение!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            Bitmap bmp = (Bitmap)pictureBoxOriginal.Image;
            bmp1 = new Bitmap(bmp.Width, bmp.Height);

            for (int y = 2; y < bmp.Height - 2; y++)
            {
                for (int x = 2; x < bmp.Width - 2; x++)
                {
                    List<int> redValues = new List<int>();
                    List<int> greenValues = new List<int>();
                    List<int> blueValues = new List<int>();

                    for (int fy = -2; fy <= 2; fy++)
                    {
                        for (int fx = -2; fx <= 2; fx++)
                        {
                            Color pixel = bmp.GetPixel(x + fx, y + fy);
                            redValues.Add(pixel.R);
                            greenValues.Add(pixel.G);
                            blueValues.Add(pixel.B);
                        }
                    }

                    redValues.Sort();
                    greenValues.Sort();
                    blueValues.Sort();

                    int medianRed = redValues[12];
                    int medianGreen = greenValues[12];
                    int medianBlue = blueValues[12];

                    bmp1.SetPixel(x, y, Color.FromArgb(medianRed, medianGreen, medianBlue));
                }
            }

            pictureBoxProcessed.Image = bmp1;
            MessageBox.Show("Медианный фильтр 5x5 применен!", "Готово", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        private void MedianFx_Click(object sender, EventArgs e)
        {
            if (pictureBoxOriginal.Image == null)
            {
                MessageBox.Show("Сначала загрузите изображение!", "Ошибка",
                               MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            Bitmap bmp = (Bitmap)pictureBoxOriginal.Image;
            Bitmap resultBmp = new Bitmap(bmp.Width, bmp.Height);

            for (int y = 2; y < bmp.Height - 2; y++)
            {
                for (int x = 2; x < bmp.Width - 2; x++)
                {
                    List<int> redValues = new List<int>();
                    List<int> greenValues = new List<int>();
                    List<int> blueValues = new List<int>();

                    for (int dy = -2; dy <= 2; dy++)
                    {
                        Color pixel = bmp.GetPixel(x, y + dy);
                        redValues.Add(pixel.R);
                        greenValues.Add(pixel.G);
                        blueValues.Add(pixel.B);
                    }

                    for (int dx = -2; dx <= 2; dx++)
                    {
                        if (dx == 0) continue;
                        Color pixel = bmp.GetPixel(x + dx, y);
                        redValues.Add(pixel.R);
                        greenValues.Add(pixel.G);
                        blueValues.Add(pixel.B);
                    }

                    redValues.Sort();
                    greenValues.Sort();
                    blueValues.Sort();

                    int medianIndex = redValues.Count/2;
                    Color medianColor = Color.FromArgb(
                        redValues[medianIndex],
                        greenValues[medianIndex],
                        blueValues[medianIndex]);

                    resultBmp.SetPixel(x, y, medianColor);
                }
            }

            pictureBoxProcessed.Image = resultBmp;
            MessageBox.Show("Медианный фильтр (крест 5x5) применен!", "Готово",
                           MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void SPBox_TextChanged(object sender, EventArgs e)
        {

        }
        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private void gauseText_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBoxOriginal_Click(object sender, EventArgs e)
        {

        }

        private void pictureBoxProcessed_Click(object sender, EventArgs e)
        {

        }

        private void textBoxMaskNumber_TextChanged(object sender, EventArgs e)
        {

        }


    }
}