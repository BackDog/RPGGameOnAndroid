using UnityEngine;
using System.Collections;

public class MapController2 : MonoBehaviour {
	public GameObject wall_1;
	public GameObject wall_2;
	public GameObject wall_3;
	public GameObject wall_4;
	public GameObject wall_5;
	public GameObject wall_6;
	public GameObject wall_7;
	public GameObject wall_8;
	public GameObject wall_9;
	public GameObject wall_10;
	public GameObject wall_11;
	public GameObject wall_12;
	public GameObject wall_13;
	public GameObject wall_14;
	
	string[] s;
	
	// Use this for initialization
	void Start () {
		s= new string[14];
		s[0]="0 0 b b b b b b b b b b b b b b b b b b b b b b b b b b b b b b b b b b b 0 0";
		s[1]="0 8                                                                       7 0";
		s[2]="0 8                                                                       7 0";
		s[3]="0 8                                                                       7 0";
		s[4]="0 8                                                                       7 0";
		s[5]="0 8                             4 5 5 5 6                                 7 0";
		s[6]="0 8                       4 5 6           4 6                             7 0";
		s[7]="0 8               1 2 3                       4 6                         7 0";
		s[8]="0 8             1 9 0 8                           4 6                     7 0";
		s[9]="0 8           1 9 0 0 8                                                   7 0";
		s[10]="0 d 2 2 2 2 2 9 0 0 0 d 2 2 2 2 2 2 2 2 2 2 2 2 2 2 2 2 2 2 2 2 2 2 2 2 2 9 0";		
		s[11]="0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0";	
		s[12]="0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0";	
		s[13]="0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0";


		loadMap ();
		
	}
	void loadMap(){
		for (int i = 0; i < s.Length; i++) {
			char[] ss = s [i].ToCharArray ();
			for (int k = 0; k < ss.Length; k++) {
				if(ss[k]=='0'){
					Instantiate (wall_1, transform.position + (new Vector3 (k/2-5, -i+5, 0)), Quaternion.Euler (0, 0, 0));
					
				};
				if(ss[k]=='1'){
					Instantiate (wall_2, transform.position + (new Vector3 (k/2-5, -i+5, 0)), Quaternion.Euler (0, 0, 0));
					
				};
				if(ss[k]=='2'){
					Instantiate (wall_3, transform.position + (new Vector3 (k/2-5, -i+5, 0)), Quaternion.Euler (0, 0, 0));
					
				};
				if(ss[k]=='3'){
					Instantiate (wall_4, transform.position + (new Vector3 (k/2-5, -i+5, 0)), Quaternion.Euler (0, 0, 0));
					
				};
				if(ss[k]=='4'){
					Instantiate (wall_5, transform.position + (new Vector3 (k/2-5, -i+5, 0)), Quaternion.Euler (0, 0, 0));
					
				};
				if(ss[k]=='5'){
					Instantiate (wall_6, transform.position + (new Vector3 (k/2-5, -i+5, 0)), Quaternion.Euler (0, 0, 0));
					
				};
				if(ss[k]=='6'){
					Instantiate (wall_7, transform.position + (new Vector3 (k/2-5, -i+5, 0)), Quaternion.Euler (0, 0, 0));
					
				};
				if(ss[k]=='7'){
					Instantiate (wall_8, transform.position + (new Vector3 (k/2-5, -i+5, 0)), Quaternion.Euler (0, 0, 0));
					
				};
				if(ss[k]=='8'){
					Instantiate (wall_9, transform.position + (new Vector3 (k/2-5, -i+5, 0)), Quaternion.Euler (0, 0, 0));
					
				};
				if(ss[k]=='9'){
					Instantiate (wall_10, transform.position + (new Vector3 (k/2-5, -i+5, 0)), Quaternion.Euler (0, 0, 0));
					
				};
				if(ss[k]=='d'){
					Instantiate (wall_11, transform.position + (new Vector3 (k/2-5, -i+5, 0)), Quaternion.Euler (0, 0, 0));
					
				};
				if(ss[k]=='a'){
					Instantiate (wall_12, transform.position + (new Vector3 (k/2-5, -i+5, 0)), Quaternion.Euler (0, 0, 0));
					
				};
				if(ss[k]=='b'){
					Instantiate (wall_13, transform.position + (new Vector3 (k/2-5, -i+5, 0)), Quaternion.Euler (0, 0, 0));
					
				};
				if(ss[k]=='c'){
					Instantiate (wall_14, transform.position + (new Vector3 (k/2-5, -i+5, 0)), Quaternion.Euler (0, 0, 0));
					
				};
			}
		}
	}
	// Update is called once per frame
	void Update () {
		
	}
}

