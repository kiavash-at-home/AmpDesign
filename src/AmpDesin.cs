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
using System.Data;
using System.Drawing.Drawing2D;

namespace AmpDesign
{
	
	public class Form1 : System.Windows.Forms.Form
	{
		#region Global Variable Declaration

		private double
			a1,b1,a2,b2,a3,b3,a4,b4,ds,ds1,ds2,k1,k2,k,c21,c22,
			e,b,bb1,bb2,asr,f,g,s1,s2,ms,As,c3,m,n,a,
			b6,m2,z2,h,h1,asd,v,v1,s5,t5,
			s6,t6,y,z,m1,z1,rb,xb1,xb2,xb,ra,rc,xc1,xc2,xc,gb,bb,gc,bc,
			ang1,ang2,ang3,ga,hb,vb,x1,x2,x3,x4,y1,y2,y3,y4,f1,f2,f3,f4
			,gp,gp1,
			z5,re1,he,ve,mp,hl,vl,
			rp1,rp2,cp1,cp2,al,re,im1,ap,
			apr,apd,arcAB,
			arcBC,ay,g2,Xcen,h11,v11,swr,rads,reb,imb,Hb1,Vb1,
			mb,ab,abr,abd,asl,lsl,aop,lop,z0,gc2,bc2,my,
			ayr,rl1,rl2,rl,cl1,cl2,Hcl,Vcl,Scl,Srl,rs1,rs2,rs,cs1,cs2,Hcs,Vcs,
			Scs,Srs,Gpd1,Gpm,xc11,xc12,
			 lslSource, lslLoad, lopSource, lopLoad; 

		public static double
			Gpd,Gpmd,rp,hcp,vcp,ml,al1;

		public static bool myTag = false;

		private string 
			st1,st2,st3,st4,st5,st6,stt1,stt2,s32,s33,sabd,ss9;
		
		public static Image myImage=new Bitmap(640,480);
		Graphics myGraph= Graphics.FromImage(myImage);
		#endregion

		#region Visual Stodio Takes Care of this Part
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.TextBox txtS11Mag;
		private System.Windows.Forms.TextBox txtS11Ang;
		private System.Windows.Forms.TextBox txtS12Ang;
		private System.Windows.Forms.TextBox txtS12Mag;
		private System.Windows.Forms.TextBox txtS22Ang;
		private System.Windows.Forms.TextBox txtS22Mag;
		private System.Windows.Forms.TextBox txtS21Ang;
		private System.Windows.Forms.TextBox txtS21Mag;
		private System.Windows.Forms.Button btnOK;
		private System.Windows.Forms.TextBox txtOutput;
		private System.Windows.Forms.Label LblS11;
		private System.Windows.Forms.Label lblS12;
		private System.Windows.Forms.Label lblS22;
		private System.Windows.Forms.Label lblS21;
		private System.Windows.Forms.RadioButton rbnLamped;
		private System.Windows.Forms.RadioButton rbtDistributed;
		private System.Windows.Forms.RadioButton rbtNone;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.GroupBox grpSparam;
		private System.Windows.Forms.GroupBox grpMatching;
		private System.Windows.Forms.TextBox txtZ0;
		private System.Windows.Forms.Label lblZ0;
		private System.Windows.Forms.Label lblOhm;
		private System.Windows.Forms.Panel GraphArea;
		private System.Windows.Forms.MainMenu mainMenu;
		private System.Windows.Forms.MenuItem menuFile;
		private System.Windows.Forms.MenuItem menuAbout;
		private System.Windows.Forms.MenuItem menuExit;
		private System.Windows.Forms.MenuItem menuItem1;

		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.Container components = null;

