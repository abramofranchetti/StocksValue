namespace StocksValue
{
    partial class WidgetForm
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WidgetForm));
            tableLayoutPanel = new TableLayoutPanel();
            flowLayoutPanel = new FlowLayoutPanel();
            contextMenuStrip = new ContextMenuStrip(components);
            aggiornaToolStripMenuItem = new ToolStripMenuItem();
            apriConfigurazioneToolStripMenuItem = new ToolStripMenuItem();
            spostaToolStripMenuItem = new ToolStripMenuItem();
            attivaDisattivaAlwaysOnTopToolStripMenuItem = new ToolStripMenuItem();
            chiudiToolStripMenuItem = new ToolStripMenuItem();
            tableLayoutPanel.SuspendLayout();
            contextMenuStrip.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel
            // 
            tableLayoutPanel.AutoSize = true;
            tableLayoutPanel.BackColor = Color.Transparent;
            tableLayoutPanel.ColumnCount = 1;
            tableLayoutPanel.ColumnStyles.Add(new ColumnStyle());
            tableLayoutPanel.Controls.Add(flowLayoutPanel, 0, 0);
            tableLayoutPanel.Dock = DockStyle.Fill;
            tableLayoutPanel.Location = new Point(0, 0);
            tableLayoutPanel.Margin = new Padding(0);
            tableLayoutPanel.Name = "tableLayoutPanel";
            tableLayoutPanel.RowCount = 1;
            tableLayoutPanel.RowStyles.Add(new RowStyle());
            tableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel.Size = new Size(154, 264);
            tableLayoutPanel.TabIndex = 0;
            // 
            // flowLayoutPanel
            // 
            flowLayoutPanel.AutoSize = true;
            flowLayoutPanel.BackColor = Color.Transparent;
            flowLayoutPanel.Dock = DockStyle.Fill;
            flowLayoutPanel.FlowDirection = FlowDirection.TopDown;
            flowLayoutPanel.Location = new Point(0, 0);
            flowLayoutPanel.Margin = new Padding(0);
            flowLayoutPanel.Name = "flowLayoutPanel";
            flowLayoutPanel.Size = new Size(154, 264);
            flowLayoutPanel.TabIndex = 1;
            // 
            // contextMenuStrip
            // 
            contextMenuStrip.Items.AddRange(new ToolStripItem[] { aggiornaToolStripMenuItem, apriConfigurazioneToolStripMenuItem, spostaToolStripMenuItem, attivaDisattivaAlwaysOnTopToolStripMenuItem, chiudiToolStripMenuItem });
            contextMenuStrip.Name = "contextMenuStrip";
            contextMenuStrip.Size = new Size(181, 114);
            // 
            // aggiornaToolStripMenuItem
            // 
            aggiornaToolStripMenuItem.Name = "aggiornaToolStripMenuItem";
            aggiornaToolStripMenuItem.Size = new Size(180, 22);
            aggiornaToolStripMenuItem.Text = "Aggiorna";
            aggiornaToolStripMenuItem.Click += aggiornaToolStripMenuItem_Click;
            // 
            // apriConfigurazioneToolStripMenuItem
            // 
            apriConfigurazioneToolStripMenuItem.Name = "apriConfigurazioneToolStripMenuItem";
            apriConfigurazioneToolStripMenuItem.Size = new Size(180, 22);
            apriConfigurazioneToolStripMenuItem.Text = "Apri Configurazione";
            apriConfigurazioneToolStripMenuItem.Click += apriConfigurazioneToolStripMenuItem_Click;
            // 
            // spostaToolStripMenuItem
            // 
            spostaToolStripMenuItem.Name = "spostaToolStripMenuItem";
            spostaToolStripMenuItem.Size = new Size(180, 22);
            spostaToolStripMenuItem.Text = "Sposta";
            spostaToolStripMenuItem.Click += spostaToolStripMenuItem_Click;
            // 
            // attivaDisattivaAlwaysOnTopToolStripMenuItem
            // 
            attivaDisattivaAlwaysOnTopToolStripMenuItem.Checked = true;
            attivaDisattivaAlwaysOnTopToolStripMenuItem.CheckState = CheckState.Checked;
            attivaDisattivaAlwaysOnTopToolStripMenuItem.Name = "attivaDisattivaAlwaysOnTopToolStripMenuItem";
            attivaDisattivaAlwaysOnTopToolStripMenuItem.Size = new Size(180, 22);
            attivaDisattivaAlwaysOnTopToolStripMenuItem.Text = "Always On Top";
            attivaDisattivaAlwaysOnTopToolStripMenuItem.Click += attivaDisattivaAlwaysOnTopToolStripMenuItem_Click;
            // 
            // chiudiToolStripMenuItem
            // 
            chiudiToolStripMenuItem.Name = "chiudiToolStripMenuItem";
            chiudiToolStripMenuItem.Size = new Size(180, 22);
            chiudiToolStripMenuItem.Text = "Chiudi";
            chiudiToolStripMenuItem.Click += chiudiToolStripMenuItem_Click;
            // 
            // WidgetForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            BackColor = Color.FromArgb(64, 64, 64);
            ClientSize = new Size(154, 264);
            ContextMenuStrip = contextMenuStrip;
            ControlBox = false;
            Controls.Add(tableLayoutPanel);
            ForeColor = Color.White;
            FormBorderStyle = FormBorderStyle.None;
            FormScreenCaptureMode = ScreenCaptureMode.HideWindow;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "WidgetForm";
            ShowInTaskbar = false;
            SizeGripStyle = SizeGripStyle.Hide;
            StartPosition = FormStartPosition.Manual;
            Text = "Stock Value";
            TopMost = true;
            tableLayoutPanel.ResumeLayout(false);
            tableLayoutPanel.PerformLayout();
            contextMenuStrip.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TableLayoutPanel tableLayoutPanel;
        private FlowLayoutPanel flowLayoutPanel;
        private ContextMenuStrip contextMenuStrip;
        private ToolStripMenuItem aggiornaToolStripMenuItem;
        private ToolStripMenuItem chiudiToolStripMenuItem;
        private ToolStripMenuItem apriConfigurazioneToolStripMenuItem;
        private ToolStripMenuItem spostaToolStripMenuItem;
        private ToolStripMenuItem attivaDisattivaAlwaysOnTopToolStripMenuItem;
    }
}
