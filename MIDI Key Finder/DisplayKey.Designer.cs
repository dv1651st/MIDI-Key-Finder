namespace MIDI_Key_Finder
{
    partial class DisplayKey
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.mainResultsPanel = new System.Windows.Forms.TableLayoutPanel();
            this.secondPlaceLabel = new System.Windows.Forms.Label();
            this.thirdPlaceLabel = new System.Windows.Forms.Label();
            this.firstPlaceLabel = new System.Windows.Forms.Label();
            this.mainResultsPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainResultsPanel
            // 
            this.mainResultsPanel.AllowDrop = true;
            this.mainResultsPanel.ColumnCount = 1;
            this.mainResultsPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.mainResultsPanel.Controls.Add(this.secondPlaceLabel, 0, 1);
            this.mainResultsPanel.Controls.Add(this.thirdPlaceLabel, 0, 2);
            this.mainResultsPanel.Controls.Add(this.firstPlaceLabel, 0, 0);
            this.mainResultsPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainResultsPanel.Location = new System.Drawing.Point(0, 0);
            this.mainResultsPanel.Name = "mainResultsPanel";
            this.mainResultsPanel.RowCount = 3;
            this.mainResultsPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 48.59813F));
            this.mainResultsPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 28.03738F));
            this.mainResultsPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 23.13084F));
            this.mainResultsPanel.Size = new System.Drawing.Size(722, 428);
            this.mainResultsPanel.TabIndex = 0;
            this.mainResultsPanel.Click += new System.EventHandler(this.mainResultsPanel_Click);
            this.mainResultsPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.mainResultsPanel_Paint);
            // 
            // secondPlaceLabel
            // 
            this.secondPlaceLabel.AutoSize = true;
            this.secondPlaceLabel.Dock = System.Windows.Forms.DockStyle.Top;
            this.secondPlaceLabel.Font = new System.Drawing.Font("Consolas", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.secondPlaceLabel.ForeColor = System.Drawing.Color.Gray;
            this.secondPlaceLabel.Location = new System.Drawing.Point(3, 208);
            this.secondPlaceLabel.Name = "secondPlaceLabel";
            this.secondPlaceLabel.Size = new System.Drawing.Size(716, 75);
            this.secondPlaceLabel.TabIndex = 1;
            this.secondPlaceLabel.Text = "2nd Place";
            this.secondPlaceLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.secondPlaceLabel.Click += new System.EventHandler(this.secondPlaceLabel_Click);
            // 
            // thirdPlaceLabel
            // 
            this.thirdPlaceLabel.AutoSize = true;
            this.thirdPlaceLabel.Dock = System.Windows.Forms.DockStyle.Top;
            this.thirdPlaceLabel.Font = new System.Drawing.Font("Consolas", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.thirdPlaceLabel.ForeColor = System.Drawing.Color.Silver;
            this.thirdPlaceLabel.Location = new System.Drawing.Point(3, 328);
            this.thirdPlaceLabel.Name = "thirdPlaceLabel";
            this.thirdPlaceLabel.Size = new System.Drawing.Size(716, 47);
            this.thirdPlaceLabel.TabIndex = 2;
            this.thirdPlaceLabel.Text = "3rd Place";
            this.thirdPlaceLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.thirdPlaceLabel.Click += new System.EventHandler(this.thirdPlaceLabel_Click);
            // 
            // firstPlaceLabel
            // 
            this.firstPlaceLabel.AutoSize = true;
            this.firstPlaceLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.firstPlaceLabel.Font = new System.Drawing.Font("Consolas", 72F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.firstPlaceLabel.ForeColor = System.Drawing.Color.Maroon;
            this.firstPlaceLabel.Location = new System.Drawing.Point(3, 0);
            this.firstPlaceLabel.Name = "firstPlaceLabel";
            this.firstPlaceLabel.Size = new System.Drawing.Size(716, 208);
            this.firstPlaceLabel.TabIndex = 3;
            this.firstPlaceLabel.Text = "1st Place";
            this.firstPlaceLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.firstPlaceLabel.Click += new System.EventHandler(this.firstPlaceLabel_Click);
            // 
            // DisplayKey
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(722, 428);
            this.Controls.Add(this.mainResultsPanel);
            this.Name = "DisplayKey";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.DisplayKey_Load);
            this.mainResultsPanel.ResumeLayout(false);
            this.mainResultsPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel mainResultsPanel;
        private System.Windows.Forms.Label secondPlaceLabel;
        private System.Windows.Forms.Label thirdPlaceLabel;
        private System.Windows.Forms.Label firstPlaceLabel;
    }
}