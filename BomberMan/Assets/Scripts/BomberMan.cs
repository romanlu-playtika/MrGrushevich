using System.Collections;
using System.Collections.Generic;
using DG.Tweening;
using UnityEngine;
using DG.Tweening;

public class BomberMan : MonoBehaviour
{
    [SerializeField] private LayerMask raycastMask;
    [SerializeField] private LayerMask explosionMask;
    [SerializeField] private GameObject bombPrefab;
    [SerializeField] private Transform bombParentTransform;
    private bool isInMovement;
    private Vector2 lastMoveVector;

    // Update is called once per frame
    void Update()
    {
        if (isInMovement)
        {
            return;
        }

        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            MovePlayerTo(Vector2.left);
            lastMoveVector = Vector2.left;
        }
        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            MovePlayerTo(Vector2.right);
            lastMoveVector = Vector2.right;
        }
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            MovePlayerTo(Vector2.up);
            lastMoveVector = Vector2.up;
        }
        if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            MovePlayerTo(Vector2.down);
            lastMoveVector = Vector2.down;
        }

        if (Input.GetMouseButtonDown(0))
        {
            var obj = RaycastFromCamera();
            if (obj != null && obj.CompareTag("Explosive"))
            {
                Destroy(obj);

                var colliders = Physics2D.OverlapCircleAll(obj.transform.position, 1f, explosionMask);
                foreach (var cldr in colliders)
                {
                    Destroy(cldr.gameObject);
                }
            }
        }

        if (Input.GetKeyDown(KeyCode.Space))
        {
            SetBomb();
        }
    }

    private void MovePlayerTo(Vector2 dir)
    {
        if (Raycast(dir))
        {
            return;
        }

        isInMovement = true;
        var pos = (Vector2) transform.position + dir;
        transform.DOMove(pos,0.5f).OnComplete(() =>
        {
            isInMovement = false;
        });
    }

    private bool Raycast(Vector2 dir)
    {
        var hit = Physics2D.Raycast(transform.position, dir, 1f, raycastMask);
        return hit.collider != null;
    }

    private GameObject RaycastFromCamera()
    {
        var hit = Physics2D.Raycast(Camera.main.ScreenToWorldPoint(Input.mousePosition),
            Vector2.zero, 1f);
        return hit.collider ? hit.collider.gameObject : null;
    }

    private void SetBomb()
    {
        var bombPosition = transform.position + new Vector3(lastMoveVector.x, lastMoveVector.y, 0f);
        var bomb = Instantiate(bombPrefab, bombPosition, Quaternion.identity, bombParentTransform);
    }
}
