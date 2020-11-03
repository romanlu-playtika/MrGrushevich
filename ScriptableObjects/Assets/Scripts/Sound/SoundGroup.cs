using System.Linq;
using UnityEngine;

namespace Sound
{
    [CreateAssetMenu]
    public class SoundGroup : ScriptableObject
    {
        [SerializeField] private string id;
        [SerializeField] private SoundInfo[] sounds;

        public string ID => id;

        public string[] GetIds()
        {
            return sounds.Select(sound => sound.ID).ToArray();
        }

        public SoundInfo GetSoundInfo(string soundID)
        {
            return sounds.FirstOrDefault(sound => sound.ID == soundID);
        }
    }
}