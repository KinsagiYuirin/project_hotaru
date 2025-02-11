using UnityEngine;

public class getFirefly : Interact
{
    public ParticleSystem fireflyParticle;
    private bool firefly1;
    public bool Firefly1 => firefly1;

    void Update()
    {
        if (CanInteract && Input.GetKeyDown(KeyCode.E))
        {
            CollectFirefly();
        }
    }

    void CollectFirefly()
    {
        fireflyParticle.gameObject.SetActive(false); // หยุด Particle
        firefly1 = true;
        Debug.Log("Collected a firefly!");
    }
}