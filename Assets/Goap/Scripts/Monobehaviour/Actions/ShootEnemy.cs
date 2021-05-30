using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShootEnemy : GoapAction
{



    protected override void GeneratePreconditions()
    {
        PreconditionList = new List<string>();
        PreconditionList.Add(GoapPreconditionReferences.HasWeapon);
    }

    protected override void GenerateEffectors()
    {
        EffectorList = new List<string>();
        EffectorList.Add(GoapPreconditionReferences.EnemyIsShot);
    }

    public override void CheckEffectorAchieved()
    {
    }


}
