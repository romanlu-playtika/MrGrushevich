using System;
using UnityEngine;

namespace StrangeGame
{
    public class PlayerCharacter : CharacterBase
    {
        [SerializeField] private Transform enemy;

        private void Update()
        {
            var dist = enemy.transform.position.x - transform.position.x;
            if (dist >= 1.0f || characterInfo.Speed < 0f)
            {
                transform.Translate(Time.deltaTime * characterInfo.Speed * transform.forward, Space.World);
            }
        }
    }
}