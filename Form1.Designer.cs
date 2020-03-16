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
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxFx = new System.Windows.Forms.TextBox();
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
            this.groupBoxInData.Location = new System.Drawing.Point(17, 16);
            this.groupBoxInData.Margin = new System.Windows.Forms.Padding(2);
            this.groupBoxInData.Name = "groupBoxInData";
            this.groupBoxInData.Padding = new System.Windows.Forms.Padding(2);
            this.groupBoxInData.Size = new System.Drawing.Size(216, 84);
            this.groupBoxInData.TabIndex = 0;
            this.groupBoxInData.TabStop = false;
            this.groupBoxInData.Text = "Входные данные";
            // 
            // textBoxEps
            // 
            this.textBoxEps.Location = new System.Drawing.Point(100, 58);
            this.textBoxEps.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxEps.Name = "textBoxEps";
            this.textBoxEps.Size = new System.Drawing.Size(68, 20);
            this.textBoxEps.TabIndex = 7;
            // 
            // labelBorderA
            // 
            this.labelBorderA.AutoSize = true;
            this.labelBorderA.Location = new System.Drawing.Point(20, 19);
            this.labelBorderA.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelBorderA.Name = "labelBorderA";
            this.labelBorderA.Size = new System.Drawing.Size(59, 13);
            this.labelBorderA.TabIndex = 2;
            this.labelBorderA.Text = "Граница А";
            // 
            // textBoxBorderB
            // 
            this.textBoxBorderB.Location = new System.Drawing.Point(100, 39);
            this.textBoxBorderB.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxBorderB.Name = "textBoxBorderB";
            this.textBoxBorderB.Size = new System.Drawing.Size(68, 20);
            this.textBoxBorderB.TabIndex = 6;
            // 
            // labelBorderB
            // 
            this.labelBorderB.AutoSize = true;
            this.labelBorderB.Location = new System.Drawing.Point(20, 39);
            this.labelBorderB.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelBorderB.Name = "labelBorderB";
            this.labelBorderB.Size = new System.Drawing.Size(59, 13);
            this.labelBorderB.TabIndex = 3;
            this.labelBorderB.Text = "Граница B";
            // 
            // textBoxBorderA
            // 
            this.textBoxBorderA.Location = new System.Drawing.Point(100, 19);
            this.textBoxBorderA.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxBorderA.Name = "textBoxBorderA";
            this.textBoxBorderA.Size = new System.Drawing.Size(68, 20);
            this.textBoxBorderA.TabIndex = 5;
            // 
            // labelEps
            // 
            this.labelEps.AutoSize = true;
            this.labelEps.Location = new System.Drawing.Point(20, 58);
            this.labelEps.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelEps.Name = "labelEps";
            this.labelEps.Size = new System.Drawing.Size(75, 13);
            this.labelEps.TabIndex = 4;
            this.labelEps.Text = "Погрешность";
            // 
            // groupBoxChangeFoo
            // 
            this.groupBoxChangeFoo.Controls.Add(this.radioButtonFoo2);
            this.groupBoxChangeFoo.Controls.Add(this.radioButtonFoo1);
            this.groupBoxChangeFoo.Location = new System.Drawing.Point(253, 16);
            this.groupBoxChangeFoo.Margin = new System.Windows.Forms.Padding(2);
            this.groupBoxChangeFoo.Name = "groupBoxChangeFoo";
            this.groupBoxChangeFoo.Padding = new System.Windows.Forms.Padding(2);
            this.groupBoxChangeFoo.Size = new System.Drawing.Size(200, 84);
            this.groupBoxChangeFoo.TabIndex = 1;
            this.groupBoxChangeFoo.TabStop = false;
            this.groupBoxChangeFoo.Text = "Выбор функции";
            // 
            // radioButtonFoo2
            // 
            this.radioButtonFoo2.AutoSize = true;
            this.radioButtonFoo2.Location = new System.Drawing.Point(43, 59);
            this.radioButtonFoo2.Margin = new System.Windows.Forms.Padding(2);
            this.radioButtonFoo2.Name = "radioButtonFoo2";
            this.radioButtonFoo2.Size = new System.Drawing.Size(124, 17);
            this.radioButtonFoo2.TabIndex = 1;
            this.radioButtonFoo2.Text = "2x^3 + x^2 - x - 2 = 0";
            this.radioButtonFoo2.UseVisualStyleBackColor = true;
            this.radioButtonFoo2.CheckedChanged += new System.EventHandler(this.RadioButtonFoo2_CheckedChanged);
            // 
            // radioButtonFoo1
            // 
            this.radioButtonFoo1.AutoSize = true;
            this.radioButtonFoo1.Checked = true;
            this.radioButtonFoo1.Location = new System.Drawing.Point(43, 39);
            this.radioButtonFoo1.Margin = new System.Windows.Forms.Padding(2);
            this.radioButtonFoo1.Name = "radioButtonFoo1";
            this.radioButtonFoo1.Size = new System.Drawing.Size(91, 17);
            this.radioButtonFoo1.TabIndex = 0;
            this.radioButtonFoo1.TabStop = true;
            this.radioButtonFoo1.Text = "lg(x) - x - 2 = 0";
            this.radioButtonFoo1.UseVisualStyleBackColor = true;
            this.radioButtonFoo1.CheckedChanged += new System.EventHandler(this.RadioButtonFoo1_CheckedChanged);
            // 
            // buttonNewton
            // 
            this.buttonNewton.Location = new System.Drawing.Point(17, 105);
            this.buttonNewton.Margin = new System.Windows.Forms.Padding(2);
            this.buttonNewton.Name = "buttonNewton";
            this.buttonNewton.Size = new System.Drawing.Size(102, 30);
            this.buttonNewton.TabIndex = 2;
            this.buttonNewton.Text = "Метод Ньютона";
            this.buttonNewton.UseVisualStyleBackColor = true;
            this.buttonNewton.Click += new System.EventHandler(this.ButtonNewton_Click);
            // 
            // buttonDichtomy
            // 
            this.buttonDichtomy.Location = new System.Drawing.Point(129, 105);
            this.buttonDichtomy.Margin = new System.Windows.Forms.Padding(2);
            this.buttonDichtomy.Name = "buttonDichtomy";
            this.buttonDichtomy.Size = new System.Drawing.Size(103, 30);
            this.buttonDichtomy.TabIndex = 3;
            this.buttonDichtomy.Text = "Метод Дихтомии";
            this.buttonDichtomy.UseVisualStyleBackColor = true;
            this.buttonDichtomy.Click += new System.EventHandler(this.ButtonDichtomy_Click);
            // 
            // labelResult
            // 
            this.labelResult.AutoSize = true;
            this.labelResult.Location = new System.Drawing.Point(284, 102);
            this.labelResult.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelResult.Name = "labelResult";
            this.labelResult.Size = new System.Drawing.Size(59, 13);
            this.labelResult.TabIndex = 4;
            this.labelResult.Text = "Результат";
            // 
            // textBoxResult
            // 
            this.textBoxResult.Location = new System.Drawing.Point(347, 99);
            this.textBoxResult.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxResult.Name = "textBoxResult";
            this.textBoxResult.ReadOnly = true;
            this.textBoxResult.Size = new System.Drawing.Size(68, 20);
            this.textBoxResult.TabIndex = 5;
            // 
            // chartFoo
            // 
            chartArea1.Name = "ChartArea1";
            this.chartFoo.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chartFoo.Legends.Add(legend1);
            this.chartFoo.Location = new System.Drawing.Point(33, 149);
            this.chartFoo.Margin = new System.Windows.Forms.Padding(2);
            this.chartFoo.Name = "chartFoo";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series1.Legend = "Legend1";
            series1.Name = "График";
            this.chartFoo.Series.Add(series1);
            this.chartFoo.Size = new System.Drawing.Size(395, 174);
            this.chartFoo.TabIndex = 6;
            this.chartFoo.Text = "chart1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(284, 134);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Невязка";
            // 
            // textBoxFx
            // 
            this.textBoxFx.Location = new System.Drawing.Point(347, 131);
            this.textBoxFx.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxFx.Name = "textBoxFx";
            this.textBoxFx.ReadOnly = true;
            this.textBoxFx.Size = new System.Drawing.Size(68, 20);
            this.textBoxFx.TabIndex = 8;
            // 
            // Calc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(469, 354);
            this.Controls.Add(this.textBoxFx);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.chartFoo);
            this.Controls.Add(this.textBoxResult);
            this.Controls.Add(this.labelResult);
            this.Controls.Add(this.buttonDichtomy);
            this.Controls.Add(this.buttonNewton);
            this.Controls.Add(this.groupBoxChangeFoo);
            this.Controls.Add(this.groupBoxInData);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(2);
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
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxFx;
    }
}

