namespace Elevator.UI.FloorControls
{
  partial class UpDownPanelControl
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
      buttonUp = new Button();
      buttonDown = new Button();
      SuspendLayout();
      // 
      // buttonUp
      // 
      buttonUp.Font = new Font("Wingdings 3", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
      buttonUp.Location = new Point(0, -2);
      buttonUp.Name = "buttonUp";
      buttonUp.Size = new Size(16, 16);
      buttonUp.TabIndex = 0;
      buttonUp.Text = "p";
      buttonUp.UseVisualStyleBackColor = true;
      buttonUp.Click += buttonUp_Click;
      // 
      // buttonDown
      // 
      buttonDown.Font = new Font("Wingdings 3", 6.75F, FontStyle.Regular, GraphicsUnit.Point);
      buttonDown.Location = new Point(0, 13);
      buttonDown.Name = "buttonDown";
      buttonDown.Size = new Size(16, 16);
      buttonDown.TabIndex = 1;
      buttonDown.Text = "q";
      buttonDown.UseVisualStyleBackColor = true;
      buttonDown.Click += buttonDown_Click;
      // 
      // UpDownPanelControl
      // 
      AutoScaleDimensions = new SizeF(7F, 15F);
      AutoScaleMode = AutoScaleMode.Font;
      Controls.Add(buttonDown);
      Controls.Add(buttonUp);
      Name = "UpDownPanelControl";
      Size = new Size(16, 31);
      ResumeLayout(false);
    }

    #endregion

    private Button buttonUp;
    private Button buttonDown;
  }
}
