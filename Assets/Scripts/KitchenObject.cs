using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KitchenObject : MonoBehaviour
{
    [SerializeField] private KitchenObjectSO kitchenObjectSO;

    private ClearCounter clearCounter;

    public KitchenObjectSO GetKitchenObjectSO() { return kitchenObjectSO; }

    public void SetClearCounter(ClearCounter clearCounter)
    {
        // Clear previous parent
        if (this.clearCounter != null)
        {
            this.clearCounter.ClearKitchenObject();
        }

        // Assign new parent
        this.clearCounter = clearCounter;

        if (clearCounter.HasKitchenObject())
        {
            Debug.LogError("Counter already has a KitchenObject");
        }

        // Set kitchen object to new parent
        clearCounter.SetKitchenObject(this);

        // Set position to the new clear counter follow point
        transform.parent = clearCounter.GetKitchenObjectFollowTransform();
        transform.localPosition = Vector3.zero;
    }

    public ClearCounter GetClearCounter() { return clearCounter; }
}
