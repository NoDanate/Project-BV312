namespace ProjectBV312
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;
        ///
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.NoteTextBox = new System.Windows.Forms.RichTextBox();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripDropDownButton4 = new System.Windows.Forms.ToolStripDropDownButton();
            this.NewNote = new System.Windows.Forms.ToolStripMenuItem();
            this.OpenNote = new System.Windows.Forms.ToolStripMenuItem();
            this.SaveNote = new System.Windows.Forms.ToolStripMenuItem();
            this.SaveAsNote = new System.Windows.Forms.ToolStripMenuItem();
            this.ClearNote = new System.Windows.Forms.ToolStripMenuItem();
            this.HelpNote = new System.Windows.Forms.ToolStripMenuItem();
            this.BoldBtn = new System.Windows.Forms.ToolStripButton();
            this.ItalicBtn = new System.Windows.Forms.ToolStripButton();
            this.UnderBtn = new System.Windows.Forms.ToolStripButton();
            this.ClearBtn = new System.Windows.Forms.ToolStripButton();
            this.FontBtn = new System.Windows.Forms.ToolStripButton();
            this.ColorBtn = new System.Windows.Forms.ToolStripButton();
            this.ImageBtn = new System.Windows.Forms.ToolStripButton();
            this.searchTextBox = new System.Windows.Forms.ToolStripTextBox();
            this.SearchBtn = new System.Windows.Forms.ToolStripButton();
            this.pdfViewer = new PdfiumViewer.PdfViewer();
            this.MarkersBtn = new System.Windows.Forms.ToolStripDropDownButton();
            this.NumberedBtn = new System.Windows.Forms.ToolStripMenuItem();
            this.BulletBtn = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // NoteTextBox
            // 
            this.NoteTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.NoteTextBox.Location = new System.Drawing.Point(0, 55);
            this.NoteTextBox.Name = "NoteTextBox";
            this.NoteTextBox.Size = new System.Drawing.Size(785, 356);
            this.NoteTextBox.TabIndex = 0;
            this.NoteTextBox.Text = "";
            // 
            // toolStrip1
            // 
            this.toolStrip1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.toolStrip1.AutoSize = false;
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.toolStrip1.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripDropDownButton4,
            this.BoldBtn,
            this.ItalicBtn,
            this.UnderBtn,
            this.MarkersBtn,
            this.ClearBtn,
            this.FontBtn,
            this.ColorBtn,
            this.ImageBtn,
            this.searchTextBox,
            this.SearchBtn});
            this.toolStrip1.Location = new System.Drawing.Point(0, 2);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(785, 50);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "ToolStrip";
            // 
            // toolStripDropDownButton4
            // 
            this.toolStripDropDownButton4.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripDropDownButton4.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.NewNote,
            this.OpenNote,
            this.SaveNote,
            this.SaveAsNote,
            this.ClearNote,
            this.HelpNote});
            this.toolStripDropDownButton4.Image = global::ProjectBV312.Properties.Resources.saveas_5165;
            this.toolStripDropDownButton4.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripDropDownButton4.Name = "toolStripDropDownButton4";
            this.toolStripDropDownButton4.Size = new System.Drawing.Size(29, 47);
            this.toolStripDropDownButton4.Text = "File";
            // 
            // NewNote
            // 
            this.NewNote.Name = "NewNote";
            this.NewNote.Size = new System.Drawing.Size(180, 34);
            this.NewNote.Text = "New";
            this.NewNote.Click += new System.EventHandler(this.NewNote_Click);
            // 
            // OpenNote
            // 
            this.OpenNote.Name = "OpenNote";
            this.OpenNote.Size = new System.Drawing.Size(180, 34);
            this.OpenNote.Text = "Open";
            this.OpenNote.Click += new System.EventHandler(this.OpenNote_Click);
            // 
            // SaveNote
            // 
            this.SaveNote.Name = "SaveNote";
            this.SaveNote.Size = new System.Drawing.Size(180, 34);
            this.SaveNote.Text = "Save";
            this.SaveNote.Click += new System.EventHandler(this.SaveNote_Click);
            // 
            // SaveAsNote
            // 
            this.SaveAsNote.Name = "SaveAsNote";
            this.SaveAsNote.Size = new System.Drawing.Size(180, 34);
            this.SaveAsNote.Text = "SaveAs";
            this.SaveAsNote.Click += new System.EventHandler(this.SaveAsNote_Click);
            // 
            // ClearNote
            // 
            this.ClearNote.Name = "ClearNote";
            this.ClearNote.Size = new System.Drawing.Size(180, 34);
            this.ClearNote.Text = "Clear";
            this.ClearNote.Click += new System.EventHandler(this.ClearNote_Click);
            // 
            // HelpNote
            // 
            this.HelpNote.Name = "HelpNote";
            this.HelpNote.Size = new System.Drawing.Size(180, 34);
            this.HelpNote.Text = "Help";
            this.HelpNote.Click += new System.EventHandler(this.HelpNote_Click);
            // 
            // BoldBtn
            // 
            this.BoldBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.BoldBtn.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BoldBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.BoldBtn.Name = "BoldBtn";
            this.BoldBtn.Size = new System.Drawing.Size(62, 47);
            this.BoldBtn.Text = "Bold";
            this.BoldBtn.Click += new System.EventHandler(this.BoldBtn_Click);
            // 
            // ItalicBtn
            // 
            this.ItalicBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.ItalicBtn.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ItalicBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ItalicBtn.Name = "ItalicBtn";
            this.ItalicBtn.Size = new System.Drawing.Size(60, 47);
            this.ItalicBtn.Text = "Italic";
            this.ItalicBtn.Click += new System.EventHandler(this.ItalicBtn_Click);
            // 
            // UnderBtn
            // 
            this.UnderBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.UnderBtn.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.UnderBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.UnderBtn.Name = "UnderBtn";
            this.UnderBtn.Size = new System.Drawing.Size(106, 47);
            this.UnderBtn.Text = "Underline";
            this.UnderBtn.Click += new System.EventHandler(this.UnderBtn_Click);
            // 
            // ClearBtn
            // 
            this.ClearBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.ClearBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ClearBtn.Name = "ClearBtn";
            this.ClearBtn.Size = new System.Drawing.Size(64, 47);
            this.ClearBtn.Text = "Clear";
            this.ClearBtn.Click += new System.EventHandler(this.ClearBtn_Click);
            // 
            // FontBtn
            // 
            this.FontBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.FontBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.FontBtn.Name = "FontBtn";
            this.FontBtn.Size = new System.Drawing.Size(58, 47);
            this.FontBtn.Text = "Font";
            this.FontBtn.Click += new System.EventHandler(this.FontBtn_Click);
            // 
            // ColorBtn
            // 
            this.ColorBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.ColorBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ColorBtn.Name = "ColorBtn";
            this.ColorBtn.Size = new System.Drawing.Size(66, 47);
            this.ColorBtn.Text = "Color";
            this.ColorBtn.Click += new System.EventHandler(this.ColorBtn_Click);
            // 
            // ImageBtn
            // 
            this.ImageBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.ImageBtn.Image = global::ProjectBV312.Properties.Resources.add_image;
            this.ImageBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ImageBtn.Name = "ImageBtn";
            this.ImageBtn.Size = new System.Drawing.Size(23, 47);
            this.ImageBtn.Text = "Image";
            this.ImageBtn.Click += new System.EventHandler(this.ImageBtn_Click);
            // 
            // searchTextBox
            // 
            this.searchTextBox.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.searchTextBox.Name = "searchTextBox";
            this.searchTextBox.Size = new System.Drawing.Size(100, 50);
            // 
            // SearchBtn
            // 
            this.SearchBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.SearchBtn.Image = global::ProjectBV312.Properties.Resources.searchmagnifierinterfacesymbol1_79893__1_;
            this.SearchBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.SearchBtn.Name = "SearchBtn";
            this.SearchBtn.Size = new System.Drawing.Size(23, 47);
            this.SearchBtn.Text = "Search";
            this.SearchBtn.Click += new System.EventHandler(this.SearchBtn_Click);
            // 
            // pdfViewer
            // 
            this.pdfViewer.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pdfViewer.Location = new System.Drawing.Point(0, 55);
            this.pdfViewer.Name = "pdfViewer";
            this.pdfViewer.Size = new System.Drawing.Size(785, 356);
            this.pdfViewer.TabIndex = 2;
            this.pdfViewer.Visible = false;
            // 
            // MarkersBtn
            // 
            this.MarkersBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.MarkersBtn.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.BulletBtn,
            this.NumberedBtn});
            this.MarkersBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.MarkersBtn.Name = "MarkersBtn";
            this.MarkersBtn.Size = new System.Drawing.Size(100, 47);
            this.MarkersBtn.Text = "Markers";
            // 
            // NumberedBtn
            // 
            this.NumberedBtn.Name = "NumberedBtn";
            this.NumberedBtn.Size = new System.Drawing.Size(185, 34);
            this.NumberedBtn.Text = "Numbered";
            this.NumberedBtn.Click += new System.EventHandler(this.NumberedListButton_Click);
            // 
            // BulletBtn
            // 
            this.BulletBtn.Name = "BulletBtn";
            this.BulletBtn.Size = new System.Drawing.Size(185, 34);
            this.BulletBtn.Text = "Bullet";
            this.BulletBtn.Click += new System.EventHandler(this.BulletListBuutton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 411);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.pdfViewer);
            this.Controls.Add(this.NoteTextBox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Заметки";
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox NoteTextBox;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton BoldBtn;
        private System.Windows.Forms.ToolStripButton ItalicBtn;
        private System.Windows.Forms.ToolStripButton UnderBtn;
        private System.Windows.Forms.ToolStripButton ClearBtn;
        private System.Windows.Forms.ToolStripDropDownButton toolStripDropDownButton4;
        private System.Windows.Forms.ToolStripMenuItem NewNote;
        private System.Windows.Forms.ToolStripMenuItem OpenNote;
        private System.Windows.Forms.ToolStripMenuItem SaveAsNote;
        private System.Windows.Forms.ToolStripMenuItem HelpNote;
        private System.Windows.Forms.ToolStripMenuItem ClearNote;
        private System.Windows.Forms.ToolStripMenuItem SaveNote;
        private System.Windows.Forms.ToolStripButton ImageBtn;
        private System.Windows.Forms.ToolStripButton SearchBtn;
        private PdfiumViewer.PdfViewer pdfViewer;
        private System.Windows.Forms.ToolStripButton FontBtn;
        private System.Windows.Forms.ToolStripButton ColorBtn;
        private System.Windows.Forms.ToolStripTextBox searchTextBox;
        private System.Windows.Forms.ToolStripDropDownButton MarkersBtn;
        private System.Windows.Forms.ToolStripMenuItem BulletBtn;
        private System.Windows.Forms.ToolStripMenuItem NumberedBtn;
    }
}

