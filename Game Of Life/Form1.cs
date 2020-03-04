using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using Game_Of_Life.Properties;

namespace Game_Of_Life {
	public partial class Form1 : Form {
		//Dialog boxes
		private SettingsDialog _settingsDialog;

		// Drawing colors
		private string _currentTheme   = "DARK";
		private Color  _gridColor      = Color.DarkSlateGray;
		private Color  _emptyCellColor = Color.LightSlateGray;
		private Color  _cellColor      = Color.Teal;

		// Generation count
		private int _generations;

		private bool _infinite;
		private int  _seed;
		private int  _tickSpeed = 20;

		private bool _seeNeighborCount;

		// The Timer class
		private readonly Timer _timer = new Timer();

		// The universe array
		private bool[,] _universe = new bool[100, 50];
		private bool[,] _scratchPad;

		public int Width {
			get => _universe.GetLength(0);
			set {
				_universe   = new bool[value, _universe.GetLength(1)];
				_scratchPad = _universe;

				graphicsPanel1.Invalidate();
			}
		}

		public int Height {
			get => _universe.GetLength(1);
			set {
				_universe   = new bool[_universe.GetLength(0), value];
				_scratchPad = _universe;

				graphicsPanel1.Invalidate();
			}
		}

		public Form1() {
			InitializeComponent();
			_settingsDialog = new SettingsDialog();

			// Setup next universe
			_scratchPad = new bool[_universe.GetLength(0), _universe.GetLength(1)];

			//Read settings
			_currentTheme = Settings.Default.Theme;
			SetTheme();

			//Set Initial values for the text boxes
			widthTextBox.Text  = _universe.GetLength(0).ToString();
			heightTextBox.Text = _universe.GetLength(1).ToString();
			seedTextBox.Text   = _seed.ToString();

			// Setup the timer
			_timer.Interval = _tickSpeed; // milliseconds
		}

		public void SetTheme() {
			if (_currentTheme == "DARK") {
				SetDarkMode();
			} else if (_currentTheme == "LIGHT") {
				SetLightMode();
			} else if (_cellColor      != Color.Teal           && _cellColor      != Color.Black || _gridColor != Color.DarkSlateGray && _gridColor != Color.SlateGray ||
					   _emptyCellColor != Color.LightSlateGray && _emptyCellColor != Color.White || _currentTheme == "CUSTOM") {
				_currentTheme = "CUSTOM";
				SetColors();
			}
		}

		private void SetColors() {
			_gridColor      = Settings.Default.LineColor;
			_cellColor      = Settings.Default.LivingCellColor;
			_emptyCellColor = Settings.Default.BackColor;
		}

		private void SetDarkMode() {
			_gridColor      = Color.DarkSlateGray;
			_cellColor      = Color.Teal;
			_emptyCellColor = Color.LightSlateGray;

			graphicsPanel1.Invalidate();
		}

		private void SetLightMode() {
			_gridColor      = Color.SlateGray;
			_cellColor      = Color.Black;
			_emptyCellColor = Color.White;

			graphicsPanel1.Invalidate();
		}

		// Calculate the next generation of cells
		private void NextGeneration() {
			// Increment generation count
			_generations++;

			//Create grid of neighbors
			int[,] neighbors = new int[_scratchPad.GetLength(0), _scratchPad.GetLength(1)];
			for (int y = 0; y < _scratchPad.GetLength(1); y++) {
				for (int x = 0; x < _scratchPad.GetLength(0); x++) neighbors[x, y] = CountNeighbors(x, y);
			}

			//Birth next generation and kill off previous one
			for (int y = 0; y < _scratchPad.GetLength(1); y++) {
				for (int x = 0; x < _scratchPad.GetLength(0); x++)
					if (neighbors[x, y] == 3 || neighbors[x, y] == 2 && _universe[x, y])
						_scratchPad[x, y] = true;
					else
						_scratchPad[x, y] = false;
			}

			graphicsPanel1.Invalidate();

			// Update status strip generations
			toolStripStatusLabelGenerations.Text = "Generations = " + _generations;
		}

