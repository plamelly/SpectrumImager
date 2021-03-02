namespace SpectrumImager
{
    partial class SpectrumImagerForm
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
            this.components = new System.ComponentModel.Container();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.selectPathButton = new System.Windows.Forms.Button();
            this.filePathTextBox = new System.Windows.Forms.TextBox();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.clearDataButton = new System.Windows.Forms.Button();
            this.showSpectrumButton = new System.Windows.Forms.Button();
            this.rmsCalculationButton = new System.Windows.Forms.Button();
            this.loadDataButton = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.pointCountLabel = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.frequencyValueLabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.rmsValueLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.imager = new ZedGraph.ZedGraphControl();
            this.frequencyValueTextBox = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.selectPathButton);
            this.groupBox1.Controls.Add(this.filePathTextBox);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(880, 61);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Путь к файлу (*.csv)";
            // 
            // selectPathButton
            // 
            this.selectPathButton.Location = new System.Drawing.Point(722, 14);
            this.selectPathButton.Name = "selectPathButton";
            this.selectPathButton.Size = new System.Drawing.Size(146, 37);
            this.selectPathButton.TabIndex = 1;
            this.selectPathButton.Text = "Обзор";
            this.selectPathButton.UseVisualStyleBackColor = true;
            this.selectPathButton.Click += new System.EventHandler(this.SelectPathButton_Click);
            // 
            // filePathTextBox
            // 
            this.filePathTextBox.Location = new System.Drawing.Point(12, 21);
            this.filePathTextBox.Name = "filePathTextBox";
            this.filePathTextBox.ReadOnly = true;
            this.filePathTextBox.Size = new System.Drawing.Size(704, 22);
            this.filePathTextBox.TabIndex = 0;
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Location = new System.Drawing.Point(0, 580);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(880, 22);
            this.statusStrip1.TabIndex = 2;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.clearDataButton);
            this.groupBox2.Controls.Add(this.showSpectrumButton);
            this.groupBox2.Controls.Add(this.rmsCalculationButton);
            this.groupBox2.Controls.Add(this.loadDataButton);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBox2.Location = new System.Drawing.Point(3, 309);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(290, 207);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Управление";
            // 
            // clearDataButton
            // 
            this.clearDataButton.Location = new System.Drawing.Point(3, 150);
            this.clearDataButton.Name = "clearDataButton";
            this.clearDataButton.Size = new System.Drawing.Size(278, 37);
            this.clearDataButton.TabIndex = 3;
            this.clearDataButton.Text = "Очистка";
            this.clearDataButton.UseVisualStyleBackColor = true;
            this.clearDataButton.Click += new System.EventHandler(this.ClearDataButton_Click);
            // 
            // showSpectrumButton
            // 
            this.showSpectrumButton.Location = new System.Drawing.Point(3, 107);
            this.showSpectrumButton.Name = "showSpectrumButton";
            this.showSpectrumButton.Size = new System.Drawing.Size(278, 37);
            this.showSpectrumButton.TabIndex = 2;
            this.showSpectrumButton.Text = "Построение спектра";
            this.showSpectrumButton.UseVisualStyleBackColor = true;
            this.showSpectrumButton.Click += new System.EventHandler(this.ShowSpectrumButton_Click);
            // 
            // rmsCalculationButton
            // 
            this.rmsCalculationButton.Location = new System.Drawing.Point(3, 64);
            this.rmsCalculationButton.Name = "rmsCalculationButton";
            this.rmsCalculationButton.Size = new System.Drawing.Size(278, 37);
            this.rmsCalculationButton.TabIndex = 1;
            this.rmsCalculationButton.Text = "Расчёт СКЗ";
            this.rmsCalculationButton.UseVisualStyleBackColor = true;
            this.rmsCalculationButton.Click += new System.EventHandler(this.RmsCalculationButton_Click);
            // 
            // loadDataButton
            // 
            this.loadDataButton.Location = new System.Drawing.Point(3, 21);
            this.loadDataButton.Name = "loadDataButton";
            this.loadDataButton.Size = new System.Drawing.Size(278, 37);
            this.loadDataButton.TabIndex = 0;
            this.loadDataButton.Text = "Загрузка данных";
            this.loadDataButton.UseVisualStyleBackColor = true;
            this.loadDataButton.Click += new System.EventHandler(this.LoadDataButton_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.groupBox5);
            this.groupBox3.Controls.Add(this.groupBox2);
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Right;
            this.groupBox3.Location = new System.Drawing.Point(584, 61);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(296, 519);
            this.groupBox3.TabIndex = 4;
            this.groupBox3.TabStop = false;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.frequencyValueTextBox);
            this.groupBox5.Controls.Add(this.pointCountLabel);
            this.groupBox5.Controls.Add(this.label4);
            this.groupBox5.Controls.Add(this.label3);
            this.groupBox5.Controls.Add(this.frequencyValueLabel);
            this.groupBox5.Controls.Add(this.label2);
            this.groupBox5.Controls.Add(this.rmsValueLabel);
            this.groupBox5.Controls.Add(this.label1);
            this.groupBox5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox5.Location = new System.Drawing.Point(3, 18);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(290, 291);
            this.groupBox5.TabIndex = 4;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Информация";
            // 
            // pointCountLabel
            // 
            this.pointCountLabel.AutoSize = true;
            this.pointCountLabel.Location = new System.Drawing.Point(178, 73);
            this.pointCountLabel.Name = "pointCountLabel";
            this.pointCountLabel.Size = new System.Drawing.Size(16, 17);
            this.pointCountLabel.TabIndex = 6;
            this.pointCountLabel.Text = "0";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 73);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(166, 17);
            this.label4.TabIndex = 5;
            this.label4.Text = "Количество отсчётов = ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(178, 53);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(24, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "Гц";
            // 
            // frequencyValueLabel
            // 
            this.frequencyValueLabel.AutoSize = true;
            this.frequencyValueLabel.Location = new System.Drawing.Point(86, 53);
            this.frequencyValueLabel.Margin = new System.Windows.Forms.Padding(0, 0, 3, 0);
            this.frequencyValueLabel.Name = "frequencyValueLabel";
            this.frequencyValueLabel.Size = new System.Drawing.Size(0, 17);
            this.frequencyValueLabel.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 53);
            this.label2.Margin = new System.Windows.Forms.Padding(3, 3, 1, 3);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Частота = ";
            // 
            // rmsValueLabel
            // 
            this.rmsValueLabel.AutoSize = true;
            this.rmsValueLabel.Location = new System.Drawing.Point(63, 33);
            this.rmsValueLabel.Name = "rmsValueLabel";
            this.rmsValueLabel.Size = new System.Drawing.Size(16, 17);
            this.rmsValueLabel.TabIndex = 1;
            this.rmsValueLabel.Text = "0";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "СКЗ = ";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.imager);
            this.groupBox4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox4.Location = new System.Drawing.Point(0, 61);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(584, 519);
            this.groupBox4.TabIndex = 5;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "График";
            // 
            // imager
            // 
            this.imager.Dock = System.Windows.Forms.DockStyle.Fill;
            this.imager.Location = new System.Drawing.Point(3, 18);
            this.imager.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.imager.Name = "imager";
            this.imager.ScrollGrace = 0D;
            this.imager.ScrollMaxX = 0D;
            this.imager.ScrollMaxY = 0D;
            this.imager.ScrollMaxY2 = 0D;
            this.imager.ScrollMinX = 0D;
            this.imager.ScrollMinY = 0D;
            this.imager.ScrollMinY2 = 0D;
            this.imager.Size = new System.Drawing.Size(578, 498);
            this.imager.TabIndex = 0;
            this.imager.UseExtendedPrintDialog = true;
            // 
            // frequencyValueTextBox
            // 
            this.frequencyValueTextBox.Location = new System.Drawing.Point(89, 50);
            this.frequencyValueTextBox.Name = "frequencyValueTextBox";
            this.frequencyValueTextBox.Size = new System.Drawing.Size(83, 22);
            this.frequencyValueTextBox.TabIndex = 7;
            this.frequencyValueTextBox.Text = "14638";
            this.frequencyValueTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // SpectrumImagerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(880, 602);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "SpectrumImagerForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Spectrum Imager";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button selectPathButton;
        private System.Windows.Forms.TextBox filePathTextBox;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label rmsValueLabel;
        private System.Windows.Forms.Button loadDataButton;
        private System.Windows.Forms.Button rmsCalculationButton;
        private System.Windows.Forms.Button showSpectrumButton;
        private System.Windows.Forms.Button clearDataButton;
        private System.Windows.Forms.Label frequencyValueLabel;
        private System.Windows.Forms.Label label2;
        private ZedGraph.ZedGraphControl imager;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label pointCountLabel;
        private System.Windows.Forms.TextBox frequencyValueTextBox;
    }
}

