using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Tilemaps;


[CreateAssetMenu(menuName = "Scriptable Object/Item")]
public class Item : ScriptableObject
{
    

    [Header("Only gameplay")]
    public TileBase Tile;
    public ItemType Type;
    public ActionType ActionType;
    public Vector2Int range = new Vector2Int(5, 4);

    [Header("Only UI")]
    public bool Stackable = true;

    [Header("Both")]
    public Sprite Image;
}

public enum ItemType
{

}
public enum ActionType
{

}
