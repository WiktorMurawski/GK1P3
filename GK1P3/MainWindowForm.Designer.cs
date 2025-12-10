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
            ChartArea chartArea4 = new ChartArea();
            ChartArea chartArea5 = new ChartArea();
            ChartArea chartArea6 = new ChartArea();
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
            FilterSelection_GroupBox = new GroupBox();
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
            MainMenuStrip_MenuStrip.Size = new Size(937, 24);
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
            HistogramsPanel_Panel.Size = new Size(200, 522);
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
            Histograms_TableLayoutPanel.Size = new Size(200, 522);
            Histograms_TableLayoutPanel.TabIndex = 0;
            // 
            // ChartRed_Chart
            // 
            chartArea4.Name = "ChartArea1";
            ChartRed_Chart.ChartAreas.Add(chartArea4);
            ChartRed_Chart.Dock = DockStyle.Fill;
            ChartRed_Chart.Location = new Point(3, 3);
            ChartRed_Chart.Name = "ChartRed_Chart";
            ChartRed_Chart.Size = new Size(194, 168);
            ChartRed_Chart.TabIndex = 0;
            // 
            // ChartGreen_Chart
            // 
            chartArea5.Name = "ChartArea1";
            ChartGreen_Chart.ChartAreas.Add(chartArea5);
            ChartGreen_Chart.Dock = DockStyle.Fill;
            ChartGreen_Chart.Location = new Point(3, 177);
            ChartGreen_Chart.Name = "ChartGreen_Chart";
            ChartGreen_Chart.Size = new Size(194, 167);
            ChartGreen_Chart.TabIndex = 1;
            // 
            // ChartBlue_Chart
            // 
            chartArea6.Name = "ChartArea1";
            ChartBlue_Chart.ChartAreas.Add(chartArea6);
            ChartBlue_Chart.Dock = DockStyle.Fill;
            ChartBlue_Chart.Location = new Point(3, 350);
            ChartBlue_Chart.Name = "ChartBlue_Chart";
            ChartBlue_Chart.Size = new Size(194, 169);
            ChartBlue_Chart.TabIndex = 2;
            // 
            // CanvasPictureBox_PictureBox
            // 
            CanvasPictureBox_PictureBox.BackColor = Color.Transparent;
            CanvasPictureBox_PictureBox.Dock = DockStyle.Fill;
            CanvasPictureBox_PictureBox.Location = new Point(0, 0);
            CanvasPictureBox_PictureBox.Name = "CanvasPictureBox_PictureBox";
            CanvasPictureBox_PictureBox.Size = new Size(537, 522);
            CanvasPictureBox_PictureBox.TabIndex = 0;
            CanvasPictureBox_PictureBox.TabStop = false;
            // 
            // RightSide_SplitContainer
            // 
            RightSide_SplitContainer.Dock = DockStyle.Fill;
            RightSide_SplitContainer.Location = new Point(0, 0);
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
            RightSide_SplitContainer.Panel2.Controls.Add(FilterSelection_GroupBox);
            RightSide_SplitContainer.Panel2.Controls.Add(BrushSizeValue_Label);
            RightSide_SplitContainer.Panel2.Controls.Add(BrushSize_Label);
            RightSide_SplitContainer.Panel2.Controls.Add(BrushSize_TrackBar);
            RightSide_SplitContainer.Panel2.Controls.Add(ApplyFilter_Button);
            RightSide_SplitContainer.Panel2.RightToLeft = RightToLeft.No;
            RightSide_SplitContainer.Panel2MinSize = 0;
            RightSide_SplitContainer.RightToLeft = RightToLeft.No;
            RightSide_SplitContainer.Size = new Size(396, 522);
            RightSide_SplitContainer.SplitterDistance = 200;
            RightSide_SplitContainer.TabIndex = 0;
            // 
            // FilterSelection_GroupBox
            // 
            FilterSelection_GroupBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            FilterSelection_GroupBox.Controls.Add(Grayscale_RadioButton);
            FilterSelection_GroupBox.Controls.Add(Invert_RadioButton);
            FilterSelection_GroupBox.Controls.Add(None_RadioButton);
            FilterSelection_GroupBox.Location = new Point(3, 125);
            FilterSelection_GroupBox.Name = "FilterSelection_GroupBox";
            FilterSelection_GroupBox.Size = new Size(186, 145);
            FilterSelection_GroupBox.TabIndex = 4;
            FilterSelection_GroupBox.TabStop = false;
            FilterSelection_GroupBox.Text = "Selected Filter";
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
            BrushSizeValue_Label.Location = new Point(170, 56);
            BrushSizeValue_Label.Name = "BrushSizeValue_Label";
            BrushSizeValue_Label.RightToLeft = RightToLeft.No;
            BrushSizeValue_Label.Size = new Size(13, 15);
            BrushSizeValue_Label.TabIndex = 3;
            BrushSizeValue_Label.Text = "1";
            // 
            // BrushSize_Label
            // 
            BrushSize_Label.AutoSize = true;
            BrushSize_Label.Location = new Point(3, 56);
            BrushSize_Label.Name = "BrushSize_Label";
            BrushSize_Label.Size = new Size(60, 15);
            BrushSize_Label.TabIndex = 2;
            BrushSize_Label.Text = "Brush Size";
            // 
            // BrushSize_TrackBar
            // 
            BrushSize_TrackBar.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            BrushSize_TrackBar.Location = new Point(3, 74);
            BrushSize_TrackBar.Maximum = 30;
            BrushSize_TrackBar.Minimum = 1;
            BrushSize_TrackBar.Name = "BrushSize_TrackBar";
            BrushSize_TrackBar.Size = new Size(186, 45);
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
            ApplyFilter_Button.Size = new Size(186, 35);
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
            MainContainer_SplitContainer.Size = new Size(937, 522);
            MainContainer_SplitContainer.SplitterDistance = 537;
            MainContainer_SplitContainer.TabIndex = 1;
            // 
            // MainWindowForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(937, 546);
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
    }
}
