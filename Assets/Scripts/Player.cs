using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        ICollectible collectible = other.GetComponent<ICollectible>();

        if (collectible != null)
        {
            collectible.CollectItem();
            Destroy(other.gameObject);
        }
    }
}
