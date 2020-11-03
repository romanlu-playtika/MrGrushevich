using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "PositionsData", menuName = "Data/ChessPosition", order = 0)]
public class ChessPositionsData : ScriptableObject
{
    [SerializeField] private List<Vector3> positions = new List<Vector3>();

    public List<Vector3> Positions => positions;
}