		// The event called by the timer every Interval milliseconds.
		private void Timer_Tick(object sender, EventArgs e) {
			NextGeneration();

			graphicsPanel1.Invalidate();
		}

		private void graphicsPanel1_Paint(object sender, PaintEventArgs e) {
			// Calculate the width and height of each cell in pixels
			// CELL WIDTH = WINDOW WIDTH / NUMBER OF CELLS IN X
			float cellWidth = graphicsPanel1.ClientSize.Width / (float) _scratchPad.GetLength(0);
			// CELL HEIGHT = WINDOW HEIGHT / NUMBER OF CELLS IN Y
			float cellHeight = graphicsPanel1.ClientSize.Height / (float) _scratchPad.GetLength(1);

			// A Pen for drawing the grid lines (color, width)
			Pen gridPen = new Pen(_gridColor, 1);

			// A Brush for filling living cells interiors (color)
			Brush cellBrush      = new SolidBrush(_cellColor);
			Brush cellEmptyBrush = new SolidBrush(_emptyCellColor);

			// Create and format font
			Font font = new Font("Fira Sans", 8f);

			StringFormat stringFormat = new StringFormat();
			stringFormat.Alignment     = StringAlignment.Center;
			stringFormat.LineAlignment = StringAlignment.Center;

			//Overwrite the previous universe
			_universe = _scratchPad;

			// Iterate through the universe in the y, top to bottom
			for (int y = 0; y < _scratchPad.GetLength(1); y++) {
				// Iterate through the universe in the x, left to right
				for (int x = 0; x < _scratchPad.GetLength(0); x++) {
					// A rectangle to represent each cell in pixels
					RectangleF cellRect = RectangleF.Empty;
					cellRect.X      = x * cellWidth;
					cellRect.Y      = y * cellHeight;
					cellRect.Width  = cellWidth;
					cellRect.Height = cellHeight;

					//Count the current cells living neighbors
					int neighbors = CountNeighbors(x, y);

					// Fill the cell with a brush if alive
					if (_universe[x, y])
						e.Graphics.FillRectangle(cellBrush, cellRect);
					else
						e.Graphics.FillRectangle(cellEmptyBrush, cellRect);

					//Write the cells living neighbors to the board
					if (_seeNeighborCount)
						if (neighbors != 0) {
							if (neighbors > 3)
								e.Graphics.DrawString(neighbors.ToString(), font, Brushes.DarkRed, cellRect, stringFormat);
							else if (neighbors == 2 || neighbors == 3)
								e.Graphics.DrawString(neighbors.ToString(), font, Brushes.LawnGreen, cellRect, stringFormat);
							else
								e.Graphics.DrawString(neighbors.ToString(), font, Brushes.Black, cellRect, stringFormat);
						}

					// Outline the cell with a pen
					e.Graphics.DrawRectangle(gridPen, cellRect.X, cellRect.Y, cellRect.Width, cellRect.Height);
				}
			}

			//Display the Grid Size of the Universe
			toolStripStatusLabelGridSize.Text = "Grid Size = " + _universe.GetLength(0) + ", " + _universe.GetLength(1);
			seedToolStrip.Text                = "Seed = "                                      + _seed;

			// Cleaning up pens and brushes
			font.Dispose();
			gridPen.Dispose();
			cellBrush.Dispose();
		}

		private void graphicsPanel1_MouseClick(object sender, MouseEventArgs e) {
			// If the left mouse button was clicked
			if (e.Button == MouseButtons.Left) {
				// Calculate the width and height of each cell in pixels
				float cellWidth  = graphicsPanel1.ClientSize.Width  / (float) _scratchPad.GetLength(0);
				float cellHeight = graphicsPanel1.ClientSize.Height / (float) _scratchPad.GetLength(1);

				// Calculate the cell that was clicked in
				// CELL X = MOUSE X / CELL WIDTH
				float x = e.X / cellWidth;
				// CELL Y = MOUSE Y / CELL HEIGHT
				float y = e.Y / cellHeight;

				// Toggle the cell's state
				_scratchPad[(int) x, (int) y] = !_scratchPad[(int) x, (int) y];

				// Tell Windows you need to repaint
				graphicsPanel1.Invalidate();
			}
		}

