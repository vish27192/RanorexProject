/*
 * Created by Ranorex
 * User: renzinger
 * Date: 30.01.2013
 * Time: 11:40
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Drawing;
using System.Windows.Forms;

namespace AndroidKeePassSample
{
	/// <summary>
	/// Description of InformationMessage.
	/// </summary>
	public partial class InformationMessage : Form
	{
		private int fTimer = 60;
		
		public InformationMessage()
		{
			InitializeComponent();
		}
		
		void BtCancelClick(object sender, EventArgs e)
		{
			Ranorex.Report.Info ("Closed dialog with 'Cancel'");
			this.Close();
		}
		
		void BtOKClick(object sender, EventArgs e)
		{
			Ranorex.Report.Info ("Confirmed dialog with 'OK'.");
			this.Close();
		}
		
		void CloseTimerTick(object sender, EventArgs e)
		{
			if (fTimer >= 0)
			{
				btCancel.Text = string.Format ("Cancel ({0:g})",fTimer);
			} 
			else 
			{
				CloseTimer.Enabled = false;
				Ranorex.Report.Info ("Dialog is closed by timeout");
				DialogResult = DialogResult.Cancel;
				this.Close();
			}
			fTimer --;
		}
		
		void InformationMessageLoad(object sender, EventArgs e)
		{
			btCancel.Text = string.Format ("Cancel ({0:g})",fTimer);
			CloseTimer.Enabled=true;
			this.CenterToScreen();
			Ranorex.Report.Info ("Presenting information dialog for different kinds of connections");
		}
		
		
	}
}
