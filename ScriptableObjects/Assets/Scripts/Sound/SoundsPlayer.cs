using System;
using UnityEngine;

namespace Sound
{
    public class SoundsPlayer : MonoBehaviour
    {
        [SerializeField] private SoundConfig soundConfig;
        [SerializeField] private AudioSource audioSource;

        [SerializeField] private SoundGroupUI soundGroupUI;

        private void Start()
        {
            var groups = soundConfig.GetGroupsIDs();
            for (int i = 1; i < groups.Length; i++)
            {
                var ids = soundConfig.GetSoundsIDs(groups[i]);
                var group = Instantiate(soundGroupUI, soundGroupUI.transform.parent);
                group.Setup(groups[i], ids, PlaySound);
            }
            soundGroupUI.Setup(groups[0], soundConfig.GetSoundsIDs(groups[0]), PlaySound);
        }

        private void PlaySound(string id)
        {
            audioSource.Stop();
            var info = soundConfig.GetSoundInfo(id);
            if (info == null)
            {
                return;
            }

            audioSource.clip = info.Clip;
            audioSource.loop = info.Loop;
            audioSource.pitch = info.Pitch;
            audioSource.volume = info.Volume;
            
            audioSource.Play();
        }
    }
}