using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShootCones : MonoBehaviour
{
    [SerializeField] private GameObject conePrefab;
    [SerializeField] private GameObject towerRotateableHead;
    [SerializeField] private Transform[] muzzles;
    [SerializeField] private int startForce;
    [SerializeField] private float cooldown;

    [SerializeField] private GameObject enemy;

    private float timer = 0.0f;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;
        if (timer >= this.cooldown)
        {
            Vector3 direction = Vector3.Normalize(this.enemy.transform.position - this.transform.position);
            float angleSwitch = Vector3.Dot(this.gameObject.transform.forward, direction);
            Debug.Log(angleSwitch);

            bool enemyInRange = angleSwitch >= 0;

            if (enemyInRange)
            {
                this.towerRotateableHead.transform.LookAt(this.enemy.transform, Vector3.up);

                if (Input.GetKeyDown(KeyCode.Space))
                {
                    foreach (var muzzle in this.muzzles)
                    {
                        var rocket = GameObject.Instantiate(conePrefab, muzzle.position, Quaternion.identity);
                        rocket.transform.LookAt(this.enemy.transform);
                        rocket.GetComponent<Rigidbody>().AddForce(rocket.transform.forward * startForce, ForceMode.VelocityChange);
                    }
                    timer = 0;
                }
            }

        }
    }
}
