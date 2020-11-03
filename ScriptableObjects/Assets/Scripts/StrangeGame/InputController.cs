using System;
using UnityEngine;

namespace StrangeGame
{
    public class InputController : MonoBehaviour
    {
        [SerializeField] private FloatVariable enemyHP;
        [SerializeField] private FloatVariable playerSpeed;
        [SerializeField] private Transform enemyTransform;
        [SerializeField] private Transform playerTransform;
        [SerializeField] private Camera mainCamera;

        private void Update()
        {
            if (Input.GetMouseButton(0))
            {
                var dist = Mathf.Abs(playerTransform.position.x - enemyTransform.position.x);
                if (dist < 1.5f)
                {
                    var ray = mainCamera.ScreenPointToRay(Input.mousePosition);
                    if (Physics.Raycast(ray, out var hit))
                    {
                        if (hit.transform == enemyTransform)
                        {
                            enemyHP.Value -= 0.25f;
                        }
                    }
                }
            }

            playerSpeed.Value = Input.GetAxis("Horizontal");
        }
    }
}