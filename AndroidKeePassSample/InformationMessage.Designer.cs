/*
 * Created by Ranorex
 * User: renzinger
 * Date: 30.01.2013
 * Time: 11:40
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace AndroidKeePassSample
{
	partial class InformationMessage
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		
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
			this.components = new System.ComponentModel.Container();
			this.lbInfoHeader = new System.Windows.Forms.Label();
			this.rtInformation = new System.Windows.Forms.RichTextBox();
			this.btOK = new System.Windows.Forms.Button();
			this.btCancel = new System.Windows.Forms.Button();
			this.CloseTimer = new System.Windows.Forms.Timer(this.components);
			this.label1 = new System.Windows.Forms.Label();
			this.richTextBox1 = new System.Windows.Forms.RichTextBox();
			this.SuspendLayout();
			// 
			// lbInfoHeader
			// 
			this.lbInfoHeader.AutoSize = true;
			this.lbInfoHeader.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbInfoHeader.Location = new System.Drawing.Point(16, 21);
			this.lbInfoHeader.Name = "lbInfoHeader";
			this.lbInfoHeader.Size = new System.Drawing.Size(151, 16);
			this.lbInfoHeader.TabIndex = 0;
			this.lbInfoHeader.Text = "Connected via WIFI";
			// 
			// rtInformation
			// 
			this.rtInformation.BackColor = System.Drawing.SystemColors.HighlightText;
			this.rtInformation.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.rtInformation.Location = new System.Drawing.Point(19, 48);
			this.rtInformation.Name = "rtInformation";
			this.rtInformation.ReadOnly = true;
			this.rtInformation.Size = new System.Drawing.Size(448, 72);
			this.rtInformation.TabIndex = 1;
			this.rtInformation.Text = "On your mobile device you need to confirm the dialog to install the app. After do" +
			"ing so, please click on the \"OK\" button below to continue the sample.";
			// 
			// btOK
			// 
			this.btOK.DialogResult = System.Windows.Forms.DialogResult.OK;
			this.btOK.Location = new System.Drawing.Point(128, 256);
			this.btOK.Name = "btOK";
			this.btOK.Size = new System.Drawing.Size(112, 32);
			this.btOK.TabIndex = 2;
			this.btOK.Text = "OK";
			this.btOK.UseVisualStyleBackColor = true;
			this.btOK.Click += new System.EventHandler(this.BtOKClick);
			// 
			// btCancel
			// 
			this.btCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.btCancel.Location = new System.Drawing.Point(248, 256);
			this.btCancel.Name = "btCancel";
			this.btCancel.Size = new System.Drawing.Size(112, 32);
			this.btCancel.TabIndex = 3;
			this.btCancel.Text = "Cancel [%d s]";
			this.btCancel.UseVisualStyleBackColor = true;
			this.btCancel.Click += new System.EventHandler(this.BtCancelClick);
			// 
			// CloseTimer
			// 
			this.CloseTimer.Interval = 1000;
			this.CloseTimer.Tick += new System.EventHandler(this.CloseTimerTick);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(16, 138);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(145, 16);
			this.label1.TabIndex = 4;
			this.label1.Text = "Connected via USB";
			// 
			// richTextBox1
			// 
			this.richTextBox1.BackColor = System.Drawing.SystemColors.HighlightText;
			this.richTextBox1.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.richTextBox1.Location = new System.Drawing.Point(18, 162);
			this.richTextBox1.Name = "richTextBox1";
			this.richTextBox1.ReadOnly = true;
			this.richTextBox1.Size = new System.Drawing.Size(448, 72);
			this.richTextBox1.TabIndex = 5;
			this.richTextBox1.Text = "Continue by clicking the \"OK\" button below.";
			// 
			// InformationMessage
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(484, 310);
			this.Controls.Add(this.richTextBox1);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.btCancel);
			this.Controls.Add(this.btOK);
			this.Controls.Add(this.rtInformation);
			this.Controls.Add(this.lbInfoHeader);
			this.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "InformationMessage";
			this.ShowIcon = false;
			this.Text = "Information Message Mobile Device";
			this.TopMost = true;
			this.Load += new System.EventHandler(this.InformationMessageLoad);
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.RichTextBox richTextBox1;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Timer CloseTimer;
		private System.Windows.Forms.Label lbInfoHeader;
		private System.Windows.Forms.Button btCancel;
		private System.Windows.Forms.Button btOK;
		private System.Windows.Forms.RichTextBox rtInformation;
	}
}
