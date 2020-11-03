using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QueenFigure : BaseFigure
{
    public override void Move()
    {
        Debug.Log($"{this} tries to move");
        base.Move();
    }
}
