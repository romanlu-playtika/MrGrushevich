using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KnightFigure : BaseFigure
{
    public override void Move()
    {
        Debug.Log($"{this} tries to move");
        base.Move();
    }
}
