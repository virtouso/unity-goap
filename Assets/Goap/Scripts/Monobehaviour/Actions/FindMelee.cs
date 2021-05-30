using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FindMelee : GoapAction
{
 
    protected override void GeneratePreconditions()
    {
        PreconditionList = new List<string>();
        PreconditionList.Add(GoapPreconditionReferences.HasNotMelee);
    }

    protected override void GenerateEffectors()
    {
        EffectorList = new List<string>();
        EffectorList.Add(GoapPreconditionReferences.HasMelee);
    }

    public override void CheckEffectorAchieved()
    {
       
    }

    protected override void Update()
    {

    }
}
