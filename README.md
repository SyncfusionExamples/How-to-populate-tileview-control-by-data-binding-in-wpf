# Populate TileView Control by Data Binding in WPF
This sample demonstrates how to populate the Syncfusion WPF TileView control using data binding. It covers binding to object collections and XML data, customizing item templates, maximizing/minimizing tiles, reordering tiles via drag-and-drop, and applying built-in themes to deliver an interactive, dashboard-like layout.

## Features
- Bind TileView to ObservableCollection, IEnumerable, or XML data
- Customize item header/content via DataTemplate and HeaderTemplate
- Maximize, minimize, and restore tiles programmatically or via UI
- Drag-and-drop tile reordering with animation
- Control tile sizes (normal, minimized, maximized) and header visibility
- Built-in themes and style customization
- Selection, state, and size change notifications for interaction logic
- Layout persistence support to save/restore tile state

## Usage Tips
- Use ObservableCollection for live updates to tiles when data changes.
- Bind SelectedItem/SelectedIndex to react to user selection.
- Control states with properties like IsMaximized and IsMinimized on containers.
- Customize layout behavior (tile ordering and sizes) via attached properties and styles.
- Persist and restore layout using serialization/persistence APIs if you need stateful dashboards.

## About the Sample
This repository includes examples that show how to populate the TileView from:
- Object collections (e.g., view models with title/content/image/etc.)
- XML data sources (via CollectionViewSource or data provider)

Each example focuses on clean data binding, minimal code-behind, and template-driven customization of tile headers and content. Extend it by adding your own view models, commands, and styles to match your application’s design and behavior.

