using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class Weapon_Knife : WeaponBase
{
    //public GameObject SlashPrefab;
    //public Transform[] SlashSpawn;

    public Collider2D col;
    

    void Start()
    {
        col.enabled = false;
        transform.parent.parent.GetComponent<Animator>().runtimeAnimatorController = Gunanim;
    }

    protected override void SetFiring()
    {
        isFiring = false;
        col.enabled = false;
    }
    protected override void Fire()
    {
        isFiring = true;

        col.enabled = true;

        //for (int i = 0; i < SlashSpawn.Length; i++)
        //{
        //    Instantiate(SlashPrefab, SlashSpawn[i].position, SlashSpawn[i].rotation);
        //}
        //if (GetComponent<AudioSource>() != null)
        //{
        //    GetComponent<AudioSource>().Play();
        //}
        Invoke("SetFiring", fireTime);
    }
   
}