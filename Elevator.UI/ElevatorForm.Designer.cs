namespace Elevator.UI
{
  partial class ElevatorForm
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
      DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ElevatorForm));
      GridViewInsideRequests = new DataGridView();
      buttonDashboardControl1 = new CabinControls.ButtonDashboardControl();
      panel1 = new Panel();
      panel9 = new Panel();
      upDownPanelControl5 = new FloorControls.UpDownPanelControl();
      panel10 = new Panel();
      panel3 = new Panel();
      upDownPanelControl4 = new FloorControls.UpDownPanelControl();
      panel8 = new Panel();
      panel6 = new Panel();
      upDownPanelControl3 = new FloorControls.UpDownPanelControl();
      panel7 = new Panel();
      panel4 = new Panel();
      upDownPanelControl2 = new FloorControls.UpDownPanelControl();
      panel5 = new Panel();
      panel2 = new Panel();
      upDownPanelControl1 = new FloorControls.UpDownPanelControl();
      cabinControl1 = new CabinControls.CabinControl();
      ((System.ComponentModel.ISupportInitialize)GridViewInsideRequests).BeginInit();
      panel1.SuspendLayout();
      panel9.SuspendLayout();
      panel3.SuspendLayout();
      panel6.SuspendLayout();
      panel4.SuspendLayout();
      panel2.SuspendLayout();
      SuspendLayout();
      // 
      // GridViewInsideRequests
      // 
      GridViewInsideRequests.AllowUserToAddRows = false;
      GridViewInsideRequests.AllowUserToDeleteRows = false;
      GridViewInsideRequests.AllowUserToOrderColumns = true;
      GridViewInsideRequests.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
      dataGridViewCellStyle1.BackColor = SystemColors.Window;
      dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
      dataGridViewCellStyle1.ForeColor = SystemColors.ControlText;
      dataGridViewCellStyle1.SelectionBackColor = SystemColors.Window;
      dataGridViewCellStyle1.SelectionForeColor = SystemColors.WindowText;
      dataGridViewCellStyle1.WrapMode = DataGridViewTriState.False;
      GridViewInsideRequests.DefaultCellStyle = dataGridViewCellStyle1;
      GridViewInsideRequests.Location = new Point(305, 13);
      GridViewInsideRequests.Name = "GridViewInsideRequests";
      GridViewInsideRequests.RowTemplate.Height = 25;
      GridViewInsideRequests.Size = new Size(434, 273);
      GridViewInsideRequests.TabIndex = 1;
      // 
      // buttonDashboardControl1
      // 
      buttonDashboardControl1.BackgroundImage = (Image)resources.GetObject("buttonDashboardControl1.BackgroundImage");
      buttonDashboardControl1.Location = new Point(173, 59);
      buttonDashboardControl1.Name = "buttonDashboardControl1";
      buttonDashboardControl1.Size = new Size(115, 227);
      buttonDashboardControl1.TabIndex = 2;
      buttonDashboardControl1.FloorButtonPressed += buttonDashboardControl1_FloorButtonPressed;
      buttonDashboardControl1.ButtonClosePressed += buttonDashboardControl1_ButtonClosePressed;
      // 
      // panel1
      // 
      panel1.Controls.Add(panel9);
      panel1.Controls.Add(panel3);
      panel1.Controls.Add(panel6);
      panel1.Controls.Add(panel4);
      panel1.Controls.Add(panel2);
      panel1.Location = new Point(12, 11);
      panel1.Name = "panel1";
      panel1.Size = new Size(150, 275);
      panel1.TabIndex = 3;
      // 
      // panel9
      // 
      panel9.BackgroundImage = Properties.Resources.DoorBg2;
      panel9.BackgroundImageLayout = ImageLayout.Stretch;
      panel9.BorderStyle = BorderStyle.FixedSingle;
      panel9.Controls.Add(upDownPanelControl5);
      panel9.Controls.Add(panel10);
      panel9.Location = new Point(3, 3);
      panel9.Name = "panel9";
      panel9.Size = new Size(145, 55);
      panel9.TabIndex = 4;
      // 
      // upDownPanelControl5
      // 
      upDownPanelControl5.Location = new Point(4, 8);
      upDownPanelControl5.Name = "upDownPanelControl5";
      upDownPanelControl5.Size = new Size(16, 31);
      upDownPanelControl5.TabIndex = 2;
      // 
      // panel10
      // 
      panel10.BorderStyle = BorderStyle.FixedSingle;
      panel10.Location = new Point(-1, -61);
      panel10.Name = "panel10";
      panel10.Size = new Size(145, 55);
      panel10.TabIndex = 1;
      // 
      // panel3
      // 
      panel3.BackgroundImage = Properties.Resources.DoorBg2;
      panel3.BackgroundImageLayout = ImageLayout.Stretch;
      panel3.BorderStyle = BorderStyle.FixedSingle;
      panel3.Controls.Add(upDownPanelControl4);
      panel3.Controls.Add(panel8);
      panel3.Location = new Point(3, 58);
      panel3.Name = "panel3";
      panel3.Size = new Size(145, 55);
      panel3.TabIndex = 3;
      // 
      // upDownPanelControl4
      // 
      upDownPanelControl4.Location = new Point(4, 8);
      upDownPanelControl4.Name = "upDownPanelControl4";
      upDownPanelControl4.Size = new Size(16, 31);
      upDownPanelControl4.TabIndex = 2;
      // 
      // panel8
      // 
      panel8.BorderStyle = BorderStyle.FixedSingle;
      panel8.Location = new Point(-1, -61);
      panel8.Name = "panel8";
      panel8.Size = new Size(145, 55);
      panel8.TabIndex = 1;
      // 
      // panel6
      // 
      panel6.BackColor = Color.Silver;
      panel6.BackgroundImage = Properties.Resources.DoorBg2;
      panel6.BackgroundImageLayout = ImageLayout.Stretch;
      panel6.BorderStyle = BorderStyle.FixedSingle;
      panel6.Controls.Add(upDownPanelControl3);
      panel6.Controls.Add(panel7);
      panel6.Location = new Point(3, 113);
      panel6.Name = "panel6";
      panel6.Size = new Size(145, 55);
      panel6.TabIndex = 2;
      // 
      // upDownPanelControl3
      // 
      upDownPanelControl3.Location = new Point(4, 8);
      upDownPanelControl3.Name = "upDownPanelControl3";
      upDownPanelControl3.Size = new Size(16, 31);
      upDownPanelControl3.TabIndex = 2;
      // 
      // panel7
      // 
      panel7.BorderStyle = BorderStyle.FixedSingle;
      panel7.Location = new Point(-1, -61);
      panel7.Name = "panel7";
      panel7.Size = new Size(145, 55);
      panel7.TabIndex = 1;
      // 
      // panel4
      // 
      panel4.BackgroundImage = Properties.Resources.DoorBg2;
      panel4.BackgroundImageLayout = ImageLayout.Stretch;
      panel4.BorderStyle = BorderStyle.FixedSingle;
      panel4.Controls.Add(upDownPanelControl2);
      panel4.Controls.Add(panel5);
      panel4.Location = new Point(3, 168);
      panel4.Name = "panel4";
      panel4.Size = new Size(145, 55);
      panel4.TabIndex = 1;
      // 
      // upDownPanelControl2
      // 
      upDownPanelControl2.Location = new Point(4, 8);
      upDownPanelControl2.Name = "upDownPanelControl2";
      upDownPanelControl2.Size = new Size(16, 31);
      upDownPanelControl2.TabIndex = 2;
      // 
      // panel5
      // 
      panel5.BorderStyle = BorderStyle.FixedSingle;
      panel5.Location = new Point(-1, -61);
      panel5.Name = "panel5";
      panel5.Size = new Size(145, 55);
      panel5.TabIndex = 1;
      // 
      // panel2
      // 
      panel2.BackgroundImage = Properties.Resources.DoorBg2;
      panel2.BackgroundImageLayout = ImageLayout.Stretch;
      panel2.BorderStyle = BorderStyle.FixedSingle;
      panel2.Controls.Add(upDownPanelControl1);
      panel2.Location = new Point(3, 223);
      panel2.Name = "panel2";
      panel2.Size = new Size(145, 55);
      panel2.TabIndex = 0;
      // 
      // upDownPanelControl1
      // 
      upDownPanelControl1.Location = new Point(4, 8);
      upDownPanelControl1.Name = "upDownPanelControl1";
      upDownPanelControl1.Size = new Size(16, 31);
      upDownPanelControl1.TabIndex = 0;
      // 
      // cabinControl1
      // 
      cabinControl1.BackColor = Color.FromArgb(192, 0, 0);
      cabinControl1.BackgroundImage = (Image)resources.GetObject("cabinControl1.BackgroundImage");
      cabinControl1.CabinBl = null;
      cabinControl1.Location = new Point(41, 235);
      cabinControl1.Name = "cabinControl1";
      cabinControl1.Size = new Size(73, 50);
      cabinControl1.TabIndex = 4;
      // 
      // ElevatorForm
      // 
      AutoScaleDimensions = new SizeF(7F, 15F);
      AutoScaleMode = AutoScaleMode.Font;
      ClientSize = new Size(800, 305);
      Controls.Add(cabinControl1);
      Controls.Add(panel1);
      Controls.Add(buttonDashboardControl1);
      Controls.Add(GridViewInsideRequests);
      Name = "ElevatorForm";
      Text = "ElevatorForm";
      Load += ElevatorForm_Load;
      ((System.ComponentModel.ISupportInitialize)GridViewInsideRequests).EndInit();
      panel1.ResumeLayout(false);
      panel9.ResumeLayout(false);
      panel3.ResumeLayout(false);
      panel6.ResumeLayout(false);
      panel4.ResumeLayout(false);
      panel2.ResumeLayout(false);
      ResumeLayout(false);
    }

    #endregion
    private DataGridView GridViewInsideRequests;
    private CabinControls.ButtonDashboardControl buttonDashboardControl1;
    private Panel panel1;
    private Panel panel6;
    private Panel panel7;
    private Panel panel4;
    private Panel panel5;
    private Panel panel2;
    private Panel panel9;
    private Panel panel10;
    private Panel panel3;
    private Panel panel8;
    private CabinControls.CabinControl cabinControl1;
    private FloorControls.UpDownPanelControl upDownPanelControl5;
    private FloorControls.UpDownPanelControl upDownPanelControl4;
    private FloorControls.UpDownPanelControl upDownPanelControl3;
    private FloorControls.UpDownPanelControl upDownPanelControl2;
    private FloorControls.UpDownPanelControl upDownPanelControl1;
  }
}