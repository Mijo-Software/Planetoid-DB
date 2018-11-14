using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Net;
using System.Reflection;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using System.Runtime.InteropServices;


namespace PlanetoidDB
{
  public partial class DatabaseInformationForm : Form
  {
    public DatabaseInformationForm()
    {
      InitializeComponent();
    }

    private void showMessageCopiedToClipboad()
    {
      MessageBox.Show("Copied to clipboard.", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
    }

    private void DatabaseInformationForm_Load(object sender, EventArgs e)
    {
      FileInfo fi = new FileInfo("mpcorb.dat");
      labelNameValue.Text = fi.Name;
      labelDirectoryValue.Text = fi.DirectoryName;
      labelSizeValue.Text = fi.Length.ToString() + " Bytes";
      labelDateCreatedValue.Text = fi.CreationTime.ToString();
      labelDateAccessedValue.Text = fi.LastAccessTime.ToString();
      labelDateWritedValue.Text = fi.LastWriteTime.ToString();
      labelAttributesValue.Text = fi.Attributes.ToString();
    }

    private void DatabaseInformationForm_FormClosed(object sender, FormClosedEventArgs e)
    {
      this.Dispose();
    }

    private void pictureBoxInformation_Click(object sender, EventArgs e)
    {

    }

    private void buttonOK_Click(object sender, EventArgs e)
    {
      this.Close();
    }

    private void labelName_DoubleClick(object sender, EventArgs e)
    {
      Clipboard.SetText(labelName.Text);
      showMessageCopiedToClipboad();
    }

    private void labelDirectory_DoubleClick(object sender, EventArgs e)
    {
      Clipboard.SetText(labelDirectory.Text);
      showMessageCopiedToClipboad();
    }

    private void labelSize_DoubleClick(object sender, EventArgs e)
    {
      Clipboard.SetText(labelSize.Text);
      showMessageCopiedToClipboad();
    }

    private void labelDateCreated_DoubleClick(object sender, EventArgs e)
    {
      Clipboard.SetText(labelDateCreated.Text);
      showMessageCopiedToClipboad();
    }

    private void labelDateAccessed_DoubleClick(object sender, EventArgs e)
    {
      Clipboard.SetText(labelDateAccessed.Text);
      showMessageCopiedToClipboad();
    }

    private void labelDateWrited_DoubleClick(object sender, EventArgs e)
    {
      Clipboard.SetText(labelDateWrited.Text);
      showMessageCopiedToClipboad();
    }

    private void labelAttributes_DoubleClick(object sender, EventArgs e)
    {
      Clipboard.SetText(labelAttributes.Text);
      showMessageCopiedToClipboad();
    }

    private void labelNameValue_DoubleClick(object sender, EventArgs e)
    {
      Clipboard.SetText(labelNameValue.Text);
      showMessageCopiedToClipboad();
    }

    private void labelDirectoryValue_DoubleClick(object sender, EventArgs e)
    {
      Clipboard.SetText(labelDirectoryValue.Text);
      showMessageCopiedToClipboad();
    }

    private void labelSizeValue_DoubleClick(object sender, EventArgs e)
    {
      Clipboard.SetText(labelSizeValue.Text);
      showMessageCopiedToClipboad();
    }

    private void labelDateCreatedValue_DoubleClick(object sender, EventArgs e)
    {
      Clipboard.SetText(labelDateCreatedValue.Text);
      showMessageCopiedToClipboad();
    }

    private void labelDateAccessedValue_DoubleClick(object sender, EventArgs e)
    {
      Clipboard.SetText(labelDateAccessedValue.Text);
      showMessageCopiedToClipboad();
    }

    private void labelDateWritedValue_DoubleClick(object sender, EventArgs e)
    {
      Clipboard.SetText(labelDateWritedValue.Text);
      showMessageCopiedToClipboad();
    }

    private void labelAttributesValue_DoubleClick(object sender, EventArgs e)
    {
      Clipboard.SetText(labelAttributesValue.Text);
      showMessageCopiedToClipboad();
    }
  }
}
