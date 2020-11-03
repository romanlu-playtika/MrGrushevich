using UnityEngine;

public abstract class BaseFigure : MonoBehaviour
{
    [SerializeField] private FigureData figureData;
    [SerializeField] private MeshRenderer figureMeshRenderer;
    [SerializeField] private MeshFilter figureMeshFilter;
    
    private Color baseColor;

    public void Initialize()
    {
        SetMesh();
        SetMaterial();
        InitBaseColor();
    }

    public virtual void Move()
    {
        var clampedPosition = transform.position;
        clampedPosition.x = Mathf.Clamp(clampedPosition.x, 0, 7);
        clampedPosition.z = Mathf.Clamp(clampedPosition.z, 0, 7);
        transform.position = clampedPosition;
    }

    private void SetMesh()
    {
        figureMeshFilter.sharedMesh = figureData.figureMesh;
    }

    private void SetMaterial()
    {
        figureMeshRenderer.sharedMaterial = figureData.figureMaterial;
    }

    public void SetSelectedColor(bool isSelected)
    {
        figureMeshRenderer.material.color = isSelected ? Color.cyan : baseColor;
    }

    private void InitBaseColor()
    {
        baseColor = figureMeshRenderer.material.color;
    }
}
