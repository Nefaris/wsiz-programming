using System;
using System.Windows.Forms;

namespace Z2 {
  public partial class Form1 : Form {
    private string num1 = "";
    private string num2 = "";
    private Operation operation = Operation.NONE;

    public Form1() {
      InitializeComponent();
    }

    private void numberButton1_Click(object sender, EventArgs e) {
      this.updateInputs("1");
      this.updateDisplay();
    }

    private void numberButton2_Click(object sender, EventArgs e) {
      this.updateInputs("2");
      this.updateDisplay();
    }

    private void numberButton3_Click(object sender, EventArgs e) {
      this.updateInputs("3");
      this.updateDisplay();
    }

    private void numberButto4_Click(object sender, EventArgs e) {
      this.updateInputs("4");
      this.updateDisplay();
    }

    private void numberButton5_Click(object sender, EventArgs e) {
      this.updateInputs("5");
      this.updateDisplay();
    }

    private void numberButton6_Click(object sender, EventArgs e) {
      this.updateInputs("6");
      this.updateDisplay();
    }

    private void numberButton7_Click(object sender, EventArgs e) {
      this.updateInputs("7");
      this.updateDisplay();
    }

    private void numberButton8_Click(object sender, EventArgs e) {
      this.updateInputs("8");
      this.updateDisplay();
    }

    private void numberButton9_Click(object sender, EventArgs e) {
      this.updateInputs("9");
      this.updateDisplay();
    }

    private void numberButton0_Click(object sender, EventArgs e) {
      this.updateInputs("0");
      this.updateDisplay();
    }

    private void comaButton_Click(object sender, EventArgs e) {
      if (this.operation == Operation.NONE)  {
        if (!this.num1.Contains(",")) {
          this.num1 += ",";
        }
      } else {
        if (!this.num2.Contains(",")) {
          this.num2 += ",";
        }
      }

      this.updateDisplay();
    }

    private void operationButtonAdd_Click(object sender, EventArgs e) {
      this.operation = Operation.ADD;
      this.updateDisplay();
    }

    private void operationButtonMultiply_Click(object sender, EventArgs e) {
      this.operation = Operation.MULTIPLY;
      this.updateDisplay();
    }

    private void operationButtonMinus_Click(object sender, EventArgs e) {
      this.operation = Operation.SUBTRACT;
      this.updateDisplay();
    }

    private void operationButtonDivide_Click(object sender, EventArgs e) {
      this.operation = Operation.DIVIDE;
      this.updateDisplay();
    }

    private void operationButtonClear_Click(object sender, EventArgs e) {
      this.operation = Operation.NONE;
      resultInput.Text = "";
      this.num1 = "";
      this.num2 = "";
    }

    private void operationButtonCalculate_Click(object sender, EventArgs e) {
      if (this.num1 == "") {
        MessageBox.Show("Provide any number", "Error", MessageBoxButtons.OK);
        return;
      }

      if (this.operation == Operation.NONE) {
        MessageBox.Show("Pick an operation", "Error", MessageBoxButtons.OK);
        return;
      }

      if (this.num2 == "") {
        MessageBox.Show("Provide second number", "Error", MessageBoxButtons.OK);
        return;
      }

      double parsed1 = double.Parse(this.num1);
      double parsed2 = double.Parse(this.num2);
      string result = "";

      switch (this.operation) {
        case Operation.ADD: {
          result = (parsed1 + parsed2).ToString();
          break;
        }
        case Operation.SUBTRACT: {
            result = (parsed1 - parsed2).ToString();
          break;
        }
        case Operation.MULTIPLY: {
            result = (parsed1 * parsed2).ToString();
          break;
        }
        case Operation.DIVIDE: {
            result = (parsed1 / parsed2).ToString();
          break;
        }
      }

      resultInput.Text = result;
      this.num1 = result;
      this.num2 = "";
      this.operation = Operation.NONE;
    }

    private void updateInputs(string number) {
      if (this.operation == Operation.NONE) {
        this.num1 += number;
      } else if (number == "0" && this.operation == Operation.DIVIDE) {
        MessageBox.Show("You can not divide by zero", "Error", MessageBoxButtons.OK);
      } else {
        this.num2 += number;
      }
    }

    private void updateDisplay() {
      this.resultInput.Text = this.num1;
      switch (this.operation) {
        case Operation.ADD: {
          this.resultInput.Text += "+" + this.num2;
          break;
        }
        case Operation.SUBTRACT: {
          this.resultInput.Text += "-" + this.num2;
          break;
        }
        case Operation.MULTIPLY: {
          this.resultInput.Text += "*" + this.num2;
          break;
        }
        case Operation.DIVIDE: {
          this.resultInput.Text += "/" + this.num2;
          break;
        }
      }
    }
  }

  enum Operation {
    ADD,
    SUBTRACT,
    DIVIDE,
    MULTIPLY,
    NONE
  }
}
