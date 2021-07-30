using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BabyFire : MonoBehaviour
{
    public GameObject baby;
    [SerializeField] int numberOfBaby = 10;

    //initialize
    public GameObject[] babies;
    public float deltaTime;
    public float fps;
    public bool isAlive;
    public int shoutCount;

    void Start()
    {
        shoutCount = 0;
        BabyInstantiate(numberOfBaby);
    }

    private void Update()
    {
        fps = GetFPS();
        
        if (((int)(Time.unscaledTime)) % 5 == 0 && Time.unscaledTime%5 < 0.1 && Time.unscaledTime>4)
        {
            Debug.Log(Time.time);
            Fire();
        }
        if (shoutCount < numberOfBaby)
        {
            BabyMovement(babies[shoutCount]);
        }
    }

    private float GetFPS()
    {
        deltaTime += (Time.deltaTime - deltaTime) * 1.0f;
        float fps = 1.0f / deltaTime;
        return fps;
    }

    private void BabyInstantiate(int numberOfBaby)
    {

        babies = new GameObject[numberOfBaby];
        babies[0] = baby;
        Quaternion quaternion = baby.GetComponent<Transform>().rotation;
        Vector3 positionBaby = baby.GetComponent<Transform>().position;

        for (int i=0; i<numberOfBaby-1; i++)
        {
            
            babies[i+1] = Instantiate(baby, positionBaby, quaternion);
        }
    }

    private void Fire()
    {
        isAlive = true;
    }

    private void BabyMovement(GameObject currentBaby)
    {
        Vector3 currentPosition= currentBaby.GetComponent<Transform>().position;
        if (isAlive == true)
        {
            currentPosition.z += 3.74f / (4 * fps); // way/(totalTime*fps)
            currentBaby.GetComponent<Transform>().position = currentPosition;

            if(currentPosition.z >= 0.70f)
            {
                isAlive = false;
                shoutCount++;
            }
        }
        
    }

    
}
