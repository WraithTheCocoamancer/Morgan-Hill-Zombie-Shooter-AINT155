using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class Weapon : MonoBehaviour 
{
    public RuntimeAnimatorController Gunanim; 
    public GameObject bulletPrefab;
    public Transform[] BulletSpawn;
    public float fireTime = 0.5f;
    private bool isFiring = false;
    private void SetFiring()
    {
        isFiring = false;
        transform.parent.parent.GetComponent<Animator>().runtimeAnimatorController = Gunanim;
    }
    private void Fire()
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
