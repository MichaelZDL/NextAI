using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class Health : MonoBehaviour {

    public float hp = 100;
    public Slider hpSlider;
    public 
	// Use this for initialization
	void Start () {
        hpSlider.value = hp;
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    public void TakeDamage(float Dmg) {
        hp -= Dmg;
        hpSlider.value = hp; 
    }
}
