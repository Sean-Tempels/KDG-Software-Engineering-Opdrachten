using System.Collections.Generic;

namespace Yahtzee
{
  partial class Yahtzee
  {
    /// <summary>
    /// Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    /// Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing)
    {
      if (disposing && (components != null))
      {
        components.Dispose();
      }
      base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    /// <summary>
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
      this.AlgemeneWerpKnop = new System.Windows.Forms.Button();
      this.cheatBox = new System.Windows.Forms.CheckBox();
      this.SuspendLayout();
      // 
      // AlgemeneWerpKnop
      // 
      this.AlgemeneWerpKnop.AutoSize = true;
      this.AlgemeneWerpKnop.Location = new System.Drawing.Point(13, 175);
      this.AlgemeneWerpKnop.Name = "AlgemeneWerpKnop";
      this.AlgemeneWerpKnop.Size = new System.Drawing.Size(420, 23);
      this.AlgemeneWerpKnop.TabIndex = 0;
      this.AlgemeneWerpKnop.Text = "Werp Alles!";
      this.AlgemeneWerpKnop.UseVisualStyleBackColor = true;
      this.AlgemeneWerpKnop.Click += new System.EventHandler(this.AlgemeneWerpKnop_Click);
      // 
      // cheatBox
      // 
      this.cheatBox.AutoSize = true;
      this.cheatBox.Location = new System.Drawing.Point(13, 207);
      this.cheatBox.Name = "cheatBox";
      this.cheatBox.Size = new System.Drawing.Size(84, 17);
      this.cheatBox.TabIndex = 1;
      this.cheatBox.Text = "Cheat Mode";
      this.cheatBox.UseVisualStyleBackColor = true;
      this.cheatBox.CheckedChanged += new System.EventHandler(this.cheatBox_CheckedChanged);
      // 
      // Yahtzee
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.AutoSize = true;
      this.ClientSize = new System.Drawing.Size(445, 236);
      this.Controls.Add(this.cheatBox);
      this.Controls.Add(this.AlgemeneWerpKnop);
      this.Name = "Yahtzee";
      this.Text = "Yahtzee";
      this.Load += new System.EventHandler(this.Yahtzee_Load);
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Button AlgemeneWerpKnop;
    private System.Windows.Forms.CheckBox cheatBox;

  }
}

