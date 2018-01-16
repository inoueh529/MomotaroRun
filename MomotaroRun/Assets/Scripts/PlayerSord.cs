using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerSord : MonoBehaviour
{
    /// <summary>
    /// 
    /// </summary>
    private OrgaFactory orgaFactory;

    /// <summary>
    /// 
    /// </summary>
    void Start()
    {
        this.orgaFactory = OrgaFactory.instance;
    }

    /// <summary>
    /// 
    /// </summary>
    /// <param name="collision"></param>
    private void OnCollisionEnter(Collision collision)
    {
        var orga = this.orgaFactory.create(collision);

        if (orga != null) OrgaHit(orga);
    }

    /// <summary>
    /// 
    /// </summary>
    /// <param name="orga"></param>
    private void OrgaHit(BaseOrga orga)
    {
        if (!orga.hit)
        {
            orga.Hit();
            orga.HitAway();
        }
    }

    /// <summary>
    /// 
    /// </summary>
    void Update()
    {

    }
}
