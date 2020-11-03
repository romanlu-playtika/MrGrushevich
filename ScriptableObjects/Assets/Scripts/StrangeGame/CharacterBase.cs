using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace StrangeGame
{
    public abstract class CharacterBase : MonoBehaviour
    {
        [SerializeField] protected CharacterInfo characterInfo;
        [SerializeField] private Image healthImage;

        protected float maxHP;

        private void OnEnable()
        {
            maxHP = characterInfo.HP;
            OnHPChanged(maxHP);
            characterInfo.HP.Variable.OnValueChanged += OnHPChanged;
        }

        private void OnDisable()
        {
            characterInfo.HP.Variable.OnValueChanged -= OnHPChanged;
        }

        private void OnHPChanged(float hp)
        {
            healthImage.fillAmount = hp / maxHP;
        }
    }
}

