using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GoapAgent : MonoBehaviour
{
    [SerializeField] private List<GoapAction> _goapActions;
    [SerializeField] private GoapMemory _goapMemory;


    private List<GoapAction> _selectedChain;
    private GoapAction _currentAction;


}
