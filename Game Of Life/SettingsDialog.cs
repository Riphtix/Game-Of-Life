using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;
using Game_Of_Life.Properties;

namespace Game_Of_Life {
	public partial class SettingsDialog : Form {
		public string Width {
			get => textBox1.Text;
			set => textBox1.Text = value;
		}

		public string Height {
			get => textBox2.Text;
			set => textBox2.Text = value;
		}

		public string Theme {
			get => comboBox1?.SelectedItem?.ToString();
			set => comboBox1.Text = value;
		}

		public Color[] ColorButtons {
			get => new[] {button3.BackColor, button4.BackColor, button5.BackColor};
			set {
				button3.BackColor = value[0];
				button4.BackColor = value[1];
				button5.BackColor = value[2];
			}
		}

		public SettingsDialog() {
			InitializeComponent();

			textBox1.Text = Settings.Default.Width.ToString();
			textBox2.Text = Settings.Default.Height.ToString();

			button3.BackColor = Settings.Default.LineColor;
			button4.BackColor = Settings.Default.BackColor;
			button5.BackColor = Settings.Default.LivingCellColor;
		}

		private void button3_Click(object sender, EventArgs e) {
			ColorDialog dlg = new ColorDialog();
			dlg.Color = button3.BackColor;

			if (DialogResult.OK == dlg.ShowDialog()) {
				button3.BackColor = dlg.Color;
				if (button3.BackColor != Color.DarkSlateGray || button3.BackColor != Color.DarkGray)
					Theme = "CUSTOM";
			}

			Invalidate();
		}

		private void button4_Click(object sender, EventArgs e) {
			ColorDialog dlg = new ColorDialog();
			dlg.Color = button4.BackColor;

			if (DialogResult.OK == dlg.ShowDialog()) {
				button4.BackColor = dlg.Color;
				if (button4.BackColor != Color.LightSlateGray || button4.BackColor != Color.White)
					Theme = "CUSTOM";
			}

			Invalidate();
		}

		private void button5_Click(object sender, EventArgs e) {
			ColorDialog dlg = new ColorDialog();
			dlg.Color = button5.BackColor;

			if (DialogResult.OK == dlg.ShowDialog()) {
				button5.BackColor = dlg.Color;
				if (button5.BackColor != Color.Teal || button5.BackColor != Color.Black)
					Theme = "CUSTOM";
			}

			Invalidate();
		}

		private void comboBox1_SelectedIndexChanged(object sender, EventArgs e) {
			if (Theme == "DARK") {
				ColorButtons = new[] {Color.DarkSlateGray, Color.LightSlateGray, Color.Teal};
			}

			if (Theme == "LIGHT") {
				ColorButtons = new[] {Color.DarkGray, Color.White, Color.Black};
			}

			Invalidate();
		}
	}
}