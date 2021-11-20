
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelGeneretor : MonoBehaviour {

	[SerializeField] private GameObject platformPrefab;
	[SerializeField] private Transform target;
	[SerializeField] private GameObject losePanel;

	private float levelWidth = 3f;
	private float minY = .5f;
	private float maxY = 3f;
	Vector3 spawnPosition = new Vector3(0,8,0);
	private GameObject[] platforms;

	void Update () {
		if(target != null){
			destroyPlatforms();
			createPlatforms();
		}
	}

	private void createPlatforms(){
		if(target.position.y > transform.position.y){
			for(int i = 0; i<6 ; i ++){
				spawnPosition.y += Random.Range(minY, maxY);
				spawnPosition.x = Random.Range(-levelWidth, levelWidth);
				Instantiate(platformPrefab, spawnPosition, Quaternion.identity);
			}
            Vector3 newPos = new Vector3(transform.position.x, target.position.y+5, transform.position.z);
            transform.position = newPos;			
        }
	}

	private void destroyPlatforms(){
		platforms = GameObject.FindGameObjectsWithTag("Platform");
		foreach(GameObject i in platforms){
			if(i.transform.position.y < target.position.y -7){
				Destroy(i);
			}
		}
	}

	public void StarAgain(){
		SceneManager.LoadScene(0);
	}
}
