using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace wfaTesteQI.Forms
{
	public partial class frmMainPage : Form
	{
		public frmMainPage()
		{
			InitializeComponent();
		}

		private void frmMainPage_FormClosing(object sender, FormClosingEventArgs e)
		{
			if (MessageBox.Show("Deseja mesmo fechar?", "Fechar", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
				Dispose();
			else
			{

			}
		}
	}
}
