using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "ChessData", menuName = "Data/ChessData", order = 0)]
public class ChessData : ScriptableObject
{
    [SerializeField] private List<BaseFigure> whiteFigures = new List<BaseFigure>();
    [SerializeField] private List<BaseFigure> blackFigures = new List<BaseFigure>();
    
    [SerializeField] private ChessPositionsData blackPosition;
    [SerializeField] private ChessPositionsData whitePosition;
    
    public List<BaseFigure> WhiteFigures => whiteFigures;
    public List<BaseFigure> BlackFigures => blackFigures;
    public ChessPositionsData BlackPosition => blackPosition;
    public ChessPositionsData WhitePosition => whitePosition;
}
