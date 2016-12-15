/*
 * 由SharpDevelop创建。
 * 用户： shinexus
 * 日期: 2016/11/30
 * 时间: 15:07
 * 
 * 要改变这种模板请点击 工具|选项|代码编写|编辑标准头文件
 */
namespace madns
{
	partial class MainForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		
		private System.Windows.Forms.Panel panel_basePanel;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.TextBox textBox2;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.OpenFileDialog openFileDialog_openImgFile;
		private System.Windows.Forms.Button button3;
		
		/// <summary>
		/// Disposes resources used by the form.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent()
		{
			this.panel_basePanel = new System.Windows.Forms.Panel();
			this.button3 = new System.Windows.Forms.Button();
			this.button2 = new System.Windows.Forms.Button();
			this.textBox2 = new System.Windows.Forms.TextBox();
			this.button1 = new System.Windows.Forms.Button();
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.openFileDialog_openImgFile = new System.Windows.Forms.OpenFileDialog();
			this.panel_basePanel.SuspendLayout();
			this.SuspendLayout();
			// 
			// panel_basePanel
			// 
			this.panel_basePanel.Controls.Add(this.button3);
			this.panel_basePanel.Controls.Add(this.button2);
			this.panel_basePanel.Controls.Add(this.textBox2);
			this.panel_basePanel.Controls.Add(this.button1);
			this.panel_basePanel.Controls.Add(this.textBox1);
			this.panel_basePanel.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panel_basePanel.Location = new System.Drawing.Point(0, 0);
			this.panel_basePanel.Name = "panel_basePanel";
			this.panel_basePanel.Size = new System.Drawing.Size(284, 261);
			this.panel_basePanel.TabIndex = 0;
			// 
			// button3
			// 
			this.button3.Location = new System.Drawing.Point(12, 227);
			this.button3.Name = "button3";
			this.button3.Size = new System.Drawing.Size(75, 23);
			this.button3.TabIndex = 4;
			this.button3.Text = "button3";
			this.button3.UseVisualStyleBackColor = true;
			this.button3.Click += new System.EventHandler(this.button3_Click);
			// 
			// button2
			// 
			this.button2.Location = new System.Drawing.Point(197, 200);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(75, 23);
			this.button2.TabIndex = 3;
			this.button2.Text = "打开";
			this.button2.UseVisualStyleBackColor = true;
			this.button2.Click += new System.EventHandler(this.Button2Click);
			// 
			// textBox2
			// 
			this.textBox2.Location = new System.Drawing.Point(12, 200);
			this.textBox2.Name = "textBox2";
			this.textBox2.Size = new System.Drawing.Size(172, 21);
			this.textBox2.TabIndex = 2;
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(160, 111);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(75, 23);
			this.button1.TabIndex = 1;
			this.button1.Text = "button1";
			this.button1.UseVisualStyleBackColor = true;
			// 
			// textBox1
			// 
			this.textBox1.Location = new System.Drawing.Point(119, 72);
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(100, 21);
			this.textBox1.TabIndex = 0;
			// 
			// openFileDialog_openImgFile
			// 
			this.openFileDialog_openImgFile.FileName = "openFileDialog1";
			this.openFileDialog_openImgFile.Filter = "图片文件 (*.BMP;*.JPG;*.GIF;*.PNG)|*.BMP;*.JPG;*.GIF|All files (*.*)|*.* ";
			this.openFileDialog_openImgFile.FileOk += new System.ComponentModel.CancelEventHandler(this.OpenFileDialog1FileOk);
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(284, 261);
			this.Controls.Add(this.panel_basePanel);
			this.Name = "MainForm";
			this.Text = ".:mands:.";
			this.panel_basePanel.ResumeLayout(false);
			this.panel_basePanel.PerformLayout();
			this.ResumeLayout(false);

		}
	}
}