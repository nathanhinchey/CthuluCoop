using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class sliderBehaviorScript : MonoBehaviour {


	private float money;

	public Slider Finance;

	public void setFinance()
	{
		Finance.value = money;
		Debug.Log("money = " + money);
	}
}
