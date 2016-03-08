using UnityEngine;
using System.Collections;

public class SoltarBomba : MonoBehaviour {

    public bool puedeSoltar = true;
    public GameObject bombPrefab;
    public float cooldown = 40.0f;



    // Use this for initialization
    void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	    if(puedeSoltar && Input.GetKey(KeyCode.Space))
        {
            GameObject nuevaBomba = Instantiate (bombPrefab) as GameObject;
            nuevaBomba.transform.localPosition = transform.localPosition + (transform.right / 5f);
            StartCoroutine(SetCooldown());

        }





    }
    IEnumerator SetCooldown()
    {
        puedeSoltar = false;
        yield return new WaitForSeconds(cooldown);
       // if (!respawn.enabled)
            puedeSoltar = true;
    }
}
