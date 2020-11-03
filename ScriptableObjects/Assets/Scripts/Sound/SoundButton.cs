using System;
using UnityEngine;
using UnityEngine.UI;

namespace Sound
{
    public class SoundButton : MonoBehaviour
    {
        [SerializeField] private Button button;
        [SerializeField] private Text buttonText;

        private string id;
        private Action<string> onPlaySoundCallback;

        public void Setup(string soundID, Action<string> callback)
        {
            buttonText.text = soundID;
            id = soundID;
            onPlaySoundCallback = callback;
        }

        private void OnEnable()
        {
            button.onClick.AddListener(OnSoundButtonClicked);
        }

        private void OnDisable()
        {
            button.onClick.RemoveListener(OnSoundButtonClicked);
        }

        private void OnSoundButtonClicked()
        {
            onPlaySoundCallback?.Invoke(id);
        }
    }
}