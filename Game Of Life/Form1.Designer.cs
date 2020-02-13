namespace Game_Of_Life {
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
			this.menuStrip1                       = new System.Windows.Forms.MenuStrip();
			this.fileToolStripMenuItem            = new System.Windows.Forms.ToolStripMenuItem();
			this.newToolStripMenuItem             = new System.Windows.Forms.ToolStripMenuItem();
			this.openToolStripMenuItem            = new System.Windows.Forms.ToolStripMenuItem();
			this.saveToolStripMenuItem            = new System.Windows.Forms.ToolStripMenuItem();
			this.exitToolStripMenuItem            = new System.Windows.Forms.ToolStripMenuItem();
			this.runToolStripMenuItem             = new System.Windows.Forms.ToolStripMenuItem();
			this.startToolStripMenuItem           = new System.Windows.Forms.ToolStripMenuItem();
			this.pauseToolStripMenuItem           = new System.Windows.Forms.ToolStripMenuItem();
			this.stepToolStripMenuItem            = new System.Windows.Forms.ToolStripMenuItem();
			this.toolsToolStripMenuItem           = new System.Windows.Forms.ToolStripMenuItem();
			this.customizeToolStripMenuItem       = new System.Windows.Forms.ToolStripMenuItem();
			this.themesToolStripMenuItem          = new System.Windows.Forms.ToolStripMenuItem();
			this.darkToolStripMenuItem            = new System.Windows.Forms.ToolStripMenuItem();
			this.lightToolStripMenuItem           = new System.Windows.Forms.ToolStripMenuItem();
			this.optionsToolStripMenuItem         = new System.Windows.Forms.ToolStripMenuItem();
			this.fromTimeToolStripMenuItem        = new System.Windows.Forms.ToolStripMenuItem();
			this.fromSeedToolStripMenuItem        = new System.Windows.Forms.ToolStripMenuItem();
			this.fromCurrentSeedToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.helpToolStripMenuItem            = new System.Windows.Forms.ToolStripMenuItem();
			this.contentsToolStripMenuItem        = new System.Windows.Forms.ToolStripMenuItem();
			this.indexToolStripMenuItem           = new System.Windows.Forms.ToolStripMenuItem();
			this.searchToolStripMenuItem          = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripSeparator5              = new System.Windows.Forms.ToolStripSeparator();
			this.aboutToolStripMenuItem           = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStrip1                       = new System.Windows.Forms.ToolStrip();
			this.newToolStripButton               = new System.Windows.Forms.ToolStripButton();
			this.openToolStripButton              = new System.Windows.Forms.ToolStripButton();
			this.saveToolStripButton              = new System.Windows.Forms.ToolStripButton();
			this.toolStripSeparator6              = new System.Windows.Forms.ToolStripSeparator();
			this.helpToolStripButton              = new System.Windows.Forms.ToolStripButton();
			this.startButton                      = new System.Windows.Forms.ToolStripButton();
			this.pauseButton                      = new System.Windows.Forms.ToolStripButton();
			this.stepButton                       = new System.Windows.Forms.ToolStripButton();
			this.seeNeighborCountToggle           = new System.Windows.Forms.ToolStripButton();
			this.toolStripSeparator3              = new System.Windows.Forms.ToolStripSeparator();
			this.toolStripLabel1                  = new System.Windows.Forms.ToolStripLabel();
			this.widthTextBox                     = new System.Windows.Forms.ToolStripTextBox();
			this.toolStripLabel2                  = new System.Windows.Forms.ToolStripLabel();
			this.heightTextBox                    = new System.Windows.Forms.ToolStripTextBox();
			this.toolStripSeparator7              = new System.Windows.Forms.ToolStripSeparator();
			this.toolStripLabel3                  = new System.Windows.Forms.ToolStripLabel();
			this.seedTextBox                      = new System.Windows.Forms.ToolStripTextBox();
			this.statusStrip1                     = new System.Windows.Forms.StatusStrip();
			this.toolStripStatusLabelGenerations  = new System.Windows.Forms.ToolStripStatusLabel();
			this.toolStripStatusLabel1            = new System.Windows.Forms.ToolStripStatusLabel();
			this.toolStripStatusLabelGridSize     = new System.Windows.Forms.ToolStripStatusLabel();
			this.seedToolStrip                    = new System.Windows.Forms.ToolStripStatusLabel();
			this.graphicsPanel1                   = new Game_Of_Life.GraphicsPanel();
			this.terroidialToolStripMenuItem      = new System.Windows.Forms.ToolStripMenuItem();
			this.menuStrip1.SuspendLayout();
			this.toolStrip1.SuspendLayout();
			this.statusStrip1.SuspendLayout();
			this.SuspendLayout();
			// 
			// menuStrip1
			// 
			this.menuStrip1.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (64)))), ((int) (((byte) (64)))), ((int) (((byte) (64)))));
			this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[]
										   {this.fileToolStripMenuItem, this.runToolStripMenuItem, this.toolsToolStripMenuItem, this.helpToolStripMenuItem});
			this.menuStrip1.Location = new System.Drawing.Point(0, 0);
			this.menuStrip1.Name     = "menuStrip1";
			this.menuStrip1.Padding  = new System.Windows.Forms.Padding(7, 2, 0, 2);
			this.menuStrip1.Size     = new System.Drawing.Size(784, 24);
			this.menuStrip1.TabIndex = 0;
			this.menuStrip1.Text     = "menuStrip1";
			// 
			// fileToolStripMenuItem
			// 
			this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[]
															  {this.newToolStripMenuItem, this.openToolStripMenuItem, this.saveToolStripMenuItem, this.exitToolStripMenuItem});
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
			this.newToolStripMenuItem.Size                  =  new System.Drawing.Size(152, 22);
			this.newToolStripMenuItem.Text                  =  "&New";
			this.newToolStripMenuItem.Click                 += new System.EventHandler(this.newToolStripMenuItem_Click);
			// 
			// openToolStripMenuItem
			// 
			this.openToolStripMenuItem.Image                 =  ((System.Drawing.Image) (resources.GetObject("openToolStripMenuItem.Image")));
			this.openToolStripMenuItem.ImageTransparentColor =  System.Drawing.Color.Magenta;
			this.openToolStripMenuItem.Name                  =  "openToolStripMenuItem";
			this.openToolStripMenuItem.ShortcutKeys          =  ((System.Windows.Forms.Keys) ((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
			this.openToolStripMenuItem.Size                  =  new System.Drawing.Size(152, 22);
			this.openToolStripMenuItem.Text                  =  "&Open";
			this.openToolStripMenuItem.Click                 += new System.EventHandler(this.openToolStripButton_Click);
			// 
			// saveToolStripMenuItem
			// 
			this.saveToolStripMenuItem.Image                 =  ((System.Drawing.Image) (resources.GetObject("saveToolStripMenuItem.Image")));
			this.saveToolStripMenuItem.ImageTransparentColor =  System.Drawing.Color.Magenta;
			this.saveToolStripMenuItem.Name                  =  "saveToolStripMenuItem";
			this.saveToolStripMenuItem.ShortcutKeys          =  ((System.Windows.Forms.Keys) ((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
			this.saveToolStripMenuItem.Size                  =  new System.Drawing.Size(152, 22);
			this.saveToolStripMenuItem.Text                  =  "&Save";
			this.saveToolStripMenuItem.Click                 += new System.EventHandler(this.saveToolStripButton_Click);
			// 
			// exitToolStripMenuItem
			// 
			this.exitToolStripMenuItem.Name  =  "exitToolStripMenuItem";
			this.exitToolStripMenuItem.Size  =  new System.Drawing.Size(152, 22);
			this.exitToolStripMenuItem.Text  =  "E&xit";
			this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
			// 
			// runToolStripMenuItem
			// 
			this.runToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[]
															 {this.startToolStripMenuItem, this.pauseToolStripMenuItem, this.stepToolStripMenuItem});
			this.runToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int) (((byte) (224)))), ((int) (((byte) (224)))), ((int) (((byte) (224)))));
			this.runToolStripMenuItem.Name      = "runToolStripMenuItem";
			this.runToolStripMenuItem.Size      = new System.Drawing.Size(40, 20);
			this.runToolStripMenuItem.Text      = "Run";
			// 
			// startToolStripMenuItem
			// 
			this.startToolStripMenuItem.Name         =  "startToolStripMenuItem";
			this.startToolStripMenuItem.ShortcutKeys =  System.Windows.Forms.Keys.F1;
			this.startToolStripMenuItem.Size         =  new System.Drawing.Size(152, 22);
			this.startToolStripMenuItem.Text         =  "Start";
			this.startToolStripMenuItem.Click        += new System.EventHandler(this.startButton_Click);
			// 
			// pauseToolStripMenuItem
			// 
			this.pauseToolStripMenuItem.Name         =  "pauseToolStripMenuItem";
			this.pauseToolStripMenuItem.ShortcutKeys =  System.Windows.Forms.Keys.F2;
			this.pauseToolStripMenuItem.Size         =  new System.Drawing.Size(152, 22);
			this.pauseToolStripMenuItem.Text         =  "Pause";
			this.pauseToolStripMenuItem.Click        += new System.EventHandler(this.pauseButton_Click);
			// 
			// stepToolStripMenuItem
			// 
			this.stepToolStripMenuItem.Name         =  "stepToolStripMenuItem";
			this.stepToolStripMenuItem.ShortcutKeys =  System.Windows.Forms.Keys.F3;
			this.stepToolStripMenuItem.Size         =  new System.Drawing.Size(152, 22);
			this.stepToolStripMenuItem.Text         =  "Step";
			this.stepToolStripMenuItem.Click        += new System.EventHandler(this.stepButton_Click);
			// 
			// toolsToolStripMenuItem
			// 
			this.toolsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[]
															   {this.customizeToolStripMenuItem, this.optionsToolStripMenuItem, this.terroidialToolStripMenuItem});
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
			this.optionsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[]
																 {this.fromTimeToolStripMenuItem, this.fromSeedToolStripMenuItem, this.fromCurrentSeedToolStripMenuItem});
			this.optionsToolStripMenuItem.Name = "optionsToolStripMenuItem";
			this.optionsToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
			this.optionsToolStripMenuItem.Text = "Randomize";
			// 
			// fromTimeToolStripMenuItem
			// 
			this.fromTimeToolStripMenuItem.Name         =  "fromTimeToolStripMenuItem";
			this.fromTimeToolStripMenuItem.ShortcutKeys =  ((System.Windows.Forms.Keys) ((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.R)));
			this.fromTimeToolStripMenuItem.Size         =  new System.Drawing.Size(246, 22);
			this.fromTimeToolStripMenuItem.Text         =  "From Time";
			this.fromTimeToolStripMenuItem.Click        += new System.EventHandler(this.fromTimeToolStripMenuItem_Click);
			// 
			// fromSeedToolStripMenuItem
			// 
			this.fromSeedToolStripMenuItem.Name         =  "fromSeedToolStripMenuItem";
			this.fromSeedToolStripMenuItem.ShortcutKeys =  ((System.Windows.Forms.Keys) ((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.R)));
			this.fromSeedToolStripMenuItem.Size         =  new System.Drawing.Size(246, 22);
			this.fromSeedToolStripMenuItem.Text         =  "From Seed";
			this.fromSeedToolStripMenuItem.Click        += new System.EventHandler(this.fromSeedToolStripMenuItem_Click);
			// 
			// fromCurrentSeedToolStripMenuItem
			// 
			this.fromCurrentSeedToolStripMenuItem.Name = "fromCurrentSeedToolStripMenuItem";
			this.fromCurrentSeedToolStripMenuItem.ShortcutKeys =
				((System.Windows.Forms.Keys) (((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) | System.Windows.Forms.Keys.R)));
			this.fromCurrentSeedToolStripMenuItem.Size  =  new System.Drawing.Size(246, 22);
			this.fromCurrentSeedToolStripMenuItem.Text  =  "From Current Seed";
			this.fromCurrentSeedToolStripMenuItem.Click += new System.EventHandler(this.fromSeedToolStripMenuItem_Click);
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
																						this.toolStripSeparator6, this.helpToolStripButton,
																						this.startButton, this.pauseButton, this.stepButton, this.seeNeighborCountToggle,
																						this.toolStripSeparator3, this.toolStripLabel1,
																						this.widthTextBox, this.toolStripLabel2, this.heightTextBox, this.toolStripSeparator7,
																						this.toolStripLabel3, this.seedTextBox
																					});
			this.toolStrip1.Location   = new System.Drawing.Point(0, 24);
			this.toolStrip1.Name       = "toolStrip1";
			this.toolStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
			this.toolStrip1.Size       = new System.Drawing.Size(784, 25);
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
			this.startButton.Text                  =  "Start";
			this.startButton.Click                 += new System.EventHandler(this.startButton_Click);
			// 
			// pauseButton
			// 
			this.pauseButton.DisplayStyle          =  System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.pauseButton.Image                 =  global::Game_Of_Life.Properties.Resources.ic_pause_white_24dp;
			this.pauseButton.ImageTransparentColor =  System.Drawing.Color.Magenta;
			this.pauseButton.Name                  =  "pauseButton";
			this.pauseButton.Size                  =  new System.Drawing.Size(23, 22);
			this.pauseButton.Text                  =  "Pause";
			this.pauseButton.Click                 += new System.EventHandler(this.pauseButton_Click);
			// 
			// stepButton
			// 
			this.stepButton.DisplayStyle          =  System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.stepButton.Image                 =  global::Game_Of_Life.Properties.Resources.ic_skip_next_white_24dp;
			this.stepButton.ImageTransparentColor =  System.Drawing.Color.Magenta;
			this.stepButton.Name                  =  "stepButton";
			this.stepButton.Size                  =  new System.Drawing.Size(23, 22);
			this.stepButton.Text                  =  "Step";
			this.stepButton.Click                 += new System.EventHandler(this.stepButton_Click);
			// 
			// seeNeighborCountToggle
			// 
			this.seeNeighborCountToggle.DisplayStyle          =  System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.seeNeighborCountToggle.Image                 =  global::Game_Of_Life.Properties.Resources.ic_repeat_one_white_24dp;
			this.seeNeighborCountToggle.ImageTransparentColor =  System.Drawing.Color.Magenta;
			this.seeNeighborCountToggle.Name                  =  "seeNeighborCountToggle";
			this.seeNeighborCountToggle.Size                  =  new System.Drawing.Size(23, 22);
			this.seeNeighborCountToggle.Text                  =  "Toggle Neighbor Count";
			this.seeNeighborCountToggle.Click                 += new System.EventHandler(this.seeNeighborCountToggle_Click);
			// 
			// toolStripSeparator3
			// 
			this.toolStripSeparator3.Name = "toolStripSeparator3";
			this.toolStripSeparator3.Size = new System.Drawing.Size(6, 25);
			// 
			// toolStripLabel1
			// 
			this.toolStripLabel1.Name = "toolStripLabel1";
			this.toolStripLabel1.Size = new System.Drawing.Size(64, 22);
			this.toolStripLabel1.Text = "Grid Width";
			// 
			// widthTextBox
			// 
			this.widthTextBox.Name        =  "widthTextBox";
			this.widthTextBox.Size        =  new System.Drawing.Size(100, 25);
			this.widthTextBox.TextChanged += new System.EventHandler(this.widthTextBox_TextChanged);
			// 
			// toolStripLabel2
			// 
			this.toolStripLabel2.Name = "toolStripLabel2";
			this.toolStripLabel2.Size = new System.Drawing.Size(68, 22);
			this.toolStripLabel2.Text = "Grid Height";
			// 
			// heightTextBox
			// 
			this.heightTextBox.Name        =  "heightTextBox";
			this.heightTextBox.Size        =  new System.Drawing.Size(100, 25);
			this.heightTextBox.TextChanged += new System.EventHandler(this.heightTextBox_TextChanged);
			// 
			// toolStripSeparator7
			// 
			this.toolStripSeparator7.Name = "toolStripSeparator7";
			this.toolStripSeparator7.Size = new System.Drawing.Size(6, 25);
			// 
			// toolStripLabel3
			// 
			this.toolStripLabel3.Name = "toolStripLabel3";
			this.toolStripLabel3.Size = new System.Drawing.Size(32, 22);
			this.toolStripLabel3.Text = "Seed";
			// 
			// seedTextBox
			// 
			this.seedTextBox.Name        =  "seedTextBox";
			this.seedTextBox.Size        =  new System.Drawing.Size(100, 25);
			this.seedTextBox.TextChanged += new System.EventHandler(this.seedTextBox_TextChanged);
			// 
			// statusStrip1
			// 
			this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[]
											 {this.toolStripStatusLabelGenerations, this.toolStripStatusLabel1, this.toolStripStatusLabelGridSize, this.seedToolStrip});
			this.statusStrip1.Location = new System.Drawing.Point(0, 539);
			this.statusStrip1.Name     = "statusStrip1";
			this.statusStrip1.Padding  = new System.Windows.Forms.Padding(1, 0, 16, 0);
			this.statusStrip1.Size     = new System.Drawing.Size(784, 22);
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
			// seedToolStrip
			// 
			this.seedToolStrip.Name = "seedToolStrip";
			this.seedToolStrip.Size = new System.Drawing.Size(52, 17);
			this.seedToolStrip.Text = "Seed = 0";
			// 
			// graphicsPanel1
			// 
			this.graphicsPanel1.BackColor  =  System.Drawing.SystemColors.WindowFrame;
			this.graphicsPanel1.Dock       =  System.Windows.Forms.DockStyle.Fill;
			this.graphicsPanel1.Font       =  new System.Drawing.Font("Fira Code Medium", 9F);
			this.graphicsPanel1.Location   =  new System.Drawing.Point(0, 49);
			this.graphicsPanel1.Name       =  "graphicsPanel1";
			this.graphicsPanel1.Size       =  new System.Drawing.Size(784, 490);
			this.graphicsPanel1.TabIndex   =  3;
			this.graphicsPanel1.Paint      += new System.Windows.Forms.PaintEventHandler(this.graphicsPanel1_Paint);
			this.graphicsPanel1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.graphicsPanel1_MouseClick);
			// 
			// terroidialToolStripMenuItem
			// 
			this.terroidialToolStripMenuItem.Name  =  "terroidialToolStripMenuItem";
			this.terroidialToolStripMenuItem.Size  =  new System.Drawing.Size(152, 22);
			this.terroidialToolStripMenuItem.Text  =  "Terroidial";
			this.terroidialToolStripMenuItem.Click += new System.EventHandler(this.terroidialToolStripMenuItem_Click);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
			this.AutoScaleMode       = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor           = System.Drawing.SystemColors.WindowFrame;
			this.ClientSize          = new System.Drawing.Size(784, 561);
			this.Controls.Add(this.graphicsPanel1);
			this.Controls.Add(this.statusStrip1);
			this.Controls.Add(this.toolStrip1);
			this.Controls.Add(this.menuStrip1);
			this.ForeColor     = System.Drawing.Color.FromArgb(((int) (((byte) (224)))), ((int) (((byte) (224)))), ((int) (((byte) (224)))));
			this.MainMenuStrip = this.menuStrip1;
			this.Name          = "Form1";
			this.Text          = "Game of Life";
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
		private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
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
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
		private System.Windows.Forms.ToolStripLabel toolStripLabel1;
		private System.Windows.Forms.ToolStripLabel toolStripLabel2;
		private System.Windows.Forms.ToolStripTextBox heightTextBox;
		private System.Windows.Forms.ToolStripTextBox widthTextBox;
		private System.Windows.Forms.ToolStripMenuItem stepToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem pauseToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem startToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem runToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem fromTimeToolStripMenuItem;
		private System.Windows.Forms.ToolStripLabel toolStripLabel3;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator7;
		private System.Windows.Forms.ToolStripTextBox seedTextBox;
		private System.Windows.Forms.ToolStripStatusLabel seedToolStrip;
		private System.Windows.Forms.ToolStripMenuItem fromSeedToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem fromCurrentSeedToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem terroidialToolStripMenuItem;
	}
}

