using System.Collections;
using System.Collections.Generic;
using UnityEngine;



[CreateAssetMenu(fileName = "Carte", menuName = "Scriptable/Carte")] // 
public class Earthstone : ScriptableObject
{
    public string name;
    public string Rarity;
    public int price;
    public Sprite Image;
}
