using System;
using UnityEngine;

namespace StrangeGame
{
    [CreateAssetMenu]
    public class FloatVariable : ScriptableObject, ISerializationCallbackReceiver
    {
        public event Action<float> OnValueChanged;
        [SerializeField] private float initialValue;
        private float value;

        public float Value
        {
            get => value;
            set
            {
                this.value = value;
                OnValueChanged?.Invoke(value);
            }
        }
        public float InitialValue => initialValue;

        public void OnBeforeSerialize()
        {
        }

        public void OnAfterDeserialize()
        {
            value = initialValue;
        }
    }
}