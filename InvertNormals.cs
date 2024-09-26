using UnityEngine;

[ExecuteInEditMode] // Ensures the script runs in edit mode
public class InvertNormals : MonoBehaviour
{
    void Awake() // Awake is called when the object is initialized
    {
        InvertMeshNormals();
    }

    void InvertMeshNormals()
    {
        // Get the MeshFilter component from the GameObject
        MeshFilter meshFilter = GetComponent<MeshFilter>();
        if (meshFilter != null)
        {
            // Use sharedMesh instead of mesh to avoid leaking meshes
            Mesh mesh = meshFilter.sharedMesh;
            if (mesh == null)
            {
                Debug.LogError("No mesh found on the object.");
                return;
            }

            // Invert the normals
            Vector3[] normals = mesh.normals;
            for (int i = 0; i < normals.Length; i++)
            {
                normals[i] = -normals[i]; // Invert the normal direction
            }
            mesh.normals = normals;

            // Invert the triangle winding order to maintain correct rendering
            for (int i = 0; i < mesh.subMeshCount; i++)
            {
                int[] triangles = mesh.GetTriangles(i);
                for (int j = 0; j < triangles.Length; j += 3)
                {
                    int temp = triangles[j];
                    triangles[j] = triangles[j + 1];
                    triangles[j + 1] = temp;
                }
                mesh.SetTriangles(triangles, i);
            }
        }
    }
}