		/// <summary>
		///     Closes the program
		/// </summary>
		/// <param name="sender">Object that tells the program to shut down</param>
		/// <param name="e">Event call</param>
		private void exitToolStripMenuItem_Click(object sender, EventArgs e) {
			Close();
		}

		/// <summary>
		///     Resets the universe with a new grid of blank cells
		/// </summary>
		/// <param name="sender">Object that tells the program to reset</param>
		/// <param name="e">Event Call</param>
		private void newToolStripMenuItem_Click(object sender, EventArgs e) {
			for (int y = 0; y < _universe.GetLength(1); y++) {
				for (int x = 0; x < _universe.GetLength(0); x++) _universe[x, y] = false;
			}

			_generations = 0;

			_timer.Enabled = false;

			toolStripStatusLabelGenerations.Text = "Generations = " + _generations;

			graphicsPanel1.Invalidate();
		}

		/// <summary>
		///     Starts the life cycle of the cells
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void startButton_Click(object sender, EventArgs e) {
			//Starts the timer
			_timer.Enabled = true;

			//If the timer is started increment tick
			if (_timer.Enabled) _timer.Tick += Timer_Tick;

			graphicsPanel1.Invalidate();
		}

		/// <summary>
		///     Pauses the life cycle of the cells
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void pauseButton_Click(object sender, EventArgs e) {
			//Stops the timer
			_timer.Enabled = false;

			graphicsPanel1.Invalidate();
		}

		/// <summary>
		///     Counts the neighbors of cell (x, y)
		/// </summary>
		/// <param name="x">The horizontal coordinate of the cell</param>
		/// <param name="y">The vertical coordinate of the cell</param>
		/// <returns>The number of living neighbors surrounding the cell</returns>
		private int CountNeighbors(int x, int y) {
			//An int to keep track of the cell's neighbors
			int livingNeighbors = 0;

			//Loop through the surrounding cells starting with the top right corner
			//[  ][  ][  ]
			//[  ][xy][  ]
			//[  ][  ][  ]
			for (int j = -1; j <= 1; j++) {
				for (int i = -1; i <= 1; i++) //Check if x + i and y + j are within the boundaries
					if (x + i < _universe.GetLength(0) && y + j < _universe.GetLength(1) && x + i >= 0 && y + j >= 0) {
						//Make sure that x + i != x and y + j != y
						if (i != 0 || j != 0) //Test the cell in the universe and if the cell is alive (if universe[x + i, y + j] returns true)
							if (_universe[x + i, y + j])
								livingNeighbors++;
					} else {
						//When infinite loop is enabled
						if (_infinite) {
							//Create temporary x and y positions
							int xT = x;
							int yT = y;

							//Test if x + i is > the universe width or is < 0
							if (x + i > _universe.GetLength(0) - 1) //set xT to be -1
								xT = -1;
							else if (x + i < 0) //set xT to be the width of the universe
								xT = _universe.GetLength(0);

							//Test if y + j is > the universe height or is < 0 
							if (y + j > _universe.GetLength(1) - 1) //set yT to be -1
								yT = -1;
							else if (y + j < 0) //set yT to be the height of the universe
								yT = _universe.GetLength(1);

							//Make sure that xT + i != xT and yT + j != yT
							if (i != 0 || j != 0) //Test the cell in the universe and if the cell is alive (if universe[xT + i, yT + j] returns true)
								if (_universe[xT + i, yT + j])
									livingNeighbors++;
						}
					}
			}

			//Return the amount of living neighbors surrounding cell (x, y)
			return livingNeighbors;
		}

