namespace pe4
{
    partial class Calc
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.groupBoxInData = new System.Windows.Forms.GroupBox();
            this.textBoxEps = new System.Windows.Forms.TextBox();
            this.labelBorderA = new System.Windows.Forms.Label();
            this.textBoxBorderB = new System.Windows.Forms.TextBox();
            this.labelBorderB = new System.Windows.Forms.Label();
            this.textBoxBorderA = new System.Windows.Forms.TextBox();
            this.labelEps = new System.Windows.Forms.Label();
            this.groupBoxChangeFoo = new System.Windows.Forms.GroupBox();
            this.radioButtonFoo2 = new System.Windows.Forms.RadioButton();
            this.radioButtonFoo1 = new System.Windows.Forms.RadioButton();
            this.buttonNewton = new System.Windows.Forms.Button();
            this.buttonDichtomy = new System.Windows.Forms.Button();
            this.labelResult = new System.Windows.Forms.Label();
            this.textBoxResult = new System.Windows.Forms.TextBox();
            this.chartFoo = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.groupBoxInData.SuspendLayout();
            this.groupBoxChangeFoo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartFoo)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBoxInData
            // 
            this.groupBoxInData.Controls.Add(this.textBoxEps);
            this.groupBoxInData.Controls.Add(this.labelBorderA);
            this.groupBoxInData.Controls.Add(this.textBoxBorderB);
            this.groupBoxInData.Controls.Add(this.labelBorderB);
            this.groupBoxInData.Controls.Add(this.textBoxBorderA);
            this.groupBoxInData.Controls.Add(this.labelEps);
            this.groupBoxInData.Location = new System.Drawing.Point(25, 25);
            this.groupBoxInData.Name = "groupBoxInData";
            this.groupBoxInData.Size = new System.Drawing.Size(324, 130);
            this.groupBoxInData.TabIndex = 0;
            this.groupBoxInData.TabStop = false;
            this.groupBoxInData.Text = "Входные данные";
            // 
            // textBoxEps
            // 
            this.textBoxEps.Location = new System.Drawing.Point(150, 90);
            this.textBoxEps.Name = "textBoxEps";
            this.textBoxEps.Size = new System.Drawing.Size(100, 26);
            this.textBoxEps.TabIndex = 7;
            // 
            // labelBorderA
            // 
            this.labelBorderA.AutoSize = true;
            this.labelBorderA.Location = new System.Drawing.Point(30, 30);
            this.labelBorderA.Name = "labelBorderA";
            this.labelBorderA.Size = new System.Drawing.Size(87, 20);
            this.labelBorderA.TabIndex = 2;
            this.labelBorderA.Text = "Граница А";
            // 
            // textBoxBorderB
            // 
            this.textBoxBorderB.Location = new System.Drawing.Point(150, 60);
            this.textBoxBorderB.Name = "textBoxBorderB";
            this.textBoxBorderB.Size = new System.Drawing.Size(100, 26);
            this.textBoxBorderB.TabIndex = 6;
            // 
            // labelBorderB
            // 
            this.labelBorderB.AutoSize = true;
            this.labelBorderB.Location = new System.Drawing.Point(30, 60);
            this.labelBorderB.Name = "labelBorderB";
            this.labelBorderB.Size = new System.Drawing.Size(87, 20);
            this.labelBorderB.TabIndex = 3;
            this.labelBorderB.Text = "Граница B";
            // 
            // textBoxBorderA
            // 
            this.textBoxBorderA.Location = new System.Drawing.Point(150, 30);
            this.textBoxBorderA.Name = "textBoxBorderA";
            this.textBoxBorderA.Size = new System.Drawing.Size(100, 26);
            this.textBoxBorderA.TabIndex = 5;
            // 
            // labelEps
            // 
            this.labelEps.AutoSize = true;
            this.labelEps.Location = new System.Drawing.Point(30, 90);
            this.labelEps.Name = "labelEps";
            this.labelEps.Size = new System.Drawing.Size(112, 20);
            this.labelEps.TabIndex = 4;
            this.labelEps.Text = "Погрешность";
            // 
            // groupBoxChangeFoo
            // 
            this.groupBoxChangeFoo.Controls.Add(this.radioButtonFoo2);
            this.groupBoxChangeFoo.Controls.Add(this.radioButtonFoo1);
            this.groupBoxChangeFoo.Location = new System.Drawing.Point(380, 25);
            this.groupBoxChangeFoo.Name = "groupBoxChangeFoo";
            this.groupBoxChangeFoo.Size = new System.Drawing.Size(300, 130);
            this.groupBoxChangeFoo.TabIndex = 1;
            this.groupBoxChangeFoo.TabStop = false;
            this.groupBoxChangeFoo.Text = "Выбор функции";
            // 
            // radioButtonFoo2
            // 
            this.radioButtonFoo2.AutoSize = true;
            this.radioButtonFoo2.Location = new System.Drawing.Point(65, 91);
            this.radioButtonFoo2.Name = "radioButtonFoo2";
            this.radioButtonFoo2.Size = new System.Drawing.Size(178, 24);
            this.radioButtonFoo2.TabIndex = 1;
            this.radioButtonFoo2.Text = "x^3 + 3x^2 - x + 1 = 0";
            this.radioButtonFoo2.UseVisualStyleBackColor = true;
            this.radioButtonFoo2.CheckedChanged += new System.EventHandler(this.RadioButtonFoo2_CheckedChanged);
            // 
            // radioButtonFoo1
            // 
            this.radioButtonFoo1.AutoSize = true;
            this.radioButtonFoo1.Checked = true;
            this.radioButtonFoo1.Location = new System.Drawing.Point(65, 60);
            this.radioButtonFoo1.Name = "radioButtonFoo1";
            this.radioButtonFoo1.Size = new System.Drawing.Size(138, 24);
            this.radioButtonFoo1.TabIndex = 0;
            this.radioButtonFoo1.TabStop = true;
            this.radioButtonFoo1.Text = "e^x + 2x - 4 = 0";
            this.radioButtonFoo1.UseVisualStyleBackColor = true;
            this.radioButtonFoo1.CheckedChanged += new System.EventHandler(this.RadioButtonFoo1_CheckedChanged);
            // 
            // buttonNewton
            // 
            this.buttonNewton.Location = new System.Drawing.Point(25, 161);
            this.buttonNewton.Name = "buttonNewton";
            this.buttonNewton.Size = new System.Drawing.Size(153, 46);
            this.buttonNewton.TabIndex = 2;
            this.buttonNewton.Text = "Метод Ньютона";
            this.buttonNewton.UseVisualStyleBackColor = true;
            this.buttonNewton.Click += new System.EventHandler(this.ButtonNewton_Click);
            // 
            // buttonDichtomy
            // 
            this.buttonDichtomy.Location = new System.Drawing.Point(194, 161);
            this.buttonDichtomy.Name = "buttonDichtomy";
            this.buttonDichtomy.Size = new System.Drawing.Size(155, 46);
            this.buttonDichtomy.TabIndex = 3;
            this.buttonDichtomy.Text = "Метод Дихтомии";
            this.buttonDichtomy.UseVisualStyleBackColor = true;
            this.buttonDichtomy.Click += new System.EventHandler(this.ButtonDichtomy_Click);
            // 
            // labelResult
            // 
            this.labelResult.AutoSize = true;
            this.labelResult.Location = new System.Drawing.Point(421, 174);
            this.labelResult.Name = "labelResult";
            this.labelResult.Size = new System.Drawing.Size(89, 20);
            this.labelResult.TabIndex = 4;
            this.labelResult.Text = "Результат";
            // 
            // textBoxResult
            // 
            this.textBoxResult.Location = new System.Drawing.Point(521, 174);
            this.textBoxResult.Name = "textBoxResult";
            this.textBoxResult.ReadOnly = true;
            this.textBoxResult.Size = new System.Drawing.Size(100, 26);
            this.textBoxResult.TabIndex = 5;
            // 
            // chartFoo
            // 
            chartArea1.Name = "ChartArea1";
            this.chartFoo.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chartFoo.Legends.Add(legend1);
            this.chartFoo.Location = new System.Drawing.Point(50, 230);
            this.chartFoo.Name = "chartFoo";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series1.Legend = "Legend1";
            series1.Name = "График";
            this.chartFoo.Series.Add(series1);
            this.chartFoo.Size = new System.Drawing.Size(592, 267);
            this.chartFoo.TabIndex = 6;
            this.chartFoo.Text = "chart1";
            // 
            // Calc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(703, 544);
            this.Controls.Add(this.chartFoo);
            this.Controls.Add(this.textBoxResult);
            this.Controls.Add(this.labelResult);
            this.Controls.Add(this.buttonDichtomy);
            this.Controls.Add(this.buttonNewton);
            this.Controls.Add(this.groupBoxChangeFoo);
            this.Controls.Add(this.groupBoxInData);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "Calc";
            this.Text = "Calc";
            this.groupBoxInData.ResumeLayout(false);
            this.groupBoxInData.PerformLayout();
            this.groupBoxChangeFoo.ResumeLayout(false);
            this.groupBoxChangeFoo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartFoo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxInData;
        private System.Windows.Forms.GroupBox groupBoxChangeFoo;
        private System.Windows.Forms.Label labelBorderA;
        private System.Windows.Forms.Label labelBorderB;
        private System.Windows.Forms.Label labelEps;
        private System.Windows.Forms.TextBox textBoxBorderA;
        private System.Windows.Forms.TextBox textBoxBorderB;
        private System.Windows.Forms.TextBox textBoxEps;
        private System.Windows.Forms.RadioButton radioButtonFoo2;
        private System.Windows.Forms.RadioButton radioButtonFoo1;
        private System.Windows.Forms.Button buttonNewton;
        private System.Windows.Forms.Button buttonDichtomy;
        private System.Windows.Forms.Label labelResult;
        private System.Windows.Forms.TextBox textBoxResult;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartFoo;
    }
}

