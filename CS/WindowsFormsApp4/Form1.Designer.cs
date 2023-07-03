namespace WindowsFormsApp4
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.diagramControl1 = new DevExpress.XtraDiagram.DiagramControl();
            this.diagramPropertyGridDockPanel1 = new DevExpress.XtraDiagram.Docking.DiagramPropertyGridDockPanel();
            this.diagramToolboxDockPanel1 = new DevExpress.XtraDiagram.Docking.DiagramToolboxDockPanel();
            this.dockManager1 = new DevExpress.XtraBars.Docking.DockManager(this.components);
            this.hideContainerRight = new DevExpress.XtraBars.Docking.AutoHideContainer();
            ((System.ComponentModel.ISupportInitialize)(this.diagramControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.diagramPropertyGridDockPanel1.PropertyGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dockManager1)).BeginInit();
            this.hideContainerRight.SuspendLayout();
            this.SuspendLayout();
            // 
            // diagramControl1
            // 
            this.diagramControl1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.diagramControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.diagramControl1.Location = new System.Drawing.Point(300, 0);
            this.diagramControl1.Name = "diagramControl1";
            this.diagramControl1.OptionsBehavior.SelectedStencils = new DevExpress.Diagram.Core.StencilCollection(new string[] {
            "BasicShapes",
            "BasicFlowchartShapes"});
            this.diagramControl1.OptionsView.PaperKind = System.Drawing.Printing.PaperKind.Letter;
            this.diagramControl1.PropertyGrid = this.diagramPropertyGridDockPanel1;
            this.diagramControl1.Size = new System.Drawing.Size(1363, 1142);
            this.diagramControl1.TabIndex = 0;
            this.diagramControl1.Text = "diagramControl1";
            this.diagramControl1.Toolbox = this.diagramToolboxDockPanel1;
            // 
            // diagramPropertyGridDockPanel1
            // 
            this.diagramPropertyGridDockPanel1.Dock = DevExpress.XtraBars.Docking.DockingStyle.Right;
            this.diagramPropertyGridDockPanel1.ID = new System.Guid("2012556b-9fa5-4bc9-807a-459a9e735f35");
            this.diagramPropertyGridDockPanel1.Location = new System.Drawing.Point(0, 0);
            this.diagramPropertyGridDockPanel1.Name = "diagramPropertyGridDockPanel1";
            this.diagramPropertyGridDockPanel1.Options.AllowFloating = false;
            this.diagramPropertyGridDockPanel1.OriginalSize = new System.Drawing.Size(300, 200);
            // 
            // 
            // 
            this.diagramPropertyGridDockPanel1.PropertyGrid.BandsInterval = 3;
            this.diagramPropertyGridDockPanel1.PropertyGrid.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.diagramPropertyGridDockPanel1.PropertyGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.diagramPropertyGridDockPanel1.PropertyGrid.Location = new System.Drawing.Point(0, 0);
            this.diagramPropertyGridDockPanel1.PropertyGrid.Margin = new System.Windows.Forms.Padding(5);
            this.diagramPropertyGridDockPanel1.PropertyGrid.Name = "propertyGrid";
            this.diagramPropertyGridDockPanel1.PropertyGrid.OptionsMenu.EnableContextMenu = true;
            this.diagramPropertyGridDockPanel1.PropertyGrid.OptionsView.FixedLineWidth = 3;
            this.diagramPropertyGridDockPanel1.PropertyGrid.OptionsView.MinRowAutoHeight = 18;
            this.diagramPropertyGridDockPanel1.PropertyGrid.Size = new System.Drawing.Size(200, 100);
            this.diagramPropertyGridDockPanel1.PropertyGrid.TabIndex = 6;
            this.diagramPropertyGridDockPanel1.SavedDock = DevExpress.XtraBars.Docking.DockingStyle.Right;
            this.diagramPropertyGridDockPanel1.SavedIndex = 1;
            this.diagramPropertyGridDockPanel1.Size = new System.Drawing.Size(300, 450);
            this.diagramPropertyGridDockPanel1.Visibility = DevExpress.XtraBars.Docking.DockVisibility.AutoHide;
            // 
            // diagramToolboxDockPanel1
            // 
            this.diagramToolboxDockPanel1.Dock = DevExpress.XtraBars.Docking.DockingStyle.Left;
            this.diagramToolboxDockPanel1.FloatSize = new System.Drawing.Size(200, 500);
            this.diagramToolboxDockPanel1.ID = new System.Guid("de28fe03-c82e-4690-8d60-153ff79b1e5e");
            this.diagramToolboxDockPanel1.Location = new System.Drawing.Point(0, 0);
            this.diagramToolboxDockPanel1.Name = "diagramToolboxDockPanel1";
            this.diagramToolboxDockPanel1.Options.AllowFloating = false;
            this.diagramToolboxDockPanel1.OriginalSize = new System.Drawing.Size(300, 200);
            this.diagramToolboxDockPanel1.Size = new System.Drawing.Size(300, 1142);
            // 
            // 
            // 
            this.diagramToolboxDockPanel1.Toolbox.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.diagramToolboxDockPanel1.Toolbox.Caption = "Shapes";
            this.diagramToolboxDockPanel1.Toolbox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.diagramToolboxDockPanel1.Toolbox.Location = new System.Drawing.Point(0, 0);
            this.diagramToolboxDockPanel1.Toolbox.Name = "";
            this.diagramToolboxDockPanel1.Toolbox.OptionsBehavior.ItemSelectMode = DevExpress.XtraToolbox.ToolboxItemSelectMode.Single;
            this.diagramToolboxDockPanel1.Toolbox.OptionsView.ItemImageSize = new System.Drawing.Size(32, 32);
            this.diagramToolboxDockPanel1.Toolbox.OptionsView.MenuButtonCaption = "More Shapes";
            this.diagramToolboxDockPanel1.Toolbox.OptionsView.ShowToolboxCaption = true;
            this.diagramToolboxDockPanel1.Toolbox.SelectedGroupIndex = 1;
            this.diagramToolboxDockPanel1.Toolbox.Size = new System.Drawing.Size(282, 1090);
            this.diagramToolboxDockPanel1.Toolbox.TabIndex = 0;
            this.diagramToolboxDockPanel1.Toolbox.Text = "Shapes";
            // 
            // dockManager1
            // 
            this.dockManager1.AutoHideContainers.AddRange(new DevExpress.XtraBars.Docking.AutoHideContainer[] {
            this.hideContainerRight});
            this.dockManager1.Form = this;
            this.dockManager1.RootPanels.AddRange(new DevExpress.XtraBars.Docking.DockPanel[] {
            this.diagramToolboxDockPanel1});
            this.dockManager1.TopZIndexControls.AddRange(new string[] {
            "DevExpress.XtraBars.BarDockControl",
            "DevExpress.XtraBars.StandaloneBarDockControl",
            "System.Windows.Forms.MenuStrip",
            "System.Windows.Forms.StatusStrip",
            "System.Windows.Forms.StatusBar",
            "DevExpress.XtraBars.Ribbon.RibbonStatusBar",
            "DevExpress.XtraBars.Ribbon.RibbonControl",
            "DevExpress.XtraBars.Navigation.OfficeNavigationBar",
            "DevExpress.XtraBars.Navigation.TileNavPane",
            "DevExpress.XtraBars.TabFormControl",
            "DevExpress.XtraBars.FluentDesignSystem.FluentDesignFormControl",
            "DevExpress.XtraBars.ToolbarForm.ToolbarFormControl"});
            // 
            // hideContainerRight
            // 
            this.hideContainerRight.BackColor = System.Drawing.SystemColors.Control;
            this.hideContainerRight.Controls.Add(this.diagramPropertyGridDockPanel1);
            this.hideContainerRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.hideContainerRight.Location = new System.Drawing.Point(1663, 0);
            this.hideContainerRight.Name = "hideContainerRight";
            this.hideContainerRight.Size = new System.Drawing.Size(33, 1142);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1696, 1142);
            this.Controls.Add(this.diagramControl1);
            this.Controls.Add(this.diagramToolboxDockPanel1);
            this.Controls.Add(this.hideContainerRight);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.diagramControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.diagramPropertyGridDockPanel1.PropertyGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dockManager1)).EndInit();
            this.hideContainerRight.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraDiagram.DiagramControl diagramControl1;
        private DevExpress.XtraDiagram.Docking.DiagramPropertyGridDockPanel diagramPropertyGridDockPanel1;
        private DevExpress.XtraDiagram.Docking.DiagramToolboxDockPanel diagramToolboxDockPanel1;
        private DevExpress.XtraBars.Docking.DockManager dockManager1;
        private DevExpress.XtraBars.Docking.AutoHideContainer hideContainerRight;
    }
}

