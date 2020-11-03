using System.Linq;
using UnityEngine;

namespace Sound
{
    [CreateAssetMenu]
    public class SoundConfig : ScriptableObject
    {
        [SerializeField] private SoundGroup[] groups;

        public string[] GetGroupsIDs()
        {
            return groups.Select(soundGroup => soundGroup.ID).ToArray();
        }

        public string[] GetSoundsIDs(string groupID)
        {
            var soundGroup = groups.FirstOrDefault(group => group.ID == groupID);
            return soundGroup == null ? null : soundGroup.GetIds();
        }

        public SoundInfo GetSoundInfo(string id)
        {
            foreach (var soundGroup in groups)
            {
                var sound = soundGroup.GetSoundInfo(id);
                if (sound != null)
                {
                    return sound;
                }
            }

            return null;
        }
    }
}