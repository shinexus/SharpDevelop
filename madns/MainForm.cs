/*
 * 由SharpDevelop创建。
 * 用户： shinexus
 * 日期: 2016/11/30
 * 时间: 15:07
 * 
 * 要改变这种模板请点击 工具|选项|代码编写|编辑标准头文件
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace madns
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class MainForm : Form
	{
		public MainForm()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
			
			
		}
		void Button2Click(object sender, EventArgs e)
		{
			openFileDialog_openImgFile.ShowDialog();
			
			if (openFileDialog_openImgFile.ShowDialog() == DialogResult.OK) {
				textBox2.Text = openFileDialog_openImgFile.FileName;
			}
			
		}
		void OpenFileDialog1FileOk(object sender, System.ComponentModel.CancelEventArgs e)
		{
	
		}
		
	}
}
