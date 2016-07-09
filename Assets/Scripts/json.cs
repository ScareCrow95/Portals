using UnityEngine;
using System.Collections;
using System;
//using System.Text;
//using System.Reflection;
//SADASDAS
//using JsonFX.Json;
//using Newtonsoft.Json.Linq.JObject;
using System.Collections.Generic;
using System.Linq;
using System.Text;
//using System.Threading.Tasks;
//Request library
using System.Net;
using System.IO;

public class json : MonoBehaviour {
	public float lat;
	public float lng;

	// Use this for initialization
	void Start () {
		string url = "http://api.sunrise-sunset.org/json?lat="+ lat +"&lng="+ lng;
		//string url = "http://api.sunrise-sunset.org/json?lat=36.7201600&lng=-4.4203400";
		print(get(url));
		//JsonObject user = (JsonObject)JsonObject.Load(get(url));
		//JObject o = JObject.Parse(get(url));
		//List jsonObject = JsonReader.Deserialize>(get(url));
		//	string sunset = jsonObject.
		//	string result = jsonObject.Find(x => x.GetId() == "sunset");
		//	print(result(get(url)));//this is the time bc
		result(get(url));
	}
	void result(string query)
	{
		int length = (int)query.Length;
		print(length);
		int a=0,i,j=0;
		string Time = "";
		for ( i = 0; i<length; i++){
			//	print ("This is : "+ query.Substring(i,1));
			if(query.Substring(i,1)=="\"")
				a++;
			if (a == 9){
				if(j==0){
					j++;
					continue;}
				Time += query.Substring(i,1);}
			else if(a == 10)
				break;
		}

		print (Time);
		//print(query.Substring(0,1));
		//char a[] = query.ToCharArray();
		//print (a[0]);
		//return time;
	}
	// Update is called once per frame
	void Update () {

	}
	protected string get(string url)
	{
		try
		{
			string rt;

			WebRequest request = WebRequest.Create(url);

			WebResponse response = request.GetResponse();

			Stream dataStream = response.GetResponseStream();

			StreamReader reader = new StreamReader(dataStream);

			rt = reader.ReadToEnd();

			Console.WriteLine(rt);

			reader.Close();
			response.Close();

			return rt;
		}
		catch(Exception ex)
		{
			return "Error: " + ex.Message;
		}
	}


}