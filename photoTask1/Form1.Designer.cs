namespace photoTask1
{
    partial class MainForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.PictureBox pictureBoxOriginal;
        private System.Windows.Forms.PictureBox pictureBoxProcessed;
        private System.Windows.Forms.Button btnLoad;
        private System.Windows.Forms.Button btnProcess;
        private System.Windows.Forms.Button btnSave; // Новая кнопка

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            pictureBoxOriginal = new PictureBox();
            pictureBoxProcessed = new PictureBox();
            btnLoad = new Button();
            btnProcess = new Button();
            btnSave = new Button();
            gause = new Button();
            btnHz = new Button();
            textBoxSigma = new TextBox();
            label1 = new Label();
            btnSP = new Button();
            SPBox = new TextBox();
            Filter = new Button();
            textBoxMaskNumber = new TextBox();
            MedianF = new Button();
            MedianFx = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBoxOriginal).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxProcessed).BeginInit();
            SuspendLayout();
            // 
            // pictureBoxOriginal
            // 
            pictureBoxOriginal.BorderStyle = BorderStyle.FixedSingle;
            pictureBoxOriginal.Location = new Point(12, 15);
            pictureBoxOriginal.Margin = new Padding(3, 4, 3, 4);
            pictureBoxOriginal.Name = "pictureBoxOriginal";
            pictureBoxOriginal.Size = new Size(852, 515);
            pictureBoxOriginal.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBoxOriginal.TabIndex = 0;
            pictureBoxOriginal.TabStop = false;
            pictureBoxOriginal.Click += pictureBoxOriginal_Click;
            // 
            // pictureBoxProcessed
            // 
            pictureBoxProcessed.BorderStyle = BorderStyle.FixedSingle;
            pictureBoxProcessed.Location = new Point(897, 15);
            pictureBoxProcessed.Margin = new Padding(3, 4, 3, 4);
            pictureBoxProcessed.Name = "pictureBoxProcessed";
            pictureBoxProcessed.Size = new Size(856, 515);
            pictureBoxProcessed.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBoxProcessed.TabIndex = 1;
            pictureBoxProcessed.TabStop = false;
            pictureBoxProcessed.Click += pictureBoxProcessed_Click;
            // 
            // btnLoad
            // 
            btnLoad.Location = new Point(232, 677);
            btnLoad.Margin = new Padding(3, 4, 3, 4);
            btnLoad.Name = "btnLoad";
            btnLoad.Size = new Size(100, 38);
            btnLoad.TabIndex = 2;
            btnLoad.Text = "Загрузка";
            btnLoad.UseVisualStyleBackColor = true;
            btnLoad.Click += btnLoad_Click;
            // 
            // btnProcess
            // 
            btnProcess.Location = new Point(712, 642);
            btnProcess.Margin = new Padding(3, 4, 3, 4);
            btnProcess.Name = "btnProcess";
            btnProcess.Size = new Size(149, 38);
            btnProcess.TabIndex = 3;
            btnProcess.Text = "Обработка в чб";
            btnProcess.UseVisualStyleBackColor = true;
            btnProcess.Click += btnProcess_Click;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(1416, 677);
            btnSave.Margin = new Padding(3, 4, 3, 4);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(100, 38);
            btnSave.TabIndex = 4;
            btnSave.Text = "Сохранить";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // gause
            // 
            gause.Location = new Point(712, 687);
            gause.Name = "gause";
            gause.Size = new Size(149, 38);
            gause.TabIndex = 5;
            gause.Text = "Гауссовский";
            gause.UseVisualStyleBackColor = true;
            gause.Click += gause_Click;
            // 
            // btnHz
            // 
            btnHz.Location = new Point(712, 731);
            btnHz.Name = "btnHz";
            btnHz.Size = new Size(149, 45);
            btnHz.TabIndex = 6;
            btnHz.Text = "Частоты";
            btnHz.UseVisualStyleBackColor = true;
            btnHz.Click += btnHz_Click;
            // 
            // textBoxSigma
            // 
            textBoxSigma.Location = new Point(882, 693);
            textBoxSigma.Name = "textBoxSigma";
            textBoxSigma.Size = new Size(137, 27);
            textBoxSigma.TabIndex = 7;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(896, 670);
            label1.Name = "label1";
            label1.Size = new Size(109, 20);
            label1.TabIndex = 8;
            label1.Text = "Введите sigma";
            // 
            // btnSP
            // 
            btnSP.Location = new Point(1068, 687);
            btnSP.Name = "btnSP";
            btnSP.Size = new Size(114, 33);
            btnSP.TabIndex = 9;
            btnSP.Text = "Соль-перец";
            btnSP.UseVisualStyleBackColor = true;
            btnSP.Click += btnSP_Click;
            // 
            // SPBox
            // 
            SPBox.Location = new Point(1211, 690);
            SPBox.Name = "SPBox";
            SPBox.Size = new Size(74, 27);
            SPBox.TabIndex = 10;
            SPBox.TextChanged += SPBox_TextChanged;
            // 
            // Filter
            // 
            Filter.Location = new Point(1068, 758);
            Filter.Name = "Filter";
            Filter.Size = new Size(114, 33);
            Filter.TabIndex = 11;
            Filter.Text = "Фильтр";
            Filter.UseVisualStyleBackColor = true;
            Filter.Click += Filter_Click;
            // 
            // textBoxMaskNumber
            // 
            textBoxMaskNumber.Location = new Point(1068, 799);
            textBoxMaskNumber.Name = "textBoxMaskNumber";
            textBoxMaskNumber.Size = new Size(114, 27);
            textBoxMaskNumber.TabIndex = 12;
            textBoxMaskNumber.TextChanged += textBoxMaskNumber_TextChanged;
            // 
            // MedianF
            // 
            MedianF.Location = new Point(1211, 758);
            MedianF.Name = "MedianF";
            MedianF.Size = new Size(216, 34);
            MedianF.TabIndex = 13;
            MedianF.Text = "Медианный фильтр квадрат";
            MedianF.UseVisualStyleBackColor = true;
            MedianF.Click += MedianF_Click;
            // 
            // MedianFx
            // 
            MedianFx.Location = new Point(1211, 799);
            MedianFx.Name = "MedianFx";
            MedianFx.Size = new Size(216, 39);
            MedianFx.TabIndex = 14;
            MedianFx.Text = "Медианный фильтр крест";
            MedianFx.UseVisualStyleBackColor = true;
            MedianFx.Click += MedianFx_Click;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1777, 838);
            Controls.Add(MedianFx);
            Controls.Add(MedianF);
            Controls.Add(textBoxMaskNumber);
            Controls.Add(Filter);
            Controls.Add(SPBox);
            Controls.Add(btnSP);
            Controls.Add(label1);
            Controls.Add(textBoxSigma);
            Controls.Add(btnHz);
            Controls.Add(gause);
            Controls.Add(btnSave);
            Controls.Add(btnProcess);
            Controls.Add(btnLoad);
            Controls.Add(pictureBoxProcessed);
            Controls.Add(pictureBoxOriginal);
            Margin = new Padding(3, 4, 3, 4);
            Name = "MainForm";
            Text = "Image Processing App";
            Load += MainForm_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBoxOriginal).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxProcessed).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }
        private Button gause;
        private Button btnHz;
        private TextBox textBoxSigma;
        private Label label1;
        private Button btnSP;
        private TextBox SPBox;
        private Button Filter;
        private TextBox textBoxMaskNumber;
        private Button MedianF;
        private Button MedianFx;
    }
}