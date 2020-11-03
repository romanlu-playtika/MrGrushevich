using System;
using UnityEngine;
using UnityEngine.UI;

namespace Sound
{
    public class SoundGroupUI : MonoBehaviour
    {
        [SerializeField] private SoundButton soundButton;
        [SerializeField] private Text header;

        public void Setup(string id, string[] sounds, Action<string> callback)
        {
            header.text = id;
            soundButton.Setup(sounds[0], callback);
            for (int i = 1; i < sounds.Length; i++)
            {
                var btn = Instantiate(soundButton, soundButton.transform.parent);
                btn.Setup(sounds[i], callback);
            }
        }
    }
}