using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Shooting : MonoBehaviour
{
    public Transform fireTransform;
    public Transform fireTransform2;
    public GameObject pringels;
    public GameObject paper;
    public GameObject cat;
    public audioManager audioManager;
    public float bulletForce = 5f;
    public float fireRate = 2f;
    private float nextTimeToShoot = 0;

    [HideInInspector]
    public bool isCatInAmmo = false;
    [HideInInspector]
    public bool isPaperInAmmo = false;

    void Update()
    {
        if (Input.GetMouseButton(0) && Time.time > nextTimeToShoot)
        {
            Bullet();
            nextTimeToShoot = Time.time + 1f / fireRate;
        }
            
    }
    private void Bullet()
    {
        if(isPaperInAmmo)
        {
            audioManager.PlaySound("pringSound");
            GameObject bullet = Instantiate(paper, fireTransform.position, fireTransform.rotation);
            Rigidbody2D rb = bullet.GetComponent<Rigidbody2D>();
            rb.AddForce(fireTransform.up * bulletForce, ForceMode2D.Impulse);
            bullet.GetComponent<DestroyPaper>().enabled = true;
            isPaperInAmmo = false;
            Destroy(bullet, 1f);
        }
        else if (isCatInAmmo)
        {
            audioManager.PlaySound("cat");
            GameObject bullet = Instantiate(cat, fireTransform.position, fireTransform2.rotation);
            Rigidbody2D rb = bullet.GetComponent<Rigidbody2D>();
            rb.AddForce(fireTransform.up * bulletForce, ForceMode2D.Impulse);
            isCatInAmmo = false;
            Destroy(bullet, 1f);
        }
        else
        {
            audioManager.PlaySound("pringSound");
            GameObject bullet = Instantiate(pringels, fireTransform.position, fireTransform.rotation);
            Rigidbody2D rb = bullet.GetComponent<Rigidbody2D>();
            rb.AddForce(fireTransform.up * bulletForce, ForceMode2D.Impulse);
        }
        
    }
}
