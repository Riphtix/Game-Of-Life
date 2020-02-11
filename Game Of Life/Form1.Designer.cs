﻿namespace Game_Of_Life {
	partial class Form1 {
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing) {
			if (disposing && (components != null)) {
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent() {
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
			this.menuStrip1                      = new System.Windows.Forms.MenuStrip();
			this.fileToolStripMenuItem           = new System.Windows.Forms.ToolStripMenuItem();
			this.newToolStripMenuItem            = new System.Windows.Forms.ToolStripMenuItem();
			this.openToolStripMenuItem           = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripSeparator              = new System.Windows.Forms.ToolStripSeparator();
			this.saveToolStripMenuItem           = new System.Windows.Forms.ToolStripMenuItem();
			this.saveAsToolStripMenuItem         = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripSeparator1             = new System.Windows.Forms.ToolStripSeparator();
			this.printToolStripMenuItem          = new System.Windows.Forms.ToolStripMenuItem();
			this.printPreviewToolStripMenuItem   = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripSeparator2             = new System.Windows.Forms.ToolStripSeparator();
			this.exitToolStripMenuItem           = new System.Windows.Forms.ToolStripMenuItem();
			this.toolsToolStripMenuItem          = new System.Windows.Forms.ToolStripMenuItem();
			this.customizeToolStripMenuItem      = new System.Windows.Forms.ToolStripMenuItem();
			this.themesToolStripMenuItem         = new System.Windows.Forms.ToolStripMenuItem();
			this.darkToolStripMenuItem           = new System.Windows.Forms.ToolStripMenuItem();
			this.lightToolStripMenuItem          = new System.Windows.Forms.ToolStripMenuItem();
			this.optionsToolStripMenuItem        = new System.Windows.Forms.ToolStripMenuItem();
			this.helpToolStripMenuItem           = new System.Windows.Forms.ToolStripMenuItem();
			this.contentsToolStripMenuItem       = new System.Windows.Forms.ToolStripMenuItem();
			this.indexToolStripMenuItem          = new System.Windows.Forms.ToolStripMenuItem();
			this.searchToolStripMenuItem         = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripSeparator5             = new System.Windows.Forms.ToolStripSeparator();
			this.aboutToolStripMenuItem          = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStrip1                      = new System.Windows.Forms.ToolStrip();
			this.newToolStripButton              = new System.Windows.Forms.ToolStripButton();
			this.openToolStripButton             = new System.Windows.Forms.ToolStripButton();
			this.saveToolStripButton             = new System.Windows.Forms.ToolStripButton();
			this.toolStripSeparator6             = new System.Windows.Forms.ToolStripSeparator();
			this.cutToolStripButton              = new System.Windows.Forms.ToolStripButton();
			this.copyToolStripButton             = new System.Windows.Forms.ToolStripButton();
			this.pasteToolStripButton            = new System.Windows.Forms.ToolStripButton();
			this.toolStripSeparator7             = new System.Windows.Forms.ToolStripSeparator();
			this.helpToolStripButton             = new System.Windows.Forms.ToolStripButton();
			this.startButton                     = new System.Windows.Forms.ToolStripButton();
			this.pauseButton                     = new System.Windows.Forms.ToolStripButton();
			this.stepButton                      = new System.Windows.Forms.ToolStripButton();
			this.seeNeighborCountToggle          = new System.Windows.Forms.ToolStripButton();
			this.statusStrip1                    = new System.Windows.Forms.StatusStrip();
			this.toolStripStatusLabelGenerations = new System.Windows.Forms.ToolStripStatusLabel();
			this.toolStripStatusLabel1           = new System.Windows.Forms.ToolStripStatusLabel();
			this.toolStripStatusLabelGridSize    = new System.Windows.Forms.ToolStripStatusLabel();
			this.graphicsPanel1                  = new Game_Of_Life.GraphicsPanel();
			this.menuStrip1.SuspendLayout();
			this.toolStrip1.SuspendLayout();
			this.statusStrip1.SuspendLayout();
			this.SuspendLayout();
			// 
			// menuStrip1
			// 
			this.menuStrip1.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (64)))), ((int) (((byte) (64)))), ((int) (((byte) (64)))));
			this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {this.fileToolStripMenuItem, this.toolsToolStripMenuItem, this.helpToolStripMenuItem});
			this.menuStrip1.Location = new System.Drawing.Point(0, 0);
			this.menuStrip1.Name     = "menuStrip1";
			this.menuStrip1.Padding  = new System.Windows.Forms.Padding(7, 2, 0, 2);
			this.menuStrip1.Size     = new System.Drawing.Size(668, 24);
			this.menuStrip1.TabIndex = 0;
			this.menuStrip1.Text     = "menuStrip1";
			// 
			// fileToolStripMenuItem
			// 
			this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
																										   this.newToolStripMenuItem, this.openToolStripMenuItem,
																										   this.toolStripSeparator, this.saveToolStripMenuItem,
																										   this.saveAsToolStripMenuItem, this.toolStripSeparator1,
																										   this.printToolStripMenuItem,
																										   this.printPreviewToolStripMenuItem, this.toolStripSeparator2,
																										   this.exitToolStripMenuItem
																									   });
			this.fileToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int) (((byte) (224)))), ((int) (((byte) (224)))), ((int) (((byte) (224)))));
			this.fileToolStripMenuItem.Name      = "fileToolStripMenuItem";
			this.fileToolStripMenuItem.Size      = new System.Drawing.Size(37, 20);
			this.fileToolStripMenuItem.Text      = "&File";
			// 
			// newToolStripMenuItem
			// 
			this.newToolStripMenuItem.Image                 =  ((System.Drawing.Image) (resources.GetObject("newToolStripMenuItem.Image")));
			this.newToolStripMenuItem.ImageTransparentColor =  System.Drawing.Color.Magenta;
			this.newToolStripMenuItem.Name                  =  "newToolStripMenuItem";
			this.newToolStripMenuItem.ShortcutKeys          =  ((System.Windows.Forms.Keys) ((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
			this.newToolStripMenuItem.Size                  =  new System.Drawing.Size(146, 22);
			this.newToolStripMenuItem.Text                  =  "&New";
			this.newToolStripMenuItem.Click                 += new System.EventHandler(this.newToolStripMenuItem_Click);
			// 
			// openToolStripMenuItem
			// 
			this.openToolStripMenuItem.Image                 =  ((System.Drawing.Image) (resources.GetObject("openToolStripMenuItem.Image")));
			this.openToolStripMenuItem.ImageTransparentColor =  System.Drawing.Color.Magenta;
			this.openToolStripMenuItem.Name                  =  "openToolStripMenuItem";
			this.openToolStripMenuItem.ShortcutKeys          =  ((System.Windows.Forms.Keys) ((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
			this.openToolStripMenuItem.Size                  =  new System.Drawing.Size(146, 22);
			this.openToolStripMenuItem.Text                  =  "&Open";
			this.openToolStripMenuItem.Click                 += new System.EventHandler(this.openToolStripButton_Click);
			// 
			// toolStripSeparator
			// 
			this.toolStripSeparator.Name = "toolStripSeparator";
			this.toolStripSeparator.Size = new System.Drawing.Size(143, 6);
			// 
			// saveToolStripMenuItem
			// 
			this.saveToolStripMenuItem.Image                 =  ((System.Drawing.Image) (resources.GetObject("saveToolStripMenuItem.Image")));
			this.saveToolStripMenuItem.ImageTransparentColor =  System.Drawing.Color.Magenta;
			this.saveToolStripMenuItem.Name                  =  "saveToolStripMenuItem";
			this.saveToolStripMenuItem.ShortcutKeys          =  ((System.Windows.Forms.Keys) ((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
			this.saveToolStripMenuItem.Size                  =  new System.Drawing.Size(146, 22);
			this.saveToolStripMenuItem.Text                  =  "&Save";
			this.saveToolStripMenuItem.Click                 += new System.EventHandler(this.saveToolStripButton_Click);
			// 
			// saveAsToolStripMenuItem
			// 
			this.saveAsToolStripMenuItem.Name  =  "saveAsToolStripMenuItem";
			this.saveAsToolStripMenuItem.Size  =  new System.Drawing.Size(146, 22);
			this.saveAsToolStripMenuItem.Text  =  "Save &As";
			this.saveAsToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripButton_Click);
			// 
			// toolStripSeparator1
			// 
			this.toolStripSeparator1.Name = "toolStripSeparator1";
			this.toolStripSeparator1.Size = new System.Drawing.Size(143, 6);
			// 
			// printToolStripMenuItem
			// 
			this.printToolStripMenuItem.Image                 = ((System.Drawing.Image) (resources.GetObject("printToolStripMenuItem.Image")));
			this.printToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.printToolStripMenuItem.Name                  = "printToolStripMenuItem";
			this.printToolStripMenuItem.ShortcutKeys          = ((System.Windows.Forms.Keys) ((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.P)));
			this.printToolStripMenuItem.Size                  = new System.Drawing.Size(146, 22);
			this.printToolStripMenuItem.Text                  = "&Print";
			// 
			// printPreviewToolStripMenuItem
			// 
			this.printPreviewToolStripMenuItem.Image                 = ((System.Drawing.Image) (resources.GetObject("printPreviewToolStripMenuItem.Image")));
			this.printPreviewToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.printPreviewToolStripMenuItem.Name                  = "printPreviewToolStripMenuItem";
			this.printPreviewToolStripMenuItem.Size                  = new System.Drawing.Size(146, 22);
			this.printPreviewToolStripMenuItem.Text                  = "Print Pre&view";
			// 
			// toolStripSeparator2
			// 
			this.toolStripSeparator2.Name = "toolStripSeparator2";
			this.toolStripSeparator2.Size = new System.Drawing.Size(143, 6);
			// 
			// exitToolStripMenuItem
			// 
			this.exitToolStripMenuItem.Name  =  "exitToolStripMenuItem";
			this.exitToolStripMenuItem.Size  =  new System.Drawing.Size(146, 22);
			this.exitToolStripMenuItem.Text  =  "E&xit";
			this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
			// 
			// toolsToolStripMenuItem
			// 
			this.toolsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {this.customizeToolStripMenuItem, this.optionsToolStripMenuItem});
			this.toolsToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int) (((byte) (224)))), ((int) (((byte) (224)))), ((int) (((byte) (224)))));
			this.toolsToolStripMenuItem.Name      = "toolsToolStripMenuItem";
			this.toolsToolStripMenuItem.Size      = new System.Drawing.Size(46, 20);
			this.toolsToolStripMenuItem.Text      = "&Tools";
			// 
			// customizeToolStripMenuItem
			// 
			this.customizeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {this.themesToolStripMenuItem});
			this.customizeToolStripMenuItem.Name = "customizeToolStripMenuItem";
			this.customizeToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
			this.customizeToolStripMenuItem.Text = "&Customize";
			// 
			// themesToolStripMenuItem
			// 
			this.themesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {this.darkToolStripMenuItem, this.lightToolStripMenuItem});
			this.themesToolStripMenuItem.Name = "themesToolStripMenuItem";
			this.themesToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
			this.themesToolStripMenuItem.Text = "Themes";
			// 
			// darkToolStripMenuItem
			// 
			this.darkToolStripMenuItem.Name  =  "darkToolStripMenuItem";
			this.darkToolStripMenuItem.Size  =  new System.Drawing.Size(152, 22);
			this.darkToolStripMenuItem.Text  =  "Dark";
			this.darkToolStripMenuItem.Click += new System.EventHandler(this.darkModeToolStripMenuItem_Click);
			// 
			// lightToolStripMenuItem
			// 
			this.lightToolStripMenuItem.Name  =  "lightToolStripMenuItem";
			this.lightToolStripMenuItem.Size  =  new System.Drawing.Size(152, 22);
			this.lightToolStripMenuItem.Text  =  "Light";
			this.lightToolStripMenuItem.Click += new System.EventHandler(this.lightModeToolStripMenuItem_Click);
			// 
			// optionsToolStripMenuItem
			// 
			this.optionsToolStripMenuItem.Name = "optionsToolStripMenuItem";
			this.optionsToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
			this.optionsToolStripMenuItem.Text = "&Options";
			// 
			// helpToolStripMenuItem
			// 
			this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
																										   this.contentsToolStripMenuItem, this.indexToolStripMenuItem,
																										   this.searchToolStripMenuItem,
																										   this.toolStripSeparator5, this.aboutToolStripMenuItem
																									   });
			this.helpToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int) (((byte) (224)))), ((int) (((byte) (224)))), ((int) (((byte) (224)))));
			this.helpToolStripMenuItem.Name      = "helpToolStripMenuItem";
			this.helpToolStripMenuItem.Size      = new System.Drawing.Size(44, 20);
			this.helpToolStripMenuItem.Text      = "&Help";
			// 
			// contentsToolStripMenuItem
			// 
			this.contentsToolStripMenuItem.Name = "contentsToolStripMenuItem";
			this.contentsToolStripMenuItem.Size = new System.Drawing.Size(122, 22);
			this.contentsToolStripMenuItem.Text = "&Contents";
			// 
			// indexToolStripMenuItem
			// 
			this.indexToolStripMenuItem.Name = "indexToolStripMenuItem";
			this.indexToolStripMenuItem.Size = new System.Drawing.Size(122, 22);
			this.indexToolStripMenuItem.Text = "&Index";
			// 
			// searchToolStripMenuItem
			// 
			this.searchToolStripMenuItem.Name = "searchToolStripMenuItem";
			this.searchToolStripMenuItem.Size = new System.Drawing.Size(122, 22);
			this.searchToolStripMenuItem.Text = "&Search";
			// 
			// toolStripSeparator5
			// 
			this.toolStripSeparator5.Name = "toolStripSeparator5";
			this.toolStripSeparator5.Size = new System.Drawing.Size(119, 6);
			// 
			// aboutToolStripMenuItem
			// 
			this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
			this.aboutToolStripMenuItem.Size = new System.Drawing.Size(122, 22);
			this.aboutToolStripMenuItem.Text = "&About...";
			// 
			// toolStrip1
			// 
			this.toolStrip1.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (75)))), ((int) (((byte) (75)))), ((int) (((byte) (75)))));
			this.toolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
			this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
																						this.newToolStripButton, this.openToolStripButton, this.saveToolStripButton,
																						this.toolStripSeparator6, this.cutToolStripButton,
																						this.copyToolStripButton, this.pasteToolStripButton, this.toolStripSeparator7,
																						this.helpToolStripButton, this.startButton,
																						this.pauseButton, this.stepButton, this.seeNeighborCountToggle
																					});
			this.toolStrip1.Location   = new System.Drawing.Point(0, 24);
			this.toolStrip1.Name       = "toolStrip1";
			this.toolStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
			this.toolStrip1.Size       = new System.Drawing.Size(668, 25);
			this.toolStrip1.TabIndex   = 1;
			this.toolStrip1.Text       = "toolStrip1";
			// 
			// newToolStripButton
			// 
			this.newToolStripButton.DisplayStyle          =  System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.newToolStripButton.Image                 =  global::Game_Of_Life.Properties.Resources.ic_insert_drive_file_white_24dp;
			this.newToolStripButton.ImageTransparentColor =  System.Drawing.Color.Magenta;
			this.newToolStripButton.Name                  =  "newToolStripButton";
			this.newToolStripButton.Size                  =  new System.Drawing.Size(23, 22);
			this.newToolStripButton.Text                  =  "&New";
			this.newToolStripButton.Click                 += new System.EventHandler(this.newToolStripMenuItem_Click);
			// 
			// openToolStripButton
			// 
			this.openToolStripButton.DisplayStyle          =  System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.openToolStripButton.Image                 =  global::Game_Of_Life.Properties.Resources.ic_create_new_folder_white_24dp;
			this.openToolStripButton.ImageTransparentColor =  System.Drawing.Color.Magenta;
			this.openToolStripButton.Name                  =  "openToolStripButton";
			this.openToolStripButton.Size                  =  new System.Drawing.Size(23, 22);
			this.openToolStripButton.Text                  =  "&Open";
			this.openToolStripButton.Click                 += new System.EventHandler(this.openToolStripButton_Click);
			// 
			// saveToolStripButton
			// 
			this.saveToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.saveToolStripButton.Font =
				new System.Drawing.Font("Fira Code", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
			this.saveToolStripButton.Image                 =  global::Game_Of_Life.Properties.Resources.ic_save_white_24dp;
			this.saveToolStripButton.ImageTransparentColor =  System.Drawing.Color.Magenta;
			this.saveToolStripButton.Name                  =  "saveToolStripButton";
			this.saveToolStripButton.Size                  =  new System.Drawing.Size(23, 22);
			this.saveToolStripButton.Text                  =  "&Save";
			this.saveToolStripButton.Click                 += new System.EventHandler(this.saveToolStripButton_Click);
			// 
			// toolStripSeparator6
			// 
			this.toolStripSeparator6.BackColor = System.Drawing.SystemColors.ControlDarkDark;
			this.toolStripSeparator6.Name      = "toolStripSeparator6";
			this.toolStripSeparator6.Size      = new System.Drawing.Size(6, 25);
			// 
			// cutToolStripButton
			// 
			this.cutToolStripButton.DisplayStyle          = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.cutToolStripButton.Image                 = global::Game_Of_Life.Properties.Resources.ic_content_cut_white_24dp;
			this.cutToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.cutToolStripButton.Name                  = "cutToolStripButton";
			this.cutToolStripButton.Size                  = new System.Drawing.Size(23, 22);
			this.cutToolStripButton.Text                  = "C&ut";
			// 
			// copyToolStripButton
			// 
			this.copyToolStripButton.DisplayStyle          = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.copyToolStripButton.Image                 = global::Game_Of_Life.Properties.Resources.ic_content_copy_white_24dp;
			this.copyToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.copyToolStripButton.Name                  = "copyToolStripButton";
			this.copyToolStripButton.Size                  = new System.Drawing.Size(23, 22);
			this.copyToolStripButton.Text                  = "&Copy";
			// 
			// pasteToolStripButton
			// 
			this.pasteToolStripButton.DisplayStyle          = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.pasteToolStripButton.Image                 = global::Game_Of_Life.Properties.Resources.ic_content_paste_white_24dp;
			this.pasteToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.pasteToolStripButton.Name                  = "pasteToolStripButton";
			this.pasteToolStripButton.Size                  = new System.Drawing.Size(23, 22);
			this.pasteToolStripButton.Text                  = "&Paste";
			// 
			// toolStripSeparator7
			// 
			this.toolStripSeparator7.Name = "toolStripSeparator7";
			this.toolStripSeparator7.Size = new System.Drawing.Size(6, 25);
			// 
			// helpToolStripButton
			// 
			this.helpToolStripButton.DisplayStyle          = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.helpToolStripButton.Image                 = global::Game_Of_Life.Properties.Resources.ic_info_outline_white_24dp;
			this.helpToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.helpToolStripButton.Name                  = "helpToolStripButton";
			this.helpToolStripButton.Size                  = new System.Drawing.Size(23, 22);
			this.helpToolStripButton.Text                  = "He&lp";
			// 
			// startButton
			// 
			this.startButton.DisplayStyle          =  System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.startButton.Image                 =  global::Game_Of_Life.Properties.Resources.ic_play_arrow_white_24dp;
			this.startButton.ImageTransparentColor =  System.Drawing.Color.Magenta;
			this.startButton.Name                  =  "startButton";
			this.startButton.Size                  =  new System.Drawing.Size(23, 22);
			this.startButton.Text                  =  "startButton";
			this.startButton.Click                 += new System.EventHandler(this.startButton_Click);
			// 
			// pauseButton
			// 
			this.pauseButton.DisplayStyle          =  System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.pauseButton.Image                 =  global::Game_Of_Life.Properties.Resources.ic_pause_white_24dp;
			this.pauseButton.ImageTransparentColor =  System.Drawing.Color.Magenta;
			this.pauseButton.Name                  =  "pauseButton";
			this.pauseButton.Size                  =  new System.Drawing.Size(23, 22);
			this.pauseButton.Text                  =  "pauseButton";
			this.pauseButton.Click                 += new System.EventHandler(this.pauseButton_Click);
			// 
			// stepButton
			// 
			this.stepButton.DisplayStyle          =  System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.stepButton.Image                 =  global::Game_Of_Life.Properties.Resources.ic_skip_next_white_24dp;
			this.stepButton.ImageTransparentColor =  System.Drawing.Color.Magenta;
			this.stepButton.Name                  =  "stepButton";
			this.stepButton.Size                  =  new System.Drawing.Size(23, 22);
			this.stepButton.Text                  =  "stepButton";
			this.stepButton.Click                 += new System.EventHandler(this.stepButton_Click);
			// 
			// seeNeighborCountToggle
			// 
			this.seeNeighborCountToggle.DisplayStyle          =  System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.seeNeighborCountToggle.Image                 =  global::Game_Of_Life.Properties.Resources.ic_repeat_one_white_24dp;
			this.seeNeighborCountToggle.ImageTransparentColor =  System.Drawing.Color.Magenta;
			this.seeNeighborCountToggle.Name                  =  "seeNeighborCountToggle";
			this.seeNeighborCountToggle.Size                  =  new System.Drawing.Size(23, 22);
			this.seeNeighborCountToggle.Text                  =  "seeNeighborCountToggle";
			this.seeNeighborCountToggle.Click                 += new System.EventHandler(this.seeNeighborCountToggle_Click);
			// 
			// statusStrip1
			// 
			this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[]
											 {this.toolStripStatusLabelGenerations, this.toolStripStatusLabel1, this.toolStripStatusLabelGridSize});
			this.statusStrip1.Location = new System.Drawing.Point(0, 376);
			this.statusStrip1.Name     = "statusStrip1";
			this.statusStrip1.Padding  = new System.Windows.Forms.Padding(1, 0, 16, 0);
			this.statusStrip1.Size     = new System.Drawing.Size(668, 22);
			this.statusStrip1.TabIndex = 2;
			this.statusStrip1.Text     = "statusStrip1";
			// 
			// toolStripStatusLabelGenerations
			// 
			this.toolStripStatusLabelGenerations.ForeColor = System.Drawing.Color.FromArgb(((int) (((byte) (224)))), ((int) (((byte) (224)))), ((int) (((byte) (224)))));
			this.toolStripStatusLabelGenerations.Name      = "toolStripStatusLabelGenerations";
			this.toolStripStatusLabelGenerations.Size      = new System.Drawing.Size(90, 17);
			this.toolStripStatusLabelGenerations.Text      = "Generations = 0";
			// 
			// toolStripStatusLabel1
			// 
			this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
			this.toolStripStatusLabel1.Size = new System.Drawing.Size(0, 17);
			// 
			// toolStripStatusLabelGridSize
			// 
			this.toolStripStatusLabelGridSize.ForeColor = System.Drawing.Color.FromArgb(((int) (((byte) (224)))), ((int) (((byte) (224)))), ((int) (((byte) (224)))));
			this.toolStripStatusLabelGridSize.Name      = "toolStripStatusLabelGridSize";
			this.toolStripStatusLabelGridSize.Size      = new System.Drawing.Size(84, 17);
			this.toolStripStatusLabelGridSize.Text      = "Grid Size = 0, 0";
			// 
			// graphicsPanel1
			// 
			this.graphicsPanel1.BackColor  =  System.Drawing.SystemColors.WindowFrame;
			this.graphicsPanel1.Dock       =  System.Windows.Forms.DockStyle.Fill;
			this.graphicsPanel1.Font       =  new System.Drawing.Font("Fira Code Medium", 9F);
			this.graphicsPanel1.Location   =  new System.Drawing.Point(0, 49);
			this.graphicsPanel1.Name       =  "graphicsPanel1";
			this.graphicsPanel1.Size       =  new System.Drawing.Size(668, 327);
			this.graphicsPanel1.TabIndex   =  3;
			this.graphicsPanel1.Paint      += new System.Windows.Forms.PaintEventHandler(this.graphicsPanel1_Paint);
			this.graphicsPanel1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.graphicsPanel1_MouseClick);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
			this.AutoScaleMode       = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor           = System.Drawing.SystemColors.WindowFrame;
			this.ClientSize          = new System.Drawing.Size(668, 398);
			this.Controls.Add(this.graphicsPanel1);
			this.Controls.Add(this.statusStrip1);
			this.Controls.Add(this.toolStrip1);
			this.Controls.Add(this.menuStrip1);
			this.ForeColor     = System.Drawing.Color.FromArgb(((int) (((byte) (224)))), ((int) (((byte) (224)))), ((int) (((byte) (224)))));
			this.MainMenuStrip = this.menuStrip1;
			this.Name          = "Form1";
			this.Text          = "Form1";
			this.menuStrip1.ResumeLayout(false);
			this.menuStrip1.PerformLayout();
			this.toolStrip1.ResumeLayout(false);
			this.toolStrip1.PerformLayout();
			this.statusStrip1.ResumeLayout(false);
			this.statusStrip1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();
		}

		#endregion

		private System.Windows.Forms.MenuStrip menuStrip1;
		private System.Windows.Forms.ToolStrip toolStrip1;
		private System.Windows.Forms.StatusStrip statusStrip1;
		private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator;
		private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem saveAsToolStripMenuItem;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
		private System.Windows.Forms.ToolStripMenuItem printToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem printPreviewToolStripMenuItem;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
		private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem toolsToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem customizeToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem optionsToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem contentsToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem indexToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem searchToolStripMenuItem;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
		private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
		private System.Windows.Forms.ToolStripButton newToolStripButton;
		private System.Windows.Forms.ToolStripButton openToolStripButton;
		private System.Windows.Forms.ToolStripButton saveToolStripButton;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator6;
		private System.Windows.Forms.ToolStripButton cutToolStripButton;
		private System.Windows.Forms.ToolStripButton copyToolStripButton;
		private System.Windows.Forms.ToolStripButton pasteToolStripButton;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator7;
		private System.Windows.Forms.ToolStripButton helpToolStripButton;
		private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabelGenerations;
		private Game_Of_Life.GraphicsPanel graphicsPanel1;
		private System.Windows.Forms.ToolStripButton startButton;
		private System.Windows.Forms.ToolStripButton pauseButton;
		private System.Windows.Forms.ToolStripButton stepButton;
		private System.Windows.Forms.ToolStripButton seeNeighborCountToggle;
		private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
		private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabelGridSize;
		private System.Windows.Forms.ToolStripMenuItem lightToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem darkToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem themesToolStripMenuItem;
	}
}

