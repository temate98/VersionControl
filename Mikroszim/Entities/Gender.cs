﻿using System;

public class Gender
{
	public Gender()
	{


	}

	public enum Gender
	{
		Male = 1,
		Female = 2
	}

	// Példa enumerációs változók használatára
	Gender ádámNeme = Gender.Male;
	Gender évaNeme = (Gender)2;

	if (ádámNeme == Gender.Male)
	{
		...
	}
}