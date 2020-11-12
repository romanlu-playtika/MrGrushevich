using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;
using UnityEngine.UI;

public class CharacterSelect : MonoBehaviour
{
    [SerializeField] private Transform playerRoot;
    private GameObject player;
    private List <Texture2D> maleHairTextures = new List<Texture2D>();
    private List <Texture2D> femaleHairTextures = new List<Texture2D>();
    private List <Texture2D> maleClothesTextures = new List<Texture2D>();
    private List <Texture2D> femaleClothesTextures = new List<Texture2D>();

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

    public void ChangeTexture()
    {
        var directoryInfo = new DirectoryInfo(Application.streamingAssetsPath);

        var allFiles = directoryInfo.GetFiles("*.*");
        foreach (var fileInfo in allFiles)
        {
            if (fileInfo.Name.Contains("meta"))
            {
                continue;
            }
            var bytes = File.ReadAllBytes(fileInfo.FullName);
            var texture2d = new Texture2D(1, 1);
            texture2d.LoadImage(bytes);
            if (fileInfo.Name.Contains("Female"))
            {
                if (fileInfo.Name.Contains("Hair"))
                {
                    femaleHairTextures.Add(texture2d);
                }
                else if (fileInfo.Name.Contains("Torso"))
                {
                    femaleClothesTextures.Add(texture2d);
                }
            }
            else if (fileInfo.Name.Contains("Male"))
            {
                if (fileInfo.Name.Contains("Hair"))
                {
                    maleHairTextures.Add(texture2d);
                }
                else if (fileInfo.Name.Contains("Torso"))
                {
                    maleClothesTextures.Add(texture2d);
                }
            }
        }
    }
}