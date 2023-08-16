Namespace WindowsFormsApp4

    Partial Class Form1

        ''' <summary>
        ''' Required designer variable.
        ''' </summary>
        Private components As System.ComponentModel.IContainer = Nothing

        ''' <summary>
        ''' Clean up any resources being used.
        ''' </summary>
        ''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        Protected Overrides Sub Dispose(ByVal disposing As Boolean)
            If disposing AndAlso (Me.components IsNot Nothing) Then
                Me.components.Dispose()
            End If

            MyBase.Dispose(disposing)
        End Sub

#Region "Windows Form Designer generated code"
        ''' <summary>
        ''' Required method for Designer support - do not modify
        ''' the contents of this method with the code editor.
        ''' </summary>
        Private Sub InitializeComponent()
            Me.components = New System.ComponentModel.Container()
            Me.diagramControl1 = New DevExpress.XtraDiagram.DiagramControl()
            Me.diagramPropertyGridDockPanel1 = New DevExpress.XtraDiagram.Docking.DiagramPropertyGridDockPanel()
            Me.diagramToolboxDockPanel1 = New DevExpress.XtraDiagram.Docking.DiagramToolboxDockPanel()
            Me.dockManager1 = New DevExpress.XtraBars.Docking.DockManager(Me.components)
            Me.hideContainerRight = New DevExpress.XtraBars.Docking.AutoHideContainer()
            CType((Me.diagramControl1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.diagramPropertyGridDockPanel1.PropertyGrid), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.dockManager1), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.hideContainerRight.SuspendLayout()
            Me.SuspendLayout()
            ' 
            ' diagramControl1
            ' 
            Me.diagramControl1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
            Me.diagramControl1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.diagramControl1.Location = New System.Drawing.Point(300, 0)
            Me.diagramControl1.Name = "diagramControl1"
            Me.diagramControl1.OptionsBehavior.SelectedStencils = New DevExpress.Diagram.Core.StencilCollection(New String() {"BasicShapes", "BasicFlowchartShapes"})
            Me.diagramControl1.OptionsView.PaperKind = System.Drawing.Printing.PaperKind.Letter
            Me.diagramControl1.PropertyGrid = Me.diagramPropertyGridDockPanel1
            Me.diagramControl1.Size = New System.Drawing.Size(1363, 1142)
            Me.diagramControl1.TabIndex = 0
            Me.diagramControl1.Text = "diagramControl1"
            Me.diagramControl1.Toolbox = Me.diagramToolboxDockPanel1
            ' 
            ' diagramPropertyGridDockPanel1
            ' 
            Me.diagramPropertyGridDockPanel1.Dock = DevExpress.XtraBars.Docking.DockingStyle.Right
            Me.diagramPropertyGridDockPanel1.ID = New System.Guid("2012556b-9fa5-4bc9-807a-459a9e735f35")
            Me.diagramPropertyGridDockPanel1.Location = New System.Drawing.Point(0, 0)
            Me.diagramPropertyGridDockPanel1.Name = "diagramPropertyGridDockPanel1"
            Me.diagramPropertyGridDockPanel1.Options.AllowFloating = False
            Me.diagramPropertyGridDockPanel1.OriginalSize = New System.Drawing.Size(300, 200)
            ' 
            ' 
            ' 
            Me.diagramPropertyGridDockPanel1.PropertyGrid.BandsInterval = 3
            Me.diagramPropertyGridDockPanel1.PropertyGrid.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
            Me.diagramPropertyGridDockPanel1.PropertyGrid.Dock = System.Windows.Forms.DockStyle.Fill
            Me.diagramPropertyGridDockPanel1.PropertyGrid.Location = New System.Drawing.Point(0, 0)
            Me.diagramPropertyGridDockPanel1.PropertyGrid.Margin = New System.Windows.Forms.Padding(5)
            Me.diagramPropertyGridDockPanel1.PropertyGrid.Name = "propertyGrid"
            Me.diagramPropertyGridDockPanel1.PropertyGrid.OptionsMenu.EnableContextMenu = True
            Me.diagramPropertyGridDockPanel1.PropertyGrid.OptionsView.FixedLineWidth = 3
            Me.diagramPropertyGridDockPanel1.PropertyGrid.OptionsView.MinRowAutoHeight = 18
            Me.diagramPropertyGridDockPanel1.PropertyGrid.Size = New System.Drawing.Size(200, 100)
            Me.diagramPropertyGridDockPanel1.PropertyGrid.TabIndex = 6
            Me.diagramPropertyGridDockPanel1.SavedDock = DevExpress.XtraBars.Docking.DockingStyle.Right
            Me.diagramPropertyGridDockPanel1.SavedIndex = 1
            Me.diagramPropertyGridDockPanel1.Size = New System.Drawing.Size(300, 450)
            Me.diagramPropertyGridDockPanel1.Visibility = DevExpress.XtraBars.Docking.DockVisibility.AutoHide
            ' 
            ' diagramToolboxDockPanel1
            ' 
            Me.diagramToolboxDockPanel1.Dock = DevExpress.XtraBars.Docking.DockingStyle.Left
            Me.diagramToolboxDockPanel1.FloatSize = New System.Drawing.Size(200, 500)
            Me.diagramToolboxDockPanel1.ID = New System.Guid("de28fe03-c82e-4690-8d60-153ff79b1e5e")
            Me.diagramToolboxDockPanel1.Location = New System.Drawing.Point(0, 0)
            Me.diagramToolboxDockPanel1.Name = "diagramToolboxDockPanel1"
            Me.diagramToolboxDockPanel1.Options.AllowFloating = False
            Me.diagramToolboxDockPanel1.OriginalSize = New System.Drawing.Size(300, 200)
            Me.diagramToolboxDockPanel1.Size = New System.Drawing.Size(300, 1142)
            ' 
            ' 
            ' 
            Me.diagramToolboxDockPanel1.Toolbox.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
            Me.diagramToolboxDockPanel1.Toolbox.Caption = "Shapes"
            Me.diagramToolboxDockPanel1.Toolbox.Dock = System.Windows.Forms.DockStyle.Fill
            Me.diagramToolboxDockPanel1.Toolbox.Location = New System.Drawing.Point(0, 0)
            Me.diagramToolboxDockPanel1.Toolbox.Name = ""
            Me.diagramToolboxDockPanel1.Toolbox.OptionsBehavior.ItemSelectMode = DevExpress.XtraToolbox.ToolboxItemSelectMode.[Single]
            Me.diagramToolboxDockPanel1.Toolbox.OptionsView.ItemImageSize = New System.Drawing.Size(32, 32)
            Me.diagramToolboxDockPanel1.Toolbox.OptionsView.MenuButtonCaption = "More Shapes"
            Me.diagramToolboxDockPanel1.Toolbox.OptionsView.ShowToolboxCaption = True
            Me.diagramToolboxDockPanel1.Toolbox.SelectedGroupIndex = 1
            Me.diagramToolboxDockPanel1.Toolbox.Size = New System.Drawing.Size(282, 1090)
            Me.diagramToolboxDockPanel1.Toolbox.TabIndex = 0
            Me.diagramToolboxDockPanel1.Toolbox.Text = "Shapes"
            ' 
            ' dockManager1
            ' 
            Me.dockManager1.AutoHideContainers.AddRange(New DevExpress.XtraBars.Docking.AutoHideContainer() {Me.hideContainerRight})
            Me.dockManager1.Form = Me
            Me.dockManager1.RootPanels.AddRange(New DevExpress.XtraBars.Docking.DockPanel() {Me.diagramToolboxDockPanel1})
            Me.dockManager1.TopZIndexControls.AddRange(New String() {"DevExpress.XtraBars.BarDockControl", "DevExpress.XtraBars.StandaloneBarDockControl", "System.Windows.Forms.MenuStrip", "System.Windows.Forms.StatusStrip", "System.Windows.Forms.StatusBar", "DevExpress.XtraBars.Ribbon.RibbonStatusBar", "DevExpress.XtraBars.Ribbon.RibbonControl", "DevExpress.XtraBars.Navigation.OfficeNavigationBar", "DevExpress.XtraBars.Navigation.TileNavPane", "DevExpress.XtraBars.TabFormControl", "DevExpress.XtraBars.FluentDesignSystem.FluentDesignFormControl", "DevExpress.XtraBars.ToolbarForm.ToolbarFormControl"})
            ' 
            ' hideContainerRight
            ' 
            Me.hideContainerRight.BackColor = System.Drawing.SystemColors.Control
            Me.hideContainerRight.Controls.Add(Me.diagramPropertyGridDockPanel1)
            Me.hideContainerRight.Dock = System.Windows.Forms.DockStyle.Right
            Me.hideContainerRight.Location = New System.Drawing.Point(1663, 0)
            Me.hideContainerRight.Name = "hideContainerRight"
            Me.hideContainerRight.Size = New System.Drawing.Size(33, 1142)
            ' 
            ' Form1
            ' 
            Me.AutoScaleDimensions = New System.Drawing.SizeF(11F, 24F)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.ClientSize = New System.Drawing.Size(1696, 1142)
            Me.Controls.Add(Me.diagramControl1)
            Me.Controls.Add(Me.diagramToolboxDockPanel1)
            Me.Controls.Add(Me.hideContainerRight)
            Me.Name = "Form1"
            Me.Text = "Form1"
            CType((Me.diagramControl1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.diagramPropertyGridDockPanel1.PropertyGrid), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.dockManager1), System.ComponentModel.ISupportInitialize).EndInit()
            Me.hideContainerRight.ResumeLayout(False)
            Me.ResumeLayout(False)
        End Sub

#End Region
        Private diagramControl1 As DevExpress.XtraDiagram.DiagramControl

        Private diagramPropertyGridDockPanel1 As DevExpress.XtraDiagram.Docking.DiagramPropertyGridDockPanel

        Private diagramToolboxDockPanel1 As DevExpress.XtraDiagram.Docking.DiagramToolboxDockPanel

        Private dockManager1 As DevExpress.XtraBars.Docking.DockManager

        Private hideContainerRight As DevExpress.XtraBars.Docking.AutoHideContainer
    End Class
End Namespace
