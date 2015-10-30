namespace Yahtzee
{
  partial class TeerlingView
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
      this.TeerlingWerpBtn = new System.Windows.Forms.Button();
      this.TeerlingLabel = new System.Windows.Forms.Label();
      this.SuspendLayout();
      // 
      // TeerlingWerpBtn
      // 
      this.TeerlingWerpBtn.Location = new System.Drawing.Point(38, 114);
      this.TeerlingWerpBtn.Name = "TeerlingWerpBtn";
      this.TeerlingWerpBtn.Size = new System.Drawing.Size(75, 23);
      this.TeerlingWerpBtn.TabIndex = 0;
      this.TeerlingWerpBtn.Text = "werp";
      this.TeerlingWerpBtn.UseVisualStyleBackColor = true;
      this.TeerlingWerpBtn.Click += new System.EventHandler(this.werp_Click);
      // 
      // TeerlingLabel
      // 
      this.TeerlingLabel.Location = new System.Drawing.Point(17, 10);
      this.TeerlingLabel.Name = "TeerlingLabel";
      this.TeerlingLabel.Size = new System.Drawing.Size(118, 101);
      this.TeerlingLabel.TabIndex = 1;
      this.TeerlingLabel.Text = "label1";
      this.TeerlingLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
      // 
      // TeerlingView
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.Controls.Add(this.TeerlingLabel);
      this.Controls.Add(this.TeerlingWerpBtn);
      this.Name = "TeerlingView";
      this.Load += new System.EventHandler(this.TeerlingView_Load);
      this.ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.Button TeerlingWerpBtn;
    private System.Windows.Forms.Label TeerlingLabel;
  }
}
