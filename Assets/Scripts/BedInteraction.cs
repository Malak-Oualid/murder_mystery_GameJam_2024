using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollidableObject : MonoBehaviour
{
    private Collider2D z_Collider;
    [SerializeField]
    private ContactFilter2D z_Filter;
    private List<Collider2D> z_CollidedObjects = new List<Collider2D>(1);

    protected virtual void Start()
    {
        // Try to get the Collider2D component from the player GameObject
        z_Collider = GetComponent<Collider2D>();

        // If z_Collider is still null, log an error
        if (z_Collider == null)
        {
            Debug.LogError("Collider2D component not found on " + gameObject.name + ". Make sure the player GameObject has a Collider2D component.");
        }
    }

    protected virtual void Update()
    {
        if (z_Collider != null)
        {
            z_Collider.OverlapCollider(z_Filter, z_CollidedObjects);
            foreach (var o in z_CollidedObjects)
            {
                // if (o != null)
                // {
                //     OnCollided(o.gameObject);
                // }
            }
        }
    }

    
}
