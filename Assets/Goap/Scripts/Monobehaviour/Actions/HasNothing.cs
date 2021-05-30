using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HasNothing : GoapAction
{
    protected override void GeneratePreconditions()
    {
        PreconditionList = new List<string>();

    }

    protected override void GenerateEffectors()
    {
        EffectorList = new List<string>();
        EffectorList.Add(GoapPreconditionReferences.HasNotMelee);
        EffectorList.Add(GoapPreconditionReferences.HasNotWeapon);

    }

    public override void CheckEffectorAchieved()
    {
    }
}
