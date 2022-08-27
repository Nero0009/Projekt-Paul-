using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GunController : MonoBehaviour
{
    ParticleSystem particles;
    public Camera cam;
    public float shotsPerSecond;
    public LayerMask mask;
    public GameObject hitParticles;
    float timeTillNextShot;
    GameObject clone;
    void Start()
    {
        particles = GetComponent<ParticleSystem>();
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetButtonDown("Fire1")){
            timeTillNextShot = 0;
        }
        if(Input.GetButton("Fire1")){
            timeTillNextShot -= Time.deltaTime;
        }


        if(timeTillNextShot <= 0){
            Shoot();
            timeTillNextShot = 1/shotsPerSecond;
        }
    }
    void Shoot(){
        if(clone != null)Destroy(clone, 0f);
        particles.Play();
        Invoke("Stop", particles.startLifetime);
        
        RaycastHit hit;
        Physics.Raycast(cam.transform.position, cam.transform.forward, out hit, 100f, mask);
        clone = Instantiate(hitParticles, hit.point, new Quaternion());
        if(hit.collider != null && hit.collider.GetComponent<DamageTaker>()!= null){
            hit.collider.GetComponent<DamageTaker>().takeDamage(1);
        }
    }
    void Stop(){
        particles.Stop();
    }
}
