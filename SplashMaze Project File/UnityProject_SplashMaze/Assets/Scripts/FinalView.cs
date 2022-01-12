using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FinalView : MonoBehaviour
{
    public GameObject Rabbit; // 0
    public GameObject Cat; // 1
    public GameObject Bird; // 2


    public int selection;

    // Update is called once per frame
    void Start()
    {
        selection = ClickAnimals.Animals.selection;
        if (selection == 0)
        {
            Rabbit.SetActive(true);
            Cat.SetActive(false);
            Bird.SetActive(false);
        }
        else if (selection == 1)
        {
            Rabbit.SetActive(false);
            Cat.SetActive(true);
            Bird.SetActive(false);
        }
        else if (selection == 2)
        {
            Rabbit.SetActive(false);
            Cat.SetActive(false);
            Bird.SetActive(true);

        }
    }
}