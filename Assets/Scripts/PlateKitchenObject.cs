using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlateKitchenObject : KitchenObject
{
    [SerializeField] private List<KitchenObjectSO> validKitchenObjectSOList;
    private List<KitchenObjectSO> kitchenObjectSOList;

    private void Awake()
    {
        kitchenObjectSOList = new List<KitchenObjectSO>();
    }

    public bool TryAddIngredient(KitchenObjectSO kitchenObjectSO)
    {
        // Not a valid ingredient
        if (!validKitchenObjectSOList.Contains(kitchenObjectSO))
        {
            // Do not add any ingredient
            return false;
        }

        // Already has this type
        if (kitchenObjectSOList.Contains(kitchenObjectSO)) return false;
        else // Brand new ingredient
        {
            kitchenObjectSOList.Add(kitchenObjectSO);

            return true;
        }
    }
}