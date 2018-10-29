using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;
using System.IO; 

public class WritingOnTextFile : MonoBehaviour {

	string readPath; 

	public TextAsset asset; 
	//public string file; 

	public List<string> stringList = new List<string>(); 

	// Use this for initialization
	void Start () {
		readPath = Application.dataPath + "/index.html"; 

		readFile (readPath); 
		writeFile (readPath, asset); 
	}
	
	// Update is called once per frame
	void readFile(string filePath){
		StreamReader reader = new StreamReader (filePath); 

		while (!reader.EndOfStream) {
			string line = reader.ReadLine(); 
			stringList.Add (line); 
		}

		reader.Close (); 
	}

	void writeFile(string filePath, TextAsset asset){
		StreamWriter writer = new StreamWriter (filePath, true); 
		writer.WriteLine ("<h1>student has a question</h1>"); 
		writer.Close (); 

		//reimport file to upload
		//AssetDatabase.ImportAsset(filePath); 
		asset = Resources.Load ("index") as TextAsset; 
	}
}
