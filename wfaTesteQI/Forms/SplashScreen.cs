using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using wfaTesteQI.Forms;

namespace wfaTesteQI
{
	public partial class SplashScreen : Form
	{
		public SplashScreen()
		{
			InitializeComponent();
			EffectTime();
		}
		private bool effect = true;

		private void EffectTime()
		{
			tmSplash.Interval = 10000; //define 190 milisegundos para a atuação do timer
			tmSplash.Enabled = true;//ativa o timer

		}

		private void tmSplash_Tick(object sender, EventArgs e)
		{
			if (effect)
			{
				this.Opacity -= 1D;//E Diminui a opacidade do form
			}
			if (this.Opacity == 0)
			{
				effect = false;
				tmSplash.Enabled = false;//Desliga o Timer
				frmMainPage frmMain = new frmMainPage();//Instancia um form Login
				frmMain.Show();//Mostra o login
				this.Hide();//Oculta o formulario Splash sem tira-lo da memória
			}

		}
	}
}
