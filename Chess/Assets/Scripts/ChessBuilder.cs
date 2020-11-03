
using System.Collections.Generic;
using UnityEngine;

public class ChessBuilder : MonoBehaviour
{
    [SerializeField] private ChessData chessData;

    private void Awake()
    {
        BuildFigures("WhiteRoot", chessData.WhiteFigures, chessData.WhitePosition, true);
        BuildFigures("BlackRoot", chessData.BlackFigures, chessData.BlackPosition);
    }

    private void BuildFigures(string rootName, List<BaseFigure> baseFigures, ChessPositionsData positionsData, bool oppositeRotation = false)
    {
        var root = new GameObject(rootName);
        for (int i = 0; i < baseFigures.Count; i++)
        {
            var figure = Instantiate(baseFigures[i], root.transform);
            figure.transform.position = positionsData.Positions[i];
            figure.transform.rotation = oppositeRotation
                ? Quaternion.Euler(0, 180, 0)
                : Quaternion.identity; 
            if (figure)
            {
                figure.Initialize();
            }
        }
    }
}
