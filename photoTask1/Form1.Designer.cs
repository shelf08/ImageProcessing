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
            Filter1 = new Button();
            Filter2 = new Button();
            Filter3 = new Button();
            label2 = new Label();
            label3 = new Label();
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
            btnLoad.BackColor = Color.Lime;
            btnLoad.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnLoad.Location = new Point(75, 677);
            btnLoad.Margin = new Padding(3, 4, 3, 4);
            btnLoad.Name = "btnLoad";
            btnLoad.Size = new Size(100, 38);
            btnLoad.TabIndex = 2;
            btnLoad.Text = "Загрузка";
            btnLoad.UseVisualStyleBackColor = false;
            btnLoad.Click += btnLoad_Click;
            // 
            // btnProcess
            // 
            btnProcess.BackColor = SystemColors.ActiveBorder;
            btnProcess.Location = new Point(290, 677);
            btnProcess.Margin = new Padding(3, 4, 3, 4);
            btnProcess.Name = "btnProcess";
            btnProcess.Size = new Size(149, 38);
            btnProcess.TabIndex = 3;
            btnProcess.Text = "Обработка в чб";
            btnProcess.UseVisualStyleBackColor = false;
            btnProcess.Click += btnProcess_Click;
            // 
            // btnSave
            // 
            btnSave.BackColor = Color.Lime;
            btnSave.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnSave.Location = new Point(1604, 674);
            btnSave.Margin = new Padding(3, 4, 3, 4);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(100, 38);
            btnSave.TabIndex = 4;
            btnSave.Text = "Сохранить";
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += btnSave_Click;
            // 
            // gause
            // 
            gause.BackColor = SystemColors.ActiveCaption;
            gause.Location = new Point(489, 677);
            gause.Name = "gause";
            gause.Size = new Size(149, 38);
            gause.TabIndex = 5;
            gause.Text = "Гауссовский";
            gause.UseVisualStyleBackColor = false;
            gause.Click += gause_Click;
            // 
            // btnHz
            // 
            btnHz.BackColor = SystemColors.ActiveBorder;
            btnHz.Location = new Point(290, 722);
            btnHz.Name = "btnHz";
            btnHz.Size = new Size(149, 38);
            btnHz.TabIndex = 6;
            btnHz.Text = "Частоты";
            btnHz.UseVisualStyleBackColor = false;
            btnHz.Click += btnHz_Click;
            // 
            // textBoxSigma
            // 
            textBoxSigma.BackColor = SystemColors.ActiveCaption;
            textBoxSigma.Location = new Point(489, 744);
            textBoxSigma.Name = "textBoxSigma";
            textBoxSigma.Size = new Size(149, 27);
            textBoxSigma.TabIndex = 7;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.Control;
            label1.Location = new Point(513, 718);
            label1.Name = "label1";
            label1.Size = new Size(109, 20);
            label1.TabIndex = 8;
            label1.Text = "Введите sigma";
            // 
            // btnSP
            // 
            btnSP.BackColor = SystemColors.ActiveCaptionText;
            btnSP.ForeColor = SystemColors.Control;
            btnSP.Location = new Point(489, 843);
            btnSP.Name = "btnSP";
            btnSP.Size = new Size(149, 38);
            btnSP.TabIndex = 9;
            btnSP.Text = "Соль-перец";
            btnSP.UseVisualStyleBackColor = false;
            btnSP.Click += btnSP_Click;
            // 
            // SPBox
            // 
            SPBox.BackColor = SystemColors.InfoText;
            SPBox.ForeColor = SystemColors.Window;
            SPBox.Location = new Point(489, 907);
            SPBox.Name = "SPBox";
            SPBox.Size = new Size(149, 27);
            SPBox.TabIndex = 10;
            SPBox.TextChanged += SPBox_TextChanged;
            // 
            // Filter
            // 
            Filter.BackColor = Color.Teal;
            Filter.Location = new Point(780, 677);
            Filter.Name = "Filter";
            Filter.Size = new Size(164, 38);
            Filter.TabIndex = 11;
            Filter.Text = "Фильтр НЧ";
            Filter.UseVisualStyleBackColor = false;
            Filter.Click += Filter_Click;
            // 
            // textBoxMaskNumber
            // 
            textBoxMaskNumber.BackColor = Color.Teal;
            textBoxMaskNumber.Location = new Point(780, 744);
            textBoxMaskNumber.Name = "textBoxMaskNumber";
            textBoxMaskNumber.Size = new Size(164, 27);
            textBoxMaskNumber.TabIndex = 12;
            textBoxMaskNumber.TextChanged += textBoxMaskNumber_TextChanged;
            // 
            // MedianF
            // 
            MedianF.BackColor = Color.FromArgb(255, 192, 128);
            MedianF.Location = new Point(1069, 677);
            MedianF.Name = "MedianF";
            MedianF.Size = new Size(216, 34);
            MedianF.TabIndex = 13;
            MedianF.Text = "Медианный фильтр квадрат";
            MedianF.UseVisualStyleBackColor = false;
            MedianF.Click += MedianF_Click;
            // 
            // MedianFx
            // 
            MedianFx.BackColor = Color.FromArgb(255, 192, 128);
            MedianFx.Location = new Point(1069, 718);
            MedianFx.Name = "MedianFx";
            MedianFx.Size = new Size(216, 39);
            MedianFx.TabIndex = 14;
            MedianFx.Text = "Медианный фильтр крест";
            MedianFx.UseVisualStyleBackColor = false;
            MedianFx.Click += MedianFx_Click;
            // 
            // Filter1
            // 
            Filter1.BackColor = Color.FromArgb(255, 192, 192);
            Filter1.Location = new Point(780, 842);
            Filter1.Name = "Filter1";
            Filter1.Size = new Size(164, 38);
            Filter1.TabIndex = 15;
            Filter1.Text = "Фильтр ВЧ1";
            Filter1.UseVisualStyleBackColor = false;
            Filter1.Click += Filter1_Click;
            // 
            // Filter2
            // 
            Filter2.BackColor = Color.FromArgb(255, 192, 192);
            Filter2.Location = new Point(780, 886);
            Filter2.Name = "Filter2";
            Filter2.Size = new Size(164, 38);
            Filter2.TabIndex = 16;
            Filter2.Text = "Фильтр ВЧ2";
            Filter2.UseVisualStyleBackColor = false;
            Filter2.Click += Filter2_Click;
            // 
            // Filter3
            // 
            Filter3.BackColor = Color.FromArgb(255, 192, 192);
            Filter3.Location = new Point(780, 930);
            Filter3.Name = "Filter3";
            Filter3.Size = new Size(164, 38);
            Filter3.TabIndex = 17;
            Filter3.Text = "Фильтр ВЧ3";
            Filter3.UseVisualStyleBackColor = false;
            Filter3.Click += Filter3_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = SystemColors.Control;
            label2.Location = new Point(768, 718);
            label2.Name = "label2";
            label2.Size = new Size(197, 20);
            label2.TabIndex = 18;
            label2.Text = "Введите номер маски (1-6)";
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = SystemColors.Control;
            label3.Location = new Point(469, 884);
            label3.Name = "label3";
            label3.Size = new Size(190, 20);
            label3.TabIndex = 19;
            label3.Text = "Введите количество точек";
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1777, 1038);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(Filter3);
            Controls.Add(Filter2);
            Controls.Add(Filter1);
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
        private Button Filter1;
        private Button Filter2;
        private Button Filter3;
        private Label label2;
        private Label label3;
    }
}