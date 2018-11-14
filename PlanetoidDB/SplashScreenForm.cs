using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace PlanetoidDB
{
  public partial class SplashScreenForm : Form
  {
    public SplashScreenForm()
    {
      InitializeComponent();
    }

    public void setProgressbar(int value)
    {
      progressBarSplash.Value = value;
    }

    private void SplashScreenForm_Load(object sender, EventArgs e)
    {
    }
  }
}
