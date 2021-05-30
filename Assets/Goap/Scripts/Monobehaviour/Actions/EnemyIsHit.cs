using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyIsHit : GoapAction
{

    protected override void GeneratePreconditions()
    {
        PreconditionList = new List<string>();
        PreconditionList.Add(GoapActionReferences.MeleeEnemy);
        PreconditionList.Add(GoapActionReferences.ShootEnemy);
    }

    protected override void GenerateEffectors()
    {
        EffectorList = new List<string>();
    }

    public override void CheckEffectorAchieved()
    {
     
    }

  
}
