using System.Collections;
using System.Collections.Generic;
using StrangeGame;
using UnityEngine;

namespace StrangeGame
{
    public class EnemyCharacter : CharacterBase
    {
        [SerializeField] private Transform player;

        [SerializeField] private FloatVariable playerHP;



        protected void Update()
        {
            if (Mathf.Abs(player.transform.position.x - transform.position.x) > 1f)
            {
                transform.Translate(Time.deltaTime * characterInfo.Speed * transform.forward, Space.World);
                return;
            }

            playerHP.Value -= Time.deltaTime;
        }
    }
}