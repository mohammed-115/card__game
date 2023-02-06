using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Data", menuName = "ScriptableObjects/Cards Dick", order = 1)]
public class CardsDeck : ScriptableObject
{

    public GameObject[] cardsDeck = new GameObject[52];
    
}
