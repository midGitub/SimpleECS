﻿using UnityEngine;
using System.Collections;
using System.Collections.Generic;

[AddComponentMenu("EntitySystem/SpinSystem")]
public class SpinSystem : EntitySystem<SpinComponent>, UpdateSystem
{
	public override void UpdateSystem (SpinComponent spin)
	{
		spin.timeSpinning += Time.deltaTime;

		spin.transform.eulerAngles += new Vector3(0,0, spin.spinSpeed);

		if (spin.maxSpinTime < spin.timeSpinning)
		{
			spin.enabled = false;
		}
	}
}
