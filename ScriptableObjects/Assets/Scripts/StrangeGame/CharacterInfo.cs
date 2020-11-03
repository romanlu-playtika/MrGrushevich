using UnityEngine;

namespace StrangeGame
{
    [CreateAssetMenu]
    public class CharacterInfo : ScriptableObject
    {
        [SerializeField] private FloatReference hp;
        [SerializeField] private FloatReference speed;

        public FloatReference HP => hp;
        public FloatReference Speed => speed;
    }
}