using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SwordsUIPreview : MonoBehaviour
{
    [SerializeField] private SwordData swordData;
    
    [SerializeField] private Transform rootPoint;
    [SerializeField] private Text nameLabel;
    [SerializeField] private Text descriptionLabel;
    [SerializeField] private Image iconImage;
    [SerializeField] private Text costLabel;
    [SerializeField] private Text damageLabel;

    private GameObject swordObject;
    
    void Start()
    {
        SetupData();
    }
    
    void Update()
    {
        rootPoint.Rotate(Time.deltaTime * swordData.RotationSpeed * Vector3.up, Space.World);
    }

    public void SetupData()
    {
        if (swordObject != null)
        {
            Destroy(swordObject);
        }
        Instantiate(swordData.Prefab, rootPoint);
        nameLabel.text = swordData.SwordName;
        descriptionLabel.text = swordData.Description;
        iconImage.sprite = swordData.Icon;
        costLabel.text = $"Cost: {swordData.Cost}";
        damageLabel.text = $"Cost: {swordData.Damage}";
    }
}
