using System;
using UnityEngine;

public class ContainerCounter : BaseCounter
{
    public event EventHandler OnPlayerGrabObject;

    [SerializeField] private KitchenObjectSO kitchenObjectSO;

    public override void Interact(Player player)
    {
        // Prevents spawning infinite kitchen objects
        if (!HasKitchenObject())
        {
            // Spawn a kitchen object
            Transform kitchenObjectTransform = Instantiate(kitchenObjectSO.prefab);
            // And give it to the player
            kitchenObjectTransform.GetComponent<KitchenObject>().SetKitchenObjectParent(player);

            OnPlayerGrabObject?.Invoke(this, EventArgs.Empty);
        }
    }
}