		/// <summary>
		///     Move forward one generation
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void stepButton_Click(object sender, EventArgs e) {
			NextGeneration();
		}

		/// <summary>
		///     Toggle the visibility of the Neighbor Count
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void seeNeighborCountToggle_Click(object sender, EventArgs e) {
			_seeNeighborCount = !_seeNeighborCount;

			graphicsPanel1.Invalidate();
		}

		/// <summary>
		///     Save the current array of cells as a .cells file
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void saveToolStripButton_Click(object sender, EventArgs e) {
			SaveFileDialog dlg = new SaveFileDialog();
			dlg.Filter      = "All Files|*.*|Cells|*.cells";
			dlg.FilterIndex = 2;
			dlg.DefaultExt  = "cells";

			if (DialogResult.OK == dlg.ShowDialog()) {
				StreamWriter writer = new StreamWriter(dlg.FileName);

				//Iterate through the universe one row at a time.
				for (int y = 0; y < _universe.GetLength(1); y++) {
					//Create a string to represent the current row.
					string currentRow = string.Empty;

					//Iterate through the current row one cell at a time.
					for (int x = 0; x < _universe.GetLength(0); x++)
						if (_universe[x, y])
							currentRow += 'O';
						else
							currentRow += '.';

					writer.WriteLine(currentRow);
				}

				writer.Close();
			}
		}

		/// <summary>
		///     Open a saved .cells file
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void openToolStripButton_Click(object sender, EventArgs e) {
			OpenFileDialog dlg = new OpenFileDialog();
			dlg.Filter      = "All Files|*.*|Cells|*.cells";
			dlg.FilterIndex = 2;

			if (DialogResult.OK == dlg.ShowDialog()) {
				StreamReader reader = new StreamReader(dlg.FileName);

				//Keep track of width and height
				int maxWidth  = 0;
				int maxHeight = 0;

				//Iterate through the file once to get its size.
				while (!reader.EndOfStream) {
					//Read one row at a time.
					string row = reader.ReadLine();

					//If the row begins with '!' then it is a comment
					//and should be ignored
					if (row[0] != '!') {
						maxHeight++;
						if (maxWidth < row.Length) maxWidth = row.Length;
					}
				}


				//Resize the current universe and scratchPad
				//to the width and height of the file calculated above.
				_universe          = new bool[maxWidth, maxHeight];
				_scratchPad        = new bool[_universe.GetLength(0), _universe.GetLength(1)];
				widthTextBox.Text  = Width.ToString();
				heightTextBox.Text = Height.ToString();

				//Reset the file pointer back to the beginning of the file.
				reader.BaseStream.Seek(0, SeekOrigin.Begin);

				int yPos = 0;
				//Iterate through the file again, this time reading in the cells.
				while (!reader.EndOfStream) {
					//Read one row at a time.
					string row = reader.ReadLine();

					//If the row begins with '!' then
					//it is a comment and should be ignored.
					if (row[0] != '!') {
						for (int xPos = 0; xPos < row.Length; xPos++) {
							//if row[xPos] is a 'O' (capital O) then
							//set the corresponding cell in the universe to alive
							if (row[xPos] == 'O') _scratchPad[xPos, yPos] = true;

							//if row[xPos] is a '.' (period) then
							//set the corresponding cell in the universe to dead.
							if (row[xPos] == '.') _scratchPad[xPos, yPos] = false;
						}

						yPos++;
					}
				}

				//Close the file.
				reader.Close();
				graphicsPanel1.Invalidate();
			}
		}

		/// <summary>
		///     Set the width of the universe based on the text in the width text box
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void widthTextBox_TextChanged(object sender, EventArgs e) {
			int.TryParse(widthTextBox.Text, out int width);
			_universe   = new bool[width, _universe.GetLength(1)];
			_scratchPad = _universe;

			graphicsPanel1.Invalidate();
		}

