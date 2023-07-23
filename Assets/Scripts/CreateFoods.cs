using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class CreateFoods : MonoBehaviour
{
    public GameObject FoodObject;
    // Start is called before the first frame update
    void Start()
    {
        for (int i = 0; i < 30; i++)
        {
            GameObject copyFood = Instantiate(FoodObject);
            copyFood.transform.position = new Vector3(
                Random.Range((float)-9.5, (float)9.5),
                (float)0.5,
                    Random.Range((float)-9.5, (float)9.5)
                );
            // 在父物体里添加子物体       
            copyFood.transform.parent = transform;
        }
    }


    // Update is called once per frame
    void Update()
    {

    }
}
