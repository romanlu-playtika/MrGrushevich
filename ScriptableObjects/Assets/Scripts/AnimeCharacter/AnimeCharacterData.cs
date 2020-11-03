using UnityEngine;

namespace AnimeCharacter
{
    [CreateAssetMenu(fileName = "AnimeCharacter", menuName = "Anime/Character", order = 0)]
    public class AnimeCharacterData : ScriptableObject
    {
        [SerializeField] [Range(0.75f, 1.25f)] private float legSize = 1f;
        [SerializeField] [Range(0.75f, 1.4f)] private float kneeSize = 1f;
        [SerializeField] [Range(0.9f, 1.1f)] private float chestSize = 1f;
        [SerializeField] [Range(0.8f, 1.4f)] private float neckSize = 1f;
        [SerializeField] [Range(0.75f, 1.3f)] private float breastSize = 1f;

        public Vector3 GetLegSize(Vector3 size)
        {
            return new Vector3(legSize, size.y, legSize);
        }
        public Vector3 GetKneeSize(Vector3 size)
        {
            return new Vector3(kneeSize, size.y, kneeSize);
        }
        public Vector3 ChestSize => new Vector3(chestSize, chestSize, chestSize);
        public Vector3 NeckSize => new Vector3(neckSize, neckSize, neckSize);
        public Vector3 BreastSize => new Vector3(breastSize, breastSize, breastSize);
    }
}