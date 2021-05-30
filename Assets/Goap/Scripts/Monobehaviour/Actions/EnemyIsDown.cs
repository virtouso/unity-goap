using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyIsDown : GoapAction
{
    protected override void GeneratePreconditions()
    {
        PreconditionList = new List<string>();
        PreconditionList.Add(GoapPreconditionReferences.EnemyIsShot);
        PreconditionList.Add(GoapPreconditionReferences.EnemyIsMeleed);
    }

    protected override void GenerateEffectors()
    {
        EffectorList = new List<string>();
    }

    public override void CheckEffectorAchieved()
    {
      
    }


   
}
