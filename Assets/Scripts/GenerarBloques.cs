using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class GenerarBloques : MonoBehaviour {
    [SerializeField]
     public   int bricksToSpawn = 60;
    [SerializeField]
    public GameObject[]bricks;
 
      List<GameObject>bricksList = new List<GameObject>(); // declare a new list
 
 
 void Start()
    {
        PopulateBricksList();

        ChooseRandomBricks();
    }


    void PopulateBricksList()
    {
        // declare a new list
        bricksList = new List< GameObject> ();

        // get the length of the built-in array
        int  totalBricks = bricks.Length;

        // add each brick to the brickList
        for (int i = 0; i < totalBricks; i++)
        {
            bricksList.Add(bricks[i]);
        }
    }


    void ChooseRandomBricks()
    {
        // choose a brick from the bricksList
        for (int i = 0; i < bricksToSpawn; i++)
        {
            // find the current length of the bricksList
             int  bricksRemaining = bricksList.Count;

            // get a random number
              int rndChoice = Random.Range(0, bricksRemaining - 1);

            // instantiate that chosen brick
            Object cloneBrick = Instantiate(bricksList[rndChoice], transform.position, transform.rotation);

            // remove that brick from the list
            bricksList.RemoveAt(rndChoice);
        }
    }

}