		public Form1()
		{
			//
			// Required for Windows Form Designer support
			//
			InitializeComponent();
			this.txtS11Ang.Tag=false;
			this.txtS21Ang.Tag=false;
			this.txtS12Ang.Tag=false;
			this.txtS22Ang.Tag=false;
			this.txtS11Mag.Tag=false;
			this.txtS21Mag.Tag=false;
			this.txtS12Mag.Tag=false;
			this.txtS22Mag.Tag=false;
			
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
				if (components != null) 
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
			System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(Form1));
			this.LblS11 = new System.Windows.Forms.Label();
			this.txtS11Mag = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.txtS11Ang = new System.Windows.Forms.TextBox();
			this.txtS12Ang = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.txtS12Mag = new System.Windows.Forms.TextBox();
			this.lblS12 = new System.Windows.Forms.Label();
			this.txtS22Ang = new System.Windows.Forms.TextBox();
			this.txtS22Mag = new System.Windows.Forms.TextBox();
			this.lblS22 = new System.Windows.Forms.Label();
			this.txtS21Ang = new System.Windows.Forms.TextBox();
			this.txtS21Mag = new System.Windows.Forms.TextBox();
			this.lblS21 = new System.Windows.Forms.Label();
			this.grpSparam = new System.Windows.Forms.GroupBox();
			this.btnOK = new System.Windows.Forms.Button();
			this.txtOutput = new System.Windows.Forms.TextBox();
			this.grpMatching = new System.Windows.Forms.GroupBox();
			this.lblOhm = new System.Windows.Forms.Label();
			this.rbtNone = new System.Windows.Forms.RadioButton();
			this.rbtDistributed = new System.Windows.Forms.RadioButton();
			this.rbnLamped = new System.Windows.Forms.RadioButton();
			this.txtZ0 = new System.Windows.Forms.TextBox();
			this.lblZ0 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.GraphArea = new System.Windows.Forms.Panel();
			this.mainMenu = new System.Windows.Forms.MainMenu();
			this.menuFile = new System.Windows.Forms.MenuItem();
			this.menuAbout = new System.Windows.Forms.MenuItem();
			this.menuExit = new System.Windows.Forms.MenuItem();
			this.menuItem1 = new System.Windows.Forms.MenuItem();
			this.grpSparam.SuspendLayout();
			this.grpMatching.SuspendLayout();
			this.SuspendLayout();
			// 
			// LblS11
			// 
			this.LblS11.Location = new System.Drawing.Point(16, 32);
			this.LblS11.Name = "LblS11";
			this.LblS11.Size = new System.Drawing.Size(24, 16);
			this.LblS11.TabIndex = 0;
			this.LblS11.Text = "S11";
			// 
			// txtS11Mag
			// 
			this.txtS11Mag.Location = new System.Drawing.Point(40, 32);
			this.txtS11Mag.MaxLength = 5;
			this.txtS11Mag.Name = "txtS11Mag";
			this.txtS11Mag.Size = new System.Drawing.Size(40, 20);
			this.txtS11Mag.TabIndex = 1;
			this.txtS11Mag.Text = "";
			this.txtS11Mag.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_KeyPress);
			this.txtS11Mag.TextChanged += new System.EventHandler(this.txtBox_TextChanged);
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(48, 16);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(32, 16);
			this.label2.TabIndex = 2;
			this.label2.Text = "Mag";
			// 
			// label3
			// 
			this.label3.Location = new System.Drawing.Point(88, 16);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(24, 16);
			this.label3.TabIndex = 3;
			this.label3.Text = "Ang";
			// 
			// txtS11Ang
			// 
			this.txtS11Ang.Location = new System.Drawing.Point(80, 32);
			this.txtS11Ang.MaxLength = 5;
			this.txtS11Ang.Name = "txtS11Ang";
			this.txtS11Ang.Size = new System.Drawing.Size(40, 20);
			this.txtS11Ang.TabIndex = 4;
			this.txtS11Ang.Text = "";
			this.txtS11Ang.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_KeyPress);
			this.txtS11Ang.TextChanged += new System.EventHandler(this.txtBox_TextChanged);
			// 
			// txtS12Ang
			// 
			this.txtS12Ang.Location = new System.Drawing.Point(192, 32);
			this.txtS12Ang.MaxLength = 5;
			this.txtS12Ang.Name = "txtS12Ang";
			this.txtS12Ang.Size = new System.Drawing.Size(40, 20);
			this.txtS12Ang.TabIndex = 9;
			this.txtS12Ang.Text = "";
			this.txtS12Ang.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_KeyPress);
			this.txtS12Ang.TextChanged += new System.EventHandler(this.txtBox_TextChanged);
			// 
			// label4
			// 
			this.label4.Location = new System.Drawing.Point(200, 16);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(24, 16);
			this.label4.TabIndex = 8;
			this.label4.Text = "Ang";
			// 
			// label5
			// 
			this.label5.Location = new System.Drawing.Point(160, 16);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(32, 16);
			this.label5.TabIndex = 7;
			this.label5.Text = "Mag";
			// 
			// txtS12Mag
			// 
			this.txtS12Mag.Location = new System.Drawing.Point(152, 32);
			this.txtS12Mag.MaxLength = 5;
			this.txtS12Mag.Name = "txtS12Mag";
			this.txtS12Mag.Size = new System.Drawing.Size(40, 20);
			this.txtS12Mag.TabIndex = 6;
			this.txtS12Mag.Text = "";
			this.txtS12Mag.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_KeyPress);
			this.txtS12Mag.TextChanged += new System.EventHandler(this.txtBox_TextChanged);
			// 
			// lblS12
			// 
			this.lblS12.Location = new System.Drawing.Point(128, 32);
			this.lblS12.Name = "lblS12";
			this.lblS12.Size = new System.Drawing.Size(24, 16);
			this.lblS12.TabIndex = 5;
			this.lblS12.Text = "S12";
			// 
			// txtS22Ang
			// 
			this.txtS22Ang.Location = new System.Drawing.Point(192, 56);
			this.txtS22Ang.MaxLength = 5;
			this.txtS22Ang.Name = "txtS22Ang";
			this.txtS22Ang.Size = new System.Drawing.Size(40, 20);
			this.txtS22Ang.TabIndex = 15;
			this.txtS22Ang.Text = "";
			this.txtS22Ang.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_KeyPress);
			this.txtS22Ang.TextChanged += new System.EventHandler(this.txtBox_TextChanged);
			// 
			// txtS22Mag
			// 
			this.txtS22Mag.Location = new System.Drawing.Point(152, 56);
			this.txtS22Mag.MaxLength = 5;
			this.txtS22Mag.Name = "txtS22Mag";
			this.txtS22Mag.Size = new System.Drawing.Size(40, 20);
			this.txtS22Mag.TabIndex = 14;
			this.txtS22Mag.Text = "";
			this.txtS22Mag.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_KeyPress);
			this.txtS22Mag.TextChanged += new System.EventHandler(this.txtBox_TextChanged);
			// 
			// lblS22
			// 
			this.lblS22.Location = new System.Drawing.Point(128, 56);
			this.lblS22.Name = "lblS22";
			this.lblS22.Size = new System.Drawing.Size(24, 16);
			this.lblS22.TabIndex = 13;
			this.lblS22.Text = "S22";
			// 
			// txtS21Ang
			// 
			this.txtS21Ang.Location = new System.Drawing.Point(80, 56);
			this.txtS21Ang.MaxLength = 5;
			this.txtS21Ang.Name = "txtS21Ang";
			this.txtS21Ang.Size = new System.Drawing.Size(40, 20);
			this.txtS21Ang.TabIndex = 12;
			this.txtS21Ang.Text = "";
			this.txtS21Ang.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_KeyPress);
			this.txtS21Ang.TextChanged += new System.EventHandler(this.txtBox_TextChanged);
			// 
			// txtS21Mag
			// 
			this.txtS21Mag.Location = new System.Drawing.Point(40, 56);
			this.txtS21Mag.MaxLength = 5;
			this.txtS21Mag.Name = "txtS21Mag";
			this.txtS21Mag.Size = new System.Drawing.Size(40, 20);
			this.txtS21Mag.TabIndex = 11;
			this.txtS21Mag.Text = "";
			this.txtS21Mag.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_KeyPress);
			this.txtS21Mag.TextChanged += new System.EventHandler(this.txtBox_TextChanged);
			// 
			// lblS21
			// 
			this.lblS21.Location = new System.Drawing.Point(16, 56);
			this.lblS21.Name = "lblS21";
			this.lblS21.Size = new System.Drawing.Size(24, 16);
			this.lblS21.TabIndex = 10;
			this.lblS21.Text = "S21";
			// 
			// grpSparam
			// 
			this.grpSparam.Controls.Add(this.btnOK);
			this.grpSparam.Location = new System.Drawing.Point(8, 0);
			this.grpSparam.Name = "grpSparam";
			this.grpSparam.Size = new System.Drawing.Size(288, 96);
			this.grpSparam.TabIndex = 16;
			this.grpSparam.TabStop = false;
			this.grpSparam.Text = "2-port S-parameters";
			// 
			// btnOK
			// 
			this.btnOK.Enabled = false;
			this.btnOK.Location = new System.Drawing.Point(232, 32);
			this.btnOK.Name = "btnOK";
			this.btnOK.Size = new System.Drawing.Size(40, 24);
			this.btnOK.TabIndex = 0;
			this.btnOK.Text = "OK";
			this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
			// 
			// txtOutput
			// 
			this.txtOutput.Location = new System.Drawing.Point(496, 16);
			this.txtOutput.Multiline = true;
			this.txtOutput.Name = "txtOutput";
			this.txtOutput.ReadOnly = true;
			this.txtOutput.Size = new System.Drawing.Size(152, 80);
			this.txtOutput.TabIndex = 17;
			this.txtOutput.Text = "";
			// 
			// grpMatching
			// 
			this.grpMatching.Controls.Add(this.lblOhm);
			this.grpMatching.Controls.Add(this.rbtNone);
			this.grpMatching.Controls.Add(this.rbtDistributed);
			this.grpMatching.Controls.Add(this.rbnLamped);
			this.grpMatching.Controls.Add(this.txtZ0);
			this.grpMatching.Controls.Add(this.lblZ0);
			this.grpMatching.Location = new System.Drawing.Point(304, 0);
			this.grpMatching.Name = "grpMatching";
			this.grpMatching.Size = new System.Drawing.Size(184, 96);
			this.grpMatching.TabIndex = 23;
			this.grpMatching.TabStop = false;
			this.grpMatching.Text = "Design Matching";
			// 
			// lblOhm
			// 
			this.lblOhm.Location = new System.Drawing.Point(144, 40);
			this.lblOhm.Name = "lblOhm";
			this.lblOhm.Size = new System.Drawing.Size(32, 16);
			this.lblOhm.TabIndex = 26;
			this.lblOhm.Text = "Ohms";
			this.lblOhm.Visible = false;
			// 
			// rbtNone
			// 
			this.rbtNone.Checked = true;
			this.rbtNone.Location = new System.Drawing.Point(8, 64);
			this.rbtNone.Name = "rbtNone";
			this.rbtNone.Size = new System.Drawing.Size(56, 24);
			this.rbtNone.TabIndex = 2;
			this.rbtNone.TabStop = true;
			this.rbtNone.Text = "None";
			this.rbtNone.Click += new System.EventHandler(this.rbt_Click);
			// 
			// rbtDistributed
			// 
			this.rbtDistributed.Location = new System.Drawing.Point(8, 40);
			this.rbtDistributed.Name = "rbtDistributed";
			this.rbtDistributed.Size = new System.Drawing.Size(80, 24);
			this.rbtDistributed.TabIndex = 1;
			this.rbtDistributed.Text = "Distributed";
			this.rbtDistributed.Click += new System.EventHandler(this.rbt_Click);
			// 
			// rbnLamped
			// 
			this.rbnLamped.Location = new System.Drawing.Point(8, 16);
			this.rbnLamped.Name = "rbnLamped";
			this.rbnLamped.Size = new System.Drawing.Size(64, 24);
			this.rbnLamped.TabIndex = 0;
			this.rbnLamped.Text = "Lamped";
			this.rbnLamped.Click += new System.EventHandler(this.rbt_Click);
			// 
			// txtZ0
			// 
			this.txtZ0.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.txtZ0.Location = new System.Drawing.Point(112, 40);
			this.txtZ0.Name = "txtZ0";
			this.txtZ0.Size = new System.Drawing.Size(32, 13);
			this.txtZ0.TabIndex = 25;
			this.txtZ0.Text = "50";
			this.txtZ0.Visible = false;
			this.txtZ0.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_KeyPress);
			// 
			// lblZ0
			// 
			this.lblZ0.Location = new System.Drawing.Point(88, 40);
			this.lblZ0.Name = "lblZ0";
			this.lblZ0.Size = new System.Drawing.Size(24, 16);
			this.lblZ0.TabIndex = 25;
			this.lblZ0.Text = "Z0=";
			this.lblZ0.Visible = false;
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(496, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(96, 16);
			this.label1.TabIndex = 24;
			this.label1.Text = "Operation Mode:";
			// 
			// GraphArea
			// 
			this.GraphArea.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.GraphArea.Location = new System.Drawing.Point(8, 104);
			this.GraphArea.Name = "GraphArea";
			this.GraphArea.Size = new System.Drawing.Size(640, 480);
			this.GraphArea.TabIndex = 25;
			this.GraphArea.SizeChanged += new System.EventHandler(this.OnSizeChanged);
			this.GraphArea.Paint += new System.Windows.Forms.PaintEventHandler(this.OnPaint);
			// 
			// mainMenu
			// 
			this.mainMenu.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
																					 this.menuFile,
																					 this.menuItem1});
			// 
			// menuFile
			// 
			this.menuFile.Index = 0;
			this.menuFile.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
																					 this.menuExit});
			this.menuFile.Text = "&File";
			// 
			// menuAbout
			// 
			this.menuAbout.Index = 0;
			this.menuAbout.Text = "&About";
			this.menuAbout.Click += new System.EventHandler(this.menuAbout_Click);
			// 
			// menuExit
			// 
			this.menuExit.Index = 0;
			this.menuExit.Text = "E&xit";
			this.menuExit.Click += new System.EventHandler(this.menuItem3_Click);
			// 
			// menuItem1
			// 
			this.menuItem1.Index = 1;
			this.menuItem1.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
																					  this.menuAbout});
			this.menuItem1.Text = "&Help";
			// 
			// Form1
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.ClientSize = new System.Drawing.Size(656, 590);
			this.Controls.Add(this.GraphArea);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.grpMatching);
			this.Controls.Add(this.txtOutput);
			this.Controls.Add(this.txtS22Ang);
			this.Controls.Add(this.txtS22Mag);
			this.Controls.Add(this.txtS21Ang);
			this.Controls.Add(this.txtS21Mag);
			this.Controls.Add(this.txtS12Ang);
			this.Controls.Add(this.txtS12Mag);
			this.Controls.Add(this.txtS11Ang);
			this.Controls.Add(this.txtS11Mag);
			this.Controls.Add(this.lblS22);
			this.Controls.Add(this.lblS21);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.lblS12);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.LblS11);
			this.Controls.Add(this.grpSparam);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximizeBox = false;
			this.Menu = this.mainMenu;
			this.Name = "Form1";
			this.Text = "Amplifer Design";
			this.grpSparam.ResumeLayout(false);
			this.grpMatching.ResumeLayout(false);
			this.ResumeLayout(false);

		}
		#endregion

		/// <summary>
		/// The main entry point for the application.
		/// </summary>
		[STAThread]
		static void Main() 
		{
			Application.Run(new Form1());
		}


		#endregion

		#region circle
		private void circle(double xCenter,double yCenter,double radius)
		{
			circle(Pens.Black,xCenter,yCenter,radius);
		}

		private void circle(Pen myPen,double xCenter,double yCenter,double radius)
		{
			float r = Convert.ToSingle(radius);
			float xCorner = (Convert.ToSingle(xCenter)-r);
			float yCorner = (Convert.ToSingle(yCenter)-r);

			myGraph.DrawEllipse(myPen,xCorner,yCorner,2*r,2*r);
		}
		#endregion
	
		#region str
		private void str(double d,ref string s)
		{
			s=Convert.ToString(Math.Round(d,3));
		}
		#endregion

		#region window
		private void window(Brush myBrush,double a,double b,double c,double d)
		{
			Rectangle rect = new Rectangle(Convert.ToInt16(a),Convert.ToInt16(b)
				,Convert.ToInt16(Font.Size*(c-a)),Convert.ToInt16(Font.Height*(d-b)));
			myGraph.FillRectangle(myBrush,rect);
		}
		private void window(double a,double b,double c,double d)
		{
			window(Brushes.White,a,b,c,d);
		}
		#endregion

		#region outtextxy
		private void outtextxy(double x,double y,string s)
		{
			outtextxy(Brushes.Black,x,y,s);
		}
		private void outtextxy(Brush myBrush,double x,double y,string s)
		{
			outtextxy(Brushes.Black,x,y,s,false);
		}
		private void outtextxy(Brush myBrush,double x,double y,string s,bool txtVertical)
		{
			StringFormat newStringFormat = new StringFormat();

			int yCorner = Convert.ToInt16(y);
			if (txtVertical)
			{
				newStringFormat.FormatFlags = StringFormatFlags.DirectionVertical;
				yCorner -= (int)(s.Length*Font.Size);
			}

			myGraph.DrawString(s,Font,myBrush,Convert.ToInt16(x),Convert.ToInt16(y),newStringFormat);
		}
		#endregion


		#region arc

		private void arc(Pen myPen,double xCenter, double yCenter, double StartAngle, double EndAngle,double radius)
		{
			float r = Convert.ToSingle(radius);
			float xCorner = (Convert.ToSingle((xCenter))-r);
			float yCorner = (Convert.ToSingle(yCenter)-r);

			myGraph.DrawArc(myPen,xCorner+0,yCorner,2*r,2*r,360-Convert.ToSingle(StartAngle),Convert.ToSingle(StartAngle-EndAngle));
		}
		#endregion

		#region line
		private void line(int xStart,int yStart,int xEnd,int yEnd)
		{
			line(Pens.Black,xStart,yStart,xEnd,yEnd);
		}

		private void line(Pen myPen,int xStart,int yStart,int xEnd,int yEnd)
		{
			myGraph.DrawLine(myPen,xStart,yStart,xEnd,yEnd);
		}

		#endregion

		#region indicating(m,n,Gpd1)
		//---------------------------private void INDICATING--------------------------

		private void indicating(double m,double n, double Gpd1)
		{
			y = Math.PI;
			z = (y * n) / 180;
			s5 = m * Math.Cos(z);
			t5 = m * Math.Sin(z);
			h = (s5 * 220) + 320;
			v = 240 - (t5 * 220);
			rc = (1 - Math.Pow(m, 2)) / (1 + Math.Pow(m, 2) - (2 * m * Math.Cos(z)));
			xc1 = (1 + (m * Math.Cos(z))) * (1 + Math.Pow(m,2) - (2 * m * Math.Cos(z))) - ((1 - Math.Pow(m,2)) * (1 - (m * Math.Cos(z))));
			xc2 = (m * Math.Sin(z)) * (1 + Math.Pow(m,2) - (2 * m * Math.Cos(z)));
			if (xc2 == 0)
				xc = 0;
			else
				xc = xc1 / xc2;
			gc = rc / (Math.Pow(rc,2) + Math.Pow(xc,2));
			bc = (-xc) / (Math.Pow(rc,2) + Math.Pow(xc,2));

			smithchart();
			circle(Pens.Red,Math.Round(h),Math.Round(v),1);
			circle(Pens.Red,Math.Round(h),Math.Round(v),2);

			if (Gpd1!=0)
				outtextxy(230,1,"Gp = Gp max ="+Convert.ToString(Math.Round(Gpd1,2))
					+" dB");

			outtextxy(1,10,"m=");
			str(m,ref st1);
			outtextxy(30,10,st1);
			outtextxy(1,30,"a=");
			str(n,ref st2);
			outtextxy(30,30,st2);
			outtextxy(1,50,"rc=");
			str(rc,ref st3);
			outtextxy(30,50,st3);
			outtextxy(1,70,"xc=");
			str(xc,ref st4);
			outtextxy(30,70,st4);

		} /*private void indicating*/

		#endregion

		#region smithchart()
		private void smithchart()
		{
			double x,r,radius;

			myGraph.Clear(this.BackColor);

			r=0;
			while (r<=10)
			{
				radius=Math.Round((1/(r+1))*220);
				circle(Pens.Green,860-(radius+320),240,radius);
				r+=0.5;
			}


			x=0.3;
			while (x<=10)
			{

				a=Math.Atan((1-(x*x))/(2*x));
				radius=Math.Round(1/(Math.Abs(x))*220);
				const int xCenter=540;
				int yCenter=(int)Math.Round((1/x)*220);
				int startAngle=(int)Math.Round((180/Math.PI)*a);
				const int endAngle=270;
				arc(Pens.Green,xCenter,240-yCenter,180+startAngle,endAngle,radius);
				arc(Pens.Green,xCenter,240+yCenter,180-startAngle,endAngle-180,radius);
				x+=0.5;
			}
			line(Pens.Green,100,240,540,240);
		}

		#endregion

		#region smithchart2()
		/*-------------------------SMITH CHART2----------------------------
		DRAWING IMPEDANCE & ADMITANCE smithchart()*/
		private void smithchart2() 
		{
			double j,g1;

			smithchart();

			g1=0;
			while (g1<=10)
			{
				int radius=(int)Math.Round((1/(g1+1))*220);
				circle(Pens.DarkBlue,320-(Math.Round((g1/(g1+1))*220)),240,radius);
				g1+=0.5;
			}
			b6=0.3;
			while (b6<=10)
			{
				j=Math.Atan((Math.Pow(b6,2)-1)/(2*b6));
				int radius1=(int)Math.Round(1/Math.Abs(b6)*220);
				const int xCenter=100;
				int yCenter=(int)Math.Round((1/b6)*220);
				int startAngle=(int)Math.Round(((180/Math.PI)*j));
				const int endAngle=270;
				arc(Pens.DarkBlue,xCenter,240-yCenter,360+startAngle,endAngle,radius1);
				arc(Pens.DarkBlue,xCenter,240+yCenter,0-startAngle,endAngle-180,radius1);
				b6+=0.5;
			}
		}/*smithchart2()*/

		#endregion

		#region matching(ml,al1,c3)
		private void matching(double m, double n, double c3)
		{
			
			y=Math.PI;
			z=(y*n)/180;
			z5=(n+180)*(y/180);

			z0=Convert.ToDouble(this.txtZ0.Text);

			rc=(1-Math.Pow(m,2))/(1+Math.Pow(m,2)-(2*m*Math.Cos(z)));
			xc1=((1+(m*Math.Cos(z)))*(1+Math.Pow(m,2)-(2*m*Math.Cos(z))))-((1-Math.Pow(m,2))*(1-(m*Math.Cos(z))));
			xc2=(m*Math.Sin(z))*(1+Math.Pow(m,2)-(2*m*Math.Cos(z)));

			if (xc2==0)
				xc=0;
			else
				xc=xc1/xc2;

			gc=rc/(Math.Pow(rc,2)+Math.Pow(xc,2));
			bc=(-1*xc)/(Math.Pow(rc,2)+Math.Pow(xc,2));
			gc2=gc*(z0/50);
			bc2=bc*(z0/50);

			s5=(Math.Pow(gc2,2)+Math.Pow(bc2,2)-1)/(Math.Pow(1+gc2,2)+Math.Pow(bc2,2)); /*real of ys or yl*/
			t5=(2*bc2)/(Math.Pow(1+gc2,2)+Math.Pow(bc2,2)); /*image of ys or yl*/

			my=Math.Sqrt(Math.Pow(s5,2)+Math.Pow(t5,2));
			ayr=Math.Atan(t5/s5);

			if ((s5<0)&&(t5>0))
				ay=180+(ayr*(180/y));

			else

			{

				if ((s5<0)&&(t5<0))
					ay=-180+(ayr*(180/y));

				else
					ay=ayr*(180/y);

			}

			h11=(s5*220)+320;
			v11=240-(t5*220);
			circle(Pens.Red,Math.Round(h11),Math.Round(v11),1);
			circle(Pens.Red,Math.Round(h11),Math.Round(v11),2);

			if (c3==1) /*SOURCE REF. COF.*/

			{

				outtextxy(1,1,"mys=");
				str(my,ref st3);
				outtextxy(30,1,st3);
				outtextxy(1,20,"ays=");
				str(ay,ref st4);
				outtextxy(35,20,st4);

				outtextxy(1,40,"ys="+Convert.ToString(Math.Round(gc2,3))+((bc2<0)?"-j":"+j")+
					Convert.ToString(Math.Round(Math.Abs(bc2),3)));


				outtextxy(Brushes.Red,Math.Round(h11-3),Math.Round(v11+7),"ys");

			}

			else  /*LOAD REF.COF.*/

			{

				outtextxy(1,1,"myl=");
				str(my,ref st3);
				outtextxy(30,1,st3);
				outtextxy(1,20,"ayl=");
				str(ay,ref st4);
				outtextxy(30,20,st4);

				outtextxy(1,40,"yl="+Convert.ToString(Math.Round(gc,3))+((bc2<0)?"-j":"+j")+
					Convert.ToString(Math.Round(Math.Abs(bc2),3)));

				
				//setcolor(4);
				outtextxy(Brushes.Red,Math.Round(h11-3),Math.Round(v11+7),"yl");

			}


			swr=(1+Math.Abs(my))/(1-Math.Abs(my));
			rads=(swr-1)/(swr+1);  /*radius of constant swr circle*/

			g2=z0/50;
			reb=(g2-1+(Math.Pow(rads,2)*(g2+1)))/(2*g2);
			imb=Math.Sqrt(Math.Pow(rads,2)-Math.Pow(reb,2));

			Hb1=320+(reb*220);
			Vb1=240-(imb*220);

			circle(Pens.Blue,Math.Round(Hb1),Math.Round(Vb1),1);
			circle(Pens.Blue,Math.Round(Hb1),Math.Round(Vb1),2);

			outtextxy(Brushes.Blue,Math.Round(Hb1-3),Math.Round(Vb1-13),"B");

			mb=Math.Sqrt(Math.Pow(reb,2)+Math.Pow(imb,2));
			abr=Math.Atan(imb/reb);

			if ((reb<0)&&(imb>0))
				abd=180+(abr*(180/y));

			else

			{

				if ((reb<0)&&(imb<0))
					abd=-180+(abr*(180/y));
				else
					abd=abr*(180/y);

			}


			if (Math.Abs(ay)>2) /* ARC BC */
			{
				arc(Pens.Red,320,240,Math.Round(ay),Math.Round(abd),Math.Round(rads*220));
			}

			else /*Math.Abs(ay)<2*/

			{
				arc(Pens.Red,320,240,Math.Round((double)0),Math.Round(abd),Math.Round(rads*220));
			}
   
			Xcen=g2/(g2+1);  /* ARC AB */

			if (Xcen<reb)

			{
				ab=( Math.Atan( imb/ (reb- (g2/(g2+1)) ) ) )*(180/Math.PI);
				arc(Pens.Blue,Math.Round(320+((g2/(g2+1))*220)),240,Math.Round(ab),180,Math.Round(220/(g2+1)));
			}

			else/*reb>0*/

			{
				ab=(Math.Atan(imb/((g2/(g2+1))-reb)))*(180/Math.PI);
				arc(Pens.Blue,Math.Round (320+( (g2*220) / (g2+1) ) ),240,Math.Round(180-ab),180,Math.Round(220/(g2+1)));
			}


			if ((ay>0)&&(ay>abd))
				asl=(360-(Math.Abs(abd-ay)))/2;
			else
				asl=Math.Abs(abd-ay)/2;

			lsl=asl/360;

			
			string sourceLoad;
			if (c3==1) /*SOURCE REF.cof.*/
			{
				sourceLoad="IN SOURCE= ";
				lslSource=lsl;
			}
			else /*LOAD REF.COF.*/
			{
				sourceLoad="IN LOAD= ";
				lslLoad=lsl;
			}
				
			outtextxy(Brushes.Black,10,120,"ANGLE OF SERIES LINE "+sourceLoad
				+Convert.ToString(Math.Round(asl,3))+" Deg",true);
			outtextxy(Brushes.Black,50,120,"LENGHT OF SERIES LINE "+sourceLoad
				+Convert.ToString(Math.Round(lsl,3))+" Lambda",true);


			m1=mb;
			z1=abr;
			rb=(1-Math.Pow(m1,2))/(1+Math.Pow(m1,2)-(2*m1*Math.Cos(z1)));
			xb1=((1+(m1*Math.Cos(z1)))*(1+Math.Pow(m1,2)-(2*m1*Math.Cos(z1))))
				-((1-Math.Pow(m1,2))*(1-(m1*Math.Cos(z1))));
			xb2=(m1*Math.Sin(z1))*(1+Math.Pow(m1,2)-(2*m1*Math.Cos(z1)));
			if (xb2==0)
				xb=0;
			else
				xb=xb1/xb2;
			gb=rb/(Math.Pow(rb,2)+Math.Pow(xb,2));
			bb=xb/(Math.Pow(rb,2)+Math.Pow(xb,2));
			outtextxy(540,1,"mb=");
			str(mb,ref ss9);
			outtextxy(570,1,ss9);

			outtextxy(540,20,"ab=");
			str(abd,ref sabd);
			outtextxy(570,20,sabd);

			outtextxy(540,40,"yb="+Convert.ToString(Math.Round(rb,3))+((xb<0)?"-j":"+j")+
				Convert.ToString(Math.Round(Math.Abs(xb),3)));


			aop=(Math.Atan(xb))* (180/y); /*ELECTRICAL LENGHT*/

			lop=aop/360;

            if (c3==1) /*SOURCE REF.cof.*/
			{
				sourceLoad="IN SOURCE= ";
				lopSource=lop;
			}
			else /*LOAD REF.COF.*/
			{
				sourceLoad="IN LOAD= ";
				lopLoad=lop;
			}
				
			outtextxy(Brushes.Black,550,120,"ANGLE OF OPEN CIRCUITE STUB "+sourceLoad
				+Convert.ToString(Math.Round(aop,3))+" Deg",true);
			outtextxy(Brushes.Black,590,120,"LENGHT OF OPEN CIRCUITE STUB "+sourceLoad
				+Convert.ToString(Math.Round(lop,3))+" Lambda",true);

			if (c3==1) /*source ref.cof.*/

			{

				GraphArea.Invalidate();
				GraphArea.Update();
				if(MessageBox.Show("Do you Want the schematic of the Amplifier?",
					"Amplifer Design",MessageBoxButtons.YesNo, MessageBoxIcon.Question)==DialogResult.Yes)
				{

					myGraph.Clear(this.BackColor);

					line(60,320,60,260);

					line(55,320,65,320);
					line(58,324,62,324);
					line(60,328,60,328);

					/*SOURCE*/
					circle(60,250,10);
					outtextxy(57,245,"~");
					outtextxy(6,245,"Vs<0");
					circle(40,244,2);
					outtextxy(51,225,"+");
					outtextxy(51,260,"-");

					line(60,240,60,190);

					line(60,190,110,190);

					/*INPUT RESISTANT*/
					line(110,190,112,185);
					line(112,185,114,195);
					line(114,195,117,185);
					line(117,185,120,195);
					line(120,195,123,185);
					line(123,185,125,190);
					outtextxy(110,170,"50");

					line(125,190,215,190);

					/*INPUT SERIES LINE*/
					line(215,180,215,200);
					line(215,200,265,200);
					line(265,200,265,180);
					line(265,180,215,180);
					outtextxy(215,165,Convert.ToString(Math.Round(lslSource,4)));

					/* WRITING WAVE LENGHT*/
					line(257,168,261,176);
					line(259,172,257,176);

					line(170,190,170,235);

					/*INPUT STUB*/
					line(160,235,180,235);
					line(180,235,180,285);
					line(180,285,160,285);
					line(160,285,160,235);
					outtextxy(182,253,Convert.ToString(Math.Round(lopSource,4)));

					line(227,256,231,264);
					line(229,260,227,264);

					line(265,190,315,190);

					/*TRANSISTOR*/
					line(315,180,315,200);
					line(315,200,335,200);
					line(335,200,335,180);
					line(335,180,315,180);
					outtextxy(318,182,"Tr");

					line(335,185,350,185);
					line(335,195,350,195);
					line(350,195,350,320);
					line(350,185,350,155);

					/*EARTH*/
					line(345,320,355,320);
					line(348,324,352,324);
					line(350,328,350,328);

					line(350,155,395,155);

					/*OUTPUT SERIES LINE*/
					line(395,145,395,165);
					line(395,165,445,165);
					line(445,165,445,145);
					line(445,145,395,145);
					outtextxy(395,130,Convert.ToString(Math.Round(lslLoad,4)));
					line(437,133,441,141);
					line(439,137,437,141);

					line(445,155,535,155);
					line(490,155,490,205);

					/*OUTPUT STUB*/
					line(480,205,500,205);
					line(500,205,500,255);
					line(500,255,480,255);
					line(480,255,480,205);
					outtextxy(428,223,Convert.ToString(Math.Round(lopLoad,4)));
					line(470,226,474,234);
					line(472,230,470,234);

					line(535,320,535,260);

					/*OUTPUT RESISTANT*/
					line(535,260,540,258);
					line(540,258,530,255);
					line(530,255,540,252);
					line(540,252,530,249);
					line(530,249,540,246);
					line(540,246,530,243);
					line(530,243,535,241);
					outtextxy(544,243,"50");

					line(535,241,535,155);

					/*EARTH*/
					line(530,320,540,320);
					line(533,324,537,324);
					line(535,328,535,328);
				}

			}

		}/* matching */
		
		#endregion

		#region lampedmatch(m,n,c3)
		/*------------------------private void LAMPEDMATCH-----------------------*/

		/*DESIGN MATCHING NETWORK WITH LAMPED ELEMENTS*/

		private void lampedmatch(double m, double n, double c3)

		{
			outtextxy(Brushes.Green,310,227,"A");
			if (c3==0)
			{
				outtextxy(1,10,"ml=");
				str(m,ref st1);
				outtextxy(30,10,st1);
				outtextxy(1,30,"al=");
				str(n,ref st2);
				outtextxy(30,30,st2);
			}
			else
			{
				outtextxy(1,10,"ms=");
				str(m,ref st1);
				outtextxy(30,10,st1);
				outtextxy(1,30,"as=");
				str(n,ref st2);
				outtextxy(30,30,st2);
			}

			y=Math.PI;
			z=(y*n)/180;
			s5=m*Math.Cos(z); /*real of point C*/
			t5=m*Math.Sin(z); /*image of point B*/
			h=(s5*220)+320;
			v=240-(t5*220);

			circle(Pens.Red,Math.Round(h),Math.Round(v),1);
			circle(Pens.Red,Math.Round(h),Math.Round(v),2);

			outtextxy(Brushes.Red,Math.Round(h-3),Math.Round(v-13),"C");

			rc=(1-Math.Pow(m,2))/(1+Math.Pow(m,2)-(2*m*Math.Cos(z)));
			xc11=((1+(m*Math.Cos(z)))*(1+Math.Pow(m,2)-(2*m*Math.Cos(z))));
			xc12=((1-Math.Pow(m,2))*(1-(m*Math.Cos(z))));
			xc1=xc11-xc12;
			xc2=(m*Math.Sin(z))*(1+Math.Pow(m,2)-(2*m*Math.Cos(z)));
			if (xc2==0)
				xc=0;
			else
				xc=xc1/xc2;
			gc=rc/(Math.Pow(rc,2)+Math.Pow(xc,2));
			bc=(-xc)/(Math.Pow(rc,2)+Math.Pow(xc,2));

			outtextxy(1,50,"rc=");
			str(rc,ref st3);
			outtextxy(30,50,st3);
			outtextxy(1,70,"xc=");
			str(xc,ref st4);
			outtextxy(30,70,st4);

			if (rc>1)
			{
				ra=1;
				s6=(ra-gc)/((2*ra*gc)+ra+gc); /*real of point B*/
				t6=Math.Sqrt(Math.Pow(1/(gc+1),2)-Math.Pow(s6+(gc/(gc+1)),2)); /*image of point B*/
				h1=(s6*220)+320;
				v1=240+(t6*220);
				circle(Pens.Blue,Math.Round(h1),Math.Round(v1),1);
				circle(Pens.Blue,Math.Round(h1),Math.Round(v1),2);

				outtextxy(Brushes.Blue,Math.Round(h1-3),Math.Round(v1-13),"B");

				/*Drawing Arc AB In rc>1*/

				ang1=(Math.Atan(t6/(0.5-s6)))*(180/Math.PI);

				if ((Math.Abs(s6)<0.5))

					arc(Pens.Red,(double)Math.Round((decimal)(320+(220/2))),240,180,Math.Round(180+ang1),110);

				else

					arc(Pens.Red,(double)Math.Round((decimal)(320+(220/2))),240,180,Math.Round(180-ang1),110);

				ang2=( Math.Atan(t5/(s5+(gc/(gc+1)))) )*(180/Math.PI);
				ang3=( Math.Atan(-t6/(s6+(gc/(gc+1)))) )*(180/Math.PI);

				arc( Pens.Red,Math.Round(((-gc/(gc+1))*220)+320),240,Math.Round(ang3),Math.Round(ang2),Math.Round((1/(gc+1))*220));

				m1=Math.Sqrt(Math.Pow(s6,2)+Math.Pow(t6,2));
				z1=Math.Atan(t6/s6);
				rb=(1-Math.Pow(m1,2))/(1+Math.Pow(m1,2)-(2*m1*Math.Cos(z1)));
				xb1=((1+(m1*Math.Cos(z1)))*(1+Math.Pow(m1,2)-(2*m1*Math.Cos(z1))))-((1-Math.Pow(m1,2))*(1-(m1*Math.Cos(z1))));
				xb2=(m1*Math.Sin(z1))*(1+Math.Pow(m1,2)-(2*m1*Math.Cos(z1)));

				if (xb2==0)
					xb=0;
				else
					xb=(-xb1)/xb2;

				gb=rb/(Math.Pow(rb,2)+Math.Pow(xb,2));
				bb=(-xb)/(Math.Pow(rb,2)+Math.Pow(xb,2));

				outtextxy(1,90,"rb=");
				str(rb,ref st5);
				outtextxy(22,90,st5);

				outtextxy(1,110,"xb=");
				str(xb,ref st6);
				outtextxy(22,110,st6);

				arcAB=xb;
				arcBC=bc-bb;

				string sourceLoad;
				if (c3==1) /*SOURCE REF.cof.*/
					sourceLoad="in source= ";
				else /*LOAD REF.COF.*/
					sourceLoad="in load= ";
				
				outtextxy(Brushes.Black,10,150,"Arc AB = series C "+sourceLoad
					+Convert.ToString(Math.Round(arcAB,3))+"j ohms",true);
				outtextxy(Brushes.Black,50,150,"Arc BC = Shunt L "+sourceLoad
					+Convert.ToString(Math.Round(arcBC,3))+"j mhos",true);


			}/*rc>1*/

			else/*rc<1*/

			{
				ga=1;
				s6=(rc-ga)/((2*rc*ga)+rc+ga);
				t6=-1*(Math.Sqrt(Math.Pow(1/(ga+1),2)-Math.Pow(s6+(ga/(ga+1)),2)));
				hb=(s6*220)+320;
				vb=240-(t6*220);
				m2=Math.Sqrt(Math.Pow(s6,2)+Math.Pow(t6,2));

				if (s6==0)
					z2=y/2;
				else
					z2=Math.Atan(t6/s6);

				gb=1;
				bb1=((1+(m2*Math.Cos(z2)))*(1+Math.Pow(m2,2)-(2*m2*Math.Cos(z2))))-((1-Math.Pow(m2,2))*(1-(m2*Math.Cos(z2))));
				bb2=(m2*Math.Sin(z2))*(1+Math.Pow(m2,2)-(2*m2*Math.Cos(z2)));

				if (bb2==0)
					bb=0;
				else
					bb=bb1/bb2;

				rb=rc;
				xb=(-1*bb)/(Math.Pow(gb,2)+Math.Pow(bb,2));

				outtextxy(1,90,"rb=");
				str(rb,ref stt1);
				outtextxy(30,90,stt1);
				outtextxy(1,110,"xb=");
				str(xb,ref stt2);
				outtextxy(30,110,stt2);
				circle(Pens.Blue,Math.Round(hb),Math.Round(vb),1);
				circle(Pens.Blue,Math.Round(hb),Math.Round(vb),2);

				outtextxy(Math.Round(hb-3),Math.Round(vb-13),"B");
				ang1=(Math.Atan(t6/(0.5+s6)))*(180/Math.PI);

				if ((Math.Abs(s6))<0.5)

					arc(Pens.Red,Math.Round(320-(0.5*220)),240,Math.Round(ang1),0,Math.Round(0.5*220)); /*Arc AB*/

				else

					arc(Pens.Red,Math.Round(320-(0.5*220)),240,Math.Round(180+ang1),0,Math.Round(0.5*220));

				ang2=( Math.Atan(-t5/((rc/(rc+1))-s5)) )*(180/Math.PI);
				ang3=( Math.Atan(-t6/((rc/(rc+1))-s6)) )*(180/Math.PI);

				arc( Pens.Red,Math.Round(((rc*220)/(rc+1))+320),240,Math.Round(-180+ang2),Math.Round(-180+ang3),Math.Round(220/(rc+1)) );/*Arc BC in rc<1*/

				arcAB=bb;
				arcBC=xc-xb;
				string sourceLoad;
				if (c3==1) /*SOURCE REF.cof.*/
					sourceLoad="in source= ";
				else /*LOAD REF.COF.*/
					sourceLoad="in load= ";
				outtextxy(Brushes.Black,20,245,"Arc AB = series C "+sourceLoad
					+Convert.ToString(Math.Round(arcAB,3))+"j ohms",true);
				outtextxy(Brushes.Black,50,250,"Arc BC = Shunt L "+sourceLoad
					+Convert.ToString(Math.Round(arcBC,3))+"j mhos",true);

			}/*rc<1*/

		}/*private void lampedmatch*/

		#endregion



		private void btnOK_Click(object sender, System.EventArgs Eventarg)
		{
			this.txtOutput.Text="";
			myTag = false;
			x1 = Convert.ToDouble(this.txtS11Mag.Text);
			y1 = Convert.ToDouble(this.txtS11Ang.Text);

			x2 = Convert.ToDouble(this.txtS12Mag.Text);
			y2 = Convert.ToDouble(this.txtS12Ang.Text);

			x3 = Convert.ToDouble(this.txtS21Mag.Text);
			y3 = Convert.ToDouble(this.txtS21Ang.Text);

			x4 = Convert.ToDouble(this.txtS22Mag.Text);
			y4 = Convert.ToDouble(this.txtS22Ang.Text);

			y = Math.PI;
			f1 = (y * y1) / 180;
			f2 = (y * y2) / 180;
			f3 = (y * y3) / 180;
			f4 = (y * y4) / 180;
			a1 = x1 * Math.Cos(f1);
			b1 = x1 * Math.Sin(f1);
			a2 = x2 * Math.Cos(f2);
			b2 = x2 * Math.Sin(f2);
			a3 = x3 * Math.Cos(f3);
			b3 = x3 * Math.Sin(f3);
			a4 = x4 * Math.Cos(f4);
			b4 = x4 * Math.Sin(f4);

			ds1 = (a1 * a4) - (b1 * b4) - (a2 * a3) + (b2 * b3);
			ds2 = (a1 * b4) + (a4 * b1) - (a2 * b3) - (a3 * b2);
			ds = Math.Sqrt(Math.Pow(ds1,2) + Math.Pow(ds2,2));

			if (x2 == 0)  /* UNILATERAL CASE */
				#region Unilateral Case Code
			{
				this.txtOutput.AppendText("Unilateral case\n");

				if ((x1 < 1) && (x2 < 1)) /*unilateral stable*/
					#region Unilateral Stable Code
				{
					this.txtOutput.AppendText("Unconditionally Stable\n");
					ml = x4;
					al1 = -y4;
					al = al1 * (Math.PI / 180);
					h = (ml * Math.Cos(al) * 220) + 320;
					v = 240 - (ml * Math.Sin(al) * 220);
										
					if (this.rbtDistributed.Checked)
					{
						smithchart();
						c3 = 0;
						matching(ml,al1,c3);
					}
					else if (this.rbnLamped.Checked)
					{
						smithchart2();
						c3=0;
						lampedmatch(ml,al1,c3);
					}
					else
					{
						indicating(ml,al1,Gpd1);
						outtextxy(Brushes.Red,Math.Round(h-3),Math.Round(v-13),"L"); //This line shows the "L" on the LOAD on Smith Chart
					}
					
					GraphArea.Invalidate();
					GraphArea.Update();
					
					MessageBox.Show ("Select OK to calculate source load.",
						"Amplifer Design",MessageBoxButtons.OK, MessageBoxIcon.Information);

					ms=x1;
					asd=-y1;
					As=asd*(Math.PI/180);
					h=(ms*Math.Cos(As)*220)+320;
					v=240-(ms*Math.Sin(As)*220);
					
					if (this.rbtDistributed.Checked)
					{
						smithchart();
						c3 = 1;
						matching(ms,asd,c3);
					}

					else if (this.rbnLamped.Checked)
					{
						smithchart2();
						c3=1;
						lampedmatch(ms,asd,c3);
					}
					else
					{
						indicating(ms,asd,Gpd1);
						outtextxy(Brushes.Red,Math.Round(h-3),Math.Round(v-13),"S"); //This line shows the "S" on the SOURCE on Smith Chart
					}
					GraphArea.Invalidate();
					GraphArea.Update();
				}
				#endregion

				else
					#region Unilateral Unstable Code
				{
					this.txtOutput.AppendText("Potentially Unstable\n");
					MessageBox.Show ("This software cannot design this case (Unilateral Case & Potentially Unstable)", "Amplifer Design",MessageBoxButtons.OK,MessageBoxIcon.Warning);
				}
					#endregion
			}
			#endregion
			else /* BILATERAL CASE */
				#region BILATERAL CASE CODE

			{
				k1=1+Math.Pow(ds1,2)+Math.Pow(ds2,2)-Math.Pow(a1,2)-Math.Pow(b1,2)
					-Math.Pow(a4,2)-Math.Pow(b4,2);
				k2=2*Math.Sqrt(Math.Pow(a3,2)+Math.Pow(b3,2))
					*Math.Sqrt(Math.Pow(a2,2)+Math.Pow(b2,2));
				k=k1/k2;
				this.txtOutput.AppendText("k=" + Convert.ToString(Math.Round(k,3))+"   "
					+ "Ds=" + Convert.ToString(Math.Round(ds,3))+"\n");

				if ((k > 1)&&(ds>1))
					MessageBox.Show ("It is impossible to design an amplifier with this transistor.",
						"Amplifer Design",MessageBoxButtons.OK, MessageBoxIcon.Warning);
				else if ((k > 1)&&(ds<1))
					#region Unconditionally Stable Code
				{
					this.txtOutput.AppendText("Unconditionally stable\n");
		
					Gpm=(x3/x2)*(k-Math.Sqrt(Math.Pow(k,2)-1));

					if (MessageBox.Show ("Do you want to design with an unspecified maximum operating power gain?"
						, "Amplifer Design",MessageBoxButtons.YesNo, MessageBoxIcon.Question)==DialogResult.Yes)
					{	/*User Decided to go for Max available Gain*/
						gp=Gpm/Math.Pow(x3,2);
						rp=0;
						Gpd1=10*((Math.Log(Gpm))/(Math.Log(10)));
					}
					else /* User Decided to Enter the Gain by itself*/
					{
						Gpmd=10*Math.Log10(Gpm);
						Form2 form = new Form2();
						
						while (myTag==false)
							form.ShowDialog(this);
												
						gp1=Math.Exp(Math.Log(10)*(Gpd/10));
						gp=gp1/Math.Pow(x3,2);
						Gpm=(x3/x2)*(k-Math.Sqrt(Math.Pow(k,2)-1));
						if (gp1==Gpm)
							rp=0;
						else
						{
							rp1=Math.Sqrt(1-(2*k*gp*x2*x3)+Math.Pow(x2*x3*gp,2));
							rp2=Math.Abs(1+(gp*(Math.Pow(x4,2)-Math.Pow(ds,2))));
							rp=rp1/rp2;
						}
					}
					c21=a4-(a1*ds1)-(b1*ds2);
					c22=b4-(a1*ds2)+(b1*ds1);
					cp1=(gp*c21)/(1+(gp*(Math.Pow(x4,2)-Math.Pow(ds,2))));
					cp2=-(gp*c22)/(1+(gp*(Math.Pow(x4,2)-Math.Pow(ds,2))));
					hcp=(cp1*220)+320;
					vcp=240-(cp2*220);

					if (myTag == false) /*max power*/
						#region Designs for MAG
					{
						ml=Math.Sqrt(Math.Pow(cp1,2)+Math.Pow(cp2,2));
						apr=Math.Atan(cp2/cp1);
						if ((cp1<0) && (cp2>0)) /*point is in the second area of plane*/
						{
							ap=y+apr;
							apd=180+(apr*(180/y));
						}
						else if ((cp1<0) && (cp2<0)) /*point is in the third area of plane*/
						{ 
							ap=-y+apr;
							apd=-180+(apr*(180/y));
						}
						else
						{
							ap=apr;
							apd=apr*(180/y);
						}
						
						al=ap;
						al1=apd;
						m=ml;
						n=al1;
						y=Math.PI;
						z=(y*n)/180;
						s5=m*Math.Cos(z);
						t5=m*Math.Sin(z);
						h=(s5*220)+320;
						v=240-(t5*220);
					}
						#endregion

					else /*constant gain circle*/
						#region Designs for the Entered Gain
					{
						/*-------------------DRAWING CONSTANT GAIN CIRCLE-------------------*/

						smithchart2();
						circle(Pens.Blue,Math.Round(hcp),Math.Round(vcp),Math.Round(rp*220));

                        outtextxy(Brushes.Black,550,120,"BLUE CIRCLE = CONSTANT GAIN CIRCLE",true);

						this.Height-=(this.GraphArea.Height+8);
						
						Form3 form = new Form3();
						form.ShowDialog(this);

						this.Height+=(this.GraphArea.Height+8);

						GraphArea.Invalidate();
						GraphArea.Update();	
						
						re=cp1-rp;
						re1=cp1+rp;
						im1=cp2;
						he=320+(220*re);
						ve=240-(220*im1);
						al=al1*Math.PI/180;
						mp=ml;

					}
					#endregion

					if (this.rbnLamped.Checked)
					{
						smithchart2();
						lampedmatch(ml,al1,0);
					}
					else if (this.rbtDistributed.Checked)
					{
						smithchart();
						matching(ml,al1,0);
					}
					else
					{
						indicating(ml,al1,0);
						outtextxy(Math.Round(h-3),Math.Round(v-13),"L"); //Print "L" on load point
					}

					outtextxy(230,1,"Gp ="+Convert.ToString(Math.Round(myTag?Gpd:Gpd1,2))
						+" dB");
					GraphArea.Invalidate();
					GraphArea.Update();
					
					MessageBox.Show ("Select OK to calculate source load.",
						"Amplifer Design",MessageBoxButtons.OK, MessageBoxIcon.Information);
						

					#region Source Calculation
					/*------------------ CALCULATING SOURCE REF. COF. ------------------*/
					e=(((a2*a3)-(b2*b3))*(ml*Math.Cos(al)))-(((a2*b3)+(a3*b2))*(ml*Math.Sin(al)));
					b=((a2*b3)+(a3*b2))*(ml*Math.Cos(al))+((a2*a3)-(b2*b3))*(ml*Math.Sin(al));
					f=1-(a4*ml*Math.Cos(al))+(b4*ml*Math.Sin(al));
					g=(a4*ml*Math.Sin(al))+(b4*ml*Math.Cos(al));
					s1=a1+(((e*f)-(b*g))/(Math.Pow(f,2)+Math.Pow(g,2)));
					s2=-b1-(((e*g)+(b*f))/(Math.Pow(f,2)+Math.Pow(g,2)));
					ms=Math.Sqrt(Math.Pow(s1,2)+Math.Pow(s2,2));
					asr=Math.Atan(s2/s1);
					if ((s2>0)&&(s1<0)) /*point is in the second area of plane*/

					{
						As=y+asr;
						asd=180+(asr*(180/y));
					}
					else if ((s2<0)&&(s1<0)) /*point is in the third area of plane*/

					{
						As=-y+asr;
						asd=-180+(asr*(180/y));
					}

					else

					{
						As=asr;
						asd=asr*(180/y);
					}

					
					/*SOURCE*/

					y=Math.PI;
					m=ms;
					n=asd;
					z=(y*n)/180;
					s5=m*Math.Cos(z);
					t5=m*Math.Sin(z);
					h=(s5*220)+320;
					v=240-(t5*220);

					rc=(1-Math.Pow(m,2))/(1+Math.Pow(m,2)-(2*m*Math.Cos(z)));
					xc1=((1+(m*Math.Cos(z)))*(1+Math.Pow(m,2)-(2*m*Math.Cos(z))))-((1-Math.Pow(m,2))*(1-(m*Math.Cos(z))));
					xc2=(m*Math.Sin(z))*(1+Math.Pow(m,2)-(2*m*Math.Cos(z)));

					if (xc2==0)
						xc=0;
					else
						xc=xc1/xc2;

					window(1,1,16,11);
					outtextxy(1,10,"ms=");
					str(ms,ref st1);
					outtextxy(30,10,st1);
					outtextxy(1,30,"as=");
					str(asd,ref st2);
					outtextxy(30,30,st2);
					outtextxy(1,50,"rc=");
					str(rc,ref st3);
					outtextxy(30,50,st3);
					outtextxy(1,70,"xc=");
					str(xc,ref st4);
					outtextxy(30,70,st4);
					if (this.rbnLamped.Checked)
					{
					
						smithchart2();
						lampedmatch(ms,asd,1);
					}
					else if (this.rbtDistributed.Checked)
					{
						smithchart();
						matching(ms,asd,1);
					}
					else
					{
						indicating(ms,asd,0);
						outtextxy(Math.Round(h-3),Math.Round(v-13),"S");
					}
					outtextxy(230,1,"Gp ="+Convert.ToString(Math.Round(myTag?Gpd:Gpd1,2))						+" dB");
					GraphArea.Invalidate();
					GraphArea.Update();
					#endregion
					
				} /*k>1 */
				#endregion
				else /*k<1* or ds>1*/
					#region Potentially unstable Code
				{
					this.txtOutput.AppendText("Potentially unstable\n");
					Gpm=x3/x2;
					Gpmd=10*(Math.Log(Gpm)/Math.Log(10));

					Form2 form = new Form2();
						
					while (myTag==false)
						form.ShowDialog(this);
					
					gp1=Math.Exp(Math.Log(10)*(Gpd/10));
					gp=gp1/Math.Pow(x3,2);

					rp1=Math.Sqrt(1-(2*k*gp*x2*x3)+Math.Pow(x2*x3*gp,2));
					rp2=Math.Abs(1+(gp*(Math.Pow(x4,2)-Math.Pow(ds,2))));
					rp=rp1/rp2;

					c21=a4-(a1*ds1)-(b1*ds2);
					c22=b4-(a1*ds2)+(b1*ds1);
					cp1=(gp*c21)/(1+(gp*(Math.Pow(x4,2)-Math.Pow(ds,2))));

					cp2=-(gp*c22)/(1+(gp*(Math.Pow(x4,2)-Math.Pow(ds,2))));

					hcp=(cp1*220)+320;
					vcp=240-(cp2*220);

					/*-------Repeat Drawing Constant Gain & Output Stability Circle------*/
					/* ------Until Source Ref.Cof. Is Good------*/

					do //this area make sure that source point is inside the stable area
					{ /*Don"t Select Source Ref.Cof.*/
						#region loops until user decides that the L & S points are fine
						smithchart2();

						circle(Pens.Blue,Math.Round(hcp),Math.Round(vcp),Math.Round(rp*220)); /*constant gain circle*/

						//-------DRAWING OUTPUT STABILITY CIRCLE--------


						rl1=((a3*a2)-(b3*b2))/(Math.Pow(x4,2)-Math.Pow(ds,2));
						rl2=((a3*b2)+(a2*b3))/(Math.Pow(x4,2)-Math.Pow(ds,2));
						rl=Math.Sqrt(Math.Pow(rl1,2)+Math.Pow(rl2,2));

						cl1=(a4-(a1*ds1)-(b1*ds2))/(Math.Pow(x4,2)-Math.Pow(ds,2));
						cl2=(-b4+(a1*ds2)-(b1*ds2))/(Math.Pow(x4,2)-Math.Pow(ds,2));
						Hcl=(cl1*220)+320;
						Vcl=240-(cl2*220);

						circle(Pens.Red,Math.Round(Hcl),Math.Round(Vcl),Math.Round(rl*220));/*output stability circle*/
						outtextxy(Brushes.Black,550,120,"Blue Circle = Constant Gain Circle",true);
						outtextxy(Brushes.Black,590,120,"Red Circle = Output Stability Circle",true);

						Scl=Math.Pow(cl1,2)+Math.Pow(cl2,2);
						Srl=Math.Pow(rl,2);

						if (Scl>Srl)
						{ /*center of smithchart() is out of output stability circle*/
							if (x1<1)
								outtextxy(Brushes.Black,620,60,"Stable Region Is Out Of Output Stability Circle",true);
							else
								outtextxy(Brushes.Black,620,60,"Stable Region Is In The Stability Circle",true);
						} /*(Scl>Srl)*/
						else
						{/*center of smith chart is in the output stability circle*/
							if (x1<1)
								outtextxy(Brushes.Black,620,60,"Stable Region Is In The Output Stability Circle",true);

							else/*x1>1*/
								outtextxy(Brushes.Black,620,60,"Stable Region Is Out Of Output Stability Circle",true);
						} /*Sc1<=Sr1*/



						this.Height-=(this.GraphArea.Height+8);
						
						Form3 smith = new Form3();
						smith.ShowDialog(this);

						this.Height+=(this.GraphArea.Height+8);

						GraphArea.Invalidate();
						GraphArea.Update();	

						mp=ml;
						al=al1*Math.PI/180;
						ap=al;
						hl=320+(ml*Math.Cos(al)*220);
						vl=240-(ml*Math.Sin(al)*220);

						re=cp1-rp;
						re1=cp1+rp;
						im1=cp2;

						
						#region CALCULATING SOURCE REFLECTION COF.
						/*------------CALCULATING SOURCE REFLECTION COF.-----------*/


						e=(((a2*a3)-(b2*b3))*(ml*Math.Cos(al)))-(((a2*b3)+(a3*b2))*(ml*Math.Sin(al)));
						b=((a2*b3)+(a3*b2))*(ml*Math.Cos(al))+((a2*a3)-(b2*b3))*(ml*Math.Sin(al));
						f=1-(a4*ml*Math.Cos(al))+(b4*ml*Math.Sin(al));
						g=(a4*ml*Math.Sin(al))+(b4*ml*Math.Cos(al));
						s1=a1+(((e*f)-(b*g))/(Math.Pow(f,2)+Math.Pow(g,2)));
						s2=-b1-(((e*g)+(b*f))/(Math.Pow(f,2)+Math.Pow(g,2)));
						ms=Math.Sqrt(Math.Pow(s1,2)+Math.Pow(s2,2));
						asr=Math.Atan(s2/s1);

						if ((s2>0)&&(s1<0))

						{
							asd=180+(asr*(180/y));
							As=y+asr;
						}

						else if ((s2<0)&&(s1<0))
						{
							As=-y+asr;
							asd=-180+(asr*(180/y));
						}

						else

						{
							As=asr;
							asd=asr*(180/y);
						}


						/*-----INDICATING SOURCE REF.COF. POINT ON SMITH CHART-----*/


						y=Math.PI;
						n=asd;
						m=ms;
						z=(y*n)/180;
						s5=(m*Math.Cos(z)); /*real part of point*/
						t5=(m*Math.Sin(z)); /*image //  //   // */
						h=(s5*220)+320;
						v=240-(t5*220);

						smithchart();

						circle(Pens.Blue,Math.Round(h),Math.Round(v),1);
						circle(Pens.Blue,Math.Round(h),Math.Round(v),2);

						outtextxy(Math.Round(h-3),Math.Round(v-13),"S");


						/*-------DRAWING INPUT STABILITY CIRCLE-------*/


						rs1=((a3*a2)-(b3*b2))/(Math.Pow(x1,2)-Math.Pow(ds,2));
						rs2=((a3*b2)+(a2*b3))/(Math.Pow(x1,2)-Math.Pow(ds,2));
						rs=Math.Sqrt(Math.Pow(rs1,2)+Math.Pow(rs2,2));

						cs1=(a1-(a4*ds1)-(b4*ds2))/(Math.Pow(x1,2)-Math.Pow(ds,2));
						cs2=(-b1+(a4*ds2)-(b4*ds1))/(Math.Pow(x1,2)-Math.Pow(ds,2));
						Hcs=(cs1*220)+320;
						Vcs=240-(cs2*220);

						circle(Pens.Red,Math.Round(Hcs),Math.Round(Vcs),Math.Round(rs*220));/*input stability circle*/

                        outtextxy(Brushes.Black,570,100,"Red Circle = Input Stability Circle",true);

						Scs=Math.Pow(cs1,2)+Math.Pow(cs2,2);
						Srs=Math.Pow(rs,2);

						if (Scs>Srs)
						{
							/*center of smith chart is out of input stability circle*/
							if (x4<1)
								outtextxy(Brushes.Black,600,60,"stable region is out of input stability circle",true);
							else
								outtextxy(Brushes.Black,600,60,"stable region is in the input stability circle",true);
						} /*Scs>Srs*/
						else
						{
							/*center of smith chart is in the input stability circle*/
							if (x4<1)
								outtextxy(Brushes.Black,600,60,"stable region is in the input stability circle",true);

							else
								outtextxy(Brushes.Black,600,60,"stable region is out of stability circle",true);
						}/*else Scs>Srs*/

						outtextxy(1,10,"ms=");
						str(ms,ref s32);
						outtextxy(25,10,s32);
						outtextxy(1,30,"as=");
						str(asd,ref s33);
						outtextxy(25,30,s33);

						GraphArea.Invalidate();
						GraphArea.Update();

						#endregion
						#endregion
					} while (MessageBox.Show ("Do you want to re-select the Load point?",
						"Amplifer Design",MessageBoxButtons.YesNo, MessageBoxIcon.Question)==DialogResult.Yes);/*while SEs!="y"*/
					
					if (this.rbnLamped.Checked)
					{
						smithchart2();
						lampedmatch(ml,al1,0);
					}
					else if (this.rbtDistributed.Checked)
					{
						smithchart();
						matching(ml,al1,0);
					}
					else
					{
						indicating(ml,al1,0);
						outtextxy(Math.Round(h-3),Math.Round(v-13),"L"); //Print "L" on load point
					}

					outtextxy(230,1,"Gp ="+Convert.ToString(Math.Round(Gpd,2))+" dB");
					GraphArea.Invalidate();
					GraphArea.Update();
					
					MessageBox.Show ("Select OK to calculate source load.",
						"Amplifer Design",MessageBoxButtons.OK, MessageBoxIcon.Information);
						

					if (this.rbnLamped.Checked)
					{
						smithchart2();
						lampedmatch(ms,asd,1);
					}

					else if (this.rbtDistributed.Checked)

					{
						smithchart();
						matching(ms,asd,1);
					}

					else
					{
						indicating(ms,asd,0);
						outtextxy(Math.Round(h-3),Math.Round(v-13),"S"); //Print "S" on load point
					}

					outtextxy(230,1,"Gp ="+Convert.ToString(Math.Round(Gpd,2))+" dB");
					GraphArea.Invalidate();
					GraphArea.Update();


				}/*k<1*/
				#endregion		
				
			}/* BILATERAL CASE */
			#endregion
		}


		private void OnSizeChanged(object sender, System.EventArgs e)
		{
			
			GraphArea.Invalidate();
			GraphArea.Update();
		}

		private void OnPaint(object sender, System.Windows.Forms.PaintEventArgs e)
		{
			e.Graphics.DrawImageUnscaled(myImage,0,0);
		}

		private void rbt_Click(object sender, System.EventArgs e)
		{
			if(this.rbtDistributed.Checked)
			{
				this.lblOhm.Visible=true;
				this.lblZ0.Visible=true;
				this.txtZ0.Visible=true;
			}
			else
			{
				this.lblOhm.Visible=false;
				this.lblZ0.Visible=false;
				this.txtZ0.Visible=false;
			}

		}

		public void txt_KeyPress(object sender, System.Windows.Forms.KeyPressEventArgs e)
		{
			if ((e.KeyChar < 48 || e.KeyChar > 57) && e.KeyChar != 8
				&& e.KeyChar != Convert.ToChar(".")
				&& e.KeyChar != Convert.ToChar("-"))

				e.Handled = true; // Remove the character
		}

		private void txtBox_TextChanged(object sender, System.EventArgs e)
		{
			// Cast the sender object to a Textbox
			TextBox tb = (TextBox)sender;

			// Test if the data is valid and set the tag background
			// color accordingly.

			if (tb.Text.Length == 0)
			{
				tb.Tag = false;
				tb.BackColor = Color.Red;
			}
			else
			{
				tb.Tag = true;
				tb.BackColor = SystemColors.Window;
			}

			// Call ValidateAll to set the OK button
			ValidateAll();
		}


		private void ValidateAll()
		{
			// Set the OK button to enabled if all the Tags are true
			this.btnOK.Enabled = ((bool)(this.txtS11Ang.Tag) &&
				(bool)(this.txtS21Ang.Tag) &&
				(bool)(this.txtS12Ang.Tag) &&
				(bool)(this.txtS22Ang.Tag) &&
				(bool)(this.txtS11Mag.Tag) &&
				(bool)(this.txtS21Mag.Tag) &&
				(bool)(this.txtS12Mag.Tag) &&
				(bool)(this.txtS22Mag.Tag));
		}

		private void menuItem3_Click(object sender, System.EventArgs e)
		{
			// Exit the application
			myImage.Dispose();
			myGraph.Dispose();
			Application.Exit();
		}

		private void menuAbout_Click(object sender, System.EventArgs e)
		{
			MessageBox.Show("This Program is written in Visual C# and licensed under Apache 2.0.","Amplifier Design v1",MessageBoxButtons.OK, MessageBoxIcon.Information);
		}

	}/*public class Form1*/
	
} /*namespace AmpDesign*/
