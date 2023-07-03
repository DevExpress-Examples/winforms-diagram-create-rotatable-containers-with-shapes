# WinForms - How to support rotating for containers with shapes

This example demonstrates how to support rotating for containers with shapes. Containers don't supply the rotating feature by default. However, this feature is implemented in the base class. If you need to enable this feature to rotate custom groups of shapes or custom shapes created within a container, you can enable this feature at the DiagramContainer class descendant:

```csharp
public class CustomDiagramContainer : DiagramContainer {
	public override bool? CanRotate { get; set; }
}

```

After that, handle `DiagramControl`'s [BeforeItemsRotating](https://docs.devexpress.com/WindowsForms/DevExpress.XtraDiagram.DiagramControl.BeforeItemsRotating) event and pass a container's child items to the `e.Items` collection:

```csharp
private void DiagramControl1_BeforeItemsRotating(object sender, DiagramBeforeItemsRotatingEventArgs e) {
	var containers = e.Items.OfType<DiagramContainer>();
	foreach (var container in containers) {
		e.Items.Remove(container);
		foreach (var item in container.Items)
			e.Items.Add(item);
	}
}
```

In this case, `DiagramControl` will rotate the inner items instead of the parent container.
After that, handle `DiagramControl`'s [ItemsRotating](https://docs.devexpress.com/WindowsForms/DevExpress.XtraDiagram.DiagramControl.ItemsRotating) event and correct the container's position and size:

```csharp
private void DiagramControl1_ItemsRotating(object sender, DiagramItemsRotatingEventArgs e) {
	var groups = e.Items.GroupBy(x => x.Item.ParentItem);
	foreach (var group in groups) {
		var container = (DiagramContainer)group.Key;
		var containingRect = container.Items.Select(x => x.RotatedDiagramBounds().BoundedRect()).Aggregate(Rect.Empty, Rect.Union);
		container.Position = new PointFloat((float)containingRect.X, (float)containingRect.Y);
		container.Width = (float)containingRect.Width;
		container.Height = (float)containingRect.Height;
	}
}
```

## Files to Review

- link.cs (VB: link.vb)
- link.js
- ...

## Documentation

- link
- link
- ...

## More Examples

- link
- link
- ...
