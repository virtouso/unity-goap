using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class GoapAction : MonoBehaviour
{

    public List<string> PreconditionList;
    public List<string> EffectorList;
    public int Price;


    protected abstract void GeneratePreconditions();
    protected abstract bool GenerateEffectors();
    protected abstract bool CheckEffectorAchieved();



    protected virtual void Awake()
    {
        print("Parent Awake Called");
    }

    protected virtual void Update()
    {
        print("Parent Update Getting Called");
    }






}
