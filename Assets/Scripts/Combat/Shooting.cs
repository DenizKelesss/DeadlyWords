using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooting : MonoBehaviour
{
    private Camera mainCam;

    public GameObject bullet;
    public Transform bulletTransform;
    public bool canFire;
    public float timer;
    public float timeBetweenFiring;


    // Start is called before the first frame update
    void Start()
    {
        mainCam = Camera.main;
    }

    // Update is called once per frame
    void Update()
    {
        // Get the mouse position in the world space
        Vector3 mouseScreenPosition = Input.mousePosition;
        mouseScreenPosition.z = Mathf.Abs(mainCam.transform.position.z - transform.position.z); // Ensure correct z distance

        Vector3 mouseWorldPosition = mainCam.ScreenToWorldPoint(mouseScreenPosition);

        // Calculate the direction from the player to the mouse position
        Vector3 direction = mouseWorldPosition - transform.position;

        // Ensure the direction vector only considers the x and y coordinates
        direction.z = 0;

        // Calculate the angle in degrees
        float angle = Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg;

        // Apply the rotation to the z axis
        transform.rotation = Quaternion.Euler(0, 0, angle);

        if(!canFire)
        {
            timer += Time.deltaTime;
            if(timer > timeBetweenFiring)
            {
                canFire = true;
                timer = 0;
            }
        }
        
        if (Input.GetMouseButtonDown(0) && canFire)
        {
            canFire= false;
            Instantiate(bullet, bulletTransform.position, Quaternion.identity);
        }
    }
}
