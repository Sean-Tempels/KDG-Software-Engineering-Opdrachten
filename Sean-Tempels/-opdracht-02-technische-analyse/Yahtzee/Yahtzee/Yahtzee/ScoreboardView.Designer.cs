namespace Yahtzee
{
  partial class ScoreboardView
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

    #region Component Designer generated code

    /// <summary> 
    /// Required method for Designer support - do not modify 
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
      this.ScoreTextBox = new System.Windows.Forms.TextBox();
      this.ScoreLabel = new System.Windows.Forms.Label();
      this.HighScoreLabel = new System.Windows.Forms.Label();
      this.HighScoreTextBox = new System.Windows.Forms.TextBox();
      this.SuspendLayout();
      // 
      // ScoreTextBox
      // 
      this.ScoreTextBox.Location = new System.Drawing.Point(26, 3);
      this.ScoreTextBox.Name = "ScoreTextBox";
      this.ScoreTextBox.Size = new System.Drawing.Size(100, 20);
      this.ScoreTextBox.TabIndex = 0;
      this.ScoreTextBox.Text = "Score";
      this.ScoreTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
      // 
      // ScoreLabel
      // 
      this.ScoreLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
      this.ScoreLabel.Location = new System.Drawing.Point(26, 26);
      this.ScoreLabel.Name = "ScoreLabel";
      this.ScoreLabel.Size = new System.Drawing.Size(100, 45);
      this.ScoreLabel.TabIndex = 1;
      this.ScoreLabel.Text = "0";
      this.ScoreLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
      // 
      // HighScoreLabel
      // 
      this.HighScoreLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
      this.HighScoreLabel.Location = new System.Drawing.Point(26, 97);
      this.HighScoreLabel.Name = "HighScoreLabel";
      this.HighScoreLabel.Size = new System.Drawing.Size(100, 45);
      this.HighScoreLabel.TabIndex = 2;
      this.HighScoreLabel.Text = "0";
      this.HighScoreLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
      // 
      // HighScoreTextBox
      // 
      this.HighScoreTextBox.Location = new System.Drawing.Point(26, 74);
      this.HighScoreTextBox.Name = "HighScoreTextBox";
      this.HighScoreTextBox.Size = new System.Drawing.Size(100, 20);
      this.HighScoreTextBox.TabIndex = 3;
      this.HighScoreTextBox.Text = "High Score";
      this.HighScoreTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
      // 
      // ScoreboardView
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.Controls.Add(this.HighScoreTextBox);
      this.Controls.Add(this.HighScoreLabel);
      this.Controls.Add(this.ScoreLabel);
      this.Controls.Add(this.ScoreTextBox);
      this.Name = "ScoreboardView";
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.TextBox ScoreTextBox;
    private System.Windows.Forms.Label ScoreLabel;
    private System.Windows.Forms.Label HighScoreLabel;
    private System.Windows.Forms.TextBox HighScoreTextBox;
  }
}
