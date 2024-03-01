<!-- default badges list -->
![](https://img.shields.io/endpoint?url=https://codecentral.devexpress.com/api/v1/VersionRange/661657446/17.2.3%2B)
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/T1175892)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
<!-- default badges end -->

# WinForms DiagramControl - Create Rotatable Containers with Shapes

This example allows users to rotate containers with shapes.

![image](https://github.com/DevExpress-Examples/winforms-diagram-create-rotatable-containers-with-shapes/assets/65009440/7f3fc737-6e9a-4e21-82b2-a80818cd2521)

## Implementation Details

Default diagram containers do not support rotation-related operations. These operations, however, are implemented in the base class. You can define a custom rotatable container in the following manner:

1. Create a [DiagramContainer](https://docs.devexpress.com/WindowsForms/DevExpress.XtraDiagram.DiagramContainer) class descendant.
2. Override the [CanRotate](https://docs.devexpress.com/WindowsForms/DevExpress.XtraDiagram.DiagramItem.CanRotate) property.

   ```csharp
   public class CustomDiagramContainer : DiagramContainer {
       public override bool? CanRotate { get; set; }
   }
   ```

3. Handle the [DiagramControl.BeforeItemsRotating](https://docs.devexpress.com/WindowsForms/DevExpress.XtraDiagram.DiagramControl.BeforeItemsRotating) event and pass container child items to the `e.Items` collection:

   ```csharp
   private void DiagramControl1_BeforeItemsRotating(object sender, DiagramBeforeItemsRotatingEventArgs e) {
       var containers = e.Items.OfType<CustomDiagramContainer>();
       foreach (var container in containers) {
           e.Items.Remove(container);
           foreach (var item in container.Items)
               e.Items.Add(item);
       }
   }
   ```

   In this instance, the `DiagramControl` rotates associated inner items instead of the parent container.
   
4. Handle the [DiagramControl.ItemsRotating](https://docs.devexpress.com/WindowsForms/DevExpress.XtraDiagram.DiagramControl.ItemsRotating) event and correct the container’s position and size:

   ```csharp
   private void DiagramControl1_ItemsRotating(object sender, DiagramItemsRotatingEventArgs e) {
       var groups = e.Items.GroupBy(x => x.Item.ParentItem);
       foreach (var group in groups) {
           if (group.Key is CustomDiagramContainer container) {
               var containingRect = container.Items.Select(x => x.RotatedDiagramBounds().BoundedRect()).Aggregate(Rect.Empty, Rect.Union);
               container.Position = new PointFloat((float)containingRect.X, (float)containingRect.Y);
               container.Width = (float)containingRect.Width;
               container.Height = (float)containingRect.Height;
           }
       }
   }
   ```

## Files to Review

- [Form1.cs](./CS/WindowsFormsApp4/Form1.cs) (VB: [Form1.vb](./VB/WindowsFormsApp4/Form1.vb))

## Documentation

- [Containers and Lists](https://docs.devexpress.com/WindowsForms/117672/controls-and-libraries/diagrams/diagram-items/containers)
- [Create Custom Diagram Items](https://docs.devexpress.com/WindowsForms/404797/controls-and-libraries/diagrams/diagram-items/create-custom-diagram-items)
- [DiagramControl.BeforeItemsRotating](https://docs.devexpress.com/WindowsForms/DevExpress.XtraDiagram.DiagramControl.BeforeItemsRotating)
- [DiagramControl.ItemsRotating](https://docs.devexpress.com/WindowsForms/DevExpress.XtraDiagram.DiagramControl.ItemsRotating)

## More Examples

- [WinForms DiagramControl - Create Custom Shapes Based on Diagram Containers](https://github.com/DevExpress-Examples/winforms-diagram-create-custom-shapes-based-on-diagram-containers)
- [WinForms DiagramControl - Proportionally Resize Shapes Within the Parent Container](https://github.com/DevExpress-Examples/winforms-diagram-proportionally-resize-shapes-within-container)
