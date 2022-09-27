using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Node : MonoBehaviour
{
    public bool isExplored = false;
    public Node isExploredFrom;

    public Vector2Int GetPos()
    {
        return new Vector2Int(Mathf.RoundToInt(transform.position.x / 11), 
                              Mathf.RoundToInt(transform.position.z / 11));
    }
}
