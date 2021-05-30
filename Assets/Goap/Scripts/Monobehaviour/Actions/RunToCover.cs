using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RunToCover : GoapAction
{

   
    protected override void GeneratePreconditions()
    {
        PreconditionList = new List<string>();
        PreconditionList.Add(GoapPreconditionReferences.HasWeapon);
       
    }

    protected override void GenerateEffectors()
    {
        EffectorList = new List<string>();
        EffectorList.Add(GoapPreconditionReferences.IsInCover);
    }

    public override void CheckEffectorAchieved()
    {
    }


}
