using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public int startHp;
    int hp;
    public float bulletCooldown;
    float bulletTimer;
    public float parryEffect;
    float parryTimer;
    public float parryCooldown;
    float parryCooldownTimer;
    public GameObject barrier;
    public int speed;

    void Start()
    {
        hp = startHp;
        parryTimer = 0;
        parryCooldownTimer = 0;
    }

    void Update()
    {    
        if(hp == 0)
        {
            Destroy(gameObject, 0);
        }
        if(Input.GetMouseButtonDown(0))
        {
            parryTimer = parryEffect;
            Destroy(Instantiate(barrier, transform.position, transform.localRotation), parryEffect);
            Debug.Log("Pressed primary button.");
        }
        
        bulletTimer -= Time.deltaTime;
        parryTimer -= Time.deltaTime;
        parryCooldownTimer -= Time.deltaTime;
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Bullet" && bulletTimer <= 0)
        {
            if (parryTimer > 0)
            {
                if (hp < startHp)
                    hp += 1;
                bulletTimer = bulletCooldown;
            }
            else
            {
                hp -= 1;
                print(hp);
                bulletTimer = bulletCooldown;
            }
        } 

    }
}
