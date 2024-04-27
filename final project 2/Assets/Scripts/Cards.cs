using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "Card/New card", fileName = "New card", order = 51)]
public class Cards : ScriptableObject
{
    public Sprite icon;
    public GameObject prefab;
    public int cost;
}
