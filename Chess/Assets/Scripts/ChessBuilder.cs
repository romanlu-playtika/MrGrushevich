
using UnityEngine;

public class ChessBuilder : MonoBehaviour
{
    [SerializeField] private ChessData chessData;

    private void Awake()
    {
        var whiteRoot = new GameObject("WhiteRoot");
        var blackRoot = new GameObject("BlackRoot");
        for (int i = 0; i < chessData.WhiteFigures.Count; i++)
        {
            var figure = Instantiate(chessData.WhiteFigures[i], whiteRoot.transform);
            figure.transform.position = chessData.WhitePosition.Positions[i];
            if (figure)
            {
                figure.Initialize();
            }
        }
        for (int i = 0; i < chessData.BlackFigures.Count; i++)
        {
            var figure = Instantiate(chessData.BlackFigures[i], blackRoot.transform);
            figure.transform.position = chessData.BlackPosition.Positions[i];
            if (figure)
            {
                figure.Initialize();
            }
        }
    }
}
