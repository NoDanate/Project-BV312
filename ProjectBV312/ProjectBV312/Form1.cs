using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PdfiumViewer;
using iTextSharp.text.pdf;
using iTextSharp.text;

namespace ProjectBV312
{
    public partial class Form1: Form
    {
        private string currentFilePath = string.Empty;
        public Form1()
        {
            InitializeComponent();
        }

        private void NewNote_Click(object sender, EventArgs e)
        {
            NoteTextBox.Clear();
            currentFilePath = string.Empty;
            this.Text = "Заметки - Новая заметка";
        }

        private void OpenNote_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "Files (*.txt;*.rtf;*.pdf)|*.txt;*.rtf;*.pdf|Text Files (*.txt)|*.txt|RTF Files (*.rtf)|*.rtf|PDF Files (*.pdf)|*.pdf";
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string filePath = openFileDialog.FileName;

                    if (filePath.EndsWith(".txt", StringComparison.OrdinalIgnoreCase))
                    {
                        //Режим редактирования
                        NoteTextBox.Visible = true;
                        pdfViewer.Visible = false;
                        NoteTextBox.LoadFile(filePath, RichTextBoxStreamType.PlainText);
                    }
                    else if (filePath.EndsWith(".rtf", StringComparison.OrdinalIgnoreCase))
                    {
                        NoteTextBox.Visible = true;
                        pdfViewer.Visible = false;
                        NoteTextBox.LoadFile(filePath, RichTextBoxStreamType.RichText);
                    }
                    else if (filePath.EndsWith(".pdf", StringComparison.OrdinalIgnoreCase))
                    {
                            try
                            {
                                pdfViewer.Document?.Dispose(); // Освобождаем предыдущий документ
                                pdfViewer.Document = PdfiumViewer.PdfDocument.Load(filePath);
                                pdfViewer.Visible = true;
                                NoteTextBox.Visible = false;
                            }
                            catch (Exception ex)
                            {
                                MessageBox.Show("Ошибка при открытии PDF: " + ex.Message);
                            }
                            /*try
                            {
                                //Загружаем PDF с помощью PdfiumViewer
                                var document = PdfiumViewer.PdfDocument.Load(filePath);
                                pdfViewer.Document = document;
                                pdfViewer.Visible = true;
                                NoteTextBox.Visible = false;
                            }
                            catch (Exception ex)
                            {
                                MessageBox.Show("Ошибка при открытии PDF: " + ex.Message);
                            }*/
                        }
                }
            }

            /*OpenFileDialog openFileDialog = new OpenFileDialog
            {
                Filter = "Text Files (*.txt)|*.txt|RTF files (*.rtf)|*.rtf|" +
                "PDF files (*.pdf)|*.pdf|All Files (*.*)|*.*"
            };

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                currentFilePath = openFileDialog.FileName;
                NoteTextBox.Text = File.ReadAllText(currentFilePath);
                this.Text = $"Заметки - {Path.GetFileName(currentFilePath)}";
            }*/
        }

        private void SaveNote_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(currentFilePath))
            {
                File.WriteAllText(currentFilePath, NoteTextBox.Text);
                this.Text = $"Заметки - {Path.GetFileName(currentFilePath)}";
            }
            else
            {
                MessageBox.Show("Вы не указали путь сохранения!", "!!!");
            }
        }

        private void SaveAsNote_Click(object sender, EventArgs e)
        {
            using (SaveFileDialog saveFileDialog = new SaveFileDialog())
            {
                saveFileDialog.Filter = "Files (*.txt;*.rtf;*.pdf)|*.txt;*.rtf;*.pdf|Text Files (*.txt)|*.txt|RTF Files (*.rtf)|*.rtf|PDF Files (*.pdf)|*.pdf";
                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string filePath = saveFileDialog.FileName;
                    if (filePath.EndsWith(".txt", StringComparison.OrdinalIgnoreCase))
                    {
                        NoteTextBox.SaveFile(filePath, RichTextBoxStreamType.PlainText);
                    }
                    else if (filePath.EndsWith(".rtf", StringComparison.OrdinalIgnoreCase))
                    {
                        NoteTextBox.SaveFile(filePath, RichTextBoxStreamType.RichText);
                    }
                    else if (filePath.EndsWith(".pdf", StringComparison.OrdinalIgnoreCase))
                    {
                        using (FileStream stream = new FileStream(filePath, FileMode.Create))
                        {
                            Document pdfDoc = new Document(PageSize.A4);
                            PdfWriter.GetInstance(pdfDoc, stream);
                            pdfDoc.Open();

                            using (Bitmap bitmap = new Bitmap(NoteTextBox.Width, NoteTextBox.Height))
                            {
                                NoteTextBox.DrawToBitmap(bitmap, new System.Drawing.Rectangle(0, 0, bitmap.Width, bitmap.Height));

                                using (MemoryStream imageStream = new MemoryStream())
                                {
                                    bitmap.Save(imageStream, System.Drawing.Imaging.ImageFormat.Png);
                                    iTextSharp.text.Image pdfImage = iTextSharp.text.Image.GetInstance(imageStream.ToArray());

                                    pdfImage.ScaleToFit(PageSize.A4.Width - 20, PageSize.A4.Height - 20);
                                    pdfDoc.Add(pdfImage);
                                }
                            }

                            pdfDoc.Close();
                        }
                    }
                }
            }

            /*SaveFileDialog saveFileDialog = new SaveFileDialog
            {
                Filter = "Text Files (*.txt)|*.txt|RTF files (*.rtf)|*.rtf|" +
                "PDF files (*.pdf)|*.pdf|All Files (*.*)|*.*"
            };

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                currentFilePath = saveFileDialog.FileName;
            }*/
        }

        private void ClearNote_Click(object sender, EventArgs e)
        {
            NoteTextBox.Clear();
        }

        private void HelpNote_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Заметки.\n\n" +
                            "1. Создайтеь новую заметку.\n" +
                            "2. Открыть существующую заметку.\n" +
                            "3. Сохранить изменения.\n" +
                            "4. Очистить содержимое.\n",
                            "Справка");
        }

        private void BoldBtn_Click(object sender, EventArgs e)
        {
            FontStyle style = NoteTextBox.SelectionFont.Style;
            if (NoteTextBox.SelectionFont.Bold)
            {
                style = style & ~FontStyle.Bold;
                BoldBtn.BackColor = Color.White;
            }
            else
            {
                style = style | FontStyle.Bold;
                BoldBtn.BackColor = Color.LightGray;
            }
            NoteTextBox.SelectionFont = new System.Drawing.Font(NoteTextBox.SelectionFont, style);
            NoteTextBox.Focus();
        }

        private void ItalicBtn_Click(object sender, EventArgs e)
        {
            FontStyle style = NoteTextBox.SelectionFont.Style;
            if (NoteTextBox.SelectionFont.Italic)
            {
                style = style & ~FontStyle.Italic;
                ItalicBtn.BackColor = Color.White;
            }
            else
            {
                style = style | FontStyle.Italic;
                ItalicBtn.BackColor = Color.LightGray;
            }
            NoteTextBox.SelectionFont = new System.Drawing.Font(NoteTextBox.SelectionFont, style);
            NoteTextBox.Focus();
        }

        private void UnderBtn_Click(object sender, EventArgs e)
        {
            FontStyle style = NoteTextBox.SelectionFont.Style;
            if (NoteTextBox.SelectionFont.Underline)
            {
                style = style & ~FontStyle.Underline;
                UnderBtn.BackColor = Color.White;
            }
            else
            {
                style = style | FontStyle.Underline;
                UnderBtn.BackColor = Color.LightGray;
            }
            NoteTextBox.SelectionFont = new System.Drawing.Font(NoteTextBox.SelectionFont, style);
            NoteTextBox.Focus();
        }

        private void ClearBtn_Click(object sender, EventArgs e)
        {
            NoteTextBox.Clear();
            NoteTextBox.Font = new System.Drawing.Font(NoteTextBox.Font, FontStyle.Regular);

            BoldBtn.BackColor = Color.White;
            ItalicBtn.BackColor = Color.White;
            UnderBtn.BackColor = Color.White;
        }

        private void ImageBtn_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "Image Files (*.png;*.jpg;*.jpeg)|*.png;*.jpg;*.jpeg";
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        string imagePath = openFileDialog.FileName;
                        System.Drawing.Image img = System.Drawing.Image.FromFile(imagePath);
                        Clipboard.SetImage(img);
                        NoteTextBox.Paste();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Ошибка при вставке изображения: " + ex.Message);
                    }
                }
            }
        }

        private void FontBtn_Click(object sender, EventArgs e)
        {
            using (FontDialog fontDialog = new FontDialog())
            {
                if (fontDialog.ShowDialog() == DialogResult.OK)
                {
                    NoteTextBox.SelectionFont = fontDialog.Font;
                }
            }
        }

        private void ColorBtn_Click(object sender, EventArgs e)
        {
            using (ColorDialog colorDialog = new ColorDialog())
            {
                if (colorDialog.ShowDialog() == DialogResult.OK)
                {
                    NoteTextBox.SelectionColor = colorDialog.Color;
                }
            }
        }

        private void SearchBtn_Click(object sender, EventArgs e)
        {
            string searchText = searchTextBox.Text;
            int startIndex = 0;
            NoteTextBox.SelectAll();
            NoteTextBox.SelectionBackColor = NoteTextBox.BackColor;
            while ((startIndex = NoteTextBox.Text.IndexOf(searchText, startIndex, StringComparison.OrdinalIgnoreCase)) != -1)
            {
                NoteTextBox.Select(startIndex, searchText.Length);
                NoteTextBox.SelectionBackColor = Color.Yellow;
                startIndex += searchText.Length;
            }
        }



        //Как работать с этим pdf?
    }
}
