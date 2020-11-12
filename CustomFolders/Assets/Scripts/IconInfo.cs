﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu]
public class IconInfo : ScriptableObject
{
    [SerializeField] private string iconName;
    [SerializeField] private string prefabName;

    public string IconName => iconName;
    public string PrefabName => prefabName;
}
