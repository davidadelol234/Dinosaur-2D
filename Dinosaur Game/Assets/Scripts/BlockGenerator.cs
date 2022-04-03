using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlockGenerator : MonoBehaviour
{
    public GameObject block;

    public float MinSpeed;
    public float MaxSpeed;
    public float currentSpeed;

    public float SpeedMultiplier;
    // Start is called before the first frame update
    void Awake()
    {
        currentSpeed = MinSpeed;
        generateBlock();
    }

    public void GeneratNextBlock()
    {
        float randomWait = Random.Range(0.1f, 1.2f);
        Invoke("generateBlock", randomWait);
    }

    public void generateBlock()
    {
        GameObject BlockIns = Instantiate(block, transform.position, transform.rotation);

        BlockIns.GetComponent<BlockScript>().blockGenerator = this;
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
