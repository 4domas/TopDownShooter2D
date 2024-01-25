using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Weapon : MonoBehaviour
{

    public float offset;

    public GameObject projecile;
    public Transform shotPoint;

    private float timeBtwnShots;
    public float startTimeBtwShots;

    private void Update()
    {
        Vector3 diffrence = Camera.main.ScreenToWorldPoint(Input.mousePosition) - transform.position;
        float rotZ = Mathf.Atan2(diffrence.y, diffrence.x) * Mathf.Rad2Deg;
        transform.rotation = Quaternion.Euler(0f, 0f, rotZ + offset);

        if(timeBtwnShots <= 0f)
        {
            if(Input.GetMouseButtonDown(0))
            {
            Instantiate(projecile, shotPoint.position, transform.rotation);
                timeBtwnShots = startTimeBtwShots;
            }
        }
        else
        {
            timeBtwnShots -= Time.deltaTime;
        }


    }
}
