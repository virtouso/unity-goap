using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FindWeapon : GoapAction
{
   

    // Update is called once per frame
    protected override void GeneratePreconditions()
    {
        PreconditionList = new List<string>();
        PreconditionList.Add(GoapPreconditionReferences.HasNotWeapon);

    }

    protected override void GenerateEffectors()
    {
        EffectorList = new List<string>();
        EffectorList.Add(GoapPreconditionReferences.HasWeapon);
    }

    public override void CheckEffectorAchieved()
    {
    
    }

 protected  override void Update()
    {
        
    }
}
