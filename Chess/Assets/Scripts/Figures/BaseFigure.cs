using UnityEngine;

public abstract class BaseFigure : MonoBehaviour
{
    [SerializeField] private FigureData figureData;
    [SerializeField] private MeshRenderer figureMeshRenderer;
    [SerializeField] private MeshFilter figureMeshFilter;

    public void Initialize()
    {
        SetMesh();
        SetMaterial();
    }
    
    public abstract void Move();

    public void SetMesh()
    {
        figureMeshFilter.sharedMesh = figureData.figureMesh;
    }

    private void SetMaterial()
    {
        figureMeshRenderer.sharedMaterial = figureData.figureMaterial;
    }
}
