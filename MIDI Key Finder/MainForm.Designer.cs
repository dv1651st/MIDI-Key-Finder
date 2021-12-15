
namespace MIDI_Key_Finder
{
    partial class MainForm
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
            this.buttonBrowseFiles = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panelOfParent = new System.Windows.Forms.Panel();
            this.mainLabel = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panelOfParent.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonBrowseFiles
            // 
            this.buttonBrowseFiles.AllowDrop = true;
            this.buttonBrowseFiles.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonBrowseFiles.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonBrowseFiles.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonBrowseFiles.Location = new System.Drawing.Point(316, 41);
            this.buttonBrowseFiles.Name = "buttonBrowseFiles";
            this.buttonBrowseFiles.Size = new System.Drawing.Size(150, 44);
            this.buttonBrowseFiles.TabIndex = 0;
            this.buttonBrowseFiles.Text = "Browse Files";
            this.buttonBrowseFiles.UseVisualStyleBackColor = true;
            this.buttonBrowseFiles.Click += new System.EventHandler(this.buttonBrowseFiles_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.buttonBrowseFiles);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 532);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(786, 132);
            this.panel1.TabIndex = 4;
            // 
            // panelOfParent
            // 
            this.panelOfParent.AllowDrop = true;
            this.panelOfParent.Controls.Add(this.mainLabel);
            this.panelOfParent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelOfParent.Location = new System.Drawing.Point(0, 0);
            this.panelOfParent.Name = "panelOfParent";
            this.panelOfParent.Size = new System.Drawing.Size(786, 532);
            this.panelOfParent.TabIndex = 5;
            this.panelOfParent.Paint += new System.Windows.Forms.PaintEventHandler(this.panelOfParent_Paint);
            // 
            // mainLabel
            // 
            this.mainLabel.AllowDrop = true;
            this.mainLabel.Font = new System.Drawing.Font("Consolas", 90F, System.Drawing.FontStyle.Bold);
            this.mainLabel.ForeColor = System.Drawing.Color.Silver;
            this.mainLabel.Location = new System.Drawing.Point(23, 22);
            this.mainLabel.Name = "mainLabel";
            this.mainLabel.Size = new System.Drawing.Size(762, 474);
            this.mainLabel.TabIndex = 0;
            this.mainLabel.Text = "Drag & Drop MIDI File here.";
            this.mainLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.mainLabel.UseMnemonic = false;
            // 
            // MainForm
            // 
            this.AcceptButton = this.buttonBrowseFiles;
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(786, 664);
            this.Controls.Add(this.panelOfParent);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "MainForm";
            this.Text = "MIDI Key Finder";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panelOfParent.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button buttonBrowseFiles;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panelOfParent;
        private System.Windows.Forms.Label mainLabel;
    }
}

