using UnityEngine;
using System.Collections;

public class Spawnpoint : MonoBehaviour {
	public GameObject debri; //우주쓰레기 프리팹
	public float interval=1f; //쓰레기 발생간격(시간) 
	// Use this for initialization
	void Start () {
		StartCoroutine ("SpawnDebri");//코루틴의 시작 
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	IEnumerator SpawnDebri(){
				while (true) {
						Instantiate (debri, transform.position, Quaternion.identity);
						//Instantiate(원본, 좌표, 각도);
						yield return new WaitForSeconds (interval);
				}
		}
}

