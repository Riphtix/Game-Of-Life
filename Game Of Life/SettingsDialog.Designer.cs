using System.ComponentModel;
using Game_Of_Life.Properties;

namespace Game_Of_Life {
	partial class SettingsDialog {
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private IContainer components = null;

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
			this.components        = new System.ComponentModel.Container();
			this.button1           = new System.Windows.Forms.Button();
			this.button2           = new System.Windows.Forms.Button();
			this.label1            = new System.Windows.Forms.Label();
			this.label2            = new System.Windows.Forms.Label();
			this.label3            = new System.Windows.Forms.Label();
			this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
			this.comboBox1         = new System.Windows.Forms.ComboBox();
			this.button3           = new System.Windows.Forms.Button();
			this.label4            = new System.Windows.Forms.Label();
			this.label5            = new System.Windows.Forms.Label();
			this.button4           = new System.Windows.Forms.Button();
			this.label6            = new System.Windows.Forms.Label();
			this.button5           = new System.Windows.Forms.Button();
			this.textBox1          = new System.Windows.Forms.TextBox();
			this.textBox2          = new System.Windows.Forms.TextBox();
			this.SuspendLayout();
			// 
			// button1
			// 
			this.button1.Anchor                  = ((System.Windows.Forms.AnchorStyles) ((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.button1.DialogResult            = System.Windows.Forms.DialogResult.OK;
			this.button1.Location                = new System.Drawing.Point(54, 215);
			this.button1.Name                    = "button1";
			this.button1.Size                    = new System.Drawing.Size(72, 24);
			this.button1.TabIndex                = 0;
			this.button1.Text                    = "Done";
			this.button1.UseVisualStyleBackColor = true;
			// 
			// button2
			// 
			this.button2.Anchor                  = ((System.Windows.Forms.AnchorStyles) ((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.button2.DialogResult            = System.Windows.Forms.DialogResult.Cancel;
			this.button2.Location                = new System.Drawing.Point(139, 215);
			this.button2.Name                    = "button2";
			this.button2.Size                    = new System.Drawing.Size(72, 24);
			this.button2.TabIndex                = 1;
			this.button2.Text                    = "Cancel";
			this.button2.UseVisualStyleBackColor = true;
			// 
			// label1
			// 
			this.label1.Location  = new System.Drawing.Point(34, 22);
			this.label1.Name      = "label1";
			this.label1.Size      = new System.Drawing.Size(75, 15);
			this.label1.TabIndex  = 3;
			this.label1.Text      = "Cell X Count";
			this.label1.TextAlign = System.Drawing.ContentAlignment.BottomRight;
			// 
			// label2
			// 
			this.label2.Location  = new System.Drawing.Point(34, 52);
			this.label2.Name      = "label2";
			this.label2.Size      = new System.Drawing.Size(75, 15);
			this.label2.TabIndex  = 5;
			this.label2.Text      = "Cell Y Count";
			this.label2.TextAlign = System.Drawing.ContentAlignment.BottomRight;
			// 
			// label3
			// 
			this.label3.Location  = new System.Drawing.Point(34, 78);
			this.label3.Name      = "label3";
			this.label3.Size      = new System.Drawing.Size(75, 15);
			this.label3.TabIndex  = 7;
			this.label3.Text      = "Theme";
			this.label3.TextAlign = System.Drawing.ContentAlignment.BottomRight;
			// 
			// contextMenuStrip1
			// 
			this.contextMenuStrip1.Name = "contextMenuStrip1";
			this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
			// 
			// comboBox1
			// 
			this.comboBox1.DropDownStyle     = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.comboBox1.FormattingEnabled = true;
			this.comboBox1.Items.AddRange(new object[] {"DARK", "LIGHT", "CUSTOM"});
			this.comboBox1.Location             =  new System.Drawing.Point(111, 75);
			this.comboBox1.Name                 =  "comboBox1";
			this.comboBox1.Size                 =  new System.Drawing.Size(100, 23);
			this.comboBox1.TabIndex             =  8;
			this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
			// 
			// button3
			// 
			this.button3.Location                =  new System.Drawing.Point(111, 103);
			this.button3.Name                    =  "button3";
			this.button3.Size                    =  new System.Drawing.Size(31, 28);
			this.button3.TabIndex                =  9;
			this.button3.UseVisualStyleBackColor =  true;
			this.button3.Click                   += new System.EventHandler(this.button3_Click);
			// 
			// label4
			// 
			this.label4.Location  = new System.Drawing.Point(34, 112);
			this.label4.Name      = "label4";
			this.label4.Size      = new System.Drawing.Size(75, 15);
			this.label4.TabIndex  = 10;
			this.label4.Text      = "Grid Color";
			this.label4.TextAlign = System.Drawing.ContentAlignment.BottomRight;
			// 
			// label5
			// 
			this.label5.Location  = new System.Drawing.Point(34, 147);
			this.label5.Name      = "label5";
			this.label5.Size      = new System.Drawing.Size(75, 15);
			this.label5.TabIndex  = 12;
			this.label5.Text      = "Cell Color";
			this.label5.TextAlign = System.Drawing.ContentAlignment.BottomRight;
			// 
			// button4
			// 
			this.button4.Location                =  new System.Drawing.Point(111, 138);
			this.button4.Name                    =  "button4";
			this.button4.Size                    =  new System.Drawing.Size(31, 28);
			this.button4.TabIndex                =  11;
			this.button4.UseVisualStyleBackColor =  true;
			this.button4.Click                   += new System.EventHandler(this.button4_Click);
			// 
			// label6
			// 
			this.label6.Location  = new System.Drawing.Point(13, 180);
			this.label6.Name      = "label6";
			this.label6.Size      = new System.Drawing.Size(96, 15);
			this.label6.TabIndex  = 14;
			this.label6.Text      = "Living Cell Color";
			this.label6.TextAlign = System.Drawing.ContentAlignment.BottomRight;
			// 
			// button5
			// 
			this.button5.Location                =  new System.Drawing.Point(111, 172);
			this.button5.Name                    =  "button5";
			this.button5.Size                    =  new System.Drawing.Size(31, 28);
			this.button5.TabIndex                =  13;
			this.button5.UseVisualStyleBackColor =  true;
			this.button5.Click                   += new System.EventHandler(this.button5_Click);
			// 
			// textBox1
			// 
			this.textBox1.Location = new System.Drawing.Point(111, 18);
			this.textBox1.Name     = "textBox1";
			this.textBox1.Size     = new System.Drawing.Size(100, 23);
			this.textBox1.TabIndex = 15;
			// 
			// textBox2
			// 
			this.textBox2.Location = new System.Drawing.Point(111, 46);
			this.textBox2.Name     = "textBox2";
			this.textBox2.Size     = new System.Drawing.Size(100, 23);
			this.textBox2.TabIndex = 16;
			// 
			// SettingsDialog
			// 
			this.AcceptButton        = this.button1;
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
			this.AutoScaleMode       = System.Windows.Forms.AutoScaleMode.Font;
			this.CancelButton        = this.button2;
			this.ClientSize          = new System.Drawing.Size(227, 254);
			this.Controls.Add(this.textBox2);
			this.Controls.Add(this.textBox1);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.button5);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.button4);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.button3);
			this.Controls.Add(this.comboBox1);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.button2);
			this.Controls.Add(this.button1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.MaximizeBox     = false;
			this.MinimizeBox     = false;
			this.Name            = "SettingsDialog";
			this.StartPosition   = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text            = "Settings Dialog";
			this.ResumeLayout(false);
			this.PerformLayout();
		}

		#endregion

		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
		private System.Windows.Forms.ComboBox comboBox1;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Button button3;
		private System.Windows.Forms.Button button5;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Button button4;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.TextBox textBox2;
		private System.Windows.Forms.TextBox textBox1;
	}
}