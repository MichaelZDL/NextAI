using UnityEngine;
using System.Collections;

public class AIAttack : MonoBehaviour {

    public float AttackAbility =10;
    public float AttackTimeInterval = 1f;
    private float timer;
	// Use this for initialization
	void Start () {
	
	}


    public void OnTriggerStay(Collider col) {
        if (col.tag == "Enemy") {
            timer += Time.deltaTime;
            if (timer >= AttackTimeInterval) {
                timer -= AttackTimeInterval;
                col.GetComponent<Health>().TakeDamage(AttackAbility);
            }
        }
    }
}
