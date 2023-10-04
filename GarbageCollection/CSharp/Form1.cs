using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

namespace DemoTestCSharp
{
	/// <summary>
	/// Summary description for Form1.
	/// </summary>
	public class Form1 : System.Windows.Forms.Form
	{
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Timer timer1;
		private System.ComponentModel.IContainer components;

		public Form1()
		{
			//
			// Required for Windows Form Designer support
			//
			InitializeComponent();

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
			this.components = new System.ComponentModel.Container();
			this.button1 = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.timer1 = new System.Windows.Forms.Timer(this.components);
			this.SuspendLayout();
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(8, 8);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(216, 32);
			this.button1.TabIndex = 0;
			this.button1.Text = "Click to create 1000 Demo Instances";
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(16, 56);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(240, 24);
			this.label1.TabIndex = 1;
			// 
			// timer1
			// 
			this.timer1.Enabled = true;
			this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
			// 
			// Form1
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.ClientSize = new System.Drawing.Size(292, 93);
			this.Controls.AddRange(new System.Windows.Forms.Control[] {
																		  this.label1,
																		  this.button1});
			this.Name = "Form1";
			this.Text = "Garbage Collection Demo";
			//this.Load += new System.EventHandler(this.Form1_Load);
			this.ResumeLayout(false);

		}

        private void button1_Click(object sender, EventArgs e)
        {
            int Counter;
            Demo aDemo;
            for (Counter = 0; Counter < 1000; Counter++)
            {
                aDemo = new Demo();
            }

           // throw new NotImplementedException();
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

        

        private void timer1_Tick(object sender, System.EventArgs e)
		{
			label1.Text = "There are " + Demo.Instances + " instances of Demo in memory";
		}

		
	}
}
