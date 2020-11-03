using UnityEngine;

public class MousePicker : MonoBehaviour
{
    [SerializeField] private float raycastDistance = 200f;

    private Camera mainCamera;
    private BaseFigure figureToMove;

    private void Start()
    {
        mainCamera = Camera.main;
    }

    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            RaycastHit hit;

            if (Physics.Raycast(mainCamera.ScreenPointToRay(Input.mousePosition), out hit, raycastDistance))
            {
                var selectedFigure = hit.collider.gameObject.GetComponent<BaseFigure>();

                if (selectedFigure != null)
                {
                    if (figureToMove != null)
                    {
                        figureToMove.SetSelectedColor(false);
                    }
                    figureToMove = selectedFigure;
                    figureToMove.SetSelectedColor(true);
                }
                else
                {
                    if (figureToMove == null) return;

                    figureToMove.Move();
                    figureToMove.SetSelectedColor(false);
                    figureToMove = null;
                }
            }
        }
    }
}

