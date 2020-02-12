using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Game_Of_Life {
	public partial class Form1 : Form {
		// The universe array
		bool[,] universe = new bool[100, 50];
		bool[,] scratchPad;

		// Drawing colors
		Color gridColor      = Color.DarkSlateGray;
		Color cellColor      = Color.Teal;
		Color emptyCellColor = Color.LightSlateGray;

		// The Timer class
		Timer timer = new Timer();

		// Generation count
		int generations = 0;

		bool seeNeighborCount = false;

		public Form1() {
			InitializeComponent();

			// Setup next universe
			scratchPad = new bool[universe.GetLength(0), universe.GetLength(1)];

			// Setup the timer
			timer.Interval = 20; // milliseconds
		}

		// Calculate the next generation of cells
		private void NextGeneration() {
			// Increment generation count
			generations++;

			//Create grid of neighbors
			int[,] neighbors = new int[scratchPad.GetLength(0), scratchPad.GetLength(1)];
			for (int y = 0; y < scratchPad.GetLength(1); y++) {
				for (int x = 0; x < scratchPad.GetLength(0); x++) {
					neighbors[x, y] = CountNeighbors(x, y);
				}
			}

			//Birth next generation and kill off previous one
			for (int y = 0; y < scratchPad.GetLength(1); y++) {
				for (int x = 0; x < scratchPad.GetLength(0); x++) {
					if (neighbors[x, y] == 3 || neighbors[x, y] == 2 && universe[x, y]) {
						scratchPad[x, y] = true;
					} else {
						scratchPad[x, y] = false;
					}
				}
			}

			graphicsPanel1.Invalidate();

			// Update status strip generations
			toolStripStatusLabelGenerations.Text = "Generations = " + generations.ToString();
		}

		// The event called by the timer every Interval milliseconds.
		private void Timer_Tick(object sender, EventArgs e) {
			NextGeneration();

			graphicsPanel1.Invalidate();
		}

		private void graphicsPanel1_Paint(object sender, PaintEventArgs e) {
			// Calculate the width and height of each cell in pixels
			// CELL WIDTH = WINDOW WIDTH / NUMBER OF CELLS IN X
			float cellWidth = (float) graphicsPanel1.ClientSize.Width / (float) scratchPad.GetLength(0);
			// CELL HEIGHT = WINDOW HEIGHT / NUMBER OF CELLS IN Y
			float cellHeight = (float) graphicsPanel1.ClientSize.Height / (float) scratchPad.GetLength(1);

			// A Pen for drawing the grid lines (color, width)
			Pen gridPen = new Pen(gridColor, 1);

			// A Brush for filling living cells interiors (color)
			Brush cellBrush      = new SolidBrush(cellColor);
			Brush cellEmptyBrush = new SolidBrush(emptyCellColor);

			// Create and format font
			Font font = new Font("Fira Sans", 8f);

			StringFormat stringFormat = new StringFormat();
			stringFormat.Alignment     = StringAlignment.Center;
			stringFormat.LineAlignment = StringAlignment.Center;

			universe = scratchPad;

			// Iterate through the universe in the y, top to bottom
			for (int y = 0; y < scratchPad.GetLength(1); y++) {
				// Iterate through the universe in the x, left to right
				for (int x = 0; x < scratchPad.GetLength(0); x++) {
					// A rectangle to represent each cell in pixels
					RectangleF cellRect = RectangleF.Empty;
					cellRect.X      = x * cellWidth;
					cellRect.Y      = y * cellHeight;
					cellRect.Width  = cellWidth;
					cellRect.Height = cellHeight;

					int neighbors = CountNeighbors(x, y);

					// Fill the cell with a brush if alive
					if (universe[x, y]) {
						e.Graphics.FillRectangle(cellBrush, cellRect);
					} else {
						e.Graphics.FillRectangle(cellEmptyBrush, cellRect);
					}

					if (seeNeighborCount) {
						if (neighbors != 0) {
							if (neighbors > 3) {
								e.Graphics.DrawString(neighbors.ToString(), font, Brushes.DarkRed, cellRect, stringFormat);
							} else if (neighbors == 2 || neighbors == 3) {
								e.Graphics.DrawString(neighbors.ToString(), font, Brushes.LawnGreen, cellRect, stringFormat);
							} else {
								e.Graphics.DrawString(neighbors.ToString(), font, Brushes.Black, cellRect, stringFormat);
							}
						}
					}

					// Outline the cell with a pen
					e.Graphics.DrawRectangle(gridPen, cellRect.X, cellRect.Y, cellRect.Width, cellRect.Height);
				}
			}

			//Display the Grid Size of the Universe
			toolStripStatusLabelGridSize.Text = "Grid Size = " + universe.GetLength(0) + ", " + universe.GetLength(1);

			// Cleaning up pens and brushes
			font.Dispose();
			gridPen.Dispose();
			cellBrush.Dispose();
		}

		private void graphicsPanel1_MouseClick(object sender, MouseEventArgs e) {
			// If the left mouse button was clicked
			if (e.Button == MouseButtons.Left) {
				// Calculate the width and height of each cell in pixels
				float cellWidth  = (float) graphicsPanel1.ClientSize.Width  / (float) scratchPad.GetLength(0);
				float cellHeight = (float) graphicsPanel1.ClientSize.Height / (float) scratchPad.GetLength(1);

				// Calculate the cell that was clicked in
				// CELL X = MOUSE X / CELL WIDTH
				float x = e.X / cellWidth;
				// CELL Y = MOUSE Y / CELL HEIGHT
				float y = e.Y / cellHeight;

				// Toggle the cell's state
				scratchPad[(int) x, (int) y] = !scratchPad[(int) x, (int) y];

				// Tell Windows you need to repaint
				graphicsPanel1.Invalidate();
			}
		}

		private void exitToolStripMenuItem_Click(object sender, EventArgs e) {
			Close();
		}

		private void newToolStripMenuItem_Click(object sender, EventArgs e) {
			for (int y = 0; y < universe.GetLength(1); y++) {
				for (int x = 0; x < universe.GetLength(0); x++) {
					universe[x, y] = false;
				}
			}

			generations = 0;

			timer.Enabled = false;

			toolStripStatusLabelGenerations.Text = "Generations = " + generations.ToString();

			graphicsPanel1.Invalidate();
		}

		private void startButton_Click(object sender, EventArgs e) {
			timer.Enabled = true;

			if (timer.Enabled) {
				timer.Tick += Timer_Tick;
			}

			graphicsPanel1.Invalidate();
		}

		private void pauseButton_Click(object sender, EventArgs e) {
			timer.Enabled = false;

			graphicsPanel1.Invalidate();
		}

		private int CountNeighbors(int x, int y) {
			int livingNeighbors = 0;
			for (int j = -1; j <= 1; j++) {
				for (int i = -1; i <= 1; i++) {
					if (x + i <= universe.GetLength(0) - 1 && y + j <= universe.GetLength(1) - 1 && x + i >= 0 && y + j >= 0) {
						if (i != 0 || j != 0) {
							if (universe[x + i, y + j]) {
								livingNeighbors++;
							}
						}
					}
				}
			}

			return livingNeighbors;
		}

		private void stepButton_Click(object sender, EventArgs e) {
			NextGeneration();
		}

		private void seeNeighborCountToggle_Click(object sender, EventArgs e) {
			seeNeighborCount = !seeNeighborCount;

			graphicsPanel1.Invalidate();
		}

		private void saveToolStripButton_Click(object sender, EventArgs e) {
			SaveFileDialog dlg = new SaveFileDialog();
			dlg.Filter      = "All Files|*.*|Cells|*.cells";
			dlg.FilterIndex = 2;
			dlg.DefaultExt  = "cells";

			if (DialogResult.OK == dlg.ShowDialog()) {
				StreamWriter writer = new StreamWriter(dlg.FileName);

				//Iterate through the universe one row at a time.
				for (int y = 0; y < universe.GetLength(1); y++) {
					//Create a string to represent the current row.
					String currentRow = string.Empty;

					//Iterate through the current row one cell at a time.
					for (int x = 0; x < universe.GetLength(0); x++) {
						if (universe[x, y]) {
							currentRow += 'O';
						} else {
							currentRow += '.';
						}
					}

					writer.WriteLine(currentRow);
				}

				writer.Close();
			}
		}

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
						if (maxWidth < row.Length) {
							maxWidth = row.Length;
						}
					}
				}


				//Resize the current universe and scratchPad
				//to the width and height of the file calculated above.
				universe   = new bool[maxWidth, maxHeight];
				scratchPad = new bool[universe.GetLength(0), universe.GetLength(1)];

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
							if (row[xPos] == 'O') {
								scratchPad[xPos, yPos] = true;
							}

							//if row[xPos] is a '.' (period) then
							//set the corresponding cell in the universe to dead.
							if (row[xPos] == '.') {
								scratchPad[xPos, yPos] = false;
							}
						}

						yPos++;
					}
				}

				//Close the file.
				reader.Close();
				graphicsPanel1.Invalidate();
			}
		}

		private void darkModeToolStripMenuItem_Click(object sender, EventArgs e) {
			gridColor      = Color.DarkSlateGray;
			cellColor      = Color.Teal;
			emptyCellColor = Color.LightSlateGray;

			graphicsPanel1.Invalidate();
		}

		private void lightModeToolStripMenuItem_Click(object sender, EventArgs e) {
			gridColor      = Color.SlateGray;
			cellColor      = Color.Black;
			emptyCellColor = Color.White;

			graphicsPanel1.Invalidate();
		}

		//TODO: Make grid resizeable
	}
}