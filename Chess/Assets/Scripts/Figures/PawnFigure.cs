using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PawnFigure : BaseFigure
{

    public override void Move()
    {
        transform.position += transform.forward;
        Debug.Log($"{this} tries to move");
        base.Move();
    }
}
