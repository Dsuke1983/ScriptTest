using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Boss {
	private int hp = 100;
	private int mp = 53;
	private int power = 25;

	public void Attack(){
		Debug.Log (this.power + "のダメージを与えた");
	}

	public void Magic(string m){
		switch (m) {
		case "ファイヤー":
			if (mp >= 5) {
				this.mp -= 5;
				Debug.Log (m + "を唱えた。残りMPは" + mp);
			} else {
				Debug.Log ("MPが足りないため魔法が使えない。残りMPは" + mp);
			}
			break;

		case "サンダー":
			if (mp >= 5) {
				this.mp -= 5;
				Debug.Log (m + "を唱えた。残りMPは" + mp);
			} else {
				Debug.Log ("MPが足りないため魔法が使えない。残りMPは" + mp);
			}
			break;

		default:
			break;
		}

	}

	public void Defence(int damage){
		Debug.Log (damage + "のダメージを受けた");
		this.hp -= damage;
	}

}


public class Test : MonoBehaviour {

	// Use this for initialization
	void Start () {

		int[] point = { 10, 20, 30, 40, 50 };

		for (int i = 0; i < 5; i++) {
			Debug.Log (point [i]);
		}

		for (int i = 4; i >= 0; i--) {
			Debug.Log (point [i]);
		}

		Boss lastboss = new Boss ();

		Debug.Log ("1回目");
		lastboss.Magic ("サンダー");

		//10回分呼び出す
		for (int i = 0; i < 10; i++) {
			Debug.Log (i + 2 + "回目");
			lastboss.Magic ("サンダー");
		}

	}
	
	// Update is called once per frame
	void Update () {
		
	}

}

