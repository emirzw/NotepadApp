namespace NotepadApp
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.menuStripMain = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveAsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fileMenuSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.undoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.redoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editMenuSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.cutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.copyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pasteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editMenuSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.findToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.replaceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.goToToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editMenuSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.selectAllToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.timeDateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.formatToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.wordWrapToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fontToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.themeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lightThemeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.darkThemeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.zoomToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.zoomInToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.zoomOutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.resetZoomToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusBarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.statusLabelLength = new System.Windows.Forms.ToolStripStatusLabel();
            this.statusLabelPosition = new System.Windows.Forms.ToolStripStatusLabel();
            this.statusLabelZoom = new System.Windows.Forms.ToolStripStatusLabel();
            this.statusLabelEncoding = new System.Windows.Forms.ToolStripStatusLabel();
            this.txtEditor = new System.Windows.Forms.RichTextBox();
            this.editorContextMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.contextUndoMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextRedoMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editorContextSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.contextCutMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextCopyMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextPasteMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextDeleteMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editorContextSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.contextSelectAllMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextTimeDateMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.fontDialog = new System.Windows.Forms.FontDialog();
            this.menuStripMain.SuspendLayout();
            this.statusStrip.SuspendLayout();
            this.editorContextMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStripMain
            // 
            this.menuStripMain.BackColor = System.Drawing.Color.White;
            this.menuStripMain.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.menuStripMain.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStripMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.editToolStripMenuItem,
            this.formatToolStripMenuItem,
            this.viewToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStripMain.Location = new System.Drawing.Point(0, 0);
            this.menuStripMain.Name = "menuStripMain";
            this.menuStripMain.Padding = new System.Windows.Forms.Padding(7, 3, 0, 3);
            this.menuStripMain.Size = new System.Drawing.Size(984, 30);
            this.menuStripMain.TabIndex = 0;
            this.menuStripMain.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newToolStripMenuItem,
            this.openToolStripMenuItem,
            this.saveToolStripMenuItem,
            this.saveAsToolStripMenuItem,
            this.fileMenuSeparator1,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(45, 24);
            this.fileToolStripMenuItem.Text = "&File";
            // 
            // newToolStripMenuItem
            // 
            this.newToolStripMenuItem.Name = "newToolStripMenuItem";
            this.newToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.newToolStripMenuItem.Size = new System.Drawing.Size(221, 24);
            this.newToolStripMenuItem.Text = "&New";
            this.newToolStripMenuItem.Click += new System.EventHandler(this.FileNewMenuItem_Click);
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.openToolStripMenuItem.Size = new System.Drawing.Size(221, 24);
            this.openToolStripMenuItem.Text = "&Open...";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.OpenFileMenuItem_Click);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(221, 24);
            this.saveToolStripMenuItem.Text = "&Save";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.SaveFileMenuItem_Click);
            // 
            // saveAsToolStripMenuItem
            // 
            this.saveAsToolStripMenuItem.Name = "saveAsToolStripMenuItem";
            this.saveAsToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift | System.Windows.Forms.Keys.S)));
            this.saveAsToolStripMenuItem.Size = new System.Drawing.Size(221, 24);
            this.saveAsToolStripMenuItem.Text = "Save &As...";
            this.saveAsToolStripMenuItem.Click += new System.EventHandler(this.SaveAsMenuItem_Click);
            // 
            // fileMenuSeparator1
            // 
            this.fileMenuSeparator1.Margin = new System.Windows.Forms.Padding(0, 2, 0, 2);
            this.fileMenuSeparator1.Name = "fileMenuSeparator1";
            this.fileMenuSeparator1.Size = new System.Drawing.Size(218, 6);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Q)));
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(221, 24);
            this.exitToolStripMenuItem.Text = "E&xit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.ExitMenuItem_Click);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.undoToolStripMenuItem,
            this.redoToolStripMenuItem,
            this.editMenuSeparator1,
            this.cutToolStripMenuItem,
            this.copyToolStripMenuItem,
            this.pasteToolStripMenuItem,
            this.deleteToolStripMenuItem,
            this.editMenuSeparator2,
            this.findToolStripMenuItem,
            this.replaceToolStripMenuItem,
            this.goToToolStripMenuItem,
            this.editMenuSeparator3,
            this.selectAllToolStripMenuItem,
            this.timeDateToolStripMenuItem});
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(47, 24);
            this.editToolStripMenuItem.Text = "&Edit";
            // 
            // undoToolStripMenuItem
            // 
            this.undoToolStripMenuItem.Name = "undoToolStripMenuItem";
            this.undoToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Z)));
            this.undoToolStripMenuItem.Size = new System.Drawing.Size(202, 24);
            this.undoToolStripMenuItem.Text = "&Undo";
            this.undoToolStripMenuItem.Click += new System.EventHandler(this.UndoMenuItem_Click);
            // 
            // redoToolStripMenuItem
            // 
            this.redoToolStripMenuItem.Name = "redoToolStripMenuItem";
            this.redoToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Y)));
            this.redoToolStripMenuItem.Size = new System.Drawing.Size(202, 24);
            this.redoToolStripMenuItem.Text = "&Redo";
            this.redoToolStripMenuItem.Click += new System.EventHandler(this.RedoMenuItem_Click);
            // 
            // editMenuSeparator1
            // 
            this.editMenuSeparator1.Margin = new System.Windows.Forms.Padding(0, 2, 0, 2);
            this.editMenuSeparator1.Name = "editMenuSeparator1";
            this.editMenuSeparator1.Size = new System.Drawing.Size(199, 6);
            // 
            // cutToolStripMenuItem
            // 
            this.cutToolStripMenuItem.Name = "cutToolStripMenuItem";
            this.cutToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.X)));
            this.cutToolStripMenuItem.Size = new System.Drawing.Size(202, 24);
            this.cutToolStripMenuItem.Text = "Cu&t";
            this.cutToolStripMenuItem.Click += new System.EventHandler(this.CutMenuItem_Click);
            // 
            // copyToolStripMenuItem
            // 
            this.copyToolStripMenuItem.Name = "copyToolStripMenuItem";
            this.copyToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.C)));
            this.copyToolStripMenuItem.Size = new System.Drawing.Size(202, 24);
            this.copyToolStripMenuItem.Text = "&Copy";
            this.copyToolStripMenuItem.Click += new System.EventHandler(this.CopyMenuItem_Click);
            // 
            // pasteToolStripMenuItem
            // 
            this.pasteToolStripMenuItem.Name = "pasteToolStripMenuItem";
            this.pasteToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.V)));
            this.pasteToolStripMenuItem.Size = new System.Drawing.Size(202, 24);
            this.pasteToolStripMenuItem.Text = "&Paste";
            this.pasteToolStripMenuItem.Click += new System.EventHandler(this.PasteMenuItem_Click);
            // 
            // deleteToolStripMenuItem
            // 
            this.deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            this.deleteToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.Delete;
            this.deleteToolStripMenuItem.Size = new System.Drawing.Size(202, 24);
            this.deleteToolStripMenuItem.Text = "De&lete";
            this.deleteToolStripMenuItem.Click += new System.EventHandler(this.DeleteMenuItem_Click);
            // 
            // editMenuSeparator2
            // 
            this.editMenuSeparator2.Margin = new System.Windows.Forms.Padding(0, 2, 0, 2);
            this.editMenuSeparator2.Name = "editMenuSeparator2";
            this.editMenuSeparator2.Size = new System.Drawing.Size(199, 6);
            // 
            // findToolStripMenuItem
            // 
            this.findToolStripMenuItem.Name = "findToolStripMenuItem";
            this.findToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.F)));
            this.findToolStripMenuItem.Size = new System.Drawing.Size(202, 24);
            this.findToolStripMenuItem.Text = "&Find...";
            this.findToolStripMenuItem.Click += new System.EventHandler(this.FindMenuItem_Click);
            // 
            // replaceToolStripMenuItem
            // 
            this.replaceToolStripMenuItem.Name = "replaceToolStripMenuItem";
            this.replaceToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.H)));
            this.replaceToolStripMenuItem.Size = new System.Drawing.Size(202, 24);
            this.replaceToolStripMenuItem.Text = "Re&place...";
            this.replaceToolStripMenuItem.Click += new System.EventHandler(this.ReplaceMenuItem_Click);
            // 
            // goToToolStripMenuItem
            // 
            this.goToToolStripMenuItem.Name = "goToToolStripMenuItem";
            this.goToToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.G)));
            this.goToToolStripMenuItem.Size = new System.Drawing.Size(202, 24);
            this.goToToolStripMenuItem.Text = "&Go To...";
            this.goToToolStripMenuItem.Click += new System.EventHandler(this.GoToMenuItem_Click);
            // 
            // editMenuSeparator3
            // 
            this.editMenuSeparator3.Margin = new System.Windows.Forms.Padding(0, 2, 0, 2);
            this.editMenuSeparator3.Name = "editMenuSeparator3";
            this.editMenuSeparator3.Size = new System.Drawing.Size(199, 6);
            // 
            // selectAllToolStripMenuItem
            // 
            this.selectAllToolStripMenuItem.Name = "selectAllToolStripMenuItem";
            this.selectAllToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.A)));
            this.selectAllToolStripMenuItem.Size = new System.Drawing.Size(202, 24);
            this.selectAllToolStripMenuItem.Text = "Select &All";
            this.selectAllToolStripMenuItem.Click += new System.EventHandler(this.SelectAllMenuItem_Click);
            // 
            // timeDateToolStripMenuItem
            // 
            this.timeDateToolStripMenuItem.Name = "timeDateToolStripMenuItem";
            this.timeDateToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F5;
            this.timeDateToolStripMenuItem.Size = new System.Drawing.Size(202, 24);
            this.timeDateToolStripMenuItem.Text = "Time/&Date";
            this.timeDateToolStripMenuItem.Click += new System.EventHandler(this.TimeDateMenuItem_Click);
            // 
            // formatToolStripMenuItem
            // 
            this.formatToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.wordWrapToolStripMenuItem,
            this.fontToolStripMenuItem,
            this.themeToolStripMenuItem});
            this.formatToolStripMenuItem.Name = "formatToolStripMenuItem";
            this.formatToolStripMenuItem.Size = new System.Drawing.Size(68, 24);
            this.formatToolStripMenuItem.Text = "F&ormat";
            // 
            // wordWrapToolStripMenuItem
            // 
            this.wordWrapToolStripMenuItem.Checked = true;
            this.wordWrapToolStripMenuItem.CheckOnClick = true;
            this.wordWrapToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.wordWrapToolStripMenuItem.Name = "wordWrapToolStripMenuItem";
            this.wordWrapToolStripMenuItem.Size = new System.Drawing.Size(211, 24);
            this.wordWrapToolStripMenuItem.Text = "&Word Wrap";
            this.wordWrapToolStripMenuItem.CheckedChanged += new System.EventHandler(this.WordWrapMenuItem_CheckedChanged);
            // 
            // fontToolStripMenuItem
            // 
            this.fontToolStripMenuItem.Name = "fontToolStripMenuItem";
            this.fontToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift | System.Windows.Forms.Keys.F)));
            this.fontToolStripMenuItem.Size = new System.Drawing.Size(211, 24);
            this.fontToolStripMenuItem.Text = "&Font...";
            this.fontToolStripMenuItem.Click += new System.EventHandler(this.FontMenuItem_Click);
            // 
            // themeToolStripMenuItem
            // 
            this.themeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lightThemeToolStripMenuItem,
            this.darkThemeToolStripMenuItem});
            this.themeToolStripMenuItem.Name = "themeToolStripMenuItem";
            this.themeToolStripMenuItem.Size = new System.Drawing.Size(211, 24);
            this.themeToolStripMenuItem.Text = "App &Theme";
            // 
            // lightThemeToolStripMenuItem
            // 
            this.lightThemeToolStripMenuItem.Checked = true;
            this.lightThemeToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.lightThemeToolStripMenuItem.Name = "lightThemeToolStripMenuItem";
            this.lightThemeToolStripMenuItem.Size = new System.Drawing.Size(158, 24);
            this.lightThemeToolStripMenuItem.Text = "&Light";
            this.lightThemeToolStripMenuItem.Click += new System.EventHandler(this.LightThemeMenuItem_Click);
            // 
            // darkThemeToolStripMenuItem
            // 
            this.darkThemeToolStripMenuItem.Name = "darkThemeToolStripMenuItem";
            this.darkThemeToolStripMenuItem.Size = new System.Drawing.Size(158, 24);
            this.darkThemeToolStripMenuItem.Text = "&Dark";
            this.darkThemeToolStripMenuItem.Click += new System.EventHandler(this.DarkThemeMenuItem_Click);
            // 
            // viewToolStripMenuItem
            // 
            this.viewToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.zoomToolStripMenuItem,
            this.statusBarToolStripMenuItem});
            this.viewToolStripMenuItem.Name = "viewToolStripMenuItem";
            this.viewToolStripMenuItem.Size = new System.Drawing.Size(51, 24);
            this.viewToolStripMenuItem.Text = "&View";
            // 
            // zoomToolStripMenuItem
            // 
            this.zoomToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.zoomInToolStripMenuItem,
            this.zoomOutToolStripMenuItem,
            this.resetZoomToolStripMenuItem});
            this.zoomToolStripMenuItem.Name = "zoomToolStripMenuItem";
            this.zoomToolStripMenuItem.Size = new System.Drawing.Size(150, 24);
            this.zoomToolStripMenuItem.Text = "&Zoom";
            // 
            // zoomInToolStripMenuItem
            // 
            this.zoomInToolStripMenuItem.Name = "zoomInToolStripMenuItem";
            this.zoomInToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Oemplus)));
            this.zoomInToolStripMenuItem.Size = new System.Drawing.Size(208, 24);
            this.zoomInToolStripMenuItem.Text = "Zoom &In";
            this.zoomInToolStripMenuItem.Click += new System.EventHandler(this.ZoomInMenuItem_Click);
            // 
            // zoomOutToolStripMenuItem
            // 
            this.zoomOutToolStripMenuItem.Name = "zoomOutToolStripMenuItem";
            this.zoomOutToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.OemMinus)));
            this.zoomOutToolStripMenuItem.Size = new System.Drawing.Size(208, 24);
            this.zoomOutToolStripMenuItem.Text = "Zoom &Out";
            this.zoomOutToolStripMenuItem.Click += new System.EventHandler(this.ZoomOutMenuItem_Click);
            // 
            // resetZoomToolStripMenuItem
            // 
            this.resetZoomToolStripMenuItem.Name = "resetZoomToolStripMenuItem";
            this.resetZoomToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.D0)));
            this.resetZoomToolStripMenuItem.Size = new System.Drawing.Size(208, 24);
            this.resetZoomToolStripMenuItem.Text = "&Reset";
            this.resetZoomToolStripMenuItem.Click += new System.EventHandler(this.ResetZoomMenuItem_Click);
            // 
            // statusBarToolStripMenuItem
            // 
            this.statusBarToolStripMenuItem.Checked = true;
            this.statusBarToolStripMenuItem.CheckOnClick = true;
            this.statusBarToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.statusBarToolStripMenuItem.Name = "statusBarToolStripMenuItem";
            this.statusBarToolStripMenuItem.Size = new System.Drawing.Size(150, 24);
            this.statusBarToolStripMenuItem.Text = "&Status Bar";
            this.statusBarToolStripMenuItem.CheckedChanged += new System.EventHandler(this.StatusBarMenuItem_CheckedChanged);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(52, 24);
            this.helpToolStripMenuItem.Text = "&Help";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F1;
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(143, 24);
            this.aboutToolStripMenuItem.Text = "&About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.AboutMenuItem_Click);
            // 
            // statusStrip
            // 
            this.statusStrip.BackColor = System.Drawing.Color.White;
            this.statusStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.statusLabelLength,
            this.statusLabelPosition,
            this.statusLabelZoom,
            this.statusLabelEncoding});
            this.statusStrip.Location = new System.Drawing.Point(0, 539);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Padding = new System.Windows.Forms.Padding(1, 0, 16, 0);
            this.statusStrip.Size = new System.Drawing.Size(984, 22);
            this.statusStrip.SizingGrip = false;
            this.statusStrip.TabIndex = 2;
            this.statusStrip.Text = "statusStrip1";
            // 
            // statusLabelLength
            // 
            this.statusLabelLength.Name = "statusLabelLength";
            this.statusLabelLength.Size = new System.Drawing.Size(76, 17);
            this.statusLabelLength.Text = "Chars: 0";
            // 
            // statusLabelPosition
            // 
            this.statusLabelPosition.Margin = new System.Windows.Forms.Padding(10, 3, 0, 2);
            this.statusLabelPosition.Name = "statusLabelPosition";
            this.statusLabelPosition.Size = new System.Drawing.Size(102, 17);
            this.statusLabelPosition.Text = "Ln 1, Col 1";
            // 
            // statusLabelZoom
            // 
            this.statusLabelZoom.Margin = new System.Windows.Forms.Padding(10, 3, 0, 2);
            this.statusLabelZoom.Name = "statusLabelZoom";
            this.statusLabelZoom.Size = new System.Drawing.Size(86, 17);
            this.statusLabelZoom.Text = "Zoom 100%";
            // 
            // statusLabelEncoding
            // 
            this.statusLabelEncoding.Margin = new System.Windows.Forms.Padding(10, 3, 0, 2);
            this.statusLabelEncoding.Name = "statusLabelEncoding";
            this.statusLabelEncoding.Size = new System.Drawing.Size(60, 17);
            this.statusLabelEncoding.Text = "UTF-8";
            // 
            // txtEditor
            // 
            this.txtEditor.AcceptsTab = true;
            this.txtEditor.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtEditor.ContextMenuStrip = this.editorContextMenu;
            this.txtEditor.DetectUrls = true;
            this.txtEditor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtEditor.Font = new System.Drawing.Font("Consolas", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtEditor.HideSelection = false;
            this.txtEditor.Location = new System.Drawing.Point(0, 30);
            this.txtEditor.Name = "txtEditor";
            this.txtEditor.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.txtEditor.Size = new System.Drawing.Size(984, 509);
            this.txtEditor.TabIndex = 1;
            this.txtEditor.Text = "";
            this.txtEditor.SelectionChanged += new System.EventHandler(this.TxtEditor_SelectionChanged);
            this.txtEditor.TextChanged += new System.EventHandler(this.TxtEditor_TextChanged);
            this.txtEditor.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TxtEditor_KeyDown);
            // 
            // editorContextMenu
            // 
            this.editorContextMenu.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.editorContextMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.contextUndoMenuItem,
            this.contextRedoMenuItem,
            this.editorContextSeparator1,
            this.contextCutMenuItem,
            this.contextCopyMenuItem,
            this.contextPasteMenuItem,
            this.contextDeleteMenuItem,
            this.editorContextSeparator2,
            this.contextSelectAllMenuItem,
            this.contextTimeDateMenuItem});
            this.editorContextMenu.Name = "editorContextMenu";
            this.editorContextMenu.Size = new System.Drawing.Size(152, 192);
            // 
            // contextUndoMenuItem
            // 
            this.contextUndoMenuItem.Name = "contextUndoMenuItem";
            this.contextUndoMenuItem.Size = new System.Drawing.Size(151, 22);
            this.contextUndoMenuItem.Text = "Undo";
            this.contextUndoMenuItem.Click += new System.EventHandler(this.UndoMenuItem_Click);
            // 
            // contextRedoMenuItem
            // 
            this.contextRedoMenuItem.Name = "contextRedoMenuItem";
            this.contextRedoMenuItem.Size = new System.Drawing.Size(151, 22);
            this.contextRedoMenuItem.Text = "Redo";
            this.contextRedoMenuItem.Click += new System.EventHandler(this.RedoMenuItem_Click);
            // 
            // editorContextSeparator1
            // 
            this.editorContextSeparator1.Name = "editorContextSeparator1";
            this.editorContextSeparator1.Size = new System.Drawing.Size(148, 6);
            // 
            // contextCutMenuItem
            // 
            this.contextCutMenuItem.Name = "contextCutMenuItem";
            this.contextCutMenuItem.Size = new System.Drawing.Size(151, 22);
            this.contextCutMenuItem.Text = "Cut";
            this.contextCutMenuItem.Click += new System.EventHandler(this.CutMenuItem_Click);
            // 
            // contextCopyMenuItem
            // 
            this.contextCopyMenuItem.Name = "contextCopyMenuItem";
            this.contextCopyMenuItem.Size = new System.Drawing.Size(151, 22);
            this.contextCopyMenuItem.Text = "Copy";
            this.contextCopyMenuItem.Click += new System.EventHandler(this.CopyMenuItem_Click);
            // 
            // contextPasteMenuItem
            // 
            this.contextPasteMenuItem.Name = "contextPasteMenuItem";
            this.contextPasteMenuItem.Size = new System.Drawing.Size(151, 22);
            this.contextPasteMenuItem.Text = "Paste";
            this.contextPasteMenuItem.Click += new System.EventHandler(this.PasteMenuItem_Click);
            // 
            // contextDeleteMenuItem
            // 
            this.contextDeleteMenuItem.Name = "contextDeleteMenuItem";
            this.contextDeleteMenuItem.Size = new System.Drawing.Size(151, 22);
            this.contextDeleteMenuItem.Text = "Delete";
            this.contextDeleteMenuItem.Click += new System.EventHandler(this.DeleteMenuItem_Click);
            // 
            // editorContextSeparator2
            // 
            this.editorContextSeparator2.Name = "editorContextSeparator2";
            this.editorContextSeparator2.Size = new System.Drawing.Size(148, 6);
            // 
            // contextSelectAllMenuItem
            // 
            this.contextSelectAllMenuItem.Name = "contextSelectAllMenuItem";
            this.contextSelectAllMenuItem.Size = new System.Drawing.Size(151, 22);
            this.contextSelectAllMenuItem.Text = "Select All";
            this.contextSelectAllMenuItem.Click += new System.EventHandler(this.SelectAllMenuItem_Click);
            // 
            // contextTimeDateMenuItem
            // 
            this.contextTimeDateMenuItem.Name = "contextTimeDateMenuItem";
            this.contextTimeDateMenuItem.Size = new System.Drawing.Size(151, 22);
            this.contextTimeDateMenuItem.Text = "Time/Date";
            this.contextTimeDateMenuItem.Click += new System.EventHandler(this.TimeDateMenuItem_Click);
            // 
            // openFileDialog
            // 
            this.openFileDialog.DefaultExt = "txt";
            this.openFileDialog.Filter = "Text Documents (*.txt)|*.txt|Rich Text Format (*.rtf)|*.rtf|All Files (*.*)|*.*";
            this.openFileDialog.Title = "Open document";
            // 
            // saveFileDialog
            // 
            this.saveFileDialog.DefaultExt = "txt";
            this.saveFileDialog.Filter = "Text Documents (*.txt)|*.txt|Rich Text Format (*.rtf)|*.rtf|All Files (*.*)|*.*";
            this.saveFileDialog.Title = "Save document";
            // 
            // fontDialog
            // 
            this.fontDialog.AllowScriptChange = false;
            this.fontDialog.ShowColor = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(984, 561);
            this.Controls.Add(this.txtEditor);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.menuStripMain);
            this.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.MainMenuStrip = this.menuStripMain;
            this.MinimumSize = new System.Drawing.Size(780, 520);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Modern Not Defteri";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStripMain.ResumeLayout(false);
            this.menuStripMain.PerformLayout();
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.editorContextMenu.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStripMain;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveAsToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator fileMenuSeparator1;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem undoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem redoToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator editMenuSeparator1;
        private System.Windows.Forms.ToolStripMenuItem cutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem copyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pasteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator editMenuSeparator2;
        private System.Windows.Forms.ToolStripMenuItem findToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem replaceToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem goToToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator editMenuSeparator3;
        private System.Windows.Forms.ToolStripMenuItem selectAllToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem timeDateToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem formatToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem wordWrapToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fontToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem themeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem lightThemeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem darkThemeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem zoomToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem zoomInToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem zoomOutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem resetZoomToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem statusBarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStripStatusLabel statusLabelLength;
        private System.Windows.Forms.ToolStripStatusLabel statusLabelPosition;
        private System.Windows.Forms.ToolStripStatusLabel statusLabelZoom;
        private System.Windows.Forms.ToolStripStatusLabel statusLabelEncoding;
        private System.Windows.Forms.RichTextBox txtEditor;
        private System.Windows.Forms.ContextMenuStrip editorContextMenu;
        private System.Windows.Forms.ToolStripMenuItem contextUndoMenuItem;
        private System.Windows.Forms.ToolStripMenuItem contextRedoMenuItem;
        private System.Windows.Forms.ToolStripSeparator editorContextSeparator1;
        private System.Windows.Forms.ToolStripMenuItem contextCutMenuItem;
        private System.Windows.Forms.ToolStripMenuItem contextCopyMenuItem;
        private System.Windows.Forms.ToolStripMenuItem contextPasteMenuItem;
        private System.Windows.Forms.ToolStripMenuItem contextDeleteMenuItem;
        private System.Windows.Forms.ToolStripSeparator editorContextSeparator2;
        private System.Windows.Forms.ToolStripMenuItem contextSelectAllMenuItem;
        private System.Windows.Forms.ToolStripMenuItem contextTimeDateMenuItem;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.SaveFileDialog saveFileDialog;
        private System.Windows.Forms.FontDialog fontDialog;
    }
}
