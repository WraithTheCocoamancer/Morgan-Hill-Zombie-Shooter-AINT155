using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class Weapon_Knife : MonoBehaviour
{
    //public GameObject SlashPrefab;
    //public Transform[] SlashSpawn;

    public Collider2D col;

    public float fireTime = 0.5f;
    private bool isFiring = false;

    public RuntimeAnimatorController anim;

    void Start()
    {
        col.enabled = false;
        transform.parent.parent.GetComponent<Animator>().runtimeAnimatorController = anim;
    }

    private void SetFiring()
    {
        isFiring = false;
        col.enabled = false;
    }
    private void Fire()
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