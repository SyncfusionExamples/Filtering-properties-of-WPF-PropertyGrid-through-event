# Filtering and Customizing Properties in WPF PropertyGrid Through Event

This sample demonstrates how to filter, customize, group, and reorder properties dynamically in the Syncfusion WPF PropertyGrid using the AutoGeneratingPropertyGridItem event.

By handling this event, you can control which properties are displayed, how they appear, and how they are grouped, entirely at runtime—without relying on attributes in the data model.

## Overview
The Syncfusion WPF PropertyGrid automatically generates property items from the selected object. The _AutoGeneratingPropertyGridItem_ event allows you to intercept this process and:
- Cancel unwanted properties
- Modify display names and descriptions
- Assign categories
- Control the order of properties

This approach is ideal when property presentation needs to be **dynamic, conditional, or UI‑specific**.

## What This Sample Demonstrates
- Filtering properties dynamically using e.Cancel
- Customizing property DisplayName, Description, Category, and Order
- Grouping properties into logical categories
- Disabling default sorting to honor custom ordering
- Binding a business object (Person) to the PropertyGrid

## Key Concepts Used - AutoGeneratingPropertyGridItem Event
This event is triggered for each property before it is added to the PropertyGrid. This allows full runtime control over the property item.

## Use Cases
This pattern is useful when:
- Property visibility depends on UI logic
- You don’t want to modify model classes with attributes
- Properties must be reordered or grouped dynamically
- Enterprise forms require controlled property presentation
