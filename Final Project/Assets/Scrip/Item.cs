using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Item : MonoBehaviour
{
    public SpriteRenderer ItemShield;
    public CircleCollider2D ItemShieldColl;
    public SpriteRenderer Shield;
    public BoxCollider2D ShieldColl;

    public PlayerDash Dashs;
    public SpriteRenderer ItemDash;
    public CircleCollider2D ItemDashColl;
    public PlayerControl BaseControl;

    public float LimitItem;

    private void OnCollisionEnter2D(Collision2D collisionInfo)
    {
        if (collisionInfo.collider.tag == "Dash")
        {
            LimitItem = 1;
            Dashss();
        }

        if (collisionInfo.collider.tag == "Item")
        {
            LimitItem = 1;
            Count();
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        ItemTime();
    }

    public void ItemTime()
    {
        if (LimitItem >= 1)
        {
            LimitItem += Time.deltaTime * 1;
            if (LimitItem >= 6)
            {
                LimitItem = 0;
                Shield.enabled = false;
                ShieldColl.enabled = false;
                Dashs.enabled = false;
                BaseControl.enabled = true;
            }
        }
    }

    public void Dashss()
    {
        Dashs.enabled = true;
        ItemDash.enabled = false;
        ItemDashColl.enabled = false;
        BaseControl.enabled = false;
    }

    public void Count()
    {
        ItemShield.enabled = false;
        Shield.enabled = true;
        ShieldColl.enabled = true;
        ItemShieldColl.enabled = false;
    }
}
