namespace PathAlgorithms
{
    partial class Form1
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
            this.upPanel = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.pathCount = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.endLISTy = new System.Windows.Forms.ListBox();
            this.endLISTx = new System.Windows.Forms.ListBox();
            this.startLISTy = new System.Windows.Forms.ListBox();
            this.startLISTx = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txts = new System.Windows.Forms.Label();
            this.TXT = new System.Windows.Forms.Label();
            this.select = new System.Windows.Forms.Button();
            this.clear = new System.Windows.Forms.Button();
            this.closeButton = new System.Windows.Forms.Button();
            this.runBFS = new System.Windows.Forms.Button();
            this.runDFS = new System.Windows.Forms.Button();
            this.board = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column13 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column14 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column15 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column16 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column20 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column17 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column18 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column19 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.runAstar = new System.Windows.Forms.Button();
            this.upPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.board)).BeginInit();
            this.SuspendLayout();
            // 
            // upPanel
            // 
            this.upPanel.BackColor = System.Drawing.SystemColors.InfoText;
            this.upPanel.Controls.Add(this.runAstar);
            this.upPanel.Controls.Add(this.label5);
            this.upPanel.Controls.Add(this.label6);
            this.upPanel.Controls.Add(this.label4);
            this.upPanel.Controls.Add(this.label3);
            this.upPanel.Controls.Add(this.pathCount);
            this.upPanel.Controls.Add(this.button1);
            this.upPanel.Controls.Add(this.label2);
            this.upPanel.Controls.Add(this.endLISTy);
            this.upPanel.Controls.Add(this.endLISTx);
            this.upPanel.Controls.Add(this.startLISTy);
            this.upPanel.Controls.Add(this.startLISTx);
            this.upPanel.Controls.Add(this.label1);
            this.upPanel.Controls.Add(this.txts);
            this.upPanel.Controls.Add(this.TXT);
            this.upPanel.Controls.Add(this.select);
            this.upPanel.Controls.Add(this.clear);
            this.upPanel.Controls.Add(this.closeButton);
            this.upPanel.Controls.Add(this.runBFS);
            this.upPanel.Controls.Add(this.runDFS);
            this.upPanel.Location = new System.Drawing.Point(861, 1);
            this.upPanel.Name = "upPanel";
            this.upPanel.Size = new System.Drawing.Size(215, 699);
            this.upPanel.TabIndex = 0;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.Orange;
            this.label5.Location = new System.Drawing.Point(174, 545);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(15, 17);
            this.label5.TabIndex = 25;
            this.label5.Text = "y";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.Orange;
            this.label6.Location = new System.Drawing.Point(118, 545);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(14, 17);
            this.label6.TabIndex = 24;
            this.label6.Text = "x";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.Orange;
            this.label4.Location = new System.Drawing.Point(174, 476);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(15, 17);
            this.label4.TabIndex = 23;
            this.label4.Text = "y";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.Orange;
            this.label3.Location = new System.Drawing.Point(118, 476);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(14, 17);
            this.label3.TabIndex = 22;
            this.label3.Text = "x";
            this.label3.Click += new System.EventHandler(this.Label3_Click);
            // 
            // pathCount
            // 
            this.pathCount.BackColor = System.Drawing.Color.Black;
            this.pathCount.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.pathCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.pathCount.ForeColor = System.Drawing.Color.DarkGreen;
            this.pathCount.Location = new System.Drawing.Point(18, 656);
            this.pathCount.Name = "pathCount";
            this.pathCount.Size = new System.Drawing.Size(173, 23);
            this.pathCount.TabIndex = 21;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Black;
            this.button1.FlatAppearance.BorderSize = 3;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button1.ForeColor = System.Drawing.Color.Orange;
            this.button1.Location = new System.Drawing.Point(16, 613);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(173, 37);
            this.button1.TabIndex = 20;
            this.button1.Text = "select";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.ForeColor = System.Drawing.Color.Orange;
            this.label2.Location = new System.Drawing.Point(3, 441);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(186, 24);
            this.label2.TabIndex = 19;
            this.label2.Text = "Select Coordinates";
            // 
            // endLISTy
            // 
            this.endLISTy.BackColor = System.Drawing.Color.Black;
            this.endLISTy.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.endLISTy.ForeColor = System.Drawing.Color.Orange;
            this.endLISTy.FormattingEnabled = true;
            this.endLISTy.ItemHeight = 16;
            this.endLISTy.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20"});
            this.endLISTy.Location = new System.Drawing.Point(143, 565);
            this.endLISTy.Name = "endLISTy";
            this.endLISTy.Size = new System.Drawing.Size(46, 32);
            this.endLISTy.TabIndex = 18;
            // 
            // endLISTx
            // 
            this.endLISTx.BackColor = System.Drawing.Color.Black;
            this.endLISTx.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.endLISTx.ForeColor = System.Drawing.Color.Orange;
            this.endLISTx.FormattingEnabled = true;
            this.endLISTx.ItemHeight = 16;
            this.endLISTx.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19"});
            this.endLISTx.Location = new System.Drawing.Point(86, 565);
            this.endLISTx.Name = "endLISTx";
            this.endLISTx.Size = new System.Drawing.Size(46, 32);
            this.endLISTx.TabIndex = 17;
            // 
            // startLISTy
            // 
            this.startLISTy.BackColor = System.Drawing.Color.Black;
            this.startLISTy.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.startLISTy.ForeColor = System.Drawing.Color.Orange;
            this.startLISTy.FormattingEnabled = true;
            this.startLISTy.ItemHeight = 16;
            this.startLISTy.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20"});
            this.startLISTy.Location = new System.Drawing.Point(143, 496);
            this.startLISTy.Name = "startLISTy";
            this.startLISTy.Size = new System.Drawing.Size(46, 32);
            this.startLISTy.TabIndex = 16;
            // 
            // startLISTx
            // 
            this.startLISTx.BackColor = System.Drawing.Color.Black;
            this.startLISTx.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.startLISTx.ForeColor = System.Drawing.Color.Orange;
            this.startLISTx.FormattingEnabled = true;
            this.startLISTx.ItemHeight = 16;
            this.startLISTx.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19"});
            this.startLISTx.Location = new System.Drawing.Point(86, 496);
            this.startLISTx.Name = "startLISTx";
            this.startLISTx.Size = new System.Drawing.Size(46, 32);
            this.startLISTx.TabIndex = 15;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.ForeColor = System.Drawing.Color.Orange;
            this.label1.Location = new System.Drawing.Point(26, 565);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 20);
            this.label1.TabIndex = 14;
            this.label1.Text = "end:\r\n";
            // 
            // txts
            // 
            this.txts.AutoSize = true;
            this.txts.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txts.ForeColor = System.Drawing.Color.Orange;
            this.txts.Location = new System.Drawing.Point(26, 491);
            this.txts.Name = "txts";
            this.txts.Size = new System.Drawing.Size(54, 20);
            this.txts.TabIndex = 13;
            this.txts.Text = "start:";
            // 
            // TXT
            // 
            this.TXT.AutoSize = true;
            this.TXT.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.TXT.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.TXT.ForeColor = System.Drawing.Color.Orange;
            this.TXT.Location = new System.Drawing.Point(29, 189);
            this.TXT.Name = "TXT";
            this.TXT.Size = new System.Drawing.Size(160, 32);
            this.TXT.TabIndex = 5;
            this.TXT.Text = "Algorithms";
            // 
            // select
            // 
            this.select.BackColor = System.Drawing.Color.Black;
            this.select.FlatAppearance.BorderSize = 5;
            this.select.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.select.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.select.ForeColor = System.Drawing.Color.Red;
            this.select.Location = new System.Drawing.Point(0, 110);
            this.select.Name = "select";
            this.select.Size = new System.Drawing.Size(211, 61);
            this.select.TabIndex = 2;
            this.select.Text = "Build Wall";
            this.select.UseVisualStyleBackColor = false;
            this.select.Click += new System.EventHandler(this.Select_Click);
            // 
            // clear
            // 
            this.clear.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.clear.FlatAppearance.BorderSize = 5;
            this.clear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.clear.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.clear.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.clear.Location = new System.Drawing.Point(0, 43);
            this.clear.Name = "clear";
            this.clear.Size = new System.Drawing.Size(211, 61);
            this.clear.TabIndex = 4;
            this.clear.Text = "CLEAR";
            this.clear.UseVisualStyleBackColor = false;
            this.clear.Click += new System.EventHandler(this.Clear_Click);
            // 
            // closeButton
            // 
            this.closeButton.FlatAppearance.BorderSize = 0;
            this.closeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.closeButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.closeButton.ForeColor = System.Drawing.Color.Red;
            this.closeButton.Location = new System.Drawing.Point(168, 0);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(44, 45);
            this.closeButton.TabIndex = 0;
            this.closeButton.Text = "x";
            this.closeButton.UseVisualStyleBackColor = true;
            this.closeButton.Click += new System.EventHandler(this.CloseButton_Click);
            // 
            // runBFS
            // 
            this.runBFS.BackColor = System.Drawing.Color.Black;
            this.runBFS.FlatAppearance.BorderSize = 5;
            this.runBFS.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.runBFS.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.runBFS.ForeColor = System.Drawing.Color.Orange;
            this.runBFS.Location = new System.Drawing.Point(3, 243);
            this.runBFS.Name = "runBFS";
            this.runBFS.Size = new System.Drawing.Size(208, 56);
            this.runBFS.TabIndex = 1;
            this.runBFS.Text = "RUN BFS";
            this.runBFS.UseVisualStyleBackColor = false;
            this.runBFS.Click += new System.EventHandler(this.RunBFS_Click);
            // 
            // runDFS
            // 
            this.runDFS.BackColor = System.Drawing.Color.Black;
            this.runDFS.FlatAppearance.BorderSize = 5;
            this.runDFS.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.runDFS.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.runDFS.ForeColor = System.Drawing.Color.Orange;
            this.runDFS.Location = new System.Drawing.Point(3, 305);
            this.runDFS.Name = "runDFS";
            this.runDFS.Size = new System.Drawing.Size(208, 58);
            this.runDFS.TabIndex = 1;
            this.runDFS.Text = "RUN DFS";
            this.runDFS.UseVisualStyleBackColor = false;
            this.runDFS.Click += new System.EventHandler(this.RunDFS_Click);
            // 
            // board
            // 
            this.board.AllowUserToAddRows = false;
            this.board.AllowUserToDeleteRows = false;
            this.board.AllowUserToResizeColumns = false;
            this.board.AllowUserToResizeRows = false;
            this.board.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.board.ColumnHeadersVisible = false;
            this.board.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6,
            this.Column7,
            this.Column8,
            this.Column9,
            this.Column10,
            this.Column11,
            this.Column12,
            this.Column13,
            this.Column14,
            this.Column15,
            this.Column16,
            this.Column20,
            this.Column17,
            this.Column18,
            this.Column19});
            this.board.Location = new System.Drawing.Point(1, 1);
            this.board.Name = "board";
            this.board.RowHeadersVisible = false;
            this.board.RowHeadersWidth = 51;
            this.board.RowTemplate.Height = 24;
            this.board.Size = new System.Drawing.Size(859, 699);
            this.board.TabIndex = 1;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Column1";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.Width = 125;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Column2";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.Width = 125;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Column3";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            this.Column3.Width = 125;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Column4";
            this.Column4.MinimumWidth = 6;
            this.Column4.Name = "Column4";
            this.Column4.Width = 125;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Column5";
            this.Column5.MinimumWidth = 6;
            this.Column5.Name = "Column5";
            this.Column5.Width = 125;
            // 
            // Column6
            // 
            this.Column6.HeaderText = "Column6";
            this.Column6.MinimumWidth = 6;
            this.Column6.Name = "Column6";
            this.Column6.Width = 125;
            // 
            // Column7
            // 
            this.Column7.HeaderText = "Column7";
            this.Column7.MinimumWidth = 6;
            this.Column7.Name = "Column7";
            this.Column7.Width = 125;
            // 
            // Column8
            // 
            this.Column8.HeaderText = "Column8";
            this.Column8.MinimumWidth = 6;
            this.Column8.Name = "Column8";
            this.Column8.Width = 125;
            // 
            // Column9
            // 
            this.Column9.HeaderText = "Column9";
            this.Column9.MinimumWidth = 6;
            this.Column9.Name = "Column9";
            this.Column9.Width = 125;
            // 
            // Column10
            // 
            this.Column10.HeaderText = "Column10";
            this.Column10.MinimumWidth = 6;
            this.Column10.Name = "Column10";
            this.Column10.Width = 125;
            // 
            // Column11
            // 
            this.Column11.HeaderText = "Column11";
            this.Column11.MinimumWidth = 6;
            this.Column11.Name = "Column11";
            this.Column11.Width = 125;
            // 
            // Column12
            // 
            this.Column12.HeaderText = "Column12";
            this.Column12.MinimumWidth = 6;
            this.Column12.Name = "Column12";
            this.Column12.Width = 125;
            // 
            // Column13
            // 
            this.Column13.HeaderText = "Column13";
            this.Column13.MinimumWidth = 6;
            this.Column13.Name = "Column13";
            this.Column13.Width = 125;
            // 
            // Column14
            // 
            this.Column14.HeaderText = "Column14";
            this.Column14.MinimumWidth = 6;
            this.Column14.Name = "Column14";
            this.Column14.Width = 125;
            // 
            // Column15
            // 
            this.Column15.HeaderText = "Column15";
            this.Column15.MinimumWidth = 6;
            this.Column15.Name = "Column15";
            this.Column15.Width = 125;
            // 
            // Column16
            // 
            this.Column16.HeaderText = "Column16";
            this.Column16.MinimumWidth = 6;
            this.Column16.Name = "Column16";
            this.Column16.Width = 125;
            // 
            // Column20
            // 
            this.Column20.HeaderText = "Column20";
            this.Column20.MinimumWidth = 6;
            this.Column20.Name = "Column20";
            this.Column20.Width = 125;
            // 
            // Column17
            // 
            this.Column17.HeaderText = "Column17";
            this.Column17.MinimumWidth = 6;
            this.Column17.Name = "Column17";
            this.Column17.Width = 125;
            // 
            // Column18
            // 
            this.Column18.HeaderText = "Column18";
            this.Column18.MinimumWidth = 6;
            this.Column18.Name = "Column18";
            this.Column18.Width = 125;
            // 
            // Column19
            // 
            this.Column19.HeaderText = "Column19";
            this.Column19.MinimumWidth = 6;
            this.Column19.Name = "Column19";
            this.Column19.Width = 125;
            // 
            // runAstar
            // 
            this.runAstar.BackColor = System.Drawing.Color.Black;
            this.runAstar.FlatAppearance.BorderSize = 5;
            this.runAstar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.runAstar.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.runAstar.ForeColor = System.Drawing.Color.Orange;
            this.runAstar.Location = new System.Drawing.Point(3, 369);
            this.runAstar.Name = "runAstar";
            this.runAstar.Size = new System.Drawing.Size(208, 58);
            this.runAstar.TabIndex = 26;
            this.runAstar.Text = "RUN A*";
            this.runAstar.UseVisualStyleBackColor = false;
            this.runAstar.Click += new System.EventHandler(this.RunAstar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1072, 702);
            this.Controls.Add(this.board);
            this.Controls.Add(this.upPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.Text = "Form1";
            this.upPanel.ResumeLayout(false);
            this.upPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.board)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel upPanel;
        private System.Windows.Forms.Button closeButton;
        private System.Windows.Forms.Button runBFS;
        private System.Windows.Forms.Button select;
        private System.Windows.Forms.Button runDFS;
        private System.Windows.Forms.Button clear;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column9;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column10;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column11;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column12;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column13;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column14;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column15;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column16;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column20;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column17;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column18;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column19;
        public System.Windows.Forms.DataGridView board;
        private System.Windows.Forms.Label TXT;
        private System.Windows.Forms.ListBox endLISTy;
        private System.Windows.Forms.ListBox endLISTx;
        private System.Windows.Forms.ListBox startLISTy;
        private System.Windows.Forms.ListBox startLISTx;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label txts;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox pathCount;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button runAstar;
    }
}

