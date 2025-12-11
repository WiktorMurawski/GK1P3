using System.Windows.Forms.DataVisualization.Charting;

namespace GK1P3
{
    partial class MainWindowForm
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
            ChartArea chartArea1 = new ChartArea();
            ChartArea chartArea2 = new ChartArea();
            ChartArea chartArea3 = new ChartArea();
            MainMenuStrip_MenuStrip = new MenuStrip();
            fileToolStripMenuItem = new ToolStripMenuItem();
            loadImageToolStripMenuItem = new ToolStripMenuItem();
            exitToolStripMenuItem = new ToolStripMenuItem();
            HistogramsPanel_Panel = new Panel();
            Histograms_TableLayoutPanel = new TableLayoutPanel();
            ChartRed_Chart = new Chart();
            ChartGreen_Chart = new Chart();
            ChartBlue_Chart = new Chart();
            CanvasPictureBox_PictureBox = new PictureBox();
            RightSide_SplitContainer = new SplitContainer();
            FunctionCurve_CurveEditorControl = new GK1P3.Controls.CurveEditorControl();
            FilterSelection_GroupBox = new GroupBox();
            CustomFunction_RadioButton = new RadioButton();
            Posterize_NumericUpDown = new NumericUpDown();
            Posterize_RadioButton = new RadioButton();
            Brightness_NumericUpDown = new NumericUpDown();
            Contrast_NumericUpDown = new NumericUpDown();
            Brightness_RadioButton = new RadioButton();
            Contrast_RadioButton = new RadioButton();
            Gamma_NumericUpDown = new NumericUpDown();
            Gamma_RadioButton = new RadioButton();
            Sepia_RadioButton = new RadioButton();
            Grayscale_RadioButton = new RadioButton();
            Invert_RadioButton = new RadioButton();
            None_RadioButton = new RadioButton();
            BrushSizeValue_Label = new Label();
            BrushSize_Label = new Label();
            BrushSize_TrackBar = new TrackBar();
            ApplyFilter_Button = new Button();
            MainContainer_SplitContainer = new SplitContainer();
            MainMenuStrip_MenuStrip.SuspendLayout();
            HistogramsPanel_Panel.SuspendLayout();
            Histograms_TableLayoutPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)ChartRed_Chart).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ChartGreen_Chart).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ChartBlue_Chart).BeginInit();
            ((System.ComponentModel.ISupportInitialize)CanvasPictureBox_PictureBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)RightSide_SplitContainer).BeginInit();
            RightSide_SplitContainer.Panel1.SuspendLayout();
            RightSide_SplitContainer.Panel2.SuspendLayout();
            RightSide_SplitContainer.SuspendLayout();
            FilterSelection_GroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)Posterize_NumericUpDown).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Brightness_NumericUpDown).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Contrast_NumericUpDown).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Gamma_NumericUpDown).BeginInit();
            ((System.ComponentModel.ISupportInitialize)BrushSize_TrackBar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)MainContainer_SplitContainer).BeginInit();
            MainContainer_SplitContainer.Panel1.SuspendLayout();
            MainContainer_SplitContainer.Panel2.SuspendLayout();
            MainContainer_SplitContainer.SuspendLayout();
            SuspendLayout();
            // 
            // MainMenuStrip_MenuStrip
            // 
            MainMenuStrip_MenuStrip.Items.AddRange(new ToolStripItem[] { fileToolStripMenuItem });
            MainMenuStrip_MenuStrip.Location = new Point(0, 0);
            MainMenuStrip_MenuStrip.Name = "MainMenuStrip_MenuStrip";
            MainMenuStrip_MenuStrip.Size = new Size(1184, 24);
            MainMenuStrip_MenuStrip.TabIndex = 0;
            MainMenuStrip_MenuStrip.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            fileToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { loadImageToolStripMenuItem, exitToolStripMenuItem });
            fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            fileToolStripMenuItem.Size = new Size(37, 20);
            fileToolStripMenuItem.Text = "File";
            // 
            // loadImageToolStripMenuItem
            // 
            loadImageToolStripMenuItem.Name = "loadImageToolStripMenuItem";
            loadImageToolStripMenuItem.Size = new Size(136, 22);
            loadImageToolStripMenuItem.Text = "Load image";
            loadImageToolStripMenuItem.Click += loadImageToolStripMenuItem_Click;
            // 
            // exitToolStripMenuItem
            // 
            exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            exitToolStripMenuItem.Size = new Size(136, 22);
            exitToolStripMenuItem.Text = "Exit";
            exitToolStripMenuItem.Click += exitToolStripMenuItem_Click;
            // 
            // HistogramsPanel_Panel
            // 
            HistogramsPanel_Panel.BackColor = SystemColors.Control;
            HistogramsPanel_Panel.Controls.Add(Histograms_TableLayoutPanel);
            HistogramsPanel_Panel.Dock = DockStyle.Fill;
            HistogramsPanel_Panel.Location = new Point(0, 0);
            HistogramsPanel_Panel.Name = "HistogramsPanel_Panel";
            HistogramsPanel_Panel.Size = new Size(300, 537);
            HistogramsPanel_Panel.TabIndex = 2;
            // 
            // Histograms_TableLayoutPanel
            // 
            Histograms_TableLayoutPanel.BackColor = SystemColors.ControlLightLight;
            Histograms_TableLayoutPanel.ColumnCount = 1;
            Histograms_TableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            Histograms_TableLayoutPanel.Controls.Add(ChartRed_Chart, 0, 0);
            Histograms_TableLayoutPanel.Controls.Add(ChartGreen_Chart, 0, 1);
            Histograms_TableLayoutPanel.Controls.Add(ChartBlue_Chart, 0, 2);
            Histograms_TableLayoutPanel.Dock = DockStyle.Fill;
            Histograms_TableLayoutPanel.GrowStyle = TableLayoutPanelGrowStyle.FixedSize;
            Histograms_TableLayoutPanel.Location = new Point(0, 0);
            Histograms_TableLayoutPanel.Name = "Histograms_TableLayoutPanel";
            Histograms_TableLayoutPanel.RowCount = 3;
            Histograms_TableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 33.33353F));
            Histograms_TableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3332329F));
            Histograms_TableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3332329F));
            Histograms_TableLayoutPanel.Size = new Size(300, 537);
            Histograms_TableLayoutPanel.TabIndex = 0;
            // 
            // ChartRed_Chart
            // 
            chartArea1.Name = "ChartArea1";
            ChartRed_Chart.ChartAreas.Add(chartArea1);
            ChartRed_Chart.Dock = DockStyle.Fill;
            ChartRed_Chart.Location = new Point(3, 3);
            ChartRed_Chart.Name = "ChartRed_Chart";
            ChartRed_Chart.Size = new Size(294, 173);
            ChartRed_Chart.TabIndex = 0;
            // 
            // ChartGreen_Chart
            // 
            chartArea2.Name = "ChartArea1";
            ChartGreen_Chart.ChartAreas.Add(chartArea2);
            ChartGreen_Chart.Dock = DockStyle.Fill;
            ChartGreen_Chart.Location = new Point(3, 182);
            ChartGreen_Chart.Name = "ChartGreen_Chart";
            ChartGreen_Chart.Size = new Size(294, 172);
            ChartGreen_Chart.TabIndex = 1;
            // 
            // ChartBlue_Chart
            // 
            chartArea3.Name = "ChartArea1";
            ChartBlue_Chart.ChartAreas.Add(chartArea3);
            ChartBlue_Chart.Dock = DockStyle.Fill;
            ChartBlue_Chart.Location = new Point(3, 360);
            ChartBlue_Chart.Name = "ChartBlue_Chart";
            ChartBlue_Chart.Size = new Size(294, 174);
            ChartBlue_Chart.TabIndex = 2;
            // 
            // CanvasPictureBox_PictureBox
            // 
            CanvasPictureBox_PictureBox.BackColor = Color.Transparent;
            CanvasPictureBox_PictureBox.Dock = DockStyle.Fill;
            CanvasPictureBox_PictureBox.Location = new Point(0, 0);
            CanvasPictureBox_PictureBox.Name = "CanvasPictureBox_PictureBox";
            CanvasPictureBox_PictureBox.Size = new Size(650, 537);
            CanvasPictureBox_PictureBox.TabIndex = 0;
            CanvasPictureBox_PictureBox.TabStop = false;
            CanvasPictureBox_PictureBox.Paint += CanvasPictureBox_PictureBox_Paint;
            CanvasPictureBox_PictureBox.MouseDown += CanvasPictureBox_PictureBox_MouseDown;
            CanvasPictureBox_PictureBox.MouseMove += CanvasPictureBox_PictureBox_MouseMove;
            CanvasPictureBox_PictureBox.MouseUp += CanvasPictureBox_PictureBox_MouseUp;
            // 
            // RightSide_SplitContainer
            // 
            RightSide_SplitContainer.Dock = DockStyle.Fill;
            RightSide_SplitContainer.Location = new Point(0, 0);
            RightSide_SplitContainer.MinimumSize = new Size(100, 100);
            RightSide_SplitContainer.Name = "RightSide_SplitContainer";
            // 
            // RightSide_SplitContainer.Panel1
            // 
            RightSide_SplitContainer.Panel1.BackColor = SystemColors.Control;
            RightSide_SplitContainer.Panel1.Controls.Add(HistogramsPanel_Panel);
            RightSide_SplitContainer.Panel1.RightToLeft = RightToLeft.No;
            RightSide_SplitContainer.Panel1MinSize = 0;
            // 
            // RightSide_SplitContainer.Panel2
            // 
            RightSide_SplitContainer.Panel2.Controls.Add(FunctionCurve_CurveEditorControl);
            RightSide_SplitContainer.Panel2.Controls.Add(FilterSelection_GroupBox);
            RightSide_SplitContainer.Panel2.Controls.Add(BrushSizeValue_Label);
            RightSide_SplitContainer.Panel2.Controls.Add(BrushSize_Label);
            RightSide_SplitContainer.Panel2.Controls.Add(BrushSize_TrackBar);
            RightSide_SplitContainer.Panel2.Controls.Add(ApplyFilter_Button);
            RightSide_SplitContainer.Panel2.RightToLeft = RightToLeft.No;
            RightSide_SplitContainer.Panel2MinSize = 0;
            RightSide_SplitContainer.RightToLeft = RightToLeft.No;
            RightSide_SplitContainer.Size = new Size(530, 537);
            RightSide_SplitContainer.SplitterDistance = 300;
            RightSide_SplitContainer.TabIndex = 0;
            // 
            // FunctionCurve_CurveEditorControl
            // 
            FunctionCurve_CurveEditorControl.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            FunctionCurve_CurveEditorControl.Location = new Point(-1, 343);
            FunctionCurve_CurveEditorControl.Margin = new Padding(0);
            FunctionCurve_CurveEditorControl.MinimumSize = new Size(50, 50);
            FunctionCurve_CurveEditorControl.Name = "FunctionCurve_CurveEditorControl";
            FunctionCurve_CurveEditorControl.Size = new Size(227, 194);
            FunctionCurve_CurveEditorControl.TabIndex = 5;
            FunctionCurve_CurveEditorControl.Text = "curveEditorControl1";
            // 
            // FilterSelection_GroupBox
            // 
            FilterSelection_GroupBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            FilterSelection_GroupBox.Controls.Add(CustomFunction_RadioButton);
            FilterSelection_GroupBox.Controls.Add(Posterize_NumericUpDown);
            FilterSelection_GroupBox.Controls.Add(Posterize_RadioButton);
            FilterSelection_GroupBox.Controls.Add(Brightness_NumericUpDown);
            FilterSelection_GroupBox.Controls.Add(Contrast_NumericUpDown);
            FilterSelection_GroupBox.Controls.Add(Brightness_RadioButton);
            FilterSelection_GroupBox.Controls.Add(Contrast_RadioButton);
            FilterSelection_GroupBox.Controls.Add(Gamma_NumericUpDown);
            FilterSelection_GroupBox.Controls.Add(Gamma_RadioButton);
            FilterSelection_GroupBox.Controls.Add(Sepia_RadioButton);
            FilterSelection_GroupBox.Controls.Add(Grayscale_RadioButton);
            FilterSelection_GroupBox.Controls.Add(Invert_RadioButton);
            FilterSelection_GroupBox.Controls.Add(None_RadioButton);
            FilterSelection_GroupBox.Location = new Point(3, 93);
            FilterSelection_GroupBox.Name = "FilterSelection_GroupBox";
            FilterSelection_GroupBox.Size = new Size(220, 247);
            FilterSelection_GroupBox.TabIndex = 4;
            FilterSelection_GroupBox.TabStop = false;
            FilterSelection_GroupBox.Text = "Selected Filter";
            // 
            // CustomFunction_RadioButton
            // 
            CustomFunction_RadioButton.AutoSize = true;
            CustomFunction_RadioButton.Location = new Point(5, 222);
            CustomFunction_RadioButton.Name = "CustomFunction_RadioButton";
            CustomFunction_RadioButton.Size = new Size(115, 19);
            CustomFunction_RadioButton.TabIndex = 13;
            CustomFunction_RadioButton.TabStop = true;
            CustomFunction_RadioButton.Text = "Custom function";
            CustomFunction_RadioButton.UseVisualStyleBackColor = true;
            CustomFunction_RadioButton.CheckedChanged += CustomFunction_RadioButton_CheckedChanged;
            // 
            // Posterize_NumericUpDown
            // 
            Posterize_NumericUpDown.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            Posterize_NumericUpDown.Location = new Point(170, 197);
            Posterize_NumericUpDown.Maximum = new decimal(new int[] { 256, 0, 0, 0 });
            Posterize_NumericUpDown.Minimum = new decimal(new int[] { 2, 0, 0, 0 });
            Posterize_NumericUpDown.Name = "Posterize_NumericUpDown";
            Posterize_NumericUpDown.Size = new Size(50, 23);
            Posterize_NumericUpDown.TabIndex = 13;
            Posterize_NumericUpDown.Value = new decimal(new int[] { 8, 0, 0, 0 });
            Posterize_NumericUpDown.ValueChanged += Posterize_NumericUpDown_ValueChanged;
            // 
            // Posterize_RadioButton
            // 
            Posterize_RadioButton.AutoSize = true;
            Posterize_RadioButton.Location = new Point(5, 197);
            Posterize_RadioButton.Name = "Posterize_RadioButton";
            Posterize_RadioButton.Size = new Size(72, 19);
            Posterize_RadioButton.TabIndex = 12;
            Posterize_RadioButton.TabStop = true;
            Posterize_RadioButton.Text = "Posterize";
            Posterize_RadioButton.UseVisualStyleBackColor = true;
            Posterize_RadioButton.CheckedChanged += Posterize_RadioButton_CheckedChanged;
            // 
            // Brightness_NumericUpDown
            // 
            Brightness_NumericUpDown.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            Brightness_NumericUpDown.DecimalPlaces = 2;
            Brightness_NumericUpDown.Increment = new decimal(new int[] { 1, 0, 0, 131072 });
            Brightness_NumericUpDown.Location = new Point(170, 172);
            Brightness_NumericUpDown.Maximum = new decimal(new int[] { 20, 0, 0, 65536 });
            Brightness_NumericUpDown.Name = "Brightness_NumericUpDown";
            Brightness_NumericUpDown.Size = new Size(50, 23);
            Brightness_NumericUpDown.TabIndex = 9;
            Brightness_NumericUpDown.Value = new decimal(new int[] { 10, 0, 0, 65536 });
            Brightness_NumericUpDown.ValueChanged += Brightness_NumericUpDown_ValueChanged;
            // 
            // Contrast_NumericUpDown
            // 
            Contrast_NumericUpDown.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            Contrast_NumericUpDown.DecimalPlaces = 2;
            Contrast_NumericUpDown.Increment = new decimal(new int[] { 1, 0, 0, 131072 });
            Contrast_NumericUpDown.Location = new Point(170, 147);
            Contrast_NumericUpDown.Maximum = new decimal(new int[] { 20, 0, 0, 65536 });
            Contrast_NumericUpDown.Minimum = new decimal(new int[] { 1, 0, 0, 131072 });
            Contrast_NumericUpDown.Name = "Contrast_NumericUpDown";
            Contrast_NumericUpDown.Size = new Size(50, 23);
            Contrast_NumericUpDown.TabIndex = 7;
            Contrast_NumericUpDown.Value = new decimal(new int[] { 10, 0, 0, 65536 });
            Contrast_NumericUpDown.ValueChanged += Contrast_NumericUpDown_ValueChanged;
            // 
            // Brightness_RadioButton
            // 
            Brightness_RadioButton.AutoSize = true;
            Brightness_RadioButton.Location = new Point(5, 172);
            Brightness_RadioButton.Name = "Brightness_RadioButton";
            Brightness_RadioButton.Size = new Size(80, 19);
            Brightness_RadioButton.TabIndex = 8;
            Brightness_RadioButton.TabStop = true;
            Brightness_RadioButton.Text = "Brightness";
            Brightness_RadioButton.UseVisualStyleBackColor = true;
            Brightness_RadioButton.CheckedChanged += Brightness_RadioButton_CheckedChanged;
            // 
            // Contrast_RadioButton
            // 
            Contrast_RadioButton.AutoSize = true;
            Contrast_RadioButton.Location = new Point(5, 147);
            Contrast_RadioButton.Name = "Contrast_RadioButton";
            Contrast_RadioButton.Size = new Size(70, 19);
            Contrast_RadioButton.TabIndex = 6;
            Contrast_RadioButton.TabStop = true;
            Contrast_RadioButton.Text = "Contrast";
            Contrast_RadioButton.UseVisualStyleBackColor = true;
            Contrast_RadioButton.CheckedChanged += Contrast_RadioButton_CheckedChanged;
            // 
            // Gamma_NumericUpDown
            // 
            Gamma_NumericUpDown.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            Gamma_NumericUpDown.DecimalPlaces = 2;
            Gamma_NumericUpDown.Increment = new decimal(new int[] { 1, 0, 0, 131072 });
            Gamma_NumericUpDown.Location = new Point(170, 122);
            Gamma_NumericUpDown.Maximum = new decimal(new int[] { 50, 0, 0, 65536 });
            Gamma_NumericUpDown.Minimum = new decimal(new int[] { 1, 0, 0, 131072 });
            Gamma_NumericUpDown.Name = "Gamma_NumericUpDown";
            Gamma_NumericUpDown.Size = new Size(50, 23);
            Gamma_NumericUpDown.TabIndex = 5;
            Gamma_NumericUpDown.Value = new decimal(new int[] { 10, 0, 0, 65536 });
            Gamma_NumericUpDown.ValueChanged += Gamma_NumericUpDown_ValueChanged;
            // 
            // Gamma_RadioButton
            // 
            Gamma_RadioButton.AutoSize = true;
            Gamma_RadioButton.Location = new Point(5, 122);
            Gamma_RadioButton.Name = "Gamma_RadioButton";
            Gamma_RadioButton.Size = new Size(67, 19);
            Gamma_RadioButton.TabIndex = 4;
            Gamma_RadioButton.TabStop = true;
            Gamma_RadioButton.Text = "Gamma";
            Gamma_RadioButton.UseVisualStyleBackColor = true;
            Gamma_RadioButton.CheckedChanged += Gamma_RadioButton_CheckedChanged;
            // 
            // Sepia_RadioButton
            // 
            Sepia_RadioButton.AutoSize = true;
            Sepia_RadioButton.Location = new Point(5, 97);
            Sepia_RadioButton.Name = "Sepia_RadioButton";
            Sepia_RadioButton.Size = new Size(53, 19);
            Sepia_RadioButton.TabIndex = 3;
            Sepia_RadioButton.TabStop = true;
            Sepia_RadioButton.Text = "Sepia";
            Sepia_RadioButton.UseVisualStyleBackColor = true;
            Sepia_RadioButton.CheckedChanged += Sepia_RadioButton_CheckedChanged;
            // 
            // Grayscale_RadioButton
            // 
            Grayscale_RadioButton.AutoSize = true;
            Grayscale_RadioButton.Location = new Point(5, 72);
            Grayscale_RadioButton.Name = "Grayscale_RadioButton";
            Grayscale_RadioButton.Size = new Size(75, 19);
            Grayscale_RadioButton.TabIndex = 2;
            Grayscale_RadioButton.TabStop = true;
            Grayscale_RadioButton.Text = "Grayscale";
            Grayscale_RadioButton.UseVisualStyleBackColor = true;
            Grayscale_RadioButton.CheckedChanged += Grayscale_RadioButton_CheckedChanged;
            // 
            // Invert_RadioButton
            // 
            Invert_RadioButton.AutoSize = true;
            Invert_RadioButton.Location = new Point(6, 47);
            Invert_RadioButton.Name = "Invert_RadioButton";
            Invert_RadioButton.Size = new Size(55, 19);
            Invert_RadioButton.TabIndex = 1;
            Invert_RadioButton.TabStop = true;
            Invert_RadioButton.Text = "Invert";
            Invert_RadioButton.UseVisualStyleBackColor = true;
            Invert_RadioButton.CheckedChanged += Invert_RadioButton_CheckedChanged;
            // 
            // None_RadioButton
            // 
            None_RadioButton.AutoSize = true;
            None_RadioButton.Checked = true;
            None_RadioButton.Location = new Point(6, 22);
            None_RadioButton.Name = "None_RadioButton";
            None_RadioButton.Size = new Size(54, 19);
            None_RadioButton.TabIndex = 0;
            None_RadioButton.TabStop = true;
            None_RadioButton.Text = "None";
            None_RadioButton.UseVisualStyleBackColor = true;
            None_RadioButton.CheckedChanged += None_RadioButton_CheckedChanged;
            // 
            // BrushSizeValue_Label
            // 
            BrushSizeValue_Label.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            BrushSizeValue_Label.AutoSize = true;
            BrushSizeValue_Label.Location = new Point(204, 39);
            BrushSizeValue_Label.Name = "BrushSizeValue_Label";
            BrushSizeValue_Label.RightToLeft = RightToLeft.No;
            BrushSizeValue_Label.Size = new Size(13, 15);
            BrushSizeValue_Label.TabIndex = 3;
            BrushSizeValue_Label.Text = "1";
            // 
            // BrushSize_Label
            // 
            BrushSize_Label.AutoSize = true;
            BrushSize_Label.Location = new Point(3, 39);
            BrushSize_Label.Name = "BrushSize_Label";
            BrushSize_Label.Size = new Size(60, 15);
            BrushSize_Label.TabIndex = 2;
            BrushSize_Label.Text = "Brush Size";
            // 
            // BrushSize_TrackBar
            // 
            BrushSize_TrackBar.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            BrushSize_TrackBar.Location = new Point(3, 57);
            BrushSize_TrackBar.Maximum = 50;
            BrushSize_TrackBar.Minimum = 1;
            BrushSize_TrackBar.Name = "BrushSize_TrackBar";
            BrushSize_TrackBar.Size = new Size(220, 45);
            BrushSize_TrackBar.TabIndex = 1;
            BrushSize_TrackBar.Value = 1;
            BrushSize_TrackBar.Scroll += BrushSize_TrackBar_Scroll;
            // 
            // ApplyFilter_Button
            // 
            ApplyFilter_Button.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            ApplyFilter_Button.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            ApplyFilter_Button.Location = new Point(3, 3);
            ApplyFilter_Button.Name = "ApplyFilter_Button";
            ApplyFilter_Button.Size = new Size(220, 30);
            ApplyFilter_Button.TabIndex = 0;
            ApplyFilter_Button.Text = "Apply filter to image";
            ApplyFilter_Button.UseVisualStyleBackColor = true;
            ApplyFilter_Button.Click += ApplyFilter_Button_Click;
            // 
            // MainContainer_SplitContainer
            // 
            MainContainer_SplitContainer.Dock = DockStyle.Fill;
            MainContainer_SplitContainer.FixedPanel = FixedPanel.Panel2;
            MainContainer_SplitContainer.Location = new Point(0, 24);
            MainContainer_SplitContainer.Name = "MainContainer_SplitContainer";
            // 
            // MainContainer_SplitContainer.Panel1
            // 
            MainContainer_SplitContainer.Panel1.Controls.Add(CanvasPictureBox_PictureBox);
            // 
            // MainContainer_SplitContainer.Panel2
            // 
            MainContainer_SplitContainer.Panel2.Controls.Add(RightSide_SplitContainer);
            MainContainer_SplitContainer.Size = new Size(1184, 537);
            MainContainer_SplitContainer.SplitterDistance = 650;
            MainContainer_SplitContainer.TabIndex = 1;
            // 
            // MainWindowForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1184, 561);
            Controls.Add(MainContainer_SplitContainer);
            Controls.Add(MainMenuStrip_MenuStrip);
            Name = "MainWindowForm";
            Text = "GK1P3";
            MainMenuStrip_MenuStrip.ResumeLayout(false);
            MainMenuStrip_MenuStrip.PerformLayout();
            HistogramsPanel_Panel.ResumeLayout(false);
            Histograms_TableLayoutPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)ChartRed_Chart).EndInit();
            ((System.ComponentModel.ISupportInitialize)ChartGreen_Chart).EndInit();
            ((System.ComponentModel.ISupportInitialize)ChartBlue_Chart).EndInit();
            ((System.ComponentModel.ISupportInitialize)CanvasPictureBox_PictureBox).EndInit();
            RightSide_SplitContainer.Panel1.ResumeLayout(false);
            RightSide_SplitContainer.Panel2.ResumeLayout(false);
            RightSide_SplitContainer.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)RightSide_SplitContainer).EndInit();
            RightSide_SplitContainer.ResumeLayout(false);
            FilterSelection_GroupBox.ResumeLayout(false);
            FilterSelection_GroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)Posterize_NumericUpDown).EndInit();
            ((System.ComponentModel.ISupportInitialize)Brightness_NumericUpDown).EndInit();
            ((System.ComponentModel.ISupportInitialize)Contrast_NumericUpDown).EndInit();
            ((System.ComponentModel.ISupportInitialize)Gamma_NumericUpDown).EndInit();
            ((System.ComponentModel.ISupportInitialize)BrushSize_TrackBar).EndInit();
            MainContainer_SplitContainer.Panel1.ResumeLayout(false);
            MainContainer_SplitContainer.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)MainContainer_SplitContainer).EndInit();
            MainContainer_SplitContainer.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Panel HistogramsPanel_Panel;
        private MenuStrip MainMenuStrip_MenuStrip;
        private ToolStripMenuItem fileToolStripMenuItem;
        private ToolStripMenuItem loadImageToolStripMenuItem;
        private ToolStripMenuItem exitToolStripMenuItem;
        private PictureBox CanvasPictureBox_PictureBox;
        private TableLayoutPanel Histograms_TableLayoutPanel;
        private System.Windows.Forms.DataVisualization.Charting.Chart ChartRed_Chart;
        private System.Windows.Forms.DataVisualization.Charting.Chart ChartGreen_Chart;
        private System.Windows.Forms.DataVisualization.Charting.Chart ChartBlue_Chart;
        private SplitContainer RightSide_SplitContainer;
        private SplitContainer MainContainer_SplitContainer;
        private Button ApplyFilter_Button;
        private Label BrushSize_Label;
        private TrackBar BrushSize_TrackBar;
        private Label BrushSizeValue_Label;
        private GroupBox FilterSelection_GroupBox;
        private RadioButton None_RadioButton;
        private RadioButton Grayscale_RadioButton;
        private RadioButton Invert_RadioButton;
        private RadioButton Sepia_RadioButton;
        private NumericUpDown Gamma_NumericUpDown;
        private RadioButton Gamma_RadioButton;
        private NumericUpDown Contrast_NumericUpDown;
        private RadioButton Contrast_RadioButton;
        private NumericUpDown Brightness_NumericUpDown;
        private RadioButton Brightness_RadioButton;
        private NumericUpDown Posterize_NumericUpDown;
        private RadioButton Posterize_RadioButton;
        private RadioButton CustomFunction_RadioButton;
        private Controls.CurveEditorControl FunctionCurve_CurveEditorControl;
    }
}
