namespace Elevator.UI.CabinControls
{
  partial class ButtonDashboardControl
  {
    /// <summary> 
    /// Variable del diseñador necesaria.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary> 
    /// Limpiar los recursos que se estén usando.
    /// </summary>
    /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
    protected override void Dispose(bool disposing)
    {
      if (disposing && (components != null))
      {
        components.Dispose();
      }
      base.Dispose(disposing);
    }

    #region Código generado por el Diseñador de componentes

    /// <summary> 
    /// Método necesario para admitir el Diseñador. No se puede modificar
    /// el contenido de este método con el editor de código.
    /// </summary>
    private void InitializeComponent()
    {
      label1 = new Label();
      label2 = new Label();
      label3 = new Label();
      label4 = new Label();
      label5 = new Label();
      labelFloor = new Label();
      labelDirection = new Label();
      panel1 = new Panel();
      labelClose = new Label();
      labelOpen = new Label();
      panel1.SuspendLayout();
      SuspendLayout();
      // 
      // label1
      // 
      label1.AutoSize = true;
      label1.BorderStyle = BorderStyle.FixedSingle;
      label1.Cursor = Cursors.Hand;
      label1.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Regular, GraphicsUnit.Point);
      label1.Image = Properties.Resources.Metal;
      label1.Location = new Point(15, 140);
      label1.Name = "label1";
      label1.Size = new Size(28, 31);
      label1.TabIndex = 0;
      label1.Text = "1";
      label1.Click += label1_Click;
      // 
      // label2
      // 
      label2.AutoSize = true;
      label2.BorderStyle = BorderStyle.FixedSingle;
      label2.Cursor = Cursors.Hand;
      label2.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Regular, GraphicsUnit.Point);
      label2.Image = Properties.Resources.Metal;
      label2.Location = new Point(57, 140);
      label2.Name = "label2";
      label2.Size = new Size(28, 31);
      label2.TabIndex = 1;
      label2.Text = "2";
      label2.Click += label2_Click;
      // 
      // label3
      // 
      label3.AutoSize = true;
      label3.BorderStyle = BorderStyle.FixedSingle;
      label3.Cursor = Cursors.Hand;
      label3.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Regular, GraphicsUnit.Point);
      label3.Image = Properties.Resources.Metal;
      label3.Location = new Point(15, 99);
      label3.Name = "label3";
      label3.Size = new Size(28, 31);
      label3.TabIndex = 2;
      label3.Text = "3";
      label3.Click += label3_Click;
      // 
      // label4
      // 
      label4.AutoSize = true;
      label4.BorderStyle = BorderStyle.FixedSingle;
      label4.Cursor = Cursors.Hand;
      label4.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Regular, GraphicsUnit.Point);
      label4.Image = Properties.Resources.Metal;
      label4.Location = new Point(57, 99);
      label4.Name = "label4";
      label4.Size = new Size(28, 31);
      label4.TabIndex = 3;
      label4.Text = "4";
      label4.Click += label4_Click;
      // 
      // label5
      // 
      label5.AutoSize = true;
      label5.BorderStyle = BorderStyle.FixedSingle;
      label5.Cursor = Cursors.Hand;
      label5.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Regular, GraphicsUnit.Point);
      label5.Image = Properties.Resources.Metal;
      label5.Location = new Point(37, 56);
      label5.Name = "label5";
      label5.Size = new Size(28, 31);
      label5.TabIndex = 4;
      label5.Text = "5";
      label5.Click += label5_Click;
      // 
      // labelFloor
      // 
      labelFloor.AutoSize = true;
      labelFloor.BackColor = Color.Black;
      labelFloor.Font = new Font("Calibri", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
      labelFloor.ForeColor = Color.FromArgb(128, 255, 128);
      labelFloor.Location = new Point(59, 0);
      labelFloor.Name = "labelFloor";
      labelFloor.Size = new Size(29, 33);
      labelFloor.TabIndex = 5;
      labelFloor.Text = "1";
      // 
      // labelDirection
      // 
      labelDirection.AutoSize = true;
      labelDirection.BackColor = Color.Black;
      labelDirection.Font = new Font("Calibri", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
      labelDirection.ForeColor = Color.FromArgb(128, 255, 128);
      labelDirection.Location = new Point(0, 0);
      labelDirection.Name = "labelDirection";
      labelDirection.Size = new Size(46, 33);
      labelDirection.TabIndex = 6;
      labelDirection.Text = "Up";
      // 
      // panel1
      // 
      panel1.BackColor = Color.Black;
      panel1.Controls.Add(labelDirection);
      panel1.Controls.Add(labelFloor);
      panel1.Location = new Point(3, 4);
      panel1.Name = "panel1";
      panel1.Size = new Size(102, 41);
      panel1.TabIndex = 7;
      // 
      // labelClose
      // 
      labelClose.AutoSize = true;
      labelClose.BorderStyle = BorderStyle.FixedSingle;
      labelClose.Cursor = Cursors.Hand;
      labelClose.Font = new Font("Gill Sans Ultra Bold", 9F, FontStyle.Regular, GraphicsUnit.Point);
      labelClose.Image = Properties.Resources.Metal;
      labelClose.Location = new Point(57, 186);
      labelClose.Name = "labelClose";
      labelClose.Size = new Size(48, 20);
      labelClose.TabIndex = 8;
      labelClose.Text = "Close";
      labelClose.Click += labelClose_Click;
      // 
      // labelOpen
      // 
      labelOpen.AutoSize = true;
      labelOpen.BorderStyle = BorderStyle.FixedSingle;
      labelOpen.Cursor = Cursors.Hand;
      labelOpen.Font = new Font("Gill Sans Ultra Bold", 9F, FontStyle.Regular, GraphicsUnit.Point);
      labelOpen.Image = Properties.Resources.Metal;
      labelOpen.Location = new Point(3, 186);
      labelOpen.Name = "labelOpen";
      labelOpen.Size = new Size(48, 20);
      labelOpen.TabIndex = 9;
      labelOpen.Text = "Open";
      labelOpen.Click += labelOpen_Click;
      // 
      // ButtonDashboardControl
      // 
      AutoScaleDimensions = new SizeF(7F, 15F);
      AutoScaleMode = AutoScaleMode.Font;
      BackgroundImage = Properties.Resources.Metal;
      Controls.Add(labelOpen);
      Controls.Add(labelClose);
      Controls.Add(label5);
      Controls.Add(label4);
      Controls.Add(label3);
      Controls.Add(label2);
      Controls.Add(label1);
      Controls.Add(panel1);
      Name = "ButtonDashboardControl";
      Size = new Size(110, 224);
      Load += ButtonDashboardControl_Load;
      panel1.ResumeLayout(false);
      panel1.PerformLayout();
      ResumeLayout(false);
      PerformLayout();
    }

    #endregion

    private Label label1;
    private Label label2;
    private Label label3;
    private Label label4;
    private Label label5;
    private Label labelFloor;
    private Label labelDirection;
    private Panel panel1;
    private Label labelClose;
    private Label labelOpen;
  }
}
