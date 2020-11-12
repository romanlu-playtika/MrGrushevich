using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;
using UnityEngine.UI;

public class CharacterSelect : MonoBehaviour
{
    [SerializeField] private Button maleButton;
    [SerializeField] private Button femaleButton;
    [SerializeField] private Transform playerRoot;
    private GameObject player;

    public void AddCharacter(string sex)
    {
        var prefab = Resources.Load<GameObject>($"Prefabs/{sex}");
        if (player != null)
        {
            Destroy(player);
        }
        player = Instantiate(prefab, playerRoot);
        var rot = new Vector3(0, -180, 0);
        player.transform.rotation = Quaternion.Euler(rot);
    }

    public void ChangeTexture(string item)
    {
        var directoryInfo = new DirectoryInfo(Application.streamingAssetsPath);
        var directoryPath = Path.Combine(directoryInfo.ToString(), "Images");
        
    }
}