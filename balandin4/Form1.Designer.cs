namespace balandin4
{
    partial class Form
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            A_GridView = new DataGridView();
            B_GridView = new DataGridView();
            N1_GridView = new DataGridView();
            N2_GridView = new DataGridView();
            N3_GridView = new DataGridView();
            MBox = new TextBox();
            NBox = new TextBox();
            label1 = new Label();
            label2 = new Label();
            CreateButton = new Button();
            CalculateButton = new Button();
            RandomButton = new Button();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            t0Box = new TextBox();
            label9 = new Label();
            TBox = new TextBox();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            Res_GridView = new DataGridView();
            chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)A_GridView).BeginInit();
            ((System.ComponentModel.ISupportInitialize)B_GridView).BeginInit();
            ((System.ComponentModel.ISupportInitialize)N1_GridView).BeginInit();
            ((System.ComponentModel.ISupportInitialize)N2_GridView).BeginInit();
            ((System.ComponentModel.ISupportInitialize)N3_GridView).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Res_GridView).BeginInit();
            ((System.ComponentModel.ISupportInitialize)chart1).BeginInit();
            SuspendLayout();
            // 
            // A_GridView
            // 
            A_GridView.AllowUserToAddRows = false;
            A_GridView.AllowUserToDeleteRows = false;
            A_GridView.AllowUserToResizeColumns = false;
            A_GridView.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.False;
            A_GridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            A_GridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            A_GridView.ColumnHeadersVisible = false;
            A_GridView.Location = new Point(12, 44);
            A_GridView.MultiSelect = false;
            A_GridView.Name = "A_GridView";
            A_GridView.RowHeadersVisible = false;
            A_GridView.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            A_GridView.RowTemplate.Height = 25;
            A_GridView.SelectionMode = DataGridViewSelectionMode.CellSelect;
            A_GridView.Size = new Size(150, 150);
            A_GridView.TabIndex = 0;
            A_GridView.TabStop = false;
            A_GridView.CellContentClick += dataGridView1_CellContentClick;
            // 
            // B_GridView
            // 
            B_GridView.AllowUserToAddRows = false;
            B_GridView.AllowUserToDeleteRows = false;
            B_GridView.AllowUserToResizeColumns = false;
            B_GridView.AllowUserToResizeRows = false;
            B_GridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            B_GridView.ColumnHeadersVisible = false;
            B_GridView.Location = new Point(168, 44);
            B_GridView.Name = "B_GridView";
            B_GridView.RowHeadersVisible = false;
            B_GridView.RowTemplate.Height = 25;
            B_GridView.Size = new Size(150, 150);
            B_GridView.TabIndex = 1;
            // 
            // N1_GridView
            // 
            N1_GridView.AllowUserToAddRows = false;
            N1_GridView.AllowUserToDeleteRows = false;
            N1_GridView.AllowUserToResizeColumns = false;
            N1_GridView.AllowUserToResizeRows = false;
            N1_GridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            N1_GridView.ColumnHeadersVisible = false;
            N1_GridView.Location = new Point(336, 44);
            N1_GridView.Name = "N1_GridView";
            N1_GridView.RowHeadersVisible = false;
            N1_GridView.RowTemplate.Height = 25;
            N1_GridView.Size = new Size(150, 150);
            N1_GridView.TabIndex = 2;
            // 
            // N2_GridView
            // 
            N2_GridView.AllowUserToAddRows = false;
            N2_GridView.AllowUserToDeleteRows = false;
            N2_GridView.AllowUserToResizeColumns = false;
            N2_GridView.AllowUserToResizeRows = false;
            N2_GridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            N2_GridView.ColumnHeadersVisible = false;
            N2_GridView.Location = new Point(492, 44);
            N2_GridView.Name = "N2_GridView";
            N2_GridView.RowHeadersVisible = false;
            N2_GridView.RowTemplate.Height = 25;
            N2_GridView.Size = new Size(150, 150);
            N2_GridView.TabIndex = 3;
            N2_GridView.CellContentClick += N2_GridView_CellContentClick;
            // 
            // N3_GridView
            // 
            N3_GridView.AllowUserToAddRows = false;
            N3_GridView.AllowUserToDeleteRows = false;
            N3_GridView.AllowUserToResizeColumns = false;
            N3_GridView.AllowUserToResizeRows = false;
            N3_GridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            N3_GridView.ColumnHeadersVisible = false;
            N3_GridView.Location = new Point(648, 44);
            N3_GridView.Name = "N3_GridView";
            N3_GridView.RowHeadersVisible = false;
            N3_GridView.RowTemplate.Height = 25;
            N3_GridView.Size = new Size(150, 150);
            N3_GridView.TabIndex = 4;
            N3_GridView.CellContentClick += dataGridView1_CellContentClick_1;
            // 
            // MBox
            // 
            MBox.CharacterCasing = CharacterCasing.Lower;
            MBox.Cursor = Cursors.Cross;
            MBox.Location = new Point(861, 110);
            MBox.Name = "MBox";
            MBox.Size = new Size(44, 23);
            MBox.TabIndex = 5;
            MBox.Text = "4";
            MBox.TextChanged += MBox_TextChanged;
            // 
            // NBox
            // 
            NBox.Location = new Point(861, 81);
            NBox.Name = "NBox";
            NBox.Size = new Size(44, 23);
            NBox.TabIndex = 6;
            NBox.Text = "3";
            NBox.TextChanged += textBox2_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(837, 82);
            label1.Name = "label1";
            label1.Size = new Size(22, 17);
            label1.TabIndex = 7;
            label1.Text = "N:";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(837, 111);
            label2.Name = "label2";
            label2.Size = new Size(24, 17);
            label2.TabIndex = 8;
            label2.Text = "M:";
            // 
            // CreateButton
            // 
            CreateButton.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            CreateButton.Location = new Point(924, 79);
            CreateButton.Name = "CreateButton";
            CreateButton.Size = new Size(75, 23);
            CreateButton.TabIndex = 9;
            CreateButton.Text = "create";
            CreateButton.UseVisualStyleBackColor = true;
            CreateButton.Click += button1_Click;
            // 
            // CalculateButton
            // 
            CalculateButton.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            CalculateButton.Location = new Point(924, 137);
            CalculateButton.Name = "CalculateButton";
            CalculateButton.Size = new Size(75, 23);
            CalculateButton.TabIndex = 10;
            CalculateButton.Text = "calculate";
            CalculateButton.UseVisualStyleBackColor = true;
            CalculateButton.Click += CalculateButton_Click;
            // 
            // RandomButton
            // 
            RandomButton.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            RandomButton.Location = new Point(924, 108);
            RandomButton.Name = "RandomButton";
            RandomButton.Size = new Size(75, 23);
            RandomButton.TabIndex = 11;
            RandomButton.Text = "random";
            RandomButton.UseVisualStyleBackColor = true;
            RandomButton.Click += button1_Click_1;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(77, 20);
            label3.Name = "label3";
            label3.Size = new Size(21, 21);
            label3.TabIndex = 12;
            label3.Text = "A";
            label3.Click += label3_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(227, 20);
            label4.Name = "label4";
            label4.Size = new Size(20, 21);
            label4.TabIndex = 13;
            label4.Text = "B";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(403, 20);
            label5.Name = "label5";
            label5.Size = new Size(32, 21);
            label5.TabIndex = 14;
            label5.Text = "N1";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(553, 20);
            label6.Name = "label6";
            label6.Size = new Size(32, 21);
            label6.TabIndex = 15;
            label6.Text = "N2";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label7.Location = new Point(711, 20);
            label7.Name = "label7";
            label7.Size = new Size(32, 21);
            label7.TabIndex = 16;
            label7.Text = "N3";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label8.Location = new Point(837, 153);
            label8.Name = "label8";
            label8.Size = new Size(24, 17);
            label8.TabIndex = 19;
            label8.Text = "t0:";
            label8.Click += label8_Click;
            // 
            // t0Box
            // 
            t0Box.CharacterCasing = CharacterCasing.Lower;
            t0Box.Cursor = Cursors.Cross;
            t0Box.Location = new Point(861, 152);
            t0Box.Name = "t0Box";
            t0Box.Size = new Size(44, 23);
            t0Box.TabIndex = 18;
            t0Box.Text = "0";
            t0Box.TextChanged += textBox1_TextChanged;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label9.Location = new Point(837, 182);
            label9.Name = "label9";
            label9.Size = new Size(20, 17);
            label9.TabIndex = 21;
            label9.Text = "T:";
            label9.Click += label9_Click;
            // 
            // TBox
            // 
            TBox.CharacterCasing = CharacterCasing.Lower;
            TBox.Cursor = Cursors.Cross;
            TBox.Location = new Point(861, 181);
            TBox.Name = "TBox";
            TBox.Size = new Size(44, 23);
            TBox.TabIndex = 20;
            TBox.Text = "6";
            TBox.TextChanged += textBox2_TextChanged_1;
            // 
            // Res_GridView
            // 
            Res_GridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            Res_GridView.Location = new Point(12, 210);
            Res_GridView.Name = "Res_GridView";
            Res_GridView.RowTemplate.Height = 25;
            Res_GridView.Size = new Size(461, 383);
            Res_GridView.TabIndex = 22;
            Res_GridView.CellContentClick += dataGridView1_CellContentClick_2;
            // 
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            chart1.Legends.Add(legend1);
            chart1.Location = new Point(479, 210);
            chart1.Name = "chart1";
            chart1.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Excel;
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            chart1.Series.Add(series1);
            chart1.Size = new Size(663, 383);
            chart1.TabIndex = 23;
            chart1.Text = "chart1";
            chart1.Click += chart1_Click;
            // 
            // Form
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1175, 634);
            Controls.Add(chart1);
            Controls.Add(Res_GridView);
            Controls.Add(label9);
            Controls.Add(TBox);
            Controls.Add(label8);
            Controls.Add(t0Box);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(RandomButton);
            Controls.Add(CalculateButton);
            Controls.Add(CreateButton);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(NBox);
            Controls.Add(MBox);
            Controls.Add(N3_GridView);
            Controls.Add(N2_GridView);
            Controls.Add(N1_GridView);
            Controls.Add(B_GridView);
            Controls.Add(A_GridView);
            Name = "Form";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)A_GridView).EndInit();
            ((System.ComponentModel.ISupportInitialize)B_GridView).EndInit();
            ((System.ComponentModel.ISupportInitialize)N1_GridView).EndInit();
            ((System.ComponentModel.ISupportInitialize)N2_GridView).EndInit();
            ((System.ComponentModel.ISupportInitialize)N3_GridView).EndInit();
            ((System.ComponentModel.ISupportInitialize)Res_GridView).EndInit();
            ((System.ComponentModel.ISupportInitialize)chart1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView A_GridView;
        private DataGridView B_GridView;
        private DataGridView N1_GridView;
        private DataGridView N2_GridView;
        private DataGridView N3_GridView;
        private TextBox MBox;
        private TextBox NBox;
        private Label label1;
        private Label label2;
        private Button CreateButton;
        private Button CalculateButton;
        private Button RandomButton;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private TextBox t0Box;
        private Label label9;
        private TextBox TBox;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private DataGridView Res_GridView;
        private System.CodeDom.CodeTypeReference MainChart;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
    }
}