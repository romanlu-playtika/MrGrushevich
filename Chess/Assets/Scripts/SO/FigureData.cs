using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum ChessType
{
    White,
    Black
}
[CreateAssetMenu(fileName = "FigureInfo", menuName = "Data/FigureData", order = 0)]
public class FigureData : ScriptableObject
{
    public string figureName;
    public Mesh figureMesh;
    public Material figureMaterial;
    public ChessType figureType = ChessType.White;
}
