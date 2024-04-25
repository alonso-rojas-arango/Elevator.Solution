namespace Elevator.UI.CabinControls
{
  partial class CabinControl
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
      panelDoorLeft = new Panel();
      panelDoorRight = new Panel();
      SuspendLayout();
      // 
      // panelDoorLeft
      // 
      panelDoorLeft.BackgroundImage = Properties.Resources.DoorBg;
      panelDoorLeft.BackgroundImageLayout = ImageLayout.Stretch;
      panelDoorLeft.BorderStyle = BorderStyle.Fixed3D;
      panelDoorLeft.Location = new Point(5, 0);
      panelDoorLeft.Name = "panelDoorLeft";
      panelDoorLeft.Size = new Size(10, 55);
      panelDoorLeft.TabIndex = 0;
      // 
      // panelDoorRight
      // 
      panelDoorRight.BackgroundImage = Properties.Resources.DoorBg;
      panelDoorRight.BackgroundImageLayout = ImageLayout.Stretch;
      panelDoorRight.BorderStyle = BorderStyle.Fixed3D;
      panelDoorRight.Location = new Point(57, 0);
      panelDoorRight.Name = "panelDoorRight";
      panelDoorRight.Size = new Size(10, 55);
      panelDoorRight.TabIndex = 1;
      // 
      // CabinControl
      // 
      AutoScaleDimensions = new SizeF(7F, 15F);
      AutoScaleMode = AutoScaleMode.Font;
      BackColor = Color.Transparent;
      BackgroundImage = Properties.Resources.Metal;
      Controls.Add(panelDoorRight);
      Controls.Add(panelDoorLeft);
      Name = "CabinControl";
      Size = new Size(73, 55);
      Click += CabinControl_Click;
      ResumeLayout(false);
    }

    #endregion

    private Panel panelDoorLeft;
    private Panel panelDoorRight;
  }
}
