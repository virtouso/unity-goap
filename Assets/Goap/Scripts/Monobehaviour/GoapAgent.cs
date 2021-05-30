using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.AI;

public class GoapAgent : MonoBehaviour
{
    private List<GoapAction> _goapActions;
    private GoapMemory _goapMemory;
    [SerializeField] private NavMeshAgent _agent;

    private List<GoapAction> _selectedChain;
    private GoapAction _currentAction;
    private int _currentActionIndex;




    private void UpdatePlan()
    {
        _selectedChain = Planner.Plan(_goapActions.First(x => x.IsStart), _goapActions.First(x => x.IsGoal), _goapActions);
        print(Planner.LogPlan(_selectedChain));
    }







    private void Awake()
    {
        _goapMemory = GetComponent<GoapMemory>();
        _goapActions = GetComponents<GoapAction>().ToList();
    }

    private void Start()
    {
        UpdatePlan();
    }



}
