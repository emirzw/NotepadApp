using System;
using System.Drawing;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace NotepadApp
{
    public partial class Form1 : Form
    {
        private enum AppTheme
        {
            Light,
            Dark
        }

        private string? _currentFilePath;
        private bool _isDirty;
        private bool _suppressTextChangedEvent;
        private float _zoomFactor = 1f;
        private AppTheme _currentTheme = AppTheme.Light;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            statusLabelEncoding.Text = "UTF-8";
            ApplyTheme(_currentTheme);
            ApplyWordWrap();
            statusStrip.Visible = statusBarToolStripMenuItem.Checked;
            ResetZoom();
            UpdateStatusBar();
            UpdateWindowTitle();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!PromptSaveIfNeeded())
            {
                e.Cancel = true;
            }
        }

        private void FileNewMenuItem_Click(object sender, EventArgs e)
        {
            if (!PromptSaveIfNeeded())
            {
                return;
            }

            _currentFilePath = null;
            SetEditorText(string.Empty);
            UpdateWindowTitle();
        }

        private void OpenFileMenuItem_Click(object sender, EventArgs e)
        {
            OpenDocumentFromDisk();
        }

        private void SaveFileMenuItem_Click(object sender, EventArgs e)
        {
            SaveDocument();
        }

        private void SaveAsMenuItem_Click(object sender, EventArgs e)
        {
            SaveDocument(forceSaveAs: true);
        }

        private void ExitMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void UndoMenuItem_Click(object sender, EventArgs e)
        {
            if (txtEditor.CanUndo)
            {
                txtEditor.Undo();
            }
        }

        private void RedoMenuItem_Click(object sender, EventArgs e)
        {
            if (txtEditor.CanRedo)
            {
                txtEditor.Redo();
            }
        }

        private void CutMenuItem_Click(object sender, EventArgs e)
        {
            if (txtEditor.SelectionLength > 0)
            {
                txtEditor.Cut();
            }
        }

        private void CopyMenuItem_Click(object sender, EventArgs e)
        {
            if (txtEditor.SelectionLength > 0)
            {
                txtEditor.Copy();
            }
        }

        private void PasteMenuItem_Click(object sender, EventArgs e)
        {
            if (Clipboard.ContainsText())
            {
                txtEditor.Paste();
            }
        }

        private void DeleteMenuItem_Click(object sender, EventArgs e)
        {
            if (txtEditor.SelectionLength > 0)
            {
                txtEditor.SelectedText = string.Empty;
            }
        }

        private void FindMenuItem_Click(object sender, EventArgs e)
        {
            var query = PromptForInput("Find", "Text to find:");
            if (string.IsNullOrEmpty(query))
            {
                return;
            }

            if (!FindAndSelectText(query))
            {
                MessageBox.Show($"\"{query}\" was not found.", "Find", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void ReplaceMenuItem_Click(object sender, EventArgs e)
        {
            var findText = PromptForInput("Replace", "Text to find:");
            if (string.IsNullOrEmpty(findText))
            {
                return;
            }

            var replaceText = PromptForInput("Replace", "Replace with:", string.Empty);
            if (replaceText is null)
            {
                return;
            }

            if (!FindAndSelectText(findText))
            {
                MessageBox.Show($"\"{findText}\" was not found.", "Replace", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            txtEditor.SelectedText = replaceText;
        }

        private void GoToMenuItem_Click(object sender, EventArgs e)
        {
            if (txtEditor.Lines.Length == 0)
            {
                return;
            }

            var response = PromptForInput("Go To Line", "Line number:");
            if (string.IsNullOrWhiteSpace(response))
            {
                return;
            }

            if (!int.TryParse(response, out var lineNumber))
            {
                MessageBox.Show("Please enter a valid number.", "Go To Line", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            lineNumber = Math.Max(1, Math.Min(lineNumber, txtEditor.Lines.Length));
            var index = txtEditor.GetFirstCharIndexFromLine(lineNumber - 1);
            if (index >= 0)
            {
                txtEditor.SelectionStart = index;
                txtEditor.SelectionLength = 0;
                txtEditor.ScrollToCaret();
            }
        }

        private void SelectAllMenuItem_Click(object sender, EventArgs e)
        {
            txtEditor.SelectAll();
        }

        private void TimeDateMenuItem_Click(object sender, EventArgs e)
        {
            txtEditor.SelectedText = DateTime.Now.ToString("dd.MM.yyyy HH:mm");
        }

        private void WordWrapMenuItem_CheckedChanged(object sender, EventArgs e)
        {
            ApplyWordWrap();
        }

        private void FontMenuItem_Click(object sender, EventArgs e)
        {
            fontDialog.Font = txtEditor.Font;
            if (fontDialog.ShowDialog(this) == DialogResult.OK)
            {
                txtEditor.Font = fontDialog.Font;
            }
        }

        private void LightThemeMenuItem_Click(object sender, EventArgs e)
        {
            ApplyTheme(AppTheme.Light);
        }

        private void DarkThemeMenuItem_Click(object sender, EventArgs e)
        {
            ApplyTheme(AppTheme.Dark);
        }

        private void StatusBarMenuItem_CheckedChanged(object sender, EventArgs e)
        {
            statusStrip.Visible = statusBarToolStripMenuItem.Checked;
        }

        private void ZoomInMenuItem_Click(object sender, EventArgs e)
        {
            AdjustZoom(0.1f);
        }

        private void ZoomOutMenuItem_Click(object sender, EventArgs e)
        {
            AdjustZoom(-0.1f);
        }

        private void ResetZoomMenuItem_Click(object sender, EventArgs e)
        {
            ResetZoom();
        }

        private void AboutMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Modern Not Defteri\nC# WinForms ile geliştirilmiş hafif bir not tutma aracı.", "About Notepad", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void TxtEditor_TextChanged(object sender, EventArgs e)
        {
            if (_suppressTextChangedEvent)
            {
                return;
            }

            _isDirty = true;
            UpdateWindowTitle();
            UpdateStatusBar();
        }

        private void TxtEditor_SelectionChanged(object sender, EventArgs e)
        {
            UpdateStatusBar();
        }

        private void TxtEditor_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control && (e.KeyCode == Keys.Add || e.KeyCode == Keys.Oemplus))
            {
                AdjustZoom(0.1f);
                e.SuppressKeyPress = true;
            }
            else if (e.Control && (e.KeyCode == Keys.Subtract || e.KeyCode == Keys.OemMinus))
            {
                AdjustZoom(-0.1f);
                e.SuppressKeyPress = true;
            }
            else if (e.Control && e.KeyCode == Keys.D0)
            {
                ResetZoom();
                e.SuppressKeyPress = true;
            }
        }

        private void ApplyWordWrap()
        {
            txtEditor.WordWrap = wordWrapToolStripMenuItem.Checked;
            txtEditor.ScrollBars = wordWrapToolStripMenuItem.Checked
                ? RichTextBoxScrollBars.Vertical
                : RichTextBoxScrollBars.Both;
        }

        private void ApplyTheme(AppTheme theme)
        {
            _currentTheme = theme;
            lightThemeToolStripMenuItem.Checked = theme == AppTheme.Light;
            darkThemeToolStripMenuItem.Checked = theme == AppTheme.Dark;

            Color shellColor;
            Color menuColor;
            Color textColor;
            Color editorColor;

            if (theme == AppTheme.Dark)
            {
                shellColor = Color.FromArgb(32, 32, 32);
                menuColor = Color.FromArgb(45, 45, 48);
                textColor = Color.Gainsboro;
                editorColor = Color.FromArgb(18, 18, 18);
            }
            else
            {
                shellColor = Color.WhiteSmoke;
                menuColor = Color.White;
                textColor = Color.FromArgb(30, 30, 30);
                editorColor = Color.White;
            }

            BackColor = shellColor;
            menuStripMain.BackColor = menuColor;
            statusStrip.BackColor = menuColor;
            editorContextMenu.BackColor = menuColor;
            ForeColor = textColor;
            txtEditor.BackColor = editorColor;
            txtEditor.ForeColor = textColor;

            ApplyThemeToMenuItems(menuStripMain.Items, textColor);
            ApplyThemeToMenuItems(editorContextMenu.Items, textColor);
            foreach (ToolStripItem label in statusStrip.Items)
            {
                label.ForeColor = textColor;
            }
        }

        private static void ApplyThemeToMenuItems(ToolStripItemCollection items, Color foreColor)
        {
            foreach (ToolStripItem item in items)
            {
                item.ForeColor = foreColor;
                if (item is ToolStripMenuItem menuItem && menuItem.DropDownItems.Count > 0)
                {
                    ApplyThemeToMenuItems(menuItem.DropDownItems, foreColor);
                }
            }
        }

        private void AdjustZoom(float delta)
        {
            var newZoom = Math.Max(0.5f, Math.Min(4f, _zoomFactor + delta));
            _zoomFactor = newZoom;
            txtEditor.ZoomFactor = _zoomFactor;
            UpdateZoomStatus();
        }

        private void ResetZoom()
        {
            _zoomFactor = 1f;
            txtEditor.ZoomFactor = 1f;
            UpdateZoomStatus();
        }

        private void UpdateZoomStatus()
        {
            statusLabelZoom.Text = $"Zoom {(int)(_zoomFactor * 100)}%";
        }

        private void UpdateStatusBar()
        {
            statusLabelLength.Text = $"Chars: {txtEditor.TextLength}";

            var caretIndex = txtEditor.SelectionStart;
            var line = txtEditor.GetLineFromCharIndex(caretIndex) + 1;
            var column = caretIndex - txtEditor.GetFirstCharIndexOfCurrentLine() + 1;
            statusLabelPosition.Text = $"Ln {line}, Col {column}";
            UpdateZoomStatus();
        }

        private void UpdateWindowTitle()
        {
            var fileName = string.IsNullOrWhiteSpace(_currentFilePath)
                ? "Adsız"
                : Path.GetFileName(_currentFilePath);
            var dirtyMark = _isDirty ? "*" : string.Empty;
            Text = $"{dirtyMark}{fileName} - Modern Not Defteri";
        }

        private void SetEditorText(string text)
        {
            LoadEditorContent(() => txtEditor.Text = text);
        }

        private void LoadEditorContent(Action loader)
        {
            _suppressTextChangedEvent = true;
            try
            {
                loader();
            }
            finally
            {
                _suppressTextChangedEvent = false;
            }

            txtEditor.SelectionStart = 0;
            txtEditor.SelectionLength = 0;
            _isDirty = false;
            UpdateStatusBar();
        }

        private void OpenDocumentFromDisk()
        {
            if (!PromptSaveIfNeeded())
            {
                return;
            }

            if (openFileDialog.ShowDialog(this) != DialogResult.OK)
            {
                return;
            }

            try
            {
                var fileName = openFileDialog.FileName;
                var extension = Path.GetExtension(fileName).ToLowerInvariant();

                if (extension == ".rtf")
                {
                    LoadEditorContent(() => txtEditor.LoadFile(fileName, RichTextBoxStreamType.RichText));
                }
                else
                {
                    var content = File.ReadAllText(fileName, Encoding.UTF8);
                    LoadEditorContent(() => txtEditor.Text = content);
                }

                _currentFilePath = fileName;
                UpdateWindowTitle();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"We could not open the file.{Environment.NewLine}{ex.Message}", "Open File", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool SaveDocument(bool forceSaveAs = false)
        {
            if (forceSaveAs || string.IsNullOrWhiteSpace(_currentFilePath))
            {
                if (saveFileDialog.ShowDialog(this) != DialogResult.OK)
                {
                    return false;
                }

                _currentFilePath = saveFileDialog.FileName;
            }

            if (string.IsNullOrWhiteSpace(_currentFilePath))
            {
                return false;
            }

            try
            {
                var extension = Path.GetExtension(_currentFilePath).ToLowerInvariant();
                if (extension == ".rtf")
                {
                    txtEditor.SaveFile(_currentFilePath, RichTextBoxStreamType.RichText);
                }
                else
                {
                    File.WriteAllText(_currentFilePath, txtEditor.Text, Encoding.UTF8);
                }

                _isDirty = false;
                UpdateWindowTitle();
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Unable to save the file.{Environment.NewLine}{ex.Message}", "Save File", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        private bool PromptSaveIfNeeded()
        {
            if (!_isDirty)
            {
                return true;
            }

            var message = "Çalışmanız kaydedilmedi. Kaydetmek ister misiniz?";
            var result = MessageBox.Show(message, "Modern Not Defteri", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);

            return result switch
            {
                DialogResult.Yes => SaveDocument(),
                DialogResult.No => true,
                _ => false
            };
        }

        private bool FindAndSelectText(string textToFind)
        {
            var startIndex = txtEditor.SelectionStart + txtEditor.SelectionLength;
            var index = txtEditor.Find(textToFind, startIndex, RichTextBoxFinds.None);

            if (index < 0 && startIndex > 0)
            {
                index = txtEditor.Find(textToFind, 0, RichTextBoxFinds.None);
            }

            if (index >= 0)
            {
                txtEditor.Select(index, textToFind.Length);
                txtEditor.ScrollToCaret();
                return true;
            }

            return false;
        }

        private string? PromptForInput(string title, string message, string defaultValue = "")
        {
            using var prompt = new Form
            {
                Width = 420,
                Height = 170,
                FormBorderStyle = FormBorderStyle.FixedDialog,
                Text = title,
                StartPosition = FormStartPosition.CenterParent,
                MaximizeBox = false,
                MinimizeBox = false
            };

            var lblMessage = new Label
            {
                Left = 15,
                Top = 15,
                AutoSize = true,
                Text = message
            };

            var inputBox = new TextBox
            {
                Left = 15,
                Top = lblMessage.Bottom + 10,
                Width = 370,
                Text = defaultValue
            };

            var btnOk = new Button
            {
                Text = "OK",
                DialogResult = DialogResult.OK,
                Left = 190,
                Width = 90,
                Top = inputBox.Bottom + 15
            };

            var btnCancel = new Button
            {
                Text = "Cancel",
                DialogResult = DialogResult.Cancel,
                Left = btnOk.Right + 10,
                Width = 90,
                Top = inputBox.Bottom + 15
            };

            prompt.AcceptButton = btnOk;
            prompt.CancelButton = btnCancel;
            prompt.Controls.Add(lblMessage);
            prompt.Controls.Add(inputBox);
            prompt.Controls.Add(btnOk);
            prompt.Controls.Add(btnCancel);

            return prompt.ShowDialog(this) == DialogResult.OK ? inputBox.Text : null;
        }
    }
}
