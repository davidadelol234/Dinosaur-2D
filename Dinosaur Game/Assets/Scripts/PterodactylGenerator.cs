using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PterodactylGenerator : MonoBehaviour
{
    public GameObject pterodactyl;

    public float MinSpeed;
    public float MaxSpeed;
    public float currentSpeed;

    public float SpeedMultiplier;
    // Start is called before the first frame update
    void Awake()
    {
        currentSpeed = MinSpeed;
        generatePterodactyl();
    }

    public void GenerateNextPterodactyl()
    {
        float randomWait = Random.Range(0.1f, 1.2f);
        Invoke("generatePterodactyl", randomWait);
    }

    public void generatePterodactyl()
    {
        GameObject PterodactylIns = Instantiate(pterodactyl, transform.position, transform.rotation);

        PterodactylIns.GetComponent<Pterodactylscript>().pterodactylGenerator = this;
    }

    // Update is called once per frame
    void Update()
    {
        if(currentSpeed < MaxSpeed)
        {
            currentSpeed += SpeedMultiplier;
        }
    }
}
