using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class sliderBehaviorScript : MonoBehaviour {

	private bool moneyIsDecreasing = true;
	private bool mindIsDecreasing = true;
	private bool bodyIsDecreasing = true;

	public float moneyEnergy = 100f;

	public Slider Finance;

	public float mindEnergy = 100f;

	public Slider mind;

	public float bodyEnergy = 100f;

	public Slider body;

	void Update ()
	{
		if (moneyIsDecreasing == true) 
		{
			moneyEnergy -= Time.deltaTime;
		}

		if (mindIsDecreasing == true) 
		{
			mindEnergy -= Time.deltaTime;
		}

		if (bodyIsDecreasing == true) 
		{
			bodyEnergy -= Time.deltaTime;
		}

		setFinance ();
		setMind ();
		setBody ();
	}

	public void setFinance()
	{
		Finance.value = moneyEnergy;
		Debug.Log("money = " + moneyEnergy);
	}

	public void setMind()
	{
		mind.value = mindEnergy;
		Debug.Log("mind = " + mindEnergy);
	}

	public void setBody()
	{
		body.value = bodyEnergy;
		Debug.Log("body = " + bodyEnergy);
	}


}
