using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RunToEnemy : GoapAction
{


    protected override void GeneratePreconditions()
    {
        PreconditionList = new List<string>();
        PreconditionList.Add(GoapPreconditionReferences.HasMelee);
    }

    protected override void GenerateEffectors()
    {
        EffectorList = new List<string>();
        EffectorList.Add(GoapPreconditionReferences.EnemyIsMeleed);
    }

    public override void CheckEffectorAchieved()
    {
    }


}
