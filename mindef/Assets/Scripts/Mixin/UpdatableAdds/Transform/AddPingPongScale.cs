﻿using UnityEngine;

public class AddPingPongScale : AddTransform 
{
	[SerializeField]
	private int changeIteration = 15;

	public override void Awake ()
	{
		base.Awake ();
		cachedValue = myTransform.localScale;
	}

	int count;
	bool turned;
	public override void Action ()
	{
		if (turned)
			plusTheValue ();
		else
			minusTheValue ();
	}

	void plusTheValue(){
		cachedValue += speed;
		myTransform.localScale = cachedValue;
		count--;
		if (count == 0)
			turned = false;
	}

	void minusTheValue(){
		cachedValue -= speed;
		myTransform.localScale = cachedValue;
		count++;
		if (count == changeIteration)
			turned = true;
	}
}
