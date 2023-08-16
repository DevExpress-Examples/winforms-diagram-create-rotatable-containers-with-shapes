Imports DevExpress.Diagram.Core
Imports DevExpress.Diagram.Core.Native
Imports DevExpress.Utils
Imports DevExpress.XtraDiagram
Imports System
Imports System.Data
Imports System.Drawing
Imports System.Linq
Imports System.Windows
Imports System.Windows.Forms

Namespace WindowsFormsApp4

    Public Class CustomDiagramContainer
        Inherits DiagramContainer

        Public Overrides Property CanRotate As Boolean?
    End Class

    Public Partial Class Form1
        Inherits Form

        Public Sub New()
            InitializeComponent()
            DiagramControl.ItemTypeRegistrator.Register(GetType(CustomDiagramContainer))
            AddHandler diagramControl1.BeforeItemsRotating, AddressOf DiagramControl1_BeforeItemsRotating
            AddHandler diagramControl1.ItemsRotating, AddressOf DiagramControl1_ItemsRotating
            diagramControl1.Items.Add(CreateContainerShape1())
        End Sub

        Private Sub DiagramControl1_BeforeItemsRotating(ByVal sender As Object, ByVal e As DiagramBeforeItemsRotatingEventArgs)
            Dim containers = e.Items.OfType(Of CustomDiagramContainer)()
            For Each container In containers
                e.Items.Remove(container)
                For Each item In container.Items
                    e.Items.Add(item)
                Next
            Next
        End Sub

        Private Sub DiagramControl1_ItemsRotating(ByVal sender As Object, ByVal e As DiagramItemsRotatingEventArgs)
            Dim groups = e.Items.GroupBy(Function(x) x.Item.ParentItem)
            For Each group In groups
                If TypeOf group.Key Is CustomDiagramContainer Then
                    Dim container = CType(group.Key, CustomDiagramContainer)
                    Dim containingRect = container.Items.[Select](Function(x) x.RotatedDiagramBounds().BoundedRect()).Aggregate(Rect.Empty, New Func(Of Rect, Rect, Rect)(AddressOf Rect.Union))
                    container.Position = New PointFloat(CSng(containingRect.X), CSng(containingRect.Y))
                    container.Width = CSng(containingRect.Width)
                    container.Height = CSng(containingRect.Height)
                End If
            Next
        End Sub

        Protected Overrides Sub OnLoad(ByVal e As EventArgs)
            MyBase.OnLoad(e)
            diagramControl1.FitToItems(diagramControl1.Items)
        End Sub

        Public Function CreateContainerShape1() As CustomDiagramContainer
            Dim container = New CustomDiagramContainer() With {.Width = 200, .Height = 200, .Position = New PointFloat(100F, 100F), .CanAddItems = False, .ItemsCanChangeParent = False, .ItemsCanCopyWithoutParent = False, .ItemsCanDeleteWithoutParent = False, .ItemsCanAttachConnectorBeginPoint = False, .ItemsCanAttachConnectorEndPoint = False}
            container.Appearance.BorderSize = 0
            container.Appearance.BackColor = Color.Transparent
            Dim innerShape1 = New DiagramShape() With {.CanSelect = True, .CanChangeParent = False, .CanEdit = True, .CanResize = False, .CanRotate = False, .CanCopyWithoutParent = False, .CanDeleteWithoutParent = False, .CanMove = False, .Shape = BasicShapes.Trapezoid, .Height = 50, .Width = 200, .Content = "Custom text"}
            Dim innerShape2 = New DiagramShape() With {.CanSelect = False, .CanChangeParent = False, .CanEdit = False, .CanCopyWithoutParent = False, .CanDeleteWithoutParent = False, .CanMove = False, .Shape = BasicShapes.Rectangle, .Height = 150, .Width = 200, .Position = New PointFloat(0, 50)}
            container.Items.Add(innerShape1)
            container.Items.Add(innerShape2)
            Return container
        End Function
    End Class
End Namespace
