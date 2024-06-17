using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spike : MonoBehaviour, ICollectible
{
    public void CollectItem()
    {
        CollectibleManager.Instance.CollectSpike();
    }
}
