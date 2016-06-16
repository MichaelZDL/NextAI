using UnityEngine;
using System.Collections;

public class AIAttack : MonoBehaviour {

    public GameObject shellPrefabs;
    public float AttackAbility =10;
    public float AttackTimeInterval = 1f;
    private float timer;
    private Transform shootPoint;
    
	// Use this for initialization
	void Start () {
        shootPoint = transform.Find("ShootPoint");
	}


    public void OnTriggerStay(Collider col) {
        if (col.tag == "Enemy") {
            timer += Time.deltaTime;
            if (timer >= AttackTimeInterval) {
                timer -= AttackTimeInterval;
                GameObject.Instantiate(shellPrefabs, shootPoint.position, shootPoint.rotation);

                //col.GetComponent<Health>().TakeDamage(AttackAbility);
            }
        }
    }
}
