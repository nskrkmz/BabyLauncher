using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BabyFire : MonoBehaviour
{

    public LevelInfo1 levelInformations;
    public GameObject baby;

    //Level Informations
    [SerializeField] int numberOfBaby;
    private float flyTime;

    [Header("Player")]
    public GameObject[] babies;

    private float deltaTime;
    private float fps;
    public bool isAlive;
    public int shoutCount;
    private bool fireControll;

    private void Awake()
    {
        levelInformations = FindObjectOfType<LevelInfo1>();
        AllInitial();
    }

    void Start()
    {
        Debug.Log("BabyFire.cs");
        shoutCount = 0;
        BabyInstantiate(numberOfBaby);
    }

    private void Update()
    {
        fireControll = FindObjectOfType<FireControl>().fire;
        fps = GetFPS();
        
        if (fireControll)
        {
            Fire();
        }
        if (shoutCount < numberOfBaby)
        {
            BabyMovement(babies[shoutCount]);
        }
    }
    private void AllInitial()
    {
        
        numberOfBaby = levelInformations.NumberOfBaby;
        flyTime= levelInformations.FlyTime;
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
            currentPosition.z += 3.74f / (flyTime * 140); // way/(totalTime*fps)
            currentBaby.GetComponent<Transform>().position = currentPosition;

            if(currentPosition.z >= 0.70f)
            {
                isAlive = false;
                shoutCount++;
            }
        }
        
    }

    
}
