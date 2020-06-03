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
	/// Summary description for Form3.
	/// </summary>
	public class Form3 : System.Windows.Forms.Form
	{
		short[] circleXvalue = new short[360];
		short[] circleYvalue = new short[360];
		float[] errorVector = new float[360];
		static Image selectImage;
		

		private System.Windows.Forms.Panel GraphArea;
		private System.Windows.Forms.Button btnContinue;
		private System.Windows.Forms.Label lblMag;
		private System.Windows.Forms.Label lblAng;
		private System.Windows.Forms.Label lbltxtMag;
		private System.Windows.Forms.Label lbltxtAng;
		private System.Windows.Forms.Label label1;
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.Container components = null;

		public Form3()
		{
			//
			// Required for Windows Form Designer support
			//
			InitializeComponent();
			selectImage=(Image)Form1.myImage.Clone();
			

			for (ushort i=0; i<=359; i++)
			{
				circleXvalue[i]=Convert.ToInt16(Form1.hcp+Math.Cos(Math.PI*i/180)*Math.Round(Form1.rp*220));
				circleYvalue[i]=Convert.ToInt16(Form1.vcp+Math.Sin(Math.PI*i/180)*Math.Round(Form1.rp*220));
			}

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
			this.GraphArea = new System.Windows.Forms.Panel();
			this.label1 = new System.Windows.Forms.Label();
			this.lbltxtAng = new System.Windows.Forms.Label();
			this.lbltxtMag = new System.Windows.Forms.Label();
			this.lblAng = new System.Windows.Forms.Label();
			this.lblMag = new System.Windows.Forms.Label();
			this.btnContinue = new System.Windows.Forms.Button();
			this.GraphArea.SuspendLayout();
			this.SuspendLayout();
			// 
			// GraphArea
			// 
			this.GraphArea.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.GraphArea.Controls.Add(this.label1);
			this.GraphArea.Controls.Add(this.lbltxtAng);
			this.GraphArea.Controls.Add(this.lbltxtMag);
			this.GraphArea.Controls.Add(this.lblAng);
			this.GraphArea.Controls.Add(this.lblMag);
			this.GraphArea.Location = new System.Drawing.Point(0, 0);
			this.GraphArea.Name = "GraphArea";
			this.GraphArea.Size = new System.Drawing.Size(640, 480);
			this.GraphArea.TabIndex = 26;
			this.GraphArea.Paint += new System.Windows.Forms.PaintEventHandler(this.GraphArea_Paint);
			this.GraphArea.MouseDown += new System.Windows.Forms.MouseEventHandler(this.GraphArea_MouseDown);
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(208, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(232, 16);
			this.label1.TabIndex = 6;
			this.label1.Text = "Select the Load point on constant gain circle";
			// 
			// lbltxtAng
			// 
			this.lbltxtAng.Location = new System.Drawing.Point(40, 32);
			this.lbltxtAng.Name = "lbltxtAng";
			this.lbltxtAng.Size = new System.Drawing.Size(48, 16);
			this.lbltxtAng.TabIndex = 5;
			// 
			// lbltxtMag
			// 
			this.lbltxtMag.Location = new System.Drawing.Point(40, 16);
			this.lbltxtMag.Name = "lbltxtMag";
			this.lbltxtMag.Size = new System.Drawing.Size(56, 16);
			this.lbltxtMag.TabIndex = 4;
			// 
			// lblAng
			// 
			this.lblAng.Location = new System.Drawing.Point(8, 32);
			this.lblAng.Name = "lblAng";
			this.lblAng.Size = new System.Drawing.Size(32, 16);
			this.lblAng.TabIndex = 1;
			this.lblAng.Text = "Ang=";
			// 
			// lblMag
			// 
			this.lblMag.Location = new System.Drawing.Point(8, 16);
			this.lblMag.Name = "lblMag";
			this.lblMag.Size = new System.Drawing.Size(40, 16);
			this.lblMag.TabIndex = 0;
			this.lblMag.Text = "Mag=";
			// 
			// btnContinue
			// 
			this.btnContinue.Enabled = false;
			this.btnContinue.Location = new System.Drawing.Point(280, 488);
			this.btnContinue.Name = "btnContinue";
			this.btnContinue.TabIndex = 27;
			this.btnContinue.Text = "Continue";
			this.btnContinue.Click += new System.EventHandler(this.btnContinue_Click);
			// 
			// Form3
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.ClientSize = new System.Drawing.Size(640, 512);
			this.Controls.Add(this.GraphArea);
			this.Controls.Add(this.btnContinue);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
			this.Name = "Form3";
			this.ShowInTaskbar = false;
			this.Text = "Amplifer Design";
			this.GraphArea.ResumeLayout(false);
			this.ResumeLayout(false);

		}
		#endregion

		private void GraphArea_Paint(object sender, System.Windows.Forms.PaintEventArgs e)
		{
			e.Graphics.DrawImageUnscaled(selectImage,0,0);
		}

		private void GraphArea_MouseDown(object sender, System.Windows.Forms.MouseEventArgs e)
		{
			selectImage=(Image)Form1.myImage.Clone();
			using(Graphics selectGraph= Graphics.FromImage(selectImage))
			{

				int pointIndex = 0;
				float minError = 640*640+480*480; //Max number that it is possible to have

				for (ushort i=0; i<=359;i++)
				{
					errorVector[i] = Convert.ToSingle((e.X-circleXvalue[i])*(e.X-circleXvalue[i])
						+ (e.Y-circleYvalue[i])*(e.Y-circleYvalue[i]));
					if (errorVector[i] < minError)
					{
						pointIndex = i; //at the end pintIndex has the angle as well
						minError = errorVector[i];
					}
				}

				selectGraph.DrawEllipse(Pens.Red,circleXvalue[pointIndex]-1,circleYvalue[pointIndex]-1,2,2); //Draw circles to indicate the selected point
				selectGraph.DrawEllipse(Pens.Red,circleXvalue[pointIndex]-2,circleYvalue[pointIndex]-2,4,4);

				
				GraphArea.Invalidate();
				GraphArea.Update();

				Form1.ml=Math.Sqrt(Math.Pow(circleXvalue[pointIndex]-320,2)+Math.Pow(circleYvalue[pointIndex]-240,2))/220; //220=Gama(1), Center point is 320,240
				Form1.al1=(pointIndex<180)?(-pointIndex):(360-pointIndex); //Make it in +/- format

				this.lbltxtAng.Text=Convert.ToString(Form1.al1);
				this.lbltxtMag.Text=Convert.ToString(Math.Round(Form1.ml,3));
				
				this.btnContinue.Enabled=true; //enables the Continue botton that user can decide between continuing the design or re-selecting the point
			}
		}

		private void btnContinue_Click(object sender, System.EventArgs e)
		{
			selectImage.Dispose();
			this.Close();		
		}
	}
}
