/*
Copyright 2009 by Kiavash

Licensed under the Apache License, Version 2.0 (the "License");
you may not use this file except in compliance with the License.
You may obtain a copy of the License at

    https://www.apache.org/licenses/LICENSE-2.0

Unless required by applicable law or agreed to in writing, software
distributed under the License is distributed on an "AS IS" BASIS,
WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
See the License for the specific language governing permissions and
limitations under the License.
*/


using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;

namespace AmpDesign
{
	/// <summary>
	/// Summary description for Form2.
	/// </summary>
	public class Form2 : System.Windows.Forms.Form
	{
		private System.Windows.Forms.Label lbldB;
		private System.Windows.Forms.TextBox txtGp;
		private System.Windows.Forms.Label lblGp;
		private System.Windows.Forms.Button btnGpOK;
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.Container components = null;

		public Form2()
		{
			//
			// Required for Windows Form Designer support
			//
			InitializeComponent();
			
			this.lbldB.Text+=Convert.ToString(Math.Round(Form1.Gpmd,1))
							+"dB";
			//
			// TODO: Add any constructor code after InitializeComponent call
			//
		}

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		protected override void Dispose( bool disposing )
		{
			if( disposing )
			{
				if(components != null)
				{
					components.Dispose();
				}
			}
			base.Dispose( disposing );
		}

		#region Windows Form Designer generated code
		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.lbldB = new System.Windows.Forms.Label();
			this.txtGp = new System.Windows.Forms.TextBox();
			this.lblGp = new System.Windows.Forms.Label();
			this.btnGpOK = new System.Windows.Forms.Button();
			this.SuspendLayout();
			//
			// lbldB
			//
			this.lbldB.Location = new System.Drawing.Point(56, 8);
			this.lbldB.Name = "lbldB";
			this.lbldB.Size = new System.Drawing.Size(72, 16);
			this.lbldB.TabIndex = 26;
			this.lbldB.Text = "dB < ";
			//
			// txtGp
			//
			this.txtGp.Location = new System.Drawing.Point(24, 8);
			this.txtGp.Name = "txtGp";
			this.txtGp.Size = new System.Drawing.Size(32, 20);
			this.txtGp.TabIndex = 25;
			this.txtGp.Text = "";
			this.txtGp.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtGp_KeyPress);
			//
			// lblGp
			//
			this.lblGp.Location = new System.Drawing.Point(0, 8);
			this.lblGp.Name = "lblGp";
			this.lblGp.Size = new System.Drawing.Size(24, 16);
			this.lblGp.TabIndex = 24;
			this.lblGp.Text = "Gp";
			//
			// btnGpOK
			//
			this.btnGpOK.Location = new System.Drawing.Point(144, 0);
			this.btnGpOK.Name = "btnGpOK";
			this.btnGpOK.Size = new System.Drawing.Size(40, 32);
			this.btnGpOK.TabIndex = 23;
			this.btnGpOK.Text = "OK";
			this.btnGpOK.Click += new System.EventHandler(this.btnGpOK_Click);
			//
			// Form2
			//
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.ClientSize = new System.Drawing.Size(186, 32);
			this.Controls.Add(this.lbldB);
			this.Controls.Add(this.txtGp);
			this.Controls.Add(this.lblGp);
			this.Controls.Add(this.btnGpOK);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "Form2";
			this.ShowInTaskbar = false;
			this.Text = "Amplifer Design";
			this.ResumeLayout(false);

		}
		#endregion

		private void btnGpOK_Click(object sender, System.EventArgs e)
		{
			
			if ((this.txtGp.Text!="") && (Convert.ToDouble(this.txtGp.Text)<Form1.Gpmd))
			{
				//this.txtGp.BackColor=Color.White;
				Form1.Gpd=Convert.ToDouble(this.txtGp.Text);
				Form1.myTag=true;
				this.Close();
			}
			else
			{
				//this.txtGp.Text="";
				this.txtGp.BackColor=Color.Red;
			}
			
		}

		private void txtGp_KeyPress(object sender, System.Windows.Forms.KeyPressEventArgs e)
		{
			if ((e.KeyChar < 48 || e.KeyChar > 57) && e.KeyChar != 8
				&& e.KeyChar != Convert.ToChar("."))

				e.Handled = true; // Remove the character
		}
	}
}
