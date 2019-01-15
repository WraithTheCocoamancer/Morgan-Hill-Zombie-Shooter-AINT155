using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class Weapon : WeaponBase
{
   
    public GameObject bulletPrefab;
    public Transform[] BulletSpawn;

    private void SpriteChange()
    {
        
    }

    protected override void SetFiring()
    {
        isFiring = false;
    }

    protected override void Fire()
    {
        isFiring = true;
        for (int i = 0; i < BulletSpawn.Length; i++)
        {
            Instantiate(bulletPrefab, BulletSpawn[i].position, BulletSpawn[i].rotation);
        }
        if (GetComponent<AudioSource>() != null)
        {
            GetComponent<AudioSource>().Play();
        }
        Invoke("SetFiring", fireTime);
    }

}
