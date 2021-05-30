using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class GoapAction : MonoBehaviour
{
    public bool IsGoal;
    public bool IsStart;
    [HideInInspector] public int G, H, F;// used in A* path planning. no other use
    [HideInInspector] public GoapAction Parent;// also used in path planning and no other use
    [HideInInspector] public List<string> PreconditionList;
    [HideInInspector] public List<string> EffectorList;
    public int Price;
    public System.Action OnEffectorAchieved;

    protected abstract void GeneratePreconditions();
    protected abstract void GenerateEffectors();
    public abstract void CheckEffectorAchieved();



    protected virtual void Awake()
    {
        print("Parent Awake Called");
        GeneratePreconditions();
        GenerateEffectors();
    }

    protected virtual void Update()
    {
        print("Parent Update Getting Called");
        CheckEffectorAchieved();
    }






}
