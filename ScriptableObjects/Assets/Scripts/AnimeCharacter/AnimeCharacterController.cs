
using System;
using System.Collections;
using System.Collections.Generic;
using AnimeCharacter;
using UnityEditor;
using UnityEngine;

public class AnimeCharacterController : MonoBehaviour
{
    [SerializeField] private AnimeCharacterData data;

    [SerializeField] private Transform[] legs;
    [SerializeField] private Transform[] knees;
    [SerializeField] private Transform chest;
    [SerializeField] private Transform neck;
    [SerializeField] private Transform[] breasts;

    private void Start()
    {
        UpdateCharacter();
    }
#if UNITY_EDITOR
    private void Update()
    {
        if (Selection.activeObject != gameObject)
        {
            return;
        }
            UpdateCharacter();
    }

#endif
    private void UpdateCharacter()
    {
        foreach (var t in legs)
        {
            t.localScale = data.GetLegSize(t.localScale);
        }
        foreach (var t in knees)
        {
            t.localScale = data.GetKneeSize(t.localScale);
        }

        chest.localScale = data.ChestSize;
        neck.localScale = data.NeckSize;
        foreach (var t in breasts)
        {
            t.localScale = data.BreastSize;
        }
    }
}
