using UnityEngine;
using System.Collections;

public class CubeScript : MonoBehaviour
{
    // Use this for initialization
    public Shader shader;
    public Texture texture;
    //public Texture texture;
    void Awake()
    {
        if(this.gameObject.GetComponent<MeshFilter>() == null)
        {
            MeshFilter cubeMesh = this.gameObject.AddComponent<MeshFilter>();
            cubeMesh.mesh = this.CreateCubeMesh();
        }

        if(this.gameObject.GetComponent<MeshRenderer>() == null)
        {
            this.gameObject.AddComponent<MeshRenderer>();
        }
    }

    void OnEnable()
    {
        MeshRenderer renderer = this.gameObject.GetComponent<MeshRenderer>();
        renderer.material.shader = this.shader;
        renderer.material.mainTexture = this.texture;
    }


    // Method to create a cube mesh with coloured vertices
    Mesh CreateCubeMesh()
    {
        Mesh m = new Mesh();
        m.name = "Cube";

        // Define the vertices. These are the "points" in 3D space that allow us to
        // construct 3D geometry (by connecting groups of 3 points into triangles).
        m.vertices = new[] {
            new Vector3(-1.0f, 1.0f, -1.0f), // Top
            new Vector3(-1.0f, 1.0f, 1.0f),
            new Vector3(1.0f, 1.0f, 1.0f),
            new Vector3(-1.0f, 1.0f, -1.0f),
            new Vector3(1.0f, 1.0f, 1.0f),
            new Vector3(1.0f, 1.0f, -1.0f),

            new Vector3(-1.0f, -1.0f, -1.0f), // Bottom
            new Vector3(1.0f, -1.0f, 1.0f),
            new Vector3(-1.0f, -1.0f, 1.0f),
            new Vector3(-1.0f, -1.0f, -1.0f),
            new Vector3(1.0f, -1.0f, -1.0f),
            new Vector3(1.0f, -1.0f, 1.0f),

            new Vector3(-1.0f, -1.0f, -1.0f), // Left
            new Vector3(-1.0f, -1.0f, 1.0f),
            new Vector3(-1.0f, 1.0f, 1.0f),
            new Vector3(-1.0f, -1.0f, -1.0f),
            new Vector3(-1.0f, 1.0f, 1.0f),
            new Vector3(-1.0f, 1.0f, -1.0f),

            new Vector3(1.0f, -1.0f, -1.0f), // Right
            new Vector3(1.0f, 1.0f, 1.0f),
            new Vector3(1.0f, -1.0f, 1.0f),
            new Vector3(1.0f, -1.0f, -1.0f),
            new Vector3(1.0f, 1.0f, -1.0f),
            new Vector3(1.0f, 1.0f, 1.0f),

            new Vector3(-1.0f, 1.0f, 1.0f), // Front
            new Vector3(1.0f, -1.0f, 1.0f),
            new Vector3(1.0f, 1.0f, 1.0f),
            new Vector3(-1.0f, 1.0f, 1.0f),
            new Vector3(-1.0f, -1.0f, 1.0f),
            new Vector3(1.0f, -1.0f, 1.0f),

            new Vector3(-1.0f, 1.0f, -1.0f), // Back
            new Vector3(1.0f, 1.0f, -1.0f),
            new Vector3(1.0f, -1.0f, -1.0f),
            new Vector3(-1.0f, -1.0f, -1.0f),
            new Vector3(-1.0f, 1.0f, -1.0f),
            new Vector3(1.0f, -1.0f, -1.0f)
        };

        // Define the vertex colours
        m.colors = new[] {
            Color.red, // Top
            Color.red,
            Color.red,
            Color.red,
            Color.red,
            Color.red,

            Color.red, // Bottom
            Color.red,
            Color.red,
            Color.red,
            Color.red,
            Color.red,

            Color.yellow, // Left
            Color.yellow,
            Color.yellow,
            Color.yellow,
            Color.yellow,
            Color.yellow,

            Color.yellow, // Right
            Color.yellow,
            Color.yellow,
            Color.yellow,
            Color.yellow,
            Color.yellow,

            Color.blue, // Front
            Color.blue,
            Color.blue,
            Color.blue,
            Color.blue,
            Color.blue,

            Color.blue, // Back
            Color.blue,
            Color.blue,
            Color.blue,
            Color.blue,
            Color.blue
        };

        // Define the uv coordinates
        m.uv = new[] {
            new Vector2(0.0f, 0.666f), // Top
            new Vector2(0.0f, 1.0f),
            new Vector2(0.333f, 1.0f),
            new Vector2(0.0f, 0.666f),
            new Vector2(0.333f, 1.0f),
            new Vector2(0.333f, 0.666f),

            new Vector2(0.333f, 0.333f), // Bottom
            new Vector2(0.666f, 0.0f),
            new Vector2(0.333f, 0.0f),
            new Vector2(0.333f, 0.333f),
            new Vector2(0.666f, 0.333f),
            new Vector2(0.666f, 0.0f),

            new Vector2(0.666f, 0.666f),
            new Vector2(0.333f, 0.666f),
            new Vector2(0.333f, 1.0f),
            new Vector2(0.666f, 0.666f), // Left
            new Vector2(0.333f, 1.0f),
            new Vector2(0.666f, 1.0f),
            

            new Vector2(0.0f, 0.333f), // Right
            new Vector2(0.333f, 0.666f),
            new Vector2(0.333f, 0.333f),
            new Vector2(0.0f, 0.333f),
            new Vector2(0.0f, 0.666f),
            new Vector2(0.333f, 0.666f),

            
            
            // Front
            new Vector2(0.666f, 0.666f),
            new Vector2(0.333f, 0.333f),
            new Vector2(0.333f, 0.666f),
            
            new Vector2(0.666f, 0.666f),
            new Vector2(0.666f, 0.333f),
            new Vector2(0.333f, 0.333f),

            new Vector2(0.0f, 0.333f), // Back
            new Vector2(0.333f, 0.333f),
            new Vector2(0.333f, 0.0f),
            new Vector2(0.0f, 0.0f),
            new Vector2(0.0f, 0.333f),
            new Vector2(0.333f, 0.0f)
        };

        // Automatically define the triangles based on the number of vertices
        int[] triangles = new int[m.vertices.Length];
        for (int i = 0; i < m.vertices.Length; i++)
            triangles[i] = i;

        m.triangles = triangles;

        return m;
    }
}
