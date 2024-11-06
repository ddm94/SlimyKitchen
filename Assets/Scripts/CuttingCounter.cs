using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CuttingCounter : BaseCounter
{
    [SerializeField] private KitchenObjectSO cutKitchenObjectSO;

    public override void Interact(Player player)
    {
        // There is no KitchenObject here
        if (!HasKitchenObject())
        {
            // The Player is carrying something
            if (player.HasKitchenObject())
            {
                // Player drops the KitchenObject on this counter
                player.GetKitchenObject().SetKitchenObjectParent(this);
            }
            else // Player is not carrying anything
            {

            }
        }
        else // There is a KitchenObject here
        {
            // Player is already carrying a KitchenObject
            if (player.HasKitchenObject())
            {
                // We do not want to do anything
            }
            else // Player is not carrying anything
            {
                GetKitchenObject().SetKitchenObjectParent(player);
            }
        }
    }

    public override void InteractAlternate(Player player)
    {
        // There is a KitchenObject here
        if (HasKitchenObject())
        {
            GetKitchenObject().DestroySelf();

            KitchenObject.SpawnKitchenObject(cutKitchenObjectSO, this);
        }
    }
}
