using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Medkit : MonoBehaviour, ICollectible
{
    public void CollectItem()
    {
        CollectibleManager.Instance.CollectMedkit();
    }
}
