﻿namespace NovelReader
{
    partial class NovelReaderForm
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NovelReaderForm));
            this.dgvChapterList = new System.Windows.Forms.DataGridView();
            this.chapterContextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.setReadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.setNotReadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.setDownloadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.remakeAudioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteChapterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.chapterBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.rtbChapterTextBox = new System.Windows.Forms.RichTextBox();
            this.btnNext = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnPlay = new System.Windows.Forms.Button();
            this.cbAutoPlay = new System.Windows.Forms.CheckBox();
            this.labelTitle = new System.Windows.Forms.Label();
            this.btnPrevious = new System.Windows.Forms.Button();
            this.btnFinishReading = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.mp3Player = new AxWMPLib.AxWindowsMediaPlayer();
            this.exportChaptersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.audioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.textToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bothToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dgvChapterList)).BeginInit();
            this.chapterContextMenuStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chapterBindingSource)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mp3Player)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvChapterList
            // 
            this.dgvChapterList.AllowUserToAddRows = false;
            this.dgvChapterList.AllowUserToDeleteRows = false;
            this.dgvChapterList.AllowUserToResizeRows = false;
            this.dgvChapterList.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.dgvChapterList.AutoGenerateColumns = false;
            this.dgvChapterList.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dgvChapterList.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvChapterList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvChapterList.ContextMenuStrip = this.chapterContextMenuStrip;
            this.dgvChapterList.DataSource = this.chapterBindingSource;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.DodgerBlue;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvChapterList.DefaultCellStyle = dataGridViewCellStyle1;
            this.dgvChapterList.Location = new System.Drawing.Point(5, 5);
            this.dgvChapterList.Name = "dgvChapterList";
            this.dgvChapterList.RowHeadersVisible = false;
            this.dgvChapterList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvChapterList.Size = new System.Drawing.Size(350, 645);
            this.dgvChapterList.TabIndex = 0;
            this.dgvChapterList.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvChapterList_CellDoubleClick);
            this.dgvChapterList.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgvChapterList_CellFormatting);
            this.dgvChapterList.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvChapterList_CellValueChanged);
            this.dgvChapterList.CurrentCellDirtyStateChanged += new System.EventHandler(this.dgvChapterList_CurrentCellDirtyStateChanged);
            this.dgvChapterList.MouseDown += new System.Windows.Forms.MouseEventHandler(this.dgvChapterList_MouseDown);
            // 
            // chapterContextMenuStrip
            // 
            this.chapterContextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.setReadToolStripMenuItem,
            this.setNotReadToolStripMenuItem,
            this.setDownloadToolStripMenuItem,
            this.remakeAudioToolStripMenuItem,
            this.deleteChapterToolStripMenuItem,
            this.exportChaptersToolStripMenuItem});
            this.chapterContextMenuStrip.Name = "chapterContextMenuStrip";
            this.chapterContextMenuStrip.Size = new System.Drawing.Size(158, 158);
            this.chapterContextMenuStrip.Opening += new System.ComponentModel.CancelEventHandler(this.chapterContextMenuStrip_Opening);
            this.chapterContextMenuStrip.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.chapterContextMenuStrip_ItemClicked);
            // 
            // setReadToolStripMenuItem
            // 
            this.setReadToolStripMenuItem.Name = "setReadToolStripMenuItem";
            this.setReadToolStripMenuItem.Size = new System.Drawing.Size(157, 22);
            this.setReadToolStripMenuItem.Text = "Set Read";
            // 
            // setNotReadToolStripMenuItem
            // 
            this.setNotReadToolStripMenuItem.Name = "setNotReadToolStripMenuItem";
            this.setNotReadToolStripMenuItem.Size = new System.Drawing.Size(157, 22);
            this.setNotReadToolStripMenuItem.Text = "Set Not Read";
            // 
            // setDownloadToolStripMenuItem
            // 
            this.setDownloadToolStripMenuItem.Name = "setDownloadToolStripMenuItem";
            this.setDownloadToolStripMenuItem.Size = new System.Drawing.Size(157, 22);
            this.setDownloadToolStripMenuItem.Text = "Redownload";
            // 
            // remakeAudioToolStripMenuItem
            // 
            this.remakeAudioToolStripMenuItem.Name = "remakeAudioToolStripMenuItem";
            this.remakeAudioToolStripMenuItem.Size = new System.Drawing.Size(157, 22);
            this.remakeAudioToolStripMenuItem.Text = "Remake Audio";
            // 
            // deleteChapterToolStripMenuItem
            // 
            this.deleteChapterToolStripMenuItem.Name = "deleteChapterToolStripMenuItem";
            this.deleteChapterToolStripMenuItem.Size = new System.Drawing.Size(157, 22);
            this.deleteChapterToolStripMenuItem.Text = "Delete Chapters";
            // 
            // chapterBindingSource
            // 
            this.chapterBindingSource.Filter = "Valid=True";
            // 
            // rtbChapterTextBox
            // 
            this.rtbChapterTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rtbChapterTextBox.BackColor = System.Drawing.SystemColors.Control;
            this.rtbChapterTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rtbChapterTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.rtbChapterTextBox.Location = new System.Drawing.Point(360, 50);
            this.rtbChapterTextBox.Name = "rtbChapterTextBox";
            this.rtbChapterTextBox.ReadOnly = true;
            this.rtbChapterTextBox.Size = new System.Drawing.Size(920, 600);
            this.rtbChapterTextBox.TabIndex = 1;
            this.rtbChapterTextBox.Text = "";
            this.rtbChapterTextBox.TextChanged += new System.EventHandler(this.rtbChapterTextBox_TextChanged);
            // 
            // btnNext
            // 
            this.btnNext.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnNext.BackColor = System.Drawing.Color.SteelBlue;
            this.btnNext.FlatAppearance.BorderSize = 0;
            this.btnNext.FlatAppearance.CheckedBackColor = System.Drawing.Color.White;
            this.btnNext.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNext.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnNext.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnNext.Location = new System.Drawing.Point(570, 0);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(80, 45);
            this.btnNext.TabIndex = 3;
            this.btnNext.Text = "Next";
            this.btnNext.UseVisualStyleBackColor = false;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEdit.BackColor = System.Drawing.Color.SteelBlue;
            this.btnEdit.FlatAppearance.BorderSize = 0;
            this.btnEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.btnEdit.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnEdit.Location = new System.Drawing.Point(790, 0);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(130, 45);
            this.btnEdit.TabIndex = 4;
            this.btnEdit.Text = "Edit";
            this.btnEdit.UseVisualStyleBackColor = false;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnPlay
            // 
            this.btnPlay.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnPlay.BackColor = System.Drawing.Color.SteelBlue;
            this.btnPlay.FlatAppearance.BorderSize = 0;
            this.btnPlay.FlatAppearance.CheckedBackColor = System.Drawing.Color.White;
            this.btnPlay.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPlay.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnPlay.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnPlay.Location = new System.Drawing.Point(650, 0);
            this.btnPlay.Name = "btnPlay";
            this.btnPlay.Size = new System.Drawing.Size(110, 45);
            this.btnPlay.TabIndex = 5;
            this.btnPlay.Text = "Play";
            this.btnPlay.UseVisualStyleBackColor = false;
            this.btnPlay.Click += new System.EventHandler(this.btnPlay_Click);
            // 
            // cbAutoPlay
            // 
            this.cbAutoPlay.AutoSize = true;
            this.cbAutoPlay.BackColor = System.Drawing.Color.SteelBlue;
            this.cbAutoPlay.FlatAppearance.BorderSize = 0;
            this.cbAutoPlay.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbAutoPlay.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cbAutoPlay.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.cbAutoPlay.Location = new System.Drawing.Point(6, 14);
            this.cbAutoPlay.Name = "cbAutoPlay";
            this.cbAutoPlay.Size = new System.Drawing.Size(93, 21);
            this.cbAutoPlay.TabIndex = 8;
            this.cbAutoPlay.Text = "Auto Play";
            this.cbAutoPlay.UseVisualStyleBackColor = false;
            this.cbAutoPlay.CheckedChanged += new System.EventHandler(this.cbAutoPlay_CheckedChanged);
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.BackColor = System.Drawing.Color.SteelBlue;
            this.labelTitle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.labelTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitle.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.labelTitle.Location = new System.Drawing.Point(10, 6);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(71, 31);
            this.labelTitle.TabIndex = 9;
            this.labelTitle.Text = "Title";
            // 
            // btnPrevious
            // 
            this.btnPrevious.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnPrevious.BackColor = System.Drawing.Color.SteelBlue;
            this.btnPrevious.FlatAppearance.BorderSize = 0;
            this.btnPrevious.FlatAppearance.CheckedBackColor = System.Drawing.Color.White;
            this.btnPrevious.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPrevious.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnPrevious.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnPrevious.Location = new System.Drawing.Point(355, 0);
            this.btnPrevious.Name = "btnPrevious";
            this.btnPrevious.Size = new System.Drawing.Size(85, 45);
            this.btnPrevious.TabIndex = 2;
            this.btnPrevious.Text = "Prev";
            this.btnPrevious.UseVisualStyleBackColor = false;
            this.btnPrevious.Click += new System.EventHandler(this.btnPrevious_Click);
            // 
            // btnFinishReading
            // 
            this.btnFinishReading.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnFinishReading.BackColor = System.Drawing.Color.SteelBlue;
            this.btnFinishReading.FlatAppearance.BorderSize = 0;
            this.btnFinishReading.FlatAppearance.CheckedBackColor = System.Drawing.Color.White;
            this.btnFinishReading.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFinishReading.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnFinishReading.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnFinishReading.Location = new System.Drawing.Point(440, 0);
            this.btnFinishReading.Name = "btnFinishReading";
            this.btnFinishReading.Size = new System.Drawing.Size(130, 45);
            this.btnFinishReading.TabIndex = 13;
            this.btnFinishReading.Text = "Finish Reading";
            this.btnFinishReading.UseVisualStyleBackColor = false;
            this.btnFinishReading.Click += new System.EventHandler(this.btnFinishReading_Click);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.SteelBlue;
            this.panel1.Controls.Add(this.labelTitle);
            this.panel1.Controls.Add(this.btnEdit);
            this.panel1.Location = new System.Drawing.Point(360, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(920, 45);
            this.panel1.TabIndex = 15;
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.panel2.BackColor = System.Drawing.Color.SteelBlue;
            this.panel2.Controls.Add(this.btnPrevious);
            this.panel2.Controls.Add(this.btnFinishReading);
            this.panel2.Controls.Add(this.btnNext);
            this.panel2.Controls.Add(this.btnPlay);
            this.panel2.Location = new System.Drawing.Point(5, 650);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(760, 45);
            this.panel2.TabIndex = 16;
            // 
            // panel3
            // 
            this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.panel3.BackColor = System.Drawing.Color.SteelBlue;
            this.panel3.Controls.Add(this.cbAutoPlay);
            this.panel3.Location = new System.Drawing.Point(1180, 650);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(100, 45);
            this.panel3.TabIndex = 17;
            // 
            // mp3Player
            // 
            this.mp3Player.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.mp3Player.Enabled = true;
            this.mp3Player.Location = new System.Drawing.Point(765, 650);
            this.mp3Player.Name = "mp3Player";
            this.mp3Player.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("mp3Player.OcxState")));
            this.mp3Player.Size = new System.Drawing.Size(415, 45);
            this.mp3Player.TabIndex = 14;
            this.mp3Player.PlayStateChange += new AxWMPLib._WMPOCXEvents_PlayStateChangeEventHandler(this.mp3Player_PlayStateChange);
            // 
            // exportChaptersToolStripMenuItem
            // 
            this.exportChaptersToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.audioToolStripMenuItem,
            this.textToolStripMenuItem,
            this.bothToolStripMenuItem});
            this.exportChaptersToolStripMenuItem.Name = "exportChaptersToolStripMenuItem";
            this.exportChaptersToolStripMenuItem.Size = new System.Drawing.Size(157, 22);
            this.exportChaptersToolStripMenuItem.Text = "Export Chapters";
            // 
            // audioToolStripMenuItem
            // 
            this.audioToolStripMenuItem.Name = "audioToolStripMenuItem";
            this.audioToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.audioToolStripMenuItem.Text = "Audio";
            this.audioToolStripMenuItem.Click += new System.EventHandler(this.ExportItem_Click);
            // 
            // textToolStripMenuItem
            // 
            this.textToolStripMenuItem.Name = "textToolStripMenuItem";
            this.textToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.textToolStripMenuItem.Text = "Text";
            this.textToolStripMenuItem.Click += new System.EventHandler(this.ExportItem_Click);
            // 
            // bothToolStripMenuItem
            // 
            this.bothToolStripMenuItem.Name = "bothToolStripMenuItem";
            this.bothToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.bothToolStripMenuItem.Text = "Audo and Text";
            this.bothToolStripMenuItem.Click += new System.EventHandler(this.ExportItem_Click);
            // 
            // NovelReaderForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.BackColor = System.Drawing.Color.LightSkyBlue;
            this.ClientSize = new System.Drawing.Size(1284, 700);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.mp3Player);
            this.Controls.Add(this.rtbChapterTextBox);
            this.Controls.Add(this.dgvChapterList);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MinimumSize = new System.Drawing.Size(1300, 300);
            this.Name = "NovelReaderForm";
            this.Text = "NovelReaderForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.NovelReaderForm_FormClosing);
            this.Load += new System.EventHandler(this.NovelReaderForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvChapterList)).EndInit();
            this.chapterContextMenuStrip.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chapterBindingSource)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mp3Player)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvChapterList;
        private System.Windows.Forms.RichTextBox rtbChapterTextBox;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnPlay;
        private System.Windows.Forms.CheckBox cbAutoPlay;
        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.Button btnPrevious;
        private System.Windows.Forms.Button btnFinishReading;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private AxWMPLib.AxWindowsMediaPlayer mp3Player;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.ContextMenuStrip chapterContextMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem setReadToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem setNotReadToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem setDownloadToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem remakeAudioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteChapterToolStripMenuItem;
        private System.Windows.Forms.BindingSource chapterBindingSource;
        private System.Windows.Forms.ToolStripMenuItem exportChaptersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem audioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem textToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bothToolStripMenuItem;
    }
}