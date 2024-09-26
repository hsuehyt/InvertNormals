# InvertNormals

### Description

**InvertNormals** is a Unity script designed to invert the normals of a 3D mesh, making the inner surface of the mesh visible while rendering the outer surface invisible. This is particularly useful for creating sky domes, tunnels, or any scenario where you need to view the inside of a mesh.

### Features
- Inverts mesh normals in both **Play Mode** and **Edit Mode** using the `[ExecuteInEditMode]` attribute.
- Modifies the shared mesh to avoid mesh instantiation and memory leaks.
- Automatically inverts triangle winding order to ensure correct rendering.

### Requirements
- Unity 2021 or higher (may work in earlier versions as well).
- Works on any 3D object with a `MeshFilter` component.

### Installation

1. **Download the Script**: Clone or download this repository to your Unity project.
   
2. **Add the Script to Your Project**:
   - Place the `InvertNormals.cs` script into your Unity project’s `Scripts` folder or any preferred location.

3. **Attach the Script**:
   - Drag and drop the script onto any GameObject in the scene that has a `MeshFilter` component.
   - For example, you can attach it to a **sphere** object to turn it into a sky dome by inverting its normals.

4. **Customization**:
   - No extra configuration is needed; once attached, the normals will be inverted immediately.

### How to Use

1. **Add the Script to an Object**:
   - Select a 3D object (like a sphere) in your scene.
   - Drag the `InvertNormals.cs` script onto the object.
   
2. **Inspect the Effect**:
   - In **Edit Mode**, you’ll see that the normals are inverted immediately, turning the object inside out.
   - If you're working on a sky dome, place your camera inside the object to view the effect.

3. **Play Mode**:
   - The script also works in **Play Mode**, ensuring that the normals are inverted if the scene is run.

### Example Use Case

- **Sky Dome**: Use a sphere as a sky dome by attaching the `InvertNormals.cs` script to the sphere. Apply a sky texture or material, and place the camera inside the inverted sphere for a 360-degree skybox effect.

### Troubleshooting

- **No Mesh Found**: If you see the error `"No mesh found on the object"`, ensure the GameObject you are attaching the script to has a `MeshFilter` with a valid mesh assigned.
  
- **Mesh Not Inverting**: Ensure you are using `sharedMesh` instead of `mesh` in your code, especially if you modified the script yourself.