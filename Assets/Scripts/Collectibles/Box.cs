using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Box : MonoBehaviour, ICollectible
{
    public void CollectItem()
    {
        CollectibleManager.Instance.CollectBox();
    }
}
