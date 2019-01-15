using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class WeaponBase : MonoBehaviour {

    public RuntimeAnimatorController Gunanim;

    public float fireTime = 0.5f;
    protected bool isFiring = false;
    
    protected virtual void SetFiring() { }

    protected virtual void Fire() { }

    private void Update()
    {
        if (Input.GetMouseButton(0))
        {
            if (!isFiring)
            {
                Fire();
            }
        }
    }
}