		/// <summary>
		///     Set the width of the universe based on the text in the width text box
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void heightTextBox_TextChanged(object sender, EventArgs e) {
			int.TryParse(heightTextBox.Text, out int height);
			_universe   = new bool[_universe.GetLength(0), height];
			_scratchPad = _universe;

			graphicsPanel1.Invalidate();
		}

		/// <summary>
		///     Create a seed for randomization based on the current time on the system
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void fromTimeToolStripMenuItem_Click(object sender, EventArgs e) {
			Random rand = new Random(DateTime.Now.Millisecond);
			_seed            = rand.Next();
			seedTextBox.Text = _seed.ToString();
			Randomize();
		}

		/// <summary>
		///     Manually write a seed to be used for randomizing the cells
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void seedTextBox_TextChanged(object sender, EventArgs e) {
			int.TryParse(seedTextBox.Text, out _seed);
			graphicsPanel1.Invalidate();
		}

		/// <summary>
		///     Sets the seed text box to be the current seed
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void fromSeedToolStripMenuItem_Click(object sender, EventArgs e) {
			seedTextBox.Text = _seed.ToString();
			Randomize();
		}

		/// <summary>
		///     Randomized the cells based on the seed
		/// </summary>
		private void Randomize() {
			Random randFromSeed = new Random(_seed);
			long   rand         = 0;
			for (int y = 0; y < _universe.GetLength(1); y++) {
				for (int x = 0; x < _universe.GetLength(0); x++) {
					rand = randFromSeed.Next(2);
					if (rand != 0)
						_scratchPad[x, y] = false;
					else
						_scratchPad[x, y] = true;
				}
			}

			graphicsPanel1.Invalidate();
		}

		/// <summary>
		///     Toggle the infinite loop
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void terroidialToolStripMenuItem_Click(object sender, EventArgs e) {
			_infinite = !_infinite;

			graphicsPanel1.Invalidate();
		}

		private void customizeToolStripMenuItem_Click(object sender, EventArgs e) {
			_settingsDialog.Width        = Width.ToString();
			_settingsDialog.Height       = Height.ToString();
			_settingsDialog.TickSpeed    = _tickSpeed.ToString();
			_settingsDialog.Theme        = _currentTheme;
			_settingsDialog.ColorButtons = new[] {_gridColor, _emptyCellColor, _cellColor};

			if (DialogResult.OK == _settingsDialog.ShowDialog()) {
				int.TryParse(_settingsDialog.Width,  out int width);
				int.TryParse(_settingsDialog.Height, out int height);
				if (_universe.GetLength(0) != width) {
					_universe = new bool[width, _universe.GetLength(1)];
				}

				if (_universe.GetLength(1) != height) {
					_universe = new bool[_universe.GetLength(0), height];
				}

				_scratchPad = _universe;

				widthTextBox.Text  = _universe.GetLength(0).ToString();
				heightTextBox.Text = _universe.GetLength(1).ToString();
				if (_settingsDialog.Theme != null) {
					if (_settingsDialog.Theme.ToLower() != _currentTheme) {
						SetTheme();
						_settingsDialog.Invalidate();
					}
				}

				int.TryParse(_settingsDialog.TickSpeed, out _tickSpeed);
				_timer.Interval = _tickSpeed;

				_gridColor      = _settingsDialog.ColorButtons[0];
				_emptyCellColor = _settingsDialog.ColorButtons[1];
				_cellColor      = _settingsDialog.ColorButtons[2];
				_currentTheme   = _settingsDialog.Theme;
				graphicsPanel1.Invalidate();
			}
		}

		private void Form1_FormClosed(object sender, FormClosedEventArgs e) {
			Settings.Default.Theme           = _currentTheme;
			Settings.Default.BackColor       = _emptyCellColor;
			Settings.Default.LineColor       = _gridColor;
			Settings.Default.LivingCellColor = _cellColor;

			Settings.Default.Width  = _universe.GetLength(0);
			Settings.Default.Height = _universe.GetLength(1);
		}
	}
}