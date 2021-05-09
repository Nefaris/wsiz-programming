using System;
using System.Windows.Forms;

namespace Z1 {
  public partial class Form1 : Form {
    public Form1() {
      InitializeComponent();
    }

    private void addButton_Click(object sender, EventArgs e) {
      try {
        resultInput.Text = (
          Double.Parse(xInput.Text) +
          Double.Parse(yInput.Text) +
          Double.Parse(zInput.Text)
          ).ToString();
      } catch (Exception) {
        MessageBox.Show("Provided wrong data format, check your inputs", "Error", MessageBoxButtons.OK);
      }
    }

    private void multiplyButton_Click(object sender, EventArgs e) {
      try {
        resultInput.Text = (
          Double.Parse(xInput.Text) *
          Double.Parse(yInput.Text) *
          Double.Parse(zInput.Text)
          ).ToString();
      } catch (Exception) {
        MessageBox.Show("Provided wrong data format, check your inputs", "Error", MessageBoxButtons.OK);
      }
    }

    private void exitButton_Click(object sender, EventArgs e) {
      Application.Exit();
    }
  }
}
