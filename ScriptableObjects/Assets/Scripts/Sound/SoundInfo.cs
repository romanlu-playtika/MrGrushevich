using UnityEngine;

namespace Sound
{
    [CreateAssetMenu]
    public class SoundInfo : ScriptableObject
    {
        [SerializeField] private string id;
        [SerializeField] private AudioClip clip;
        [SerializeField] private bool loop;
        [SerializeField] [Range(0f, 1f)] private float volume = 1;
        [SerializeField] [Range(0f, 1f)] private float pitch = 1;
        
        public string ID => id;
        public AudioClip Clip => clip;
        public bool Loop => loop;
        public float Volume => volume;
        public float Pitch => pitch;
    }
}