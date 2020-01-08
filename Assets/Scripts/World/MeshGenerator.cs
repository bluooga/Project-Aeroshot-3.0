using UnityEngine;

[RequireComponent(typeof(MeshFilter))]
public class MeshGenerator : MonoBehaviour
{
    Mesh mesh;
    public Material material;

    Vector3[] Vertices;
    int[] tri;

    public int XSize;
    public int ZSize;

    public float Scale;

    public float NoiseLayers;
    public float Height;
    // Start is called before the first frame update
    void Start()
    {
        mesh = new Mesh();
        GetComponent<MeshFilter>().mesh = mesh;
        CreateShape();
        UpdateMesh();
        GetComponent<MeshCollider>().sharedMesh = mesh;
    }

    private void Update()
    {

    }

    void CreateShape()
    {
        Vertices = new Vector3[(XSize + 1) * (ZSize + 1)];

        for (int i = 0, z = 0; z <= ZSize; z++)
        {
            for (int x = 0; x <= XSize; x++)
            {
                float y = Mathf.Pow(Mathf.PerlinNoise(x * Scale, z * Scale), NoiseLayers) * Height;
                Vertices[i] = new Vector3(x, y, z);
                i++;
            }
        }

        tri = new int[XSize * ZSize * 6];

        int vert = 0;
        int tris = 0;

        for (int z = 0; z < ZSize; z++)
        {
            for (int x = 0; x < XSize; x++)
            {
                tri[tris + 0] = vert + 0;
                tri[tris + 1] = vert + XSize + 1;
                tri[tris + 2] = vert + 1;
                tri[tris + 3] = vert + 1;
                tri[tris + 4] = vert + XSize + 1;
                tri[tris + 5] = vert + XSize + 2;

                vert++;
                tris += 6;
            }
            vert++;
        }
    }

    void UpdateMesh()
    {
        mesh.Clear();

        mesh.vertices = Vertices;
        mesh.triangles = tri;
        mesh.RecalculateNormals();
    }
}
