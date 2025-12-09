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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            MainMenuStrip_MenuStrip = new MenuStrip();
            fileToolStripMenuItem = new ToolStripMenuItem();
            loadImageToolStripMenuItem = new ToolStripMenuItem();
            exitToolStripMenuItem = new ToolStripMenuItem();
            HistogramsPanel_Panel = new Panel();
            Histograms_TableLayoutPanel = new TableLayoutPanel();
            ChartRed_Chart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ChartGreen_Chart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ChartBlue_Chart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            CanvasPictureBox_PictureBox = new PictureBox();
            RightSide_SplitContainer = new SplitContainer();
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
            RightSide_SplitContainer.SuspendLayout();
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
            HistogramsPanel_Panel.Size = new Size(257, 522);
            HistogramsPanel_Panel.TabIndex = 2;
            // 
            // Histograms_TableLayoutPanel
            // 
            Histograms_TableLayoutPanel.AutoSize = false;
            Histograms_TableLayoutPanel.BackColor = SystemColors.ControlLightLight;
            Histograms_TableLayoutPanel.ColumnCount = 1;
            Histograms_TableLayoutPanel.ColumnStyles.Clear();
            Histograms_TableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100));
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
            Histograms_TableLayoutPanel.Size = new Size(257, 522);
            Histograms_TableLayoutPanel.TabIndex = 0;
            // 
            // ChartRed_Chart
            // 
            chartArea1.Name = "ChartArea1";
            ChartRed_Chart.MinimumSize = Size.Empty;
            ChartRed_Chart.ChartAreas.Add(chartArea1);
            ChartRed_Chart.Dock = DockStyle.Fill;
            ChartRed_Chart.Location = new Point(3, 3);
            ChartRed_Chart.Name = "ChartRed_Chart";
            ChartRed_Chart.TabIndex = 0;
            // 
            // ChartGreen_Chart
            // 
            chartArea2.Name = "ChartArea1";
            ChartGreen_Chart.MinimumSize = Size.Empty;
            ChartGreen_Chart.ChartAreas.Add(chartArea2);
            ChartGreen_Chart.Dock = DockStyle.Fill;
            ChartGreen_Chart.Location = new Point(3, 177);
            ChartGreen_Chart.Name = "ChartGreen_Chart";
            ChartGreen_Chart.TabIndex = 1;
            // 
            // ChartBlue_Chart
            // 
            chartArea3.Name = "ChartArea1";
            ChartBlue_Chart.MinimumSize = Size.Empty;
            ChartBlue_Chart.ChartAreas.Add(chartArea3);
            ChartBlue_Chart.Dock = DockStyle.Fill;
            ChartBlue_Chart.Location = new Point(3, 350);
            ChartBlue_Chart.Name = "ChartBlue_Chart";
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
            RightSide_SplitContainer.Panel2.RightToLeft = RightToLeft.No;
            RightSide_SplitContainer.Panel2MinSize = 0;
            RightSide_SplitContainer.RightToLeft = RightToLeft.No;
            RightSide_SplitContainer.Size = new Size(396, 522);
            RightSide_SplitContainer.SplitterDistance = 257;
            RightSide_SplitContainer.TabIndex = 0;
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
            ((System.ComponentModel.ISupportInitialize)RightSide_SplitContainer).EndInit();
            RightSide_SplitContainer.ResumeLayout(false);
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
    }
}
