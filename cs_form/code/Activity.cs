﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file will be lost if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public abstract class Activity
{
	public virtual string description
	{
		get;
		set;
	}

	public virtual string type
	{
		get;
		set;
	}

	public virtual IEnumerable<Astronaut> l_astronaut
	{
		get;
		set;
	}

	public virtual Place Place
	{
		get;
		set;
	}

	public virtual TimeUnit End
	{
		get;
		set;
	}

	public virtual TimeUnit Start
	{
		get;
		set;
	}

	public Activity(string type)
	{
	}

}

